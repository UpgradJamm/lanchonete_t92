using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lanchonete_T92
{
    class PrincipalController
    {
        private Form form;
        private int largImagem;

        // Construtor da classe que recebe a tela a ser editada e envia para a propriedade da tela
        public PrincipalController( Form form )
        {
            this.form = form;

            FormataTela();
            CriaBotoes();
            CriaPainelLateral();
            CriaLogo();

            // Listeners (ouvintes) dos botões da tela
            // O objeto deve ter um .Name para poder ser programado
            // .Click - clique sobre o elemento 
            // .MouseHover - mouse sobre o elemento
            // .MouseLeave - mouse sair de cima do elemento
            // .MouseMove - quando o mouse se movimenta sobre o elemento
            // .DoubleClick - clique duplo sobre o elemento
            // .MouseDown - mouse pressionado sobre o elemento

            form.Controls.Find("sairBtn", true)[0].Click += FazerLogOFF;
        }

        void FormataTela()
        {
            // inicia a tela em tela cheia (maximizado)
            form.WindowState = FormWindowState.Maximized;

            // Removendo a barra de título Win
            form.FormBorderStyle = FormBorderStyle.None;

            // Colocando a cor de fundo do tema atual
            form.BackColor = Color.FromArgb( Config.corFundo[ Config.tema, Config.tema ], Config.corFundo[Config.tema,1], Config.corFundo[Config.tema,2] );
        }

        void CriaPainelLateral()
        {
            PictureBox imagemLateral = new PictureBox();// cria o objeto (componente)

            this.largImagem = Convert.ToInt32( Config.tamanhoTela[0] * 0.3f );

            imagemLateral.Size = new Size( largImagem , Config.tamanhoTela[1] );// tamanho
            imagemLateral.BackgroundImage = Image.FromFile( Config.CaminhosImagens("lateral") ) ;// carrega a imagem

            imagemLateral.BackgroundImageLayout = ImageLayout.Zoom;// deixando a imagem responsiva

            imagemLateral.BackColor = Color.Transparent;// cor de fundo
            imagemLateral.Location = new Point(0, 0); // posição

            // Instanciá-lo na tela ( colocar)
            form.Controls.Add( imagemLateral );

        }

        void CriaLogo()
        {
            int largLogo = Convert.ToInt32( Config.tamanhoTela[0] * 0.2f );

            //int elementos = largImagem + largLogo;

            int posX = Convert.ToInt32( Config.tamanhoTela[0] * 0.7f - largLogo );
            int posY = Convert.ToInt32( ( Config.tamanhoTela[1] / 2) - ( largLogo / 2 ));

            //Debug.WriteLine( elementos );

            PictureBox logo = new PictureBox();
            logo.Size = new Size( largLogo, largLogo );
            logo.BackgroundImage = Image.FromFile( Config.CaminhosImagens("logo") );
            logo.BackgroundImageLayout = ImageLayout.Zoom;
            logo.Location = new Point( posX, posY );

            form.Controls.Add(logo);

        }

        void CriaBotoes()
        {
            
            int posX = Convert.ToInt32( Config.tamanhoTela[0] * 0.97f );
            int posX2 = Convert.ToInt32( Config.tamanhoTela[0] * 0.94f );

            Button configBtn = new Button();
            PadronizaBotoes(configBtn);
            configBtn.Location = new Point( posX2 , 10 );
            configBtn.BackgroundImage = Image.FromFile(Config.CaminhosImagens("config"));
            configBtn.Name = "configBtn"; // Aplica um Name ao objeto
            form.Controls.Add(configBtn);

            Button sairBtn = new Button();
            PadronizaBotoes(sairBtn);
            sairBtn.Location = new Point(posX, 10);
            sairBtn.BackgroundImage = Image.FromFile( Config.CaminhosImagens( "sair" ));
            configBtn.Name = "sairBtn";
            form.Controls.Add(sairBtn);

            Button menuBtn = new Button();
            PadronizaBotoes(menuBtn);
            menuBtn.Location = new Point(10, 10);
            menuBtn.BackgroundImage = Image.FromFile(Config.CaminhosImagens("menu"));
            configBtn.Name = "menuBtn";
            form.Controls.Add(menuBtn);
        }
        void PadronizaBotoes( Button botao )
        {
            int tamanhoBtn = Convert.ToInt32(Config.tamanhoTela[0] * 0.02f);

            botao.Size = new Size(tamanhoBtn, tamanhoBtn);
            botao.BackgroundImageLayout = ImageLayout.Zoom;
            botao.FlatAppearance.BorderSize = 0;
            botao.FlatStyle = FlatStyle.Flat;
            botao.FlatAppearance.MouseDownBackColor = Color.Transparent;
            botao.FlatAppearance.MouseOverBackColor = Color.Transparent;
            botao.BackColor = Color.Transparent;
            botao.Cursor = Cursors.Hand;

        }
        void FazerLogOFF(object disparador, EventArgs evento )
        {
            // Abrimos a tela de login 
            LoginView LoginV = new LoginView(); // Criando o objeto da tela de Login
            LoginV.Show();// Exibe a tela criada
            
            //form.Close();// encerra a tela e ser for a única aberta encerra a aplicação.

        }

    }
}
