using ProjetoVenda.controle;
using ProjetoVenda.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoVenda.formularios
{
    public partial class frmPrincipal : Form
    {
        private FuncionarioControle controller;

        public frmPrincipal()
        {
            InitializeComponent();
            controller = new FuncionarioControle();
            Funcionario? funcionario = controller.usuarioAutenticado();
            string nome = (funcionario != null) ? funcionario.nome : "";
            this.Text += $" - {nome}";
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            string username = Sessao.usuarioAutenticado.nome;
            this.lblUsername.Text = username;

            bool adm = controller.usuarioAdministrador();
            if (!adm)
            {
                this.btnCadFuncionario.Visible = false;
            }
        }

        private void exibirFormulario(Form formulario)
        {
            while (painelPrincipal.Controls.Count > 0)
            {
                painelPrincipal.Controls[0].Dispose();
            }

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            this.lblTitulo.Text = formulario.Text;

            painelPrincipal.Controls.Add(formulario);
            formulario.Show();
        }

        private void btnCadFuncionario_Click(object sender, EventArgs e)
        {
            frmCadastroFuncionario frm = new frmCadastroFuncionario();
            exibirFormulario(frm);
            //frm.ShowDialog();
        }

        private void btnCadProduto_Click(object sender, EventArgs e)
        {
            frmCadastroProduto frm = new frmCadastroProduto();
            exibirFormulario(frm);
            //frm.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            // evento para sair
            controller.deslogar();
            this.DialogResult = DialogResult.Retry;
            this.Dispose();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            frmPerfilUsuario frm = new frmPerfilUsuario();
            exibirFormulario(frm);
        }

        private void btnCadVenda_Click(object sender, EventArgs e)
        {
            frmCadastroVenda frm = new frmCadastroVenda();
            exibirFormulario(frm);
        }
    }
}
