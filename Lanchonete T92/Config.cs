/*
    Na POO existem 04 pilares:
        - Encapsulamento
            - Proteção dos dados na aplicação (acesso)
            - private é visível apenas na classe (arquivo)
            - public é visível de qualquer outra classe
            
        - Abstração
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

*/
//Importando a classe Forms do Win (componentes)
using System.Windows.Forms;

namespace Lanchonete_T92
{
   
    public static class Config
    {
        // Atributos - varáveis da classe é visível de qualquer membro da classe

        // armazena o tema atual 0 claro / 1 escuro
        public static int tema = 0;

        // ler o tamanho do monitor do usuário
        public static int[] tamanhoTela = { Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height };

    }

}