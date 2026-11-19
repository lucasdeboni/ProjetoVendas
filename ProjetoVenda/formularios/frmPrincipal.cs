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
        private List<Button> listaBotoesMenu;
        //private bool formularioAtivo;

        public frmPrincipal()
        {
            InitializeComponent();
            controller = new FuncionarioControle();
            Funcionario? funcionario = controller.usuarioAutenticado();
            string nome = (funcionario != null) ? funcionario.nome : "";
            this.Text += $" - {nome}";
            listaBotoesMenu = new List<Button> { btnCadProduto, btnCadVenda, btnCadFuncionario, btnPerfil };
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

            desativarBotao(listaBotoesMenu);
            //formularioAtivo = true;
            ativarBotao(btnCadFuncionario);
        }

        private void btnCadProduto_Click(object sender, EventArgs e)
        {
            frmCadastroProduto frm = new frmCadastroProduto();
            exibirFormulario(frm);

            desativarBotao(listaBotoesMenu);
            //formularioAtivo = true;
            ativarBotao(btnCadProduto);
            //frm.ShowDialog();
        }
        private void btnPerfil_Click(object sender, EventArgs e)
        {
            frmPerfilUsuario frm = new frmPerfilUsuario();
            exibirFormulario(frm);

            desativarBotao(listaBotoesMenu);
            //formularioAtivo = true;
            ativarBotao(btnPerfil);
        }



        private void btnCadVenda_Click(object sender, EventArgs e)
        {
            frmCadastroVenda frm = new frmCadastroVenda();
            exibirFormulario(frm);

            desativarBotao(listaBotoesMenu);
            //formularioAtivo = true;
            ativarBotao(btnCadVenda);
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            // evento para sair
            controller.deslogar();
            this.DialogResult = DialogResult.Retry;
            this.Dispose();
        }

        private void desativarBotao(List<Button> botoes)
        {
            //formularioAtivo = false;
            foreach(Button botao in botoes)
            {
                botao.BackColor = SystemColors.Menu;
                botao.ForeColor = SystemColors.ControlText;
            }
        }

        private void ativarBotao(Button button)
        {
            button.BackColor = Color.RoyalBlue;
            button.ForeColor = Color.White;
        }
    }
}
