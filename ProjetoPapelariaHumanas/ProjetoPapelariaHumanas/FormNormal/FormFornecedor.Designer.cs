
namespace ProjetoPapelariaHumanas
{
    partial class FormFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFornecedor));
            this.label_fornecedor = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Mask_Cnpj = new System.Windows.Forms.MaskedTextBox();
            this.Mask_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Box_Nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Mask_Cep = new System.Windows.Forms.MaskedTextBox();
            this.Box_Cidade = new System.Windows.Forms.TextBox();
            this.Box_Bairro = new System.Windows.Forms.TextBox();
            this.Box_Rua = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Lb_Data = new System.Windows.Forms.Label();
            this.Check_Ativo = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lb_titulo_data = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bt_Cadastrar = new System.Windows.Forms.Button();
            this.bt_Atualizar = new System.Windows.Forms.Button();
            this.bt_Excluir = new System.Windows.Forms.Button();
            this.bt_Sair = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Box_Cod_Fornecedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_ajuda = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_fornecedor
            // 
            this.label_fornecedor.AutoSize = true;
            this.label_fornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label_fornecedor.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_fornecedor.Location = new System.Drawing.Point(168, 34);
            this.label_fornecedor.Name = "label_fornecedor";
            this.label_fornecedor.Size = new System.Drawing.Size(268, 29);
            this.label_fornecedor.TabIndex = 0;
            this.label_fornecedor.Text = "Cadastro  Fornecedor";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Mask_Cnpj);
            this.groupBox1.Controls.Add(this.Mask_Telefone);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.Box_Nome);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(583, 121);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Fornecedor";
            // 
            // Mask_Cnpj
            // 
            this.Mask_Cnpj.BackColor = System.Drawing.Color.AliceBlue;
            this.Mask_Cnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mask_Cnpj.Location = new System.Drawing.Point(68, 74);
            this.Mask_Cnpj.Mask = "00.000.000/0000-00";
            this.Mask_Cnpj.Name = "Mask_Cnpj";
            this.Mask_Cnpj.Size = new System.Drawing.Size(142, 20);
            this.Mask_Cnpj.TabIndex = 15;
            // 
            // Mask_Telefone
            // 
            this.Mask_Telefone.BackColor = System.Drawing.Color.AliceBlue;
            this.Mask_Telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mask_Telefone.Location = new System.Drawing.Point(303, 74);
            this.Mask_Telefone.Mask = "(99)-00000-0000";
            this.Mask_Telefone.Name = "Mask_Telefone";
            this.Mask_Telefone.Size = new System.Drawing.Size(96, 20);
            this.Mask_Telefone.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(229, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "* Telefone :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "* CNPJ :";
            // 
            // Box_Nome
            // 
            this.Box_Nome.BackColor = System.Drawing.Color.AliceBlue;
            this.Box_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Nome.Location = new System.Drawing.Point(68, 26);
            this.Box_Nome.MaxLength = 30;
            this.Box_Nome.Name = "Box_Nome";
            this.Box_Nome.Size = new System.Drawing.Size(496, 20);
            this.Box_Nome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "* Nome :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.Mask_Cep);
            this.groupBox2.Controls.Add(this.Box_Cidade);
            this.groupBox2.Controls.Add(this.Box_Bairro);
            this.groupBox2.Controls.Add(this.Box_Rua);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(21, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(583, 239);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Endereço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(160, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(358, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "* Pressione TAB Para Concluir O Preenchimento Do Endereço";
            // 
            // Mask_Cep
            // 
            this.Mask_Cep.BackColor = System.Drawing.Color.AliceBlue;
            this.Mask_Cep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mask_Cep.Location = new System.Drawing.Point(73, 39);
            this.Mask_Cep.Mask = "00000-000";
            this.Mask_Cep.Name = "Mask_Cep";
            this.Mask_Cep.Size = new System.Drawing.Size(68, 20);
            this.Mask_Cep.TabIndex = 14;
            this.Mask_Cep.Leave += new System.EventHandler(this.Mask_Cep_Leave);
            // 
            // Box_Cidade
            // 
            this.Box_Cidade.BackColor = System.Drawing.Color.AliceBlue;
            this.Box_Cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Cidade.Location = new System.Drawing.Point(73, 187);
            this.Box_Cidade.MaxLength = 20;
            this.Box_Cidade.Name = "Box_Cidade";
            this.Box_Cidade.Size = new System.Drawing.Size(321, 20);
            this.Box_Cidade.TabIndex = 12;
            // 
            // Box_Bairro
            // 
            this.Box_Bairro.BackColor = System.Drawing.Color.AliceBlue;
            this.Box_Bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Bairro.Location = new System.Drawing.Point(73, 132);
            this.Box_Bairro.MaxLength = 30;
            this.Box_Bairro.Name = "Box_Bairro";
            this.Box_Bairro.Size = new System.Drawing.Size(321, 20);
            this.Box_Bairro.TabIndex = 11;
            // 
            // Box_Rua
            // 
            this.Box_Rua.BackColor = System.Drawing.Color.AliceBlue;
            this.Box_Rua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Rua.Location = new System.Drawing.Point(73, 85);
            this.Box_Rua.MaxLength = 30;
            this.Box_Rua.Name = "Box_Rua";
            this.Box_Rua.Size = new System.Drawing.Size(321, 20);
            this.Box_Rua.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "* Cidade :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "* Rua :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "* CEP :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "* Bairro :";
            // 
            // Lb_Data
            // 
            this.Lb_Data.AutoSize = true;
            this.Lb_Data.Enabled = false;
            this.Lb_Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Data.Location = new System.Drawing.Point(327, 27);
            this.Lb_Data.Name = "Lb_Data";
            this.Lb_Data.Size = new System.Drawing.Size(28, 13);
            this.Lb_Data.TabIndex = 10;
            this.Lb_Data.Text = "data";
            // 
            // Check_Ativo
            // 
            this.Check_Ativo.AutoSize = true;
            this.Check_Ativo.Enabled = false;
            this.Check_Ativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Check_Ativo.Location = new System.Drawing.Point(519, 26);
            this.Check_Ativo.Name = "Check_Ativo";
            this.Check_Ativo.Size = new System.Drawing.Size(50, 17);
            this.Check_Ativo.TabIndex = 9;
            this.Check_Ativo.Text = "Ativo";
            this.Check_Ativo.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(467, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Status :";
            // 
            // lb_titulo_data
            // 
            this.lb_titulo_data.AutoSize = true;
            this.lb_titulo_data.Location = new System.Drawing.Point(205, 27);
            this.lb_titulo_data.Name = "lb_titulo_data";
            this.lb_titulo_data.Size = new System.Drawing.Size(96, 13);
            this.lb_titulo_data.TabIndex = 7;
            this.lb_titulo_data.Text = "Data Cadastro :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Codigo Fornecedor :";
            // 
            // bt_Cadastrar
            // 
            this.bt_Cadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.bt_Cadastrar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.bt_Cadastrar.Image = ((System.Drawing.Image)(resources.GetObject("bt_Cadastrar.Image")));
            this.bt_Cadastrar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.bt_Cadastrar.Location = new System.Drawing.Point(21, 502);
            this.bt_Cadastrar.Name = "bt_Cadastrar";
            this.bt_Cadastrar.Size = new System.Drawing.Size(126, 49);
            this.bt_Cadastrar.TabIndex = 4;
            this.bt_Cadastrar.Text = "  Cadastrar";
            this.bt_Cadastrar.UseVisualStyleBackColor = false;
            this.bt_Cadastrar.Click += new System.EventHandler(this.bt_Cadastrar_Click);
            // 
            // bt_Atualizar
            // 
            this.bt_Atualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.bt_Atualizar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.bt_Atualizar.Image = ((System.Drawing.Image)(resources.GetObject("bt_Atualizar.Image")));
            this.bt_Atualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Atualizar.Location = new System.Drawing.Point(253, 502);
            this.bt_Atualizar.Name = "bt_Atualizar";
            this.bt_Atualizar.Size = new System.Drawing.Size(132, 49);
            this.bt_Atualizar.TabIndex = 5;
            this.bt_Atualizar.Text = "  Atualizar";
            this.bt_Atualizar.UseVisualStyleBackColor = false;
            this.bt_Atualizar.Click += new System.EventHandler(this.bt_Atualizar_Click);
            // 
            // bt_Excluir
            // 
            this.bt_Excluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.bt_Excluir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.bt_Excluir.Image = ((System.Drawing.Image)(resources.GetObject("bt_Excluir.Image")));
            this.bt_Excluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Excluir.Location = new System.Drawing.Point(472, 502);
            this.bt_Excluir.Name = "bt_Excluir";
            this.bt_Excluir.Size = new System.Drawing.Size(132, 49);
            this.bt_Excluir.TabIndex = 6;
            this.bt_Excluir.Text = "Excluir";
            this.bt_Excluir.UseVisualStyleBackColor = false;
            this.bt_Excluir.Click += new System.EventHandler(this.bt_Excluir_Click);
            // 
            // bt_Sair
            // 
            this.bt_Sair.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bt_Sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Sair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Sair.Location = new System.Drawing.Point(600, -4);
            this.bt_Sair.Name = "bt_Sair";
            this.bt_Sair.Size = new System.Drawing.Size(31, 28);
            this.bt_Sair.TabIndex = 7;
            this.bt_Sair.Text = "X";
            this.bt_Sair.UseVisualStyleBackColor = false;
            this.bt_Sair.Click += new System.EventHandler(this.bt_Sair_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Box_Cod_Fornecedor);
            this.groupBox3.Controls.Add(this.lb_titulo_data);
            this.groupBox3.Controls.Add(this.Lb_Data);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.Check_Ativo);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(21, 188);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(583, 60);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // Box_Cod_Fornecedor
            // 
            this.Box_Cod_Fornecedor.BackColor = System.Drawing.Color.AliceBlue;
            this.Box_Cod_Fornecedor.Enabled = false;
            this.Box_Cod_Fornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Cod_Fornecedor.Location = new System.Drawing.Point(129, 24);
            this.Box_Cod_Fornecedor.Name = "Box_Cod_Fornecedor";
            this.Box_Cod_Fornecedor.Size = new System.Drawing.Size(62, 20);
            this.Box_Cod_Fornecedor.TabIndex = 11;
            this.Box_Cod_Fornecedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Sistema Papelaria Humanas";
            // 
            // bt_ajuda
            // 
            this.bt_ajuda.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_ajuda.Location = new System.Drawing.Point(575, -1);
            this.bt_ajuda.Name = "bt_ajuda";
            this.bt_ajuda.Size = new System.Drawing.Size(19, 19);
            this.bt_ajuda.Style = MetroFramework.MetroColorStyle.Silver;
            this.bt_ajuda.TabIndex = 36;
            this.bt_ajuda.Text = " ?";
            this.bt_ajuda.UseSelectable = true;
            this.bt_ajuda.Click += new System.EventHandler(this.bt_ajuda_Click);
            // 
            // FormFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(627, 555);
            this.Controls.Add(this.bt_ajuda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.bt_Sair);
            this.Controls.Add(this.bt_Excluir);
            this.Controls.Add(this.bt_Atualizar);
            this.Controls.Add(this.bt_Cadastrar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_fornecedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Papelaria Humanas";
            this.Load += new System.EventHandler(this.FormFornecedor_Load);
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

        private System.Windows.Forms.Label label_fornecedor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lb_titulo_data;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bt_Cadastrar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button bt_Atualizar;
        private System.Windows.Forms.Button bt_Excluir;
        private System.Windows.Forms.Button bt_Sair;
        public System.Windows.Forms.TextBox Box_Nome;
        public System.Windows.Forms.Label Lb_Data;
        public System.Windows.Forms.CheckBox Check_Ativo;
        public System.Windows.Forms.TextBox Box_Cidade;
        public System.Windows.Forms.TextBox Box_Bairro;
        public System.Windows.Forms.TextBox Box_Rua;
        public System.Windows.Forms.MaskedTextBox Mask_Telefone;
        public System.Windows.Forms.MaskedTextBox Mask_Cep;
        public System.Windows.Forms.MaskedTextBox Mask_Cnpj;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.TextBox Box_Cod_Fornecedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroButton bt_ajuda;
    }
}