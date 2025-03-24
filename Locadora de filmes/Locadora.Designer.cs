namespace Locadora_de_filmes
{
    partial class Locadora
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
            this.components = new System.ComponentModel.Container();
            this.locBase = new System.Windows.Forms.DataGridView();
            this.locCarregarDados = new System.Windows.Forms.MenuStrip();
            this.locNovoFilme = new System.Windows.Forms.ToolStripMenuItem();
            this.locSalvarDados = new System.Windows.Forms.ToolStripMenuItem();
            this.carregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locSair = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.locBase)).BeginInit();
            this.locCarregarDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // locBase
            // 
            this.locBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.locBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.locBase.Location = new System.Drawing.Point(0, 28);
            this.locBase.Name = "locBase";
            this.locBase.RowHeadersWidth = 51;
            this.locBase.Size = new System.Drawing.Size(800, 582);
            this.locBase.TabIndex = 0;
            // 
            // locCarregarDados
            // 
            this.locCarregarDados.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.locCarregarDados.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.locNovoFilme,
            this.locSalvarDados,
            this.carregarToolStripMenuItem,
            this.locSair});
            this.locCarregarDados.Location = new System.Drawing.Point(0, 0);
            this.locCarregarDados.Name = "locCarregarDados";
            this.locCarregarDados.Size = new System.Drawing.Size(800, 28);
            this.locCarregarDados.TabIndex = 1;
            this.locCarregarDados.Text = "menuStrip1";
            // 
            // locNovoFilme
            // 
            this.locNovoFilme.Name = "locNovoFilme";
            this.locNovoFilme.Size = new System.Drawing.Size(99, 24);
            this.locNovoFilme.Text = "Novo Filme";
            this.locNovoFilme.Click += new System.EventHandler(this.locNovoFilme_Click);
            // 
            // locSalvarDados
            // 
            this.locSalvarDados.Name = "locSalvarDados";
            this.locSalvarDados.Size = new System.Drawing.Size(110, 24);
            this.locSalvarDados.Text = "Salvar Dados";
            this.locSalvarDados.Click += new System.EventHandler(this.locSalvarDados_Click);
            // 
            // carregarToolStripMenuItem
            // 
            this.carregarToolStripMenuItem.Name = "carregarToolStripMenuItem";
            this.carregarToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.carregarToolStripMenuItem.Text = "Carregar Dados";
            this.carregarToolStripMenuItem.Click += new System.EventHandler(this.carregarToolStripMenuItem_Click);
            // 
            // locSair
            // 
            this.locSair.Name = "locSair";
            this.locSair.Size = new System.Drawing.Size(48, 24);
            this.locSair.Text = "Sair";
            this.locSair.Click += new System.EventHandler(this.locSair_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(61, 4);
            // 
            // Locadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 610);
            this.Controls.Add(this.locBase);
            this.Controls.Add(this.locCarregarDados);
            this.MainMenuStrip = this.locCarregarDados;
            this.Name = "Locadora";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.locBase)).EndInit();
            this.locCarregarDados.ResumeLayout(false);
            this.locCarregarDados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView locBase;
        private System.Windows.Forms.MenuStrip locCarregarDados;
        private System.Windows.Forms.ToolStripMenuItem locNovoFilme;
        private System.Windows.Forms.ToolStripMenuItem locSalvarDados;
        private System.Windows.Forms.ToolStripMenuItem carregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locSair;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
    }
}

