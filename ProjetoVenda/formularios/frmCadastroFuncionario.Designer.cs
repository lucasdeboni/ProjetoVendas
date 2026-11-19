namespace ProjetoVenda.formularios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroFuncionario));
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            txtTelefone = new TextBox();
            txtConfirmacaoSenha = new TextBox();
            label2 = new Label();
            label3 = new Label();
            cbxAdm = new ComboBox();
            label5 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            dgvFuncionarios = new DataGridView();
            panel1 = new Panel();
            panel3 = new Panel();
            btnAtualizar = new Button();
            btnCadastrar = new Button();
            panel2 = new Panel();
            label4 = new Label();
            label1 = new Label();
            txtCep = new TextBox();
            txtComplemento = new TextBox();
            txtNumero = new TextBox();
            txtRua = new TextBox();
            txtNome = new TextBox();
            panel4 = new Panel();
            cbxQuantidadeFuncionarios = new ComboBox();
            panel5 = new Panel();
            lblPaginas = new Label();
            btnProximo = new Button();
            btnAnterior = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFuncionarios).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(16, 97);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuário";
            txtUsuario.Size = new Size(138, 23);
            txtUsuario.TabIndex = 6;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(16, 126);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.PlaceholderText = "Senha";
            txtSenha.Size = new Size(138, 23);
            txtSenha.TabIndex = 7;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(16, 41);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.PlaceholderText = "Telefone";
            txtTelefone.Size = new Size(120, 23);
            txtTelefone.TabIndex = 1;
            // 
            // txtConfirmacaoSenha
            // 
            txtConfirmacaoSenha.Location = new Point(160, 126);
            txtConfirmacaoSenha.Name = "txtConfirmacaoSenha";
            txtConfirmacaoSenha.PasswordChar = '*';
            txtConfirmacaoSenha.PlaceholderText = "Confirmação Senha";
            txtConfirmacaoSenha.Size = new Size(138, 23);
            txtConfirmacaoSenha.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 23);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 11;
            label2.Text = "Contato";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 79);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 12;
            label3.Text = "Login";
            // 
            // cbxAdm
            // 
            cbxAdm.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxAdm.FormattingEnabled = true;
            cbxAdm.Items.AddRange(new object[] { "Funcionario", "Administrador" });
            cbxAdm.Location = new Point(160, 97);
            cbxAdm.Name = "cbxAdm";
            cbxAdm.Size = new Size(138, 23);
            cbxAdm.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(160, 79);
            label5.Name = "label5";
            label5.Size = new Size(90, 15);
            label5.TabIndex = 21;
            label5.Text = "Tipo de Usuário";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(dgvFuncionarios, 0, 2);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel4, 0, 1);
            tableLayoutPanel1.Controls.Add(panel5, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 240F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            tableLayoutPanel1.Size = new Size(684, 639);
            tableLayoutPanel1.TabIndex = 22;
            // 
            // dgvFuncionarios
            // 
            dgvFuncionarios.AllowUserToAddRows = false;
            dgvFuncionarios.AllowUserToDeleteRows = false;
            dgvFuncionarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFuncionarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFuncionarios.Dock = DockStyle.Fill;
            dgvFuncionarios.Location = new Point(15, 293);
            dgvFuncionarios.Margin = new Padding(15, 18, 15, 18);
            dgvFuncionarios.Name = "dgvFuncionarios";
            dgvFuncionarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFuncionarios.Size = new Size(654, 238);
            dgvFuncionarios.TabIndex = 24;
            dgvFuncionarios.CellContentDoubleClick += dgvFuncionarios_CellDoubleClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(678, 234);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top;
            panel3.Controls.Add(btnAtualizar);
            panel3.Controls.Add(btnCadastrar);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(txtUsuario);
            panel3.Controls.Add(cbxAdm);
            panel3.Controls.Add(txtSenha);
            panel3.Controls.Add(txtTelefone);
            panel3.Controls.Add(txtConfirmacaoSenha);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(360, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(315, 231);
            panel3.TabIndex = 1;
            // 
            // btnAtualizar
            // 
            btnAtualizar.BackColor = Color.RoyalBlue;
            btnAtualizar.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            btnAtualizar.FlatStyle = FlatStyle.Flat;
            btnAtualizar.ForeColor = SystemColors.ControlLightLight;
            btnAtualizar.Location = new Point(142, 193);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(75, 23);
            btnAtualizar.TabIndex = 23;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = false;
            btnAtualizar.Visible = false;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.RoyalBlue;
            btnCadastrar.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.ForeColor = SystemColors.ButtonHighlight;
            btnCadastrar.Location = new Point(223, 172);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 46);
            btnCadastrar.TabIndex = 22;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtCep);
            panel2.Controls.Add(txtComplemento);
            panel2.Controls.Add(txtNumero);
            panel2.Controls.Add(txtRua);
            panel2.Controls.Add(txtNome);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(301, 228);
            panel2.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 23);
            label4.Name = "label4";
            label4.Size = new Size(96, 15);
            label4.TabIndex = 20;
            label4.Text = "Nome Completo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 75);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 19;
            label1.Text = "Endereço";
            // 
            // txtCep
            // 
            txtCep.Location = new Point(20, 97);
            txtCep.Name = "txtCep";
            txtCep.PlaceholderText = "CEP";
            txtCep.Size = new Size(100, 23);
            txtCep.TabIndex = 15;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(126, 158);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.PlaceholderText = "Complemento";
            txtComplemento.Size = new Size(154, 23);
            txtComplemento.TabIndex = 18;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(20, 158);
            txtNumero.Name = "txtNumero";
            txtNumero.PlaceholderText = "Numero";
            txtNumero.Size = new Size(96, 23);
            txtNumero.TabIndex = 17;
            // 
            // txtRua
            // 
            txtRua.Location = new Point(20, 129);
            txtRua.Name = "txtRua";
            txtRua.PlaceholderText = "Rua";
            txtRua.Size = new Size(260, 23);
            txtRua.TabIndex = 16;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(20, 41);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome";
            txtNome.Size = new Size(260, 23);
            txtNome.TabIndex = 14;
            // 
            // panel4
            // 
            panel4.Controls.Add(cbxQuantidadeFuncionarios);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 243);
            panel4.Name = "panel4";
            panel4.Size = new Size(678, 29);
            panel4.TabIndex = 1;
            // 
            // cbxQuantidadeFuncionarios
            // 
            cbxQuantidadeFuncionarios.Anchor = AnchorStyles.Top;
            cbxQuantidadeFuncionarios.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxQuantidadeFuncionarios.FormattingEnabled = true;
            cbxQuantidadeFuncionarios.Items.AddRange(new object[] { "5", "10", "25", "50", "100" });
            cbxQuantidadeFuncionarios.Location = new Point(557, 3);
            cbxQuantidadeFuncionarios.Name = "cbxQuantidadeFuncionarios";
            cbxQuantidadeFuncionarios.Size = new Size(88, 23);
            cbxQuantidadeFuncionarios.TabIndex = 28;
            cbxQuantidadeFuncionarios.SelectedIndexChanged += cbxQuantidadeFuncionarios_SelectedIndexChanged;
            // 
            // panel5
            // 
            panel5.Controls.Add(lblPaginas);
            panel5.Controls.Add(btnProximo);
            panel5.Controls.Add(btnAnterior);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(3, 552);
            panel5.Name = "panel5";
            panel5.Size = new Size(678, 84);
            panel5.TabIndex = 25;
            // 
            // lblPaginas
            // 
            lblPaginas.Anchor = AnchorStyles.Top;
            lblPaginas.Location = new Point(105, 23);
            lblPaginas.Name = "lblPaginas";
            lblPaginas.Size = new Size(469, 39);
            lblPaginas.TabIndex = 29;
            lblPaginas.Text = "Pagina 1 de 5";
            lblPaginas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnProximo
            // 
            btnProximo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnProximo.FlatStyle = FlatStyle.Flat;
            btnProximo.Location = new Point(593, 23);
            btnProximo.Name = "btnProximo";
            btnProximo.Size = new Size(75, 39);
            btnProximo.TabIndex = 28;
            btnProximo.Text = "Proximo >";
            btnProximo.UseVisualStyleBackColor = true;
            btnProximo.Click += btnProximo_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.FlatStyle = FlatStyle.Flat;
            btnAnterior.Location = new Point(11, 23);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(75, 39);
            btnAnterior.TabIndex = 27;
            btnAnterior.Text = "< Anterior";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // frmCadastroFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 639);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmCadastroFuncionario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Funcionario";
            Load += frmCadastroFuncionario_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFuncionarios).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private TextBox txtTelefone;
        private TextBox txtConfirmacaoSenha;
        private Label label2;
        private Label label3;
        private ComboBox cbxAdm;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel3;
        private Button btnAtualizar;
        private Button btnCadastrar;
        private Panel panel2;
        private Label label4;
        private Label label1;
        private TextBox txtCep;
        private TextBox txtComplemento;
        private TextBox txtNumero;
        private TextBox txtRua;
        private TextBox txtNome;
        private DataGridView dgvFuncionarios;
        private Panel panel4;
        private ComboBox cbxQuantidadeFuncionarios;
        private Panel panel5;
        private Label lblPaginas;
        private Button btnProximo;
        private Button btnAnterior;
    }
}