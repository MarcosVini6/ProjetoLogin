namespace ProjetoLogin
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNome = new TextBox();
            lblNomeFuncionario = new Label();
            btnSalvar = new Button();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblCargo = new Label();
            listCargo = new ListBox();
            lblSenha = new Label();
            txtSenha = new TextBox();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(71, 48);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(330, 27);
            txtNome.TabIndex = 0;
            // 
            // lblNomeFuncionario
            // 
            lblNomeFuncionario.AutoSize = true;
            lblNomeFuncionario.Location = new Point(12, 48);
            lblNomeFuncionario.Name = "lblNomeFuncionario";
            lblNomeFuncionario.Size = new Size(53, 20);
            lblNomeFuncionario.TabIndex = 1;
            lblNomeFuncionario.Text = "Nome:";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(307, 354);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 29);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(16, 104);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(71, 101);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(330, 27);
            txtEmail.TabIndex = 4;
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Location = new Point(13, 228);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(52, 20);
            lblCargo.TabIndex = 5;
            lblCargo.Text = "Cargo:";
            // 
            // listCargo
            // 
            listCargo.FormattingEnabled = true;
            listCargo.ItemHeight = 20;
            listCargo.Location = new Point(71, 228);
            listCargo.Name = "listCargo";
            listCargo.Size = new Size(150, 104);
            listCargo.TabIndex = 6;
            listCargo.SelectedIndexChanged += listCargo_SelectedIndexChanged;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(16, 168);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(52, 20);
            lblSenha.TabIndex = 7;
            lblSenha.Text = "Senha:";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(77, 171);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(125, 27);
            txtSenha.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSenha);
            Controls.Add(lblSenha);
            Controls.Add(listCargo);
            Controls.Add(lblCargo);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(btnSalvar);
            Controls.Add(lblNomeFuncionario);
            Controls.Add(txtNome);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private Label lblNomeFuncionario;
        private Button btnSalvar;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblCargo;
        private ListBox listCargo;
        private Label lblSenha;
        private TextBox txtSenha;
    }
}