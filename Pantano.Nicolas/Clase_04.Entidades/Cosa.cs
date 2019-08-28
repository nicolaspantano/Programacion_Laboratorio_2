using System;

namespace Clase_04.Entidades
{
    public class Cosa
    {
        private int entero;
        private string cadena;
        private DateTime fecha;

        public Cosa()
        {
            this.entero = -1;
            this.cadena = "Sin valor";
            this.fecha = DateTime.Now;
        }

        /*public Cosa(int entero)
        {
            this.EstablecerValor(entero);
        }*/

        public Cosa(string cadena):this()
        {
            this.cadena = cadena;           
        }

        public Cosa(string cadena,DateTime fecha):this(cadena)
        {          
            this.fecha = fecha;           
        }

        public Cosa(string cadena, DateTime fecha, int entero):this(cadena,fecha)
        {
            this.entero = entero;            
        }

        public string Mostrar()
        {
            return this.entero.ToString()+ " - " + this.cadena + " - " + this.fecha.ToString();
        }

        public void EstablecerValor(int numero1)
        {
            this.entero = numero1;
        }

        public void EstablecerValor(string cadena1)
        {
            this.cadena = cadena1;
        }

        public void EstablecerValor(DateTime fecha1)
        {
            this.fecha = fecha1;
        }
    }
}
