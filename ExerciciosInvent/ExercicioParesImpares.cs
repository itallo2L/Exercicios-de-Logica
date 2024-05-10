using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosInvent
{
    internal class ExercicioParesImpares
    {
        public void OrganizaParesImpares()
        {
            int numeroDeValores = int.Parse(Console.ReadLine());
            var arrayPar = new ArrayList();
            var arrayImpar = new ArrayList();
            if (1 < numeroDeValores && numeroDeValores <= Math.Pow(10, 5))
            {
                for (int contador = 0; contador < numeroDeValores; contador++)
                {
                    int numero = int.Parse(Console.ReadLine());
                    if (numero % 2 == 0)
                    {
                        arrayPar.Add(numero);
                    }
                    else
                    {
                        arrayImpar.Add(numero);
                    }
                }

                var ordenacaoPar = arrayPar.ToArray().OrderBy(y => y);
                foreach (var n in ordenacaoPar)
                {
                    Console.WriteLine(n);
                }

                var ordenacaoImpar = arrayImpar.ToArray().OrderByDescending(x => x);
                foreach (var n in ordenacaoImpar)
                {
                    Console.WriteLine(n);
                }


            }
        }
    }
}
