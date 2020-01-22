namespace SOAMultiLayerSolution.DTO
{
	public class PersonDTO : IDto
	{
		/// <summary>
		/// Nombre
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Dirección
		/// </summary>
		public string Address { get; set; }

		/// <summary>
		/// Teléfono
		/// </summary>
		public string Phone { get; set; }
	}
}
