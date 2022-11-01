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
    public partial class PrincipalView : Form
    {
        public PrincipalView()
        {
            InitializeComponent();

            // Instanciar um objeto da classe
            PrincipalController principalC = new PrincipalController( this );

        }
    }
}
