
namespace ProjetoPapelariaHumanas
{
    partial class FormMarca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMarca));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Box_Nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Box_Cod_Marca = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Lb_Data = new System.Windows.Forms.Label();
            this.lb_titulo_data = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Check_Ativo = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Box_Observacao = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Bt_Cadastrar = new System.Windows.Forms.Button();
            this.bt_Atulizar = new System.Windows.Forms.Button();
            this.bt_Excluir = new System.Windows.Forms.Button();
            this.bt_Sair = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label_marca = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_ajuda = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Box_Nome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados da Marca";
            // 
            // Box_Nome
            // 
            this.Box_Nome.BackColor = System.Drawing.Color.AliceBlue;
            this.Box_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Nome.Location = new System.Drawing.Point(69, 37);
            this.Box_Nome.MaxLength = 30;
            this.Box_Nome.Name = "Box_Nome";
            this.Box_Nome.Size = new System.Drawing.Size(381, 20);
            this.Box_Nome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "* Nome :";
            // 
            // Box_Cod_Marca
            // 
            this.Box_Cod_Marca.BackColor = System.Drawing.Color.AliceBlue;
            this.Box_Cod_Marca.Enabled = false;
            this.Box_Cod_Marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Cod_Marca.Location = new System.Drawing.Point(93, 16);
            this.Box_Cod_Marca.Name = "Box_Cod_Marca";
            this.Box_Cod_Marca.Size = new System.Drawing.Size(49, 20);
            this.Box_Cod_Marca.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Codigo Marca:";
            // 
            // Lb_Data
            // 
            this.Lb_Data.AutoSize = true;
            this.Lb_Data.Enabled = false;
            this.Lb_Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Data.Location = new System.Drawing.Point(279, 19);
            this.Lb_Data.Name = "Lb_Data";
            this.Lb_Data.Size = new System.Drawing.Size(30, 13);
            this.Lb_Data.TabIndex = 5;
            this.Lb_Data.Text = "Data";
            // 
            // lb_titulo_data
            // 
            this.lb_titulo_data.AutoSize = true;
            this.lb_titulo_data.Location = new System.Drawing.Point(151, 19);
            this.lb_titulo_data.Name = "lb_titulo_data";
            this.lb_titulo_data.Size = new System.Drawing.Size(96, 13);
            this.lb_titulo_data.TabIndex = 4;
            this.lb_titulo_data.Text = "Data Cadastro :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Status :";
            // 
            // Check_Ativo
            // 
            this.Check_Ativo.AutoSize = true;
            this.Check_Ativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Check_Ativo.Location = new System.Drawing.Point(405, 19);
            this.Check_Ativo.Name = "Check_Ativo";
            this.Check_Ativo.Size = new System.Drawing.Size(50, 17);
            this.Check_Ativo.TabIndex = 2;
            this.Check_Ativo.Text = "Ativo";
            this.Check_Ativo.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Box_Observacao);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(459, 155);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Observação";
            // 
            // Box_Observacao
            // 
            this.Box_Observacao.BackColor = System.Drawing.Color.AliceBlue;
            this.Box_Observacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Observacao.Location = new System.Drawing.Point(85, 19);
            this.Box_Observacao.MaxLength = 50;
            this.Box_Observacao.Multiline = true;
            this.Box_Observacao.Name = "Box_Observacao";
            this.Box_Observacao.Size = new System.Drawing.Size(367, 130);
            this.Box_Observacao.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Observação :";
            // 
            // Bt_Cadastrar
            // 
            this.Bt_Cadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.Bt_Cadastrar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Cadastrar.Image = ((System.Drawing.Image)(resources.GetObject("Bt_Cadastrar.Image")));
            this.Bt_Cadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bt_Cadastrar.Location = new System.Drawing.Point(9, 379);
            this.Bt_Cadastrar.Name = "Bt_Cadastrar";
            this.Bt_Cadastrar.Size = new System.Drawing.Size(108, 42);
            this.Bt_Cadastrar.TabIndex = 7;
            this.Bt_Cadastrar.Text = "          Cadastrar";
            this.Bt_Cadastrar.UseVisualStyleBackColor = false;
            this.Bt_Cadastrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_Atulizar
            // 
            this.bt_Atulizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.bt_Atulizar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Atulizar.Image = ((System.Drawing.Image)(resources.GetObject("bt_Atulizar.Image")));
            this.bt_Atulizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Atulizar.Location = new System.Drawing.Point(188, 379);
            this.bt_Atulizar.Name = "bt_Atulizar";
            this.bt_Atulizar.Size = new System.Drawing.Size(108, 42);
            this.bt_Atulizar.TabIndex = 8;
            this.bt_Atulizar.Text = "         Atualizar";
            this.bt_Atulizar.UseVisualStyleBackColor = false;
            this.bt_Atulizar.Click += new System.EventHandler(this.bt_Atulizar_Click);
            // 
            // bt_Excluir
            // 
            this.bt_Excluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.bt_Excluir.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Excluir.Image = ((System.Drawing.Image)(resources.GetObject("bt_Excluir.Image")));
            this.bt_Excluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Excluir.Location = new System.Drawing.Point(361, 379);
            this.bt_Excluir.Name = "bt_Excluir";
            this.bt_Excluir.Size = new System.Drawing.Size(108, 42);
            this.bt_Excluir.TabIndex = 9;
            this.bt_Excluir.Text = "           Excluir";
            this.bt_Excluir.UseVisualStyleBackColor = false;
            this.bt_Excluir.Click += new System.EventHandler(this.bt_Excluir_Click);
            // 
            // bt_Sair
            // 
            this.bt_Sair.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bt_Sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Sair.Location = new System.Drawing.Point(456, -4);
            this.bt_Sair.Name = "bt_Sair";
            this.bt_Sair.Size = new System.Drawing.Size(31, 28);
            this.bt_Sair.TabIndex = 10;
            this.bt_Sair.Text = "X";
            this.bt_Sair.UseVisualStyleBackColor = false;
            this.bt_Sair.Click += new System.EventHandler(this.bt_Sair_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Check_Ativo);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.Lb_Data);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.lb_titulo_data);
            this.groupBox3.Controls.Add(this.Box_Cod_Marca);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 162);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(459, 44);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            // 
            // label_marca
            // 
            this.label_marca.AutoSize = true;
            this.label_marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label_marca.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_marca.Location = new System.Drawing.Point(120, 34);
            this.label_marca.Name = "label_marca";
            this.label_marca.Size = new System.Drawing.Size(233, 29);
            this.label_marca.TabIndex = 15;
            this.label_marca.Text = "Cadastro de Marca";
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
            this.bt_ajuda.Location = new System.Drawing.Point(431, -1);
            this.bt_ajuda.Name = "bt_ajuda";
            this.bt_ajuda.Size = new System.Drawing.Size(19, 19);
            this.bt_ajuda.Style = MetroFramework.MetroColorStyle.Silver;
            this.bt_ajuda.TabIndex = 41;
            this.bt_ajuda.Text = " ?";
            this.bt_ajuda.UseSelectable = true;
            this.bt_ajuda.Click += new System.EventHandler(this.bt_ajuda_Click);
            // 
            // FormMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(483, 430);
            this.Controls.Add(this.bt_ajuda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_marca);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.bt_Sair);
            this.Controls.Add(this.bt_Excluir);
            this.Controls.Add(this.bt_Atulizar);
            this.Controls.Add(this.Bt_Cadastrar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMarca";
            this.Load += new System.EventHandler(this.FormMarca_Load);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_titulo_data;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Bt_Cadastrar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bt_Atulizar;
        private System.Windows.Forms.Button bt_Excluir;
        private System.Windows.Forms.Button bt_Sair;
        public System.Windows.Forms.TextBox Box_Nome;
        public System.Windows.Forms.Label Lb_Data;
        public System.Windows.Forms.CheckBox Check_Ativo;
        public System.Windows.Forms.TextBox Box_Observacao;
        public System.Windows.Forms.TextBox Box_Cod_Marca;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label_marca;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroButton bt_ajuda;
    }
}