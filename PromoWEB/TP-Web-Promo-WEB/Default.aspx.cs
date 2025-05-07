using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_Web_Promo_WEB
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtBoxVoucher.Text = "Ingresar código";

            }
        }

        protected void btnValidar_Click(object sender, EventArgs e)
        {
            // Acá podés validar  el código ingresado

            // Luego redirigís a la página ListadoProducto.aspx
            Response.Redirect("ListadoProducto.aspx",false);
        }

    }
}