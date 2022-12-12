
namespace ProjetoPapelariaHumanas
{
    partial class FormCargo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCargo));
            this.lb_data_cadastro = new System.Windows.Forms.Label();
            this.lb_codigo_cargo = new System.Windows.Forms.Label();
            this.label_cargo = new System.Windows.Forms.Label();
            this.lb_nome_cargo = new System.Windows.Forms.Label();
            this.lb_status = new System.Windows.Forms.Label();
            this.lb_observacao = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.box_observacao = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_data = new System.Windows.Forms.Label();
            this.box_codigo_cargo = new System.Windows.Forms.TextBox();
            this.check_ativo = new System.Windows.Forms.CheckBox();
            this.box_nome_cargo = new System.Windows.Forms.TextBox();
            this.bt_cadastrar = new System.Windows.Forms.Button();
            this.bt_atualizar = new System.Windows.Forms.Button();
            this.bt_excluir = new System.Windows.Forms.Button();
            this.bt_sair = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.bt_ajuda = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_data_cadastro
            // 
            this.lb_data_cadastro.AutoSize = true;
            this.lb_data_cadastro.Enabled = false;
            this.lb_data_cadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_data_cadastro.ForeColor = System.Drawing.Color.Black;
            this.lb_data_cadastro.Location = new System.Drawing.Point(372, 19);
            this.lb_data_cadastro.Name = "lb_data_cadastro";
            this.lb_data_cadastro.Size = new System.Drawing.Size(30, 13);
            this.lb_data_cadastro.TabIndex = 0;
            this.lb_data_cadastro.Text = "Data";
            // 
            // lb_codigo_cargo
            // 
            this.lb_codigo_cargo.AutoSize = true;
            this.lb_codigo_cargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_codigo_cargo.ForeColor = System.Drawing.Color.Black;
            this.lb_codigo_cargo.Location = new System.Drawing.Point(16, 19);
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
            this.label_cargo.Location = new System.Drawing.Point(231, 13);
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
            this.lb_nome_cargo.Location = new System.Drawing.Point(20, 44);
            this.lb_nome_cargo.Name = "lb_nome_cargo";
            this.lb_nome_cargo.Size = new System.Drawing.Size(93, 13);
            this.lb_nome_cargo.TabIndex = 3;
            this.lb_nome_cargo.Text = "* Nome Cargo :";
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_status.ForeColor = System.Drawing.Color.Black;
            this.lb_status.Location = new System.Drawing.Point(473, 19);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(51, 13);
            this.lb_status.TabIndex = 4;
            this.lb_status.Text = "Status :";
            // 
            // lb_observacao
            // 
            this.lb_observacao.AutoSize = true;
            this.lb_observacao.ForeColor = System.Drawing.Color.Black;
            this.lb_observacao.Location = new System.Drawing.Point(20, 162);
            this.lb_observacao.Name = "lb_observacao";
            this.lb_observacao.Size = new System.Drawing.Size(83, 13);
            this.lb_observacao.TabIndex = 5;
            this.lb_observacao.Text = "Observação :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.box_observacao);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.box_nome_cargo);
            this.groupBox1.Controls.Add(this.lb_nome_cargo);
            this.groupBox1.Controls.Add(this.lb_observacao);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(621, 262);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações";
            // 
            // box_observacao
            // 
            this.box_observacao.BackColor = System.Drawing.Color.AliceBlue;
            this.box_observacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_observacao.Location = new System.Drawing.Point(124, 141);
            this.box_observacao.MaxLength = 60;
            this.box_observacao.Multiline = true;
            this.box_observacao.Name = "box_observacao";
            this.box_observacao.Size = new System.Drawing.Size(491, 107);
            this.box_observacao.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb_data);
            this.groupBox2.Controls.Add(this.box_codigo_cargo);
            this.groupBox2.Controls.Add(this.lb_data_cadastro);
            this.groupBox2.Controls.Add(this.lb_codigo_cargo);
            this.groupBox2.Controls.Add(this.lb_status);
            this.groupBox2.Controls.Add(this.check_ativo);
            this.groupBox2.Location = new System.Drawing.Point(4, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(609, 49);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // lb_data
            // 
            this.lb_data.AutoSize = true;
            this.lb_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_data.ForeColor = System.Drawing.Color.Black;
            this.lb_data.Location = new System.Drawing.Point(263, 19);
            this.lb_data.Name = "lb_data";
            this.lb_data.Size = new System.Drawing.Size(42, 13);
            this.lb_data.TabIndex = 9;
            this.lb_data.Text = "Data :";
            // 
            // box_codigo_cargo
            // 
            this.box_codigo_cargo.BackColor = System.Drawing.Color.AliceBlue;
            this.box_codigo_cargo.Enabled = false;
            this.box_codigo_cargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_codigo_cargo.Location = new System.Drawing.Point(120, 16);
            this.box_codigo_cargo.Name = "box_codigo_cargo";
            this.box_codigo_cargo.Size = new System.Drawing.Size(116, 20);
            this.box_codigo_cargo.TabIndex = 8;
            // 
            // check_ativo
            // 
            this.check_ativo.AutoSize = true;
            this.check_ativo.Enabled = false;
            this.check_ativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_ativo.ForeColor = System.Drawing.Color.Black;
            this.check_ativo.Location = new System.Drawing.Point(542, 18);
            this.check_ativo.Name = "check_ativo";
            this.check_ativo.Size = new System.Drawing.Size(50, 17);
            this.check_ativo.TabIndex = 7;
            this.check_ativo.Text = "Ativo";
            this.check_ativo.UseVisualStyleBackColor = true;
            // 
            // box_nome_cargo
            // 
            this.box_nome_cargo.BackColor = System.Drawing.Color.AliceBlue;
            this.box_nome_cargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_nome_cargo.Location = new System.Drawing.Point(124, 41);
            this.box_nome_cargo.MaxLength = 30;
            this.box_nome_cargo.Name = "box_nome_cargo";
            this.box_nome_cargo.Size = new System.Drawing.Size(472, 20);
            this.box_nome_cargo.TabIndex = 9;
            // 
            // bt_cadastrar
            // 
            this.bt_cadastrar.ForeColor = System.Drawing.Color.Black;
            this.bt_cadastrar.Image = ((System.Drawing.Image)(resources.GetObject("bt_cadastrar.Image")));
            this.bt_cadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_cadastrar.Location = new System.Drawing.Point(12, 306);
            this.bt_cadastrar.Name = "bt_cadastrar";
            this.bt_cadastrar.Size = new System.Drawing.Size(103, 41);
            this.bt_cadastrar.TabIndex = 8;
            this.bt_cadastrar.Text = "        Cadastrar";
            this.bt_cadastrar.UseVisualStyleBackColor = false;
            this.bt_cadastrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_atualizar
            // 
            this.bt_atualizar.ForeColor = System.Drawing.Color.Black;
            this.bt_atualizar.Image = ((System.Drawing.Image)(resources.GetObject("bt_atualizar.Image")));
            this.bt_atualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_atualizar.Location = new System.Drawing.Point(267, 306);
            this.bt_atualizar.Name = "bt_atualizar";
            this.bt_atualizar.Size = new System.Drawing.Size(103, 41);
            this.bt_atualizar.TabIndex = 9;
            this.bt_atualizar.Text = "      Atualizar";
            this.bt_atualizar.UseVisualStyleBackColor = false;
            this.bt_atualizar.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_excluir
            // 
            this.bt_excluir.ForeColor = System.Drawing.Color.Black;
            this.bt_excluir.Image = ((System.Drawing.Image)(resources.GetObject("bt_excluir.Image")));
            this.bt_excluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_excluir.Location = new System.Drawing.Point(530, 306);
            this.bt_excluir.Name = "bt_excluir";
            this.bt_excluir.Size = new System.Drawing.Size(103, 41);
            this.bt_excluir.TabIndex = 10;
            this.bt_excluir.Text = "    Excluir";
            this.bt_excluir.UseVisualStyleBackColor = false;
            this.bt_excluir.Click += new System.EventHandler(this.button3_Click);
            // 
            // bt_sair
            // 
            this.bt_sair.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bt_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sair.ForeColor = System.Drawing.Color.Black;
            this.bt_sair.Location = new System.Drawing.Point(622, -4);
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.Size = new System.Drawing.Size(31, 28);
            this.bt_sair.TabIndex = 11;
            this.bt_sair.Text = "X";
            this.bt_sair.UseVisualStyleBackColor = false;
            this.bt_sair.Click += new System.EventHandler(this.button4_Click);
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
            this.label5.TabIndex = 18;
            this.label5.Text = "Sistema Papelaria Humanas";
            // 
            // bt_ajuda
            // 
            this.bt_ajuda.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_ajuda.Location = new System.Drawing.Point(597, -1);
            this.bt_ajuda.Name = "bt_ajuda";
            this.bt_ajuda.Size = new System.Drawing.Size(19, 19);
            this.bt_ajuda.Style = MetroFramework.MetroColorStyle.Silver;
            this.bt_ajuda.TabIndex = 19;
            this.bt_ajuda.Text = " ?";
            this.bt_ajuda.UseSelectable = true;
            this.bt_ajuda.Click += new System.EventHandler(this.bt_ajuda_Click);
            // 
            // FormCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(649, 350);
            this.Controls.Add(this.bt_ajuda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bt_sair);
            this.Controls.Add(this.bt_excluir);
            this.Controls.Add(this.bt_atualizar);
            this.Controls.Add(this.bt_cadastrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_cargo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCargo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Papelaria Humanas";
            this.Load += new System.EventHandler(this.FormCargocs_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.Button bt_cadastrar;
        public System.Windows.Forms.Label lb_data_cadastro;
        public System.Windows.Forms.CheckBox check_ativo;
        public System.Windows.Forms.TextBox box_codigo_cargo;
        public System.Windows.Forms.TextBox box_nome_cargo;
        private System.Windows.Forms.Button bt_atualizar;
        private System.Windows.Forms.Button bt_excluir;
        private System.Windows.Forms.Button bt_sair;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        public System.Windows.Forms.TextBox box_observacao;
        private System.Windows.Forms.Label lb_data;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroButton bt_ajuda;
    }
}