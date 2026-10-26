using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using ProjetoVenda.controller;

namespace ProjetoVenda.view
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            EmployeeController controller = new EmployeeController();
            string usuario = this.txtUsuario.Text;
            string senha = this.txtSenha.Text;

            if( controller.login(usuario, senha))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            } else
            {
                MessageBox.Show(
                    "Usuário ou senha incorretos",
                    "Erro de Login",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                //this.txtUsuario.Text = "";
                this.txtSenha.Clear();
            }

            /*

            if (Session.login(usuario, senha))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            } else
            {
                MessageBox.Show(
                    "Usuário ou senha incorretos",
                    "Erro de Login",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                //this.txtUsuario.Text = "";
                this.txtSenha.Text = "";
            }
            */
        }
    }
}
