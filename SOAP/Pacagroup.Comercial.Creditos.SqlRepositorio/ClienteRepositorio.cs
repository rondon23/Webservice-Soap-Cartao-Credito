using Pacagroup.Comercial.Creditos.Dominio;
using System.Collections.Generic;
using Pacagroup.Comercial.Creditos.ContratoRepositorio;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace Pacagroup.Comercial.Creditos.SqlRepositorio
{
    public class ClienteRepositorio : IClienteRepositorio
    {
        public Cliente ObtenerCliente(string numeroDocumento)
        {
            using (IDbConnection conexion = new SqlConnection(ConexionRepositorio.ObtenerCadenaConexion()))
            {
                conexion.Open();
                var parametros = new DynamicParameters();
                parametros.Add("pNumeroDocumento", numeroDocumento);

                var cliente = conexion.QuerySingle<Cliente>("dbo.sp_cliente_obtener", param: parametros, 
                    commandType: CommandType.StoredProcedure);
                return cliente;
            }
        }

        public IEnumerable<Cliente> ListarCliente()
        {
            using (IDbConnection conexion = new SqlConnection(ConexionRepositorio.ObtenerCadenaConexion()))
            {
                conexion.Open();
                var cliente = conexion.Query<Cliente>("dbo.sp_cliente_listar", commandType: CommandType.StoredProcedure);
                return cliente;
            }
        }

    }
}
