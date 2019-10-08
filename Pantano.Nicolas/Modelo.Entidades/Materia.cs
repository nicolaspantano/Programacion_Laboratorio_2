using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Materia
    {
        #region Atributos
        private List<Alumno> _alumnos;
        private EMateria _nombre;
        private static Random _notaParaUnAlumno;
        #endregion

        #region Propiedades
        public List<Alumno> Alumnos
        {
            get
            {
                return this._alumnos;
            }
            set
            {
                this._alumnos = value;
            }
                    
        }

        public EMateria Nombre
        {
            get
            {
                return this._nombre;
            }
            set
            {
                this._nombre = value;
            }
        }
        #endregion

        #region Constructores
        static Materia()
        {
            Materia._notaParaUnAlumno = new Random();
        }

        private Materia(EMateria nombre):this()
        {
            this.Nombre = nombre;
        }

        private Materia()
        {
            this.Alumnos = new List<Alumno>();
        }
        #endregion

        #region Metodos
        public void CalificarAlumnos()
        {
          foreach(Alumno actual in this.Alumnos)
            {
                actual.Nota = Materia._notaParaUnAlumno.Next(1, 10);
            }   
        }

        private string Mostrar()
        {
            StringBuilder sb=new StringBuilder();
            sb.AppendLine("\nMateria: "+this.Nombre);
            sb.Append('*', 39).AppendLine();
            sb.Append('*', 16);
            sb.Append("ALUMNOS");
            sb.Append('*', 16).AppendLine().AppendLine();

            foreach(Alumno actual in this.Alumnos)
            {
                sb.AppendLine(Alumno.Mostrar(actual));
            }
            return sb.ToString();
        }
        #endregion

        #region Sobrecargas
        public static explicit operator string(Materia materia)
        {
            return materia.Mostrar();
        }

        public static implicit operator float(Materia m)
        {
            float acumulador=0;

            foreach(Alumno actual in m.Alumnos)
            {
                acumulador += actual.Nota;
            }

            return acumulador / m.Alumnos.Count;
        }

        public static implicit operator Materia(EMateria nombre)
        {
            return new Materia(nombre);   
        }

        public static bool operator ==(Materia m,Alumno a)
        {
            return m.Alumnos.Contains(a);        
        }

        public static bool operator !=(Materia m,Alumno a)
        {
            if (m.Equals(null))
            {
                return false;
            }
            return !(m == a);
        }
        
        public static Materia operator +(Materia m,Alumno a)
        {
            if (m != a)
            {
                m.Alumnos.Add(a);
                Console.WriteLine("Se agrego el alumno a la materia: " + m.Nombre + "!!!");
            }
            else
            {
                Console.WriteLine("El alumno ya esta en la materia: " + m.Nombre + "!!!");

            }

            return m;
        }

        public static Materia operator -(Materia m,Alumno a)
        {
            if (m == a)
            {
                m.Alumnos.Remove(a);
                Console.WriteLine("Se quito el alumno de la materia: " + m.Nombre + "!!!");
            }
            else
            {
                Console.WriteLine("El alumno no esta en la materia :" + m.Nombre + "!!!");
            }
            return m;
        }
        #endregion
    }
}
