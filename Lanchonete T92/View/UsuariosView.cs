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
    public partial class UsuariosView : Form
    {
        public UsuariosView()
        {
            InitializeComponent();

            UsuariosController usuariosC = new UsuariosController(this);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
