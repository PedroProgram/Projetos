namespace ProjetoPapelariaHumanas
{
    partial class FormConsultarCargo
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
            this.combo_consulta_cargo = new System.Windows.Forms.ComboBox();
            this.box_nome_cargo = new System.Windows.Forms.TextBox();
            this.groupBox_status = new System.Windows.Forms.GroupBox();
            this.radio_inativo = new System.Windows.Forms.RadioButton();
            this.radio_ativo = new System.Windows.Forms.RadioButton();
            this.bt_atualizar = new System.Windows.Forms.Button();
            this.bt_sair = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton__contem = new System.Windows.Forms.RadioButton();
            this.radio_inicio = new System.Windows.Forms.RadioButton();
            this.dataGridView_cargo = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_status.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cargo)).BeginInit();
            this.SuspendLayout();
            // 
            // combo_consulta_cargo
            // 
            this.combo_consulta_cargo.FormattingEnabled = true;
            this.combo_consulta_cargo.Location = new System.Drawing.Point(7, 25);
            this.combo_consulta_cargo.Name = "combo_consulta_cargo";
            this.combo_consulta_cargo.Size = new System.Drawing.Size(121, 21);
            this.combo_consulta_cargo.TabIndex = 0;
            this.combo_consulta_cargo.SelectedIndexChanged += new System.EventHandler(this.combo_consulta_cargo_SelectedIndexChanged);
            // 
            // box_nome_cargo
            // 
            this.box_nome_cargo.Location = new System.Drawing.Point(212, 25);
            this.box_nome_cargo.Name = "box_nome_cargo";
            this.box_nome_cargo.Size = new System.Drawing.Size(100, 20);
            this.box_nome_cargo.TabIndex = 1;
            // 
            // groupBox_status
            // 
            this.groupBox_status.Controls.Add(this.radio_inativo);
            this.groupBox_status.Controls.Add(this.radio_ativo);
            this.groupBox_status.Location = new System.Drawing.Point(7, 66);
            this.groupBox_status.Name = "groupBox_status";
            this.groupBox_status.Size = new System.Drawing.Size(121, 41);
            this.groupBox_status.TabIndex = 2;
            this.groupBox_status.TabStop = false;
            this.groupBox_status.Text = "Status";
            // 
            // radio_inativo
            // 
            this.radio_inativo.AutoSize = true;
            this.radio_inativo.Location = new System.Drawing.Point(58, 18);
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
            this.radio_ativo.Location = new System.Drawing.Point(7, 18);
            this.radio_ativo.Name = "radio_ativo";
            this.radio_ativo.Size = new System.Drawing.Size(49, 17);
            this.radio_ativo.TabIndex = 0;
            this.radio_ativo.TabStop = true;
            this.radio_ativo.Text = "Ativo";
            this.radio_ativo.UseVisualStyleBackColor = true;
            // 
            // bt_atualizar
            // 
            this.bt_atualizar.Location = new System.Drawing.Point(492, 66);
            this.bt_atualizar.Name = "bt_atualizar";
            this.bt_atualizar.Size = new System.Drawing.Size(75, 34);
            this.bt_atualizar.TabIndex = 3;
            this.bt_atualizar.Text = "Pesquisar";
            this.bt_atualizar.UseVisualStyleBackColor = true;
            this.bt_atualizar.Click += new System.EventHandler(this.bt_atualizar_Click);
            // 
            // bt_sair
            // 
            this.bt_sair.Location = new System.Drawing.Point(536, 13);
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.Size = new System.Drawing.Size(31, 28);
            this.bt_sair.TabIndex = 4;
            this.bt_sair.Text = "X";
            this.bt_sair.Click += new System.EventHandler(this.bt_sair_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.dataGridView_cargo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.bt_sair);
            this.groupBox2.Controls.Add(this.combo_consulta_cargo);
            this.groupBox2.Controls.Add(this.groupBox_status);
            this.groupBox2.Controls.Add(this.bt_atualizar);
            this.groupBox2.Controls.Add(this.box_nome_cargo);
            this.groupBox2.Location = new System.Drawing.Point(33, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(573, 354);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações do Cargo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton__contem);
            this.groupBox1.Controls.Add(this.radio_inicio);
            this.groupBox1.Location = new System.Drawing.Point(338, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(131, 49);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Pesquisa";
            // 
            // radioButton__contem
            // 
            this.radioButton__contem.AutoSize = true;
            this.radioButton__contem.Location = new System.Drawing.Point(63, 20);
            this.radioButton__contem.Name = "radioButton__contem";
            this.radioButton__contem.Size = new System.Drawing.Size(61, 17);
            this.radioButton__contem.TabIndex = 6;
            this.radioButton__contem.TabStop = true;
            this.radioButton__contem.Text = "Contém";
            this.radioButton__contem.UseVisualStyleBackColor = true;
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
            // dataGridView_cargo
            // 
            this.dataGridView_cargo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_cargo.Location = new System.Drawing.Point(7, 149);
            this.dataGridView_cargo.MultiSelect = false;
            this.dataGridView_cargo.Name = "dataGridView_cargo";
            this.dataGridView_cargo.ReadOnly = true;
            this.dataGridView_cargo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_cargo.Size = new System.Drawing.Size(455, 166);
            this.dataGridView_cargo.TabIndex = 7;
            this.dataGridView_cargo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(62, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Para Alterar ou Excluir um cliente, Selecione na Grid!!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome Cargo :";
            // 
            // FormConsultarCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 378);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormConsultarCargo";
            this.Text = "FormConsultarCargo";
            this.Load += new System.EventHandler(this.FormConsultarCargo_Load);
            this.groupBox_status.ResumeLayout(false);
            this.groupBox_status.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cargo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_consulta_cargo;
        private System.Windows.Forms.TextBox box_nome_cargo;
        private System.Windows.Forms.GroupBox groupBox_status;
        private System.Windows.Forms.RadioButton radio_inativo;
        private System.Windows.Forms.RadioButton radio_ativo;
        private System.Windows.Forms.Button bt_atualizar;
        private System.Windows.Forms.Button bt_sair;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_cargo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton__contem;
        private System.Windows.Forms.RadioButton radio_inicio;
    }
}