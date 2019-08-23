using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.Write("Ingrese un numero entre -100 y 100: ");
            numero = int.Parse(Console.ReadLine());

            Console.WriteLine(Validacion.validar(numero,-100,100));



            Console.ReadKey();
        }
    }
}
