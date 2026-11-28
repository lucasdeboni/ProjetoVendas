using MySqlConnector;
using ProjetoVenda.bancoDeDados;
using ProjetoVenda.modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoVenda.repositorio
{
    internal class VendaRepositorio
    {
        public bool cadastrarVenda(Venda venda)
        {
            using MySqlConnection conector = BancoDeDados.conexao();
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
                    using var cursor = cmdBloqueio.ExecuteReader();
                    if (!cursor.Read())
                    {
                        throw new Exception("Erro no registro!");
                    }
                    
                    int quantidade = cursor.GetInt32("quantidade");
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

        public List<Venda> listarVendasMes(int mes, int ano)
        {
            DateTime dataInicial = new DateTime(ano, mes, 1);
            DateTime dataFinal = dataInicial.AddMonths(1);

            string sql = @"
                SELECT
	                v.*,
                    f.nome as nome_funcionario,
                    i.*,
                    p.nome,
                    p.marca
                FROM venda v
                JOIN funcionario f
	                ON f.cod_funcionario = v.cod_funcionario
                JOIN item i
	                ON i.cod_venda = v.cod_venda
                JOIN produto p
	                ON p.cod_produto = i.cod_produto
                WHERE v.data >= @dataInicial AND v.data < @dataFinal
                ORDER BY v.data, v.cod_venda, p.cod_produto;";
            using MySqlConnection conexao = BancoDeDados.conexao();
            using MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@dataInicial", dataInicial);
            comando.Parameters.AddWithValue("@dataFinal", dataFinal);

            MySqlDataReader cursor = comando.ExecuteReader();

            List<Venda> listaDeVenda = new List<Venda>();

            while (cursor.Read())
            {
                int cod_venda = cursor.GetInt32("cod_venda");
                Venda? venda = listaDeVenda.Find(v => v.cod_venda == cod_venda);
                if (venda == null)
                {
                    venda = new Venda
                    {
                        cod_venda = cursor.GetInt32("cod_venda"),
                        cod_funcionario = cursor.GetInt32("cod_funcionario"),
                        data = cursor.GetDateTime("data"),
                        nomeFuncionario = cursor.GetString("nome_funcionario"),
                    };
                    listaDeVenda.Add(venda);
                }

                if (!cursor.IsDBNull(cursor.GetOrdinal("cod_item")))
                {
                    Item item = new Item
                    {
                        cod_item = cursor.GetInt32("cod_item"),
                        cod_venda = cursor.GetInt32("cod_venda"),
                        cod_produto = cursor.GetInt32("cod_produto"),
                        quantidade = cursor.GetInt32("quantidade"),
                        preco = cursor.GetInt32("preco"),
                        nomeProduto = cursor.GetString("nome"),
                        marcaProduto = cursor.GetString("marca")
                    };
                    venda.itens.Add(item);
                }

            }
            return listaDeVenda;
        }
    }
}
