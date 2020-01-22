namespace SOAMultiLayerSolution.Model
{
	/// <summary>
	/// Clase abstracta para tener las propiedades comunes de entidades persona
	/// </summary>
	public abstract class Person
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
