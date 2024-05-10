using ExerciciosInvent;
using System.Buffers.Text;

namespace ExerciciosInvent
{
    public class Program
    {
        static void Main(string[] args) 
        {
            dynamic mem = new MemoryStream(Int32.MaxValue);
            mem.Write(new byte[] { 0x00, 0x01, 0x02, 0x03 });


            var exercicioParesImpares = new ExercicioParesImpares();
            exercicioParesImpares.OrganizaParesImpares();

            ExercicioDoCorvo exercicioDoCorvo = new ExercicioDoCorvo();
            exercicioDoCorvo.ExercicioResolvidoCorvo();

            var baskhara = new ExercicioBaskhara();
            baskhara.formulaDeBaskhara();

            //conflito
        }
    }
}
