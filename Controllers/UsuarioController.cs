using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class UsuarioController
    {
        public bool Inserir(UsuarioModel usuario)
        {
            MySqlConnection conn = new Conexao().conectar();
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = $"INSERT INTO Users (user_name, user_login, user_password) values (@nome, @email, @senha);";
            cmd.Parameters.AddWithValue("@nome", usuario.Nome);
            cmd.Parameters.AddWithValue("@email", usuario.Email);
            cmd.Parameters.AddWithValue("@senha", usuario.Senha);

            cmd.Connection = conn;

            int resposta = cmd.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
            return (resposta > 0);
        }
        public bool Alterar(UsuarioModel usuario)
        {
            MySqlConnection conn = new Conexao().conectar();
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = $"UPDATE Users SET user_name= @nome, user_login = @email, user_password= @senha WHERE user_id = @id;";
            cmd.Parameters.AddWithValue("@id", usuario.Id);
            cmd.Parameters.AddWithValue("@nome", usuario.Nome);
            cmd.Parameters.AddWithValue("@email", usuario.Email);
            cmd.Parameters.AddWithValue("@senha", usuario.Senha);

            cmd.Connection = conn;

            int resposta = cmd.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
            return (resposta > 0);
        }
        public List<string> Pesquisar(string usuario)
        {
            List<string> resposta = new List<string>();
            MySqlConnection conn = new Conexao().conectar();
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = $"SELECT * FROM Users where user_login = @login;";
            cmd.Parameters.AddWithValue("@login", usuario);

            cmd.Connection = conn;

            MySqlDataReader data = cmd.ExecuteReader();
            if (data.Read())
            {
                resposta.Add(data[0].ToString());
                resposta.Add(data[1].ToString());
                resposta.Add(data[2].ToString());
                resposta.Add(data[3].ToString());
                conn.Close();
                conn.Dispose();
                return resposta;
            }
            resposta.Add("Usuário não encontrado");
            return resposta;
        }
    }
}