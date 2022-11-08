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
        // Criar atributos/propriedades

        // Sempre que criar uma classe contruir o contrutor
        public UsuariosController( Form form )
        {
            // Instaciamos a classe de banco de dados
            DB db = new DB();

            // Chamamos a conexão com o banco
            db.ConectaBanco();

           
        }
    }
}
