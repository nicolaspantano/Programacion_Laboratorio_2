using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_10.Entidades
{
     public class Catedra
    {
        private List<Alumno> alumnos;

        public List<Alumno> Alumnos { get { return this.alumnos; } }

        public Catedra()
        {
            this.alumnos = new List<Alumno>();
        }

        public static int operator |(Alumno a, Catedra c)
        {
            return c.alumnos.IndexOf(a);
            
        }

        public static bool operator ==(Catedra c,Alumno a)
        {
            return c.alumnos.Contains(a);
        }

        public static bool operator !=(Catedra c,Alumno a)
        {
            return !(c == a);
        }

        public static bool operator -(Catedra c,Alumno a)
        {
            return c.alumnos.Remove(a);

        }

        public static bool operator +(Catedra c,Alumno a)
        {
            int index;
            index = a | c;

            if (index != -1)
            {
                return false;
            }
            else
            {
                c.alumnos.Add(a);
                return true;
            }
           
        }
    }
}
