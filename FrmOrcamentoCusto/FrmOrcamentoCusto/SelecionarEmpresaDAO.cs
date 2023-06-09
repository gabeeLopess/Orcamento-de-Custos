using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FrmOrcamentoCusto
{ 

    internal class SelecionarEmpresaDAO
    {
        private SqlConnection Connection { get; }

        public SelecionarEmpresaDAO(SqlConnection connection)
        {
            Connection = connection;
        }

        public List<OrcamentoCustoModel> GetEmpresas() 
        {
            List<OrcamentoCustoModel> empresas = new List<OrcamentoCustoModel>();
            using(SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT codEmpresa, nomeEmpresa, anoOrcamento, versao FROM MvtOrcamentoVenda");
                command.CommandText = sql.ToString();
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        empresas.Add(popualteDr(dr));
                    }
                }
            }
            return empresas;
        }

        private OrcamentoCustoModel popualteDr(SqlDataReader dr)
        {
            string codEmpresa = "";
            string empresa = "";
            string anoOrcamento = "";
            string versao = "";

            if (DBNull.Value != dr["codEmpresa"])
            {
                codEmpresa = dr["codEmpresa"] + "";
            }
            if (DBNull.Value != dr["nomeEmpresa"])
            {
                empresa = dr["nomeEmpresa"] + "";
            }
            if (DBNull.Value != dr["anoOrcamento"])
            {
                anoOrcamento = dr["anoOrcamento"] + "";
            }
            if (DBNull.Value != dr["versao"])
            {
                versao = dr["versao"] + "";
            }

            return new OrcamentoCustoModel()
            {
                CodEmpresa = codEmpresa,
                Empresa = empresa,
                AnoOrcamento = anoOrcamento,
                Versao = versao,
            };
        }
    }
   
}