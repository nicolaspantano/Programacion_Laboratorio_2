using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio de bienvenida";
            Console.ForegroundColor = ConsoleColor.Green;

            int acumulador = 0;
            bool flag=true;
            int max=0;
            int min=0;
            int promedio;
            for(int i=0;i<5;i++)
            {
                Console.Write("Ingrese un numero: ");
                int numero = int.Parse(Console.ReadLine());
                acumulador += numero;

                if(flag)
                {
                    max = numero;
                    min = numero;
                    flag = false;

                }

                if (numero>max)
                {
                    max = numero;
                }
                if (numero < min)
                {
                    min = numero;
                    
                }

                
            }
            promedio = acumulador / 5;


            Console.WriteLine("MAX: {0}, MIN {1}, Promedio: {2}",max,min,promedio);
            Console.ReadKey();
        }
    }
}
