using MySqlConnector;
using ProjetoVenda.bancoDeDados;
using ProjetoVenda.modelo;
using ProjetoVenda.formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ProjetoVenda.repositorio
{
    internal class ProdutoRepositorio
    {
        private Produto mapear(MySqlDataReader cursor)
        {
            return new Produto
            {
                cod_produto = cursor.GetInt32("cod_produto"),
                cod_funcionario = cursor.GetInt32("cod_funcionario"),
                nome = cursor.GetString("nome"),
                marca = cursor.GetString("marca"),
                preco = cursor.GetInt32("preco"),
                quantidade = cursor.GetInt32("quantidade"),
                data_registro = cursor.GetDateTime("data_registro")
            }; 
        }

        public int criarProduto(Produto produto)
        {
            using MySqlConnection conector = BancoDeDados.conexao();
            string sql = @"INSERT INTO produto
                (cod_funcionario, nome, marca, preco, quantidade)
                VALUES
                (@cod_funcionario, @nome, @marca, @preco, @quantidade)";
            using MySqlCommand cmd = new MySqlCommand(sql, conector);
            cmd.Parameters.AddWithValue("@cod_funcionario", produto.cod_funcionario);
            cmd.Parameters.AddWithValue("@nome", produto.nome);
            cmd.Parameters.AddWithValue("@marca", produto.marca);
            cmd.Parameters.AddWithValue("@preco", produto.preco);
            cmd.Parameters.AddWithValue("@quantidade", produto.quantidade);
            cmd.ExecuteNonQuery();
            return (int)cmd.LastInsertedId;
        }

        public List<Produto> listarProdutos()
        {
            using MySqlConnection conector = BancoDeDados.conexao();
            string sql = "SELECT * FROM produto";
            using MySqlCommand cmd = new MySqlCommand(sql, conector);
            using var cursor = cmd.ExecuteReader();

            List<Produto> lista = new List<Produto>();
            while (cursor.Read())
            {
                lista.Add(mapear(cursor));
            }
            return lista;
        }

        public List<Produto> listarPorPagina(int quantidade, int pagina)
        {
            int offset = quantidade * (pagina - 1);
            using MySqlConnection conector = BancoDeDados.conexao();
            string sql = "SELECT * FROM produto LIMIT @limit OFFSET @offset";
            using MySqlCommand cmd = new MySqlCommand(sql, conector);
            cmd.Parameters.AddWithValue("@limit", quantidade);
            cmd.Parameters.AddWithValue("@offset", offset);
            using var cursor = cmd.ExecuteReader();

            List<Produto> listaDeProdutos = new List<Produto>();
            while (cursor.Read())
            {
                listaDeProdutos.Add(mapear(cursor));
            }
            return listaDeProdutos;
        }

        public int quantidadeProdutos()
        {
            using MySqlConnection conector = BancoDeDados.conexao();
            string sql = "SELECT COUNT(*) FROM produto";
            using MySqlCommand cmd = new MySqlCommand(sql, conector);
            return Convert.ToInt32(cmd.ExecuteScalar());            
        }
    
        public bool atualizar(Produto produto)
        {
            using MySqlConnection conector = BancoDeDados.conexao();
            string sql = @"UPDATE produto SET
                 nome = @nome
                ,marca = @marca
                ,preco = @preco
                ,quantidade = @quantidade
                WHERE cod_produto = @cod_produto";
            using MySqlCommand cmd = new MySqlCommand(sql, conector);
            cmd.Parameters.AddWithValue("@nome", produto.nome);
            cmd.Parameters.AddWithValue("@marca", produto.marca);
            cmd.Parameters.AddWithValue("@preco", produto.preco);
            cmd.Parameters.AddWithValue("@quantidade", produto.quantidade);
            cmd.Parameters.AddWithValue("@cod_produto", produto.cod_produto);
            
            // ExecuteNonQuery retorna um valor que representa a quantidade de registros alterados
            return cmd.ExecuteNonQuery() > 0;
        }

        public bool excluir(int cod_produto)
        {
            using MySqlConnection conector = BancoDeDados.conexao();
            string sql = @"DELETE FROM produto
                WHERE cod_produto = @cod_produto";
            using MySqlCommand cmd = new MySqlCommand(sql, conector);
            cmd.Parameters.AddWithValue("@cod_produto", cod_produto);

            // ExecuteNonQuery retorna um valor que representa a quantidade de registros alterados
            return cmd.ExecuteNonQuery() > 0;
        }

    }
}
