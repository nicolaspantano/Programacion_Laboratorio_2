using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            MiClase.edad = 23;
            MiClase.nombre = "Juan";
            name = MiClase.RetornarNombre();
            Console.WriteLine(name);
            MiClase.MostrarEdad();        

            
            Console.ReadKey();
        }
    }
}
