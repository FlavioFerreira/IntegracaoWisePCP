using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace DAL
{
    public class ConexaoBD
    {
        NpgsqlConnection conexao = new NpgsqlConnection(); // Estancia da conexao ao postgreSQL

        // Método ConexaoDAL
        public ConexaoBD()
        {
            conexao.ConnectionString = @"Server = servidor; Port = 5432; User Id = postgres; Password = #abc123#; Database = wisepcp_demo;";
        }

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
