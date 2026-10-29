using ProjetoVenda.model;
using ProjetoVenda.repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoVenda.controller
{
    internal class ProductController
    {
        private ProductRepository repository;

        public ProductController()
        {
            repository = new ProductRepository();
        }

        public bool createProduct(Product product)
        {
            int cod_funcionario = Session.userAuth.cod_funcionario;
            product.cod_funcionario = cod_funcionario;
            product.validar();
            // fazer o cadastro
            repository.createProduct(product);

            return true;
        }

        public List<Product> getAll()
        {
            return repository.getAll();
        }

        public List<Product> listarPorPagina(int qtd, int pagina)
        {
            return repository.listarPorPagina(qtd, pagina);
        }

        public int quantidadePaginas(int quantidadeItensPorPagina)
        {
            int totalProdutos = repository.quantidadeProdutos();
            return (int) Math.Ceiling((decimal)totalProdutos / quantidadeItensPorPagina);
        }

        public bool atualizar(Product product)
        {
            return repository.atualizar(product);
        }

        public bool excluir(Product product)
        {
            return repository.excluir(product.cod_produto);
        }
    }
}
