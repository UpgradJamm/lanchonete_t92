// Importações
using System;
using System.Windows.Forms;

namespace Lanchonete_T92
{


    public static class Config
    {
        // Cores de fundo de acordo com o tema claro[0], escuro[0]
        // Vetor ou array multidimensional
        public static int[,] coresFundo = { { 253, 229, 210 }, { 50, 50, 50 } };

        public static int[,] coresRotulos = { { 125, 113, 104 }, { 255, 255, 255 } };

        public static int[,] coresFundoCampos = { { 253, 229, 210 }, { 245, 245 , 245 } };

        // Medindo a resolução do monitor.
        public static int[] tamanhoMonitor = { Screen.PrimaryScreen.Bounds.Width,
        Screen.PrimaryScreen.Bounds.Height};
    }
}
