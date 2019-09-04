using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_06
{
    class Paleta
    {
        private Tempera[] colores;
        private int cantidadMaximaColores;

        private Paleta() : this(5) { }                    
        
        private Paleta(int cantidadColores)
        {
            this.cantidadMaximaColores = cantidadColores;
            this.colores = new Tempera[cantidadColores];
        }

        public static implicit operator Paleta(int cantidad)
        {
            return new Paleta(cantidad);
        }

        private string Mostrar()
        {
            string retorno="Cant Maxima: " + this.cantidadMaximaColores.ToString() + "\n";

            foreach(Tempera tempera in this.colores)
            {
                retorno += (string)tempera + "\n";
            }
           

            return retorno;
        }
        
        public static explicit operator string(Paleta paleta)
        {
            return paleta.Mostrar();
        }

        public static bool operator ==(Paleta paleta, Tempera tempera)
        {
            bool retorno = false;
            foreach (Tempera actual in paleta.colores)
            {
                if (actual == tempera)
                {
                    retorno = true;
                }
            }
            return retorno;
        }          

        public static bool operator !=(Paleta paleta, Tempera tempera)
        {
            return !(paleta == tempera);
        }

        public static Paleta operator +(Paleta paleta,Tempera tempera)
        {
            if (paleta == tempera)
            {
                int index;
                index = Array.IndexOf(paleta.colores, tempera);
                paleta.colores[index] += tempera;

            }
            else
            {
                paleta.colores[paleta.ObtenerLugarLibre()] = tempera;
            }
            return paleta;
        }
        private int ObtenerLugarLibre()
        {
            int index=0;
            foreach(Tempera actual in this.colores)
            {
                if (Object.Equals(actual, null))
                {
                    return index;
                }
                index++;
            }

            return -1;
            
        }

        public static int operator |(Paleta paleta,Tempera tempera)
        {
            return Array.IndexOf(paleta.colores, tempera);
        }

    }
}
