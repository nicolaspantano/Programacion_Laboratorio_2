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
using System.Xml.Serialization;


using Entidades;

namespace AdminPersonas
{
    public partial class FrmPrincipal : Form
    {

        System.Data.SqlClient.SqlConnection conexion;

        private List<Persona> lista;

        public FrmPrincipal()
        {
            InitializeComponent();

            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;

            this.lista = new List<Persona>();
            this.conexion = new System.Data.SqlClient.SqlConnection(Properties.Settings.Default.Conexion);



            //System.Data.SqlClient.sqñ
        }

        private void cargarArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog.ShowDialog();
                XmlSerializer ser = new XmlSerializer(typeof(List<Persona>));                
                StreamReader reader = new StreamReader(this.openFileDialog.FileName);
                this.lista=(List<Persona>)ser.Deserialize(reader);
                reader.Close();
            }
            catch(Exception f)
            {
                MessageBox.Show(f.Message);
            }
            //implementar...//
        }

        private void guardarEnArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.saveFileDialog.ShowDialog();
                XmlSerializer ser = new XmlSerializer(typeof(List<Persona>));
                StreamWriter writer = new StreamWriter(this.saveFileDialog.FileName);
                ser.Serialize(writer, this.lista);
                writer.Close();
            }
            catch(Exception f)
            {
                MessageBox.Show(f.Message);
            }
            //implementar...//
        }

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmVisorPersona frm = new frmVisorPersona(this.lista);
                frm.StartPosition = FormStartPosition.CenterScreen;
                this.lista = frm.Lista;
                frm.Show();
            }
            catch(Exception f)
            {
                MessageBox.Show(f.Message);
            }





            //implementar//

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            //implementar //
        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                
                conexion.Open();
                MessageBox.Show("Exito");
                
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
            }
        }

        private void traerTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.conexion.Open();
                System.Data.SqlClient.SqlCommand comando = new System.Data.SqlClient.SqlCommand();
                comando.Connection = this.conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT TOP 1000 [id],[nombre],[apellido],[edad]FROM[personas_bd].[dbo].[personas]";
                System.Data.SqlClient.SqlDataReader reader;
                reader = comando.ExecuteReader();
                while (reader.Read() != false)
                {                    
                    this.lista.Add(new Persona(reader["nombre"].ToString(), reader["apellido"].ToString(), Convert.ToInt16(reader["edad"])));                    
                }
                MessageBox.Show("Exito");
                reader.Close();
                conexion.Close();
            }
            catch(Exception f)
            {
                throw f;
            }
            
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
                
        }

        
    }
}
