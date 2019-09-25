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
    public partial class FrmAlumno : Form
    {
        public FrmAlumno()
        {
            InitializeComponent();
            foreach(ETipoExamen a in Enum.GetValues(typeof(ETipoExamen)))
            {
                this.cmbTipoExamen.Items.Add(a);
            }
            this.cmbTipoExamen.SelectedItem = ETipoExamen.Final;
           
        }
        
        public FrmAlumno(Alumno alumno):this()
        {
            this.txtApellido.Text = alumno.Apellido;
            this.txtNombre.Text = alumno.Nombre;
            this.txtLegajo.Text = alumno.Legajo.ToString();
            this.cmbTipoExamen.SelectedItem = alumno.Examen;
            this.txtLegajo.Enabled = false;
        }
        public Alumno Alumno
        {
            get {
                return new Alumno(this.txtNombre.Text, this.txtApellido.Text, Convert.ToInt32(this.txtLegajo.Text),(ETipoExamen)this.cmbTipoExamen.SelectedIndex);
                }
           
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected virtual void btnAceptar_Click(object sender, EventArgs e)
        {
            if(this.txtApellido.Text!=""&&this.txtNombre.Text!=""&&this.txtLegajo.Text!="")
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Faltan datos");
            }
            
        }
    }
}
