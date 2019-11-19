using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Externa.Sellada;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Clase.Ultima
{
    public static class ClaseEstatica
    {
        public static string Mostrar(this PersonaExternaSellada p1)
        {
            return String.Format("{0}, {1} - {2} - {3}", p1.Apellido, p1.Nombre, p1.Edad, p1.Sexo);
        }

        public static bool EsNulo(this object obj)
        {
            if (object.Equals(obj, null))
            {
                return true;
            }
            return false;
        }

        public static List<Persona> ObtenerListadoDB(this List<Persona> personas)
        {            
            try
            {
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.Conexion);
                SqlCommand comando = new SqlCommand();
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT TOP 1000 [id],[nombre],[apellido],[edad]FROM[personas_bd].[dbo].[personas]";
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    personas.Add(new Persona(reader["nombre"].ToString(), reader["apellido"].ToString(), Convert.ToInt16(reader["edad"])));
                }
                return personas;
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}
