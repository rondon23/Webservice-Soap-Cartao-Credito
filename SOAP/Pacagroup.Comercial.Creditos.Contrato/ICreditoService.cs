using System.Collections.Generic;
using Pacagroup.Comercial.Creditos.Dominio;
using System.ServiceModel.Web;
using System.ServiceModel;
using System.ComponentModel;

namespace Pacagroup.Comercial.Creditos.Contrato
{
    [ServiceContract]
    public interface ICreditoService
    {
        [OperationContract]
        [Description("Servico REST que obtem toda a informacao dos cartoes de credito")]
        [WebGet(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate ="/ListarCredito", BodyStyle =WebMessageBodyStyle.Bare)]
        IEnumerable<Credito> ListarCredito();

        [OperationContract]
        [Description("Servico REST que permite cadastrar cartoes de credito")]
        [WebInvoke(RequestFormat = WebMessageFormat.Json, ResponseFormat =WebMessageFormat.Json, Method ="POST", UriTemplate="/RegistrarCredito", BodyStyle = WebMessageBodyStyle.Bare)]        
        Credito RegistrarCredito(Credito credito);
          
        [OperationContract]
        [Description("Servico REST que permite atualizar cartoes de credito")]
        [WebInvoke(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "PUT", UriTemplate = "/AtualizarCredito", BodyStyle = WebMessageBodyStyle.Bare)]
        Credito AtualizarCredito(Credito credito);

        [OperationContract]
        [Description("Servico REST que permite apagar cartoes de credito")]
        [WebInvoke(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "DELETE", UriTemplate = "/EliminarCredito?idCredito={idCredito}", BodyStyle = WebMessageBodyStyle.Bare)]
        bool EliminarCredito(int idCredito);
    }
}
