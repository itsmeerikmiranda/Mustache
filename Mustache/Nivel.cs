using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mustache
{
    internal class Nivel
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }


        public Nivel(int id)

        { id = 0; }


        public Nivel (int id, string nome, string sigla)
        {
            Id = id;
            Nome = nome;
            Sigla = sigla;



        }
        public Nivel(string nome, string sigla)
        {
            
            Nome = nome;
            Sigla = sigla;



        }
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_nivel_insert";
            cmd.Parameters.AddWithValue("sp_nome", Nome);
            cmd.Parameters.AddWithValue("sp_sigla", Sigla);
            
            Id = Convert.ToInt32(cmd.ExecuteScalar());
        }


    }
}








