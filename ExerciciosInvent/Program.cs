using ExerciciosInvent;
using System.Buffers.Text;
using System.Xml;

namespace ExerciciosInvent
{
    public class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Exercicio impar e par");
            var exercicioParesImpares = new ExercicioParesImpares();
            exercicioParesImpares.OrganizaParesImpares();
            Console.WriteLine("Execicio do corvo");
            ExercicioDoCorvo exercicioDoCorvo = new ExercicioDoCorvo();
            exercicioDoCorvo.ExercicioResolvidoCorvo();
            Console.WriteLine("Exercicio da formula de baskhara");
            var baskhara = new ExercicioBaskhara();
            baskhara.formulaDeBaskhara();


            //conflito
            //mais alguma coisa só pra ficar melhor


        }
    }
}
