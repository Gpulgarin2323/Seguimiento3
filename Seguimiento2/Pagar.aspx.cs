using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Windows.Forms;
using Capa_Entidades;

namespace Seguimiento2
{
    public partial class Pagar : System.Web.UI.Page
    {

        ws.DBSoapClient ws = new ws.DBSoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //Session["referencia"] = null;
                //MessageBox.Show("Su compra no pudo ser fectuada", "confirmar", MessageBoxButtons.OK, MessageBoxIcon.Question);
                //Response.Redirect("ComprarPelicula.aspx");

            }

        }

        protected void btnpagar_Click(object sender, EventArgs e)
        {
            string referencia = Session["referencia"].ToString();
            string usuario = Session["usuariopago"].ToString();

            CentWsEnviar obj = new CentWsEnviar();
            obj.peliculas =referencia;
            obj.precio = usuario;
           
            string[] array = { obj.peliculas, obj.precio};
            bool result = ws.GetPagoFinal(array);
            if (result == true)
            {
                MessageBox.Show("Su compra fue finalizada con exito", "confirmar", MessageBoxButtons.OK, MessageBoxIcon.Question);
                Response.Redirect("index.aspx");
            }
            else
            {
                MessageBox.Show("No se pudo guardar su compra");
                Response.Redirect("ComprarPelicula.aspx");
            }

        }
    }
}