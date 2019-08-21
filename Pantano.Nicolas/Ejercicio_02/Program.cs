using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            do
            {
                Console.Write("Ingrese un numero mayor a 0: ");
                numero = int.Parse(Console.ReadLine());

            } while (numero<=0);

            Console.Write("Elevado al cuadrado: ");
           Console.WriteLine( Math.Pow(numero, 2));
            Console.Write("Elevado al cubo: ");
            Console.WriteLine(Math.Pow(numero, 3));

            Console.ReadKey();
            
        }
    }
}
