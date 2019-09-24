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
    public partial class FrmAlumnoCalificado : FrmAlumno
    {

        public FrmAlumnoCalificado()
        {
            InitializeComponent();

        }

        public AlumnoCalificado Alumno
        {
            set
            {
                this.txtNombre.Text = value.Nombre;
                this.txtApellido.Text = value.Apellido;
                this.txtLegajo.Text = value.Legajo.ToString();
                this.cmbTipoExamen.SelectedItem = value.Examen;

                this.txtNombre.Enabled = false;
                this.txtApellido.Enabled = false;
                this.txtLegajo.Enabled = false;
                this.cmbTipoExamen.Enabled = false;
            }

            get
            {
                return new AlumnoCalificado(this.txtNombre.Text, this.txtApellido.Text, Convert.ToInt32(this.txtLegajo.Text), (ETipoExamen)this.cmbTipoExamen.SelectedItem, Convert.ToInt32(this.txtNota.Text));
            }
        }
    }
}
