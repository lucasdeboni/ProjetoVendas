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
    public partial class frmPerfilUsuario : Form
    {
        private FuncionarioControle controller;
        private Funcionario? funcionario;

        public frmPerfilUsuario()
        {
            InitializeComponent();
            controller = new FuncionarioControle();
        }

        private void frmPerfilUsuario_Load(object sender, EventArgs e)
        {
            funcionario = controller.usuarioAutenticado();
            if(funcionario != null)
            {
                carregarDados();
            }
        }

        private void carregarDados()
        {
            this.txtNome.Text = funcionario.nome;
            this.txtTelefone.Text = funcionario.telefone;
            this.txtCep.Text = funcionario.cep;
            this.txtRua.Text = funcionario.rua;
            this.txtNumero.Text = funcionario.numero;
            this.txtComplemento.Text = funcionario.complemento;

            this.txtUsuario.Text = funcionario.usuario;
        }
    }
}
