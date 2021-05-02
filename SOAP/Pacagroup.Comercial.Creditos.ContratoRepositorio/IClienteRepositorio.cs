using Pacagroup.Comercial.Creditos.Dominio;
using System.Collections.Generic;

namespace Pacagroup.Comercial.Creditos.ContratoRepositorio
{
    public interface IClienteRepositorio
    {
        IEnumerable<Cliente> ListarCliente();

        Cliente ObtenerCliente(string numeroDocumento);
    }
}
