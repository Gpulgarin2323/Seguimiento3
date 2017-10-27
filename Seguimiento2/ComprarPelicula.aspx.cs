using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa_Entidades;
using Capa_ReglasNegocio;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Seguimiento2
{
    public partial class ComprarPelicula : System.Web.UI.Page

    {
        CentPeliculas oentPeliculas = new CentPeliculas();
        
        Centusuarios oentusuarios = new Centusuarios();
        CregPeliculas oregPeliculas = new CregPeliculas();
        Cregusuarios oregusuarios = new Cregusuarios();
        CentGenerarReferencia oentGenerarReferencia = new CentGenerarReferencia();

        ws.DBSoapClient ws = new ws.DBSoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {


                
                if (Session["inicio"] == null)
                {
                    Response.Redirect("LOGIN.aspx");


                }
                else
                {
                    DataSet ds = new DataSet();
                    ds = oregPeliculas.consulta_peliculaddl(oentPeliculas);
                    ddlpeliculas.DataSource = ds;
                    ddlpeliculas.DataTextField = "nombre";                            // FieldName of Table in DataBase
                    ddlpeliculas.DataValueField = "nombre";
                    ddlpeliculas.DataBind();



                    DataSet SS = ws.Getdbpeliculas();

                    ddlbancos.DataSource = SS;
                    ddlbancos.DataTextField = "bancos";
                    ddlbancos.DataValueField = "bancos";
                    ddlbancos.DataBind();
                }
            }


        }
        
        protected void btnpagar_Click(object sender, EventArgs e)
        {
            CentWsEnviar obj = new CentWsEnviar();
            obj.peliculas = ddlpeliculas.SelectedValue;
            obj.precio = txtprecio.Text;
            obj.nombre = txtnombres.Text;
            obj.apellidos = txtapellidos.Text;
            obj.direccion = txtdireccion.Text;
            obj.ciudad = txtciudad.Text;
            obj.departamento = txtdepartamento.Text;
            obj.telefono = txttelefono.Text;
            obj.banco = ddlbancos.SelectedValue;
            obj.referencia = oentGenerarReferencia.GenerarReferencia();
            string[] array = { obj.peliculas, obj.precio, obj.nombre, obj.apellidos , obj.direccion, obj.ciudad, obj.departamento, obj.telefono, obj.banco, obj.referencia};
            bool result = ws.GetInsertarCompraPelicula(array);
            if (result)
            {
                MessageBox.Show("espere mientras es redirigido al banco para finalziar la compra", "confirmar", MessageBoxButtons.OK, MessageBoxIcon.Question);
                Session["referencia"] = obj.referencia;

                Response.Redirect("Banco.aspx");
            }
            else
            {
                MessageBox.Show("No se pudo guardar su compra");
                Response.Redirect("ComprarPelicula.aspx");
            }
            

        }

        protected void ddlpeliculas_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            oentPeliculas.nombre = ddlpeliculas.SelectedValue;
            DataSet ds = new DataSet();
            ds = oregPeliculas.consulta_preciopelicula(oentPeliculas);
            txtprecio.Text = ds.Tables[0].Rows[0]["precio"].ToString();


        }


        
    }
}