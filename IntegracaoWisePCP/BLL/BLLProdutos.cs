using DAL;
using DAL.DALProdutos;
using Modelo.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLProdutos
    {
        private ConexaoBD conexao;


        public ModeloProdutos CarregaModeloProduto(int codigo)
        {
            DALProdutos DALObj = new DALProdutos(conexao);
            return DALObj.CarregaModeloProdutos(codigo);
        }
    }
}
