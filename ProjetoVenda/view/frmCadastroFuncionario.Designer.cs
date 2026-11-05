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
            lblPaginas = new Label();
            btnProximo = new Button();
            btnAnterior = new Button();
            cbxQuantidadeFuncionarios = new ComboBox();
            btnAtualizar = new Button();
            cbxAdm = new ComboBox();
            label5 = new Label();
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
            txtUsuario.Location = new Point(355, 85);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuário";
            txtUsuario.Size = new Size(138, 23);
            txtUsuario.TabIndex = 6;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(355, 114);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.PlaceholderText = "Senha";
            txtSenha.Size = new Size(138, 23);
            txtSenha.TabIndex = 7;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(12, 114);
            txtNumero.Name = "txtNumero";
            txtNumero.PlaceholderText = "Numero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 4;
            // 
            // txtRua
            // 
            txtRua.Location = new Point(118, 85);
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
            txtComplemento.Location = new Point(118, 114);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.PlaceholderText = "Complemento";
            txtComplemento.Size = new Size(225, 23);
            txtComplemento.TabIndex = 5;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(12, 85);
            txtCep.Name = "txtCep";
            txtCep.PlaceholderText = "CEP";
            txtCep.Size = new Size(100, 23);
            txtCep.TabIndex = 2;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(11, 153);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 36);
            btnCadastrar.TabIndex = 9;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // txtConfirmacaoSenha
            // 
            txtConfirmacaoSenha.Location = new Point(499, 114);
            txtConfirmacaoSenha.Name = "txtConfirmacaoSenha";
            txtConfirmacaoSenha.PasswordChar = '*';
            txtConfirmacaoSenha.PlaceholderText = "Confirmação Senha";
            txtConfirmacaoSenha.Size = new Size(138, 23);
            txtConfirmacaoSenha.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 63);
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
            label3.Location = new Point(355, 67);
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
            dgvFuncionarios.AllowUserToAddRows = false;
            dgvFuncionarios.AllowUserToDeleteRows = false;
            dgvFuncionarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFuncionarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFuncionarios.Location = new Point(12, 195);
            dgvFuncionarios.Name = "dgvFuncionarios";
            dgvFuncionarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFuncionarios.Size = new Size(630, 310);
            dgvFuncionarios.TabIndex = 14;
            dgvFuncionarios.CellDoubleClick += dgvFuncionarios_CellDoubleClick;
            // 
            // lblPaginas
            // 
            lblPaginas.Location = new Point(92, 517);
            lblPaginas.Name = "lblPaginas";
            lblPaginas.Size = new Size(469, 39);
            lblPaginas.TabIndex = 17;
            lblPaginas.Text = "Pagina 1 de 5";
            lblPaginas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnProximo
            // 
            btnProximo.Location = new Point(567, 517);
            btnProximo.Name = "btnProximo";
            btnProximo.Size = new Size(75, 39);
            btnProximo.TabIndex = 16;
            btnProximo.Text = "Proximo >";
            btnProximo.UseVisualStyleBackColor = true;
            btnProximo.Click += btnProximo_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.Location = new Point(11, 517);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(75, 39);
            btnAnterior.TabIndex = 15;
            btnAnterior.Text = "< Anterior";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // cbxQuantidadeFuncionarios
            // 
            cbxQuantidadeFuncionarios.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxQuantidadeFuncionarios.FormattingEnabled = true;
            cbxQuantidadeFuncionarios.Items.AddRange(new object[] { "5", "10", "25", "50", "100" });
            cbxQuantidadeFuncionarios.Location = new Point(554, 166);
            cbxQuantidadeFuncionarios.Name = "cbxQuantidadeFuncionarios";
            cbxQuantidadeFuncionarios.Size = new Size(88, 23);
            cbxQuantidadeFuncionarios.TabIndex = 18;
            cbxQuantidadeFuncionarios.SelectedIndexChanged += cbxQuantidadeFuncionarios_SelectedIndexChanged;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(565, 16);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(75, 36);
            btnAtualizar.TabIndex = 19;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Visible = false;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // cbxAdm
            // 
            cbxAdm.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxAdm.FormattingEnabled = true;
            cbxAdm.Items.AddRange(new object[] { "Funcionario", "Administrador" });
            cbxAdm.Location = new Point(499, 85);
            cbxAdm.Name = "cbxAdm";
            cbxAdm.Size = new Size(138, 23);
            cbxAdm.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(499, 67);
            label5.Name = "label5";
            label5.Size = new Size(90, 15);
            label5.TabIndex = 21;
            label5.Text = "Tipo de Usuário";
            // 
            // frmCadastroFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 582);
            Controls.Add(label5);
            Controls.Add(cbxAdm);
            Controls.Add(btnAtualizar);
            Controls.Add(cbxQuantidadeFuncionarios);
            Controls.Add(lblPaginas);
            Controls.Add(btnProximo);
            Controls.Add(btnAnterior);
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
        private Label lblPaginas;
        private Button btnProximo;
        private Button btnAnterior;
        private ComboBox cbxQuantidadeFuncionarios;
        private Button btnAtualizar;
        private ComboBox cbxAdm;
        private Label label5;
    }
}