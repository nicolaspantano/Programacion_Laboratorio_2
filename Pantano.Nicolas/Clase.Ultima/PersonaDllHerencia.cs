using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Externa;

namespace Clase.Ultima
{
    public class PersonaDllHerencia : PersonaExterna
    {
        public PersonaDllHerencia(string nombre, string apellido, int edad, ESexo sexo)
            :base(nombre,apellido,edad,sexo)
        {

        }

        public string Nombre { get {return this._nombre; } }
        public string Apellido { get { return this._apellido; } }
        public int Edad { get { return this._edad; } }
        public ESexo Sexo { get { return this._sexo; } }

        public string MostrarInformacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base._nombre);
            sb.Append(" - ");
            sb.Append(base._apellido);
            sb.Append(" - ");
            sb.Append(this._edad.ToString());
            sb.Append(" - ");
            sb.AppendLine(this._sexo.ToString());

            return sb.ToString();
        }
    }
}
