using Pacagroup.Comercial.Creditos.Dominio;
using System.Collections.Generic;

namespace Pacagroup.Comercial.Creditos.ContratoRepositorio
{
    public interface ICreditoRepositorio
    {
        IEnumerable<Credito> ListarCredito();
        Credito RegistrarCredito(Credito credito);
        Credito AtualizarCredito(Credito credito);
        bool EliminarCredito(int idCredito);
    }
}
