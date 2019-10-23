using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Entidades
{
    public abstract class Vehiculo
    {
        protected double _precio;
    
        public void MostrarPrecio()
        {
            Console.WriteLine(this._precio.ToString());
        }

        public Vehiculo(double precio)
        {
            this._precio = precio;
        }
    }
}
