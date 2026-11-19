namespace ProjetoVenda.formularios
{
    partial class frmCadastroVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroVenda));
            tableLayoutPanel1 = new TableLayoutPanel();
            dgvCarrinho = new DataGridView();
            painelRodape = new Panel();
            lblPrecoTotal = new Label();
            btnCadastrar = new Button();
            painelSuperior = new Panel();
            btnAdicionar = new Button();
            numQuantidade = new NumericUpDown();
            lblQuantidade = new Label();
            label2 = new Label();
            label1 = new Label();
            lblPreco = new Label();
            cbxProdutos = new ComboBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarrinho).BeginInit();
            painelRodape.SuspendLayout();
            painelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantidade).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(dgvCarrinho, 0, 1);
            tableLayoutPanel1.Controls.Add(painelRodape, 0, 2);
            tableLayoutPanel1.Controls.Add(painelSuperior, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 180F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            tableLayoutPanel1.Size = new Size(610, 644);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // dgvCarrinho
            // 
            dgvCarrinho.AllowUserToAddRows = false;
            dgvCarrinho.AllowUserToDeleteRows = false;
            dgvCarrinho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCarrinho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrinho.Dock = DockStyle.Fill;
            dgvCarrinho.Location = new Point(15, 198);
            dgvCarrinho.Margin = new Padding(15, 18, 15, 18);
            dgvCarrinho.MultiSelect = false;
            dgvCarrinho.Name = "dgvCarrinho";
            dgvCarrinho.ReadOnly = true;
            dgvCarrinho.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarrinho.Size = new Size(580, 278);
            dgvCarrinho.TabIndex = 6;
            dgvCarrinho.CellContentDoubleClick += dgvCarrinho_CellContentClick;
            // 
            // painelRodape
            // 
            painelRodape.Controls.Add(lblPrecoTotal);
            painelRodape.Controls.Add(btnCadastrar);
            painelRodape.Dock = DockStyle.Fill;
            painelRodape.Location = new Point(3, 497);
            painelRodape.Name = "painelRodape";
            painelRodape.Size = new Size(604, 144);
            painelRodape.TabIndex = 1;
            // 
            // lblPrecoTotal
            // 
            lblPrecoTotal.Anchor = AnchorStyles.Top;
            lblPrecoTotal.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrecoTotal.Location = new Point(19, 23);
            lblPrecoTotal.Name = "lblPrecoTotal";
            lblPrecoTotal.Size = new Size(566, 39);
            lblPrecoTotal.TabIndex = 9;
            lblPrecoTotal.Text = "Total da venda: R$ XX.XX";
            lblPrecoTotal.TextAlign = ContentAlignment.TopRight;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Anchor = AnchorStyles.Top;
            btnCadastrar.BackColor = Color.RoyalBlue;
            btnCadastrar.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.ForeColor = SystemColors.ButtonHighlight;
            btnCadastrar.Location = new Point(261, 77);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(105, 45);
            btnCadastrar.TabIndex = 8;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // painelSuperior
            // 
            painelSuperior.Anchor = AnchorStyles.Top;
            painelSuperior.Controls.Add(btnAdicionar);
            painelSuperior.Controls.Add(numQuantidade);
            painelSuperior.Controls.Add(lblQuantidade);
            painelSuperior.Controls.Add(label2);
            painelSuperior.Controls.Add(label1);
            painelSuperior.Controls.Add(lblPreco);
            painelSuperior.Controls.Add(cbxProdutos);
            painelSuperior.Location = new Point(3, 3);
            painelSuperior.Name = "painelSuperior";
            painelSuperior.Size = new Size(604, 174);
            painelSuperior.TabIndex = 0;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.RoyalBlue;
            btnAdicionar.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            btnAdicionar.FlatStyle = FlatStyle.Flat;
            btnAdicionar.ForeColor = SystemColors.ButtonHighlight;
            btnAdicionar.Location = new Point(472, 117);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(120, 42);
            btnAdicionar.TabIndex = 11;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // numQuantidade
            // 
            numQuantidade.Location = new Point(472, 79);
            numQuantidade.Name = "numQuantidade";
            numQuantidade.Size = new Size(120, 23);
            numQuantidade.TabIndex = 10;
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(15, 104);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(140, 15);
            lblQuantidade.TabIndex = 9;
            lblQuantidade.Text = "Quantidade Disponível: X";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(472, 61);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 6;
            label2.Text = "Quantidade";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 16);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 7;
            label1.Text = "Produto";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(15, 71);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(135, 15);
            lblPreco.TabIndex = 8;
            lblPreco.Text = "Preço Unitário: R$ XX,XX";
            // 
            // cbxProdutos
            // 
            cbxProdutos.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxProdutos.FormattingEnabled = true;
            cbxProdutos.Location = new Point(15, 34);
            cbxProdutos.Name = "cbxProdutos";
            cbxProdutos.Size = new Size(577, 23);
            cbxProdutos.TabIndex = 5;
            cbxProdutos.SelectedIndexChanged += cbxProdutos_SelectedIndexChanged;
            // 
            // frmCadastroVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 644);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmCadastroVenda";
            Text = "Cadastro Venda";
            Load += frmCadastroVenda_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCarrinho).EndInit();
            painelRodape.ResumeLayout(false);
            painelSuperior.ResumeLayout(false);
            painelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantidade).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvCarrinho;
        private Panel painelSuperior;
        private Button btnAdicionar;
        private NumericUpDown numQuantidade;
        private Label lblQuantidade;
        private Label label2;
        private Label label1;
        private Label lblPreco;
        private ComboBox cbxProdutos;
        private Panel painelRodape;
        private Label lblPrecoTotal;
        private Button btnCadastrar;
    }
}