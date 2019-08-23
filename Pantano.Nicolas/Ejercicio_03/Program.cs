using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            bool flag = true;
            int i;

            do
            {
                Console.Write("Ingrese un numero mayor a 0: ");
                numero = int.Parse(Console.ReadLine());

            } while (numero <= 0);

            for (int j = 3; j < numero; j++)
            {
                for ( i = 2; i < j; i++)
                {
                    if (j % i == 0)
                    {
                        flag = false;
                        break;
                    }

                }
                if (flag == true)
                {
                    Console.WriteLine(i);
                }
                flag = true;
          
            }
           
            Console.ReadKey();
        }
    }
}
