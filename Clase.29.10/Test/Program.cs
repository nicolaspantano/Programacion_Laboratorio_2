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
            Persona p1 = new Persona("Juan", "Perez",50);
            p1.Apodos.Add("a");
            Console.WriteLine(p1.ToString());

            try
            {                
                XmlSerializer a = new XmlSerializer(typeof(Persona));
                //XmlTextWriter writer = new XmlTextWriter();
                StreamWriter sw = new StreamWriter("Persona.xml");
                a.Serialize(sw, p1);                
                sw.Close();                
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Persona));
                StreamReader sr = new StreamReader("Persona.xml");
                Persona prueba=(Persona)serializer.Deserialize(sr);
                Console.WriteLine(prueba.ToString());
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }


            List<Persona> lista = new List<Persona>();
            lista.Add(p1);

            Persona p2 = new Persona("Federico", "Gonzalez", 19);
            p2.Apodos.Add("b");
            Persona p3 = new Persona("Valentin", "Gomez", 16);
            p3.Apodos.Add("c");
        
            lista.Add(p2);            
            lista.Add(p3);

            try
            {
                XmlSerializer serilaizer = new XmlSerializer(typeof(List<Persona>));
                StreamWriter sw = new StreamWriter("Lista.xml");
                serilaizer.Serialize(sw, lista);
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
