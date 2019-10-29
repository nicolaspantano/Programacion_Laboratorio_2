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
    public class Alumno:Persona
    {
        public double nota;

        public Alumno(double nota,string nombre, string apellido , int edad):base(nombre,apellido,edad)
        {
            this.nota = nota;
        }

        public Alumno() : this(-1, "SinNombre", "SinApellido", -1) { }

        public override string ToString()
        {
            return base.ToString() + " Nota: " + this.nota.ToString();
        }
    }
}
