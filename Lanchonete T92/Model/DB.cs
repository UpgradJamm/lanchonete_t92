// Importando as bibliotecas do MySQL instaladas com o NuGet (Projeto > Gerenciar Pacotes do NuGet )
using MySql.Data.MySqlClient;
using System;
using static System.Net.Mime.MediaTypeNames;

namespace Lanchonete_T92
{
    class DB
    {
        // Propriedade que armazena nossa conexão com BD
        private MySqlConnection conn;

        public void ConectaBanco()
        {
            //cria um objeto da classe de conexão
            try
            { 
                MySqlConnection conexao = new MySqlConnection( 
                "Server=" + Config.servidorBD +" ; " +
                "Port=" + Config.portaBD + "; " +
                "Database=" + Config.bancoBD +"; " +
                "Uid=" + Config.usuarioBD +"; " +
                "Pwd=" + Config.senhaBD );

                this.conn = conexao;
            }
            catch( Exception erro)
            {
                // Passando um texto para o label que está na tela
                Application.OpenForms["UsuariosView"].Controls.Find("label1", true)[0].Text = "Conectado ao Banco";
            }
        }

        void BuscaDados()
        {

        }

        void InsereDados()
        {

        }

        void AtualizaDados()
        {

        }

        void ApagaDados()
        {

        }

    }
}
