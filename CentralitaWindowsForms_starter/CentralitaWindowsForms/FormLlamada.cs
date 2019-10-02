using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaPolimorfismo.Entidades;

namespace CentralitaWindowsForms
{
    public abstract partial class FormLlamada : Form
    {

        public FormLlamada()
        {
            InitializeComponent();
        }
        public abstract Llamada GetLLamada
        {
            get;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
