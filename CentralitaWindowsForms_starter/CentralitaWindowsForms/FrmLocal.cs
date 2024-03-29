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
    public partial class FrmLocal : FormLlamada
    {
        public FrmLocal():base()
        {
            InitializeComponent();
        }

        public override Llamada GetLLamada
        {
            get
            {
                return new Local(base.txtOrigen.Text, Convert.ToSingle(base.txtDuracion.Text), base.txtDestino.Text,Convert.ToSingle(this.txtCosto.Text));
            }
        }
    }
}
