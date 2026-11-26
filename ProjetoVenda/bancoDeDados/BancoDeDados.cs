using DotNetEnv;
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
            string caminho = Path.Combine(AppContext.BaseDirectory, ".env");
            Env.Load(caminho);

            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder
            {
                Server = Env.GetString("DB_HOSTNAME"),
                //Port = uint.Parse(Env.GetString("DB_PORT")),
                Port = (uint)Env.GetInt("DB_PORT"),
                Database = Env.GetString("DB_NAME"),
                UserID = Env.GetString("DB_USER"),
                Password = Env.GetString("DB_PASSWORD")
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
