using Modelo.Produtos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DALProdutos
{
    public class DALProdutos
    {
        private ConexaoBD conexao;

        public DALProdutos(ConexaoBD cx)
        {
            this.conexao = cx;
        }

        public ModeloProdutos CarregaModeloProdutos(int codigo)
        {
            ModeloProdutos modelo = new ModeloProdutos();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from produto where idProduto = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();

            if (registro.HasRows)
            {
                registro.Read();

                modelo.IdProduto = Convert.ToInt32(registro["idProduto"]);
                modelo.Descricao = Convert.ToString(registro["descricao"]);
                modelo.IdUnidade = Convert.ToInt32(registro["idUnidade"]);
                modelo.ValorCustoDireto = Convert.ToDouble(registro["valorCustoDireto"]);
                modelo.ValorCustoIndireto = Convert.ToDouble(registro["valorCustoIndireto"]);

            }
            conexao.Desconectar();
            return modelo;

        }

    }
}
