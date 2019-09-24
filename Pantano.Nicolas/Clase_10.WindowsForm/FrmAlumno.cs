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

        public Alumno Alumno
        {
            get {
                return new Alumno(txtNombre.Text, txtApellido.Text, Convert.ToInt32(txtLegajo.Text),(ETipoExamen)this.cmbTipoExamen.SelectedIndex);
                }
            set
            {
               this.txtApellido.Text = value.Apellido;
                this.txtNombre.Text = value.Nombre;
                this.txtLegajo.Text = value.Legajo.ToString();
                this.cmbTipoExamen.SelectedItem = value.Examen;
                this.txtLegajo.Enabled = false;
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
