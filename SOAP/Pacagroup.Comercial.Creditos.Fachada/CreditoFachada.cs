using Pacagroup.Comercial.Creditos.Dominio;
using Pacagroup.Comercial.Creditos.Fachada;
using Pacagroup.Comercial.Creditos.ContratoRepositorio;
using Pacagroup.Comercial.Creditos.SqlRepositorio;
using System;
using System.Collections.Generic;

namespace Pacagroup.Comercial.Creditos.Fachada
{
    public class CreditoFachada : IDisposable
    {
        public IEnumerable<Credito> ListarCredito()
        {
            ICreditoRepositorio instancia = new CreditoRepositorio();
            return instancia.ListarCredito();
        }

        public Credito RegistrarCredito(Credito credito)
        {
            ICreditoRepositorio instancia = new CreditoRepositorio();
            return instancia.RegistrarCredito(credito);
        }

        public Credito AtualizarCredito(Credito credito)
        {
            ICreditoRepositorio instancia = new CreditoRepositorio();
            return instancia.AtualizarCredito(credito);
        }

        public bool EliminarCredito(int idCredito)
        {
            ICreditoRepositorio instancia = new CreditoRepositorio();
            return instancia.EliminarCredito(idCredito);
        }

        void IDisposable.Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
