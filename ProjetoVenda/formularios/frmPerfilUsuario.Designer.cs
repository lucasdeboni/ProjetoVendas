namespace ProjetoVenda.formularios
{
    partial class frmPerfilUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPerfilUsuario));
            label4 = new Label();
            label2 = new Label();
            txtConfirmacaoSenha = new TextBox();
            btnAtualizar = new Button();
            txtCep = new TextBox();
            txtComplemento = new TextBox();
            txtNumero = new TextBox();
            txtRua = new TextBox();
            txtTelefone = new TextBox();
            txtSenha = new TextBox();
            txtUsuario = new TextBox();
            txtNome = new TextBox();
            btnExcluir = new Button();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label5 = new Label();
            label6 = new Label();
            label3 = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 19);
            label4.Name = "label4";
            label4.Size = new Size(96, 15);
            label4.TabIndex = 27;
            label4.Text = "Nome Completo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 68);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 25;
            label2.Text = "Contato";
            // 
            // txtConfirmacaoSenha
            // 
            txtConfirmacaoSenha.Location = new Point(150, 51);
            txtConfirmacaoSenha.Name = "txtConfirmacaoSenha";
            txtConfirmacaoSenha.PasswordChar = '*';
            txtConfirmacaoSenha.PlaceholderText = "Confirmação Senha";
            txtConfirmacaoSenha.Size = new Size(138, 23);
            txtConfirmacaoSenha.TabIndex = 22;
            txtConfirmacaoSenha.Visible = false;
            // 
            // btnAtualizar
            // 
            btnAtualizar.BackColor = Color.RoyalBlue;
            btnAtualizar.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            btnAtualizar.FlatStyle = FlatStyle.Flat;
            btnAtualizar.ForeColor = SystemColors.ButtonHighlight;
            btnAtualizar.Location = new Point(28, 406);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(75, 36);
            btnAtualizar.TabIndex = 23;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = false;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(6, 37);
            txtCep.Name = "txtCep";
            txtCep.PlaceholderText = "CEP";
            txtCep.Size = new Size(100, 23);
            txtCep.TabIndex = 16;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(6, 85);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.PlaceholderText = "Complemento";
            txtComplemento.Size = new Size(225, 23);
            txtComplemento.TabIndex = 19;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(343, 37);
            txtNumero.Name = "txtNumero";
            txtNumero.PlaceholderText = "Numero";
            txtNumero.Size = new Size(73, 23);
            txtNumero.TabIndex = 18;
            // 
            // txtRua
            // 
            txtRua.Location = new Point(112, 37);
            txtRua.Name = "txtRua";
            txtRua.PlaceholderText = "Rua";
            txtRua.Size = new Size(225, 23);
            txtRua.TabIndex = 17;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(6, 86);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.PlaceholderText = "Telefone";
            txtTelefone.Size = new Size(120, 23);
            txtTelefone.TabIndex = 15;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(6, 51);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.PlaceholderText = "Senha";
            txtSenha.Size = new Size(138, 23);
            txtSenha.TabIndex = 21;
            txtSenha.Visible = false;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(6, 22);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuário";
            txtUsuario.Size = new Size(138, 23);
            txtUsuario.TabIndex = 20;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(6, 37);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome";
            txtNome.Size = new Size(275, 23);
            txtNome.TabIndex = 14;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Tomato;
            btnExcluir.FlatAppearance.MouseOverBackColor = Color.LightCoral;
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.ForeColor = SystemColors.ButtonHighlight;
            btnExcluir.Location = new Point(412, 406);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 36);
            btnExcluir.TabIndex = 28;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user_icon;
            pictureBox1.Location = new Point(28, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(154, 154);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(txtTelefone);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(188, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(299, 120);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "Funcionário";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtCep);
            groupBox2.Controls.Add(txtRua);
            groupBox2.Controls.Add(txtNumero);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txtComplemento);
            groupBox2.Location = new Point(28, 183);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(459, 126);
            groupBox2.TabIndex = 31;
            groupBox2.TabStop = false;
            groupBox2.Text = "Endereço";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(343, 19);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 25;
            label5.Text = "Número";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 67);
            label6.Name = "label6";
            label6.Size = new Size(84, 15);
            label6.TabIndex = 25;
            label6.Text = "Complemento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(112, 19);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 25;
            label3.Text = "Rua";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 25;
            label1.Text = "CEP";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtUsuario);
            groupBox3.Controls.Add(txtSenha);
            groupBox3.Controls.Add(txtConfirmacaoSenha);
            groupBox3.Location = new Point(28, 318);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(459, 82);
            groupBox3.TabIndex = 32;
            groupBox3.TabStop = false;
            groupBox3.Text = "Sistema";
            // 
            // frmPerfilUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 511);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(btnExcluir);
            Controls.Add(btnAtualizar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmPerfilUsuario";
            Text = "Perfil Usuario";
            Load += frmPerfilUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label4;
        private Label label2;
        private TextBox txtConfirmacaoSenha;
        private Button btnAtualizar;
        private TextBox txtCep;
        private TextBox txtComplemento;
        private TextBox txtNumero;
        private TextBox txtRua;
        private TextBox txtTelefone;
        private TextBox txtSenha;
        private TextBox txtUsuario;
        private TextBox txtNome;
        private Button btnExcluir;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label5;
        private Label label6;
        private Label label3;
        private Label label1;
    }
}