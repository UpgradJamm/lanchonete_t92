using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lanchonete_T92
{
    class PrincipalController 
    {
        private Form form;
        public PrincipalController(Form form)
        {
            
            this.form = form;
            TamanhoTela();


        }
        private void TamanhoTela()
        {
           
            form.Width = Convert.ToInt32(Config.tamanhoTela[0] * 0.6f);
            form.Height = Convert.ToInt32(Config.tamanhoTela[0] * 0.6f * 0.56f);

            MudaTamanhos(PegaComponente("imagemLateral"), 0.30f, 1.53f);

            MudaTamanhos(PegaComponente("logoImg"), 0.55f, 0.55f);
            MudaPosicao(PegaComponente("logoImg"), 0.4f, 0.05f);

            MudaTamanhos(PegaComponente("panel1"), 0.6f, 0.5f);

        }
        void MudaTamanhos(Control componente, float fatorLarg, float fatorAlt)
        {
            int larguraNova = Convert.ToInt32(componente.Parent.Width * fatorLarg);
            int AlturaNova = Convert.ToInt32(larguraNova * fatorAlt);

            
            componente.Size = new Size(larguraNova, AlturaNova);

            Debug.WriteLine(componente.Parent.Width);

            
            Debug.WriteLine(componente.Parent.Width);
        }
        void MudaPosicao(Control componente, float x, float y)
        {
            int posX = Convert.ToInt32(componente.Parent.Width * x);
            int posY = Convert.ToInt32(componente.Parent.Width * y);


            componente.Location = new Point(posX, posY);

        }
        Control PegaComponente(string quem)
        {
            return form.Controls.Find(quem, true)[0];
        }
    }
}
