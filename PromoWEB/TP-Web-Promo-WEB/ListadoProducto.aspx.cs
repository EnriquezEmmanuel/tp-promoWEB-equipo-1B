using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace TP_Web_Promo_WEB
{
    public partial class ListadoProducto : System.Web.UI.Page
    {
        public List<Articulo> ListaArticulos { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarArticulosConImagenes();
                rptArticulos.DataSource = ListaArticulos;
                rptArticulos.DataBind();
            }
            if (Session["CodVaucher"] != null)
            {
                Temporal.Text = Session["IdCliente"].ToString()+" => Esto es para verificar que pasan las variables.";
            }
        }

        private void CargarArticulosConImagenes()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            ImagenNegocio imagenNegocio = new ImagenNegocio();

            ListaArticulos = negocio.lista(); // Lista de artículos
            Dictionary<int, List<Imagen>> imagenesPorArticulo = imagenNegocio.lista(); // Agrupadas por ID

            foreach (var articulo in ListaArticulos)
            {
                // Si hay imágenes asociadas a ese artículo, asignarlas
                if (imagenesPorArticulo.ContainsKey(articulo.Id))
                {
                    articulo.Imagenes = imagenesPorArticulo[articulo.Id];
                }
                else
                {
                    articulo.Imagenes = new List<Imagen>(); // Inicializar lista vacía si no hay imágenes, para evita errores
                }
            }

            // Finalmente, bindear al Repeater
            rptArticulos.DataSource = ListaArticulos;
            rptArticulos.DataBind();
        }


        protected void rptArticulos_ItemDataBound(object sender, RepeaterItemEventArgs e) /*Se ejecuta una vez por cada ítem que se está mostrando en el Repeater.*/
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                var articulo = (Articulo)e.Item.DataItem;
                var rptImagenes = (Repeater)e.Item.FindControl("rptImagenes");

                if (rptImagenes != null && articulo.Imagenes != null)
                {
                    rptImagenes.DataSource = articulo.Imagenes;
                    rptImagenes.DataBind();
                }
            }
        }

        protected void BtnSelecionar_Click(object sender, EventArgs e)
        {
            // Selecionar el articulo, restarlo en la base de datos

            // Luego redirigís a la página pedirle los datos al cliente
            //Response.Redirect("", false);
        }
    }
}