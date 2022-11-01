/*
    Na POO existem 04 pilares:
        - Encapsulamento
            - Proteção dos dados na aplicação (acesso)
            - private é visível apenas na classe (arquivo)
            - public é visível de qualquer outra classe
            
<<<<<<< Updated upstream
        - Abstração - ao chamar um método não é necessário conhecer seus detalhes, 
            apenas passar os parâmetros que são obrigatorios.
=======
        - Abstração - ao chamar um método não é necessário conhecer seus detalhes, apenas passar os parâmetros que são obrigatórios.

>>>>>>> Stashed changes
        - Herança
        - Polimorfismo

    Classe Static que armazena as configurações da aplicação.
        - cores
        - fontes
        - credenciais BD
    
    Classes no C#
        Existem: 
            - classes "normais" - para usá-la precisa de um objeto
            - classes static - não precisam de objetos (menos seguras)
    
    No C# tudo é PRIVATE (privado).

<<<<<<< Updated upstream
=======
    Estruturas de Decisão

        if (condição - comparação) {
            // códigos a executar se verdadeiro
        }
        else
        {
             // códigos a executar se  a condição for falsa
        }

        switch( variavel )
        {
            case "valor" : 
                    // código a ser executado se verdadeiro
                  break;
            default:  // executado caso seja outro valor diferente dos mapeados      
        }

>>>>>>> Stashed changes
*/
//Importando a classe Forms do Win (componentes)
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Lanchonete_T92
{
<<<<<<< Updated upstream

=======
   
>>>>>>> Stashed changes
    public static class Config
    {
        // Atributos - varáveis da classe é visível de qualquer membro da classe

<<<<<<< Updated upstream
=======
        public static string caminhos;

>>>>>>> Stashed changes
        // armazena o tema atual 0 claro / 1 escuro
        public static int tema = 0;

        // ler o tamanho do monitor do usuário
        public static int[] tamanhoTela = { Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height };

<<<<<<< Updated upstream
        // Essa variável armazena o caminho da nossa instalação 
        public static string caminho = Path.GetDirectoryName
            (Assembly.GetExecutingAssembly().Location);

        public static void MostraMensagem( string texto)
        {
            MessageBox.Show(texto);
        }
        public static Control PegaComponentes(string quem, Form form)
        {
            return form.Controls.Find(quem , true)[0];
=======
        // armazena o caminho da nossa instalação
        public static string caminho = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        // armazena nossas cores de fundo
        public static int[ , ] corFundo = { { 253, 229, 210 }, { 38, 40, 51 } };

        // armazena as imagens 
        private static string[,] imagens  = {
            { 
                "login.png",
                "logo.png", 
                "fundo_form.png",
                "sair.png",
                "config.png"
            }, 
            { 
                "login_d.png", 
                "logo_d.png", 
                "fundo_form_d.png",
                "sair_d_png",
                "config_d_png"
            } 
        };


        public static void MostraMensagem( string texto )
        {
            MessageBox.Show( texto );
        }

        public static string CaminhosImagens( string imagem )
        {
           

            switch ( imagem )
            {
                case "lateral":
                    return caminhos = Path.Combine(caminho, "Imagens\\" + imagens[tema, 0] );
                    break;

                case "logo":
                    return caminhos = Path.Combine(caminho, "Imagens\\" + imagens[tema, 1] );
                    break;

                case "campos":
                    return caminhos = Path.Combine(caminho, "Imagens\\" + imagens[tema, 2] );
                    break;

                case "sair":
                    return caminhos = Path.Combine(caminho, "Imagens\\Icones\\" + imagens[tema, 3] );
                    break;

                case "config":
                    return caminhos = Path.Combine(caminho, "Imagens\\Icones\\" + imagens[tema, 4]);
                    break;

                default: return caminhos = "";
            }
            
>>>>>>> Stashed changes
        }

    }

}