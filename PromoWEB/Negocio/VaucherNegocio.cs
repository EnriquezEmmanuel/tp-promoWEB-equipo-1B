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
				datos.setearConsulta("SELECT CodigoVoucher, IdCliente, FechaCanje, IdArticulo FROM Vouchers;");
				datos.ejecutarLectura();

				while (datos.Lector.Read())
				{
					Vaucher aux = new Vaucher();
					aux.Codigo = (string)datos.Lector["CodigoVoucher"];
					if (datos.Lector["IdCliente"] is null)
					{
						aux.IdCliente = (int)datos.Lector["IdCliente"];
						aux.FechaCanje = (DateTime)datos.Lector["FechaCanje"];
						aux.IdArticulo = (int)datos.Lector["IdArticulo"];
					}
                    else
                    {
                        aux.IdCliente = 0;
						aux.IdArticulo = 0;
                        aux.FechaCanje = DateTime.Today;
						/*
						Cuando se decida devolver a la base el dato de la fecha debemos formatear lo así
						fechaSinLaHora.ToString("dd/MM/yyyy");
						*/
					}

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
