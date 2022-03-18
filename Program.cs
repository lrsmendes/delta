using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nome
{
    class Program
    {
        static void Main(string[] args)
        {   // Por L.R. Mendes, (c) 2022
            Console.WriteLine("(c)Raziel, 2022\n");

            Double a, b, c, delta;
            Console.WriteLine("Escreva os valores de A, B e C.\n");
            Console.Write("A: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nB: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nC: ");
            c = Convert.ToDouble(Console.ReadLine());

            delta = b * b - 4 * a * c;

            Console.WriteLine("O seu delta é igual a: " + delta);

            Console.Write("\nAperte uma tecla para sair...");
            Console.ReadKey();
        }
    }
}
