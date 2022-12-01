using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;// importação dos componentes de tela win
using MySql.Data; // importa as bibliotecas de acesso ao Mysql
using MySql.Data.MySqlClient;

namespace Lanchonete_T92
{

    class UsuariosController
    {
        Form form;// propriedade que armazena a tela UsuariosView

        MySqlConnection conexao = null;// armazena a conexão com o BD

        // método construtor, executado automaticamente 
        public UsuariosController( Form form )
        {
            this.form = form;

            //MessageBoxButtons botoes = MessageBoxButtons.YesNoCancel;

            //MostraMensagem(" texto exibido ", " título da caixinha", botoes );

            // ConectaBanco();

            PosicionaCampos(); // posiciona os TextBoxes

        }

        void MostraMensagem ( string mensagem, string titulo, MessageBoxButtons botoes )
        {

            MessageBox.Show( mensagem, titulo, botoes );
        }

        // conectar ao banco de dados
        void ConectaBanco()
        {
            // Quando nosso código pode gerar erro, por exemplo, por problemas de infra (internet, servidor fora do ar) temos que tratar o erro, impedindo que o programa feche usando o try/catch

            try
            {
                // objeto da classe de conexão com mysql
                MySqlConnection conexao = new MySqlConnection(" server=localhost;port=3306;database=lanchonete_t92;uid=root;password=");

                // Abre a conexao com o banco
                conexao.Open();

                // enviamos a conexão para a propriedade da classe, assim outros métodos podem usar a mesma conexão sem abrir uma nova.
                this.conexao = conexao;

            }
            catch( Exception erro )
            {
                MessageBox.Show( " Erro ao se conectar ao Banco de Dados. O erro foi: " + erro.ToString() );
            }

        }

        void PosicionaCampos()
        {
            float margemTopoLinha1 = 0.0915f;
            float margemTopoLinha2 = 0.042f;

            // manda criar o componente
            CriaTextBox( "nomeTxt", 0.025f, margemTopoLinha1, 0.178f, "flowLayoutPanel1" );
            CriaTextBox( "sobreNomeTxt", 0.021f, margemTopoLinha1, 0.178f , "flowLayoutPanel1");
            CriaTextBox( "cpfTxt", 0.021f, margemTopoLinha1, 0.115f, "flowLayoutPanel1");
            CriaTextBox( "nascimentoTxt", 0.021f, margemTopoLinha1, 0.115f, "flowLayoutPanel1");

            CriaTextBox( "cepTxt", 0.025f, margemTopoLinha2, 0.097f , "flowLayoutPanel1");
            CriaTextBox( "logradouroTxt", 0.022f, margemTopoLinha2, 0.195f, "flowLayoutPanel1");
            CriaTextBox( "numeroTxt", 0.022f, margemTopoLinha2, 0.066f, "flowLayoutPanel1");
            CriaTextBox( "complementoTxt", 0.022f, margemTopoLinha2, 0.083f, "flowLayoutPanel1");
            CriaTextBox( "bairroTxt", 0.022f, margemTopoLinha2, 0.083f, "flowLayoutPanel1");
            
            CriaBotao("maisEnderecoBtn", 0.02f, 0.02f, 0.02f, 0.04f, "flowLayoutPanel1");

            CriaTextBox( "tipoTxt", 0.025f, margemTopoLinha2, 0.095f, "flowLayoutPanel1");
            CriaTextBox( "telefoneTxt", 0.022f, margemTopoLinha2, 0.195f, "flowLayoutPanel1");
            
            CriaBotao( "maisFoneBtn", 0.02f, 0.02f, 0.02f, 0.04f, "flowLayoutPanel1");

            OrganizaCampos();

            CriaTextBox("tipo2Txt", 0.025f, 0.042f, 0.095f, "organiza");
            CriaTextBox("emailTxt", 0.022f, 0.042f, 0.195f, "organiza");
            CriaBotao("maisEmailBtn", 0.02f, 0.02f, 0.02f, 0.039f, "organiza");

            CriaFoto("foto", 0.09f, 0.125f, 0.044f, 0.0f, "organiza");

            CriaBotao("adicionaFoto", 0.09f, 0.125f, 0.025f, 0.0f, "organiza");
            

            CriaTabela();

        }

        int CalculaTamanho( float tamanho )
        {
            int novoTamanho = Convert.ToInt32( Config.tamanhoTela[0] * tamanho );

            return novoTamanho;
        }

        void CriaTextBox( string name, float esq, float topo, float larg, string onde)
        {
            TextBox campo = new TextBox();
            campo.BackColor = Color.FromArgb( 254, 239, 227 );
            campo.Name = name;
            campo.Font = new Font( FontFamily.GenericSansSerif, 14 );
            //campo.BorderStyle = BorderStyle.None;

            form.Controls.Find( onde , true)[0].Controls.Add( campo );

            // esquerda, cima, direita, embaixo
            form.Controls.Find( name, true)[0].Margin = new Padding(CalculaTamanho( esq ), CalculaTamanho( topo ), 0, 0);
            form.Controls.Find( name, true)[0].Width = CalculaTamanho( larg );

        }

