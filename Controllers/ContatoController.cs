using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ContatoController
    {
        public bool Inserir(ContatoModel contato)
        {
            MySqlConnection conn = new Conexao().conectar();
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = $"INSERT INTO Contacts" +
                $"(contact_name, contact_phone, contact_email, contact_group, owner_id)" +
                $"VALUES (@nome, @telefone, @email, @grupo, @dono);";

            cmd.Parameters.AddWithValue("@nome", contato.Nome);
            cmd.Parameters.AddWithValue("@telefone", contato.Telefone);
            cmd.Parameters.AddWithValue("@email", contato.Email);
            cmd.Parameters.AddWithValue("@grupo", contato.Grupo);
            cmd.Parameters.AddWithValue("@dono", contato.Dono);

            cmd.Connection = conn;

            try
            {
                int resposta = cmd.ExecuteNonQuery();
                conn.Close();
                conn.Dispose();
                return (resposta > 0);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        public List<string> Pesquisar(string contato)
        {
            List<string> resposta = new List<string>();
            MySqlConnection conn = new Conexao().conectar();
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = $"SELECT * FROM Contacts WHERE contact_name = @nome";
            cmd.Parameters.AddWithValue("@nome", contato);

            cmd.Connection = conn;

            MySqlDataReader data = cmd.ExecuteReader();
            if (data.Read())
            {
                resposta.Add(data[0].ToString());
                resposta.Add(data[1].ToString());
                resposta.Add(data[2].ToString());
                resposta.Add(data[3].ToString());
                resposta.Add(data[4].ToString());
                resposta.Add(data[5].ToString());
                conn.Close();
                conn.Dispose();
                return resposta;
            }
            resposta.Add("Contato não encontrado");
            return resposta;
        }
        public bool Atualizar(ContatoModel contato)
        {
            MySqlConnection conn = new Conexao().conectar();
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = $"UPDATE Contacts SET contact_name = @nome, contact_phone = @telefone, contact_email = @email, contact_group = @grupo, owner_id = @dono WHERE contact_id = @id;";

            cmd.Parameters.AddWithValue("@id", contato.Id);
            cmd.Parameters.AddWithValue("@nome", contato.Nome);
            cmd.Parameters.AddWithValue("@telefone", contato.Telefone);
            cmd.Parameters.AddWithValue("@email", contato.Email);
            cmd.Parameters.AddWithValue("@grupo", contato.Grupo);
            cmd.Parameters.AddWithValue("@dono", contato.Dono);

            cmd.Connection = conn;

            try
            {
                int resposta = cmd.ExecuteNonQuery();
                conn.Close();
                conn.Dispose();
                return (resposta > 0);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        public bool Excluir(int contato)
        {
            MySqlConnection conn = new Conexao().conectar();
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = $"DELETE FROM Contacts WHERE contact_id = @contato;";

            cmd.Parameters.AddWithValue("@nome", contato);

            cmd.Connection = conn;

            try
            {
                int resposta = cmd.ExecuteNonQuery();
                conn.Close();
                conn.Dispose();
                return (resposta > 0);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}