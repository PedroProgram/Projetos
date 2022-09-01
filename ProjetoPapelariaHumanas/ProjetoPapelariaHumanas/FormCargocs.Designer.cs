
namespace ProjetoPapelariaHumanas
{
    partial class FormCargocs
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
            this.lb_data_cadastro = new System.Windows.Forms.Label();
            this.lb_codigo_cargo = new System.Windows.Forms.Label();
            this.label_cargo = new System.Windows.Forms.Label();
            this.lb_nome_cargo = new System.Windows.Forms.Label();
            this.lb_status = new System.Windows.Forms.Label();
            this.lb_observacao = new System.Windows.Forms.Label();
            this.box_observacao = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.box_nome_cargo = new System.Windows.Forms.TextBox();
            this.box_codigo_cargo = new System.Windows.Forms.TextBox();
            this.check_ativo = new System.Windows.Forms.CheckBox();
            this.bt_cadastrar = new System.Windows.Forms.Button();
            this.bt_atualizar = new System.Windows.Forms.Button();
            this.bt_excluir = new System.Windows.Forms.Button();
            this.bt_sair = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_data_cadastro
            // 
            this.lb_data_cadastro.AutoSize = true;
            this.lb_data_cadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_data_cadastro.ForeColor = System.Drawing.Color.Black;
            this.lb_data_cadastro.Location = new System.Drawing.Point(260, 112);
            this.lb_data_cadastro.Name = "lb_data_cadastro";
            this.lb_data_cadastro.Size = new System.Drawing.Size(88, 13);
            this.lb_data_cadastro.TabIndex = 0;
            this.lb_data_cadastro.Text = "Data Cadastro";
            // 
            // lb_codigo_cargo
            // 
            this.lb_codigo_cargo.AutoSize = true;
            this.lb_codigo_cargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_codigo_cargo.ForeColor = System.Drawing.Color.Black;
            this.lb_codigo_cargo.Location = new System.Drawing.Point(7, 112);
            this.lb_codigo_cargo.Name = "lb_codigo_cargo";
            this.lb_codigo_cargo.Size = new System.Drawing.Size(91, 13);
            this.lb_codigo_cargo.TabIndex = 1;
            this.lb_codigo_cargo.Text = "Código Cargo :";
            // 
            // label_cargo
            // 
            this.label_cargo.AutoSize = true;
            this.label_cargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cargo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_cargo.Location = new System.Drawing.Point(299, 9);
            this.label_cargo.Name = "label_cargo";
            this.label_cargo.Size = new System.Drawing.Size(233, 29);
            this.label_cargo.TabIndex = 2;
            this.label_cargo.Text = "Cadastro de Cargo";
            // 
            // lb_nome_cargo
            // 
            this.lb_nome_cargo.AutoSize = true;
            this.lb_nome_cargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nome_cargo.ForeColor = System.Drawing.Color.Black;
            this.lb_nome_cargo.Location = new System.Drawing.Point(7, 40);
            this.lb_nome_cargo.Name = "lb_nome_cargo";
            this.lb_nome_cargo.Size = new System.Drawing.Size(84, 13);
            this.lb_nome_cargo.TabIndex = 3;
            this.lb_nome_cargo.Text = "Nome Cargo :";
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_status.ForeColor = System.Drawing.Color.Black;
            this.lb_status.Location = new System.Drawing.Point(397, 112);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(51, 13);
            this.lb_status.TabIndex = 4;
            this.lb_status.Text = "Status :";
            // 
            // lb_observacao
            // 
            this.lb_observacao.AutoSize = true;
            this.lb_observacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_observacao.ForeColor = System.Drawing.Color.Black;
            this.lb_observacao.Location = new System.Drawing.Point(8, 163);
            this.lb_observacao.Name = "lb_observacao";
            this.lb_observacao.Size = new System.Drawing.Size(71, 13);
            this.lb_observacao.TabIndex = 5;
            this.lb_observacao.Text = "Observação :";
            // 
            // box_observacao
            // 
            this.box_observacao.Location = new System.Drawing.Point(108, 156);
            this.box_observacao.Name = "box_observacao";
            this.box_observacao.Size = new System.Drawing.Size(416, 20);
            this.box_observacao.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.box_nome_cargo);
            this.groupBox1.Controls.Add(this.box_codigo_cargo);
            this.groupBox1.Controls.Add(this.check_ativo);
            this.groupBox1.Controls.Add(this.box_observacao);
            this.groupBox1.Controls.Add(this.lb_nome_cargo);
            this.groupBox1.Controls.Add(this.lb_observacao);
            this.groupBox1.Controls.Add(this.lb_status);
            this.groupBox1.Controls.Add(this.lb_codigo_cargo);
            this.groupBox1.Controls.Add(this.lb_data_cadastro);
            this.groupBox1.Location = new System.Drawing.Point(27, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(621, 269);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(260, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(271, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Todos os campos em negrito são obrigatórios!!";
            // 
            // box_nome_cargo
            // 
            this.box_nome_cargo.Location = new System.Drawing.Point(111, 40);
            this.box_nome_cargo.Name = "box_nome_cargo";
            this.box_nome_cargo.Size = new System.Drawing.Size(413, 20);
            this.box_nome_cargo.TabIndex = 9;
            // 
            // box_codigo_cargo
            // 
            this.box_codigo_cargo.Location = new System.Drawing.Point(111, 109);
            this.box_codigo_cargo.Name = "box_codigo_cargo";
            this.box_codigo_cargo.Size = new System.Drawing.Size(116, 20);
            this.box_codigo_cargo.TabIndex = 8;
            // 
            // check_ativo
            // 
            this.check_ativo.AutoSize = true;
            this.check_ativo.ForeColor = System.Drawing.Color.Black;
            this.check_ativo.Location = new System.Drawing.Point(469, 112);
            this.check_ativo.Name = "check_ativo";
            this.check_ativo.Size = new System.Drawing.Size(55, 17);
            this.check_ativo.TabIndex = 7;
            this.check_ativo.Text = "Ativo";
            this.check_ativo.UseVisualStyleBackColor = true;
            // 
            // bt_cadastrar
            // 
            this.bt_cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cadastrar.ForeColor = System.Drawing.Color.Black;
            this.bt_cadastrar.Location = new System.Drawing.Point(27, 320);
            this.bt_cadastrar.Name = "bt_cadastrar";
            this.bt_cadastrar.Size = new System.Drawing.Size(75, 23);
            this.bt_cadastrar.TabIndex = 8;
            this.bt_cadastrar.Text = "Cadastrar";
            this.bt_cadastrar.UseVisualStyleBackColor = true;
            this.bt_cadastrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_atualizar
            // 
            this.bt_atualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_atualizar.ForeColor = System.Drawing.Color.Black;
            this.bt_atualizar.Location = new System.Drawing.Point(138, 320);
            this.bt_atualizar.Name = "bt_atualizar";
            this.bt_atualizar.Size = new System.Drawing.Size(75, 23);
            this.bt_atualizar.TabIndex = 9;
            this.bt_atualizar.Text = "Atualizar";
            this.bt_atualizar.UseVisualStyleBackColor = true;
            this.bt_atualizar.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_excluir
            // 
            this.bt_excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_excluir.ForeColor = System.Drawing.Color.Black;
            this.bt_excluir.Location = new System.Drawing.Point(258, 319);
            this.bt_excluir.Name = "bt_excluir";
            this.bt_excluir.Size = new System.Drawing.Size(75, 23);
            this.bt_excluir.TabIndex = 10;
            this.bt_excluir.Text = "Excluir";
            this.bt_excluir.UseVisualStyleBackColor = true;
            this.bt_excluir.Click += new System.EventHandler(this.button3_Click);
            // 
            // bt_sair
            // 
            this.bt_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sair.ForeColor = System.Drawing.Color.Black;
            this.bt_sair.Location = new System.Drawing.Point(649, 0);
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.Size = new System.Drawing.Size(31, 28);
            this.bt_sair.TabIndex = 11;
            this.bt_sair.Text = "X";
            this.bt_sair.UseVisualStyleBackColor = true;
            this.bt_sair.Click += new System.EventHandler(this.button4_Click);
            // 
            // FormCargocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 350);
            this.Controls.Add(this.bt_sair);
            this.Controls.Add(this.bt_excluir);
            this.Controls.Add(this.bt_atualizar);
            this.Controls.Add(this.bt_cadastrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_cargo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCargocs";
            this.Text = " Papelaria Humanas";
            this.Load += new System.EventHandler(this.FormCargocs_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_codigo_cargo;
        private System.Windows.Forms.Label label_cargo;
        private System.Windows.Forms.Label lb_nome_cargo;
        private System.Windows.Forms.Label lb_status;
        private System.Windows.Forms.Label lb_observacao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bt_cadastrar;
        public System.Windows.Forms.Label lb_data_cadastro;
        public System.Windows.Forms.TextBox box_observacao;
        public System.Windows.Forms.CheckBox check_ativo;
        public System.Windows.Forms.TextBox box_codigo_cargo;
        public System.Windows.Forms.TextBox box_nome_cargo;
        private System.Windows.Forms.Button bt_atualizar;
        private System.Windows.Forms.Button bt_excluir;
        private System.Windows.Forms.Button bt_sair;
    }
}