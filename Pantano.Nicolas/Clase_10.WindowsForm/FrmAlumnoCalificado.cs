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
        public FrmAlumnoCalificado(Alumno miAlumno) : base(miAlumno)
        {
            InitializeComponent();
            this.txtApellido.Enabled = false;
            this.txtNombre.Enabled = false;
            this.cmbTipoExamen.Enabled = false;
            
        }

        public AlumnoCalificado AlumnoCalificado
        {       
            get
            {
                return new AlumnoCalificado(this.txtNombre.Text, this.txtApellido.Text, Convert.ToInt32(this.txtLegajo.Text), (ETipoExamen)this.cmbTipoExamen.SelectedItem, Convert.ToDouble(this.txtNota.Text));
            }
        }

        
    }
}
