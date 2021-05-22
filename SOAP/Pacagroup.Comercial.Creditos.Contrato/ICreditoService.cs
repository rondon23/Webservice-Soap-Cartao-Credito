using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pacagroup.Comercial.Creditos.Dominio;
using System.ServiceModel.Web;
using System.ServiceModel;

namespace Pacagroup.Comercial.Creditos.Contrato
{
    [ServiceContract]
    public interface ICreditoService
    {
        [OperationContract]
        [WebGet(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate ="/ListarCredito", BodyStyle =WebMessageBodyStyle.Bare)]
        IEnumerable<Credito> ListarCredito();

        [OperationContract]
        [WebInvoke(RequestFormat = WebMessageFormat.Json, ResponseFormat =WebMessageFormat.Json, Method ="POST", UriTemplate="/RegistrarCredito", BodyStyle = WebMessageBodyStyle.Bare)]        
        Credito RegistrarCredito(Credito credito);
          
        [OperationContract]
        [WebInvoke(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "PUT", UriTemplate = "/AtualizarCredito", BodyStyle = WebMessageBodyStyle.Bare)]
        Credito AtualizarCredito(Credito credito);

        [OperationContract]
        [WebInvoke(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "DELETE", UriTemplate = "/EliminarCredito/{idCredito}", BodyStyle = WebMessageBodyStyle.Bare)]
        bool EliminarCredito(int idCredito);
    }
}
