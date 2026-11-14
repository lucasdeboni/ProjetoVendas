using ProjetoVenda.controle;
using ProjetoVenda.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;

namespace ProjetoVenda.formularios
{
    public partial class frmCadastroFuncionario : Form
    {
        private FuncionarioControle controller;
        private Funcionario? funcionarioSelecionado;
        private int totalDePaginas = 5;
        private int paginaAtual = 1;
        private int totalPorPagina = 5;

        public frmCadastroFuncionario()
        {
            InitializeComponent();
            controller = new FuncionarioControle();
        }

        private void limparCampos()
        {
            this.txtNome.Clear();
            this.txtTelefone.Clear();
            this.txtRua.Clear();
            this.txtNumero.Clear();
            this.txtCep.Clear();
            this.txtComplemento.Clear();

            this.txtUsuario.Clear();
            this.txtSenha.Clear();
            this.txtConfirmacaoSenha.Clear();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = this.txtNome.Text;
            string telefone = this.txtTelefone.Text;
            string rua = this.txtRua.Text;
            string numero = this.txtNumero.Text;
            string cep = this.txtCep.Text;
            string complemento = this.txtComplemento.Text;

            string usuario = this.txtUsuario.Text;
            string senha = this.txtSenha.Text;
            string confirmacaoSenha = this.txtConfirmacaoSenha.Text;
            bool adm = this.cbxAdm.Text == "Administrador";

            if (senha != confirmacaoSenha)
            {
                MessageBox.Show(
                      "Senhas não conferem."
                    , "Senhas incorretas"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error
                    );
                return;
            }

            // chamar o controlador do usuário para cadastro
            Funcionario funcionario = new Funcionario
            {
                nome = nome,
                telefone = telefone,
                rua = rua,
                numero = numero,
                cep = cep,
                complemento = complemento,
                usuario = usuario,
                senha = senha,
                adm = adm
            };

            bool resp = controller.criarFuncionario(funcionario);

            if (resp)
            {
                MessageBox.Show(
                    "Funcionário Cadastrado Com Sucesso"
                    , "Cadastro Funcionário"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Information
                    );
                limparCampos();
                carregarFuncionarios();
            }
            else
            {
                MessageBox.Show(
                    "Erro ao Cadastrar Funcionário"
                    , "Cadastro Funcionário"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error
                    );
            }
        }

        private void frmCadastroFuncionario_Load(object sender, EventArgs e)
        {
            this.cbxQuantidadeFuncionarios.SelectedIndex = 1;
            carregarFuncionarios();
            this.cbxAdm.SelectedIndex = 0;
        }

        private void carregarFuncionarios()
        {
            totalDePaginas = controller.quantidadePaginas(totalPorPagina);
            if (paginaAtual > totalDePaginas)
            {
                paginaAtual = totalDePaginas;
            }
            atualizarLblPagina();

            //List<Employee> list = controller.getAll();
            List<Funcionario> list = controller.listarPorPagina(totalPorPagina, paginaAtual);
            this.dgvFuncionarios.DataSource = list;
            this.dgvFuncionarios.Columns["senha"].Visible = false;
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (paginaAtual < totalDePaginas)
            {
                paginaAtual++;
                atualizarLblPagina();
                carregarFuncionarios();
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (paginaAtual > 1)
            {
                paginaAtual--;
                atualizarLblPagina();
                carregarFuncionarios();
            }
        }

        private void atualizarLblPagina()
        {
            this.lblPaginas.Text = $"Pagina {paginaAtual} de {totalDePaginas}";
        }

        private void cbxQuantidadeFuncionarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Capturar o numero
            // recalcular as paginas
            this.totalPorPagina = int.Parse(this.cbxQuantidadeFuncionarios.Text);
            carregarFuncionarios();
        }

        private void dgvFuncionarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            DataGridViewRow linha = this.dgvFuncionarios.Rows[e.RowIndex];
            Funcionario? funcionario = linha.DataBoundItem as Funcionario;

            this.txtNome.Text = funcionario.nome;
            this.txtTelefone.Text = funcionario.telefone;
            this.txtRua.Text = funcionario.rua;
            this.txtNumero.Text = funcionario.numero;
            this.txtCep.Text = funcionario.cep;
            this.txtComplemento.Text = funcionario.complemento;

            this.txtUsuario.Text = funcionario.usuario;

            funcionarioSelecionado = funcionario;
            //this.btnAtualizar.Enabled = true;
            //this.btnExcluir.Enabled = true;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            // evento de atualizar
            //funcionarioSelecionado.nome = this.txtNome.Text;
            //funcionarioSelecionado.marca = this.txtMarca.Text;
            //funcionarioSelecionado.preco = Convert.ToInt32(this.txtPreco.Text);
            //funcionarioSelecionado.quantidade = (int)this.txtQuantidade.Value;

            //bool resp = controller.atualizar(produtoSelecionado);
            //if (resp)
            //{
            //    MessageBox.Show(
            //        "Produto Atualizado com sucesso"
            //        , "Atualização do produto"
            //        , MessageBoxButtons.OK
            //        , MessageBoxIcon.Information
            //        );
            //    limparCampos();
            //    carregarProdutos();
            //    produtoSelecionado = null;
            //    this.btnAtualizar.Enabled = false;
            //    this.btnExcluir.Enabled = false;

            //}
            //else
            //{
            //    MessageBox.Show(
            //        "Erro ao atualizar o produto"
            //        , "Atualização do produto"
            //        , MessageBoxButtons.OK
            //        , MessageBoxIcon.Error
            //        );
            //}
        }
    }
}
