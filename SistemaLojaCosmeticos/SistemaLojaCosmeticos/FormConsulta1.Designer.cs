namespace SistemaLojaCosmeticos
{
    partial class FormConsulta1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsulta1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView_Consulta = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_sair = new System.Windows.Forms.Button();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.groupBoxpesquisa = new System.Windows.Forms.GroupBox();
            this.radioButtoncontem = new System.Windows.Forms.RadioButton();
            this.radio_inicio = new System.Windows.Forms.RadioButton();
            this.box_nome = new System.Windows.Forms.TextBox();
            this.groupBoxcpf = new System.Windows.Forms.GroupBox();
            this.mask_cep = new System.Windows.Forms.MaskedTextBox();
            this.groupBoxstatus = new System.Windows.Forms.GroupBox();
            this.radioButton_inativo = new System.Windows.Forms.RadioButton();
            this.radioButton_ativo = new System.Windows.Forms.RadioButton();
            this.groupBoxSexo = new System.Windows.Forms.GroupBox();
            this.radioButton_masculino = new System.Windows.Forms.RadioButton();
            this.radioButton_Feminino = new System.Windows.Forms.RadioButton();
            this.combo_opcoes = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Consulta)).BeginInit();
            this.groupBoxpesquisa.SuspendLayout();
            this.groupBoxcpf.SuspendLayout();
            this.groupBoxstatus.SuspendLayout();
            this.groupBoxSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView_Consulta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bt_sair);
            this.groupBox1.Controls.Add(this.btPesquisar);
            this.groupBox1.Controls.Add(this.groupBoxpesquisa);
            this.groupBox1.Controls.Add(this.box_nome);
            this.groupBox1.Controls.Add(this.groupBoxcpf);
            this.groupBox1.Controls.Add(this.groupBoxstatus);
            this.groupBox1.Controls.Add(this.groupBoxSexo);
            this.groupBox1.Controls.Add(this.combo_opcoes);
            this.groupBox1.Location = new System.Drawing.Point(2, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(742, 486);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione um tipo de Consulta";
            // 
            // dataGridView_Consulta
            // 
            this.dataGridView_Consulta.AllowUserToAddRows = false;
            this.dataGridView_Consulta.AllowUserToDeleteRows = false;
            this.dataGridView_Consulta.AllowUserToResizeColumns = false;
            this.dataGridView_Consulta.AllowUserToResizeRows = false;
            this.dataGridView_Consulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Consulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Consulta.Location = new System.Drawing.Point(35, 214);
            this.dataGridView_Consulta.MultiSelect = false;
            this.dataGridView_Consulta.Name = "dataGridView_Consulta";
            this.dataGridView_Consulta.ReadOnly = true;
            this.dataGridView_Consulta.RowHeadersVisible = false;
            this.dataGridView_Consulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Consulta.Size = new System.Drawing.Size(673, 252);
            this.dataGridView_Consulta.TabIndex = 9;
            this.dataGridView_Consulta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Consulta_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(143, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Para Alterar ou Excluir um cliente, Selecione na Grid!!";
            // 
            // bt_sair
            // 
            this.bt_sair.Image = ((System.Drawing.Image)(resources.GetObject("bt_sair.Image")));
            this.bt_sair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_sair.Location = new System.Drawing.Point(574, 170);
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.Size = new System.Drawing.Size(134, 38);
            this.bt_sair.TabIndex = 7;
            this.bt_sair.Text = "Sair";
            this.bt_sair.UseVisualStyleBackColor = true;
            // 
            // btPesquisar
            // 
            this.btPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btPesquisar.Image")));
            this.btPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPesquisar.Location = new System.Drawing.Point(574, 100);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(134, 42);
            this.btPesquisar.TabIndex = 6;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // groupBoxpesquisa
            // 
            this.groupBoxpesquisa.Controls.Add(this.radioButtoncontem);
            this.groupBoxpesquisa.Controls.Add(this.radio_inicio);
            this.groupBoxpesquisa.Location = new System.Drawing.Point(556, 32);
            this.groupBoxpesquisa.Name = "groupBoxpesquisa";
            this.groupBoxpesquisa.Size = new System.Drawing.Size(152, 43);
            this.groupBoxpesquisa.TabIndex = 5;
            this.groupBoxpesquisa.TabStop = false;
            this.groupBoxpesquisa.Text = "Tipo de Pesquisa";
            // 
            // radioButtoncontem
            // 
            this.radioButtoncontem.AutoSize = true;
            this.radioButtoncontem.Location = new System.Drawing.Point(63, 19);
            this.radioButtoncontem.Name = "radioButtoncontem";
            this.radioButtoncontem.Size = new System.Drawing.Size(61, 17);
            this.radioButtoncontem.TabIndex = 1;
            this.radioButtoncontem.TabStop = true;
            this.radioButtoncontem.Text = "Contém";
            this.radioButtoncontem.UseVisualStyleBackColor = true;
            // 
            // radio_inicio
            // 
            this.radio_inicio.AutoSize = true;
            this.radio_inicio.Location = new System.Drawing.Point(7, 20);
            this.radio_inicio.Name = "radio_inicio";
            this.radio_inicio.Size = new System.Drawing.Size(50, 17);
            this.radio_inicio.TabIndex = 0;
            this.radio_inicio.TabStop = true;
            this.radio_inicio.Text = "Inicio";
            this.radio_inicio.UseVisualStyleBackColor = true;
            // 
            // box_nome
            // 
            this.box_nome.Location = new System.Drawing.Point(162, 44);
            this.box_nome.Name = "box_nome";
            this.box_nome.Size = new System.Drawing.Size(377, 20);
            this.box_nome.TabIndex = 4;
            // 
            // groupBoxcpf
            // 
            this.groupBoxcpf.Controls.Add(this.mask_cep);
            this.groupBoxcpf.Location = new System.Drawing.Point(421, 102);
            this.groupBoxcpf.Name = "groupBoxcpf";
            this.groupBoxcpf.Size = new System.Drawing.Size(124, 41);
            this.groupBoxcpf.TabIndex = 3;
            this.groupBoxcpf.TabStop = false;
            this.groupBoxcpf.Text = "CPF";
            // 
            // mask_cep
            // 
            this.mask_cep.Location = new System.Drawing.Point(6, 17);
            this.mask_cep.Mask = "000,000,000-00";
            this.mask_cep.Name = "mask_cep";
            this.mask_cep.Size = new System.Drawing.Size(112, 20);
            this.mask_cep.TabIndex = 0;
            // 
            // groupBoxstatus
            // 
            this.groupBoxstatus.Controls.Add(this.radioButton_inativo);
            this.groupBoxstatus.Controls.Add(this.radioButton_ativo);
            this.groupBoxstatus.Location = new System.Drawing.Point(232, 101);
            this.groupBoxstatus.Name = "groupBoxstatus";
            this.groupBoxstatus.Size = new System.Drawing.Size(159, 42);
            this.groupBoxstatus.TabIndex = 2;
            this.groupBoxstatus.TabStop = false;
            this.groupBoxstatus.Text = "Status";
            // 
            // radioButton_inativo
            // 
            this.radioButton_inativo.AutoSize = true;
            this.radioButton_inativo.Location = new System.Drawing.Point(77, 19);
            this.radioButton_inativo.Name = "radioButton_inativo";
            this.radioButton_inativo.Size = new System.Drawing.Size(57, 17);
            this.radioButton_inativo.TabIndex = 1;
            this.radioButton_inativo.TabStop = true;
            this.radioButton_inativo.Text = "Inativo";
            this.radioButton_inativo.UseVisualStyleBackColor = true;
            // 
            // radioButton_ativo
            // 
            this.radioButton_ativo.AutoSize = true;
            this.radioButton_ativo.Location = new System.Drawing.Point(6, 18);
            this.radioButton_ativo.Name = "radioButton_ativo";
            this.radioButton_ativo.Size = new System.Drawing.Size(49, 17);
            this.radioButton_ativo.TabIndex = 0;
            this.radioButton_ativo.TabStop = true;
            this.radioButton_ativo.Text = "Ativo";
            this.radioButton_ativo.UseVisualStyleBackColor = true;
            // 
            // groupBoxSexo
            // 
            this.groupBoxSexo.Controls.Add(this.radioButton_masculino);
            this.groupBoxSexo.Controls.Add(this.radioButton_Feminino);
            this.groupBoxSexo.Location = new System.Drawing.Point(11, 100);
            this.groupBoxSexo.Name = "groupBoxSexo";
            this.groupBoxSexo.Size = new System.Drawing.Size(204, 42);
            this.groupBoxSexo.TabIndex = 1;
            this.groupBoxSexo.TabStop = false;
            this.groupBoxSexo.Text = "Sexo";
            // 
            // radioButton_masculino
            // 
            this.radioButton_masculino.AutoSize = true;
            this.radioButton_masculino.Location = new System.Drawing.Point(98, 19);
            this.radioButton_masculino.Name = "radioButton_masculino";
            this.radioButton_masculino.Size = new System.Drawing.Size(73, 17);
            this.radioButton_masculino.TabIndex = 1;
            this.radioButton_masculino.TabStop = true;
            this.radioButton_masculino.Text = "Masculino";
            this.radioButton_masculino.UseVisualStyleBackColor = true;
            // 
            // radioButton_Feminino
            // 
            this.radioButton_Feminino.AutoSize = true;
            this.radioButton_Feminino.Location = new System.Drawing.Point(7, 20);
            this.radioButton_Feminino.Name = "radioButton_Feminino";
            this.radioButton_Feminino.Size = new System.Drawing.Size(67, 17);
            this.radioButton_Feminino.TabIndex = 0;
            this.radioButton_Feminino.TabStop = true;
            this.radioButton_Feminino.Text = "Feminino";
            this.radioButton_Feminino.UseVisualStyleBackColor = true;
            // 
            // combo_opcoes
            // 
            this.combo_opcoes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_opcoes.FormattingEnabled = true;
            this.combo_opcoes.Location = new System.Drawing.Point(10, 43);
            this.combo_opcoes.Name = "combo_opcoes";
            this.combo_opcoes.Size = new System.Drawing.Size(121, 21);
            this.combo_opcoes.TabIndex = 0;
            this.combo_opcoes.SelectedIndexChanged += new System.EventHandler(this.combo_opcoes_SelectedIndexChanged);
            // 
            // FormConsulta1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 510);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormConsulta1";
            this.Text = "FormConsulta1";
            this.Load += new System.EventHandler(this.FormConsulta1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Consulta)).EndInit();
            this.groupBoxpesquisa.ResumeLayout(false);
            this.groupBoxpesquisa.PerformLayout();
            this.groupBoxcpf.ResumeLayout(false);
            this.groupBoxcpf.PerformLayout();
            this.groupBoxstatus.ResumeLayout(false);
            this.groupBoxstatus.PerformLayout();
            this.groupBoxSexo.ResumeLayout(false);
            this.groupBoxSexo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_sair;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.GroupBox groupBoxpesquisa;
        private System.Windows.Forms.RadioButton radioButtoncontem;
        private System.Windows.Forms.RadioButton radio_inicio;
        private System.Windows.Forms.TextBox box_nome;
        private System.Windows.Forms.GroupBox groupBoxcpf;
        private System.Windows.Forms.MaskedTextBox mask_cep;
        private System.Windows.Forms.GroupBox groupBoxstatus;
        private System.Windows.Forms.RadioButton radioButton_inativo;
        private System.Windows.Forms.RadioButton radioButton_ativo;
        private System.Windows.Forms.GroupBox groupBoxSexo;
        private System.Windows.Forms.RadioButton radioButton_masculino;
        private System.Windows.Forms.RadioButton radioButton_Feminino;
        private System.Windows.Forms.ComboBox combo_opcoes;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView_Consulta;
    }
}