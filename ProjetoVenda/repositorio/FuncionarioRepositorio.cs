using MySqlConnector;
using ProjetoVenda.bancoDeDados;
using ProjetoVenda.modelo;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ProjetoVenda.repositorio
{
    internal class FuncionarioRepositorio
    {
        private Funcionario mapear(MySqlDataReader cursor)
        {
            return new Funcionario
            {
                cod_funcionario = cursor.GetInt32("cod_funcionario"),
                nome = cursor.GetString("nome"),
                usuario = cursor.GetString("usuario"),
                senha = cursor.GetString("senha"),
                telefone = cursor.GetString("telefone"),
                rua = (cursor.IsDBNull(cursor.GetOrdinal("rua")) ? null : cursor.GetString("rua")),
                numero = cursor.GetString("numero"),
                complemento = (cursor.IsDBNull(cursor.GetOrdinal("complemento")) ? null : cursor.GetString("complemento")),
                cep = cursor.GetString("cep"),
                adm = cursor.GetBoolean("adm")
            };
        }

        public Funcionario? pegarPorNomeDeUsuario(string nomeDeUsuario)
        {
            using MySqlConnection connector = BancoDeDados.conexao();
            string sql = "SELECT * FROM funcionario WHERE usuario = @username";
            using MySqlCommand cmd = new MySqlCommand(sql, connector);
            cmd.Parameters.AddWithValue("@username", nomeDeUsuario);
            using var cursor = cmd.ExecuteReader();
            if (cursor.Read())
            {
                return mapear(cursor);
            }
            return null;
        }

        public int criarFuncionario(Funcionario funcionario)
        {
            using MySqlConnection conector = BancoDeDados.conexao();
            string sql = @"INSERT INTO funcionario
                (nome, usuario, senha, telefone, rua, numero, complemento, cep, adm)
                VALUES
                (@nome, @usuario, @senha, @telefone, @rua, @numero, @complemento, @cep, @adm)";
            using MySqlCommand cmd = new MySqlCommand(sql, conector);
            cmd.Parameters.AddWithValue("@nome", funcionario.nome);
            cmd.Parameters.AddWithValue("@usuario", funcionario.usuario);
            cmd.Parameters.AddWithValue("@senha", funcionario.senha);
            cmd.Parameters.AddWithValue("@telefone", funcionario.telefone);
            cmd.Parameters.AddWithValue("@rua", funcionario.rua);
            cmd.Parameters.AddWithValue("@numero", funcionario.numero);
            cmd.Parameters.AddWithValue("@complemento", funcionario.complemento);
            cmd.Parameters.AddWithValue("@cep", funcionario.cep);
            cmd.Parameters.AddWithValue("@adm", funcionario.adm);
            cmd.ExecuteNonQuery();

            return (int) cmd.LastInsertedId;
        }

        public List<Funcionario> listarFuncionarios()
        {
            using MySqlConnection connector = BancoDeDados.conexao();
            string sql = "SELECT * FROM funcionario";
            using MySqlCommand cmd = new MySqlCommand(sql, connector);
            using var cursor = cmd.ExecuteReader();

            List<Funcionario> lista = new List<Funcionario>();
            while (cursor.Read())
            {
                lista.Add(mapear(cursor));
            }
            return lista;
        }

        public List<Funcionario> listarPorPagina(int qtd, int pagina)
        {
            int offset = qtd * (pagina - 1);
            using MySqlConnection conector = BancoDeDados.conexao();
            string sql = "SELECT * FROM funcionario LIMIT @limit OFFSET @offset";
            using MySqlCommand cmd = new MySqlCommand(sql, conector);
            cmd.Parameters.AddWithValue("@limit", qtd);
            cmd.Parameters.AddWithValue("@offset", offset);
            using var reader = cmd.ExecuteReader();

            List<Funcionario> lista = new List<Funcionario>();
            while (reader.Read())
            {
                lista.Add(mapear(reader));
            }
            return lista;
        }

        public int quantidadeFuncionarios()
        {
            using MySqlConnection connector = BancoDeDados.conexao();
            string sql = "SELECT COUNT(*) FROM funcionario";
            using MySqlCommand cmd = new MySqlCommand(sql, connector);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        public bool atualizar(Funcionario funcionario)
        {
            using MySqlConnection connector = BancoDeDados.conexao();
            string sql = @"UPDATE funcionario SET
                 nome = @nome
                ,telefone = @telefone
                ,cep = @cep
                ,rua = @rua
                ,numero = @numero
                ,complemento = @complemento
                ,usuario = @usuario
                WHERE cod_funcionario = @cod_funcionario";
            using MySqlCommand cmd = new MySqlCommand(sql, connector);
            cmd.Parameters.AddWithValue("@nome", funcionario.nome);
            cmd.Parameters.AddWithValue("@telefone", funcionario.telefone);
            cmd.Parameters.AddWithValue("@cep", funcionario.cep);
            cmd.Parameters.AddWithValue("@rua", funcionario.rua);
            cmd.Parameters.AddWithValue("@numero", funcionario.numero);
            cmd.Parameters.AddWithValue("@complemento", funcionario.complemento);
            cmd.Parameters.AddWithValue("@usuario", funcionario.usuario);
            cmd.Parameters.AddWithValue("@cod_funcionario", funcionario.cod_funcionario);

            // ExecuteNonQuery retorna um valor que representa a quantidade de registros alterados
            return cmd.ExecuteNonQuery() > 0;
        }


    }
}
