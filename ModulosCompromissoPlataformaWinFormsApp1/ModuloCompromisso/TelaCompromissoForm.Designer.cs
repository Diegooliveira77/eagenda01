namespace ModulosCompromissoPlataformaWinFormsApp1.ModuloCompromisso
{
    partial class TelaCompromissoForm
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
            txtId = new TextBox();
            txtAssunto = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtData = new DateTimePicker();
            txtHorarioInicio = new DateTimePicker();
            label4 = new Label();
            txtHorarioFinal = new DateTimePicker();
            label5 = new Label();
            cmbContaos = new ComboBox();
            label6 = new Label();
            rdbPresencial = new RadioButton();
            rdbOline = new RadioButton();
            bpnCancelar = new Button();
            panel1 = new Panel();
            txtOnline = new TextBox();
            label7 = new Label();
            txtPrencial = new TextBox();
            label8 = new Label();
            bpnGravar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 0;
            label1.Text = "Id:";
            // 
            // txtId
            // 
            txtId.Location = new Point(74, 19);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 1;
            txtId.Text = "0";
            // 
            // txtAssunto
            // 
            txtAssunto.Location = new Point(74, 54);
            txtAssunto.Name = "txtAssunto";
            txtAssunto.Size = new Size(443, 23);
            txtAssunto.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 57);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 2;
            label2.Text = "Assunto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 91);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 4;
            label3.Text = "Data :";
            // 
            // txtData
            // 
            txtData.Format = DateTimePickerFormat.Short;
            txtData.Location = new Point(74, 85);
            txtData.Name = "txtData";
            txtData.Size = new Size(121, 23);
            txtData.TabIndex = 5;
            // 
            // txtHorarioInicio
            // 
            txtHorarioInicio.Format = DateTimePickerFormat.Time;
            txtHorarioInicio.Location = new Point(74, 122);
            txtHorarioInicio.Name = "txtHorarioInicio";
            txtHorarioInicio.Size = new Size(121, 23);
            txtHorarioInicio.TabIndex = 7;
            // 
            // label4
            // 
            label4.Location = new Point(12, 115);
            label4.Name = "label4";
            label4.Size = new Size(56, 40);
            label4.TabIndex = 6;
            label4.Text = "horario Inicio:";
            // 
            // txtHorarioFinal
            // 
            txtHorarioFinal.Format = DateTimePickerFormat.Time;
            txtHorarioFinal.Location = new Point(313, 122);
            txtHorarioFinal.Name = "txtHorarioFinal";
            txtHorarioFinal.Size = new Size(121, 23);
            txtHorarioFinal.TabIndex = 9;
            // 
            // label5
            // 
            label5.Location = new Point(214, 115);
            label5.Name = "label5";
            label5.Size = new Size(72, 40);
            label5.TabIndex = 8;
            label5.Text = "horario Final:";
            // 
            // cmbContaos
            // 
            cmbContaos.FormattingEnabled = true;
            cmbContaos.Location = new Point(74, 158);
            cmbContaos.Name = "cmbContaos";
            cmbContaos.Size = new Size(121, 23);
            cmbContaos.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 166);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 11;
            label6.Text = "Contatos";
            // 
            // rdbPresencial
            // 
            rdbPresencial.AutoSize = true;
            rdbPresencial.Location = new Point(80, 28);
            rdbPresencial.Name = "rdbPresencial";
            rdbPresencial.Size = new Size(78, 19);
            rdbPresencial.TabIndex = 12;
            rdbPresencial.TabStop = true;
            rdbPresencial.Text = "Presencial";
            rdbPresencial.UseVisualStyleBackColor = true;
            rdbPresencial.CheckedChanged += rdbPresencial_CheckedChanged;
            // 
            // rdbOline
            // 
            rdbOline.AutoSize = true;
            rdbOline.Location = new Point(180, 30);
            rdbOline.Name = "rdbOline";
            rdbOline.Size = new Size(60, 19);
            rdbOline.TabIndex = 14;
            rdbOline.TabStop = true;
            rdbOline.Text = "Online";
            rdbOline.UseVisualStyleBackColor = true;
            // 
            // bpnCancelar
            // 
            bpnCancelar.DialogResult = DialogResult.Cancel;
            bpnCancelar.Location = new Point(445, 379);
            bpnCancelar.Name = "bpnCancelar";
            bpnCancelar.Size = new Size(75, 35);
            bpnCancelar.TabIndex = 18;
            bpnCancelar.Text = "Cancelar";
            bpnCancelar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtOnline);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtPrencial);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(rdbOline);
            panel1.Controls.Add(rdbPresencial);
            panel1.Location = new Point(74, 207);
            panel1.Name = "panel1";
            panel1.Size = new Size(394, 144);
            panel1.TabIndex = 21;
            // 
            // txtOnline
            // 
            txtOnline.Location = new Point(80, 107);
            txtOnline.Name = "txtOnline";
            txtOnline.Size = new Size(280, 23);
            txtOnline.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 72);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 22;
            label7.Text = "Online";
            // 
            // txtPrencial
            // 
            txtPrencial.Location = new Point(80, 64);
            txtPrencial.Name = "txtPrencial";
            txtPrencial.Size = new Size(280, 23);
            txtPrencial.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 115);
            label8.Name = "label8";
            label8.Size = new Size(65, 15);
            label8.TabIndex = 24;
            label8.Text = "Pressencial";
            // 
            // bpnGravar
            // 
            bpnGravar.DialogResult = DialogResult.OK;
            bpnGravar.Location = new Point(348, 379);
            bpnGravar.Name = "bpnGravar";
            bpnGravar.Size = new Size(75, 35);
            bpnGravar.TabIndex = 22;
            bpnGravar.Text = "Gravar";
            bpnGravar.UseVisualStyleBackColor = true;
            bpnGravar.Click += bpnGravar_Click;
            // 
            // TelaCompromissoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 436);
            Controls.Add(bpnGravar);
            Controls.Add(panel1);
            Controls.Add(bpnCancelar);
            Controls.Add(label6);
            Controls.Add(cmbContaos);
            Controls.Add(txtHorarioFinal);
            Controls.Add(label5);
            Controls.Add(txtHorarioInicio);
            Controls.Add(label4);
            Controls.Add(txtData);
            Controls.Add(label3);
            Controls.Add(txtAssunto);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            MinimizeBox = false;
            Name = "TelaCompromissoForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Compromissos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtId;
        private TextBox txtAssunto;
        private Label label2;
        private Label label3;
        private DateTimePicker txtData;
        private DateTimePicker txtHorarioInicio;
        private Label label4;
        private DateTimePicker txtHorarioFinal;
        private Label label5;
        private ComboBox cmbContaos;
        private Label label6;
        private RadioButton rdbPresencial;
        private RadioButton rdbOline;
        private Button button1;
        private Button bpnCancelar;
        private Panel panel1;
        private TextBox txtOnline;
        private Label label7;
        private TextBox txtPrencial;
        private Label label8;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button bpnGravar;
    }
}