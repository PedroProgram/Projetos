
namespace ProjetoPapelariaHumanas
{
    partial class FormConsultaMarca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultaMarca));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView_pesquisa_marca = new System.Windows.Forms.DataGridView();
            this.bt_pesquisar = new System.Windows.Forms.Button();
            this.group_status = new System.Windows.Forms.GroupBox();
            this.radio_inativo = new System.Windows.Forms.RadioButton();
            this.radio_ativo = new System.Windows.Forms.RadioButton();
            this.group_tipo_pesquisa = new System.Windows.Forms.GroupBox();
            this.radio_contem = new System.Windows.Forms.RadioButton();
            this.radio_inicio = new System.Windows.Forms.RadioButton();
            this.box_nome = new System.Windows.Forms.TextBox();
            this.combo_pesquisa_marca = new System.Windows.Forms.ComboBox();
            this.bt_sair = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_ajuda = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pesquisa_marca)).BeginInit();
            this.group_status.SuspendLayout();
            this.group_tipo_pesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView_pesquisa_marca);
            this.groupBox1.Controls.Add(this.bt_pesquisar);
            this.groupBox1.Controls.Add(this.group_status);
            this.groupBox1.Controls.Add(this.group_tipo_pesquisa);
            this.groupBox1.Controls.Add(this.box_nome);
            this.groupBox1.Controls.Add(this.combo_pesquisa_marca);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(762, 399);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta De Marca";
            // 
            // dataGridView_pesquisa_marca
            // 
            this.dataGridView_pesquisa_marca.AllowUserToAddRows = false;
            this.dataGridView_pesquisa_marca.AllowUserToDeleteRows = false;
            this.dataGridView_pesquisa_marca.AllowUserToResizeColumns = false;
            this.dataGridView_pesquisa_marca.AllowUserToResizeRows = false;
            this.dataGridView_pesquisa_marca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_pesquisa_marca.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridView_pesquisa_marca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_pesquisa_marca.Location = new System.Drawing.Point(6, 163);
            this.dataGridView_pesquisa_marca.MultiSelect = false;
            this.dataGridView_pesquisa_marca.Name = "dataGridView_pesquisa_marca";
            this.dataGridView_pesquisa_marca.ReadOnly = true;
            this.dataGridView_pesquisa_marca.RowHeadersVisible = false;
            this.dataGridView_pesquisa_marca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_pesquisa_marca.Size = new System.Drawing.Size(750, 224);
            this.dataGridView_pesquisa_marca.TabIndex = 8;
            this.dataGridView_pesquisa_marca.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_pesquisa_marca_CellClick);
            // 
            // bt_pesquisar
            // 
            this.bt_pesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.bt_pesquisar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.bt_pesquisar.Image = ((System.Drawing.Image)(resources.GetObject("bt_pesquisar.Image")));
            this.bt_pesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_pesquisar.Location = new System.Drawing.Point(618, 39);
            this.bt_pesquisar.Name = "bt_pesquisar";
            this.bt_pesquisar.Size = new System.Drawing.Size(131, 53);
            this.bt_pesquisar.TabIndex = 6;
            this.bt_pesquisar.Text = "      Pesquisar";
            this.bt_pesquisar.UseVisualStyleBackColor = false;
            this.bt_pesquisar.Click += new System.EventHandler(this.bt_pesquisar_Click);
            // 
            // group_status
            // 
            this.group_status.Controls.Add(this.radio_inativo);
            this.group_status.Controls.Add(this.radio_ativo);
            this.group_status.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.group_status.Location = new System.Drawing.Point(13, 102);
            this.group_status.Name = "group_status";
            this.group_status.Size = new System.Drawing.Size(147, 53);
            this.group_status.TabIndex = 4;
            this.group_status.TabStop = false;
            this.group_status.Text = "Status";
            // 
            // radio_inativo
            // 
            this.radio_inativo.AutoSize = true;
            this.radio_inativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_inativo.Location = new System.Drawing.Point(74, 21);
            this.radio_inativo.Name = "radio_inativo";
            this.radio_inativo.Size = new System.Drawing.Size(57, 17);
            this.radio_inativo.TabIndex = 3;
            this.radio_inativo.TabStop = true;
            this.radio_inativo.Text = "Inativo";
            this.radio_inativo.UseVisualStyleBackColor = true;
            // 
            // radio_ativo
            // 
            this.radio_ativo.AutoSize = true;
            this.radio_ativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_ativo.Location = new System.Drawing.Point(19, 21);
            this.radio_ativo.Name = "radio_ativo";
            this.radio_ativo.Size = new System.Drawing.Size(49, 17);
            this.radio_ativo.TabIndex = 2;
            this.radio_ativo.TabStop = true;
            this.radio_ativo.Text = "Ativo";
            this.radio_ativo.UseVisualStyleBackColor = true;
            // 
            // group_tipo_pesquisa
            // 
            this.group_tipo_pesquisa.Controls.Add(this.radio_contem);
            this.group_tipo_pesquisa.Controls.Add(this.radio_inicio);
            this.group_tipo_pesquisa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.group_tipo_pesquisa.Location = new System.Drawing.Point(424, 31);
            this.group_tipo_pesquisa.Name = "group_tipo_pesquisa";
            this.group_tipo_pesquisa.Size = new System.Drawing.Size(161, 61);
            this.group_tipo_pesquisa.TabIndex = 2;
            this.group_tipo_pesquisa.TabStop = false;
            this.group_tipo_pesquisa.Text = "Tipo de pesquisa";
            // 
            // radio_contem
            // 
            this.radio_contem.AutoSize = true;
            this.radio_contem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_contem.Location = new System.Drawing.Point(85, 26);
            this.radio_contem.Name = "radio_contem";
            this.radio_contem.Size = new System.Drawing.Size(61, 17);
            this.radio_contem.TabIndex = 3;
            this.radio_contem.TabStop = true;
            this.radio_contem.Text = "Contém";
            this.radio_contem.UseVisualStyleBackColor = true;
            // 
            // radio_inicio
            // 
            this.radio_inicio.AutoSize = true;
            this.radio_inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_inicio.Location = new System.Drawing.Point(18, 26);
            this.radio_inicio.Name = "radio_inicio";
            this.radio_inicio.Size = new System.Drawing.Size(50, 17);
            this.radio_inicio.TabIndex = 2;
            this.radio_inicio.TabStop = true;
            this.radio_inicio.Text = "Inicio";
            this.radio_inicio.UseVisualStyleBackColor = true;
            // 
            // box_nome
            // 
            this.box_nome.BackColor = System.Drawing.Color.AliceBlue;
            this.box_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_nome.Location = new System.Drawing.Point(158, 47);
            this.box_nome.MaxLength = 30;
            this.box_nome.Name = "box_nome";
            this.box_nome.Size = new System.Drawing.Size(245, 20);
            this.box_nome.TabIndex = 1;
            // 
            // combo_pesquisa_marca
            // 
            this.combo_pesquisa_marca.BackColor = System.Drawing.Color.AliceBlue;
            this.combo_pesquisa_marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_pesquisa_marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_pesquisa_marca.FormattingEnabled = true;
            this.combo_pesquisa_marca.Location = new System.Drawing.Point(9, 47);
            this.combo_pesquisa_marca.Name = "combo_pesquisa_marca";
            this.combo_pesquisa_marca.Size = new System.Drawing.Size(135, 21);
            this.combo_pesquisa_marca.TabIndex = 0;
            this.combo_pesquisa_marca.SelectedIndexChanged += new System.EventHandler(this.combo_pesquisa_marca_SelectedIndexChanged);
            // 
            // bt_sair
            // 
            this.bt_sair.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bt_sair.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.bt_sair.Location = new System.Drawing.Point(759, -4);
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.Size = new System.Drawing.Size(31, 28);
            this.bt_sair.TabIndex = 7;
            this.bt_sair.Text = "X";
            this.bt_sair.UseVisualStyleBackColor = false;
            this.bt_sair.Click += new System.EventHandler(this.bt_sair_Click);
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
            this.bt_ajuda.Location = new System.Drawing.Point(734, -1);
            this.bt_ajuda.Name = "bt_ajuda";
            this.bt_ajuda.Size = new System.Drawing.Size(19, 19);
            this.bt_ajuda.Style = MetroFramework.MetroColorStyle.Silver;
            this.bt_ajuda.TabIndex = 45;
            this.bt_ajuda.Text = " ?";
            this.bt_ajuda.UseSelectable = true;
            this.bt_ajuda.Click += new System.EventHandler(this.bt_ajuda_Click);
            // 
            // FormConsultaMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(786, 442);
            this.Controls.Add(this.bt_ajuda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_sair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormConsultaMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Marca";
            this.Load += new System.EventHandler(this.FormConsultaMarca_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pesquisa_marca)).EndInit();
            this.group_status.ResumeLayout(false);
            this.group_status.PerformLayout();
            this.group_tipo_pesquisa.ResumeLayout(false);
            this.group_tipo_pesquisa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView_pesquisa_marca;
        private System.Windows.Forms.Button bt_sair;
        private System.Windows.Forms.Button bt_pesquisar;
        private System.Windows.Forms.GroupBox group_status;
        private System.Windows.Forms.RadioButton radio_inativo;
        private System.Windows.Forms.RadioButton radio_ativo;
        private System.Windows.Forms.GroupBox group_tipo_pesquisa;
        private System.Windows.Forms.RadioButton radio_contem;
        private System.Windows.Forms.RadioButton radio_inicio;
        private System.Windows.Forms.TextBox box_nome;
        private System.Windows.Forms.ComboBox combo_pesquisa_marca;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroButton bt_ajuda;
    }
}