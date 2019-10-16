using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FormArchivo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            foreach(Environment.SpecialFolder item in Enum.GetValues(typeof(Environment.SpecialFolder)))
            {
                this.cmbUbicacion.Items.Add(item);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter writer = new StreamWriter(@"C:\Users\alumno\" +this.cmbUbicacion.SelectedItem.ToString() +@"\"+this.txtNombre.Text,false);
                writer.WriteLine(txtTexto.Text);
                writer.Close();
               
            }
            catch(Exception)
            {
                this.txtTexto.Text = "Error";
            }
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader reader = new StreamReader(@"C:\Users\alumno\" + this.cmbUbicacion.SelectedItem.ToString() + @"\" + this.txtNombre.Text, false);
                this.txtTexto.Text = reader.ReadToEnd();
                reader.Close();
            }
            catch (Exception)
            {
                this.txtTexto.Text = "Error";
            }
        }
    }
}
