using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mustache
{
    public class Categoria
    {
        public int Id { get; set; }
        public string? Descricao { get; set; }
        public string? Sigla { get; set; }

        public Categoria(int id)
        {
            Id = 0;
        }

        public Categoria(int id, string descricao, string sigla)
        {
            Id = id;
            Descricao = descricao;
            Sigla = sigla;
        }

        public Categoria(string descricao, string sigla)
        {
            Descricao = descricao;
            Sigla = sigla;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir(); // passa conexão com o banco para o objeto cmd através do metodo Abrir da classe Banco
            cmd.CommandType = CommandType.StoredProcedure; // Será utilizado stored procedure
            cmd.CommandText = "sp_categoria_insert";
            cmd.Parameters.AddWithValue("sp_descricao", Descricao);
            cmd.Parameters.AddWithValue("sp_sigla", Sigla);
            Id = Convert.ToInt32(cmd.ExecuteScalar());
        }





    

    }
}
