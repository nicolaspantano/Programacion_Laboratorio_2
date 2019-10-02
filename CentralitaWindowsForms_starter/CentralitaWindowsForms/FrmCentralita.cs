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
    public partial class FrmCentralita : Form
    {
        Centralita central;
        
        public FrmCentralita()
        {
            central = new Centralita();
            
            InitializeComponent();
            
            
        }

        private void btnLocal_Click(object sender, EventArgs e)
        {
            FrmLocal form = new FrmLocal();
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                this.central.Llamadas.Add(form.GetLLamada);
                ActualizarLista();
            }

        }

        private void ActualizarLista()
        {
            this.lstVisor.Items.Clear();
            foreach(Llamada llamada in central.Llamadas)
            {
                this.lstVisor.Items.Add(llamada);
            }
        }

        private void btnProvincial_Click(object sender, EventArgs e)
        {
            FrmProvincial form = new FrmProvincial();
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                this.central.Llamadas.Add(form.GetLLamada);
                ActualizarLista();
            }

        }

        private void cboOrdenamiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.cboOrdenamiento.SelectedItem)
            {
                case "Ascendente":
                    central.OrdenarLLamadas(1);
                    break;

                case "Descendente":
                    central.OrdenarLLamadas(-1);
                    break;

            }
            ActualizarLista();
        }
    }
}
