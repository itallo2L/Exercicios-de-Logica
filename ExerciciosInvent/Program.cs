using ExerciciosInvent;

﻿namespace ExerciciosInvent
{
    internal class Program
    {
        static void Main(string[] args)
       
            var exercicioParesImpares = new ExercicioParesImpares();
            exercicioParesImpares.OrganizaParesImpares();

            ExercicioDoCorvo exercicioDoCorvo = new ExercicioDoCorvo();
            exercicioDoCorvo.ExercicioResolvidoCorvo();

            var baskhara = new ExercicioBaskhara();
            baskhara.formulaDeBaskhara();

        }
    }
}
