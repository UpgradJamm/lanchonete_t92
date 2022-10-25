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

            PrincipalController principalController = new PrincipalController(this);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PrincipalView_Load(object sender, EventArgs e)
        {

        }
    }
}
