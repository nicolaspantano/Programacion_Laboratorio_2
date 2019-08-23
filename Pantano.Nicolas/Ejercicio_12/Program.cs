using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            char seguir;
            
            do
            {
                Console.Write("Ingrese un numero: ");
                Console.Read();
                Console.ReadLine();
                Console.Write("Desea ingresar otro numero?(s/n): ");
                seguir = Convert.ToChar(Console.Read());
                Console.ReadLine();
               
            } while (ValidarRespuesta.ValidarS_N(seguir));
            
            
        }
    }
}
