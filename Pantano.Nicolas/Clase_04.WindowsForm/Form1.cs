using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase_04.Entidades;

namespace Clase_04.WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cosa cosa1 = new Cosa(this.txtCadena.Text,DateTime.Parse(this.txtFecha.Text),int.Parse(this.txtEntero.Text));

            MessageBox.Show(cosa1.Mostrar());
            lstListado.Items.Add(cosa1.Mostrar());
        }
    }
}
