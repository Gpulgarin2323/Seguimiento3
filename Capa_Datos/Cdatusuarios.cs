using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Capa_Entidades;

namespace Capa_Datos
{
    public class Cdatusuarios
    {
        Conexiones oconexion = new Conexiones();
        public bool alta_usuarios(Centusuarios ousuarios)
        {
            try
            {
                SqlCommand ocmd = new SqlCommand();
                ocmd.Connection = oconexion.conectar("bdregistro");
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.CommandText = "alta_usuarios";
                ocmd.Parameters.AddWithValue("@id", ousuarios.id);
                ocmd.Parameters.AddWithValue("@nom", ousuarios.nom);
                ocmd.Parameters.AddWithValue("@email", ousuarios.email);
                ocmd.Parameters.AddWithValue("@pass", ousuarios.pass);
                ocmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        public bool eliminar_usuarios(Centusuarios ousuarios)
        {
            try
            {
                SqlCommand ocmd = new SqlCommand();
                ocmd.Connection = oconexion.conectar("bdregistro");
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.CommandText = "eliminar_usuarios";
                ocmd.Parameters.AddWithValue("@id", ousuarios.id);
                ocmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message); // solo se ejecuta si hay error
            }
        }
        public DataSet buscar_usuario(Centusuarios ousuarios)
        {
            try
            {
                SqlCommand ocmd = new SqlCommand();
                ocmd.Connection = oconexion.conectar("bdregistro");
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.CommandText = "buscar_usuario";
                ocmd.Parameters.AddWithValue("@id", ousuarios.id);
                SqlDataAdapter da = new SqlDataAdapter(ocmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message); // solo se ejecuta si hay error
            }
        }


        public DataSet ver_usuarios(Centusuarios ousuarios)
        {
            try
            {
                SqlCommand ocmd = new SqlCommand();
                ocmd.Connection = oconexion.conectar("bdregistro");
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.CommandText = "ver_usuarios";
                ocmd.Parameters.AddWithValue("@nom", ousuarios.nom);
                ocmd.Parameters.AddWithValue("@pass", ousuarios.pass);
                SqlDataAdapter da = new SqlDataAdapter(ocmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }
    }
}
