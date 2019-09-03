using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_05.Entidades
{
    class Pluma
    {
        private string marca;
        private Tinta tinta;
        private int cantidad;

        public Pluma()
        {
            this.marca = "Sin marca";
            this.tinta = null;
            this.cantidad = 0;
        }
        public Pluma(string marca):this()
        {
            this.marca = marca;
        }
        public Pluma(string marca,Tinta tinta):this(marca)
        {
            this.tinta = tinta;
        }
        public Pluma(string marca, Tinta tinta, int cantidad) : this(marca, tinta)
        {
            this.cantidad = cantidad;
        }

        private string Mostrar()
        {
            return this.marca + " - " + (string)this.tinta + " - " + this.cantidad.ToString();
        }

        public static implicit operator string(Pluma pluma)
        {
            return pluma.Mostrar();
        }
        
        public static bool operator ==(Pluma pluma, Tinta tinta)
        {
            return pluma.tinta == tinta;
        }
        
        public static bool operator !=(Pluma pluma,Tinta tinta)
        {
            return !(pluma == tinta);
        }
        
        public static Pluma operator +(Pluma pluma,Tinta tinta)
        {
            if (pluma == tinta&&pluma.cantidad<100)
            {
                pluma.cantidad++;
            }
            return pluma;
        }
    }
}
