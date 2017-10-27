using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa_ReglasNegocio;
using Capa_Entidades;
using System.Data;
using System.IO;

namespace Seguimiento2
{
    public partial class Reg_peliculas : System.Web.UI.Page
    {

        CentPeliculas oentPeliculas = new CentPeliculas();
        CregPeliculas oregPeliculas = new CregPeliculas();
        Centusuarios oentusuarios = new Centusuarios();
        Cregusuarios oregusuarios = new Cregusuarios();


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
        protected void limpiar_campos()
            {
                txtautor.Text = "";
                txtcodPelicula.Text = "";
                txtdescripcion.Text = "";
                txtgenero.Text = "";

                txtnombrePelicula.Text = "";


            }

            protected void bttsubirfoto_Click(object sender, EventArgs e)
        {
            bool correcto = false;

            if (tufoto.HasFile)
            {
                string extencionarchivo = System.IO.Path.GetExtension(tufoto.FileName).ToLower();
                string[] extencionespermitidas = { ".png", ".jpg", ".jpeg" };
                for (int i = 0; i < extencionespermitidas.Length; i++)
                {
                    if (extencionarchivo == extencionespermitidas[i])
                    {
                        correcto = true;
                    }
                }

                if (correcto == true)
                {
                    ViewState["foto"] = System.IO.Path.GetFileName(tufoto.FileName);
                    tufoto.SaveAs(Server.MapPath("~/") + ViewState["foto"]);

                    pcbfoto.ImageUrl = "~/" + ViewState["foto"];
                    pcbfoto.DataBind();
                }
            }
        }

        protected void bttregresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }

        protected void BTAGREGAR_Click(object sender, EventArgs e)
        {
            System.Drawing.Image foto = System.Drawing.Image.FromFile(Server.MapPath("~/") + ViewState["foto"]);
            oentPeliculas.codpelicula = txtcodPelicula.Text;
            oentPeliculas.descripcion = txtdescripcion.Text;
            oentPeliculas.genero = txtgenero.Text;
            oentPeliculas.nombre = txtnombrePelicula.Text;
            oentPeliculas.precio = txtprecioPelicula.Text;
            oentPeliculas.autor = txtautor.Text;


            oentPeliculas.foto = imagen_a_byte(foto);

            oregPeliculas.agregar_pelicula(oentPeliculas);



            lblmensaje.Text = "Pelicula agregado correctamente";
            limpiar_campos();


        }

        //metodo para convertir de imagen a byte
        private Byte[] imagen_a_byte(System.Drawing.Image foto)
        {
            if (!(foto == null))
            {
                MemoryStream codi = new MemoryStream();
                foto.Save(codi, System.Drawing.Imaging.ImageFormat.Jpeg);
                return codi.GetBuffer();
            }
            else
            {
                return null;
            }

        }

        protected void bttsubirpdf_Click(object sender, EventArgs e)
        {
            bool correcto = false;

            if (tufoto.HasFile)
            {
                string extencionarchivo = System.IO.Path.GetExtension(tufoto.FileName).ToLower();
                string[] extencionespermitidas = { ".png", ".jpg", ".jpeg", ".mp4" };
                for (int i = 0; i < extencionespermitidas.Length; i++)
                {
                    if (extencionarchivo == extencionespermitidas[i])
                    {
                        correcto = true;
                    }
                }

                if (correcto == true)
                {
                    ViewState["foto"] = System.IO.Path.GetFileName(tufoto.FileName);
                    byte[] contenido = tufoto.FileBytes;
                    tufoto.SaveAs(Server.MapPath("~/") + ViewState["foto"]);

                    pcbfoto.ImageUrl = "~/" + ViewState["foto"];
                    pcbfoto.DataBind();
                }
            }
        }
    }
}