using ProjetoVenda.controller;
using ProjetoVenda.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoVenda.view
{
    public partial class frmCadastroProduto : Form
    {
        private ProductController controller;
        private Product? produtoSelecionado;

        public frmCadastroProduto()
        {
            InitializeComponent();
            controller = new ProductController();
        }

        private void limparCampos()
        {
            this.txtNome.Clear();
            this.txtMarca.Clear();
            this.txtPreco.Clear();
            this.txtQuantidade.Value = 0;
        }

        private void btnCadProduto_Click(object sender, EventArgs e)
        {
            string nome = this.txtNome.Text;
            string marca = this.txtMarca.Text;
            int preco = Convert.ToInt32(this.txtPreco.Text);
            int quantidade = Convert.ToInt32(this.txtQuantidade.Text);

            // encapsulando os dados
            Product product = new Product
            {
                nome = nome,
                marca = marca,
                preco = preco,
                quantidade = quantidade
            };

            // Enviar os dados para a controller
            bool resp = controller.createProduct(product);
            if (resp)
            {
                MessageBox.Show(
                    "Produto Cadastrado Com Sucesso"
                    , "Cadastro Produto"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Information
                    );
                limparCampos();
                carregarProdutos();
            }
            else
            {
                MessageBox.Show(
                    "Erro ao Cadastrar Produto"
                    , "Cadastro Produto"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error
                    );
            }
        }

        private void frmCadastroProduto_Load(object sender, EventArgs e)
        {
            // finalizar listar os produtos
            carregarProdutos();
        }

        private void carregarProdutos()
        {
            List<Product> list = controller.getAll();
            this.dgvProdutos.DataSource = list;
            this.dgvProdutos.Columns["cod_funcionario"].Visible = false;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            // evento de atualizar
            produtoSelecionado.nome = this.txtNome.Text;
            produtoSelecionado.marca = this.txtMarca.Text;
            produtoSelecionado.preco = Convert.ToInt32(this.txtPreco.Text);
            produtoSelecionado.quantidade = (int) this.txtQuantidade.Value;

            bool resp = controller.atualizar( produtoSelecionado );
            if (resp)
            {
                carregarProdutos();
                MessageBox.Show(
                    "Produto Atualizado com sucesso"
                    ,"Atualização do produto"
                    ,MessageBoxButtons.OK
                    ,MessageBoxIcon.Information
                    );
                limparCampos();
                this.btnAtualizar.Enabled = false;
                this.btnExcluir.Enabled = false;
            } else
            {
                MessageBox.Show(
                    "Erro ao atualizar o produto"
                    , "Atualização do produto"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error
                    );
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void dgvProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            DataGridViewRow linha = this.dgvProdutos.Rows[e.RowIndex];
            Product? produto = linha.DataBoundItem as Product;

            this.txtNome.Text = produto.nome;
            this.txtMarca.Text = produto.marca;
            this.txtPreco.Text = produto.preco.ToString();
            this.txtQuantidade.Value = produto.quantidade;
            produtoSelecionado = produto;
            this.btnAtualizar.Enabled = true;
        }
    
    }
}
