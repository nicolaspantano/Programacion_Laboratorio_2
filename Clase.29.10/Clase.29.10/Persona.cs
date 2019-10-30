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
    [XmlInclude(typeof(Alumno))]
    [XmlInclude(typeof(Empleado))]

    public class Persona : IXML
    {
        public string nombre;
        public string apellido;
        private int edad;
        private List<string> apodos;

        public Persona() : this("SinNombre", "SinApellido",-1) { }
        
        public Persona(string nombre, string apellido,int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.apodos = new List<string>();
           

        }

        public int Edad
        {
            set
            {
                this.edad = value;
            }
            get
            {
                return this.edad;
            }
        }

        public List<string> Apodos
        {
            get
            {
                return this.apodos;
            }

            
        }

        public override string ToString()
        {
            return this.nombre + " " + this.apellido;
        }

        public bool Guardar(string path)
        {
            try
            {
                XmlSerializer a = new XmlSerializer(typeof(Persona));
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

        public bool Leer(string path, out object salida)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Persona));
                StreamReader sr = new StreamReader(path);
                salida = (Persona)serializer.Deserialize(sr);
                sr.Close();
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

