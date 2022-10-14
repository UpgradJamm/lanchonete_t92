using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lanchonete_T92
{
    public partial class LoginView : Form
    {
        public LoginView()
        {
            // Construtor da tela, excutado automaticamente ANTES da tela carregar, enquanto está sendo montada.

            // escreve o texto no Console (saida)
            Debug.WriteLine("A tela foi montada.");

            InitializeComponent();

            // chamamos a função/método da classe LoginController.cs
            // Instanciar um objeto da classe
            LoginController loginC = new LoginController( this );

            

        }


        /*
         
            Os códigos abaixo são criados quando clicamos duas vezes em um componente da tela.

        private void LoginView_Load(object sender, EventArgs e)
        {
            // Construtor é a função que executa automaticamente no CARREGAMENTO da tela
            Debug.WriteLine("A tela foi carregada/exibida.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Construtor do botão, só é executado qando o botão é CLICADO
            Debug.WriteLine("Botão Clicado.");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Construtor do pictureBox, só é executado qando o pictureBox é CLICADO
            Debug.WriteLine("Clicou na imagem.");
        }
        */
    }
}
