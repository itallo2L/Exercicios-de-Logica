using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosInvent
{
    public sealed class ExercicioDoCorvo
    {

        public void ExercicioResolvidoCorvo()
        {
            int valorSomaPiscadas = 0;
            int contagemGrito = 0;
            while (contagemGrito < 3)
            {
                string olhosCorvos = Console.ReadLine();

                switch (olhosCorvos)
                {
                    case "caw caw":
                        if (valorSomaPiscadas < 1000)
                        {
                            Console.WriteLine(valorSomaPiscadas);
                            valorSomaPiscadas = 0;
                            contagemGrito++;
                        }
                        else
                        {
                            Console.WriteLine("Passou de 1000");
                        }
                        break;
                    case "--*":
                        valorSomaPiscadas += 1;
                        break;
                    case "*--":
                        valorSomaPiscadas += 4;
                        break;
                    case "-*-":
                        valorSomaPiscadas += 2;
                        break;
                    case "-**":
                        valorSomaPiscadas += 3;
                        break;
                    case "*-*":
                        valorSomaPiscadas += 5;
                        break;
                    case "**-":
                        valorSomaPiscadas += 6;
                        break;
                    default:
                        valorSomaPiscadas += 7;
                        break;


                }
            }
        }

        public virtual void disposable()
        {
            throw new NotImplementedException();
        }
    }
}
