using SOAMultiLayerSolution.DTO;
using System.Collections.Generic;

namespace SOAMultiLayerSolution.Bll
{
	public interface IAppLogic
	{
		/// <summary>
		/// Obtiene la lista de clientes
		/// </summary>
		/// <returns></returns>
		List<CustomerDTO> GetCustomers ();

		/// <summary>
		/// Obtiene un cliente
		/// </summary>
		/// <param name="id">Id del cliente</param>
		/// <returns></returns>
		CustomerDTO GetCustomer (int id);

		/// <summary>
		/// Crea un cliente nuevo
		/// </summary>
		/// <param name="customer"></param>
		/// <returns></returns>
		int CreateCustomer (CustomerDTO customer);

		/// <summary>
		/// Actualiza un cliente
		/// </summary>
		/// <param name="customer">Cliente a actualizar</param>
		/// <returns>True si lo ha actualizado correctamente</returns>
		bool UpdateCustomer (CustomerDTO customer);

		/// <summary>
		/// Eliminar un cliente
		/// </summary>
		/// <param name="customer">Cliente a eliminar</param>
		/// <returns>True si lo eliminar correctamente</returns>
		bool DeleteCustomer (CustomerDTO customer);
	}
}
