using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int acumulador = 1;
            int contador = 0;
            
            for(int i=3;i>1;i++)
            {
                for(int j=2;j<i;j++)
                {
                    if(i%j==0)
                    {
                        acumulador += j;
                    }
                }
                if(acumulador==i)
                {
                    Console.WriteLine(i);
                    contador++;
                }
                acumulador = 1;
                if(contador==4)
                {
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
