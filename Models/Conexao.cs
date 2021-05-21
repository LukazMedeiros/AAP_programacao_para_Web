using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Conexao
    {
        public MySqlConnection conectar()
        {
            string server = "127.0.0.1";
            int port = 8000;
            string database = "fatec_aap";
            string user = "root";
            string password = "";
            string stringDeConexao = $"Server={server};Port={port};Database={database};Uid={user};Pwd={password}";

            var conexao = new MySqlConnection(stringDeConexao);
            try
            {
                conexao.Open();
                return conexao;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}