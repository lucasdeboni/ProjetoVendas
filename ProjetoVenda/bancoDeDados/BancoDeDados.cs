using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ProjetoVenda.bancoDeDados
{
    internal static class BancoDeDados
    {
        private static string textoDeConexao;

        static BancoDeDados()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder
            {
                Server = "localhost",
                Port = 3306,
                Database = "db_vendas",
                UserID = "root",
                Password = ""
            };
            textoDeConexao = builder.ConnectionString;
        }

        public static MySqlConnection conexao()
        {
            MySqlConnection connection = new MySqlConnection(textoDeConexao);
            try
            {
                connection.Open();
                return connection;
            }catch (MySqlException ex)
            {
                connection.Dispose();
                throw;
            }
        }
    }
}
