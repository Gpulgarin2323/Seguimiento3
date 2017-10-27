using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Seguimiento2
{
    public partial class LOGINADMIN : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (txtadmin.Text.Trim() == "" & txtpass.Text.Trim() == "")
            {
                lblmensaje.Text = "Digite su usuario y/o contraseña ";
            }

            else
            {
                if (txtadmin.Text == "ADMIN" & txtpass.Text == "ADMIN123")
                {
                    Session["inicio_admin"] = txtadmin.Text;
                    Response.Redirect("MODIFICACION.aspx");

                }

                else
                {
                    lblmensaje.Text = "USUARIO O CONTRASEÑA INVALIDOS";
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }
    }
}