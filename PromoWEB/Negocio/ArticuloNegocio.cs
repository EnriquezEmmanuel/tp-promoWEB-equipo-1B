using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> lista()
        {
            List<Articulo> lista = new List<Articulo>();
			AccesoDatos datos = new AccesoDatos();


			try
			{
				datos.setearConsulta("Select A.Id, A.Codigo, A.Nombre, A.Descripcion,  A.IdMarca, A.IdCategoria, A.Precio from  ARTICULOS A");
				datos.ejecutarLectura();

				while (datos.Lector.Read())
				{
					Articulo aux = new Articulo();
					aux.Id = (int)datos.Lector["Id"];
					aux.Codigo = (string)datos.Lector["Codigo"];
					aux.Nombre = (string)datos.Lector["Nombre"];
					aux.Descripcion = (string)datos.Lector["Descripcion"];

					aux.Marca = (int)datos.Lector["IdMarca"];
					aux.Categoria = (int)datos.Lector["IdCategoria"];

                    aux.Precio = (decimal)datos.Lector["Precio"];
					lista.Add(aux);
				}

				return lista;
			}
			catch (Exception ex)
			{

				throw ex;
			}
			finally 
			{ 
				datos.cerrarConexion();
			}
        }
    }
}
