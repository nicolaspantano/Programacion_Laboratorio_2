using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
namespace Clase._29._10
{
    public class Auto:IXML
    {
        public string marca;
        public double precio;

        public Auto() : this("SinMarca", -1)
        {

        }

        public Auto(string marca, double precio)
        {
            this.marca = marca;
            this.precio = precio;
        }

        public override string ToString()
        {
            return this.marca + " - " + this.precio.ToString();
        }

        public bool Guardar(string path)
        {
            try
            {
                XmlSerializer a = new XmlSerializer(typeof(Auto));
                StreamWriter sw = new StreamWriter(path);
                a.Serialize(sw, this);
                sw.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Leer(string path,out object salida)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Auto));
                StreamReader sr = new StreamReader(path);
                salida = (Auto)serializer.Deserialize(sr);                
                return true;
               
            }
            catch
            {
                salida = null;
                return false;
            }
        }

    }
}
