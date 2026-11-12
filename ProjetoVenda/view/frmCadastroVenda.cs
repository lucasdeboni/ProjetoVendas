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
    public partial class frmCadastroVenda : Form
    {

        private ProductController produtoControle;
        private VendaControle vendaControle;
        private List<Item> carrinho = new List<Item>();




        public frmCadastroVenda()
        {
            InitializeComponent();
            produtoControle = new ProductController();
            vendaControle = new VendaControle();
        }



        private void carregarProdutos()
        {
            List<Product> lista = produtoControle.listarProdutos();
            cbxProdutos.DataSource = lista;
            cbxProdutos.DisplayMember = "nome";
            cbxProdutos.ValueMember = "cod_produto";
        }

        private void configurarCarrinho()
        {
            this.dgvCarrinho.AutoGenerateColumns = false;
            this.dgvCarrinho.Columns.Clear();
            this.dgvCarrinho.Columns.Add(
                new DataGridViewTextBoxColumn
                {
                    HeaderText = "Produto",
                    Name = "colunaProduto",
                    DataPropertyName = "nomeProduto",
                });
            this.dgvCarrinho.Columns.Add(
                new DataGridViewTextBoxColumn
                {
                    HeaderText = "Marca",
                    Name = "colunaMarca",
                    DataPropertyName = "marcaProduto",
                });
            this.dgvCarrinho.Columns.Add(
                new DataGridViewTextBoxColumn
                {
                    HeaderText = "Quantidade",
                    Name = "colunaQuantidade",
                    DataPropertyName = "quantidade",
                });
            this.dgvCarrinho.Columns.Add(
                new DataGridViewTextBoxColumn
                {
                    HeaderText = "Preço",
                    Name = "colunaPreco",
                    DataPropertyName = "precoReal",
                    DefaultCellStyle = new DataGridViewCellStyle
                    {
                        Format = "C2"
                    }
                });
            this.dgvCarrinho.Columns.Add(
                new DataGridViewTextBoxColumn
                {
                    HeaderText = "Subtotal",
                    Name = "colunaSubTotal",
                    DataPropertyName = "subtotal",
                    DefaultCellStyle = new DataGridViewCellStyle
                    {
                        Format = "C2"
                    }
                });
        }

        public void atualizarCarrinho()
        {
            this.dgvCarrinho.DataSource = this.carrinho.ToList();
            this.btnCadastrar.Enabled = this.carrinho.Count() > 0;
            decimal total = this.carrinho.Sum(item => item.subtotal);
            this.lblPrecoTotal.Text = $"Total da Venda: {total:c2}";
        }

        private void frmCadastroVenda_Load(object sender, EventArgs e)
        {
            carregarProdutos();
            configurarCarrinho();
            atualizarCarrinho();
        }



        private void cbxProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product produto = cbxProdutos.SelectedItem as Product;
            this.lblPreco.Text = $"Preço Unitário: {produto.precoReal:C2}";
            this.lblQuantidade.Text = $"Quantidade Disponível: {produto.quantidade}";
            this.numQuantidade.Maximum = produto.quantidade;
            this.numQuantidade.Value = (numQuantidade.Maximum > 0) ? 1 : 0;

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Product produto = cbxProdutos.SelectedItem as Product;
            int quantidade = (int)this.numQuantidade.Value;


            Item? itemExistente = this.carrinho.FirstOrDefault(item => item.cod_produto == produto.cod_produto);

            if (itemExistente == null)
            {
                Item novoItem = new Item
                {
                    cod_produto = produto.cod_produto,
                    quantidade = quantidade,
                    preco = produto.preco,
                    nomeProduto = produto.nome,
                    marcaProduto = produto.marca
                };
                this.carrinho.Add(novoItem);
            }
            else
            {
                itemExistente.quantidade += quantidade;
            }

            produto.quantidade -= quantidade;
            this.cbxProdutos.SelectedItem = produto;
            cbxProdutos_SelectedIndexChanged(this, EventArgs.Empty);


            atualizarCarrinho();


        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            decimal total = this.carrinho.Sum(item => item.subtotal);
            DialogResult confirmar = MessageBox.Show(
                $"Deseja efeturar a venda no valor: {total:c2}",
                "Confirmar Venda",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question
                );

            if ( confirmar == DialogResult.No )
            {
                return;
            }

            // enviar os dados para o controle
            try
            {
                bool resposta = vendaControle.cadastrarVenda( this.carrinho );
                if (resposta)
                {
                    carrinho.Clear();
                    frmCadastroVenda_Load(this, EventArgs.Empty);
                    MessageBox.Show("Venda Cadastrada com sucesso!!!", "Cadastro Venda");

                } else
                {
                    MessageBox.Show($"Erro ao cadastrar Venda!", "Erro no Cadastro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }catch ( Exception ex )
            {
                MessageBox.Show($"Erro: {ex.Message}","Erro no Cadastro",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            carrinho.Clear();
            frmCadastroVenda_Load(this, EventArgs.Empty );
            MessageBox.Show("Venda Cadastrada com sucesso!!!");

        }
    }
}
