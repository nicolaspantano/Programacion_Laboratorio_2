using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase._29._10
{
    public static class Serializadora
    {
        public static bool Serializar(IXML interfaz)
        {
            return interfaz.Guardar(@"C:\Users\alumno\Desktop\Serializado.xml");
        }

        public static bool Deserializar(IXML interfaz,out object salida)
        {
            salida = null;
            return interfaz.Leer(@"C:\Users\alumno\Desktop\Serializado.xml", out salida);
        }
    }
}
