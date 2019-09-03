using System;

namespace Clase_05.Entidades
{
    public class Tinta
    {
        private ConsoleColor color;
        private ETipoTinta tipo;

        public Tinta()
        {
            this.color = ConsoleColor.Blue;
            this.tipo = ETipoTinta.Comun;
        }

        public Tinta(ConsoleColor color) : this()
        {
            this.color = color;
        }

        public Tinta(ConsoleColor color, ETipoTinta tipo) : this(color)
        {
            this.tipo = tipo;
        }

        private string Mostrar()
        {
            return this.color.ToString() + " - " + this.tipo.ToString();
        }

        public static string Mostrar(Tinta tinta)
        {
            return tinta.Mostrar();
        }

        public static bool operator ==(Tinta tinta1,Tinta tinta2)
        {
            if(Object.Equals(tinta1,null)||Object.Equals(tinta2,null))
            {                                
                    return false;                               
            }
            else if (tinta1.color == tinta2.color && tinta2.tipo == tinta1.tipo)
            {
                return true;
            }
            else
            {
                return false;
            }

               
            
            
        }
        
        public static bool operator !=(Tinta tinta1,Tinta tinta2)
        {
            return !(tinta1 == tinta2);
        }

        public static bool operator ==(Tinta tinta,ConsoleColor color)
        {
            if (tinta.color == color)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Tinta tinta,ConsoleColor color)
        {
            return !(tinta == color);
        }

        public static explicit operator string (Tinta tinta)
        {
            return tinta.Mostrar();
        }
    }
}
