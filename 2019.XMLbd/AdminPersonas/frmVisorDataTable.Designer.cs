namespace AdminPersonas
{
    partial class frmVisorDataTable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAgregarDb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(307, 236);
            // 
            // btnAgregarDb
            // 
            this.btnAgregarDb.Location = new System.Drawing.Point(143, 236);
            this.btnAgregarDb.Name = "btnAgregarDb";
            this.btnAgregarDb.Size = new System.Drawing.Size(103, 23);
            this.btnAgregarDb.TabIndex = 4;
            this.btnAgregarDb.Text = "Agregar a DB";
            this.btnAgregarDb.UseVisualStyleBackColor = true;
            this.btnAgregarDb.Click += new System.EventHandler(this.btnAgregarDb_Click);
            // 
            // frmVisorDataTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAgregarDb);
            this.Name = "frmVisorDataTable";
            this.Text = "frmVisorDataTable";
            this.Controls.SetChildIndex(this.lstVisor, 0);
            this.Controls.SetChildIndex(this.btnAgregar, 0);
            this.Controls.SetChildIndex(this.btnModificar, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.Controls.SetChildIndex(this.btnAgregarDb, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarDb;
    }
}