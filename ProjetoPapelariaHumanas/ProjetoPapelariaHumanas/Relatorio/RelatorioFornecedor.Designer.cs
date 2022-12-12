
namespace ProjetoPapelariaHumanas
{
    partial class RelatorioFornecedor
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelatorioFornecedor));
            this.ClassFornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.group_cidade = new System.Windows.Forms.GroupBox();
            this.combo_cidade = new System.Windows.Forms.ComboBox();
            this.group_mes = new System.Windows.Forms.GroupBox();
            this.combo_datacad_mes = new System.Windows.Forms.ComboBox();
            this.group_data = new System.Windows.Forms.GroupBox();
            this.mask_data = new System.Windows.Forms.MaskedTextBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bt_gerar_relatorio = new System.Windows.Forms.Button();
            this.group_cnpj = new System.Windows.Forms.GroupBox();
            this.Mask_Cnpj = new System.Windows.Forms.MaskedTextBox();
            this.group_status = new System.Windows.Forms.GroupBox();
            this.radio_inativo = new System.Windows.Forms.RadioButton();
            this.radio_ativo = new System.Windows.Forms.RadioButton();
            this.group_telefone = new System.Windows.Forms.GroupBox();
            this.Mask_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.combo_tipo_relatorio = new System.Windows.Forms.ComboBox();
            this.bt_Sair = new System.Windows.Forms.Button();
            this.label_fornecedor = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_ajuda = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.ClassFornecedorBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.group_cidade.SuspendLayout();
            this.group_mes.SuspendLayout();
            this.group_data.SuspendLayout();
            this.group_cnpj.SuspendLayout();
            this.group_status.SuspendLayout();
            this.group_telefone.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClassFornecedorBindingSource
            // 
            this.ClassFornecedorBindingSource.DataSource = typeof(ProjetoPapelariaHumanas.ClassFornecedor);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.group_cidade);
            this.groupBox1.Controls.Add(this.group_mes);
            this.groupBox1.Controls.Add(this.group_data);
            this.groupBox1.Controls.Add(this.reportViewer1);
            this.groupBox1.Controls.Add(this.bt_gerar_relatorio);
            this.groupBox1.Controls.Add(this.group_cnpj);
            this.groupBox1.Controls.Add(this.group_status);
            this.groupBox1.Controls.Add(this.group_telefone);
            this.groupBox1.Controls.Add(this.combo_tipo_relatorio);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(786, 421);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa de Fornecedor";
            // 
            // group_cidade
            // 
            this.group_cidade.Controls.Add(this.combo_cidade);
            this.group_cidade.Location = new System.Drawing.Point(221, 97);
            this.group_cidade.Name = "group_cidade";
            this.group_cidade.Size = new System.Drawing.Size(150, 53);
            this.group_cidade.TabIndex = 15;
            this.group_cidade.TabStop = false;
            this.group_cidade.Text = "Selecione Uma Cidade";
            // 
            // combo_cidade
            // 
            this.combo_cidade.BackColor = System.Drawing.Color.AliceBlue;
            this.combo_cidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_cidade.FormattingEnabled = true;
            this.combo_cidade.Location = new System.Drawing.Point(18, 19);
            this.combo_cidade.Name = "combo_cidade";
            this.combo_cidade.Size = new System.Drawing.Size(117, 21);
            this.combo_cidade.TabIndex = 8;
            // 
            // group_mes
            // 
            this.group_mes.Controls.Add(this.combo_datacad_mes);
            this.group_mes.Location = new System.Drawing.Point(432, 97);
            this.group_mes.Name = "group_mes";
            this.group_mes.Size = new System.Drawing.Size(147, 53);
            this.group_mes.TabIndex = 14;
            this.group_mes.TabStop = false;
            this.group_mes.Text = "Selecione Um Mês";
            // 
            // combo_datacad_mes
            // 
            this.combo_datacad_mes.BackColor = System.Drawing.Color.AliceBlue;
            this.combo_datacad_mes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_datacad_mes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_datacad_mes.FormattingEnabled = true;
            this.combo_datacad_mes.Location = new System.Drawing.Point(16, 19);
            this.combo_datacad_mes.Name = "combo_datacad_mes";
            this.combo_datacad_mes.Size = new System.Drawing.Size(117, 21);
            this.combo_datacad_mes.TabIndex = 9;
            // 
            // group_data
            // 
            this.group_data.Controls.Add(this.mask_data);
            this.group_data.Location = new System.Drawing.Point(637, 97);
            this.group_data.Name = "group_data";
            this.group_data.Size = new System.Drawing.Size(130, 53);
            this.group_data.TabIndex = 13;
            this.group_data.TabStop = false;
            this.group_data.Text = "Pesquisa Por Data";
            // 
            // mask_data
            // 
            this.mask_data.BackColor = System.Drawing.Color.AliceBlue;
            this.mask_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mask_data.Location = new System.Drawing.Point(26, 19);
            this.mask_data.Mask = "00/00/0000";
            this.mask_data.Name = "mask_data";
            this.mask_data.Size = new System.Drawing.Size(79, 20);
            this.mask_data.TabIndex = 13;
            this.mask_data.ValidatingType = typeof(System.DateTime);
            this.mask_data.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.masked_data_TypeValidationCompleted);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ClassFornecedorBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProjetoPapelariaHumanas.Report.ReportFornecedor.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(6, 166);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(761, 242);
            this.reportViewer1.TabIndex = 7;
            // 
            // bt_gerar_relatorio
            // 
            this.bt_gerar_relatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.bt_gerar_relatorio.Image = ((System.Drawing.Image)(resources.GetObject("bt_gerar_relatorio.Image")));
            this.bt_gerar_relatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_gerar_relatorio.Location = new System.Drawing.Point(629, 22);
            this.bt_gerar_relatorio.Name = "bt_gerar_relatorio";
            this.bt_gerar_relatorio.Size = new System.Drawing.Size(138, 56);
            this.bt_gerar_relatorio.TabIndex = 6;
            this.bt_gerar_relatorio.Text = "        Gerar Relatório";
            this.bt_gerar_relatorio.UseVisualStyleBackColor = false;
            this.bt_gerar_relatorio.Click += new System.EventHandler(this.bt_pesquisar_Click);
            // 
            // group_cnpj
            // 
            this.group_cnpj.Controls.Add(this.Mask_Cnpj);
            this.group_cnpj.Location = new System.Drawing.Point(10, 97);
            this.group_cnpj.Name = "group_cnpj";
            this.group_cnpj.Size = new System.Drawing.Size(166, 53);
            this.group_cnpj.TabIndex = 5;
            this.group_cnpj.TabStop = false;
            this.group_cnpj.Text = "CNPJ";
            // 
            // Mask_Cnpj
            // 
            this.Mask_Cnpj.BackColor = System.Drawing.Color.AliceBlue;
            this.Mask_Cnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mask_Cnpj.Location = new System.Drawing.Point(12, 20);
            this.Mask_Cnpj.Mask = "00.000.000/0000-00";
            this.Mask_Cnpj.Name = "Mask_Cnpj";
            this.Mask_Cnpj.Size = new System.Drawing.Size(142, 20);
            this.Mask_Cnpj.TabIndex = 16;
            // 
            // group_status
            // 
            this.group_status.Controls.Add(this.radio_inativo);
            this.group_status.Controls.Add(this.radio_ativo);
            this.group_status.Location = new System.Drawing.Point(432, 25);
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
            this.radio_inativo.Location = new System.Drawing.Point(76, 21);
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
            this.radio_ativo.Location = new System.Drawing.Point(21, 21);
            this.radio_ativo.Name = "radio_ativo";
            this.radio_ativo.Size = new System.Drawing.Size(49, 17);
            this.radio_ativo.TabIndex = 2;
            this.radio_ativo.TabStop = true;
            this.radio_ativo.Text = "Ativo";
            this.radio_ativo.UseVisualStyleBackColor = true;
            // 
            // group_telefone
            // 
            this.group_telefone.Controls.Add(this.Mask_Telefone);
            this.group_telefone.Location = new System.Drawing.Point(221, 25);
            this.group_telefone.Name = "group_telefone";
            this.group_telefone.Size = new System.Drawing.Size(150, 53);
            this.group_telefone.TabIndex = 3;
            this.group_telefone.TabStop = false;
            this.group_telefone.Text = "Telefone";
            // 
            // Mask_Telefone
            // 
            this.Mask_Telefone.BackColor = System.Drawing.Color.AliceBlue;
            this.Mask_Telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mask_Telefone.Location = new System.Drawing.Point(28, 20);
            this.Mask_Telefone.Mask = "(99)-00000-0000";
            this.Mask_Telefone.Name = "Mask_Telefone";
            this.Mask_Telefone.Size = new System.Drawing.Size(96, 20);
            this.Mask_Telefone.TabIndex = 13;
            // 
            // combo_tipo_relatorio
            // 
            this.combo_tipo_relatorio.BackColor = System.Drawing.Color.AliceBlue;
            this.combo_tipo_relatorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_tipo_relatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_tipo_relatorio.FormattingEnabled = true;
            this.combo_tipo_relatorio.Location = new System.Drawing.Point(10, 41);
            this.combo_tipo_relatorio.Name = "combo_tipo_relatorio";
            this.combo_tipo_relatorio.Size = new System.Drawing.Size(166, 21);
            this.combo_tipo_relatorio.TabIndex = 0;
            this.combo_tipo_relatorio.SelectedIndexChanged += new System.EventHandler(this.combo_opcoes_SelectedIndexChanged);
            // 
            // bt_Sair
            // 
            this.bt_Sair.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bt_Sair.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.bt_Sair.Location = new System.Drawing.Point(783, -4);
            this.bt_Sair.Name = "bt_Sair";
            this.bt_Sair.Size = new System.Drawing.Size(31, 28);
            this.bt_Sair.TabIndex = 3;
            this.bt_Sair.Text = "X";
            this.bt_Sair.UseVisualStyleBackColor = false;
            this.bt_Sair.Click += new System.EventHandler(this.bt_Sair_Click);
            // 
            // label_fornecedor
            // 
            this.label_fornecedor.AutoSize = true;
            this.label_fornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label_fornecedor.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_fornecedor.Location = new System.Drawing.Point(283, 19);
            this.label_fornecedor.Name = "label_fornecedor";
            this.label_fornecedor.Size = new System.Drawing.Size(263, 29);
            this.label_fornecedor.TabIndex = 6;
            this.label_fornecedor.Text = "Relatório Fornecedor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 18);
            this.label5.TabIndex = 18;
            this.label5.Text = "Sistema Papelaria Humanas";
            // 
            // bt_ajuda
            // 
            this.bt_ajuda.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_ajuda.Location = new System.Drawing.Point(758, -1);
            this.bt_ajuda.Name = "bt_ajuda";
            this.bt_ajuda.Size = new System.Drawing.Size(19, 19);
            this.bt_ajuda.Style = MetroFramework.MetroColorStyle.Silver;
            this.bt_ajuda.TabIndex = 48;
            this.bt_ajuda.Text = " ?";
            this.bt_ajuda.UseSelectable = true;
            this.bt_ajuda.Click += new System.EventHandler(this.bt_ajuda_Click);
            // 
            // RelatorioFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(810, 483);
            this.Controls.Add(this.bt_ajuda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_fornecedor);
            this.Controls.Add(this.bt_Sair);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RelatorioFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RelatorioFornecedor";
            this.Load += new System.EventHandler(this.RelatorioFornecedor_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.ClassFornecedorBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.group_cidade.ResumeLayout(false);
            this.group_mes.ResumeLayout(false);
            this.group_data.ResumeLayout(false);
            this.group_data.PerformLayout();
            this.group_cnpj.ResumeLayout(false);
            this.group_cnpj.PerformLayout();
            this.group_status.ResumeLayout(false);
            this.group_status.PerformLayout();
            this.group_telefone.ResumeLayout(false);
            this.group_telefone.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource ClassFornecedorBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button bt_gerar_relatorio;
        private System.Windows.Forms.GroupBox group_cnpj;
        private System.Windows.Forms.GroupBox group_status;
        private System.Windows.Forms.GroupBox group_telefone;
        private System.Windows.Forms.ComboBox combo_tipo_relatorio;
        public System.Windows.Forms.MaskedTextBox Mask_Cnpj;
        public System.Windows.Forms.RadioButton radio_inativo;
        public System.Windows.Forms.RadioButton radio_ativo;
        public System.Windows.Forms.MaskedTextBox Mask_Telefone;
        private System.Windows.Forms.ComboBox combo_datacad_mes;
        private System.Windows.Forms.ComboBox combo_cidade;
        private System.Windows.Forms.GroupBox group_data;
        private System.Windows.Forms.MaskedTextBox mask_data;
        private System.Windows.Forms.Button bt_Sair;
        private System.Windows.Forms.Label label_fornecedor;
        private System.Windows.Forms.GroupBox group_mes;
        private System.Windows.Forms.GroupBox group_cidade;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroButton bt_ajuda;
    }
}