using System;
using Capa_Entidades;
using Capa_ReglasNegocio;
using System.Data;

namespace Seguimiento2
{
    public partial class Login : System.Web.UI.Page
    {

        CentPeliculas oentPeliculas = new CentPeliculas();
        Centusuarios oentusuarios = new Centusuarios();
        CregPeliculas oregPeliculas = new CregPeliculas();
        Cregusuarios oregusuarios = new Cregusuarios();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BTTiniciar_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text.Trim() == "" | txtcontraseña.Text.Trim() == "")
            {
                lblmensajeusua.Text = "Escriba un usuario y contraseña";
            }

            else
            {
                oentusuarios.nom = txtusuario.Text;
                oentusuarios.pass = txtcontraseña.Text;

                DataSet ds = new DataSet();

                ds = oregusuarios.ver_usuarios(oentusuarios);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    Session["inicio"] = txtusuario.Text;
                    Response.Redirect("Index.aspx");
                }
                else
                {
                    lblmensajeusua.Text = "Usuario y/o Contraseña Incorrecta";
                }

            }

        }

        protected void BTTregistrar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registro.aspx");
        }
    }
}