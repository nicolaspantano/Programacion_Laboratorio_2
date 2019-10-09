using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Auto:Vehiculo
    {
        public ETipo tipo;

        public Auto(string modelo, float precio, Fabricante fabri,ETipo tipo):base(precio,modelo,fabri)
        {
            this.tipo = tipo;
        }

        public static bool operator ==(Auto a,Auto b)
        {
            return (a.tipo == b.tipo && (Vehiculo)a == (Vehiculo)b);
        }

        public static bool operator !=(Auto a, Auto b)
        {
            return !(a == b);
        }

        public static explicit operator Single(Auto a)
        {
            return a.precio;
        }

        public override bool Equals(object obj)
        {
            if(obj is Auto)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append((string)this);
            sb.Append("TIPO: ");
            sb.AppendLine(this.tipo.ToString());

            return sb.ToString();
        }
    }
}
