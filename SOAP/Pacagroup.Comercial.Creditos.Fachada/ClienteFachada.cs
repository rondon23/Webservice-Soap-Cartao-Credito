using System;
using System.Collections.Generic;
using Pacagroup.Comercial.Creditos.Dominio;
using Pacagroup.Comercial.Creditos.ContratoRepositorio;
using Pacagroup.Comercial.Creditos.SqlRepositorio;

namespace Pacagroup.Comercial.Creditos.Fachada
{
    public class ClienteFachada : IDisposable
    {
        public Cliente ObtenerCliente(string numeroDocumento)
        {
            IClienteRepositorio instancia = new ClienteRepositorio();
            return instancia.ObtenerCliente(numeroDocumento);
        }

        public IEnumerable<Cliente> ListarCliente()
        {
            IClienteRepositorio instancia = new ClienteRepositorio();
            return instancia.ListarCliente();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
