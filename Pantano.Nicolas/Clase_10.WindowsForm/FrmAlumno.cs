using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            this.cmbTipoExamen.SelectedItem = ETipoExamen.Primero;
        }

        
    }
}
