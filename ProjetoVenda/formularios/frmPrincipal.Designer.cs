namespace ProjetoVenda.formularios
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            lblUsername = new Label();
            btnCadFuncionario = new Button();
            btnCadProduto = new Button();
            panel2 = new Panel();
            btnCadVenda = new Button();
            btnPerfil = new Button();
            btnSair = new Button();
            panel1 = new Panel();
            lblTitulo = new Label();
            painelPrincipal = new Panel();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(16, 13);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(97, 15);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "nome do usuário";
            // 
            // btnCadFuncionario
            // 
            btnCadFuncionario.BackColor = SystemColors.Menu;
            btnCadFuncionario.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            btnCadFuncionario.FlatStyle = FlatStyle.Flat;
            btnCadFuncionario.Image = Properties.Resources.icons8_human_resources_64;
            btnCadFuncionario.Location = new Point(16, 538);
            btnCadFuncionario.Name = "btnCadFuncionario";
            btnCadFuncionario.Size = new Size(136, 87);
            btnCadFuncionario.TabIndex = 1;
            btnCadFuncionario.Text = "Cadastrar Funcionário";
            btnCadFuncionario.TextImageRelation = TextImageRelation.TextAboveImage;
            btnCadFuncionario.UseVisualStyleBackColor = false;
            btnCadFuncionario.Click += btnCadFuncionario_Click;
            // 
            // btnCadProduto
            // 
            btnCadProduto.BackColor = SystemColors.Menu;
            btnCadProduto.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            btnCadProduto.FlatStyle = FlatStyle.Flat;
            btnCadProduto.Image = Properties.Resources.product_management___Copia;
            btnCadProduto.ImageAlign = ContentAlignment.TopCenter;
            btnCadProduto.Location = new Point(11, 56);
            btnCadProduto.Name = "btnCadProduto";
            btnCadProduto.Size = new Size(141, 88);
            btnCadProduto.TabIndex = 2;
            btnCadProduto.Text = "Cadastrar Produto";
            btnCadProduto.TextAlign = ContentAlignment.BottomCenter;
            btnCadProduto.TextImageRelation = TextImageRelation.TextAboveImage;
            btnCadProduto.UseVisualStyleBackColor = false;
            btnCadProduto.Click += btnCadProduto_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.MenuHighlight;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnCadVenda);
            panel2.Controls.Add(btnPerfil);
            panel2.Controls.Add(btnSair);
            panel2.Controls.Add(btnCadProduto);
            panel2.Controls.Add(btnCadFuncionario);
            panel2.Controls.Add(lblUsername);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(165, 829);
            panel2.TabIndex = 4;
            // 
            // btnCadVenda
            // 
            btnCadVenda.BackColor = SystemColors.Menu;
            btnCadVenda.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            btnCadVenda.FlatStyle = FlatStyle.Flat;
            btnCadVenda.Image = Properties.Resources.icons8_shopping_cart_64;
            btnCadVenda.ImageAlign = ContentAlignment.BottomCenter;
            btnCadVenda.Location = new Point(11, 150);
            btnCadVenda.Name = "btnCadVenda";
            btnCadVenda.Size = new Size(141, 88);
            btnCadVenda.TabIndex = 5;
            btnCadVenda.Text = "Cadastrar Venda";
            btnCadVenda.TextAlign = ContentAlignment.TopCenter;
            btnCadVenda.UseVisualStyleBackColor = false;
            btnCadVenda.Click += btnCadVenda_Click;
            // 
            // btnPerfil
            // 
            btnPerfil.BackColor = SystemColors.Menu;
            btnPerfil.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            btnPerfil.FlatStyle = FlatStyle.Flat;
            btnPerfil.Image = Properties.Resources.icons8_profile_64;
            btnPerfil.Location = new Point(16, 631);
            btnPerfil.Name = "btnPerfil";
            btnPerfil.Size = new Size(136, 87);
            btnPerfil.TabIndex = 4;
            btnPerfil.Text = "Perfil";
            btnPerfil.TextImageRelation = TextImageRelation.TextAboveImage;
            btnPerfil.UseVisualStyleBackColor = false;
            btnPerfil.Click += btnPerfil_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = SystemColors.ControlLightLight;
            btnSair.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.ForeColor = SystemColors.ControlText;
            btnSair.Image = Properties.Resources.icons8_logout_64;
            btnSair.Location = new Point(16, 724);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(136, 85);
            btnSair.TabIndex = 3;
            btnSair.Text = "Sair";
            btnSair.TextImageRelation = TextImageRelation.TextAboveImage;
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblTitulo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(165, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(843, 60);
            panel1.TabIndex = 5;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(843, 60);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Título da Tela";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // painelPrincipal
            // 
            painelPrincipal.Dock = DockStyle.Fill;
            painelPrincipal.Location = new Point(165, 60);
            painelPrincipal.Name = "painelPrincipal";
            painelPrincipal.Size = new Size(843, 769);
            painelPrincipal.TabIndex = 6;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 829);
            Controls.Add(painelPrincipal);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1024, 868);
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Inicial";
            Load += frmPrincipal_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblUsername;
        private Button btnCadFuncionario;
        private Button btnCadProduto;
        private Panel panel2;
        private Panel panel1;
        private Panel painelPrincipal;
        private Button btnSair;
        private Button btnPerfil;
        private Button btnCadVenda;
        private Label lblTitulo;
    }
}