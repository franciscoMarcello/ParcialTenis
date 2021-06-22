
namespace LanchesDefault.Forms
{
    partial class FrmMenu
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
            this.BtnRealizarUmPedido = new System.Windows.Forms.Button();
            this.BtnPedidosRealizados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnRealizarUmPedido
            // 
            this.BtnRealizarUmPedido.Location = new System.Drawing.Point(35, 98);
            this.BtnRealizarUmPedido.Name = "BtnRealizarUmPedido";
            this.BtnRealizarUmPedido.Size = new System.Drawing.Size(350, 162);
            this.BtnRealizarUmPedido.TabIndex = 0;
            this.BtnRealizarUmPedido.Text = "Realizar um pedido";
            this.BtnRealizarUmPedido.UseVisualStyleBackColor = true;
            this.BtnRealizarUmPedido.Click += new System.EventHandler(this.BtnRealizarUmPedido_Click);
            // 
            // BtnPedidosRealizados
            // 
            this.BtnPedidosRealizados.Location = new System.Drawing.Point(413, 98);
            this.BtnPedidosRealizados.Name = "BtnPedidosRealizados";
            this.BtnPedidosRealizados.Size = new System.Drawing.Size(350, 162);
            this.BtnPedidosRealizados.TabIndex = 1;
            this.BtnPedidosRealizados.Text = "Pedidos realizados";
            this.BtnPedidosRealizados.UseVisualStyleBackColor = true;
            this.BtnPedidosRealizados.Click += new System.EventHandler(this.BtnPedidosRealizados_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 390);
            this.Controls.Add(this.BtnPedidosRealizados);
            this.Controls.Add(this.BtnRealizarUmPedido);
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnRealizarUmPedido;
        private System.Windows.Forms.Button BtnPedidosRealizados;
    }
}