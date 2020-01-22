using SOAMultiLayerSolution.DTO;
using System.Collections.Generic;
using System.ServiceModel;

namespace Service
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService
    {
        /// <summary>
        /// Obtiene la lista de clientes
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<CustomerDTO> GetCustomers ();

        /// <summary>
        /// Obtiene un cliente
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [OperationContract]
        CustomerDTO GetCustomer (int id);

        /// <summary>
        /// Crea un cliente
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [OperationContract]
        int CreateCustomer (CustomerDTO dto);

        /// <summary>
        /// Elimina un cliente
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [OperationContract]
        bool DeleteCustomer (CustomerDTO dto);

        /// <summary>
        /// Actualiza un cliente
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [OperationContract]
        bool UpdateCustomer (CustomerDTO dto);

    }
}
