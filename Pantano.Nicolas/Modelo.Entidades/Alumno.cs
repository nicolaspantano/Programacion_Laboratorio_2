using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Alumno
    {
        #region Atributos
        private string _apellido;
        private int _legajo;
        private string _nombre;
        private float _nota;
        #endregion

        #region Propiedades
        public string Apellido
        {
            get
            {
                return this._apellido;
            }
            set
            {
                this._apellido = value;
            }
        }

        public int Legajo
        {
            get
            {
                return this._legajo;
            }
            set
            {
                this._legajo = value;
            }
        }
        public string Nombre
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
        public float Nota
        {
            get
            {
                return this._nota;
            }
            set
            {
                this._nota = value;
            }
        }
        #endregion

        #region Constructores
        public Alumno(int legajo,string nombre,string apellido)
        {
            this.Legajo = legajo;
            this.Nombre = nombre;
            this.Apellido = apellido;
        }

        public Alumno(int legajo, string nombre, string apellido, float nota):this(legajo,nombre,apellido)
        {
            this.Nota = nota;
        }
        #endregion

        #region Metodos
        private string Mostrar()
        {
            return this.Apellido + ", " + this.Nombre + " - Legajo: " + this.Legajo.ToString() + " - Nota: " + this.Nota.ToString(); 
        }

        public static string Mostrar(Alumno alumno)
        {
            return alumno.Mostrar();
        }
        #endregion

        #region Sobrecargas
        public static bool operator ==(Alumno a1, Alumno a2)
        {
            if (a1.Equals(null) || a2.Equals(null))
            {
                return a1.Legajo == a2.Legajo;
            }                       
                return false;           
        }

        public static bool operator !=(Alumno a1, Alumno a2)
        {
            return !(a1 == a2);  
        }
        #endregion
    }
}
