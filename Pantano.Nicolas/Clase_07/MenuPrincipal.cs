﻿using System;
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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            IsMdiContainer = true;
        }

        private void administracionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void paletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            //paletaToolStripMenuItem.Enabled= false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frmTempera = new MenuTempera();
            //frmTempera.MdiParent=this;
            frmTempera.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}
