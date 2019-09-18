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
            foreach (ETipoOrdenamiento a in Enum.GetValues(typeof(ETipoOrdenamiento)))
            {
                this.cmbOrdenamiento.Items.Add(a);
            }
            this.cmbOrdenamiento.SelectedItem = ETipoOrdenamiento.LegajoAscendente;
        }

        private void cmbOrdenamiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAlumno frmAlumno = new FrmAlumno();
            frmAlumno.ShowDialog();
        }
    }
}
