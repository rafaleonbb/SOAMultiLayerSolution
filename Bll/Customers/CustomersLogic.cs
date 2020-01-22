using SOAMultiLayerSolution.Bll.Infrastructure;
using SOAMultiLayerSolution.DTO;
using SOAMultiLayerSolution.Model;

namespace SOAMultiLayerSolution.Bll.Customers
{
	class CustomersLogic : LogicInfrastructure<Customer, CustomerDTO>
	{
		// Operaciones CRUD estándar implementadas LogicInfrastructure
		// Implementar aquí lógica adicional específica de Customer

		/// <summary>
		/// Mapear un Modelo en un Dto
		/// </summary>
		/// <param name="model"></param>
		/// <returns></returns>
		internal override CustomerDTO MapToDto (Customer model) => new CustomerDTO {
			Id = model.Id,
			Address = model.Address,
			Name = model.Name,
			Phone = model.Phone
		};

		/// <summary>
		/// Mapea un Dto en un Model
		/// </summary>
		/// <param name="dto"></param>
		/// <returns></returns>
		internal override Customer MapToModel (CustomerDTO dto) => new Customer {
			Id = dto.Id,
			Address = dto.Address,
			Name = dto.Name,
			Phone = dto.Phone
		};
	}
}
