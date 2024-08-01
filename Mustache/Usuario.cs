using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mustache
{
    public class Usuario
    {

        // Propriedade da classe 
        public int Id { get; set; }
        public string Nivel { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime Data_cad { get; set; }
        public bool Ativo { get; set; }
        public string Senha { get; set; }
        public string Cpf { get; set; }


        // metódos construtores
        public Usuario(int id)
        {
            Id = 0;
        }

        public Usuario(string nivel, string nome, string email, string senha, string cpf)
        {
            Nivel = nivel;
            Nome = nome;
            Email = email;
            Senha = senha;
            Cpf = cpf;
        }

        public Usuario(int id, string nivel, string nome, string email, DateTime data_cad, bool ativo, string senha, string cpf)
        {
            Id = id;
            Nivel = nivel;
            Nome = nome;
            Email = email;
            Data_cad = data_cad;
            Ativo = ativo;
            Senha = senha;
            Cpf = cpf;
        }

        // Metodo Inserir da Classe usuario qual faz o registro no banco de dados
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_usuario_insert";
            cmd.Parameters.AddWithValue("sp_nivel_id", Nivel);
            cmd.Parameters.AddWithValue("sp_nome", Nome);
            cmd.Parameters.AddWithValue("sp_email", Email);
            cmd.Parameters.AddWithValue("sp_senha", Senha);
            cmd.Parameters.AddWithValue("sp_cpf", Cpf);

            // Retorna o valor do identificador gerado pelo banco de dados, converte para int32
            //e atribui o valor gerado na propriedade Id da classe
            Id = Convert.ToInt32(cmd.ExecuteScalar());

        }
    }
}


