using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lanchonete_T92
{
    class UsuariosController 
    {
        // criar atributos/propriedade

        // criar o construtor da classe
        public UsuariosController(Form form)
        {
            this.form = form;
            
            form.Controls.Find("cadastroBtn", true)[0].Click += ChamaCadastro;
        }
        void ChamaCadastro( object objeto, EventArgs evento)
        {
            string usuario = form.Controls.Find("usuarioTxt", true)[0].text;
            string senha = form.Controls.Find("senhaTxt", true)[0].text;

            DB db = new DB();

            db.InsereDados("teste4@teste.com", "1234");
        }
    }
}
