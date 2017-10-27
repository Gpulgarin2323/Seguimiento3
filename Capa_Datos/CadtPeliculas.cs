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
   public class CadtPeliculas
    {

        Conexiones oconexion = new Conexiones();


        public bool eliminar_pelicula(CentPeliculas opelicula)
        {
            try
            {
                SqlCommand ocmd = new SqlCommand();
                ocmd.Connection = oconexion.conectar("bdregistro");
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.CommandText = "eliminar_peliculas";
                ocmd.Parameters.AddWithValue("@codpeliculas", opelicula.codpelicula);
                ocmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message); // solo se ejecuta si hay error
            }
        }



        public DataSet consulta_pelicula1(CentPeliculas opelicula)
        {
            try
            {
                SqlCommand ocmd = new SqlCommand();
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("bdregistro");
                ocmd.CommandText = "consulta_peliculas";
                ocmd.Parameters.AddWithValue("@nombre", opelicula.nombre);
                


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




        public void agregar_pelicula(CentPeliculas opelicula)
        {
            try
            {
                SqlCommand ocmd = new SqlCommand();
                ocmd.Connection = oconexion.conectar("bdregistro");
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.CommandText = "agregar_peliculas";
                ocmd.Parameters.AddWithValue("@codpeliculas", opelicula.codpelicula);
                ocmd.Parameters.AddWithValue("@descripcion", opelicula.descripcion);
                ocmd.Parameters.AddWithValue("@genero", opelicula.genero);
                ocmd.Parameters.AddWithValue("@autor", opelicula.autor);
                ocmd.Parameters.AddWithValue("@nombre", opelicula.nombre);
                ocmd.Parameters.AddWithValue("@foto", opelicula.foto);
                ocmd.Parameters.AddWithValue("@precio", opelicula.precio);

                ocmd.ExecuteNonQuery();

            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        public DataSet consulta_peliculadll(CentPeliculas opelicula)
        {
            try
            {
                SqlCommand ocmd = new SqlCommand();
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("bdregistro");
                ocmd.CommandText = "consulta_peliculasddl";
                
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
        public DataSet consulta_preciopelicula(CentPeliculas opelicula)
        {
            try
            {
                SqlCommand ocmd = new SqlCommand();
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("bdregistro");
                ocmd.CommandText = "consulta_precio";
                ocmd.Parameters.AddWithValue("@nombre", opelicula.nombre);

                SqlDataAdapter da = new SqlDataAdapter(ocmd);
                if(da != null)
                {
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    return ds;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }


    }

}
    