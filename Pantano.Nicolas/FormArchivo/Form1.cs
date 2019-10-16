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
        DirectoryInfo di = new DirectoryInfo(@"C:\Users\" + Environment.UserName + @"\");

        public Form1()
        {
            InitializeComponent();

            /*foreach(Environment.SpecialFolder item in Enum.GetValues(typeof(Environment.SpecialFolder)))
            {
                this.cmbUbicacion.Items.Add(item);
            }*/

            foreach(var direc in di.GetDirectories())
            {
                cmbUbicacion.Items.Add(direc);
            }
                        
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //StreamWriter writer = new StreamWriter(Environment.GetFolderPath((Environment.SpecialFolder)this.cmbUbicacion.SelectedItem) + @"\" + this.txtNombre.Text, false);
                StreamWriter writer = new StreamWriter(di.ToString() + cmbUbicacion.SelectedItem.ToString() + @"\" + this.txtNombre.Text + ".txt", false);

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
                //StreamReader reader = new StreamReader(Environment.GetFolderPath((Environment.SpecialFolder)this.cmbUbicacion.SelectedItem) + @"\" + this.txtNombre.Text, false);
                StreamReader reader = new StreamReader(di.ToString() +cmbUbicacion.SelectedItem.ToString()+@"\"+ this.txtNombre.Text+ ".txt", false);

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
