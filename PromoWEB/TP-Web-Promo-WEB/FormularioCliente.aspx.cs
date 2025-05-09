using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace TP_Web_Promo_WEB
{
    public partial class FormularioCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void btnParticipar_Click(object sender, EventArgs e)
        {
            
            ClienteNegocio negocio = new ClienteNegocio();
            var existente = negocio.buscarPorDNI(txtDocumento.Text);
            

            if ( existente != null )
            {
                Response.Redirect("RegistroExitoso");
                return;
            }
                
            cliente c = new cliente();

            c.Documento = txtDocumento.Text;
            c.Nombre = txtNombre.Text;
            c.Apellido = txtApellido.Text;
            c.Email = txtEmail.Text;
            c.Direccion = txtDireccion.Text;
            c.Ciudad = txtCiudad.Text;
            c.CodPostal = int.Parse(txtCodPostal.Text);

            negocio.agregar(c);
            Response.Redirect("RegistroExitoso");
        }

        protected void txtDocumento_TextChanged(object sender, EventArgs e)
        {
            ClienteNegocio negocio = new ClienteNegocio();
            string dni = txtDocumento.Text.Trim();

            if (!string.IsNullOrEmpty(dni))
            {
                var lista = negocio.lista();
                cliente clienteExistente = lista.FirstOrDefault(c => c.Documento == dni);

                if (clienteExistente != null)
                {
                    txtNombre.Text = clienteExistente.Nombre;
                    txtApellido.Text = clienteExistente.Apellido;
                    txtEmail.Text = clienteExistente.Email;
                    txtDireccion.Text = clienteExistente.Direccion;
                    txtCiudad.Text = clienteExistente.Ciudad;
                    txtCodPostal.Text = clienteExistente.CodPostal.ToString();
                }
                else
                {
                    limpiarCampos();
                }
            }
        }
        private void limpiarCampos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEmail.Text = "";
            txtDireccion.Text = "";
            txtCiudad.Text = "";
            txtCodPostal.Text = "";
        }
    }
}