using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona miPersona = new Persona("Nicolas","Pantano",43324757);

            

            Console.WriteLine(miPersona.Mostrar());

            Persona otraPersona = new Persona("Juan","Perez",44487444);


            Console.WriteLine(otraPersona.Mostrar());
            Console.ReadKey();
        }
    }
}
