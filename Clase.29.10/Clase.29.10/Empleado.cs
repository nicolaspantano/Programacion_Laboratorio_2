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
    public class Empleado:Persona
    {
        public int legajo;
        public double sueldo;

        public Empleado(string nombre, string apellido, int edad, int legajo, double sueldo)
            : base(nombre, apellido, edad)
        {
            this.legajo = legajo;
            this.sueldo = sueldo;
        }

        public Empleado() : this("SinNombre", "SinApellido", -1, -1, -1) { }

        public override string ToString()
        {
            return base.ToString() + " Legajo: " + this.legajo.ToString() + "Sueldo: " + this.sueldo.ToString();
        }

    }
}
