using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Mustache
{
    public class Servico
    {
        public int Id { get; set; }
        public int Categoria_id { get; set; }
        public string Nome { get; set; }
        public double Valor_Unit { get; set; }
        public TimeSpan Duracao_Estimada { get; set; }
        public double Desconto { get; set; }
        public DateTime Data_Cad { get; set; }


        public Servico(int id)
        {
            Id = 0;
        }

        public Servico(string nome, int categoria_id, double valor_unit, TimeSpan duracao_estimada, double desconto )
        {
            Nome = nome;
            Categoria_id = categoria_id;
            Valor_Unit = valor_unit;
            Duracao_Estimada = duracao_estimada;
            Desconto = desconto;
        }

        public Servico(int id, int categoria_id, string nome, double valor_Unit, TimeSpan duracao_Estimada, double desconto, DateTime data_Cad)
        {
            Id = id;
            Categoria_id = categoria_id;
            Nome = nome;
            Valor_Unit = valor_Unit;
            Duracao_Estimada = duracao_Estimada;
            Desconto = desconto;
            Data_Cad = data_Cad;
        }


        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_servico_insert";
            cmd.Parameters.AddWithValue("sp_nome", Nome);
            cmd.Parameters.AddWithValue("sp_categoria_id", Categoria_id);
            cmd.Parameters.AddWithValue("sp_valor_unit", Valor_Unit);
            cmd.Parameters.AddWithValue("sp_duracao_estimada", Duracao_Estimada);
            cmd.Parameters.AddWithValue("sp_desconto", Desconto);
            Id = Convert.ToInt32(cmd.ExecuteScalar());
        }



    }
}
