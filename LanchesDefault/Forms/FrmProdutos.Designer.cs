
namespace LanchesDefault.Forms
{
    partial class FrmProdutos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DgvProdutos = new System.Windows.Forms.DataGridView();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.TxtPesquisar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DgvProdutos);
            this.groupBox1.Controls.Add(this.BtnPesquisar);
            this.groupBox1.Controls.Add(this.TxtPesquisar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(753, 467);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Todos os Tenis";
            // 
            // DgvProdutos
            // 
            this.DgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProdutos.Location = new System.Drawing.Point(25, 92);
            this.DgvProdutos.Name = "DgvProdutos";
            this.DgvProdutos.Size = new System.Drawing.Size(706, 347);
            this.DgvProdutos.TabIndex = 3;
            this.DgvProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProdutos_CellContentClick);
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.Location = new System.Drawing.Point(579, 48);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(152, 23);
            this.BtnPesquisar.TabIndex = 2;
            this.BtnPesquisar.Text = "Pesquisar";
            this.BtnPesquisar.UseVisualStyleBackColor = true;
            this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // TxtPesquisar
            // 
            this.TxtPesquisar.Location = new System.Drawing.Point(25, 50);
            this.TxtPesquisar.Name = "TxtPesquisar";
            this.TxtPesquisar.Size = new System.Drawing.Size(547, 20);
            this.TxtPesquisar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição ou código";
            // 
            // FrmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 512);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmProdutos";
            this.Text = "FrmProdutos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DgvProdutos;
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.TextBox TxtPesquisar;
        private System.Windows.Forms.Label label1;
    }
}