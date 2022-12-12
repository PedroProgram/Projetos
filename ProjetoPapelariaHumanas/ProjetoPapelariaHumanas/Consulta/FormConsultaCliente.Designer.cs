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
            this.bt_pesquisar = new System.Windows.Forms.Button();
            this.groupBox_rg = new System.Windows.Forms.GroupBox();
            this.mask_rg = new System.Windows.Forms.MaskedTextBox();
            this.groupBox_pesquisanome = new System.Windows.Forms.GroupBox();
            this.radio_contem = new System.Windows.Forms.RadioButton();
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
            this.combo_pesquisa_cliente = new System.Windows.Forms.ComboBox();
            this.bt_sair = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_ajuda = new MetroFramework.Controls.MetroButton();
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
            this.groupBox_cliente.Controls.Add(this.dataGridView_cliente);
            this.groupBox_cliente.Controls.Add(this.bt_pesquisar);
            this.groupBox_cliente.Controls.Add(this.groupBox_rg);
            this.groupBox_cliente.Controls.Add(this.groupBox_pesquisanome);
            this.groupBox_cliente.Controls.Add(this.box_nome);
            this.groupBox_cliente.Controls.Add(this.groupBox_cpf);
            this.groupBox_cliente.Controls.Add(this.groupBox_sexo);
            this.groupBox_cliente.Controls.Add(this.groupBox_status);
            this.groupBox_cliente.Controls.Add(this.combo_pesquisa_cliente);
            this.groupBox_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox_cliente.Location = new System.Drawing.Point(12, 30);
            this.groupBox_cliente.Name = "groupBox_cliente";
            this.groupBox_cliente.Size = new System.Drawing.Size(676, 410);
            this.groupBox_cliente.TabIndex = 0;
            this.groupBox_cliente.TabStop = false;
            this.groupBox_cliente.Text = "Infromações do Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(165, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nome :";
            // 
            // dataGridView_cliente
            // 
            this.dataGridView_cliente.AllowUserToAddRows = false;
            this.dataGridView_cliente.AllowUserToDeleteRows = false;
            this.dataGridView_cliente.AllowUserToResizeColumns = false;
            this.dataGridView_cliente.AllowUserToResizeRows = false;
            this.dataGridView_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_cliente.Location = new System.Drawing.Point(12, 219);
            this.dataGridView_cliente.MultiSelect = false;
            this.dataGridView_cliente.Name = "dataGridView_cliente";
            this.dataGridView_cliente.ReadOnly = true;
            this.dataGridView_cliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_cliente.Size = new System.Drawing.Size(658, 189);
            this.dataGridView_cliente.TabIndex = 10;
            this.dataGridView_cliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_cliente_CellClick);
            // 
            // bt_pesquisar
            // 
            this.bt_pesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.bt_pesquisar.Image = ((System.Drawing.Image)(resources.GetObject("bt_pesquisar.Image")));
            this.bt_pesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_pesquisar.Location = new System.Drawing.Point(553, 49);
            this.bt_pesquisar.Name = "bt_pesquisar";
            this.bt_pesquisar.Size = new System.Drawing.Size(117, 54);
            this.bt_pesquisar.TabIndex = 8;
            this.bt_pesquisar.Text = "     Pesquisar";
            this.bt_pesquisar.UseVisualStyleBackColor = false;
            this.bt_pesquisar.Click += new System.EventHandler(this.bt_pesquisar_Click);
            // 
            // groupBox_rg
            // 
            this.groupBox_rg.Controls.Add(this.mask_rg);
            this.groupBox_rg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox_rg.Location = new System.Drawing.Point(13, 162);
            this.groupBox_rg.Name = "groupBox_rg";
            this.groupBox_rg.Size = new System.Drawing.Size(107, 51);
            this.groupBox_rg.TabIndex = 6;
            this.groupBox_rg.TabStop = false;
            this.groupBox_rg.Text = "RG";
            // 
            // mask_rg
            // 
            this.mask_rg.BackColor = System.Drawing.Color.AliceBlue;
            this.mask_rg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mask_rg.Location = new System.Drawing.Point(6, 19);
            this.mask_rg.Mask = "00,000,000-A";
            this.mask_rg.Name = "mask_rg";
            this.mask_rg.Size = new System.Drawing.Size(87, 20);
            this.mask_rg.TabIndex = 0;
            // 
            // groupBox_pesquisanome
            // 
            this.groupBox_pesquisanome.Controls.Add(this.radio_contem);
            this.groupBox_pesquisanome.Controls.Add(this.radio_inicio);
            this.groupBox_pesquisanome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox_pesquisanome.Location = new System.Drawing.Point(406, 15);
            this.groupBox_pesquisanome.Name = "groupBox_pesquisanome";
            this.groupBox_pesquisanome.Size = new System.Drawing.Size(136, 41);
            this.groupBox_pesquisanome.TabIndex = 5;
            this.groupBox_pesquisanome.TabStop = false;
            this.groupBox_pesquisanome.Text = "Tipo de Pesquisa";
            // 
            // radio_contem
            // 
            this.radio_contem.AutoSize = true;
            this.radio_contem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_contem.Location = new System.Drawing.Point(64, 18);
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
            this.box_nome.BackColor = System.Drawing.Color.AliceBlue;
            this.box_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_nome.Location = new System.Drawing.Point(214, 27);
            this.box_nome.MaxLength = 30;
            this.box_nome.Name = "box_nome";
            this.box_nome.Size = new System.Drawing.Size(186, 20);
            this.box_nome.TabIndex = 4;
            // 
            // groupBox_cpf
            // 
            this.groupBox_cpf.Controls.Add(this.mask_cpf);
            this.groupBox_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox_cpf.Location = new System.Drawing.Point(417, 92);
            this.groupBox_cpf.Name = "groupBox_cpf";
            this.groupBox_cpf.Size = new System.Drawing.Size(125, 49);
            this.groupBox_cpf.TabIndex = 3;
            this.groupBox_cpf.TabStop = false;
            this.groupBox_cpf.Text = "CPF";
            // 
            // mask_cpf
            // 
            this.mask_cpf.BackColor = System.Drawing.Color.AliceBlue;
            this.mask_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mask_cpf.Location = new System.Drawing.Point(13, 19);
            this.mask_cpf.Mask = "000,000,000-00";
            this.mask_cpf.Name = "mask_cpf";
            this.mask_cpf.Size = new System.Drawing.Size(100, 20);
            this.mask_cpf.TabIndex = 0;
            // 
            // groupBox_sexo
            // 
            this.groupBox_sexo.Controls.Add(this.radio_masculino);
            this.groupBox_sexo.Controls.Add(this.radio_feminino);
            this.groupBox_sexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox_sexo.Location = new System.Drawing.Point(13, 91);
            this.groupBox_sexo.Name = "groupBox_sexo";
            this.groupBox_sexo.Size = new System.Drawing.Size(187, 50);
            this.groupBox_sexo.TabIndex = 2;
            this.groupBox_sexo.TabStop = false;
            this.groupBox_sexo.Text = "Sexo";
            // 
            // radio_masculino
            // 
            this.radio_masculino.AutoSize = true;
            this.radio_masculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_masculino.Location = new System.Drawing.Point(98, 19);
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
            this.radio_feminino.Location = new System.Drawing.Point(18, 19);
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
            this.groupBox_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox_status.Location = new System.Drawing.Point(259, 92);
            this.groupBox_status.Name = "groupBox_status";
            this.groupBox_status.Size = new System.Drawing.Size(130, 49);
            this.groupBox_status.TabIndex = 1;
            this.groupBox_status.TabStop = false;
            this.groupBox_status.Text = "Status";
            // 
            // radio_inativo
            // 
            this.radio_inativo.AutoSize = true;
            this.radio_inativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_inativo.Location = new System.Drawing.Point(64, 19);
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
            this.radio_ativo.Location = new System.Drawing.Point(10, 18);
            this.radio_ativo.Name = "radio_ativo";
            this.radio_ativo.Size = new System.Drawing.Size(49, 17);
            this.radio_ativo.TabIndex = 0;
            this.radio_ativo.TabStop = true;
            this.radio_ativo.Text = "Ativo";
            this.radio_ativo.UseVisualStyleBackColor = true;
            // 
            // combo_pesquisa_cliente
            // 
            this.combo_pesquisa_cliente.BackColor = System.Drawing.Color.AliceBlue;
            this.combo_pesquisa_cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_pesquisa_cliente.FormattingEnabled = true;
            this.combo_pesquisa_cliente.Location = new System.Drawing.Point(6, 27);
            this.combo_pesquisa_cliente.Name = "combo_pesquisa_cliente";
            this.combo_pesquisa_cliente.Size = new System.Drawing.Size(153, 21);
            this.combo_pesquisa_cliente.TabIndex = 0;
            this.combo_pesquisa_cliente.SelectedIndexChanged += new System.EventHandler(this.combo_consulta_SelectedIndexChanged);
            // 
            // bt_sair
            // 
            this.bt_sair.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bt_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.bt_sair.Location = new System.Drawing.Point(679, -4);
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.Size = new System.Drawing.Size(31, 28);
            this.bt_sair.TabIndex = 9;
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
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "Sistema Papelaria Humanas";
            // 
            // bt_ajuda
            // 
            this.bt_ajuda.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_ajuda.Location = new System.Drawing.Point(654, -1);
            this.bt_ajuda.Name = "bt_ajuda";
            this.bt_ajuda.Size = new System.Drawing.Size(19, 19);
            this.bt_ajuda.Style = MetroFramework.MetroColorStyle.Silver;
            this.bt_ajuda.TabIndex = 42;
            this.bt_ajuda.Text = " ?";
            this.bt_ajuda.UseSelectable = true;
            this.bt_ajuda.Click += new System.EventHandler(this.bt_ajuda_Click);
            // 
            // FormConsultaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(706, 450);
            this.Controls.Add(this.bt_ajuda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox_cliente);
            this.Controls.Add(this.bt_sair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormConsultaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
            this.PerformLayout();

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
        private System.Windows.Forms.ComboBox combo_pesquisa_cliente;
        private System.Windows.Forms.GroupBox groupBox_pesquisanome;
        private System.Windows.Forms.TextBox box_nome;
        private System.Windows.Forms.GroupBox groupBox_rg;
        private System.Windows.Forms.MaskedTextBox mask_rg;
        private System.Windows.Forms.RadioButton radio_contem;
        private System.Windows.Forms.RadioButton radio_inicio;
        private System.Windows.Forms.Button bt_sair;
        private System.Windows.Forms.Button bt_pesquisar;
        private System.Windows.Forms.DataGridView dataGridView_cliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroButton bt_ajuda;
    }
}