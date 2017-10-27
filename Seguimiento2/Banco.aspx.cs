using Capa_Entidades;
using Capa_ReglasNegocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Seguimiento2
{
    public partial class Banco : System.Web.UI.Page
    {
        CentPeliculas oentPeliculas = new CentPeliculas();
        Centusuarios oentusuarios = new Centusuarios();
        CregPeliculas oregPeliculas = new CregPeliculas();
        Cregusuarios oregusuarios = new Cregusuarios();

        ws.DBSoapClient wsconsultausuario = new ws.DBSoapClient();

        CentWsEnviar obj = new CentWsEnviar();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["referencia"] == null)
            {
                Response.Redirect("ComprarPelicula.aspx");


            }

        }

        protected void btnentrar_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text.Trim() == "" | txtpass.Text.Trim() == "")
            {
                //lblmensajeusua.Text = "Escriba un usuario y contraseña";
            }

            else
            {

                obj.peliculas = txtusuario.Text;
                obj.precio = txtpass.Text;
                string[] array = { obj.peliculas, obj.precio };
                

                bool result = wsconsultausuario.GetConsultarUsuarioBanco(array);
                if (result == true)
                {
                    Session["usuariopago"] = txtusuario.Text;
                    Response.Redirect("pagar.aspx");
                }
                else
                {
                    MessageBox.Show("No se pudo guardar su compra");
                    Response.Redirect("ComprarPelicula.aspx");
                }

                ////if (ds.Tables[0].Rows.Count > 0)
                ////{
                ////    Session["inicio"] = txtusuario.Text;
                ////    Response.Redirect("Index.aspx");
                ////}
                //else
                //{
                //    //lblmensajeusua.Text = "Usuario y/o Contraseña Incorrecta";
                //}



            }
        }
    }
}