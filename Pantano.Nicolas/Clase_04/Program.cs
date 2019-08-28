using System;
using Clase_04.Entidades;

namespace Clase_04
{
    class Program
    {
        static void Main(string[] args)
        {
            

            DateTime fecha = new DateTime(2019,08,25);
            Cosa cosa1 = new Cosa();
            Cosa cosa2 = new Cosa("hola");
            Cosa cosa3 = new Cosa("hola",fecha);
            Cosa cosa4 = new Cosa("hola",fecha,8);



            Console.WriteLine(cosa1.Mostrar());
            Console.WriteLine(cosa2.Mostrar());
            Console.WriteLine(cosa3.Mostrar());
            Console.WriteLine(cosa4.Mostrar());

            Console.ReadKey();
        }
    }
}
