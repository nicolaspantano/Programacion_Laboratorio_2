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
    public partial class frmVisorPersona : Form
    {
        private List<Persona> listaVisor;
        public frmVisorPersona()
        {
            InitializeComponent();
            
            
        }

        public frmVisorPersona(List<Persona> l) : this()
        {
            this.listaVisor = l;
            this.ActualizarLista();
        }

       public List<Persona> Lista
        {
            get { return this.listaVisor; }
            
        }        
            
        

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmPersona frm = new frmPersona();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {                
                this.listaVisor.Add(frm.Persona);
                ActualizarLista();
                
            }
           
            //implementar//

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmPersona frm = new frmPersona(this.listaVisor[this.lstVisor.SelectedIndex]);
            frm.StartPosition = FormStartPosition.CenterScreen;
            if (frm.DialogResult == DialogResult.OK)
            {
                this.listaVisor[this.lstVisor.SelectedIndex] = frm.Persona;
                this.ActualizarLista();
            }


            //implementar//
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.listaVisor.Remove(this.listaVisor[this.lstVisor.SelectedIndex]);
            this.ActualizarLista();
            
            //implementar
        }

        private void ActualizarLista()
        {
            this.lstVisor.Items.Clear();
            foreach(Persona actual in listaVisor)
            {
                this.lstVisor.Items.Add(actual);
            }
        }

       
        
    }
}
