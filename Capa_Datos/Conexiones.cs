using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Capa_Datos
{
    public class Conexiones
    {

        public SqlConnection conectar(string Cnx) // es una funcion para abrir la base de datos
        {
            try  // desactiva la recoleccion automatica de errores
            {

                SqlConnection oconectar = new SqlConnection("Data Source=DESKTOP-OQ7Q3GE\\PRUEBASSQL;Initial Catalog=registro;User ID=sapeliculasdb;Password=1234");
                //SqlConnection oconectar = new SqlConnection("Data Source=german1cero1\\empresa;Initial Catalog=registro;User ID=sa;Password=1Cero12017$");
                oconectar.Open(); //abrir la base de datos   
                //oconectar.Close();
                return oconectar; //se lo retorna al q lo necesite
               
            }
            catch (Exception err)
            {
                throw new Exception(err.Message); // solo se ejecuta si hay error
            }
        }
    }
}
