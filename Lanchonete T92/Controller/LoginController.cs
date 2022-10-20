/*
    Classe que aplica as alterações, chamadas e controles da tela de Login (LoginView.cs)
    
    Propriedades / Atributos / Variáveis / Parâmetros
        - Propriedade/Atributo - está dentro da classe
        - Variável dentro do método/função
        - Parâmetro dentro do parêntese do método

    *.Width / *.Height - dimensões do elemento
   
    Convert. - Método de conversão de tipo de dados da classe System
            ToInt32() - converte para inteiros
            ToFloat() - converte para decimal float
            ToBool() - converte para lógico
    
*/

using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;


namespace Lanchonete_T92
{
    public class LoginController
    {
        private Form form;
       
        // Método Construtor - é executado automaticamente ao criar um objeto da classe
        public LoginController( Form form )
        {
            // envia o form para o atributo da classe
            this.form = form;

            TamanhoTela();
        }

        private void TamanhoTela()
        {
            // form.Width lê o tamaho da tela
            // form.Width = 100 definindo a largura da tela
            form.Width = Convert.ToInt32(Config.tamanhoTela[0] * 0.6f);
            form.Height = Convert.ToInt32(Config.tamanhoTela[0] * 0.6f * 0.56f);

            // Tamanho da imagem lateral
            int largLateral = Convert.ToInt32( form.Width * 0.35f );
            int altLateral = Convert.ToInt32( largLateral * 1.53f );

            form.Controls.Find("imagemLateral",true)[0].Size = new Size( largLateral, altLateral );

        }

    }
}