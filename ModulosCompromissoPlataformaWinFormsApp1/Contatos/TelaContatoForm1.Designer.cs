namespace ModulosCompromissoPlataformaWinFormsApp1.Contatos
{
    partial class TelaContatoForm1
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
            label1 = new Label();
            bpnCancelar = new Button();
            bpnGravar = new Button();
            label2 = new Label();
            txtId = new TextBox();
            txtNome = new TextBox();
            label3 = new Label();
            txtTelefone = new TextBox();
            txtCargo = new TextBox();
            txtEmail = new TextBox();
            txtEmpresa = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(80, 60);
            label1.Name = "label1";
            label1.Size = new Size(0, 37);
            label1.TabIndex = 0;
            // 
            // bpnCancelar
            // 
            bpnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bpnCancelar.DialogResult = DialogResult.Cancel;
            bpnCancelar.Location = new Point(432, 143);
            bpnCancelar.Name = "bpnCancelar";
            bpnCancelar.Size = new Size(75, 36);
            bpnCancelar.TabIndex = 1;
            bpnCancelar.Text = "Cancelar";
            bpnCancelar.UseVisualStyleBackColor = true;
            // 
            // bpnGravar
            // 
            bpnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bpnGravar.DialogResult = DialogResult.OK;
            bpnGravar.Location = new Point(340, 143);
            bpnGravar.Name = "bpnGravar";
            bpnGravar.Size = new Size(75, 36);
            bpnGravar.TabIndex = 2;
            bpnGravar.Text = "Gravar";
            bpnGravar.UseVisualStyleBackColor = true;
            bpnGravar.Click += bpnGravar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 3;
            label2.Text = "Id";
            // 
            // txtId
            // 
            txtId.Location = new Point(80, 6);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 4;
            txtId.Text = "0";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(80, 40);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(419, 23);
            txtNome.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 41);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 6;
            label3.Text = "Nome";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(80, 74);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(141, 23);
            txtTelefone.TabIndex = 7;
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(80, 103);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(141, 23);
            txtCargo.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(358, 75);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(141, 23);
            txtEmail.TabIndex = 9;
            // 
            // txtEmpresa
            // 
            txtEmpresa.Location = new Point(358, 108);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new Size(141, 23);
            txtEmpresa.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(297, 116);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 11;
            label4.Text = "Empresa";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(297, 83);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 12;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 111);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 13;
            label6.Text = "Cargo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 83);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 14;
            label7.Text = "Telefone";
            // 
            // TelaContatoForm1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 201);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtEmpresa);
            Controls.Add(txtEmail);
            Controls.Add(txtCargo);
            Controls.Add(txtTelefone);
            Controls.Add(label3);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(bpnGravar);
            Controls.Add(bpnCancelar);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaContatoForm1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro De Contato";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button bpnCancelar;
        private Button bpnGravar;
        private Label label2;
        private TextBox txtId;
        private TextBox txtNome;
        private Label label3;
        private TextBox txtTelefone;
        private TextBox txtCargo;
        private TextBox txtEmail;
        private TextBox txtEmpresa;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}