namespace ModulosCompromissoPlataformaWinFormsApp1
{
    partial class TelaPrincipalForm1
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
            menuStrip1 = new MenuStrip();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            contatosMenuItem = new ToolStripMenuItem();
            compromissosMenuItem = new ToolStripMenuItem();
            tarefasMenuItem = new ToolStripMenuItem();
            despesasToolStripMenuItem = new ToolStripMenuItem();
            despesasMenuItem1 = new ToolStripMenuItem();
            categoriasMenuItem = new ToolStripMenuItem();
            relatoriosToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            labelRodaPe = new ToolStripStatusLabel();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            bpnInserir = new ToolStripButton();
            bpnEditar = new ToolStripButton();
            bpnExcluir = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            lblTipoCadastro = new ToolStripLabel();
            panelRegistro = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            menuStrip2 = new MenuStrip();
            toolStripSeparator2 = new ToolStripSeparator();
            bpnFiltrar = new ToolStripButton();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            panelRegistro.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem, relatoriosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(145, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { contatosMenuItem, compromissosMenuItem, tarefasMenuItem, despesasToolStripMenuItem });
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(66, 20);
            cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // contatosMenuItem
            // 
            contatosMenuItem.Name = "contatosMenuItem";
            contatosMenuItem.Size = new Size(154, 22);
            contatosMenuItem.Text = "Contatos";
            contatosMenuItem.Click += contatosMenuItem_Click;
            // 
            // compromissosMenuItem
            // 
            compromissosMenuItem.Name = "compromissosMenuItem";
            compromissosMenuItem.Size = new Size(154, 22);
            compromissosMenuItem.Text = "Compromissos";
            compromissosMenuItem.Click += compromissosMenuItem_Click;
            // 
            // tarefasMenuItem
            // 
            tarefasMenuItem.Name = "tarefasMenuItem";
            tarefasMenuItem.Size = new Size(154, 22);
            tarefasMenuItem.Text = "Tarefas";
            tarefasMenuItem.Click += tarefasMenuItem_Click;
            // 
            // despesasToolStripMenuItem
            // 
            despesasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { despesasMenuItem1, categoriasMenuItem });
            despesasToolStripMenuItem.Name = "despesasToolStripMenuItem";
            despesasToolStripMenuItem.Size = new Size(154, 22);
            despesasToolStripMenuItem.Text = "Despesas";
            // 
            // despesasMenuItem1
            // 
            despesasMenuItem1.Name = "despesasMenuItem1";
            despesasMenuItem1.Size = new Size(130, 22);
            despesasMenuItem1.Text = "Despesas";
            // 
            // categoriasMenuItem
            // 
            categoriasMenuItem.Name = "categoriasMenuItem";
            categoriasMenuItem.Size = new Size(130, 22);
            categoriasMenuItem.Text = "Categorias";
            // 
            // relatoriosToolStripMenuItem
            // 
            relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            relatoriosToolStripMenuItem.Size = new Size(71, 20);
            relatoriosToolStripMenuItem.Text = "Relatorios";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { labelRodaPe, toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(799, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // labelRodaPe
            // 
            labelRodaPe.Name = "labelRodaPe";
            labelRodaPe.Size = new Size(44, 17);
            labelRodaPe.Text = "rodape";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(32, 17);
            toolStripStatusLabel1.Text = "teste";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { bpnInserir, bpnEditar, bpnExcluir, toolStripSeparator1, bpnFiltrar, toolStripSeparator2, lblTipoCadastro });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(799, 45);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // bpnInserir
            // 
            bpnInserir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            bpnInserir.Image = Properties.Resources.add;
            bpnInserir.ImageScaling = ToolStripItemImageScaling.None;
            bpnInserir.ImageTransparentColor = Color.Magenta;
            bpnInserir.Name = "bpnInserir";
            bpnInserir.Padding = new Padding(7);
            bpnInserir.Size = new Size(42, 42);
            bpnInserir.Text = "Inserir";
            bpnInserir.Click += bpnInserir_Click;
            // 
            // bpnEditar
            // 
            bpnEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            bpnEditar.Image = Properties.Resources.edit;
            bpnEditar.ImageScaling = ToolStripItemImageScaling.None;
            bpnEditar.ImageTransparentColor = Color.Magenta;
            bpnEditar.Name = "bpnEditar";
            bpnEditar.Padding = new Padding(7);
            bpnEditar.Size = new Size(42, 42);
            bpnEditar.Text = "toolStripButton2";
            bpnEditar.ToolTipText = "Editar";
            bpnEditar.Click += bpnEditar_Click;
            // 
            // bpnExcluir
            // 
            bpnExcluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            bpnExcluir.Image = Properties.Resources.delete;
            bpnExcluir.ImageScaling = ToolStripItemImageScaling.None;
            bpnExcluir.ImageTransparentColor = Color.Magenta;
            bpnExcluir.Name = "bpnExcluir";
            bpnExcluir.Padding = new Padding(7);
            bpnExcluir.Size = new Size(42, 42);
            bpnExcluir.Text = "toolStripButton3";
            bpnExcluir.ToolTipText = "Excluir";
            bpnExcluir.Click += bpnExcluir_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 45);
            // 
            // lblTipoCadastro
            // 
            lblTipoCadastro.Name = "lblTipoCadastro";
            lblTipoCadastro.Size = new Size(75, 42);
            lblTipoCadastro.Text = "tipoCadastro";
            // 
            // panelRegistro
            // 
            panelRegistro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelRegistro.BorderStyle = BorderStyle.FixedSingle;
            panelRegistro.Controls.Add(flowLayoutPanel1);
            panelRegistro.Location = new Point(10, 62);
            panelRegistro.Name = "panelRegistro";
            panelRegistro.Size = new Size(776, 363);
            panelRegistro.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(569, 179);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(200, 100);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // menuStrip2
            // 
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(799, 24);
            menuStrip2.TabIndex = 4;
            menuStrip2.Text = "menuStrip2";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 45);
            // 
            // bpnFiltrar
            // 
            bpnFiltrar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            bpnFiltrar.Image = Properties.Resources.delete;
            bpnFiltrar.ImageScaling = ToolStripItemImageScaling.None;
            bpnFiltrar.ImageTransparentColor = Color.Magenta;
            bpnFiltrar.Name = "bpnFiltrar";
            bpnFiltrar.Padding = new Padding(7);
            bpnFiltrar.Size = new Size(42, 42);
            bpnFiltrar.Text = "toolStripButton3";
            bpnFiltrar.ToolTipText = "Excluir";
            bpnFiltrar.Click += bpnFiltrar_Click;
            // 
            // TelaPrincipalForm1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 450);
            Controls.Add(panelRegistro);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip1;
            Name = "TelaPrincipalForm1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "eAgenda1.0";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panelRegistro.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem contatosMenuItem;
        private ToolStripMenuItem compromissosMenuItem;
        private ToolStripMenuItem tarefasMenuItem;
        private ToolStripMenuItem despesasToolStripMenuItem;
        private ToolStripMenuItem relatoriosToolStripMenuItem;
        private ToolStripMenuItem despesasMenuItem1;
        private ToolStripMenuItem categoriasMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel labelRodaPe;
        private ToolStrip toolStrip1;
        private ToolStripButton bpnInserir;
        private ToolStripButton bpnEditar;
        private ToolStripButton bpnExcluir;
        private Panel panelRegistro;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel lblTipoCadastro;
        private MenuStrip menuStrip2;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private ToolStripButton bpnFiltrar;
        private ToolStripSeparator toolStripSeparator2;
    }
}