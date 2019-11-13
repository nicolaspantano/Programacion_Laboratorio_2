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
using System.Threading;

using Entidades;
using System.Data.SqlClient;

namespace AdminPersonas
{
    public partial class FrmPrincipal : Form
    {

        System.Data.SqlClient.SqlConnection conexion;
        private DataTable tablaPersonas;
        private List<Persona> lista;
        private SqlDataAdapter adaptador;
        private SqlCommand comando;
        public FrmPrincipal()
        {
            InitializeComponent();

            /*Thread hilo = new Thread(this.CargarDataTable);
            hilo.Start();
            hilo.Abort();*/
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
            this.tablaPersonas = new DataTable("Personas");
            //this.CargarDataTable();

            this.conexion = new System.Data.SqlClient.SqlConnection(Properties.Settings.Default.Conexion);

            this.comando = new SqlCommand();
            this.comando.Connection = this.conexion;
            this.comando.CommandType = CommandType.Text;
            this.comando.CommandText = "select * from personas";

            this.adaptador = new SqlDataAdapter(this.comando.CommandText, this.conexion);
            this.lista = new List<Persona>();

            //Configurando adaptador
            this.adaptador.Fill(this.tablaPersonas);//Carga lo que esta en memoria
            this.adaptador.InsertCommand = new SqlCommand("insert into personas values (@p1, @p2, @p3)", this.conexion);
            this.adaptador.UpdateCommand = new SqlCommand("update personas set nombre = @p1, apellido = @p2, edad = @p3 where id = @p4", this.conexion);
            this.adaptador.DeleteCommand = new SqlCommand("delete from personas whre id = @p1", this.conexion);

            //Configurando parametros de cada comando
            this.adaptador.InsertCommand.Parameters.Add("@p1", SqlDbType.VarChar, 50, "nombre");
            this.adaptador.InsertCommand.Parameters.Add("@p2", SqlDbType.VarChar, 50, "apellido");
            this.adaptador.InsertCommand.Parameters.Add("@p3", SqlDbType.Int, 10, "edad");

            this.adaptador.UpdateCommand.Parameters.Add("@p1", SqlDbType.VarChar, 50, "nombre");
            this.adaptador.UpdateCommand.Parameters.Add("@p2", SqlDbType.VarChar, 50, "apellido");
            this.adaptador.UpdateCommand.Parameters.Add("@p3", SqlDbType.Int, 10, "edad");
            this.adaptador.UpdateCommand.Parameters.Add("@p4", SqlDbType.Int, 10, "id");

            this.adaptador.DeleteCommand.Parameters.Add("@p1", SqlDbType.Int, 10, "id");



            //System.Data.SqlClient.sqñ
        }

        private void CargarDataTable()
        {
            this.conexion.Open();

            this.comando.Connection = this.conexion;
            this.comando.CommandType = CommandType.Text;
            this.comando.CommandText = "select * from personas";

            SqlDataReader reader = this.comando.ExecuteReader();

            this.tablaPersonas.Load(reader);

            this.conexion.Close();
            
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
                MessageBox.Show(f.Message);
            }
            
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
                
        }

        private void visualizarDataTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisorDataTable frmMiDataTable = new frmVisorDataTable(this.tablaPersonas);
            frmMiDataTable.StartPosition = FormStartPosition.CenterScreen;
            frmMiDataTable.ShowDialog();
            if (frmMiDataTable.DialogResult == DialogResult.OK)
            {
                this.adaptador.Update(frmMiDataTable.Table);
            }
        }

        private void sincronizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.adaptador.Update(this.tablaPersonas);
                MessageBox.Show("Pudo sincronizarse el adaptador", "Exito");
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
