using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno();
            Alumno alumno2 = new Alumno();
            Alumno alumno3 = new Alumno();

            alumno2.apellido = "Perez";
            alumno2.nombre = "Juan";
            alumno2.legajo = 15236;
            alumno2.Estudiar(1, 2);
            alumno2.CalcularFinal();

            alumno3.apellido = "Diaz";
            alumno3.nombre = "Martin";
            alumno3.legajo = 14798;
            alumno3.Estudiar(8, 8);
            alumno3.CalcularFinal();


            alumno1.apellido = "Fernandez";
            alumno1.nombre = "Fausto";
            alumno1.legajo = 13265;
            alumno1.Estudiar(4, 4);
            alumno1.CalcularFinal();


            Console.WriteLine(alumno1.Mostrar()+"\n");
            Console.WriteLine(alumno2.Mostrar()+"\n");
            Console.WriteLine(alumno3.Mostrar()+"\n");
            

            Console.ReadKey();


        }
    }
}
