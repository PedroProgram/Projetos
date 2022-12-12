namespace ProjetoPapelariaHumanas
{
    partial class FormProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProduto));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Box_Preco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Box_Quantidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Box_Nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Cb_Cod_Fornecedor = new System.Windows.Forms.ComboBox();
            this.Cb_Cod_Marca = new System.Windows.Forms.ComboBox();
            this.Cb_Cod_Categoria = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Check_Status = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_data = new System.Windows.Forms.Label();
            this.lb_data_titulo = new System.Windows.Forms.Label();
            this.Box_Cod_Produto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Bt_Cadastrar = new System.Windows.Forms.Button();
            this.bt_Sair = new System.Windows.Forms.Button();
            this.bt_Excluir = new System.Windows.Forms.Button();
            this.bt_Atulizar = new System.Windows.Forms.Button();
            this.label_produto = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_ajuda = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Box_Preco);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Box_Quantidade);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Box_Nome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 107);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Produto";
            // 
            // Box_Preco
            // 
            this.Box_Preco.BackColor = System.Drawing.Color.AliceBlue;
            this.Box_Preco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Preco.Location = new System.Drawing.Point(295, 76);
            this.Box_Preco.MaxLength = 5;
            this.Box_Preco.Name = "Box_Preco";
            this.Box_Preco.Size = new System.Drawing.Size(109, 20);
            this.Box_Preco.TabIndex = 5;
            this.Box_Preco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Box_Preco_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "* Preço :";
            // 
            // Box_Quantidade
            // 
            this.Box_Quantidade.BackColor = System.Drawing.Color.AliceBlue;
            this.Box_Quantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Quantidade.Location = new System.Drawing.Point(96, 76);
            this.Box_Quantidade.MaxLength = 5;
            this.Box_Quantidade.Name = "Box_Quantidade";
            this.Box_Quantidade.Size = new System.Drawing.Size(109, 20);
            this.Box_Quantidade.TabIndex = 3;
            this.Box_Quantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Box_Quantidade_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "* Quantidade :";
            // 
            // Box_Nome
            // 
            this.Box_Nome.BackColor = System.Drawing.Color.AliceBlue;
            this.Box_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Nome.Location = new System.Drawing.Point(80, 35);
            this.Box_Nome.MaxLength = 30;
            this.Box_Nome.Name = "Box_Nome";
            this.Box_Nome.Size = new System.Drawing.Size(424, 20);
            this.Box_Nome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "* Nome :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Cb_Cod_Fornecedor);
            this.groupBox2.Controls.Add(this.Cb_Cod_Marca);
            this.groupBox2.Controls.Add(this.Cb_Cod_Categoria);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(551, 130);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // Cb_Cod_Fornecedor
            // 
            this.Cb_Cod_Fornecedor.BackColor = System.Drawing.Color.AliceBlue;
            this.Cb_Cod_Fornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_Cod_Fornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_Cod_Fornecedor.FormattingEnabled = true;
            this.Cb_Cod_Fornecedor.Location = new System.Drawing.Point(101, 100);
            this.Cb_Cod_Fornecedor.Name = "Cb_Cod_Fornecedor";
            this.Cb_Cod_Fornecedor.Size = new System.Drawing.Size(137, 21);
            this.Cb_Cod_Fornecedor.TabIndex = 12;
            // 
            // Cb_Cod_Marca
            // 
            this.Cb_Cod_Marca.BackColor = System.Drawing.Color.AliceBlue;
            this.Cb_Cod_Marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_Cod_Marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_Cod_Marca.FormattingEnabled = true;
            this.Cb_Cod_Marca.Location = new System.Drawing.Point(101, 56);
            this.Cb_Cod_Marca.Name = "Cb_Cod_Marca";
            this.Cb_Cod_Marca.Size = new System.Drawing.Size(137, 21);
            this.Cb_Cod_Marca.TabIndex = 11;
            // 
            // Cb_Cod_Categoria
            // 
            this.Cb_Cod_Categoria.BackColor = System.Drawing.Color.AliceBlue;
            this.Cb_Cod_Categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_Cod_Categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_Cod_Categoria.FormattingEnabled = true;
            this.Cb_Cod_Categoria.Location = new System.Drawing.Point(101, 16);
            this.Cb_Cod_Categoria.Name = "Cb_Cod_Categoria";
            this.Cb_Cod_Categoria.Size = new System.Drawing.Size(137, 21);
            this.Cb_Cod_Categoria.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "* Fornecedor  :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "* Marca :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "* Categoria :";
            // 
            // Check_Status
            // 
            this.Check_Status.AutoSize = true;
            this.Check_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Check_Status.Location = new System.Drawing.Point(466, 19);
            this.Check_Status.Name = "Check_Status";
            this.Check_Status.Size = new System.Drawing.Size(50, 17);
            this.Check_Status.TabIndex = 10;
            this.Check_Status.Text = "Ativo";
            this.Check_Status.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(416, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Status :";
            // 
            // lb_data
            // 
            this.lb_data.AutoSize = true;
            this.lb_data.Enabled = false;
            this.lb_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_data.Location = new System.Drawing.Point(336, 20);
            this.lb_data.Name = "lb_data";
            this.lb_data.Size = new System.Drawing.Size(28, 13);
            this.lb_data.TabIndex = 8;
            this.lb_data.Text = "data";
            // 
            // lb_data_titulo
            // 
            this.lb_data_titulo.AutoSize = true;
            this.lb_data_titulo.Location = new System.Drawing.Point(207, 20);
            this.lb_data_titulo.Name = "lb_data_titulo";
            this.lb_data_titulo.Size = new System.Drawing.Size(96, 13);
            this.lb_data_titulo.TabIndex = 7;
            this.lb_data_titulo.Text = "Data Cadastro :";
            // 
            // Box_Cod_Produto
            // 
            this.Box_Cod_Produto.BackColor = System.Drawing.Color.AliceBlue;
            this.Box_Cod_Produto.Enabled = false;
            this.Box_Cod_Produto.Location = new System.Drawing.Point(114, 17);
            this.Box_Cod_Produto.Name = "Box_Cod_Produto";
            this.Box_Cod_Produto.Size = new System.Drawing.Size(73, 20);
            this.Box_Cod_Produto.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Codigo Produto :";
            // 
            // Bt_Cadastrar
            // 
            this.Bt_Cadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.Bt_Cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Cadastrar.Image = ((System.Drawing.Image)(resources.GetObject("Bt_Cadastrar.Image")));
            this.Bt_Cadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bt_Cadastrar.Location = new System.Drawing.Point(12, 357);
            this.Bt_Cadastrar.Name = "Bt_Cadastrar";
            this.Bt_Cadastrar.Size = new System.Drawing.Size(119, 49);
            this.Bt_Cadastrar.TabIndex = 3;
            this.Bt_Cadastrar.Text = "     Cadastrar";
            this.Bt_Cadastrar.UseVisualStyleBackColor = false;
            this.Bt_Cadastrar.Click += new System.EventHandler(this.Bt_Cadastrar_Click);
            // 
            // bt_Sair
            // 
            this.bt_Sair.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bt_Sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Sair.Location = new System.Drawing.Point(562, -4);
            this.bt_Sair.Name = "bt_Sair";
            this.bt_Sair.Size = new System.Drawing.Size(31, 28);
            this.bt_Sair.TabIndex = 13;
            this.bt_Sair.Text = "X";
            this.bt_Sair.UseVisualStyleBackColor = false;
            this.bt_Sair.Click += new System.EventHandler(this.bt_Sair_Click);
            // 
            // bt_Excluir
            // 
            this.bt_Excluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.bt_Excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Excluir.Image = ((System.Drawing.Image)(resources.GetObject("bt_Excluir.Image")));
            this.bt_Excluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Excluir.Location = new System.Drawing.Point(448, 357);
            this.bt_Excluir.Name = "bt_Excluir";
            this.bt_Excluir.Size = new System.Drawing.Size(115, 49);
            this.bt_Excluir.TabIndex = 12;
            this.bt_Excluir.Text = "    Excluir";
            this.bt_Excluir.UseVisualStyleBackColor = false;
            this.bt_Excluir.Click += new System.EventHandler(this.bt_Excluir_Click);
            // 
            // bt_Atulizar
            // 
            this.bt_Atulizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.bt_Atulizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Atulizar.Image = ((System.Drawing.Image)(resources.GetObject("bt_Atulizar.Image")));
            this.bt_Atulizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Atulizar.Location = new System.Drawing.Point(230, 357);
            this.bt_Atulizar.Name = "bt_Atulizar";
            this.bt_Atulizar.Size = new System.Drawing.Size(119, 49);
            this.bt_Atulizar.TabIndex = 11;
            this.bt_Atulizar.Text = "      Atualizar";
            this.bt_Atulizar.UseVisualStyleBackColor = false;
            this.bt_Atulizar.Click += new System.EventHandler(this.bt_Atulizar_Click);
            // 
            // label_produto
            // 
            this.label_produto.AutoSize = true;
            this.label_produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label_produto.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_produto.Location = new System.Drawing.Point(163, 35);
            this.label_produto.Name = "label_produto";
            this.label_produto.Size = new System.Drawing.Size(254, 29);
            this.label_produto.TabIndex = 14;
            this.label_produto.Text = "Cadastro de Produto";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Check_Status);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.lb_data);
            this.groupBox3.Controls.Add(this.Box_Cod_Produto);
            this.groupBox3.Controls.Add(this.lb_data_titulo);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 176);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(551, 48);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "Sistema Papelaria Humanas";
            // 
            // bt_ajuda
            // 
            this.bt_ajuda.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_ajuda.Location = new System.Drawing.Point(537, -1);
            this.bt_ajuda.Name = "bt_ajuda";
            this.bt_ajuda.Size = new System.Drawing.Size(19, 19);
            this.bt_ajuda.Style = MetroFramework.MetroColorStyle.Silver;
            this.bt_ajuda.TabIndex = 42;
            this.bt_ajuda.Text = " ?";
            this.bt_ajuda.UseSelectable = true;
            this.bt_ajuda.Click += new System.EventHandler(this.bt_ajuda_Click);
            // 
            // FormProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(589, 411);
            this.Controls.Add(this.bt_ajuda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label_produto);
            this.Controls.Add(this.bt_Sair);
            this.Controls.Add(this.Bt_Cadastrar);
            this.Controls.Add(this.bt_Excluir);
            this.Controls.Add(this.bt_Atulizar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProduto";
            this.Load += new System.EventHandler(this.FormProduto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_data_titulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Bt_Cadastrar;
        private System.Windows.Forms.Button bt_Sair;
        private System.Windows.Forms.Button bt_Excluir;
        private System.Windows.Forms.Button bt_Atulizar;
        public System.Windows.Forms.TextBox Box_Preco;
        public System.Windows.Forms.TextBox Box_Quantidade;
        public System.Windows.Forms.TextBox Box_Nome;
        public System.Windows.Forms.CheckBox Check_Status;
        public System.Windows.Forms.Label lb_data;
        public System.Windows.Forms.TextBox Box_Cod_Produto;
        public System.Windows.Forms.ComboBox Cb_Cod_Fornecedor;
        public System.Windows.Forms.ComboBox Cb_Cod_Marca;
        public System.Windows.Forms.ComboBox Cb_Cod_Categoria;
        private System.Windows.Forms.Label label_produto;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroButton bt_ajuda;
    }
}