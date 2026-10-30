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
    public partial class frmCadastroFuncionario : Form
    {
        private EmployeeController controller;

        public frmCadastroFuncionario()
        {
            InitializeComponent();
            controller = new EmployeeController();
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
            EmployeeController controller = new EmployeeController();
            bool resp = controller.createEmployee(nome, telefone, rua, numero, cep, complemento, usuario, senha);

            if (resp)
            {
                MessageBox.Show(
                    "Funcionário Cadastrado Com Sucesso"
                    , "Cadastro Funcionário"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Information
                    );
                limparCampos();
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
            carregarFuncionarios();
        }

        private void carregarFuncionarios()
        {
            //totalDePaginas = controller.quantidadePaginas(totalPorPagina);
            //if (paginaAtual > totalDePaginas)
            //{
            //    paginaAtual = totalDePaginas;
            //}
            //atualizarLblPagina();

            List<Employee> list = controller.getAll();
            this.dgvFuncionarios.DataSource = list;
            this.dgvFuncionarios.Columns["senha"].Visible = false;
        }
    }
}
