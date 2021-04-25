using Pacagroup.Comercial.Creditos.Dominio;
using System.Collections.Generic;
using System.ServiceModel;

namespace Pacagroup.Comercial.Creditos.Contrato
{
    [ServiceContract]
    public interface IClienteService
    {
        [OperationContract]
        Cliente ObtenerCliente(string numeroDocumento);
        [OperationContract]
        IEnumerable<Cliente> ListarCliente();

    }
}
