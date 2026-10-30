namespace ProjetoVenda.view
{
    partial class frmCadastroFuncionario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNome = new TextBox();
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            txtNumero = new TextBox();
            txtRua = new TextBox();
            txtTelefone = new TextBox();
            txtComplemento = new TextBox();
            txtCep = new TextBox();
            btnCadastrar = new Button();
            txtConfirmacaoSenha = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dgvFuncionarios = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvFuncionarios).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 29);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome";
            txtNome.Size = new Size(304, 23);
            txtNome.TabIndex = 0;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(358, 89);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuário";
            txtUsuario.Size = new Size(138, 23);
            txtUsuario.TabIndex = 6;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(358, 118);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.PlaceholderText = "Senha";
            txtSenha.Size = new Size(138, 23);
            txtSenha.TabIndex = 7;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(12, 118);
            txtNumero.Name = "txtNumero";
            txtNumero.PlaceholderText = "Numero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 4;
            // 
            // txtRua
            // 
            txtRua.Location = new Point(118, 89);
            txtRua.Name = "txtRua";
            txtRua.PlaceholderText = "Rua";
            txtRua.Size = new Size(225, 23);
            txtRua.TabIndex = 3;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(355, 29);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.PlaceholderText = "Telefone";
            txtTelefone.Size = new Size(120, 23);
            txtTelefone.TabIndex = 1;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(118, 118);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.PlaceholderText = "Complemento";
            txtComplemento.Size = new Size(225, 23);
            txtComplemento.TabIndex = 5;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(12, 89);
            txtCep.Name = "txtCep";
            txtCep.PlaceholderText = "CEP";
            txtCep.Size = new Size(100, 23);
            txtCep.TabIndex = 2;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(12, 147);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 36);
            btnCadastrar.TabIndex = 9;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // txtConfirmacaoSenha
            // 
            txtConfirmacaoSenha.Location = new Point(502, 118);
            txtConfirmacaoSenha.Name = "txtConfirmacaoSenha";
            txtConfirmacaoSenha.PasswordChar = '*';
            txtConfirmacaoSenha.PlaceholderText = "Confirmação Senha";
            txtConfirmacaoSenha.Size = new Size(138, 23);
            txtConfirmacaoSenha.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 67);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 10;
            label1.Text = "Endereço";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(355, 11);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 11;
            label2.Text = "Contato";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(358, 71);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 12;
            label3.Text = "Login";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 11);
            label4.Name = "label4";
            label4.Size = new Size(96, 15);
            label4.TabIndex = 13;
            label4.Text = "Nome Completo";
            // 
            // dgvFuncionarios
            // 
            dgvFuncionarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFuncionarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFuncionarios.Location = new Point(12, 202);
            dgvFuncionarios.Name = "dgvFuncionarios";
            dgvFuncionarios.Size = new Size(628, 310);
            dgvFuncionarios.TabIndex = 14;
            // 
            // frmCadastroFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 524);
            Controls.Add(dgvFuncionarios);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtConfirmacaoSenha);
            Controls.Add(btnCadastrar);
            Controls.Add(txtCep);
            Controls.Add(txtComplemento);
            Controls.Add(txtNumero);
            Controls.Add(txtRua);
            Controls.Add(txtTelefone);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            Controls.Add(txtNome);
            Name = "frmCadastroFuncionario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Funcionario";
            Load += frmCadastroFuncionario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFuncionarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private TextBox txtNumero;
        private TextBox txtRua;
        private TextBox txtTelefone;
        private TextBox txtComplemento;
        private TextBox txtCep;
        private Button btnCadastrar;
        private TextBox txtConfirmacaoSenha;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dgvFuncionarios;
    }
}