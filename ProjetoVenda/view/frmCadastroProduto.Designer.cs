namespace ProjetoVenda.view
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
            txtNome = new TextBox();
            txtMarca = new TextBox();
            txtPreco = new TextBox();
            txtQuantidade = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnCadProduto = new Button();
            dgvProdutos = new DataGridView();
            btnAtualizar = new Button();
            btnExcluir = new Button();
            btnAnterior = new Button();
            btnProximo = new Button();
            lblPaginas = new Label();
            ((System.ComponentModel.ISupportInitialize)txtQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(31, 41);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome do produto";
            txtNome.Size = new Size(257, 23);
            txtNome.TabIndex = 0;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(306, 41);
            txtMarca.Name = "txtMarca";
            txtMarca.PlaceholderText = "Marca do produto";
            txtMarca.Size = new Size(257, 23);
            txtMarca.TabIndex = 1;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(34, 89);
            txtPreco.Name = "txtPreco";
            txtPreco.PlaceholderText = "Preco";
            txtPreco.Size = new Size(100, 23);
            txtPreco.TabIndex = 2;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(171, 90);
            txtQuantidade.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(120, 23);
            txtQuantidade.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 23);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 4;
            label1.Text = "Nome do produto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(306, 23);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 5;
            label2.Text = "Marca";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 71);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 6;
            label3.Text = "Preco";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(171, 71);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 7;
            label4.Text = "Quantidade";
            // 
            // btnCadProduto
            // 
            btnCadProduto.Location = new Point(306, 77);
            btnCadProduto.Name = "btnCadProduto";
            btnCadProduto.Size = new Size(80, 40);
            btnCadProduto.TabIndex = 4;
            btnCadProduto.Text = "Cadastrar";
            btnCadProduto.UseVisualStyleBackColor = true;
            btnCadProduto.Click += btnCadProduto_Click;
            // 
            // dgvProdutos
            // 
            dgvProdutos.AllowUserToAddRows = false;
            dgvProdutos.AllowUserToDeleteRows = false;
            dgvProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Location = new Point(31, 155);
            dgvProdutos.MultiSelect = false;
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.ReadOnly = true;
            dgvProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProdutos.Size = new Size(673, 364);
            dgvProdutos.TabIndex = 8;
            dgvProdutos.CellDoubleClick += dgvProdutos_CellDoubleClick;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Enabled = false;
            btnAtualizar.Location = new Point(582, 31);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(80, 40);
            btnAtualizar.TabIndex = 9;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Enabled = false;
            btnExcluir.Location = new Point(582, 73);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(80, 40);
            btnExcluir.TabIndex = 10;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.Location = new Point(31, 529);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(75, 39);
            btnAnterior.TabIndex = 11;
            btnAnterior.Text = "< Anterior";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnProximo
            // 
            btnProximo.Location = new Point(629, 529);
            btnProximo.Name = "btnProximo";
            btnProximo.Size = new Size(75, 39);
            btnProximo.TabIndex = 12;
            btnProximo.Text = "Proximo >";
            btnProximo.UseVisualStyleBackColor = true;
            btnProximo.Click += btnProximo_Click;
            // 
            // lblPaginas
            // 
            lblPaginas.Location = new Point(112, 529);
            lblPaginas.Name = "lblPaginas";
            lblPaginas.Size = new Size(511, 39);
            lblPaginas.TabIndex = 13;
            lblPaginas.Text = "Pagina 1 de 5";
            lblPaginas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmCadastroProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 588);
            Controls.Add(lblPaginas);
            Controls.Add(btnProximo);
            Controls.Add(btnAnterior);
            Controls.Add(btnExcluir);
            Controls.Add(btnAtualizar);
            Controls.Add(dgvProdutos);
            Controls.Add(btnCadProduto);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtQuantidade);
            Controls.Add(txtPreco);
            Controls.Add(txtMarca);
            Controls.Add(txtNome);
            Name = "frmCadastroProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Produto";
            Load += frmCadastroProduto_Load;
            ((System.ComponentModel.ISupportInitialize)txtQuantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtMarca;
        private TextBox txtPreco;
        private NumericUpDown txtQuantidade;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnCadProduto;
        private DataGridView dgvProdutos;
        private Button btnAtualizar;
        private Button btnExcluir;
        private Button btnAnterior;
        private Button btnProximo;
        private Label lblPaginas;
    }
}