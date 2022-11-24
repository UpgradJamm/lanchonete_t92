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

            MessageBoxButtons botoes = MessageBoxButtons.YesNoCancel;

            /*MostraMensagem(" texto exibido ", " título da caixinha", botoes );*/

            /*ConectaBanco();*/

            PosicionaCampos(); // Posiciona os TextBoxes
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
            float margemTopoLinha1 = 0.092f;
            float margemTopoLinha2 = 0.042f;
            float margemTopoLinha3 = 0.045f;
            
            // Manda Criar o componente 
            CriaTextBox("nomeTxt", 0.025f, margemTopoLinha1, 0.175f);
            CriaTextBox("sobrenomeTxt", 0.025f, margemTopoLinha1, 0.178f);
            CriaTextBox("cpfTxt", 0.020f, margemTopoLinha1, 0.117f);
            CriaTextBox("nascimentoTxt", 0.018f, margemTopoLinha1, 0.117f);

            CriaTextBox("cepTxt", 0.025f, margemTopoLinha2, 0.097f);
            CriaTextBox("logradouroTxt", 0.022f, margemTopoLinha2, 0.195f);
            CriaTextBox("numeroTxt", 0.022f, margemTopoLinha2, 0.066f);
            CriaTextBox("complementoTxt", 0.022f, margemTopoLinha2, 0.085f);
            CriaTextBox("bairroTxt", 0.022f, margemTopoLinha2, 0.087f);

            CriaBotao("maisEnderecoBtn");

            CriaTextBox("tipoTxt", 0.026f, margemTopoLinha3, 0.095f);
            CriaTextBox("telefoneTxt", 0.022f, margemTopoLinha3, 0.195f);

            //CriaTextBox("tipo1Txt", 0.026f, margemTopoLinha3, 0.095f);
            //CriaTextBox("emailTxt", 0.022f, margemTopoLinha3, 0.195f);
            CriaBotao("maisEmailBtn");
        }

        int CalculaTamanho( float tamanho )
        {
            int novoTamanho = Convert.ToInt32(Config.tamanhoTela[0] * tamanho);

            return novoTamanho;
        }
    
        void CriaTextBox(string name, float esquerda, float topo, float larg )
        {
            TextBox campo = new TextBox();
            campo.BackColor = Color.FromArgb(254, 239, 227);
            campo.Name = name;
            campo.Font = new Font(FontFamily.GenericSansSerif, 14);
            campo.BorderStyle = BorderStyle.None;

            form.Controls.Find("FlowLayoutPanel1", true)[0].Controls.Add( campo );

            // esquerda, cima, direita, embaixo
            form.Controls.Find(name, true)[0].Margin = new Padding
                (CalculaTamanho( esquerda ),
                CalculaTamanho(topo),
                0,
                0);

            form.Controls.Find( name , true)[0].Width = CalculaTamanho( larg );
        }
    
        void CriaBotao( string name )
        {
            Button botao = new Button();

            form.Controls.Find("FlowLayoutPanel1", true)[0].Controls.Add(botao);

            form.Controls.Find(name, true)[0].Margin = new Padding
               (CalculaTamanho(0.01f),
               CalculaTamanho(0.04f),
               0,
               0);

            form.Controls.Find(name, true)[0].Size = new Size( CalculaTamanho(0.05f), CalculaTamanho(0.05f));
        }
    
    }

}