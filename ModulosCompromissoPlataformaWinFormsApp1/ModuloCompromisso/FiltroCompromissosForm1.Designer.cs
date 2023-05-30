namespace ModulosCompromissoPlataformaWinFormsApp1.ModuloCompromisso
{
    partial class FiltroCompromissosForm1
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
            bpnFiltrar = new Button();
            bpnCancelar = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // bpnFiltrar
            // 
            bpnFiltrar.DialogResult = DialogResult.OK;
            bpnFiltrar.Location = new Point(241, 279);
            bpnFiltrar.Name = "bpnFiltrar";
            bpnFiltrar.Size = new Size(75, 39);
            bpnFiltrar.TabIndex = 0;
            bpnFiltrar.Text = "Filtrar";
            bpnFiltrar.UseVisualStyleBackColor = true;
            // 
            // bpnCancelar
            // 
            bpnCancelar.DialogResult = DialogResult.Cancel;
            bpnCancelar.Location = new Point(335, 279);
            bpnCancelar.Name = "bpnCancelar";
            bpnCancelar.Size = new Size(75, 39);
            bpnCancelar.TabIndex = 1;
            bpnCancelar.Text = "Cancelar";
            bpnCancelar.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(62, 48);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(211, 19);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "Visualizar Todos  os COmpromissos";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(62, 100);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(203, 19);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "Visualizar Compromissos Passado";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(62, 154);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(200, 19);
            radioButton3.TabIndex = 4;
            radioButton3.TabStop = true;
            radioButton3.Text = "Visualizar Compromissos Futuros";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(62, 198);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(62, 227);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 207);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 7;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 235);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 8;
            label2.Text = "label2";
            // 
            // FiltroCompromissosForm1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 330);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(bpnCancelar);
            Controls.Add(bpnFiltrar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FiltroCompromissosForm1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Filtro de Compromissos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bpnFiltrar;
        private Button bpnCancelar;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label1;
        private Label label2;
    }
}