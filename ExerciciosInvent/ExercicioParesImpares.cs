using System.Collections;

namespace ExerciciosInvent
{
    public class ExercicioParesImpares
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

        public Thread nowlyThread()
        {
            Thread thread = new Thread(OrganizaParesImpares);
            thread.Start();
            return thread;
        }

        public void nowlyThread(Thread thread)
        {
            thread.Join();
        }
    }
}
