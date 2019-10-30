using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace AdminPersonas
{
    public partial class frmPersona : Form
    {
        private Persona miPersona;

        public Persona Persona
        {
            get { return this.miPersona; }
            
        }       
        public frmPersona()
        {
            InitializeComponent();                        
        }

        public frmPersona(Persona p):this()
        {
            this.miPersona = p;
            this.txtApellido.Text = this.miPersona.apellido;
            this.txtEdad.Text = this.miPersona.edad.ToString();
            this.txtNombre.Text = this.miPersona.nombre;

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            this.miPersona = new Persona(txtNombre.Text, txtApellido.Text, Convert.ToInt16(txtEdad.Text));

            //implementar//

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
