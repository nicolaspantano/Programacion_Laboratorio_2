using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_06
{
    public class Tempera
    {
        private ConsoleColor color;
        private string marca;
        private int cantidad;

        public Tempera(ConsoleColor color, string marca, int cantidad)
        {
            this.color = color;
            this.marca = marca;
            this.cantidad = cantidad;

        }

        private string Mostrar()
        {
            return this.color.ToString() + " - " + this.marca + " - " + this.cantidad.ToString();
        }

        public static implicit operator string(Tempera tempera)
        {
            return tempera.Mostrar();
        }

        public static bool operator ==(Tempera tempera1, Tempera tempera2)
        {
            bool retorno = false;
            if(Object.Equals(tempera1,null)==false&&Object.Equals(tempera2,null)==false)
            if (tempera1.color == tempera2.color)
            {
                if (tempera2.marca == tempera1.marca)
                {
                    if (tempera1.cantidad == tempera2.cantidad)
                    {
                        retorno = true;
                    }
                }
            }
            return retorno;

        }

        public static bool operator !=(Tempera tempera1, Tempera tempera2)
        {
            return !(tempera1 == tempera2);
        }

        public static Tempera operator +(Tempera tempera, int cantidad)
        {
            if (Object.Equals(tempera, null) == false)
            {
                tempera.cantidad += cantidad;
            }

            return tempera;
        }

        public static Tempera operator +(Tempera tempera1, Tempera tempera2)
        {
            if (tempera1 == tempera2)
            {
                tempera1.cantidad += tempera2.cantidad;
            }
            return tempera1;
        }
    }
}
