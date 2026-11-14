using ProjetoVenda.modelo;
using ProjetoVenda.repositorio;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoVenda.controle
{
    internal class ProdutoControle
    {
        private ProdutoRepositorio repositorio;

        public ProdutoControle()
        {
            repositorio = new ProdutoRepositorio();
        }

        public bool createProduct(Produto produto)
        {
            int cod_funcionario = Sessao.usuarioAutenticado.cod_funcionario;
            produto.cod_funcionario = cod_funcionario;
            produto.validar();
            // fazer o cadastro
            repositorio.criarProduto(produto);

            return true;
        }

        public List<Produto> listarProdutos()
        {
            return repositorio.listarProdutos();
        }

        public List<Produto> listarPorPagina(int quantidade, int pagina)
        {
            return repositorio.listarPorPagina(quantidade, pagina);
        }

        public int quantidadePaginas(int quantidadeItensPorPagina)
        {
            int quantidadeProdutos = repositorio.quantidadeProdutos();
            return (int) Math.Ceiling((decimal)quantidadeProdutos / quantidadeItensPorPagina);
        }

        public bool atualizar(Produto produto)
        {
            return repositorio.atualizar(produto);
        }

        public bool excluir(Produto produto)
        {
            return repositorio.excluir(produto.cod_produto);
        }
    }
}
