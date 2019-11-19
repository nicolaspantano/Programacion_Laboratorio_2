using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Clase.Ultima
{
    public class Persona
    {
        private string nombre;
        private string apellido;
        private int edad;

        public string Nombre { get { return this.nombre; } }
        public string Apellido { get { return this.apellido; } }
        public int Edad { get { return this.edad; } }



        public Persona(string nombre, string apellido,int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }

        public string MostrarInformacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.nombre);
            sb.Append(" - ");
            sb.Append(this.apellido);
            sb.Append(" - ");
            sb.AppendLine(this.edad.ToString());

            return sb.ToString();
        }

    }
}
