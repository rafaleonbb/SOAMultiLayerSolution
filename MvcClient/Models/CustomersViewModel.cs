using SOAMultiLayerSolution.DTO;
using System.Collections.Generic;
using Fersoft.SOAInfrastructure.ServiceFactory;
using MvcClient.ServiceReference;

namespace MvcClient.Models
{
    public class CustomersViewModel
    {
        List<CustomerDTO> customers;

        public List<CustomerDTO> Customers {
            get {
                if (customers == null) {
                    customers = Get ();
                }
                return customers;
            }
        }

        public CustomerDTO Data { get; set; }

        /// <summary>
        /// Obtener la lista de clientes
        /// </summary>
        /// <returns></returns>
        public List<CustomerDTO> Get () => ServiceClientFactory.InvokeMethod<IService, List<CustomerDTO>> (proxy => proxy.GetCustomers ());

        /// <summary>
        /// Obtiene un cliente
        /// </summary>
        /// <param name="id">Id del cliente</param>
        /// <returns></returns>
        public CustomerDTO Get (int id) => ServiceClientFactory.InvokeMethod<IService, CustomerDTO> (proxy => proxy.GetCustomer (id));

        /// <summary>
        /// Envía un cliente al servidor para que lo cree
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public int Create (CustomerDTO dto) => ServiceClientFactory.InvokeMethod<IService, int> (proxy => proxy.CreateCustomer (dto));

        /// <summary>
        /// Envía un cliente al servidor para que lo elimine
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete (int id) => ServiceClientFactory.InvokeMethod<IService, bool> (proxy => proxy.DeleteCustomer (new CustomerDTO { Id = id }));

        /// <summary>
        /// Envía un cliente al servidor para que lo actualice
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public bool Update (CustomerDTO dto) => ServiceClientFactory.InvokeMethod<IService, bool> (proxy => proxy.UpdateCustomer (dto));

    }
}