        void CriaBotao( string nome, float larg, float alt, float esq, float topo, string onde)
        {
            Button botao = new Button();
            botao.Name = nome;
            botao.Size = new Size( CalculaTamanho( larg ), CalculaTamanho( alt ) );
            botao.Margin = new Padding( CalculaTamanho( esq ), CalculaTamanho( topo), 0, 0 );

            form.Controls.Find(onde, true)[0].Controls.Add(botao);

        }

        void CriaFoto( string nome, float larg, float alt, float esq, float topo, string onde)
        {
            PictureBox foto = new PictureBox();
            foto.Name = nome;
            foto.Size = new Size( CalculaTamanho( larg ), CalculaTamanho( alt ) );
            foto.Margin = new Padding( CalculaTamanho(esq), CalculaTamanho(topo), 0, 0 );
            foto.BackColor = Color.Red;

            form.Controls.Find( onde , true)[0].Controls.Add(foto);
        }

        void CriaTabela()
        {
            /* 
              DatagridView é um componente que serve para mostrar dados em formato tabular.
            
              É uma matriz, ou seja, um vetor multidimensional.
              
              string[] nomes = { "nome1", "nome2" };// vetor tem apenas uma dimensão - nomes[0] - nome1
              
            string [,] nomes = { { "nome1", "nome2" }, {"nome3", "nome4"} }; // nomes[1,0] - nome3
            
             */
            DataGridView tabela = new DataGridView();
            tabela.Name = "tabelaUsuarios";
            tabela.Width = CalculaTamanho(0.5f);
            tabela.Margin = new Padding(CalculaTamanho(0.025f), CalculaTamanho (0.037f),0,0 );

            // A tabela é alimentada por um vetor
            //string[] nomes = { "Felipe", "nome2", "nome3", "nome4" };

            // adicionando a coluna
            //tabela.Columns.Add("nome", "Nomes Funcionários");

            // Colocando as colunas na ordem desejada
            //tabela.Columns[0].DisplayIndex = 0;

            // adicionando a linhas com os dados
            //tabela.Rows.Add(nomes);

            // fazendo a SELECT no Banco
            string SQL = "SELECT usuarios.id_usuario, usuarios.login, enderecos.logradouro, telefones.telefone, emails.email FROM usuarios INNER JOIN enderecos ON usuarios.id_usuario = enderecos.usuarios_id_usuario INNER JOIN telefones ON usuarios.id_usuario = telefones.usuarios_id_usuario INNER JOIN emails ON usuarios.id_usuario = emails.usuarios_id_usuario ORDER BY id_usuario DESC";

            // para rodar o comando se a conexão não existe é criada
            if( conexao == null )
            {
                ConectaBanco();
            }
            
            try
            {
                // monta o comando SQL
                //MySqlCommand roda = new MySqlCommand(SQL, conexao);
                // roda o comando montado

                //roda.ExecuteNonQuery();// executa sem trazer dados do BD (INSERT, UPDATE, DELETE)

                // para extrairmos os dados da busca usamos os métodos:
                // .GetString() - para retornar string
                // .GetInt() - inteiros
                // .GetBool() - verdadeiro/falso
                // .GetFloat() - traz um decimal

                // cria um objeto adaptador para o retorno do banco e a tabela
                MySqlDataAdapter adaptador = new MySqlDataAdapter( SQL,conexao );

                // DataSet que aplica o resultado na tabela
                DataSet dados = new DataSet();

                // criando o DataMember
                tabela.DataMember = "funcionarios";

                // executa o comando no banco
                adaptador.Fill(dados, "funcionarios");

                // a tabela monta automaticamente as colunas
                tabela.AutoGenerateColumns = true;

                // colocando os dados na tabela
                tabela.DataSource = dados;

            }
            catch( Exception erro)
            {
                MessageBox.Show("Erro ao buscar os dados." + erro.ToString() );
            }

            // Adicionando um DataSource - os dados de um Select do BD
            //tabela.DataSource = nomes;

            // nomeando as colunas do DataGridView
            //tabela.Columns[0].Name = "Nome";

            form.Controls.Find("flowLayoutPanel1", true)[0].Controls.Add(tabela);
        }
        void OrganizaCampos()
        {
            FlowLayoutPanel organiza = new FlowLayoutPanel();
            organiza.Name = "organiza";
            organiza.FlowDirection = FlowDirection.LeftToRight;

            organiza.Width = CalculaTamanho(0.7f);
            organiza.Height = CalculaTamanho(0.1f);

            organiza.Margin = new Padding(0, CalculaTamanho(0.0f), 0, 0);

            //organiza.BackColor = Color.Green;

            form.Controls.Find("flowLayoutPanel1", true)[0].Controls.Add(organiza);
        }

    }

}