namespace ProjetoVenda.formularios
{
    partial class frmCadastroProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroProduto));
            painelRodape = new TableLayoutPanel();
            dgvProdutos = new DataGridView();
            painelSuperior = new Panel();
            cbxQuantidadeItens = new ComboBox();
            btnExcluir = new Button();
            btnAtualizar = new Button();
            btnCadProduto = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtQuantidade = new NumericUpDown();
            txtPreco = new TextBox();
            txtMarca = new TextBox();
            txtNome = new TextBox();
            panel1 = new Panel();
            lblPaginas = new Label();
            btnProximo = new Button();
            btnAnterior = new Button();
            painelRodape.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            painelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtQuantidade).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // painelRodape
            // 
            painelRodape.ColumnCount = 1;
            painelRodape.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            painelRodape.Controls.Add(dgvProdutos, 0, 1);
            painelRodape.Controls.Add(painelSuperior, 0, 0);
            painelRodape.Controls.Add(panel1, 0, 2);
            painelRodape.Dock = DockStyle.Fill;
            painelRodape.Location = new Point(0, 0);
            painelRodape.Name = "painelRodape";
            painelRodape.RowCount = 3;
            painelRodape.RowStyles.Add(new RowStyle(SizeType.Absolute, 180F));
            painelRodape.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            painelRodape.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            painelRodape.Size = new Size(678, 629);
            painelRodape.TabIndex = 15;
            // 
            // dgvProdutos
            // 
            dgvProdutos.AllowUserToAddRows = false;
            dgvProdutos.AllowUserToDeleteRows = false;
            dgvProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Dock = DockStyle.Fill;
            dgvProdutos.Location = new Point(15, 198);
            dgvProdutos.Margin = new Padding(15, 18, 15, 18);
            dgvProdutos.MultiSelect = false;
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.ReadOnly = true;
            dgvProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProdutos.Size = new Size(648, 323);
            dgvProdutos.TabIndex = 9;
            dgvProdutos.CellContentDoubleClick += dgvProdutos_CellDoubleClick;
            // 
            // painelSuperior
            // 
            painelSuperior.Anchor = AnchorStyles.Top;
            painelSuperior.Controls.Add(cbxQuantidadeItens);
            painelSuperior.Controls.Add(btnExcluir);
            painelSuperior.Controls.Add(btnAtualizar);
            painelSuperior.Controls.Add(btnCadProduto);
            painelSuperior.Controls.Add(label4);
            painelSuperior.Controls.Add(label3);
            painelSuperior.Controls.Add(label2);
            painelSuperior.Controls.Add(label1);
            painelSuperior.Controls.Add(txtQuantidade);
            painelSuperior.Controls.Add(txtPreco);
            painelSuperior.Controls.Add(txtMarca);
            painelSuperior.Controls.Add(txtNome);
            painelSuperior.Location = new Point(3, 3);
            painelSuperior.Name = "painelSuperior";
            painelSuperior.Size = new Size(672, 174);
            painelSuperior.TabIndex = 0;
            painelSuperior.Click += btnExcluir_Click;
            // 
            // cbxQuantidadeItens
            // 
            cbxQuantidadeItens.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxQuantidadeItens.FormattingEnabled = true;
            cbxQuantidadeItens.Items.AddRange(new object[] { "5", "10", "25", "50", "100" });
            cbxQuantidadeItens.Location = new Point(548, 135);
            cbxQuantidadeItens.Name = "cbxQuantidadeItens";
            cbxQuantidadeItens.Size = new Size(88, 23);
            cbxQuantidadeItens.TabIndex = 26;
            cbxQuantidadeItens.SelectedIndexChanged += cbxQuantidadeItens_SelectedIndexChanged;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = SystemColors.ControlLight;
            btnExcluir.Enabled = false;
            btnExcluir.FlatAppearance.MouseOverBackColor = Color.LightCoral;
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.ForeColor = SystemColors.ControlText;
            btnExcluir.Location = new Point(376, 97);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(80, 27);
            btnExcluir.TabIndex = 25;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.BackColor = Color.RoyalBlue;
            btnAtualizar.Enabled = false;
            btnAtualizar.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            btnAtualizar.FlatStyle = FlatStyle.Flat;
            btnAtualizar.ForeColor = SystemColors.HighlightText;
            btnAtualizar.Location = new Point(462, 97);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(80, 27);
            btnAtualizar.TabIndex = 24;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = false;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnCadProduto
            // 
            btnCadProduto.BackColor = Color.RoyalBlue;
            btnCadProduto.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            btnCadProduto.FlatStyle = FlatStyle.Flat;
            btnCadProduto.ForeColor = SystemColors.ButtonHighlight;
            btnCadProduto.Location = new Point(548, 65);
            btnCadProduto.Name = "btnCadProduto";
            btnCadProduto.Size = new Size(88, 59);
            btnCadProduto.TabIndex = 19;
            btnCadProduto.Text = "Cadastrar Produto";
            btnCadProduto.UseVisualStyleBackColor = false;
            btnCadProduto.Click += btnCadProduto_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(114, 64);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 23;
            label4.Text = "Quantidade";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 65);
            label3.Name = "label3";
            label3.Size = new Size(100, 15);
            label3.TabIndex = 22;
            label3.Text = "Preco do Produto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(379, 17);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 21;
            label2.Text = "Marca do Produto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 17);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 20;
            label1.Text = "Nome do produto";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(114, 83);
            txtQuantidade.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            txtQuantidade.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(120, 23);
            txtQuantidade.TabIndex = 18;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(8, 83);
            txtPreco.Name = "txtPreco";
            txtPreco.PlaceholderText = "R$ 0000";
            txtPreco.Size = new Size(100, 23);
            txtPreco.TabIndex = 17;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(379, 35);
            txtMarca.Name = "txtMarca";
            txtMarca.PlaceholderText = "Marca do produto";
            txtMarca.Size = new Size(257, 23);
            txtMarca.TabIndex = 16;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(5, 35);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome do produto";
            txtNome.Size = new Size(368, 23);
            txtNome.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblPaginas);
            panel1.Controls.Add(btnProximo);
            panel1.Controls.Add(btnAnterior);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 542);
            panel1.Name = "panel1";
            panel1.Size = new Size(672, 84);
            panel1.TabIndex = 10;
            // 
            // lblPaginas
            // 
            lblPaginas.Anchor = AnchorStyles.Top;
            lblPaginas.Location = new Point(114, 15);
            lblPaginas.Name = "lblPaginas";
            lblPaginas.Size = new Size(428, 55);
            lblPaginas.TabIndex = 16;
            lblPaginas.Text = "Pagina 1 de 5";
            lblPaginas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnProximo
            // 
            btnProximo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnProximo.FlatStyle = FlatStyle.Flat;
            btnProximo.Location = new Point(548, 15);
            btnProximo.Name = "btnProximo";
            btnProximo.Size = new Size(95, 55);
            btnProximo.TabIndex = 15;
            btnProximo.Text = "Proximo >";
            btnProximo.UseVisualStyleBackColor = true;
            btnProximo.Click += btnProximo_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.FlatStyle = FlatStyle.Flat;
            btnAnterior.Location = new Point(12, 15);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(95, 55);
            btnAnterior.TabIndex = 14;
            btnAnterior.Text = "< Anterior";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // frmCadastroProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(678, 629);
            Controls.Add(painelRodape);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmCadastroProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Produto";
            Load += frmCadastroProduto_Load;
            painelRodape.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            painelSuperior.ResumeLayout(false);
            painelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtQuantidade).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel painelRodape;
        private Panel painelSuperior;
        private ComboBox cbxQuantidadeItens;
        private Button btnExcluir;
        private Button btnAtualizar;
        private Button btnCadProduto;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown txtQuantidade;
        private TextBox txtPreco;
        private TextBox txtMarca;
        private TextBox txtNome;
        private DataGridView dgvProdutos;
        private Panel panel1;
        private Label lblPaginas;
        private Button btnProximo;
        private Button btnAnterior;
    }
}