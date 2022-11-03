/*
    Classe que aplica as alterações, chamadas e controles da tela de Login (LoginView.cs)
    
    Propriedades / Atributos / Variáveis / Parâmetros
        - Propriedade/Atributo - está dentro da classe
        - Variável dentro do método/função
        - Parâmetro dentro do parêntese do método

    atributo = / métodos ()

    *.Width / *.Height - atributo - dimensões do elemento
    *.Size() - método que altera larg e alt usando new Size( larg, alt )
    *.Parent - atributo - pega o "pai" do elemento (que o contém)
    *.Location - atributo - posição para o elemento new Point( x , y )
    *.Margin - atributo - margem do objeto new Padding( 0 , 0, 0, 0 )
   
    Convert. - Método de conversão de tipo de dados da classe System
            ToInt32() - converte para inteiros
            ToFloat() - converte para decimal float
            ToBool() - converte para lógico
    
*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace Lanchonete_T92
{
    public class LoginController
    {
        private Form form;
        private int qtdadeItens;
       
        // Método Construtor - é executado automaticamente ao criar um objeto da classe
        public LoginController( Form form )
        {
            // envia o form para o atributo da classe
            this.form = form;
            // chama o método que redimensiona a tela
            TamanhoTela();
            // chama o método FormataControles passando seu parâmetro
            FormataControles( form.Controls );

            AplicaImagens();

            // chamando um método e um atributo de uma classe estática
            //Config.MostraMensagem( Config.caminho );
        }

        private void TamanhoTela()
        {
            // form.Width lê o tamaho da tela
            // form.Width = 100 definindo a largura da tela
            form.Width = Convert.ToInt32(Config.tamanhoTela[0] * 0.6f);
            form.Height = Convert.ToInt32(Config.tamanhoTela[0] * 0.6f * 0.56f);

            // Tamanho da imagem lateral
            MudaTamanhos( PegaComponente("imagemLateral"), 0.35f, 1.53f );
            
            // Tamanho e posição do logo
            MudaTamanhos( PegaComponente("logoImg"), 0.55f, 0.55f );
            MudaPosicao( PegaComponente("logoImg"), 0.4f, 0.05f );

            // tamanho e posição dos paineis
            MudaTamanhos( PegaComponente("panel1"), 0.55f, 0.4f);
            //PegaComponente("panel1").BackColor = Color.Transparent;

            //int largLateral = Convert.ToInt32( form.Width * 0.35f );
            //int altLateral = Convert.ToInt32( largLateral * 1.53f );

            //form.Controls.Find("imagemLateral",true)[0].Size = new Size( largLateral, altLateral );

            // Tamanho do logotipo

        }

        void MudaTamanhos(Control componente, float fatorLarg, float fatorAlt)
        {
            int larguraNova = Convert.ToInt32( componente.Parent.Width * fatorLarg );
            int alturaNova = Convert.ToInt32( larguraNova * fatorAlt );
            
            // Alterando o tamanho do componente
            componente.Size = new Size( larguraNova, alturaNova );
            
        }

        void MudaPosicao( Control componente, float x, float y )
        {
            int posX = Convert.ToInt32(componente.Parent.Width * x); 
            int posY = Convert.ToInt32(componente.Parent.Width * y); 
            
            componente.Location = new Point( posX, posY );// posição do elemento

        }

        Control PegaComponente( string quem )
        {
            return form.Controls.Find(quem, true)[0];
        }

        /// <summary>
        /// Remove cor de fundo e padroniza todos os componentes da tela
        /// </summary>
        /// <param name="colecao">parâmetro com a coleção de controles do form a ser acessada.</param>
        void FormataControles( Control.ControlCollection colecao )
        {
            List<Control> itens =  new List<Control>();

            // laço de repetição (loop) - se repete para cada item encontrado
            foreach( Control componentes in colecao )
            {
                if( componentes is Button)
                {
                    Button btn = new Button();
                    btn = (Button) componentes;
                    // nesse escopo componentes tem apenas botões
                    btn.BackColor = Color.Transparent;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.FlatAppearance.MouseDownBackColor = Color.Transparent;
                    btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
                    btn.ForeColor = Color.White;
                    btn.Text = "";
                    btn.Cursor = Cursors.Hand;
                    btn.BackgroundImageLayout = ImageLayout.Zoom;
                }

                if ( componentes is TextBox )
                {
                    TextBox texto = new TextBox();
                    texto = (TextBox)componentes;
                    
                }

                if (componentes is Panel)
                {
                    Panel painel = new Panel();
                    painel = (Panel) componentes;
                    painel.BackColor = Color.Transparent;
                }

                if (componentes is Label )
                {
                    Label rotulo = new Label();
                    rotulo = (Label)componentes;
                    rotulo.BackColor = Color.Transparent;
                }

                // Repetir o método que conta os itens, mas agora dentro dos controles
                FormataControles(componentes.Controls);
            }

            // envia o resultado para uma propriedade/atributo da classe
            this.qtdadeItens = itens.Count;

            //MessageBox.Show("Achei " + qtdadeItens + " componentes.");
        }
        
        void ContaItens( )
        {
            // classe List<> permite criar um vetor com objetos de outras classes
            List<Control> lista = new List<Control>();

            // Para cada item encontrado repita o código abaixo
            // Itens que estão diretamente no form (filhos do  form)
            foreach ( Control itens in form.Controls )
            {
                // adiciona o item encontrado na List
                lista.Add( itens ); 
            }

            // Exibe uma caixa de aviso para o usuário.
            MessageBox.Show("Foram encontrados " + lista.Count + " itens");
        }

        void AplicaImagens()
        {
            PegaComponente("imagemLateral").BackgroundImage = Image.FromFile( Path.Combine( Config.caminho, "Imagens\\login.png" ) );

            PegaComponente("logoImg").BackgroundImage = Image.FromFile( Path.Combine( Config.caminho, "Imagens\\logo.png" ) );

            PegaComponente("fecharBtn").BackgroundImage = Image.FromFile( Path.Combine( Config.caminho, "Imagens\\Icones\\botao-ligar-desligar.png" ) );
            
        }

    }
}