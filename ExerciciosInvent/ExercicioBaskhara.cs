using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosInvent
{
    internal class ExercicioBaskhara
    {

        public void formulaDeBaskhara()
        {
            /*Leia 3 números de ponto flutuante. Depois, imprima as raízes da fórmula de bhaskara.
  * Caso seja impossível calcular as raízes devido à divisão por zero ou raiz quadrada 
  * de um número negativo, apresenta a mensagem “Impossível calcular”.
  * 
  * Entrada
  * Leia 3 números de ponto flutuante (duplos) A, B e C.
  * 
  * Saída
  * Imprima o resultado com 5 dígitos após a vírgula ou a mensagem se for impossível calcular.*/

            string[] valores = Console.ReadLine().Split(' ');
            double a = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double b = double.Parse(valores[1], CultureInfo.InvariantCulture);
            double c = double.Parse(valores[2], CultureInfo.InvariantCulture);

            double delta = Math.Pow(b, 2) - 4 * a * c;
            double respostaUm = (-b + Math.Sqrt(delta)) / (2 * a);
            double respostaDois = (-b - Math.Sqrt(delta)) / (2 * a);

            if (a == 0 || delta < 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                Console.WriteLine("R1 = " + respostaUm.ToString("F5"), CultureInfo.InvariantCulture);
                Console.WriteLine("R2 = " + respostaDois.ToString("F5"), CultureInfo.InvariantCulture);
            }
        }
    }
}
