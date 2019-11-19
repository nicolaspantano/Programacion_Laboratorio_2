using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase.Ultima;
using Entidades.Externa;
using Entidades.Externa.Sellada;
namespace Clase.Ultima.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("Juan", "Perez", 43324757);
            List<Persona> lista = new List<Persona>();
            string a;
            a.
            lista.ObtenerListadoDB();
            foreach(Persona a in lista)
            {
                Console.WriteLine(a.MostrarInformacion());
            }
            
            Console.ReadKey();

        }


    }
}
