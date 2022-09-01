namespace ProjetoPapelariaHumanas
{
    partial class FormConsultaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultaCliente));
            this.groupBox_cliente = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_cliente = new System.Windows.Forms.DataGridView();
            this.bt_sair = new System.Windows.Forms.Button();
            this.bt_pesquisar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_rg = new System.Windows.Forms.GroupBox();
            this.mask_rg = new System.Windows.Forms.MaskedTextBox();
            this.groupBox_pesquisanome = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radio_inicio = new System.Windows.Forms.RadioButton();
            this.box_nome = new System.Windows.Forms.TextBox();
            this.groupBox_cpf = new System.Windows.Forms.GroupBox();
            this.mask_cpf = new System.Windows.Forms.MaskedTextBox();
            this.groupBox_sexo = new System.Windows.Forms.GroupBox();
            this.radio_masculino = new System.Windows.Forms.RadioButton();
            this.radio_feminino = new System.Windows.Forms.RadioButton();
            this.groupBox_status = new System.Windows.Forms.GroupBox();
            this.radio_inativo = new System.Windows.Forms.RadioButton();
            this.radio_ativo = new System.Windows.Forms.RadioButton();
            this.combo_consulta = new System.Windows.Forms.ComboBox();
            this.groupBox_cliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cliente)).BeginInit();
            this.groupBox_rg.SuspendLayout();
            this.groupBox_pesquisanome.SuspendLayout();
            this.groupBox_cpf.SuspendLayout();
            this.groupBox_sexo.SuspendLayout();
            this.groupBox_status.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_cliente
            // 
            this.groupBox_cliente.Controls.Add(this.label2);
            this.groupBox_cliente.Controls.Add(this.bt_sair);
            this.groupBox_cliente.Controls.Add(this.dataGridView_cliente);
            this.groupBox_cliente.Controls.Add(this.bt_pesquisar);
            this.groupBox_cliente.Controls.Add(this.label1);
            this.groupBox_cliente.Controls.Add(this.groupBox_rg);
            this.groupBox_cliente.Controls.Add(this.groupBox_pesquisanome);
            this.groupBox_cliente.Controls.Add(this.box_nome);
            this.groupBox_cliente.Controls.Add(this.groupBox_cpf);
            this.groupBox_cliente.Controls.Add(this.groupBox_sexo);
            this.groupBox_cliente.Controls.Add(this.groupBox_status);
            this.groupBox_cliente.Controls.Add(this.combo_consulta);
            this.groupBox_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_cliente.Location = new System.Drawing.Point(12, 3);
            this.groupBox_cliente.Name = "groupBox_cliente";
            this.groupBox_cliente.Size = new System.Drawing.Size(655, 435);
            this.groupBox_cliente.TabIndex = 0;
            this.groupBox_cliente.TabStop = false;
            this.groupBox_cliente.Text = "Infromações do Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nome Cliente :";
            // 
            // dataGridView_cliente
            // 
            this.dataGridView_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_cliente.Location = new System.Drawing.Point(12, 232);
            this.dataGridView_cliente.MultiSelect = false;
            this.dataGridView_cliente.Name = "dataGridView_cliente";
            this.dataGridView_cliente.ReadOnly = true;
            this.dataGridView_cliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_cliente.Size = new System.Drawing.Size(637, 176);
            this.dataGridView_cliente.TabIndex = 10;
            this.dataGridView_cliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_cliente_CellContentClick);
            // 
            // bt_sair
            // 
            this.bt_sair.Location = new System.Drawing.Point(624, 9);
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.Size = new System.Drawing.Size(31, 28);
            this.bt_sair.TabIndex = 9;
            this.bt_sair.Text = "X";
            this.bt_sair.UseVisualStyleBackColor = true;
            this.bt_sair.Click += new System.EventHandler(this.bt_sair_Click);
            // 
            // bt_pesquisar
            // 
            this.bt_pesquisar.Image = ((System.Drawing.Image)(resources.GetObject("bt_pesquisar.Image")));
            this.bt_pesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_pesquisar.Location = new System.Drawing.Point(548, 43);
            this.bt_pesquisar.Name = "bt_pesquisar";
            this.bt_pesquisar.Size = new System.Drawing.Size(107, 42);
            this.bt_pesquisar.TabIndex = 8;
            this.bt_pesquisar.Text = "      Pesquisar";
            this.bt_pesquisar.UseVisualStyleBackColor = true;
            this.bt_pesquisar.Click += new System.EventHandler(this.bt_pesquisar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(216, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Para Alterar ou Excluir um cliente, Selecione na Grid!!";
            // 
            // groupBox_rg
            // 
            this.groupBox_rg.Controls.Add(this.mask_rg);
            this.groupBox_rg.Location = new System.Drawing.Point(12, 148);
            this.groupBox_rg.Name = "groupBox_rg";
            this.groupBox_rg.Size = new System.Drawing.Size(107, 51);
            this.groupBox_rg.TabIndex = 6;
            this.groupBox_rg.TabStop = false;
            this.groupBox_rg.Text = "RG";
            // 
            // mask_rg
            // 
            this.mask_rg.Location = new System.Drawing.Point(6, 19);
            this.mask_rg.Mask = "00,000,000-A";
            this.mask_rg.Name = "mask_rg";
            this.mask_rg.Size = new System.Drawing.Size(87, 20);
            this.mask_rg.TabIndex = 0;
            // 
            // groupBox_pesquisanome
            // 
            this.groupBox_pesquisanome.Controls.Add(this.radioButton1);
            this.groupBox_pesquisanome.Controls.Add(this.radio_inicio);
            this.groupBox_pesquisanome.Location = new System.Drawing.Point(398, 36);
            this.groupBox_pesquisanome.Name = "groupBox_pesquisanome";
            this.groupBox_pesquisanome.Size = new System.Drawing.Size(131, 41);
            this.groupBox_pesquisanome.TabIndex = 5;
            this.groupBox_pesquisanome.TabStop = false;
            this.groupBox_pesquisanome.Text = "Tipo de Pesquisa";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(64, 18);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(61, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Contém";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radio_inicio
            // 
            this.radio_inicio.AutoSize = true;
            this.radio_inicio.Location = new System.Drawing.Point(7, 18);
            this.radio_inicio.Name = "radio_inicio";
            this.radio_inicio.Size = new System.Drawing.Size(50, 17);
            this.radio_inicio.TabIndex = 0;
            this.radio_inicio.TabStop = true;
            this.radio_inicio.Text = "Inicio";
            this.radio_inicio.UseVisualStyleBackColor = true;
            // 
            // box_nome
            // 
            this.box_nome.Location = new System.Drawing.Point(205, 47);
            this.box_nome.Name = "box_nome";
            this.box_nome.Size = new System.Drawing.Size(187, 20);
            this.box_nome.TabIndex = 4;
            // 
            // groupBox_cpf
            // 
            this.groupBox_cpf.Controls.Add(this.mask_cpf);
            this.groupBox_cpf.Location = new System.Drawing.Point(398, 93);
            this.groupBox_cpf.Name = "groupBox_cpf";
            this.groupBox_cpf.Size = new System.Drawing.Size(131, 49);
            this.groupBox_cpf.TabIndex = 3;
            this.groupBox_cpf.TabStop = false;
            this.groupBox_cpf.Text = "CPF";
            // 
            // mask_cpf
            // 
            this.mask_cpf.Location = new System.Drawing.Point(6, 19);
            this.mask_cpf.Mask = "000,000,000-00";
            this.mask_cpf.Name = "mask_cpf";
            this.mask_cpf.Size = new System.Drawing.Size(100, 20);
            this.mask_cpf.TabIndex = 0;
            // 
            // groupBox_sexo
            // 
            this.groupBox_sexo.Controls.Add(this.radio_masculino);
            this.groupBox_sexo.Controls.Add(this.radio_feminino);
            this.groupBox_sexo.Location = new System.Drawing.Point(6, 93);
            this.groupBox_sexo.Name = "groupBox_sexo";
            this.groupBox_sexo.Size = new System.Drawing.Size(187, 50);
            this.groupBox_sexo.TabIndex = 2;
            this.groupBox_sexo.TabStop = false;
            this.groupBox_sexo.Text = "Sexo";
            // 
            // radio_masculino
            // 
            this.radio_masculino.AutoSize = true;
            this.radio_masculino.Location = new System.Drawing.Point(79, 19);
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
            this.radio_feminino.Location = new System.Drawing.Point(6, 19);
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
            this.groupBox_status.Location = new System.Drawing.Point(219, 93);
            this.groupBox_status.Name = "groupBox_status";
            this.groupBox_status.Size = new System.Drawing.Size(130, 49);
            this.groupBox_status.TabIndex = 1;
            this.groupBox_status.TabStop = false;
            this.groupBox_status.Text = "Status";
            // 
            // radio_inativo
            // 
            this.radio_inativo.AutoSize = true;
            this.radio_inativo.Location = new System.Drawing.Point(61, 19);
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
            this.radio_ativo.Location = new System.Drawing.Point(6, 18);
            this.radio_ativo.Name = "radio_ativo";
            this.radio_ativo.Size = new System.Drawing.Size(49, 17);
            this.radio_ativo.TabIndex = 0;
            this.radio_ativo.TabStop = true;
            this.radio_ativo.Text = "Ativo";
            this.radio_ativo.UseVisualStyleBackColor = true;
            // 
            // combo_consulta
            // 
            this.combo_consulta.FormattingEnabled = true;
            this.combo_consulta.Location = new System.Drawing.Point(6, 46);
            this.combo_consulta.Name = "combo_consulta";
            this.combo_consulta.Size = new System.Drawing.Size(121, 21);
            this.combo_consulta.TabIndex = 0;
            this.combo_consulta.SelectedIndexChanged += new System.EventHandler(this.combo_consulta_SelectedIndexChanged);
            // 
            // FormConsultaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 450);
            this.Controls.Add(this.groupBox_cliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormConsultaCliente";
            this.Text = "Consultar Cliente";
            this.Load += new System.EventHandler(this.FormConsultaCliente_Load);
            this.groupBox_cliente.ResumeLayout(false);
            this.groupBox_cliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cliente)).EndInit();
            this.groupBox_rg.ResumeLayout(false);
            this.groupBox_rg.PerformLayout();
            this.groupBox_pesquisanome.ResumeLayout(false);
            this.groupBox_pesquisanome.PerformLayout();
            this.groupBox_cpf.ResumeLayout(false);
            this.groupBox_cpf.PerformLayout();
            this.groupBox_sexo.ResumeLayout(false);
            this.groupBox_sexo.PerformLayout();
            this.groupBox_status.ResumeLayout(false);
            this.groupBox_status.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_cliente;
        private System.Windows.Forms.GroupBox groupBox_cpf;
        private System.Windows.Forms.MaskedTextBox mask_cpf;
        private System.Windows.Forms.GroupBox groupBox_sexo;
        private System.Windows.Forms.RadioButton radio_masculino;
        private System.Windows.Forms.RadioButton radio_feminino;
        private System.Windows.Forms.GroupBox groupBox_status;
        private System.Windows.Forms.RadioButton radio_inativo;
        private System.Windows.Forms.RadioButton radio_ativo;
        private System.Windows.Forms.ComboBox combo_consulta;
        private System.Windows.Forms.GroupBox groupBox_pesquisanome;
        private System.Windows.Forms.TextBox box_nome;
        private System.Windows.Forms.GroupBox groupBox_rg;
        private System.Windows.Forms.MaskedTextBox mask_rg;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radio_inicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_sair;
        private System.Windows.Forms.Button bt_pesquisar;
        private System.Windows.Forms.DataGridView dataGridView_cliente;
        private System.Windows.Forms.Label label2;
    }
}