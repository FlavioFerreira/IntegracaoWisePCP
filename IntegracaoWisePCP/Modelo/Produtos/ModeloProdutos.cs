using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Produtos
{
    public class ModeloProdutos
    {
        public ModeloProdutos()
        {
            this.idProduto = 0;
            this.descricao = "";
            this.idUnidade = 0;
            this.valorCustoDireto = 0;
            this.valorCustoIndireto = 0;
        }

        private int idProduto;

        public int IdProduto
        {
            get { return this.idProduto; }
            set { this.idProduto = value; }
        }

        private String descricao;

        public String Descricao
        {
            get { return this.descricao; }
            set { this.descricao = value; }
        }

        private int idUnidade;

        public int IdUnidade
        {
            get { return this.idUnidade; }
            set { this.idUnidade = value; }
        }

        private Double valorCustoDireto;

        public Double ValorCustoDireto
        {
            get { return this.valorCustoDireto;}
            set { this.valorCustoDireto = value; }
        }

        private Double valorCustoIndireto;

        public Double ValorCustoIndireto
        {
            get { return this.valorCustoIndireto; }
            set { this.valorCustoIndireto = value; }
        }


    }
}
