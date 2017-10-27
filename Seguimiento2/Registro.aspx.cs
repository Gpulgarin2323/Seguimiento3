using System;
using Capa_Entidades;
using Capa_ReglasNegocio;

namespace Seguimiento2
{
    public partial class Registro : System.Web.UI.Page
    {

        CentPeliculas oentPeliculas = new CentPeliculas();
        Centusuarios oentusuarios = new Centusuarios();
        CregPeliculas oregPeliculas = new CregPeliculas();
        Cregusuarios oregusuarios = new Cregusuarios();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void limpiar_campos()
        {
            txtcontraseña.Text = "";
            txtemail.Text = "";
            txtid.Text = "";
            txtnombre.Text = "";
        }

        protected void BTTconfirm_Click(object sender, EventArgs e)
        {

            if (txtid.Text.Trim() == "")
            {
                lblcomunicado.Text = "Digite un id";
                txtid.Focus();
            }
            else
            {
                if (txtnombre.Text.Trim() == "")
                {
                    lblcomunicado.Text = "Digite un usuario/nombre";
                    txtnombre.Focus();
                }

                else
                {
                    if (txtemail.Text.Trim() == "")
                    {
                        lblcomunicado.Text = "digite un correo electronico";
                        txtemail.Focus();
                    }
                    else
                    {
                        if (txtcontraseña.Text.Trim() == "")
                        {
                            lblcomunicado.Text = " porfavor ingrese una contraseña";
                            txtcontraseña.Focus();
                        }

                        else
                        {
                            lblcomunicado.Text = "";

                            oentusuarios.id = txtid.Text;
                            oentusuarios.nom = txtnombre.Text;
                            oentusuarios.email = txtemail.Text;
                            oentusuarios.pass = txtcontraseña.Text;

                            if (oregusuarios.alta_usuarios(oentusuarios))

                            {


                                lblcomunicado.Text = "usuario registrado";
                                Response.Redirect("LOGIN.aspx");
                            }

                            else
                            {
                                lblcomunicado.Text = "Error al registrarse";
                            }






                        }
                    }

                }
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void txtemail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}