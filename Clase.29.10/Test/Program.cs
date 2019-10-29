using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using Clase._29._10;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> lista = new List<Persona>();
            lista.Add(new Persona());
            lista.Add(new Persona());
            lista.Add(new Empleado());
            lista.Add(new Empleado());
            lista.Add(new Alumno());
            lista.Add(new Alumno());

            foreach(Persona a in lista)
            {
                Serializadora.Serializar(a);
            } 

            Console.ReadKey();
        }
    }
}
