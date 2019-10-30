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

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Persona>));
                StreamWriter sw = new StreamWriter(@"C:\Users\alumno\Desktop\Lista.xml");
                serializer.Serialize(sw, lista);
                sw.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
