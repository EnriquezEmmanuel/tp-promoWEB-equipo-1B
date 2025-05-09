using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace TP_Web_Promo_WEB
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnValidar_Click(object sender, EventArgs e)
        {

            Image1.Style["opacity"] = "1";

            VaucherNegocio ListaVauchers = new VaucherNegocio();
            bool validacion = false;

            foreach (Vaucher item in ListaVauchers.lista())
            {
                if (item.Codigo == txtBoxVoucher.Text)
                {
                    validacion = true;
                    Session.Add("CodVaucher", item.Codigo);
                    Session.Add("FechaCanje", item.FechaCanje);
                    Response.Redirect("ListadoProducto.aspx", false);
                }
            }
            Image1.Style["opacity"] = "0";
            if (!validacion) lblMensaje.Text = "Vaucher inexistente";

            /*
            Image1.Style["opacity"]="1"; 
            try
            {
                VaucherNegocio ListaVauchers = new VaucherNegocio();
                bool validacion = false;

                foreach(Vaucher item in ListaVauchers.lista())
                {
                    if (item.Codigo == txtBoxVoucher.Text)
                    {
                        validacion = true;
                        Session.Add("CodVaucher", item.Codigo);
                        Response.Redirect("ListadoProducto.aspx", false);
                    }
                }
                Image1.Style["opacity"] = "0";
                if (!validacion) lblMensaje.Text = "Vaucher inexistente";
            }
            catch (Exception ex)
            {
                //---------- Es para sacar un mensaje Alert() de html -----------------------
                //string Alerta = "alert('Hubo un error inesperado. Vuelva a intentar mas tarde.');";
                //ClientScript.RegisterStartupScript(this.GetType(), "MensajeAlerta", Alerta, true);

                Image1.Style["opacity"] = "0";
                lblMensaje.Text = "Hubo un error inesperado. Vuelva a intentar mas tarde.";

                throw ex;
            }
            */


        }

    }
}