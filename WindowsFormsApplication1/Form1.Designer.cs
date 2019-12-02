namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lProduto = new System.Windows.Forms.Label();
            this.lCliente = new System.Windows.Forms.Label();
            this.Cliente = new System.Windows.Forms.PictureBox();
            this.Produto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Cliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Produto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(94, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "BEM-VINDO";
            // 
            // lProduto
            // 
            this.lProduto.AutoSize = true;
            this.lProduto.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lProduto.Location = new System.Drawing.Point(279, 219);
            this.lProduto.Name = "lProduto";
            this.lProduto.Size = new System.Drawing.Size(78, 22);
            this.lProduto.TabIndex = 4;
            this.lProduto.Text = "Produto";
            // 
            // lCliente
            // 
            this.lCliente.AutoSize = true;
            this.lCliente.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCliente.Location = new System.Drawing.Point(60, 223);
            this.lCliente.Name = "lCliente";
            this.lCliente.Size = new System.Drawing.Size(79, 26);
            this.lCliente.TabIndex = 5;
            this.lCliente.Text = "Cliente";
            // 
            // Cliente
            // 
            this.Cliente.Image = global::WindowsFormsApplication1.Properties.Resources.cliente;
            this.Cliente.Location = new System.Drawing.Point(58, 136);
            this.Cliente.Name = "Cliente";
            this.Cliente.Size = new System.Drawing.Size(81, 80);
            this.Cliente.TabIndex = 3;
            this.Cliente.TabStop = false;
            this.Cliente.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Produto
            // 
            this.Produto.Image = global::WindowsFormsApplication1.Properties.Resources.icons8_produto_novo_80;
            this.Produto.Location = new System.Drawing.Point(276, 136);
            this.Produto.Name = "Produto";
            this.Produto.Size = new System.Drawing.Size(81, 80);
            this.Produto.TabIndex = 2;
            this.Produto.TabStop = false;
            this.Produto.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(420, 272);
            this.Controls.Add(this.lCliente);
            this.Controls.Add(this.lProduto);
            this.Controls.Add(this.Cliente);
            this.Controls.Add(this.Produto);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Cliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Produto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Produto;
        private System.Windows.Forms.PictureBox Cliente;
        private System.Windows.Forms.Label lProduto;
        private System.Windows.Forms.Label lCliente;
    }
}

