using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class VaucherNegocio
    {

		public List<Vaucher> lista()
		{
			List<Vaucher> lista = new List<Vaucher>();
			AccesoDatos datos = new AccesoDatos();


			try
			{
				datos.setearConsulta("SELECT v.CodigoVoucher, c.Id, v.FechaCanje, v.IdArticulo  FROM Vouchers v JOIN Clientes c ON v.IdCliente = c.Id");
				datos.ejecutarLectura();

				while (datos.Lector.Read())
				{
					Vaucher aux = new Vaucher();
					aux.Codigo = (string)datos.Lector["CodigoVoucher"];
					aux.IdCliente = (int)datos.Lector["Id"];
					aux.FechaCanje = (DateTime)datos.Lector["FechaCanje"];
					aux.IdArticulo = (int)datos.Lector["IdArticulo"];

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
