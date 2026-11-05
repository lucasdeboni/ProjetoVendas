using MySqlConnector;
using ProjetoVenda.database;
using ProjetoVenda.model;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ProjetoVenda.repository
{
    internal class EmployeeRepository
    {
        private Employee map(MySqlDataReader reader)
        {
            return new Employee
            {
                cod_funcionario = reader.GetInt32("cod_funcionario"),
                nome = reader.GetString("nome"),
                usuario = reader.GetString("usuario"),
                senha = reader.GetString("senha"),
                telefone = reader.GetString("telefone"),
                rua = (reader.IsDBNull(reader.GetOrdinal("rua")) ? null : reader.GetString("rua")),
                numero = reader.GetString("numero"),
                complemento = (reader.IsDBNull(reader.GetOrdinal("complemento")) ? null : reader.GetString("complemento")),
                cep = reader.GetString("cep"),
                adm = reader.GetBoolean("adm")
            };
        }

        public Employee? getByUsername(string username)
        {
            using MySqlConnection connector = Database.GetConnection();
            string sql = "SELECT * FROM funcionario WHERE usuario = @username";
            using MySqlCommand cmd = new MySqlCommand(sql, connector);
            cmd.Parameters.AddWithValue("@username", username);
            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return map(reader);
            }
            return null;
        }

        public int createEmployee(Employee employee)
        {
            using MySqlConnection connector = Database.GetConnection();
            string sql = @"INSERT INTO funcionario
                (nome, usuario, senha, telefone, rua, numero, complemento, cep, adm)
                VALUES
                (@nome, @usuario, @senha, @telefone, @rua, @numero, @complemento, @cep, @adm)";
            using MySqlCommand cmd = new MySqlCommand(sql, connector);
            cmd.Parameters.AddWithValue("@nome", employee.nome);
            cmd.Parameters.AddWithValue("@usuario", employee.usuario);
            cmd.Parameters.AddWithValue("@senha", employee.senha);
            cmd.Parameters.AddWithValue("@telefone", employee.telefone);
            cmd.Parameters.AddWithValue("@rua", employee.rua);
            cmd.Parameters.AddWithValue("@numero", employee.numero);
            cmd.Parameters.AddWithValue("@complemento", employee.complemento);
            cmd.Parameters.AddWithValue("@cep", employee.cep);
            cmd.Parameters.AddWithValue("@adm", employee.adm);
            cmd.ExecuteNonQuery();

            return (int) cmd.LastInsertedId;
        }

        public List<Employee> getAll()
        {
            using MySqlConnection connector = Database.GetConnection();
            string sql = "SELECT * FROM funcionario";
            using MySqlCommand cmd = new MySqlCommand(sql, connector);
            using var reader = cmd.ExecuteReader();

            List<Employee> list = new List<Employee>();
            while (reader.Read())
            {
                list.Add(map(reader));
            }
            return list;
        }

        public List<Employee> listarPorPagina(int qtd, int pagina)
        {
            int offset = qtd * (pagina - 1);
            using MySqlConnection connector = Database.GetConnection();
            string sql = "SELECT * FROM funcionario LIMIT @limit OFFSET @offset";
            using MySqlCommand cmd = new MySqlCommand(sql, connector);
            cmd.Parameters.AddWithValue("@limit", qtd);
            cmd.Parameters.AddWithValue("@offset", offset);
            using var reader = cmd.ExecuteReader();

            List<Employee> list = new List<Employee>();
            while (reader.Read())
            {
                list.Add(map(reader));
            }
            return list;
        }

        public int quantidadeFuncionarios()
        {
            using MySqlConnection connector = Database.GetConnection();
            string sql = "SELECT COUNT(*) FROM funcionario";
            using MySqlCommand cmd = new MySqlCommand(sql, connector);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        public bool atualizar(Employee employee)
        {
            using MySqlConnection connector = Database.GetConnection();
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
            cmd.Parameters.AddWithValue("@nome", employee.nome);
            cmd.Parameters.AddWithValue("@telefone", employee.telefone);
            cmd.Parameters.AddWithValue("@cep", employee.cep);
            cmd.Parameters.AddWithValue("@rua", employee.rua);
            cmd.Parameters.AddWithValue("@numero", employee.numero);
            cmd.Parameters.AddWithValue("@complemento", employee.complemento);
            cmd.Parameters.AddWithValue("@usuario", employee.usuario);
            cmd.Parameters.AddWithValue("@cod_funcionario", employee.cod_funcionario);

            // ExecuteNonQuery retorna um valor que representa a quantidade de registros alterados
            return cmd.ExecuteNonQuery() > 0;
        }


    }
}
