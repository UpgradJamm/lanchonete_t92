﻿// Importando as bibliotecas do MySQL instaladas com o NuGet (Projeto > Gerenciar Pacotes do NuGet )
using MySql.Data.MySqlClient;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lanchonete_T92
{
    class DB
    {
        // Propriedade que armazena nossa conexão com BD
        private MySqlConnection conn = null;

        // Método Construtor da Classe que é executado automaticamente ao criar um objeto desta classe
        public DB()
        {
            // se não há uma conexão aberta, abra
            if( this.conn == null )
            { 
                ConectaBanco();
            }
        }

        void ConectaBanco()
        {
            //cria um objeto da classe de conexão
            try
            {
                MySqlConnection conexao = new MySqlConnection("Persist Security info = false; Server= " + Config.servidorBD +
                    ";Port=" + Config.portaBD + ";Database=" + Config.bancoBD +
                    ";uid=" + Config.usuarioBD +
                    ";password=" + Config.senhaBD);

                // Abrimos a conexão
                conexao.Open();

                // enviando a conexão para a propriedade de classe (disponível para todos os métodos
                this.conn = conexao;
            }
            catch( Exception erro )
            {
                // no objeto erro temos todas as mensagens retornadas pelo mysql caso encontre haja problema de conexão e deve ser convertido para string para ser escrito no MessageBox()
                MessageBox.Show("Não foi possível conectar ao banco! Informe o erro: " + erro.ToString() );
                
            }

        }

        MySqlCommand BuscaDados()
        {
            string comandoSQL = "SELECT * FROM usuarios";

            // rodar o comando SQL no BD
            MySqlCommand roda = RodaSQL(comandoSQL);

            return roda;

        }

        public void InsereDados( string usuario, string senha )
        {
            string comandoSQL = "INSERT INTO usuarios ( login, senha ) VALUES ( '"+ usuario +"' , '"+ senha +"' )";

            if ( RodaSQL(comandoSQL)  != null )
            {
                Debug.WriteLine("Dado Inserido");
            }
            else
            {
                Debug.WriteLine("Erro ao inserir");
            }

        }

        void AtualizaDados()
        {

        }

        void ApagaDados()
        {

        }

        MySqlCommand RodaSQL( string comandoSQL )
        {
            try
            {
                // prepara o comando 
                MySqlCommand roda = new MySqlCommand(comandoSQL, conn);


                // executa o comando
                roda.ExecuteNonQuery();

                conn.Close();

                // retorna o resultado do comando
                return roda;
            }
            catch( Exception erro )
            {
                MySqlCommand roda = new MySqlCommand();
                // retorna um objeto vazio em caso de erro
                return roda = null;

            }

        }

    }
}
