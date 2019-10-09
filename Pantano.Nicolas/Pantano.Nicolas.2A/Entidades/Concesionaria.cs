using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Concesionaria
    {
        private int capacidad;
        private List<Vehiculo> vehiculos;

        private Concesionaria()
        {
            this.vehiculos = new List<Vehiculo>();
        }

        private Concesionaria(int capacidad) : this()
        {
            this.capacidad = capacidad;
        }

        public double PrecioDeAutos
        {
            get
            {
                return this.ObtenerPrecio(EVehiculo.PrecioDeAutos);
            }
        }

        public double PrecioDeMotos
        {
            get
            {
                return this.ObtenerPrecio(EVehiculo.PrecioDeMotos);
            }
        }

        public double PrecioTotal
        {
            get
            {
                return this.ObtenerPrecio(EVehiculo.PrecioTotal);
            }
        }

        public static string Mostrar(Concesionaria c)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Capacidad: ");
            sb.AppendLine(c.capacidad.ToString());
            sb.Append("Total por autos: ");
            sb.AppendLine(c.PrecioDeAutos.ToString());
            sb.Append("Total por motos: ");
            sb.AppendLine(c.PrecioDeMotos.ToString());
            sb.Append("Total: ");
            sb.AppendLine(c.PrecioTotal.ToString());
            sb.Append('*', 40).AppendLine();
            sb.AppendLine("Listado de Vehiculos");
            sb.Append('*', 40).AppendLine();
            
            foreach(Vehiculo actual in c.vehiculos)
            {
                sb.AppendLine(actual.ToString()).AppendLine();
                
            }

            return sb.ToString();

        }

        private double ObtenerPrecio(EVehiculo tipoVehiculo)
        {
            Single acumulador=0;

            switch (tipoVehiculo)
            {
                case EVehiculo.PrecioDeAutos:
                    
                    foreach (Vehiculo actual in this.vehiculos)
                    {
                        if (actual is Auto)
                        {
                            acumulador += (Single)(Auto)actual;
                        }                                                
                    }
                    break;
                    

                case EVehiculo.PrecioDeMotos:
                    
                    foreach (Vehiculo actual in this.vehiculos)
                    {
                        if (actual is Moto)
                        {
                            acumulador += (Moto)actual;

                        }
                    }
                    break;
                    

                case EVehiculo.PrecioTotal:

                    acumulador = (float)(this.PrecioDeAutos + this.PrecioDeMotos);
                    break;
                    
            }

            return acumulador;
        }

        public static implicit operator Concesionaria(int capacidad)
        {
            return new Concesionaria(capacidad);
        }

        public static bool operator ==(Concesionaria c,Vehiculo v)
        {
            foreach(Vehiculo actual in c.vehiculos)
            {
                if(actual == v)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Concesionaria c, Vehiculo v)
        {
            return !(c == v);
        }

        public static Concesionaria operator +(Concesionaria c,Vehiculo v)
        {
            if (c == v)
            {
                Console.WriteLine("El vehiculo ya esta en la concesionaria!!");                
            }
            else if (c.vehiculos.Count == c.capacidad)
            {
                Console.WriteLine("No hay mas lugar en la concesionaria!!");
            }
            else
            {
                c.vehiculos.Add(v);
            }

            return c;
        }
    }
}
