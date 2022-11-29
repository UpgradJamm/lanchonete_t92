using System;
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
            CriaTextBox( "nomeTxt", 0.025f, margemTopoLinha1, 0.178f );
            CriaTextBox( "sobreNomeTxt", 0.021f, margemTopoLinha1, 0.178f );
            CriaTextBox( "cpfTxt", 0.021f, margemTopoLinha1, 0.115f );
            CriaTextBox( "nascimentoTxt", 0.021f, margemTopoLinha1, 0.115f );

            CriaTextBox( "cepTxt", 0.025f, margemTopoLinha2, 0.097f );
            CriaTextBox( "logradouroTxt", 0.022f, margemTopoLinha2, 0.195f );
            CriaTextBox( "numeroTxt", 0.022f, margemTopoLinha2, 0.066f );
            CriaTextBox( "complementoTxt", 0.022f, margemTopoLinha2, 0.083f );
            CriaTextBox( "bairroTxt", 0.022f, margemTopoLinha2, 0.083f );
            
            CriaBotao("maisEnderecoBtn", 0.02f, 0.02f, 0.02f, 0.04f);

            CriaTextBox( "tipoTxt", 0.025f, margemTopoLinha2, 0.095f );
            CriaTextBox( "telefoneTxt", 0.022f, margemTopoLinha2, 0.195f );
            
            CriaBotao( "maisFoneBtn", 0.02f, 0.02f, 0.02f, 0.04f );

            CriaFoto("foto", 0.09f, 0.125f, 0.045f, 0.05f);

            CriaBotao("adicionaFoto", 0.09f, 0.125f, 0.025f, 0.05f);

            CriaTextBox("tipo2Txt", 0.025f, 0f, 0.095f);
            CriaTextBox("emailTxt", 0.022f, 0f, 0.195f);
            
            CriaBotao("maisEmailBtn", 0.02f, 0.02f, 0.02f, 0f );

            CriaTabela();

        }

        int CalculaTamanho( float tamanho )
        {
            int novoTamanho = Convert.ToInt32( Config.tamanhoTela[0] * tamanho );

            return novoTamanho;
        }

        void CriaTextBox( string name, float esq, float topo, float larg )
        {
            TextBox campo = new TextBox();
            campo.BackColor = Color.FromArgb( 254, 239, 227 );
            campo.Name = name;
            campo.Font = new Font( FontFamily.GenericSansSerif, 14 );
            //campo.BorderStyle = BorderStyle.None;

            form.Controls.Find("flowLayoutPanel1", true)[0].Controls.Add( campo );

            // esquerda, cima, direita, embaixo
            form.Controls.Find( name, true)[0].Margin = new Padding(CalculaTamanho( esq ), CalculaTamanho( topo ), 0, 0);
            form.Controls.Find( name, true)[0].Width = CalculaTamanho( larg );

        }

        void CriaBotao( string nome, float larg, float alt, float esq, float topo )
        {
            Button botao = new Button();
            botao.Name = nome;
            botao.Size = new Size( CalculaTamanho( larg ), CalculaTamanho( alt ) );
            botao.Margin = new Padding( CalculaTamanho( esq ), CalculaTamanho( topo), 0, 0 );

            form.Controls.Find("flowLayoutPanel1", true)[0].Controls.Add(botao);

        }

        void CriaFoto( string nome, float larg, float alt, float esq, float topo )
        {
            PictureBox foto = new PictureBox();
            foto.Name = nome;
            foto.Size = new Size( CalculaTamanho( larg ), CalculaTamanho( alt ) );
            foto.Margin = new Padding( CalculaTamanho(esq), CalculaTamanho(topo), 0, 0 );
            foto.BackColor = Color.Red;

            form.Controls.Find("flowLayoutPanel1", true)[0].Controls.Add(foto);
        }
        
        void CriaTabela()
        {
            /* 
              DatagridView é um componente que serve para mostrar dados em formato tabualr.
              
              é uma matriz, ou seja um vetor multidimensional.
              
              string[] nomes = { "nome1", "nome2"};// Vetor tem apens uma dimensão
            
            */

            DataGridView tabela = new DataGridView();
            tabela.Name = "tabelaUsuarios";
            tabela.Width = CalculaTamanho(0.5f);

            // A tabela é alimentada por um vetor
            //string[] nomes = { "Felipe", "nome2", "nome3", "nome4" };

            // Adicionando a coluna
            //tabela.Columns.Add("nome", "nome2");

            // Colocando as colunas na ordem desejada
            //tabela.Columns[0].DisplayIndex = 0;
            
            // Adicionas a coluna com os dados
            //tabela.Rows.Add(nomes);

            // Adicionando um DataSource - os dados de um Select do BD 
            tabela.DataSource = nomes;


            // Fazendo a SELECT no BD
            string SQL = "SELECT * FROM usuarios";

            // nomeando as colunas do DataGridView
            //tabela.Columns[0].Name = "Nome";

            form.Controls.Find("flowLayoutPanel1", true)[0].Controls.Add(tabela);

            // Para rodar o cmando se a conexão não existe é criada
            if(conexao == null)
            {
                ConectaBanco();
            }
            try
            {
                // Monta o comando SQL
                MySqlCommand roda = new MySqlCommand(SQL, conexao);
                // Roda o comando montado
                roda.ExecuteNonQuery();//Executa sem trazer dados do BD
            }
            catch(Exception erro)
            {
                MessageBox
            }
        }
    }

}