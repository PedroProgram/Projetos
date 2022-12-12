namespace ProjetoPapelariaHumanas
{
    partial class FormConsultaFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultaFuncionario));
            this.bt_sair = new System.Windows.Forms.Button();
            this.bt_pesquisar = new System.Windows.Forms.Button();
            this.combo_pesquisa_funcionario = new System.Windows.Forms.ComboBox();
            this.combo_c = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView_funcionario = new System.Windows.Forms.DataGridView();
            this.groupBox_sexo = new System.Windows.Forms.GroupBox();
            this.radio_masculino = new System.Windows.Forms.RadioButton();
            this.radio_feminino = new System.Windows.Forms.RadioButton();
            this.groupBox_status = new System.Windows.Forms.GroupBox();
            this.radio_inativo = new System.Windows.Forms.RadioButton();
            this.radio_ativo = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.box_nome_fun = new System.Windows.Forms.TextBox();
            this.groupBoox_tipopesquisa = new System.Windows.Forms.GroupBox();
            this.radio_contem = new System.Windows.Forms.RadioButton();
            this.radio_inicio = new System.Windows.Forms.RadioButton();
            this.groupBox_cargo = new System.Windows.Forms.GroupBox();
            this.groupBox_cpf = new System.Windows.Forms.GroupBox();
            this.mask_cpf = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_ajuda = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_funcionario)).BeginInit();
            this.groupBox_sexo.SuspendLayout();
            this.groupBox_status.SuspendLayout();
            this.groupBoox_tipopesquisa.SuspendLayout();
            this.groupBox_cargo.SuspendLayout();
            this.groupBox_cpf.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_sair
            // 
            this.bt_sair.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bt_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.bt_sair.Location = new System.Drawing.Point(720, -4);
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.Size = new System.Drawing.Size(31, 28);
            this.bt_sair.TabIndex = 0;
            this.bt_sair.Text = "X";
            this.bt_sair.UseVisualStyleBackColor = false;
            this.bt_sair.Click += new System.EventHandler(this.bt_sair_Click);
            // 
            // bt_pesquisar
            // 
            this.bt_pesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.bt_pesquisar.Image = ((System.Drawing.Image)(resources.GetObject("bt_pesquisar.Image")));
            this.bt_pesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_pesquisar.Location = new System.Drawing.Point(572, 19);
            this.bt_pesquisar.Name = "bt_pesquisar";
            this.bt_pesquisar.Size = new System.Drawing.Size(130, 55);
            this.bt_pesquisar.TabIndex = 1;
            this.bt_pesquisar.Text = "    Pesquisar";
            this.bt_pesquisar.UseVisualStyleBackColor = false;
            this.bt_pesquisar.Click += new System.EventHandler(this.bt_pesquisar_Click);
            // 
            // combo_pesquisa_funcionario
            // 
            this.combo_pesquisa_funcionario.BackColor = System.Drawing.Color.AliceBlue;
            this.combo_pesquisa_funcionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_pesquisa_funcionario.FormattingEnabled = true;
            this.combo_pesquisa_funcionario.Location = new System.Drawing.Point(6, 35);
            this.combo_pesquisa_funcionario.Name = "combo_pesquisa_funcionario";
            this.combo_pesquisa_funcionario.Size = new System.Drawing.Size(180, 21);
            this.combo_pesquisa_funcionario.TabIndex = 2;
            this.combo_pesquisa_funcionario.SelectedIndexChanged += new System.EventHandler(this.combo_pesquisa_SelectedIndexChanged);
            // 
            // combo_c
            // 
            this.combo_c.BackColor = System.Drawing.Color.AliceBlue;
            this.combo_c.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_c.FormattingEnabled = true;
            this.combo_c.Location = new System.Drawing.Point(23, 24);
            this.combo_c.Name = "combo_c";
            this.combo_c.Size = new System.Drawing.Size(121, 21);
            this.combo_c.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView_funcionario);
            this.groupBox1.Controls.Add(this.groupBox_sexo);
            this.groupBox1.Controls.Add(this.groupBox_status);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.box_nome_fun);
            this.groupBox1.Controls.Add(this.groupBoox_tipopesquisa);
            this.groupBox1.Controls.Add(this.groupBox_cargo);
            this.groupBox1.Controls.Add(this.groupBox_cpf);
            this.groupBox1.Controls.Add(this.combo_pesquisa_funcionario);
            this.groupBox1.Controls.Add(this.bt_pesquisar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(708, 412);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações do Funcionário";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridView_funcionario
            // 
            this.dataGridView_funcionario.AllowUserToAddRows = false;
            this.dataGridView_funcionario.AllowUserToDeleteRows = false;
            this.dataGridView_funcionario.AllowUserToResizeColumns = false;
            this.dataGridView_funcionario.AllowUserToResizeRows = false;
            this.dataGridView_funcionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_funcionario.Location = new System.Drawing.Point(6, 156);
            this.dataGridView_funcionario.MultiSelect = false;
            this.dataGridView_funcionario.Name = "dataGridView_funcionario";
            this.dataGridView_funcionario.ReadOnly = true;
            this.dataGridView_funcionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_funcionario.Size = new System.Drawing.Size(696, 250);
            this.dataGridView_funcionario.TabIndex = 12;
            this.dataGridView_funcionario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_funcionario_CellClick);
            // 
            // groupBox_sexo
            // 
            this.groupBox_sexo.Controls.Add(this.radio_masculino);
            this.groupBox_sexo.Controls.Add(this.radio_feminino);
            this.groupBox_sexo.Location = new System.Drawing.Point(6, 88);
            this.groupBox_sexo.Name = "groupBox_sexo";
            this.groupBox_sexo.Size = new System.Drawing.Size(165, 62);
            this.groupBox_sexo.TabIndex = 11;
            this.groupBox_sexo.TabStop = false;
            this.groupBox_sexo.Text = "Sexo";
            // 
            // radio_masculino
            // 
            this.radio_masculino.AutoSize = true;
            this.radio_masculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_masculino.Location = new System.Drawing.Point(88, 24);
            this.radio_masculino.Name = "radio_masculino";
            this.radio_masculino.Size = new System.Drawing.Size(73, 17);
            this.radio_masculino.TabIndex = 1;
            this.radio_masculino.TabStop = true;
            this.radio_masculino.Text = "Masculino";
            this.radio_masculino.UseVisualStyleBackColor = true;
            // 
            // radio_feminino
            // 
            this.radio_feminino.AutoSize = true;
            this.radio_feminino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_feminino.Location = new System.Drawing.Point(14, 24);
            this.radio_feminino.Name = "radio_feminino";
            this.radio_feminino.Size = new System.Drawing.Size(67, 17);
            this.radio_feminino.TabIndex = 0;
            this.radio_feminino.TabStop = true;
            this.radio_feminino.Text = "Feminino";
            this.radio_feminino.UseVisualStyleBackColor = true;
            // 
            // groupBox_status
            // 
            this.groupBox_status.Controls.Add(this.radio_inativo);
            this.groupBox_status.Controls.Add(this.radio_ativo);
            this.groupBox_status.Location = new System.Drawing.Point(377, 88);
            this.groupBox_status.Name = "groupBox_status";
            this.groupBox_status.Size = new System.Drawing.Size(138, 62);
            this.groupBox_status.TabIndex = 10;
            this.groupBox_status.TabStop = false;
            this.groupBox_status.Text = "Status";
            // 
            // radio_inativo
            // 
            this.radio_inativo.AutoSize = true;
            this.radio_inativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_inativo.Location = new System.Drawing.Point(71, 24);
            this.radio_inativo.Name = "radio_inativo";
            this.radio_inativo.Size = new System.Drawing.Size(57, 17);
            this.radio_inativo.TabIndex = 1;
            this.radio_inativo.TabStop = true;
            this.radio_inativo.Text = "Inativo";
            this.radio_inativo.UseVisualStyleBackColor = true;
            // 
            // radio_ativo
            // 
            this.radio_ativo.AutoSize = true;
            this.radio_ativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_ativo.Location = new System.Drawing.Point(13, 24);
            this.radio_ativo.Name = "radio_ativo";
            this.radio_ativo.Size = new System.Drawing.Size(49, 17);
            this.radio_ativo.TabIndex = 0;
            this.radio_ativo.TabStop = true;
            this.radio_ativo.Text = "Ativo";
            this.radio_ativo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nome :";
            // 
            // box_nome_fun
            // 
            this.box_nome_fun.BackColor = System.Drawing.Color.AliceBlue;
            this.box_nome_fun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_nome_fun.Location = new System.Drawing.Point(238, 35);
            this.box_nome_fun.MaxLength = 30;
            this.box_nome_fun.Name = "box_nome_fun";
            this.box_nome_fun.Size = new System.Drawing.Size(191, 20);
            this.box_nome_fun.TabIndex = 8;
            // 
            // groupBoox_tipopesquisa
            // 
            this.groupBoox_tipopesquisa.Controls.Add(this.radio_contem);
            this.groupBoox_tipopesquisa.Controls.Add(this.radio_inicio);
            this.groupBoox_tipopesquisa.Location = new System.Drawing.Point(438, 19);
            this.groupBoox_tipopesquisa.Name = "groupBoox_tipopesquisa";
            this.groupBoox_tipopesquisa.Size = new System.Drawing.Size(128, 46);
            this.groupBoox_tipopesquisa.TabIndex = 5;
            this.groupBoox_tipopesquisa.TabStop = false;
            this.groupBoox_tipopesquisa.Text = "Tipo de Pesquisa";
            // 
            // radio_contem
            // 
            this.radio_contem.AutoSize = true;
            this.radio_contem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_contem.Location = new System.Drawing.Point(61, 19);
            this.radio_contem.Name = "radio_contem";
            this.radio_contem.Size = new System.Drawing.Size(61, 17);
            this.radio_contem.TabIndex = 1;
            this.radio_contem.TabStop = true;
            this.radio_contem.Text = "Contém";
            this.radio_contem.UseVisualStyleBackColor = true;
            // 
            // radio_inicio
            // 
            this.radio_inicio.AutoSize = true;
            this.radio_inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_inicio.Location = new System.Drawing.Point(6, 19);
            this.radio_inicio.Name = "radio_inicio";
            this.radio_inicio.Size = new System.Drawing.Size(50, 17);
            this.radio_inicio.TabIndex = 0;
            this.radio_inicio.TabStop = true;
            this.radio_inicio.Text = "Inicio";
            this.radio_inicio.UseVisualStyleBackColor = true;
            // 
            // groupBox_cargo
            // 
            this.groupBox_cargo.Controls.Add(this.combo_c);
            this.groupBox_cargo.Location = new System.Drawing.Point(194, 88);
            this.groupBox_cargo.Name = "groupBox_cargo";
            this.groupBox_cargo.Size = new System.Drawing.Size(165, 62);
            this.groupBox_cargo.TabIndex = 7;
            this.groupBox_cargo.TabStop = false;
            this.groupBox_cargo.Text = "Selecione o Cargo";
            // 
            // groupBox_cpf
            // 
            this.groupBox_cpf.Controls.Add(this.mask_cpf);
            this.groupBox_cpf.Location = new System.Drawing.Point(554, 88);
            this.groupBox_cpf.Name = "groupBox_cpf";
            this.groupBox_cpf.Size = new System.Drawing.Size(133, 62);
            this.groupBox_cpf.TabIndex = 6;
            this.groupBox_cpf.TabStop = false;
            this.groupBox_cpf.Text = "CPF";
            // 
            // mask_cpf
            // 
            this.mask_cpf.BackColor = System.Drawing.Color.AliceBlue;
            this.mask_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mask_cpf.Location = new System.Drawing.Point(23, 24);
            this.mask_cpf.Mask = "000,000,000-00";
            this.mask_cpf.Name = "mask_cpf";
            this.mask_cpf.Size = new System.Drawing.Size(93, 20);
            this.mask_cpf.TabIndex = 0;
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
            this.bt_ajuda.Location = new System.Drawing.Point(695, 0);
            this.bt_ajuda.Name = "bt_ajuda";
            this.bt_ajuda.Size = new System.Drawing.Size(19, 19);
            this.bt_ajuda.Style = MetroFramework.MetroColorStyle.Silver;
            this.bt_ajuda.TabIndex = 44;
            this.bt_ajuda.Text = " ?";
            this.bt_ajuda.UseSelectable = true;
            this.bt_ajuda.Click += new System.EventHandler(this.bt_ajuda_Click);
            // 
            // FormConsultaFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(747, 450);
            this.Controls.Add(this.bt_ajuda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_sair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormConsultaFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormConsularFuncionario";
            this.Load += new System.EventHandler(this.FormConsularFuncionario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_funcionario)).EndInit();
            this.groupBox_sexo.ResumeLayout(false);
            this.groupBox_sexo.PerformLayout();
            this.groupBox_status.ResumeLayout(false);
            this.groupBox_status.PerformLayout();
            this.groupBoox_tipopesquisa.ResumeLayout(false);
            this.groupBoox_tipopesquisa.PerformLayout();
            this.groupBox_cargo.ResumeLayout(false);
            this.groupBox_cpf.ResumeLayout(false);
            this.groupBox_cpf.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_sair;
        private System.Windows.Forms.Button bt_pesquisar;
        private System.Windows.Forms.ComboBox combo_pesquisa_funcionario;
        private System.Windows.Forms.ComboBox combo_c;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoox_tipopesquisa;
        private System.Windows.Forms.GroupBox groupBox_cargo;
        private System.Windows.Forms.GroupBox groupBox_cpf;
        private System.Windows.Forms.TextBox box_nome_fun;
        private System.Windows.Forms.RadioButton radio_contem;
        private System.Windows.Forms.RadioButton radio_inicio;
        private System.Windows.Forms.MaskedTextBox mask_cpf;
        private System.Windows.Forms.GroupBox groupBox_status;
        private System.Windows.Forms.RadioButton radio_inativo;
        private System.Windows.Forms.RadioButton radio_ativo;
        private System.Windows.Forms.DataGridView dataGridView_funcionario;
        private System.Windows.Forms.GroupBox groupBox_sexo;
        private System.Windows.Forms.RadioButton radio_masculino;
        private System.Windows.Forms.RadioButton radio_feminino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroButton bt_ajuda;
    }
}