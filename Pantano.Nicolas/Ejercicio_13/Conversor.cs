using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    class Conversor
    {
        public static string DecimalBinario(double doble)
        {
            string binario="";

            while(doble>1)
            {
                if (doble % 2 == 0)
                {
                    binario = "0" + binario;
                }
                else
                {
                    binario = "1" + binario;
                }

                doble = doble / 2; 
            }


            return binario;
        }

        public static double BinarioDecimal(string binario)
        {
            double doble=0;
            
            int exponente = 0;

            
           
            for (int i = (binario.Length)-1; i>=0; i--)
            {
                               
                if (binario[i]=='1')
                {
                    if(i==(binario.Length)-1)
                    {
                        doble += 1;
                        continue;
                       
                    }
                    else
                    {
                        doble +=Math.Pow(2,exponente);
                        
                    }
                    
                }

                exponente++;

            }

            
            return doble;

        }
    }
}




    

