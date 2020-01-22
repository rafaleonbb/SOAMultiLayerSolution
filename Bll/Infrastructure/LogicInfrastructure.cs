using SOAMultiLayerSoluion.Dal;
using SOAMultiLayerSolution.DTO;
using SOAMultiLayerSolution.Model;
using System.Collections.Generic;
using System.Linq;

namespace SOAMultiLayerSolution.Bll.Infrastructure
{
	/// <summary>
	/// Abstracción de la lógica para las operaciones CRUD
	/// </summary>
	/// <typeparam name="TModel"></typeparam>
	abstract class LogicInfrastructure<TModel, TDto> where TModel : class, IEntity where TDto : IDto
	{
		internal abstract TDto MapToDto (TModel model);
		internal abstract TModel MapToModel (TDto dto);

		/// <summary>
		/// Obtiene la lista de registros de <see cref="TModel"/>
		/// </summary>
		/// <returns></returns>
		public virtual List<TDto> Get ()
		{
			var response = new List<TDto> ();
			using (var db = OpenContext ()) {
				foreach (var model in db.Set<TModel> ().OrderBy (m => m.Id)) {
					response.Add (MapToDto (model));
				}
				return response;
			}
		}

		/// <summary>
		/// Obtiene un registro
		/// </summary>
		/// <param name="id">Id del registro</param>
		/// <returns></returns>
		public virtual TDto Get (int id)
		{
			using (var db = OpenContext ()) {
				return MapToDto (db.Set<TModel> ().FirstOrDefault (c => c.Id.Equals (id)));
			}
		}

		/// <summary>
		/// Crea un cliente nuevo
		/// </summary>
		/// <param name="model"></param>
		/// <returns></returns>
		public int Create (TDto dto)
		{
			var model = MapToModel (dto);
			using (var db = OpenContext ()) {
				db.Set<TModel> ().Add (model);
				db.SaveChanges ();
				return model.Id;
			}
		}

		/// <summary>
		/// Elimina un registro
		/// </summary>
		/// <param name="model"></param>
		/// <returns></returns>
		public bool Delete (TDto dto)
		{
			var model = MapToModel (dto);
			using (var db = OpenContext ()) {
				db.Set<TModel> ().Remove (model);
				db.SaveChanges ();
				return true;
			}
		}

		/// <summary>
		/// Modifica un registro
		/// </summary>
		/// <param name="model"></param>
		/// <returns></returns>
		public bool Update (TDto dto)
		{
			var model = MapToModel (dto);
			using (var db = OpenContext ()) {
				Delete (dto);
				db.Set<TModel> ().Add (model);
				db.SaveChanges ();
				return true;
			}
		}

		/// <summary>
		/// Obtiene el contexto de la base de datos
		/// </summary>
		/// <returns></returns>
		protected virtual Context OpenContext () => AppLogic.Current.OpenContext ();

	}
}
