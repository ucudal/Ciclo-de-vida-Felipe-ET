//----------------------------------------g----------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            var t1 = new Train("Last train to london");
            var t2 = new Train("Last train to london");
            var t3 = new Train("Runaway train");

            // Aunque t1 y t2 tengan la misma identificacion no son el mismo objeto
            // t2 y t3 tienen distinta identificacion y en efecto son distinto objeto 

            Console.WriteLine(t1==t2);
            Console.WriteLine(t2==t3);

            /*
            for (int i=0; i<100; i++)
            {
                var train = new Train("10");
            }
            */
        }
    }
}

// al intentar 10 000 000 de instancias se sobrecarga la compilador y queda en bucle porque cada vez que se llena el compilador las borra y arranca desde 0