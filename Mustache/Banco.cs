using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Mustache
{
    public static class Banco // Classe banco, qual realizara a conexão do sistema com o banco de dados mustachedb01
    {
        public static MySqlCommand Abrir() // metodo da classe Banco
        {
            MySqlCommand cmd = new MySqlCommand(); // permite a aplicação de comandos mysql através dos metodo cmd

            // caracteristicas de uma string de conexão
            string conection = @"server =127.0.0.1;database=mustachedb01; user id =root; password="; // String de conexão
            MySqlConnection cn = new MySqlConnection(conection); // cria conexão utilizando os dados passados

            try
            {
                cn.Open();
                cmd.Connection = cn;

            }
            catch (Exception)
            {

                throw;
            }

            return cmd;
        }

    }
}
