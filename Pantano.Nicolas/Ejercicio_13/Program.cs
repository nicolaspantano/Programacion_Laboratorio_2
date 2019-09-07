using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            double doble = 120;

            Console.WriteLine(Conversor.DecimalBinario(doble));

            string binario = "1100110";

            Console.WriteLine(Conversor.BinarioDecimal(binario));

            Console.ReadKey();

           
        }
    }
}
