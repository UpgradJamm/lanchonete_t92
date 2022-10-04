/*No model armazenamos os dados principais da aplicação (cores, formatações, dados do BD)
 
    Na view temos os componentes de tela (textos, botões).
    
    No controller fazemos as chamadas que conectam a View e o Model.

    Tipos de dados para variaveis/atributos



        int - numeros intriros = 100
        float - numeros decimais = 100.2f
        bool - verdadeiro/falso = true/false
        string - cadeia de texto - "texto 123"
        char - letra unica - 'c'
    
        array permite guardar mais de um valor na mesma variavel/atributo
        public int cores = 255;
        public int[] cores = { 255, 255, 255 };

        tipo de acesso
        public -acesso liberado de qualquer classe do mesmo namespace.
        private - acesso APENAS da classe onde foi criado.



       sintaxe de atributos/variaveis
       acesso tipoDeDado nomeAtributo = valor;
  Sintaxe dos métodos 
            acesso retorno NomeDoMetodo( parâmetros )
            {
                // códigos a serem executados quando o método é chamado
            }

        Retorno ou é um tipo de dado ou a palavra void

 */
        using System;
        using System.Collections.Generic;
using System.Drawing;
using System.Linq;
        using System.Text;
        using System.Threading.Tasks;
        
// importamos a classe da tela do Win para manipular seus componentes
using System.Windows.Forms;

      

    namespace Lanchonete_T92
{
    /// <summary>
    /// Classe que controla a aparência do programa (tamanho, cor, etc)
    /// </summary>
    class LayoutModel 
    {
        // Atributos 
        public int[] corFundoTelas = { 255 ,0 ,0 };
        public int[] corTextoTelas = { 0, 0, 255};
        
        // Métodos
           
        public void MontaLogin(Form tela)
        {
            // Mudar a cor de fundo da tela
            tela.BackColor = Color.FromArgb( corFundoTelas[0], corFundoTelas[1], corFundoTelas[2] );

        }
    
    }
}
