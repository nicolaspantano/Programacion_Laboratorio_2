using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces.Entidades;

namespace Interfaces.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Privado privado = new Privado(100, 450, 10);
            Comercial comercial = new Comercial(200, 450, 10);
            Deportivo deportivo = new Deportivo(1000, "ADE989", 120);

            privado.MostrarPrecio();
            comercial.MostrarPrecio();
            deportivo.MostrarPrecio();

            Console.WriteLine(Gestion.MostrarImpuestoNacional(privado));
            Console.WriteLine(Gestion.MostrarImpuestoNacional(comercial));
            Console.WriteLine(Gestion.MostrarImpuestoNacional(deportivo));

            Console.ReadLine();
        }
    }
}
