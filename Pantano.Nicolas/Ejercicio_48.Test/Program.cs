using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_48.Entidades;

namespace Ejercicio_48.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Contabilidad<Factura, Recibo> contabilidad = new Contabilidad<Factura, Recibo>();
            Recibo r1 = new Recibo(1542);
            Recibo r2 = new Recibo(1000);
            Recibo r3 = new Recibo(1200);

            contabilidad += r1;
            contabilidad += r2;
            contabilidad += r3;

            Factura f1 = new Factura(9874);
            Factura f2 = new Factura(9451);
            Factura f3 = new Factura(9000);

            contabilidad += f1;
            contabilidad += f2;
            contabilidad += f3;

            Console.Read();

        }
    }
}
