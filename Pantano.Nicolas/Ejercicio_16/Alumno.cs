using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;



        public void CalcularFinal()
        {
            Random rnd = new Random();
            if(this.nota1>=4&&this.nota2>=4)
            {
                this.notaFinal = rnd.Next(1, 10);
            }
            else
            {
                this.notaFinal = -1;
            }

        }

        public void Estudiar(byte notaUno,byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;

        }

        public string Mostrar()
        {
            if(this.notaFinal!=-1)
            {
                return this.nombre + " " + this.apellido + "\n" + "Notas: " + this.nota1.ToString() + " - " + this.nota2.ToString() + "\nNota final: " + this.notaFinal.ToString();
                
            }
            else
            {

                return this.nombre + "\n" + this.apellido + "\n" + this.nota1.ToString() + " - " + this.nota2.ToString() + "\nAlumno Desaprobado";

            }

        }

    }
}
