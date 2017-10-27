using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Seguimiento2
{
    /// <summary>
    /// webservice para consumir los bancos
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class DB : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        [WebMethod]
        public DataSet Getdbpeliculas()
        {

             SqlConnection oconectar = new SqlConnection("Data Source=DESKTOP-OQ7Q3GE\\PRUEBASSQL;Initial Catalog=registro;User ID=sapeliculasdb;Password=1234");
            //SqlConnection oconectar = new SqlConnection("Data Source=german1cero1\\empresa;Initial Catalog=registro;User ID=sa;Password=1Cero12017$");
            oconectar.Open(); //abrir la base de datos   
            SqlCommand ocmd = new SqlCommand("consulta_bancos", oconectar);

            SqlDataAdapter da = new SqlDataAdapter(ocmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            oconectar.Close();
            return ds;
        }

        [WebMethod]
        public Boolean GetInsertarCompraPelicula(string[] oent)
        {

            SqlConnection oconectar = new SqlConnection("Data Source=DESKTOP-OQ7Q3GE\\PRUEBASSQL;Initial Catalog=registro;User ID=sapeliculasdb;Password=1234");
            // SqlConnection oconectar = new SqlConnection("Data Source=german1cero1\\empresa;Initial Catalog=registro;User ID=sa;Password=1Cero12017$");
            oconectar.Open(); //abrir la base de datos   
            SqlCommand ocmd = new SqlCommand("agregar_comprapelicula", oconectar);
            ocmd.CommandType = CommandType.StoredProcedure;
            ocmd.Parameters.Clear();
            ocmd.Parameters.AddWithValue("@NombrePelicula", oent[0].ToString());
            ocmd.Parameters.AddWithValue("@precio", Convert.ToInt32(oent[1]));
            ocmd.Parameters.AddWithValue("@nombre", oent[2].ToString());
            ocmd.Parameters.AddWithValue("@apellidos", oent[3].ToString());
            ocmd.Parameters.AddWithValue("@direccion", oent[4].ToString());
            ocmd.Parameters.AddWithValue("@ciudad", oent[5].ToString());
            ocmd.Parameters.AddWithValue("@departamento", oent[6].ToString());
            ocmd.Parameters.AddWithValue("@telefono", oent[7].ToString());
            ocmd.Parameters.AddWithValue("@banco", oent[8].ToString());
            ocmd.Parameters.AddWithValue("@referencia", oent[9].ToString());
            ocmd.Parameters.AddWithValue("@estadocompra", "pendiente");


            if (ocmd.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        [WebMethod]
        public DataSet Getdbpeliculaapagar()
        {

            SqlConnection oconectar = new SqlConnection("Data Source=DESKTOP-OQ7Q3GE\\PRUEBASSQL;Initial Catalog=registro;User ID=sapeliculasdb;Password=1234");
            //SqlConnection oconectar = new SqlConnection("Data Source=german1cero1\\empresa;Initial Catalog=registro;User ID=sa;Password=1Cero12017$");
            oconectar.Open(); //abrir la base de datos   
            SqlCommand ocmd = new SqlCommand("consulta_peliculaapagar", oconectar);

            SqlDataAdapter da = new SqlDataAdapter(ocmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            oconectar.Close();
            return ds;
        }

        [WebMethod]
        public Boolean GetConsultarUsuarioBanco(string[] oent)
        {

            SqlConnection oconectar = new SqlConnection("Data Source=DESKTOP-OQ7Q3GE\\PRUEBASSQL;Initial Catalog=registro;User ID=sapeliculasdb;Password=1234");
            //SqlConnection oconectar = new SqlConnection("Data Source=german1cero1\\empresa;Initial Catalog=registro;User ID=sa;Password=1Cero12017$");
            oconectar.Open(); //abrir la base de datos   
            SqlCommand ocmd = new SqlCommand("ver_usuariosbanco", oconectar);
            ocmd.CommandType = CommandType.StoredProcedure;
            ocmd.Parameters.AddWithValue("@user", oent[0].ToString());
            ocmd.Parameters.AddWithValue("@pass", oent[1].ToString());
            SqlDataAdapter da = new SqlDataAdapter(ocmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            SqlDataReader reg = null;

             reg = ocmd.ExecuteReader();

            if (reg.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        [WebMethod]
        public Boolean GetPagoFinal(string[] oent)
        {

            SqlConnection oconectar = new SqlConnection("Data Source=DESKTOP-OQ7Q3GE\\PRUEBASSQL;Initial Catalog=registro;User ID=sapeliculasdb;Password=1234");
            //SqlConnection oconectar = new SqlConnection("Data Source=german1cero1\\empresa;Initial Catalog=registro;User ID=sa;Password=1Cero12017$");
            oconectar.Open(); //abrir la base de datos   
            SqlCommand ocmd = new SqlCommand("pelicula_pagofinal", oconectar);
            ocmd.CommandType = CommandType.StoredProcedure;
            ocmd.Parameters.AddWithValue("@referencia", oent[0].ToString());
            ocmd.Parameters.AddWithValue("@user", oent[1].ToString());
            SqlDataAdapter da = new SqlDataAdapter(ocmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            //SqlDataReader reg = null;
            //reg = ocmd.ExecuteReader();

            if (ocmd.ExecuteNonQuery() == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }

}
