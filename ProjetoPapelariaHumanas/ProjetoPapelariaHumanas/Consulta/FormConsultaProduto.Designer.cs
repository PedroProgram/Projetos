
namespace ProjetoPapelariaHumanas
{
    partial class FormConsultaProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultaProduto));
            this.group_consulta_produto = new System.Windows.Forms.GroupBox();
            this.group_data = new System.Windows.Forms.GroupBox();
            this.masked_data = new System.Windows.Forms.MaskedTextBox();
            this.group_preco = new System.Windows.Forms.GroupBox();
            this.box_preco = new System.Windows.Forms.TextBox();
            this.group_quatidade = new System.Windows.Forms.GroupBox();
            this.box_quantidade = new System.Windows.Forms.TextBox();
            this.group_pesquisa_nome = new System.Windows.Forms.GroupBox();
            this.box_nome = new System.Windows.Forms.TextBox();
            this.group_tipo_pesquisa = new System.Windows.Forms.GroupBox();
            this.radio_contem = new System.Windows.Forms.RadioButton();
            this.radio_inicio = new System.Windows.Forms.RadioButton();
            this.dataGridView_pesquisa_produto = new System.Windows.Forms.DataGridView();
            this.bt_pesquisar = new System.Windows.Forms.Button();
            this.group_status = new System.Windows.Forms.GroupBox();
            this.radio_inativo = new System.Windows.Forms.RadioButton();
            this.radio_ativo = new System.Windows.Forms.RadioButton();
            this.combo_pesquisa_produto = new System.Windows.Forms.ComboBox();
            this.bt_sair = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_ajuda = new MetroFramework.Controls.MetroButton();
            this.group_consulta_produto.SuspendLayout();
            this.group_data.SuspendLayout();
            this.group_preco.SuspendLayout();
            this.group_quatidade.SuspendLayout();
            this.group_pesquisa_nome.SuspendLayout();
            this.group_tipo_pesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pesquisa_produto)).BeginInit();
            this.group_status.SuspendLayout();
            this.SuspendLayout();
            // 
            // group_consulta_produto
            // 
            this.group_consulta_produto.Controls.Add(this.group_data);
            this.group_consulta_produto.Controls.Add(this.group_preco);
            this.group_consulta_produto.Controls.Add(this.group_quatidade);
            this.group_consulta_produto.Controls.Add(this.group_pesquisa_nome);
            this.group_consulta_produto.Controls.Add(this.dataGridView_pesquisa_produto);
            this.group_consulta_produto.Controls.Add(this.bt_pesquisar);
            this.group_consulta_produto.Controls.Add(this.group_status);
            this.group_consulta_produto.Controls.Add(this.combo_pesquisa_produto);
            this.group_consulta_produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_consulta_produto.Location = new System.Drawing.Point(12, 33);
            this.group_consulta_produto.Name = "group_consulta_produto";
            this.group_consulta_produto.Size = new System.Drawing.Size(765, 408);
            this.group_consulta_produto.TabIndex = 3;
            this.group_consulta_produto.TabStop = false;
            this.group_consulta_produto.Text = "Consulta de Produto";
            // 
            // group_data
            // 
            this.group_data.Controls.Add(this.masked_data);
            this.group_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_data.Location = new System.Drawing.Point(476, 105);
            this.group_data.Name = "group_data";
            this.group_data.Size = new System.Drawing.Size(129, 53);
            this.group_data.TabIndex = 12;
            this.group_data.TabStop = false;
            this.group_data.Text = "Pesquisa Por Data";
            // 
            // masked_data
            // 
            this.masked_data.BackColor = System.Drawing.Color.AliceBlue;
            this.masked_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masked_data.Location = new System.Drawing.Point(19, 21);
            this.masked_data.Mask = "00/00/0000";
            this.masked_data.Name = "masked_data";
            this.masked_data.Size = new System.Drawing.Size(79, 20);
            this.masked_data.TabIndex = 13;
            this.masked_data.ValidatingType = typeof(System.DateTime);
            this.masked_data.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.masked_data_TypeValidationCompleted);
            // 
            // group_preco
            // 
            this.group_preco.Controls.Add(this.box_preco);
            this.group_preco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_preco.Location = new System.Drawing.Point(327, 105);
            this.group_preco.Name = "group_preco";
            this.group_preco.Size = new System.Drawing.Size(134, 53);
            this.group_preco.TabIndex = 11;
            this.group_preco.TabStop = false;
            this.group_preco.Text = "Pesquisa Por Preço";
            // 
            // box_preco
            // 
            this.box_preco.BackColor = System.Drawing.Color.AliceBlue;
            this.box_preco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_preco.Location = new System.Drawing.Point(20, 21);
            this.box_preco.MaxLength = 5;
            this.box_preco.Name = "box_preco";
            this.box_preco.Size = new System.Drawing.Size(99, 20);
            this.box_preco.TabIndex = 1;
            this.box_preco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.box_preco_KeyPress);
            // 
            // group_quatidade
            // 
            this.group_quatidade.Controls.Add(this.box_quantidade);
            this.group_quatidade.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_quatidade.Location = new System.Drawing.Point(162, 105);
            this.group_quatidade.Name = "group_quatidade";
            this.group_quatidade.Size = new System.Drawing.Size(159, 53);
            this.group_quatidade.TabIndex = 10;
            this.group_quatidade.TabStop = false;
            this.group_quatidade.Text = "Pesquisa Por Quantidade";
            // 
            // box_quantidade
            // 
            this.box_quantidade.BackColor = System.Drawing.Color.AliceBlue;
            this.box_quantidade.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_quantidade.Location = new System.Drawing.Point(28, 24);
            this.box_quantidade.MaxLength = 5;
            this.box_quantidade.Name = "box_quantidade";
            this.box_quantidade.Size = new System.Drawing.Size(99, 20);
            this.box_quantidade.TabIndex = 1;
            this.box_quantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.box_quantidade_KeyPress);
            // 
            // group_pesquisa_nome
            // 
            this.group_pesquisa_nome.Controls.Add(this.box_nome);
            this.group_pesquisa_nome.Controls.Add(this.group_tipo_pesquisa);
            this.group_pesquisa_nome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.group_pesquisa_nome.Location = new System.Drawing.Point(149, 19);
            this.group_pesquisa_nome.Name = "group_pesquisa_nome";
            this.group_pesquisa_nome.Size = new System.Drawing.Size(448, 59);
            this.group_pesquisa_nome.TabIndex = 9;
            this.group_pesquisa_nome.TabStop = false;
            this.group_pesquisa_nome.Text = "Pesquisa Por Nome";
            // 
            // box_nome
            // 
            this.box_nome.BackColor = System.Drawing.Color.AliceBlue;
            this.box_nome.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_nome.Location = new System.Drawing.Point(6, 24);
            this.box_nome.MaxLength = 30;
            this.box_nome.Name = "box_nome";
            this.box_nome.Size = new System.Drawing.Size(256, 20);
            this.box_nome.TabIndex = 1;
            // 
            // group_tipo_pesquisa
            // 
            this.group_tipo_pesquisa.Controls.Add(this.radio_contem);
            this.group_tipo_pesquisa.Controls.Add(this.radio_inicio);
            this.group_tipo_pesquisa.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_tipo_pesquisa.Location = new System.Drawing.Point(276, 11);
            this.group_tipo_pesquisa.Name = "group_tipo_pesquisa";
            this.group_tipo_pesquisa.Size = new System.Drawing.Size(149, 42);
            this.group_tipo_pesquisa.TabIndex = 2;
            this.group_tipo_pesquisa.TabStop = false;
            this.group_tipo_pesquisa.Text = "Tipo De Pesquisa";
            // 
            // radio_contem
            // 
            this.radio_contem.AutoSize = true;
            this.radio_contem.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_contem.Location = new System.Drawing.Point(76, 17);
            this.radio_contem.Name = "radio_contem";
            this.radio_contem.Size = new System.Drawing.Size(61, 18);
            this.radio_contem.TabIndex = 3;
            this.radio_contem.TabStop = true;
            this.radio_contem.Text = "Contém";
            this.radio_contem.UseVisualStyleBackColor = true;
            // 
            // radio_inicio
            // 
            this.radio_inicio.AutoSize = true;
            this.radio_inicio.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_inicio.Location = new System.Drawing.Point(11, 17);
            this.radio_inicio.Name = "radio_inicio";
            this.radio_inicio.Size = new System.Drawing.Size(49, 18);
            this.radio_inicio.TabIndex = 2;
            this.radio_inicio.TabStop = true;
            this.radio_inicio.Text = "Inicio";
            this.radio_inicio.UseVisualStyleBackColor = true;
            // 
            // dataGridView_pesquisa_produto
            // 
            this.dataGridView_pesquisa_produto.AllowUserToAddRows = false;
            this.dataGridView_pesquisa_produto.AllowUserToDeleteRows = false;
            this.dataGridView_pesquisa_produto.AllowUserToResizeColumns = false;
            this.dataGridView_pesquisa_produto.AllowUserToResizeRows = false;
            this.dataGridView_pesquisa_produto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_pesquisa_produto.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridView_pesquisa_produto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_pesquisa_produto.Location = new System.Drawing.Point(6, 173);
            this.dataGridView_pesquisa_produto.MultiSelect = false;
            this.dataGridView_pesquisa_produto.Name = "dataGridView_pesquisa_produto";
            this.dataGridView_pesquisa_produto.ReadOnly = true;
            this.dataGridView_pesquisa_produto.RowHeadersVisible = false;
            this.dataGridView_pesquisa_produto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_pesquisa_produto.Size = new System.Drawing.Size(750, 229);
            this.dataGridView_pesquisa_produto.TabIndex = 8;
            this.dataGridView_pesquisa_produto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_pesquisa_produto_CellClick);
            // 
            // bt_pesquisar
            // 
            this.bt_pesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.bt_pesquisar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.bt_pesquisar.Image = ((System.Drawing.Image)(resources.GetObject("bt_pesquisar.Image")));
            this.bt_pesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_pesquisar.Location = new System.Drawing.Point(618, 19);
            this.bt_pesquisar.Name = "bt_pesquisar";
            this.bt_pesquisar.Size = new System.Drawing.Size(129, 59);
            this.bt_pesquisar.TabIndex = 6;
            this.bt_pesquisar.Text = "     Pesquisar";
            this.bt_pesquisar.UseVisualStyleBackColor = false;
            this.bt_pesquisar.Click += new System.EventHandler(this.bt_pesquisar_Click);
            // 
            // group_status
            // 
            this.group_status.Controls.Add(this.radio_inativo);
            this.group_status.Controls.Add(this.radio_ativo);
            this.group_status.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_status.Location = new System.Drawing.Point(22, 105);
            this.group_status.Name = "group_status";
            this.group_status.Size = new System.Drawing.Size(134, 53);
            this.group_status.TabIndex = 4;
            this.group_status.TabStop = false;
            this.group_status.Text = "Status";
            // 
            // radio_inativo
            // 
            this.radio_inativo.AutoSize = true;
            this.radio_inativo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_inativo.Location = new System.Drawing.Point(64, 24);
            this.radio_inativo.Name = "radio_inativo";
            this.radio_inativo.Size = new System.Drawing.Size(56, 18);
            this.radio_inativo.TabIndex = 3;
            this.radio_inativo.TabStop = true;
            this.radio_inativo.Text = "Inativo";
            this.radio_inativo.UseVisualStyleBackColor = true;
            // 
            // radio_ativo
            // 
            this.radio_ativo.AutoSize = true;
            this.radio_ativo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_ativo.Location = new System.Drawing.Point(9, 24);
            this.radio_ativo.Name = "radio_ativo";
            this.radio_ativo.Size = new System.Drawing.Size(50, 18);
            this.radio_ativo.TabIndex = 2;
            this.radio_ativo.TabStop = true;
            this.radio_ativo.Text = "Ativo";
            this.radio_ativo.UseVisualStyleBackColor = true;
            // 
            // combo_pesquisa_produto
            // 
            this.combo_pesquisa_produto.BackColor = System.Drawing.Color.AliceBlue;
            this.combo_pesquisa_produto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_pesquisa_produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_pesquisa_produto.FormattingEnabled = true;
            this.combo_pesquisa_produto.Location = new System.Drawing.Point(6, 42);
            this.combo_pesquisa_produto.Name = "combo_pesquisa_produto";
            this.combo_pesquisa_produto.Size = new System.Drawing.Size(137, 21);
            this.combo_pesquisa_produto.TabIndex = 0;
            this.combo_pesquisa_produto.SelectedIndexChanged += new System.EventHandler(this.combo_pesquisa_produto_SelectedIndexChanged);
            // 
            // bt_sair
            // 
            this.bt_sair.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bt_sair.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.bt_sair.Location = new System.Drawing.Point(768, -4);
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
            this.bt_ajuda.Location = new System.Drawing.Point(743, -1);
            this.bt_ajuda.Name = "bt_ajuda";
            this.bt_ajuda.Size = new System.Drawing.Size(19, 19);
            this.bt_ajuda.Style = MetroFramework.MetroColorStyle.Silver;
            this.bt_ajuda.TabIndex = 46;
            this.bt_ajuda.Text = " ?";
            this.bt_ajuda.UseSelectable = true;
            this.bt_ajuda.Click += new System.EventHandler(this.bt_ajuda_Click);
            // 
            // FormConsultaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(795, 452);
            this.Controls.Add(this.bt_ajuda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.group_consulta_produto);
            this.Controls.Add(this.bt_sair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormConsultaProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Papelaria Humanas";
            this.Load += new System.EventHandler(this.FormConsultaProduto_Load);
            this.group_consulta_produto.ResumeLayout(false);
            this.group_data.ResumeLayout(false);
            this.group_data.PerformLayout();
            this.group_preco.ResumeLayout(false);
            this.group_preco.PerformLayout();
            this.group_quatidade.ResumeLayout(false);
            this.group_quatidade.PerformLayout();
            this.group_pesquisa_nome.ResumeLayout(false);
            this.group_pesquisa_nome.PerformLayout();
            this.group_tipo_pesquisa.ResumeLayout(false);
            this.group_tipo_pesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pesquisa_produto)).EndInit();
            this.group_status.ResumeLayout(false);
            this.group_status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox group_consulta_produto;
        private System.Windows.Forms.DataGridView dataGridView_pesquisa_produto;
        private System.Windows.Forms.Button bt_sair;
        private System.Windows.Forms.Button bt_pesquisar;
        private System.Windows.Forms.GroupBox group_status;
        private System.Windows.Forms.RadioButton radio_inativo;
        private System.Windows.Forms.RadioButton radio_ativo;
        private System.Windows.Forms.GroupBox group_tipo_pesquisa;
        private System.Windows.Forms.RadioButton radio_contem;
        private System.Windows.Forms.RadioButton radio_inicio;
        private System.Windows.Forms.TextBox box_nome;
        private System.Windows.Forms.ComboBox combo_pesquisa_produto;
        private System.Windows.Forms.GroupBox group_pesquisa_nome;
        private System.Windows.Forms.GroupBox group_quatidade;
        private System.Windows.Forms.TextBox box_quantidade;
        private System.Windows.Forms.GroupBox group_preco;
        private System.Windows.Forms.TextBox box_preco;
        private System.Windows.Forms.GroupBox group_data;
        private System.Windows.Forms.MaskedTextBox masked_data;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroButton bt_ajuda;
    }
}