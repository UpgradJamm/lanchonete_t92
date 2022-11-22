using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data; // Importa as bibliotecas de acesso ao Mysql

namespace Lanchonete_T92
{
    class UsuariosController 
    {
        // criar atributos/propriedade
        Form form;

        // criar o construtor da classe
        public UsuariosController(Form form)
        {
            this.form = form;

            MessageBoxButtons botoes = MessageBoxButtons.YesNoCancel;
            
            MostraMensagem("Texto exibido", "título da caixinha", botoes);

            ConectaBanco();
        }
        void MostraMensagem (string mensagem, string titulo, MessageBoxButtons botoes )
        {
            MessageBox.Show(mensagem, titulo, botoes);


        }

        void ConectaBanco()
        {
            MySqlConnection conexao = new MySqlConnection("server=localhost;port=3306;database=lanchonete_t92;uid=root;password=");


            // Abre a conexao com o banco
            conexao.Open();

        }
        void ChamaCadastro( object objeto, EventArgs evento )
        {
           string usuario = form.Controls.Find("usuarioTxt", true)[0].Text;
           string senha = form.Controls.Find("senhaTxt", true)[0].Text;

            // Instanciamos a classe do banco de dados
            DB db = new DB();

            // Criptografamos a senha informada
            MySqlCommand senhaCriptografada = db.CriptografaSenha(senha);

            Debug.WriteLine( senhaCriptografada.ToString() );

            string campos = " login, senha ";
            string valores = " '" + usuario + "', '" + senha + "' ";
            string tabela = "usuarios";

            db.InsereDados(campos, valores, tabela);
            
        }

    }
}
