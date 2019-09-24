using System;

namespace Clase_10.Entidades
{
    public class Alumno
    {
        protected string apellido;
        protected ETipoExamen examen;
        protected int legajo;
        protected string nombre;

        public string Apellido { get { return this.apellido; } }

        public ETipoExamen Examen { get { return this.examen; } }

        public int Legajo { get { return this.legajo; } }

        public string Nombre { get { return this.nombre; } }

        public Alumno(string nombre,string apellido,int legajo, ETipoExamen examen)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
            this.examen = examen;
        }

        public static string Mostrar(Alumno a)
        {
            return a.nombre + " - " + a.apellido + " - " + a.legajo.ToString() + " - " + a.examen.ToString();
        }

        public static bool operator ==(Alumno a,Alumno b)
        {
            if(a.legajo==b.legajo)
            { return true; }
            else { return false; }
        }
        
        public static bool operator !=(Alumno a,Alumno b)
        {
            return !(a == b);
        }

        public static int OrdenarPorApellidoAsc(Alumno a,Alumno b)
        {
            return string.Compare(a.apellido, b.apellido);
        }

        public static int OrdenarPorApellidoDesc(Alumno a, Alumno b)
        {
            return -1 * OrdenarPorApellidoAsc(a, b);
        }

        public static int OrdenarPorLegajoAsc(Alumno a, Alumno b)
        {
            if (a.legajo > b.legajo)
            {
                return 1;
            }
            else if(a.legajo == b.legajo)
            {
                return 0;
            }
            else { return -1; }
        }

        public static int OrdenarPorALegajoDesc(Alumno a, Alumno b)
        {
            return -1 * OrdenarPorLegajoAsc(a, b);
        }

        public override string ToString()
        {
            return Alumno.Mostrar(this);
        }





    }
}
