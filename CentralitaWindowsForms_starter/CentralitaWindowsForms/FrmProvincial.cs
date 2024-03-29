﻿using System;
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
    public partial class FrmProvincial : FormLlamada
    {
        public FrmProvincial()
        {
            InitializeComponent();
         
            foreach(Franja franja in Enum.GetValues(typeof(Franja)))
            {
                this.cmbFranja.Items.Add(franja);
            }                       
        }

        public override Llamada GetLLamada
        {
            get
            {
                return new Provincial(base.txtOrigen.Text,(Franja)this.cmbFranja.SelectedIndex, Convert.ToSingle(base.txtDuracion.Text), base.txtDestino.Text);
            }
        }
    }
}
