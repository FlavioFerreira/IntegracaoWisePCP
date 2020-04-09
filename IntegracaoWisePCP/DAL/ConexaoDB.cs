using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace DAL
{
    public class ConexaoBD
    {
        private SqlConnection _conexao;
        private String _stringConexao;

        public SqlConnection ObjetoConexao
        {
            get { return this._conexao; }
            set { this._conexao = value; }
        }

        public String StringConexao
        {
            get { return this._stringConexao; }
            set { this._stringConexao = value; }
        }

        NpgsqlConnection conexao = new NpgsqlConnection(); // Estancia da conexao ao postgreSQL

        

        // Médoto Conectar
        public NpgsqlConnection Conectar()
        {
            if (conexao.State == System.Data.ConnectionState.Closed)
            {
                conexao.Open();
            }
            return conexao;
        }

        // Médoto Desconectar
        public void Desconectar() // Usa se tipo void, não retorna nenhum valor
        {
            if (conexao.State == System.Data.ConnectionState.Open) // Antes de conectar, verifica se já está conectado ao banco de dados
            {
                conexao.Close();
            }
        }
    }
}
}
