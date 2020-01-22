using SOAMultiLayerSolution.Bll;
using SOAMultiLayerSolution.DTO;
using System.Collections.Generic;

namespace Service
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service.svc o Service.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service : IService
    {
        /// <summary>
        /// Backfield de <see cref="AppLogic"/>
        /// </summary>
        IAppLogic appLogic;

        /// <summary>
        /// Accede a la lógica de la aplicación
        /// </summary>
        IAppLogic AppLogic {
            get {
                if (appLogic == null) {
                    appLogic = LogicFactory.Build ();
                }
                return appLogic;
            }
        }

        /// <summary>
        /// Obtiene la lista de clientes
        /// </summary>
        /// <returns></returns>
        public List<CustomerDTO> GetCustomers () => AppLogic.GetCustomers ();

        /// <summary>
        /// Obtiene un cliente
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public CustomerDTO GetCustomer (int id) => AppLogic.GetCustomer (id);

        /// <summary>
        /// Crea un cliente
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public int CreateCustomer (CustomerDTO dto) => AppLogic.CreateCustomer (dto);

        /// <summary>
        /// Elimina un cliente
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public bool DeleteCustomer (CustomerDTO dto) => AppLogic.DeleteCustomer (dto);

        /// <summary>
        /// Actualiza un cliente
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public bool UpdateCustomer (CustomerDTO dto) => AppLogic.UpdateCustomer (dto);

    }
}
