using SOAMultiLayerSolution.Model;
using System.Data.Entity;

namespace SOAMultiLayerSoluion.Dal
{

    public class Context : DbContext
    {
        /// <summary>
        /// Cadena de conexión para .\SQLEXPRESS
        /// </summary>
        const string ConnString =
           "data source=.\\SQLEXPRESS;" +
           "initial catalog=SOAMultiLayerSolution;" +
           "integrated security=True;" +
           "MultipleActiveResultSets=True;" +
           "App=EntityFramework;" +
           "Connect Timeout=5;";

        // El contexto se ha configurado para usar una cadena de conexión 'Context' del archivo 
        // de configuración de la aplicación (App.config o Web.config). De forma predeterminada, 
        // esta cadena de conexión tiene como destino la base de datos 'SOAMultiLayerSoluion.Dal.Context' de la instancia LocalDb. 
        // 
        // Si desea tener como destino una base de datos y/o un proveedor de base de datos diferente, 
        // modifique la cadena de conexión 'Context'  en el archivo de configuración de la aplicación.
        public Context ()
            : base (ConnString) => Database.CreateIfNotExists ();

        // Agregue un DbSet para cada tipo de entidad que desee incluir en el modelo. Para obtener más información 
        // sobre cómo configurar y usar un modelo Code First, vea http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Customer> Customers { get; set; }
    }
}