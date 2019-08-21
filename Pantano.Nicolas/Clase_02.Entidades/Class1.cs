using System;

namespace Clase_02.Entidades
{
    public class Sello
    {
        public static string mensaje;
        public static ConsoleColor color;
        public static string Imprimir()
        {
            
            return Sello.ArmarFormatoMensaje();
        }

        public static void Borrar()
        {
            Sello.mensaje = null;
        }

        public static void ImprimirEnColor()
        {
            Console.ForegroundColor = color;
            Console.WriteLine(Sello.ArmarFormatoMensaje());
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        static string ArmarFormatoMensaje()
        {
            string techo="";
           
           
            for (int i = 0; i < mensaje.Length+2; i++)
            {
                techo += "*";
            }
            
            return techo+"\n*"+mensaje+"*\n"+techo;
        }
    }
}
