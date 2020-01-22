using System.ComponentModel.DataAnnotations;

namespace SOAMultiLayerSolution.Model
{
	public class Customer : Person, IEntity
	{
		[Key]
		public int Id { get; set; }
	}
}
