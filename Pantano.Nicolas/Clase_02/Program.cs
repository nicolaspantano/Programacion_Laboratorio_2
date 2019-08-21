using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Clase_02.Entidades;
namespace Clase_02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string name;
            MiClase.edad = 23;
            MiClase.nombre = "Juan";
            name = MiClase.RetornarNombre();
            Console.WriteLine(name);
            MiClase.MostrarEdad();  */

            Sello.mensaje = "Hola mundo";
            Console.WriteLine(Sello.Imprimir());
            
            Sello.color = ConsoleColor.Green;
            Sello.mensaje = "Hola mundo";
            Sello.ImprimirEnColor();







            Console.ReadLine();
        }
    }
}
