using System;
using System.Collections.Generic;
using Pacagroup.Comercial.Creditos.Contrato;
using Pacagroup.Comercial.Creditos.Dominio;
using Pacagroup.Comercial.Creditos.Fachada;

namespace Pacagroup.Comercial.Creditos.Implementacion
{
    public class ClienteService : IClienteService
    {
        public IEnumerable<Cliente> ListarCliente()
        {
            using (var instancia = new ClienteFachada())
            {
                return instancia.ListarCliente();
            }
        }

        public Cliente ObtenerCliente(string numeroDocumento)
        {
            using (var instancia = new ClienteFachada()) 
            {
                return instancia.ObtenerCliente(numeroDocumento);
            }
                
        }
    }
}
