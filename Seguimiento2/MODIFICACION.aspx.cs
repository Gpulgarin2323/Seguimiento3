using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa_ReglasNegocio;
using Capa_Entidades;
using System.Data;
using System.Windows.Forms;


namespace Seguimiento2
{
    public partial class MODIFICACION : System.Web.UI.Page
    {

        CentPeliculas oentPeliculas = new CentPeliculas();
        CregPeliculas oregPeliculas = new CregPeliculas();
        Centusuarios oentusuarios = new Centusuarios();
        Cregusuarios oregusuarios = new Cregusuarios();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["inicio_admin"] == null)
                {
                    Response.Redirect("LOGINADMIN.aspx");
                }
            }

        }


        protected void limpiar_campos()
        {
            txtpass.Text = "";
            txtemail.Text = "";
            txtid.Text = "";
            txtnom.Text = "";
        }


        protected void Button1_Click(object sender, EventArgs e)
        {

            if (txtid.Text.Trim() == "")
            {
                lblmensaje.Text = "Digite un id";
                txtid.Focus();
            }
            else
            {
                if (txtnom.Text.Trim() == "")
                {
                    lblmensaje.Text = "Digite un usuario/nombre";
                    txtnom.Focus();
                }

                else
                {
                    if (txtemail.Text.Trim() == "")
                    {
                        lblmensaje.Text = "digite un correo electronico";
                        txtemail.Focus();
                    }
                    else
                    {
                        if (txtpass.Text.Trim() == "")
                        {
                            lblmensaje.Text = " porfavor ingrese una contraseña";
                            txtpass.Focus();
                        }

                        else
                        {
                            lblmensaje.Text = "";

                            oentusuarios.id = txtid.Text;
                            oentusuarios.nom = txtnom.Text;
                            oentusuarios.email = txtemail.Text;
                            oentusuarios.pass = txtpass.Text;

                            if (oregusuarios.alta_usuarios(oentusuarios))

                            {


                                lblmensaje.Text = "Usuario Agregado correctamente";
                                limpiar_campos();
                            }

                            else
                            {
                                lblmensaje.Text = "Error al Agregar el Usuario";
                            }






                        }
                    }

                }
            }


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            oentusuarios.id = txtbid.Text;
            ds = oregusuarios.buscar_usuario(oentusuarios);
            if (ds.Tables[0].Rows.Count == 0)
            {
                lblbusqueda.Text = "usuario no registrado";
                txtbid.Focus();
                lblnom.Text = "";
                lblemail.Text = "";
                lblpass.Text = "";
            }
            else
            {
                lblnom.Text = ds.Tables[0].Rows[0]["nom"].ToString();
                lblemail.Text = ds.Tables[0].Rows[0]["email"].ToString();
                lblpass.Text = ds.Tables[0].Rows[0]["pass"].ToString();
                lblbusqueda.Text = "";
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            oentusuarios.id = txteliusuario.Text;
            if (MessageBox.Show("Desea Eliminar este usuario?", "Anular", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                oregusuarios.eliminar_usuarios(oentusuarios);
                lblmensaje.Text = "usuario eliminado correctamente";
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            oentPeliculas.codpelicula = txtcodpelicula.Text;
            if (MessageBox.Show("Desea Eliminar esta Pelicula?", "Anular", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                oregPeliculas.eliminar_pelicula(oentPeliculas);
                lblmensaje.Text = "Pelicula eliminada correctamente";
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("LOGIN.aspx");
        }
    }
}