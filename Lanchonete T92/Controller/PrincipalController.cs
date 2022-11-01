using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
<<<<<<< Updated upstream
=======
using System.IO;
>>>>>>> Stashed changes
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lanchonete_T92
{
<<<<<<< Updated upstream
    class PrincipalController 
    {
        private Form form;
        public PrincipalController(Form form)
        {
            
            this.form = form;
            TamanhoTela();


        }
        private void TamanhoTela()
        {
           
            form.Width = Convert.ToInt32(Config.tamanhoTela[0] * 0.6f);
            form.Height = Convert.ToInt32(Config.tamanhoTela[0] * 0.6f * 0.56f);

            MudaTamanhos(PegaComponente("imagemLateral"), 0.30f, 1.53f);

            MudaTamanhos(PegaComponente("logoImg"), 0.55f, 0.55f);
            MudaPosicao(PegaComponente("logoImg"), 0.4f, 0.05f);

            MudaTamanhos(PegaComponente("panel1"), 0.6f, 0.5f);

        }
        void MudaTamanhos(Control componente, float fatorLarg, float fatorAlt)
        {
            int larguraNova = Convert.ToInt32(componente.Parent.Width * fatorLarg);
            int AlturaNova = Convert.ToInt32(larguraNova * fatorAlt);

            
            componente.Size = new Size(larguraNova, AlturaNova);

            Debug.WriteLine(componente.Parent.Width);

            
            Debug.WriteLine(componente.Parent.Width);
        }
        void MudaPosicao(Control componente, float x, float y)
        {
            int posX = Convert.ToInt32(componente.Parent.Width * x);
            int posY = Convert.ToInt32(componente.Parent.Width * y);


            componente.Location = new Point(posX, posY);

        }
        Control PegaComponente(string quem)
        {
            return form.Controls.Find(quem, true)[0];
        }
=======
    class PrincipalController
    {
        private Form form;
        private int largImagem;

        // Construtor da classe que recebe a tela a ser editada e envia para a propriedade da tela
        public PrincipalController( Form form )
        {
            this.form = form;

            FormataTela();
            CriaPainelLateral();
            CriaLogo();
            CriarBotoes();
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
        private void CriaLogo()
        {
            int LargLogo = Convert.ToInt32(Config.tamanhoTela[0] * 0.2f);

            int elementos = largImagem + LargLogo;

            int posX = Convert.ToInt32( (Config.tamanhoTela[0] * 0.7f - LargLogo) );
            int posY = Convert.ToInt32( (Config.tamanhoTela[1] / 2) - (LargLogo / 2 ));

            Debug.WriteLine(elementos);

            PictureBox ImagemLogo = new PictureBox();

            
            ImagemLogo.Size = new Size(LargLogo, LargLogo);
            ImagemLogo.BackgroundImage = Image.FromFile(Config.CaminhosImagens("logo"));
            ImagemLogo.BackgroundImageLayout = ImageLayout.Zoom;
            ImagemLogo.Location = new Point(posX, posY);

            ImagemLogo.BackColor = Color.Transparent;
            
            form.Controls.Add( ImagemLogo );
        }
        void CriarBotoes()
        {
            int tamanhoBtn = Convert.ToInt32( Config.tamanhoTela[0] * 0.02f );
            int posX = Convert.ToInt32(Config.tamanhoTela[0] * 0.95f );
            int posX2 = Convert.ToInt32(Config.tamanhoTela[0] * 0.97f );
            
            Button configBtn = new Button();
            configBtn.Size = new Size(tamanhoBtn, tamanhoBtn);
            configBtn.Location = new Point(posX2, 10);
            configBtn.BackgroundImage = Image.FromFile(Config.CaminhosImagens("config"));
            form.Controls.Add(configBtn);

            Button sairBtn = new Button();
            sairBtn.Size = new Size(tamanhoBtn, tamanhoBtn);
            sairBtn.Location = new Point(posX, 10);
            sairBtn.BackgroundImage = Image.FromFile(Config.CaminhosImagens("sair"));
            form.Controls.Add(sairBtn);
        }

>>>>>>> Stashed changes
    }
}
