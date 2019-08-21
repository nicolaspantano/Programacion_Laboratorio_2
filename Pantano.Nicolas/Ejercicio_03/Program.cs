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
            bool flag=true;
            do
            {
                Console.Write("Ingrese un numero mayor a 0: ");
                numero = int.Parse(Console.ReadLine());

            } while (numero<=0);

            /*Console.Write("Los numeros hasta el {0} son: ",numero);
            for(int i=1;i<numero;i++)
            {
                for(int j=2;j<i;j++)
                {
                    if((i%j)!=0)
                    {
                        Console.WriteLine(i);
                        break;
                    }
                        
                }
            }*/
            for(int i=2;i<numero;i++)
            {


            }
           
            Console.ReadKey();
        }
    }
}
