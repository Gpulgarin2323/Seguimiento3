using System;
using Capa_Entidades;
using Capa_ReglasNegocio;
using System.Data;
using System.IO;

namespace Seguimiento2
{
    public partial class index : System.Web.UI.Page
    {
        CentPeliculas oentPeliculas = new CentPeliculas();
        Centusuarios oentusuarios = new Centusuarios();
        CregPeliculas oregPeliculas = new CregPeliculas();
        Cregusuarios oregusuarios = new Cregusuarios();

        protected void limpiar_campos()
        {
            lblautor.Text = "";
            lblcodigo.Text = "";
            lbldescripcion.Text = "";
            lblgenero.Text = "";
            lblnombre.Text = "";



        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["inicio"] == null)
                {
                    Response.Redirect("LOGIN.aspx");
                }
            }
        }

        /*

        System.Drawing.Image foto = bytes_a_imagen(oentlibros.foto);
        foto.Save(Server.MapPath("~/") + "nuevo.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

        pcbfoto.ImageUrl = "~/nuevo.jpg";
        pcbfoto.DataBind();

*/



        //metodo para convertir de bytes a imagen
        private System.Drawing.Image bytes_a_imagen(Byte[] foto)
        {
            if (!(foto == null))
            {
                MemoryStream codi = new MemoryStream(foto);
                System.Drawing.Image resultado = System.Drawing.Image.FromStream(codi);
                return resultado;
            }
            else
            {
                return null;
            }
        }
    

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("LOGIN.aspx");
        }

        protected void BTTagregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Reg_peliculas.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
            oentPeliculas.nombre = txtnombre.Text.Trim();

            DataSet ds = new DataSet();
            ds = oregPeliculas.consulta_pelicula1(oentPeliculas);
            if (ds.Tables[0].Rows.Count == 0)
            {
                lblmensaje.Text = "Pelicula no registrado";
                limpiar_campos();
                txtnombre.Focus();
            }
            else
            {
                lblcodigo.Text = ds.Tables[0].Rows[0]["codPeliculas"].ToString();
                lbldescripcion.Text = ds.Tables[0].Rows[0]["descripcion"].ToString();
                lblgenero.Text = ds.Tables[0].Rows[0]["genero"].ToString();
                lblnombre.Text = ds.Tables[0].Rows[0]["nombre"].ToString();
                lblautor.Text = ds.Tables[0].Rows[0]["autor"].ToString();
                System.Drawing.Image foto = bytes_a_imagen(oentPeliculas.foto);
                pcbfoto.ImageUrl = ds.Tables[0].Rows[0]["foto"] + "~" + ViewState["foto"];
                pcbfoto.DataBind();




            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("LOGINADMIN.aspx");
        }

        protected void btnComprar_Click(object sender, EventArgs e)
        {
            Response.Redirect("ComprarPelicula.aspx");
        }
    }
}