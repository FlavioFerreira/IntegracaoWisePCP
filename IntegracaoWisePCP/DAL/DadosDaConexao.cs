using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DadosDaConexao
    {
        
        public static String StringDeConexao
        {
            get
            {
                return "Server = servidor; Port = 5432; User Id = postgres; Password = #abc123#; Database = wisepcp_demo;";
            }
        }
    }
}
