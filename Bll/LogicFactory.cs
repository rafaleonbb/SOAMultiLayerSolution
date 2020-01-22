namespace SOAMultiLayerSolution.Bll
{
	public static class LogicFactory
	{
		/// <summary>
		/// Construye una nueva instancia de la lógica de la aplicación
		/// </summary>
		/// <returns></returns>
		public static IAppLogic Build () => new AppLogic ();
	}
}
