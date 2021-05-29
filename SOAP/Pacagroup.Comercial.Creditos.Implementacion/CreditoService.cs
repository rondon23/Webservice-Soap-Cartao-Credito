using Pacagroup.Comercial.Creditos.Contrato;
using Pacagroup.Comercial.Creditos.Dominio;
using System;
using System.Collections.Generic;
using Pacagroup.Comercial.Creditos.Fachada;

namespace Pacagroup.Comercial.Creditos.Implementacion
{
    public class CreditoService : ICreditoService
    {
        public Credito AtualizarCredito(Credito credito)
        {
            using (var instancia = new CreditoFachada())
            {
                return instancia.AtualizarCredito(credito);
            }
        }

        public bool EliminarCredito(int idCredito)
        {
            using (var instancia = new CreditoFachada())
            {
                return instancia.EliminarCredito(idCredito);
            }
        }

        public IEnumerable<Credito> ListarCredito()
        {
            using (var instancia = new CreditoFachada())
            {
                return instancia.ListarCredito();
            }
        }

        public Credito RegistrarCredito(Credito credito)
        {
            using (var instancia = new CreditoFachada())
            {
                return instancia.RegistrarCredito(credito);
            }
        }
    }
}
