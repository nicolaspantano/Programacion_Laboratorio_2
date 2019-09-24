using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase_10.Entidades;

namespace Clase_10.WindowsForm
{
    public partial class FrmCatedra : Form
    {
        private Catedra catedra;
        private List<AlumnoCalificado> lista;

        public FrmCatedra()
        {
            InitializeComponent();
            
            this.catedra = new Catedra();
            this.lista = new List<AlumnoCalificado>();
            foreach (ETipoOrdenamiento a in Enum.GetValues(typeof(ETipoOrdenamiento)))
            {
                this. cmbOrdenamiento.Items.Add(a);
            }
            this.cmbOrdenamiento.SelectedItem = ETipoOrdenamiento.LegajoAscendente;
        }

        private void cmbOrdenamiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.cmbOrdenamiento.SelectedItem)
            {
                case ETipoOrdenamiento.ApellidoAscendente:
                   this.catedra.Alumnos.Sort(Alumno.OrdenarPorApellidoAsc);                 
                    break;
                case ETipoOrdenamiento.ApellidoDescendente:
                    this.catedra.Alumnos.Sort(Alumno.OrdenarPorApellidoDesc);
                    break;
                case ETipoOrdenamiento.LegajoAscendente:
                    this.catedra.Alumnos.Sort(Alumno.OrdenarPorLegajoAsc);
                    break;
                case ETipoOrdenamiento.LegajoDescendente:
                    this.catedra.Alumnos.Sort(Alumno.OrdenarPorApellidoDesc);
                    break;
            }

            ActualizarListadoAlumno();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool check = false;

            FrmAlumno frmAlumno = new FrmAlumno();
            frmAlumno.ShowDialog();

            if (frmAlumno.DialogResult == DialogResult.OK)
            {
                check=this.catedra + frmAlumno.Alumno;
                ActualizarListadoAlumno();
            }
        }

        private void ActualizarListadoAlumno()
        {
            this.lstAlumnos.Items.Clear();
            foreach(Alumno actual in this.catedra.Alumnos)
            {
                this.lstAlumnos.Items.Add(actual);
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FrmAlumno frmAlumno = new FrmAlumno(this.catedra.Alumnos[this.lstAlumnos.SelectedIndex]);
            
            frmAlumno.ShowDialog();

            if (frmAlumno.DialogResult == DialogResult.OK)
            {
                catedra.Alumnos[this.lstAlumnos.SelectedIndex] = frmAlumno.Alumno;
                ActualizarListadoAlumno();
            }
            
           
        }
       
        private void btnCalificar_Click(object sender, EventArgs e)
        {
            bool check;
            FrmAlumnoCalificado frmCalificado = new FrmAlumnoCalificado(this.catedra.Alumnos[this.lstAlumnos.SelectedIndex]);
            
            frmCalificado.ShowDialog();

            if (frmCalificado.DialogResult == DialogResult.OK)
            {
                this.lista.Add(frmCalificado.AlumnoCalificado);
                check= this.catedra - this.catedra.Alumnos[this.lstAlumnos.SelectedIndex];
                ActualizarListadoAlumno();
                ActualizarListadoAlumnosCalificados();
                
            }
        }

        

        private void ActualizarListadoAlumnosCalificados()
        {
            this.lstCalificados.Items.Clear();
            foreach(AlumnoCalificado actual in this.lista)
            {
                this.lstCalificados.Items.Add(actual.Mostrar());
            }
        }
    }
}
