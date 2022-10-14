/*
No Model manipulamos os dados principais da aplicação (cores, formatações, dados do BD).

No Controller fazemos as chamadas que conectam a View e o Model.

Na View temos os componentes de tela (textos, botões).

Tipos de dados para variáveis/atributos

    int - números inteiros - 100
    float - números decimais - 100.2f
    bool - verdadeiro/falso - true/false
    string - cadeias de texto - "texto 123"
    char - letra única - 'c'

    arrays permitem guardar mais de um valor na mesma variável/atributo
        public int cores = 255;
        public int[] cores = { 255, 253, 251 };
        cores[0] 255 cores[1] 253

    Tipos de Acesso
        public - acesso liberado de qualquer classe do mesmo namespace.
        private - acesso APENAS da classe onde foi criado.

    Sintaxe de atributos/variáveis
        acesso tipoDeDado nomeAtributo = valor;

    Sintaxe dos métodos
        acesso retorno NomeDoMetodo( parâmetros )
        {
            // Códigos a serem executados quando o método é chamado
        }

        retorno ou é um tipo de dado ou a palavra void
 
*/

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// importamos a classe de tela do Win para manipular seus componentes
using System.Windows.Forms;

namespace Lanchonete_T92
{
    /// <summary>
    /// Classe que controla a aparência do programa (tamanho, cor, etc)
    /// </summary>
    class LayoutModel 
    {
        // Atributos
        public int[] corFundoTelas = { 255, 60 , 0 };
        public int[] corTextoTelas = { 0, 0 , 255 };

        // Métodos
        
        public void MontaLogin( Form tela )
        {
            // Mudar a cor de fundo da tela
            tela.BackColor = Color.FromArgb( corFundoTelas[0], corFundoTelas[1], corFundoTelas[2] );

        }


    }

}
