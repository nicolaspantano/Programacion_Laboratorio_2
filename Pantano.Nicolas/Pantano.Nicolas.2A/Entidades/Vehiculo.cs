using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo
    {
        protected Fabricante fabricante;
        protected static Random generadorDeVelocidades;
        protected string modelo;
        protected float precio;
        protected int velocidadMaxima;

        static Vehiculo()
        {
            Vehiculo.generadorDeVelocidades = new Random();
        }

        public Vehiculo(float precio, string modelo, Fabricante fabri) 
        {
            this.precio = precio;
            this.modelo = modelo;
            this.fabricante = fabri;
            
        }

        public Vehiculo(string marca, EPais pais, string modelo, float precio) 
            : this(precio, modelo, new Fabricante(marca, pais))
        {

        }


        public int VelocidadMaxima
        {
            get
            {
                if (this.velocidadMaxima == 0)
                {
                    this.velocidadMaxima = generadorDeVelocidades.Next(100,280);
                }
                return this.velocidadMaxima;
            }
        }

        private static string Mostrar(Vehiculo v)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("FABRICANTE: ");
            sb.AppendLine((string)(v.fabricante));
            sb.Append("MODELO: ");
            sb.AppendLine(v.modelo);
            sb.Append("VELOCIDAD MAXIMA: ");
            sb.AppendLine(v.VelocidadMaxima.ToString());
            sb.Append("PRECIO: ");
            sb.AppendLine(v.precio.ToString());

            return sb.ToString();
        }

        public static bool operator ==(Vehiculo a, Vehiculo b)
        {
            /*if (a.Equals(null) || b.Equals(null))
            {                
                return false;
            }*/
            if (a.modelo == b.modelo&&a.fabricante==b.fabricante)
            {
                return true;
            }
            return false;
            
            //return (a.modelo == b.modelo && a.fabricante == b.fabricante);
        }

        public static bool operator !=(Vehiculo a, Vehiculo b)
        {
            return !(a == b);
        }

        public static explicit operator string(Vehiculo v)
        {
            return Vehiculo.Mostrar(v);
        }
    }
}
