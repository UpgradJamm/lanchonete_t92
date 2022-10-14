/*
    Classe que aplica as alterações, chamadas e controles da tela de Login (LoginView.cs)
*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;


namespace Lanchonete_T92
{
    public class LoginController
    {
        // Atributos 
        private Form form;
        private int temaAtual = 1;
        
        // Método Construtor - é executado automaticamente ao criar um objeto da classe
        public LoginController( Form form )
        {
            //.WriteLine(" O objeto foi criado e o construtor disparado!");


            this.form = form;// Enviando a form para a classe

            ConfiguraLoginView();

            MudaCores();
        }

        /// <summary>
        /// Configura o tamanho e cor da tela de login
        /// </summary>
        private void ConfiguraLoginView()
        {
            
            // Mudando a cor da tela LoginView
            form.BackColor = Color.FromArgb(Config.coresFundo[temaAtual, 0], Config.coresFundo[temaAtual, 1], Config.coresFundo[temaAtual, 2]);

            // Mudando as dimensões da tela de acordo com o monitor
            int LarguraTela = Convert.ToInt32 (Config.tamanhoMonitor[0] * 0.6f);
            int alturaTela = Convert.ToInt32(Config.tamanhoMonitor[1] * 0.56f);


            form.Size = new Size(LarguraTela,
                alturaTela);

            // Devolvendo ao centro da tela
            form.StartPosition = FormStartPosition.CenterScreen;
        }
        private void MudaCores()
        {
            // Criamos um vetor de objetos para guardar os componentes
            // Vetores podem se adicionados, removidos, reoordenados
            List<Control> componentes = new List<Control>();
            // Lopp que se repete para cada componente encontrado
            // O objeto controles só existe dentro do laço de repetição foreach
            foreach ( Control controles in form.Controls)
            {
                if( controles is Label)
                {
                    //componentes.Add(controles);
                    // Criamos um botão (objeto);
                    Label rotulo = new Label();
                    // Controles é Control / btn Button 
                    rotulo = (Label) controles;
                    rotulo.ForeColor = Color.Red;
                }
                
            }
            // MessageBox abre uma caixa de mensagem para o usuário
            MessageBox.Show("Foram encontrados " + componentes.Count + " item");
        }
    }
}