using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lanchonete_T92
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Chamando o método que está no Model desta tela
            // Instanciar a classe como um objeto utilizavel
            LayoutModel login = new LayoutModel();


            login.MontaLogin( this );
        }
    }
}
