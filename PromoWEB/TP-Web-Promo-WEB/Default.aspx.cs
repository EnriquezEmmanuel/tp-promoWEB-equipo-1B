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
            // Acá podés validar  el código ingresado

            VaucherNegocio ListaVauchers = new VaucherNegocio();
            bool validacion= false;

            for (int x=0; x< ListaVauchers.lista().Count; x++)
            {
                if(ListaVauchers.lista()[x].Codigo== txtBoxVoucher.Text)
                {
                    Response.Redirect("ListadoProducto.aspx",false);
                    validacion = true;
                    Session.Add("CodVaucher",ListaVauchers.lista()[x].Codigo);
                    Session.Add("IdCliente", ListaVauchers.lista()[x].IdCliente);
                }
            }
            if (!validacion) lblMensaje.Text ="Vaucher inexistente";

            // Luego redirigís a la página ListadoProducto.aspx

        }

    }
}