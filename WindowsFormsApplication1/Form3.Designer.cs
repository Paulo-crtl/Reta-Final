namespace WindowsFormsApplication1
{
    partial class Form3
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
            this.estoque = new System.Windows.Forms.TextBox();
            this.nome = new System.Windows.Forms.TextBox();
            this.codigo = new System.Windows.Forms.TextBox();
            this.preço = new System.Windows.Forms.MaskedTextBox();
            this.unidade = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.descriçao = new System.Windows.Forms.RichTextBox();
            this.Limpar = new System.Windows.Forms.Button();
            this.Cadastrar = new System.Windows.Forms.Button();
            this.tipo = new System.Windows.Forms.ComboBox();
            this.t = new System.Windows.Forms.Label();
            this.Voltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.unidade)).BeginInit();
            this.SuspendLayout();
            // 
            // estoque
            // 
            this.estoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estoque.Location = new System.Drawing.Point(130, 358);
            this.estoque.Name = "estoque";
            this.estoque.Size = new System.Drawing.Size(81, 24);
            this.estoque.TabIndex = 5;
            // 
            // nome
            // 
            this.nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.Location = new System.Drawing.Point(35, 142);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(338, 24);
            this.nome.TabIndex = 2;
            // 
            // codigo
            // 
            this.codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigo.Location = new System.Drawing.Point(35, 88);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(338, 24);
            this.codigo.TabIndex = 1;
            // 
            // preço
            // 
            this.preço.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preço.Location = new System.Drawing.Point(35, 358);
            this.preço.Name = "preço";
            this.preço.Size = new System.Drawing.Size(89, 24);
            this.preço.TabIndex = 4;
            // 
            // unidade
            // 
            this.unidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unidade.Location = new System.Drawing.Point(217, 358);
            this.unidade.Name = "unidade";
            this.unidade.Size = new System.Drawing.Size(64, 24);
            this.unidade.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(127, 329);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "Estoque";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Preço";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Codigo De Barras";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(214, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Unidade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-2, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(324, 37);
            this.label5.TabIndex = 26;
            this.label5.Text = "Cadastro De Produto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "Descrição";
            // 
            // descriçao
            // 
            this.descriçao.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriçao.Location = new System.Drawing.Point(35, 198);
            this.descriçao.Name = "descriçao";
            this.descriçao.Size = new System.Drawing.Size(338, 116);
            this.descriçao.TabIndex = 3;
            this.descriçao.Text = "";
            // 
            // Limpar
            // 
            this.Limpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Limpar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Limpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Limpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Limpar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Limpar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Limpar.Location = new System.Drawing.Point(216, 400);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(113, 30);
            this.Limpar.TabIndex = 9;
            this.Limpar.Text = "Limpar ";
            this.Limpar.UseVisualStyleBackColor = false;
            this.Limpar.Click += new System.EventHandler(this.Limpar_Click);
            // 
            // Cadastrar
            // 
            this.Cadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Cadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Cadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cadastrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Cadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Cadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cadastrar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cadastrar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Cadastrar.Location = new System.Drawing.Point(75, 399);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(117, 30);
            this.Cadastrar.TabIndex = 8;
            this.Cadastrar.Text = "Cadastrar ";
            this.Cadastrar.UseVisualStyleBackColor = false;
            this.Cadastrar.Click += new System.EventHandler(this.Cadastrar_Click);
            // 
            // tipo
            // 
            this.tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipo.FormattingEnabled = true;
            this.tipo.Items.AddRange(new object[] {
            "pra mim\t",
            "e pra tu",
            "pra ele"});
            this.tipo.Location = new System.Drawing.Point(287, 358);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(86, 23);
            this.tipo.TabIndex = 7;
            // 
            // t
            // 
            this.t.AutoSize = true;
            this.t.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t.Location = new System.Drawing.Point(284, 329);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(40, 16);
            this.t.TabIndex = 38;
            this.t.Text = "Tipo";
            // 
            // Voltar
            // 
            this.Voltar.BackColor = System.Drawing.Color.DarkRed;
            this.Voltar.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.icons8_voltar_50;
            this.Voltar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.Voltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.Voltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.Voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Voltar.ForeColor = System.Drawing.Color.White;
            this.Voltar.Location = new System.Drawing.Point(328, 12);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(61, 53);
            this.Voltar.TabIndex = 10;
            this.Voltar.UseVisualStyleBackColor = false;
            this.Voltar.Click += new System.EventHandler(this.Voltar_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(415, 446);
            this.Controls.Add(this.Voltar);
            this.Controls.Add(this.t);
            this.Controls.Add(this.tipo);
            this.Controls.Add(this.Cadastrar);
            this.Controls.Add(this.Limpar);
            this.Controls.Add(this.descriçao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.unidade);
            this.Controls.Add(this.preço);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.estoque);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.unidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox estoque;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.TextBox codigo;
        private System.Windows.Forms.MaskedTextBox preço;
        private System.Windows.Forms.NumericUpDown unidade;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox descriçao;
        private System.Windows.Forms.Button Limpar;
        private System.Windows.Forms.Button Cadastrar;
        private System.Windows.Forms.ComboBox tipo;
        private System.Windows.Forms.Label t;
        private System.Windows.Forms.Button Voltar;
    }
}