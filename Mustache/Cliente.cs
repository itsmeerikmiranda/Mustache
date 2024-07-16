using MySql.Data.MySqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mustache
{
    public class Cliente
    {
        public int Id{ get; set; }
        public string Nome{ get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNasc { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCad { get; set; }
        public string Telefone { get; set; }

        // Construtor apenas com id
        public Cliente()
        {
            Id = 0;
        }

        // Construtor Completo
        public Cliente(int id, string nome, string email, string cpf, DateTime datanasc, bool ativo, DateTime datacad, string telefone)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Cpf = cpf;
            DataNasc = datanasc;
            Ativo = ativo;
            DataCad = datacad;
            Telefone = telefone;
        }

        // Construtor apenas sem o id
        public Cliente(string nome, string email, string cpf, DateTime datanasc, bool ativo, DateTime datacad, string telefone)
        {
            Nome = nome;
            Email = email;
            Cpf = cpf;
            DataNasc = datanasc;
            Ativo = ativo;
            DataCad = datacad;
            Telefone = telefone;

        }

        // Construtor sem os campos que utilizam timestamp ou auto incremento
        public Cliente(string nome, string email, string cpf, DateTime datanasc, string telefone)
        {
            Nome = nome;
            Email = email;
            Cpf = cpf;
            DataNasc = datanasc;
            Telefone = telefone;
        }


        // Método Inserir da classe Cliente
        public void Inserir()
        {
            var cmd = Banco.Abrir(); // Atribui o método Abrir() da classe banco ao objeto cmd
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_cliente_insert";
            cmd.Parameters.AddWithValue("sp_nome", Nome);
            cmd.Parameters.AddWithValue("sp_email", Email);
            cmd.Parameters.AddWithValue("sp_cpf", Cpf);
            cmd.Parameters.AddWithValue("sp_data_nasc", DataNasc);
            cmd.Parameters.AddWithValue("sp_telefone", Telefone);
            Id = Convert.ToInt32(cmd.ExecuteScalar());
        }


    }
}
