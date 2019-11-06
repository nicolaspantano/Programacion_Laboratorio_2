using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AdminPersonas
{
    public partial class frmVisorDataTable : frmVisorPersona
    {
        DataTable table;
        public frmVisorDataTable(DataTable table)
        {
            InitializeComponent();
            this.table = table;
            
            /*foreach (this.table.Rows)
            {
                
            }*/
        }

        public DataTable Table { get {return this.table; } }
    }


}
