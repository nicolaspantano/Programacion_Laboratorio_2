using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Clase_06;
namespace Clase_07
{
    public partial class MenuTempera : Form
    {
        public MenuTempera()
        {
            InitializeComponent();
            foreach(ConsoleColor c in Enum.GetValues(typeof(ConsoleColor)))
            {
                this.cmbColor.Items.Add(c);
            }
        }

        private void MenuTempera_Load(object sender, EventArgs e)
        {
            cmbColor.SelectedItem = ConsoleColor.Magenta;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt64(txtCantidad.Text) > 100)
            {
                txtCantidad.Text = "100";
            }
            else if (Convert.ToInt64(txtCantidad.Text) < 0)
            {
                txtCantidad.Text = "0";
            }
            
            Tempera t = new Tempera((ConsoleColor)this.cmbColor.SelectedItem, cmbColor.Text, Convert.ToInt32(txtCantidad.Text));

            
            
            MessageBox.Show(t);

            this.Close();
        }
    }
}
