using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_10.Entidades
{
    public class AlumnoCalificado:Alumno
    {
        protected double nota;

        public double Nota { get { return this.nota; } }

        public AlumnoCalificado(Alumno a,double nota) : this(a.Nombre, a.Apellido, a.Legajo, a.Examen, nota) { }
               

        public AlumnoCalificado(string nombre, string apellido, int legajo,ETipoExamen examen, double nota):base(nombre,apellido,legajo,examen)
        {
            this.nota = nota;
        }

        public string Mostrar()
        {
            return Alumno.Mostrar(this) + " - " + this.Nota.ToString();
        }

        public override string ToString()
        {
            return AlumnoCalificado.Mostrar(this);
        }
    }
}
