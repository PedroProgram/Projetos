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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultarCargo));
            this.combo_pesquisa_cargo = new System.Windows.Forms.ComboBox();
            this.box_nome_cargo = new System.Windows.Forms.TextBox();
            this.groupBox_status = new System.Windows.Forms.GroupBox();
            this.radio_inativo = new System.Windows.Forms.RadioButton();
            this.radio_ativo = new System.Windows.Forms.RadioButton();
            this.bt_atualizar = new System.Windows.Forms.Button();
            this.bt_sair = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox_pesquisa = new System.Windows.Forms.GroupBox();
            this.radioButton__contem = new System.Windows.Forms.RadioButton();
            this.radio_inicio = new System.Windows.Forms.RadioButton();
            this.dataGridView_cargo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_ajuda = new MetroFramework.Controls.MetroButton();
            this.groupBox_status.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox_pesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cargo)).BeginInit();
            this.SuspendLayout();
            // 
            // combo_pesquisa_cargo
            // 
            this.combo_pesquisa_cargo.BackColor = System.Drawing.Color.AliceBlue;
            this.combo_pesquisa_cargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_pesquisa_cargo.FormattingEnabled = true;
            this.combo_pesquisa_cargo.Location = new System.Drawing.Point(7, 29);
            this.combo_pesquisa_cargo.Name = "combo_pesquisa_cargo";
            this.combo_pesquisa_cargo.Size = new System.Drawing.Size(161, 21);
            this.combo_pesquisa_cargo.TabIndex = 0;
            this.combo_pesquisa_cargo.SelectedIndexChanged += new System.EventHandler(this.combo_consulta_cargo_SelectedIndexChanged);
            // 
            // box_nome_cargo
            // 
            this.box_nome_cargo.BackColor = System.Drawing.Color.AliceBlue;
            this.box_nome_cargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_nome_cargo.Location = new System.Drawing.Point(229, 29);
            this.box_nome_cargo.MaxLength = 30;
            this.box_nome_cargo.Name = "box_nome_cargo";
            this.box_nome_cargo.Size = new System.Drawing.Size(203, 20);
            this.box_nome_cargo.TabIndex = 1;
            // 
            // groupBox_status
            // 
            this.groupBox_status.Controls.Add(this.radio_inativo);
            this.groupBox_status.Controls.Add(this.radio_ativo);
            this.groupBox_status.Location = new System.Drawing.Point(7, 66);
            this.groupBox_status.Name = "groupBox_status";
            this.groupBox_status.Size = new System.Drawing.Size(161, 41);
            this.groupBox_status.TabIndex = 2;
            this.groupBox_status.TabStop = false;
            this.groupBox_status.Text = "Status";
            // 
            // radio_inativo
            // 
            this.radio_inativo.AutoSize = true;
            this.radio_inativo.Location = new System.Drawing.Point(85, 18);
            this.radio_inativo.Name = "radio_inativo";
            this.radio_inativo.Size = new System.Drawing.Size(64, 17);
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
            this.radio_ativo.Size = new System.Drawing.Size(54, 17);
            this.radio_ativo.TabIndex = 0;
            this.radio_ativo.TabStop = true;
            this.radio_ativo.Text = "Ativo";
            this.radio_ativo.UseVisualStyleBackColor = true;
            // 
            // bt_atualizar
            // 
            this.bt_atualizar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.bt_atualizar.Image = ((System.Drawing.Image)(resources.GetObject("bt_atualizar.Image")));
            this.bt_atualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_atualizar.Location = new System.Drawing.Point(458, 14);
            this.bt_atualizar.Name = "bt_atualizar";
            this.bt_atualizar.Size = new System.Drawing.Size(126, 49);
            this.bt_atualizar.TabIndex = 3;
            this.bt_atualizar.Text = "     Pesquisar";
            this.bt_atualizar.UseVisualStyleBackColor = false;
            this.bt_atualizar.Click += new System.EventHandler(this.bt_atualizar_Click);
            // 
            // bt_sair
            // 
            this.bt_sair.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bt_sair.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.bt_sair.Location = new System.Drawing.Point(618, -4);
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.Size = new System.Drawing.Size(31, 28);
            this.bt_sair.TabIndex = 4;
            this.bt_sair.Text = "X";
            this.bt_sair.UseVisualStyleBackColor = false;
            this.bt_sair.Click += new System.EventHandler(this.bt_sair_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox_pesquisa);
            this.groupBox2.Controls.Add(this.dataGridView_cargo);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.combo_pesquisa_cargo);
            this.groupBox2.Controls.Add(this.groupBox_status);
            this.groupBox2.Controls.Add(this.bt_atualizar);
            this.groupBox2.Controls.Add(this.box_nome_cargo);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(33, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(600, 324);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações do Cargo";
            // 
            // groupBox_pesquisa
            // 
            this.groupBox_pesquisa.Controls.Add(this.radioButton__contem);
            this.groupBox_pesquisa.Controls.Add(this.radio_inicio);
            this.groupBox_pesquisa.Location = new System.Drawing.Point(249, 66);
            this.groupBox_pesquisa.Name = "groupBox_pesquisa";
            this.groupBox_pesquisa.Size = new System.Drawing.Size(126, 49);
            this.groupBox_pesquisa.TabIndex = 8;
            this.groupBox_pesquisa.TabStop = false;
            this.groupBox_pesquisa.Text = "Tipo de Pesquisa";
            // 
            // radioButton__contem
            // 
            this.radioButton__contem.AutoSize = true;
            this.radioButton__contem.Location = new System.Drawing.Point(63, 20);
            this.radioButton__contem.Name = "radioButton__contem";
            this.radioButton__contem.Size = new System.Drawing.Size(67, 17);
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
            this.radio_inicio.Size = new System.Drawing.Size(56, 17);
            this.radio_inicio.TabIndex = 0;
            this.radio_inicio.TabStop = true;
            this.radio_inicio.Text = "Inicio";
            this.radio_inicio.UseVisualStyleBackColor = true;
            // 
            // dataGridView_cargo
            // 
            this.dataGridView_cargo.AllowUserToAddRows = false;
            this.dataGridView_cargo.AllowUserToDeleteRows = false;
            this.dataGridView_cargo.AllowUserToResizeColumns = false;
            this.dataGridView_cargo.AllowUserToResizeRows = false;
            this.dataGridView_cargo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_cargo.Location = new System.Drawing.Point(7, 121);
            this.dataGridView_cargo.MultiSelect = false;
            this.dataGridView_cargo.Name = "dataGridView_cargo";
            this.dataGridView_cargo.ReadOnly = true;
            this.dataGridView_cargo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_cargo.Size = new System.Drawing.Size(577, 197);
            this.dataGridView_cargo.TabIndex = 7;
            this.dataGridView_cargo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome  :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(-1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "Sistema Papelaria Humanas";
            // 
            // bt_ajuda
            // 
            this.bt_ajuda.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_ajuda.Location = new System.Drawing.Point(593, 0);
            this.bt_ajuda.Name = "bt_ajuda";
            this.bt_ajuda.Size = new System.Drawing.Size(19, 19);
            this.bt_ajuda.Style = MetroFramework.MetroColorStyle.Silver;
            this.bt_ajuda.TabIndex = 47;
            this.bt_ajuda.Text = " ?";
            this.bt_ajuda.UseSelectable = true;
            this.bt_ajuda.Click += new System.EventHandler(this.bt_ajuda_Click);
            // 
            // FormConsultarCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(645, 364);
            this.Controls.Add(this.bt_ajuda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.bt_sair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormConsultarCargo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormConsultarCargo";
            this.Load += new System.EventHandler(this.FormConsultarCargo_Load);
            this.groupBox_status.ResumeLayout(false);
            this.groupBox_status.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox_pesquisa.ResumeLayout(false);
            this.groupBox_pesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cargo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_pesquisa_cargo;
        private System.Windows.Forms.TextBox box_nome_cargo;
        private System.Windows.Forms.GroupBox groupBox_status;
        private System.Windows.Forms.RadioButton radio_inativo;
        private System.Windows.Forms.RadioButton radio_ativo;
        private System.Windows.Forms.Button bt_atualizar;
        private System.Windows.Forms.Button bt_sair;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_cargo;
        private System.Windows.Forms.GroupBox groupBox_pesquisa;
        private System.Windows.Forms.RadioButton radioButton__contem;
        private System.Windows.Forms.RadioButton radio_inicio;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroButton bt_ajuda;
    }
}