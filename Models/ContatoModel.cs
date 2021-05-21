using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class ContatoModel
    {
        private int id;
        private string nome;
        private string telefone;
        private string email;
        private string grupo;
        private string dono;

        public ContatoModel(string nome, string telefone, string email, string grupo, string dono)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.email = email;
            this.grupo = grupo;
            this.dono = dono;
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Email { get => email; set => email = value; }
        public string Grupo { get => grupo; set => grupo = value; }
        public string Dono { get => dono; set => dono = value; }
    }
}