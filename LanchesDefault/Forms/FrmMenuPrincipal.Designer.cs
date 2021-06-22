
namespace LanchesDefault.Forms
{
    partial class FrmMenuPrincipal
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
            this.NovoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PesquisarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PesquisarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NovoProdutoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.PesquisarProdutosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NovoToolStripMenuItem
            // 
            this.NovoToolStripMenuItem.Name = "NovoToolStripMenuItem";
            this.NovoToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.NovoToolStripMenuItem.Text = "Novo";
            // 
            // PesquisarToolStripMenuItem
            // 
            this.PesquisarToolStripMenuItem.Name = "PesquisarToolStripMenuItem";
            this.PesquisarToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
          
            
            // 
            // PesquisarToolStripMenuItem1
            // 
            this.PesquisarToolStripMenuItem1.Name = "PesquisarToolStripMenuItem1";
            this.PesquisarToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NovoProdutoToolStripMenuItem1,
            this.PesquisarProdutosToolStripMenuItem1,
            });
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.produtosToolStripMenuItem.Text = "Tenis";
            // 
            // NovoProdutoToolStripMenuItem1
            // 
            this.NovoProdutoToolStripMenuItem1.Name = "NovoProdutoToolStripMenuItem1";
            this.NovoProdutoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.NovoProdutoToolStripMenuItem1.Text = "Novo";
            this.NovoProdutoToolStripMenuItem1.Click += new System.EventHandler(this.NovoProdutoToolStripMenuItem1_Click);
            // 
            // PesquisarProdutosToolStripMenuItem1
            // 
            this.PesquisarProdutosToolStripMenuItem1.Name = "PesquisarProdutosToolStripMenuItem1";
            this.PesquisarProdutosToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.PesquisarProdutosToolStripMenuItem1.Text = "Pesquisar";
            this.PesquisarProdutosToolStripMenuItem1.Click += new System.EventHandler(this.PesquisarProdutosToolStripMenuItem1_Click);
           
          
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenuPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem NovoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PesquisarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PesquisarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NovoProdutoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem PesquisarProdutosToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}