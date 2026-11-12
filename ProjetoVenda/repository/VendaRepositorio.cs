using MySqlConnector;
using ProjetoVenda.database;
using ProjetoVenda.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoVenda.repository
{
    internal class VendaRepositorio
    {
        public bool cadastrarVenda(Venda venda)
        {
            using MySqlConnection conector = Database.GetConnection();
            using MySqlTransaction transacao = conector.BeginTransaction();
            try
            {
                // Bloquear os produtos
                foreach(var item in venda.itens.OrderBy(item => item.cod_produto))
                {
                    string sqlBloqueio = @"SELECT * FROM produto
                            WHERE cod_produto = @cod_produto FOR UPDATE";

                    using var cmdBloqueio = new MySqlCommand(sqlBloqueio, conector, transacao);
                    cmdBloqueio.Parameters.AddWithValue("@cod_produto", item.cod_produto);
                    using var reader = cmdBloqueio.ExecuteReader();
                    if (!reader.Read())
                    {
                        throw new Exception("Erro no registro!");
                    }
                    
                    int quantidade = reader.GetInt32("quantidade");
                    if (quantidade < item.quantidade)
                    {
                        throw new Exception($"Quantidade indisponível do produto: {item.nomeProduto}");
                    }

                }

                // Registrar a venda
                string sqlVenda = @"INSERT INTO venda (cod_funcionario)
                    VALUES (@cod_funcionario)";
                using var cmdVenda = new MySqlCommand(sqlVenda, conector, transacao);
                cmdVenda.Parameters.AddWithValue("@cod_funcionario", venda.cod_funcionario);
                cmdVenda.ExecuteNonQuery();
                venda.cod_venda = (int) cmdVenda.LastInsertedId;

                // registrar os itens
                foreach (var item in venda.itens)
                {
                    string sqlItem = @"INSERT INTO item
                        (cod_venda, cod_produto, quantidade, preco)
                        VALUES
                        (@cod_venda, @cod_produto, @quantidade, @preco)";

                    using var cmdItem = new MySqlCommand(sqlItem, conector, transacao);
                    cmdItem.Parameters.AddWithValue("@cod_venda", venda.cod_venda);
                    cmdItem.Parameters.AddWithValue("@cod_produto", item.cod_produto);
                    cmdItem.Parameters.AddWithValue("@quantidade", item.quantidade);
                    cmdItem.Parameters.AddWithValue("@preco", item.preco);
                    int linhaAlterada = cmdItem.ExecuteNonQuery();
                    if (linhaAlterada != 1)
                    {
                        throw new Exception($"Erro ao cadastrar o produto: {item.nomeProduto}.");
                    }

                    // atualizar a quantidade dos produtos
                    string sqlQuantidade = @"UPDATE produto SET
                        quantidade = quantidade - @quantidade
                        WHERE cod_produto = @cod_produto";
                    using MySqlCommand cmdQuantidade = new MySqlCommand(sqlQuantidade, conector, transacao);
                    cmdQuantidade.Parameters.AddWithValue("@quantidade", item.quantidade);
                    cmdQuantidade.Parameters.AddWithValue("@cod_produto", item.cod_produto);
                    linhaAlterada = cmdQuantidade.ExecuteNonQuery();
                    if (linhaAlterada != 1)
                    {
                        throw new Exception($"Erro ao atualizar a quantidade do produto: {item.nomeProduto}.");
                    }
                }

                transacao.Commit();
                return true;
            } catch (Exception ex)
            {
                transacao.Rollback();
                throw ex;
            }
        }
    }
}
