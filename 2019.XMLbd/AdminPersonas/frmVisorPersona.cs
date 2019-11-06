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
using System.Data.SqlClient;
namespace AdminPersonas
{
    public partial class frmVisorPersona : Form
    {
        System.Data.SqlClient.SqlConnection conexion;
        private List<Persona> listaVisor;
        public frmVisorPersona()
        {
            InitializeComponent();
            this.conexion = new System.Data.SqlClient.SqlConnection(Properties.Settings.Default.Conexion);
            
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

                try
                {
                    conexion.Open();
                    System.Data.SqlClient.SqlCommand comando = new System.Data.SqlClient.SqlCommand();
                    comando.Connection = conexion;
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "Insert into Personas(nombre,apellido,edad) values('"+frm.Persona.nombre + "','" + frm.Persona.apellido + "'," + frm.Persona.edad + ')';
                    comando.ExecuteNonQuery();
                    conexion.Close();
                }
                catch(Exception f)
                {
                    throw f;
                }

            }

            //implementar//

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmPersona frm = new frmPersona(this.listaVisor[this.lstVisor.SelectedIndex]);
            int id;
            id = this.GetId(frm.Persona);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {

                this.listaVisor[this.lstVisor.SelectedIndex] = frm.Persona;
               

                try
                {
                    
                    conexion.Open();                    
                    System.Data.SqlClient.SqlCommand comando = new System.Data.SqlClient.SqlCommand();
                    comando.Connection = conexion;
                    comando.CommandType = CommandType.Text;                    
                    comando.CommandText = "Update Personas set nombre='" + frm.Persona.nombre + "',apellido='" + frm.Persona.apellido + "',edad=" + frm.Persona.edad + "where id="+id;
                    comando.ExecuteNonQuery();
                    conexion.Close();
                }
                catch(Exception f)
                {
                    throw f;
                }
                this.ActualizarLista();
            }


            //command.update = update Personas set nombre = "otroNombre", apellido = "otroApellido", edad=otraEdad  where id = 8
            //implementar//
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
                                                           
            if(this.lstVisor.SelectedIndex != -1)
            {
                frmPersona frm = new frmPersona(this.listaVisor[this.lstVisor.SelectedIndex]);
                int id = this.GetId(frm.Persona);
                try
                {
                    this.Lista.RemoveAt(this.lstVisor.SelectedIndex);
                    System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand();
                    this.conexion.Open();
                    command.Connection = this.conexion;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "delete from Personas where id = " + id;
                    command.ExecuteNonQuery();
                    this.conexion.Close();
                    this.ActualizarLista();                                        
                }
                catch(Exception f)
                {
                    MessageBox.Show(f.Message);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una persona de la lista");
            }

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

        private int GetId(Persona p1)
        {
            this.conexion.Open();
            int id=-1;
            System.Data.SqlClient.SqlCommand comando = new System.Data.SqlClient.SqlCommand();
            comando.Connection = this.conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT TOP 1000 [id],[nombre],[apellido],[edad]FROM[personas_bd].[dbo].[personas]";
            System.Data.SqlClient.SqlDataReader reader;            
            reader = comando.ExecuteReader();
            while (reader.Read() != false)
            {
                if (reader["nombre"].ToString() == p1.nombre && reader["apellido"].ToString() == p1.apellido && Convert.ToInt16(reader["edad"]) == p1.edad)
                {
                    
                    id= Convert.ToInt16(reader["id"]);
                }
                   
            }
            reader.Close();
            this.conexion.Close();
            return id;
            
        }

       
        
    }
}
