using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lanchonete_T92
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// Construtor da aplicação.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< Updated upstream:Lanchonete T92/Program.cs
=======
            
            // Tela que inicia a aplicação
>>>>>>> Stashed changes:Lanchonete_T92/Program.cs
            Application.Run(new PrincipalView());
        }
    }
}
