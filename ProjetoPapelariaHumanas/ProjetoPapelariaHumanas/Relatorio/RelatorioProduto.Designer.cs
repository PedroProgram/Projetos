
namespace ProjetoPapelariaHumanas
{
    partial class RelatorioProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelatorioProduto));
            this.ClassProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.group_mes = new System.Windows.Forms.GroupBox();
            this.combo_datacad_mes = new System.Windows.Forms.ComboBox();
            this.group_preco = new System.Windows.Forms.GroupBox();
            this.Box_preco = new System.Windows.Forms.TextBox();
            this.group_data = new System.Windows.Forms.GroupBox();
            this.mask_data = new System.Windows.Forms.MaskedTextBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bt_gerar_relatorio = new System.Windows.Forms.Button();
            this.group_status = new System.Windows.Forms.GroupBox();
            this.radio_inativo = new System.Windows.Forms.RadioButton();
            this.radio_ativo = new System.Windows.Forms.RadioButton();
            this.group_quantidade = new System.Windows.Forms.GroupBox();
            this.Box_quantidade = new System.Windows.Forms.TextBox();
            this.combo_tipo_relatorio = new System.Windows.Forms.ComboBox();
            this.bt_Sair = new System.Windows.Forms.Button();
            this.label_fornecedor = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ClassRelVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bt_ajuda = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.ClassProdutoBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.group_mes.SuspendLayout();
            this.group_preco.SuspendLayout();
            this.group_data.SuspendLayout();
            this.group_status.SuspendLayout();
            this.group_quantidade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClassRelVendaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ClassProdutoBindingSource
            // 
            this.ClassProdutoBindingSource.DataSource = typeof(ProjetoPapelariaHumanas.ClassProduto);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.group_mes);
            this.groupBox1.Controls.Add(this.group_preco);
            this.groupBox1.Controls.Add(this.group_data);
            this.groupBox1.Controls.Add(this.reportViewer1);
            this.groupBox1.Controls.Add(this.bt_gerar_relatorio);
            this.groupBox1.Controls.Add(this.group_status);
            this.groupBox1.Controls.Add(this.group_quantidade);
            this.groupBox1.Controls.Add(this.combo_tipo_relatorio);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(754, 428);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa de Fornecedor";
            // 
            // group_mes
            // 
            this.group_mes.Controls.Add(this.combo_datacad_mes);
            this.group_mes.Location = new System.Drawing.Point(221, 101);
            this.group_mes.Name = "group_mes";
            this.group_mes.Size = new System.Drawing.Size(150, 53);
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
            this.combo_datacad_mes.Location = new System.Drawing.Point(21, 20);
            this.combo_datacad_mes.Name = "combo_datacad_mes";
            this.combo_datacad_mes.Size = new System.Drawing.Size(117, 21);
            this.combo_datacad_mes.TabIndex = 9;
            // 
            // group_preco
            // 
            this.group_preco.Controls.Add(this.Box_preco);
            this.group_preco.Location = new System.Drawing.Point(26, 101);
            this.group_preco.Name = "group_preco";
            this.group_preco.Size = new System.Drawing.Size(150, 53);
            this.group_preco.TabIndex = 14;
            this.group_preco.TabStop = false;
            this.group_preco.Text = "preco";
            // 
            // Box_preco
            // 
            this.Box_preco.BackColor = System.Drawing.Color.AliceBlue;
            this.Box_preco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_preco.Location = new System.Drawing.Point(13, 20);
            this.Box_preco.Name = "Box_preco";
            this.Box_preco.Size = new System.Drawing.Size(125, 20);
            this.Box_preco.TabIndex = 0;
            this.Box_preco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Box_preco_KeyPress);
            // 
            // group_data
            // 
            this.group_data.Controls.Add(this.mask_data);
            this.group_data.Location = new System.Drawing.Point(453, 101);
            this.group_data.Name = "group_data";
            this.group_data.Size = new System.Drawing.Size(128, 53);
            this.group_data.TabIndex = 13;
            this.group_data.TabStop = false;
            this.group_data.Text = "Pesquisa Por Data";
            // 
            // mask_data
            // 
            this.mask_data.BackColor = System.Drawing.Color.AliceBlue;
            this.mask_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mask_data.Location = new System.Drawing.Point(28, 19);
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
            reportDataSource1.Value = this.ClassProdutoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProjetoPapelariaHumanas.Report.ReportProduto.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(10, 172);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(738, 249);
            this.reportViewer1.TabIndex = 7;
            // 
            // bt_gerar_relatorio
            // 
            this.bt_gerar_relatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.bt_gerar_relatorio.Image = ((System.Drawing.Image)(resources.GetObject("bt_gerar_relatorio.Image")));
            this.bt_gerar_relatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_gerar_relatorio.Location = new System.Drawing.Point(604, 34);
            this.bt_gerar_relatorio.Name = "bt_gerar_relatorio";
            this.bt_gerar_relatorio.Size = new System.Drawing.Size(131, 53);
            this.bt_gerar_relatorio.TabIndex = 6;
            this.bt_gerar_relatorio.Text = "    Gerar Relatório";
            this.bt_gerar_relatorio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_gerar_relatorio.UseVisualStyleBackColor = false;
            this.bt_gerar_relatorio.Click += new System.EventHandler(this.bt_gerar_relatorio_Click);
            // 
            // group_status
            // 
            this.group_status.Controls.Add(this.radio_inativo);
            this.group_status.Controls.Add(this.radio_ativo);
            this.group_status.Location = new System.Drawing.Point(424, 31);
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
            // group_quantidade
            // 
            this.group_quantidade.Controls.Add(this.Box_quantidade);
            this.group_quantidade.Location = new System.Drawing.Point(221, 31);
            this.group_quantidade.Name = "group_quantidade";
            this.group_quantidade.Size = new System.Drawing.Size(150, 53);
            this.group_quantidade.TabIndex = 3;
            this.group_quantidade.TabStop = false;
            this.group_quantidade.Text = "quantidade";
            // 
            // Box_quantidade
            // 
            this.Box_quantidade.BackColor = System.Drawing.Color.AliceBlue;
            this.Box_quantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_quantidade.Location = new System.Drawing.Point(13, 20);
            this.Box_quantidade.Name = "Box_quantidade";
            this.Box_quantidade.Size = new System.Drawing.Size(125, 20);
            this.Box_quantidade.TabIndex = 0;
            this.Box_quantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Box_quantidade_KeyPress);
            // 
            // combo_tipo_relatorio
            // 
            this.combo_tipo_relatorio.BackColor = System.Drawing.Color.AliceBlue;
            this.combo_tipo_relatorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_tipo_relatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_tipo_relatorio.FormattingEnabled = true;
            this.combo_tipo_relatorio.Location = new System.Drawing.Point(10, 47);
            this.combo_tipo_relatorio.Name = "combo_tipo_relatorio";
            this.combo_tipo_relatorio.Size = new System.Drawing.Size(166, 21);
            this.combo_tipo_relatorio.TabIndex = 0;
            this.combo_tipo_relatorio.SelectedIndexChanged += new System.EventHandler(this.combo_opcoes_SelectedIndexChanged);
            // 
            // bt_Sair
            // 
            this.bt_Sair.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bt_Sair.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.bt_Sair.Location = new System.Drawing.Point(760, -4);
            this.bt_Sair.Name = "bt_Sair";
            this.bt_Sair.Size = new System.Drawing.Size(31, 28);
            this.bt_Sair.TabIndex = 15;
            this.bt_Sair.Text = "X";
            this.bt_Sair.UseVisualStyleBackColor = false;
            this.bt_Sair.Click += new System.EventHandler(this.bt_Sair_Click);
            // 
            // label_fornecedor
            // 
            this.label_fornecedor.AutoSize = true;
            this.label_fornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label_fornecedor.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_fornecedor.Location = new System.Drawing.Point(297, 15);
            this.label_fornecedor.Name = "label_fornecedor";
            this.label_fornecedor.Size = new System.Drawing.Size(219, 29);
            this.label_fornecedor.TabIndex = 15;
            this.label_fornecedor.Text = "Relatório Produto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 18);
            this.label5.TabIndex = 18;
            this.label5.Text = "Sistema Papelaria Humanas";
            // 
            // ClassRelVendaBindingSource
            // 
            this.ClassRelVendaBindingSource.DataSource = typeof(ProjetoPapelariaHumanas.ClassRelVenda);
            // 
            // bt_ajuda
            // 
            this.bt_ajuda.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_ajuda.Location = new System.Drawing.Point(735, 0);
            this.bt_ajuda.Name = "bt_ajuda";
            this.bt_ajuda.Size = new System.Drawing.Size(19, 19);
            this.bt_ajuda.Style = MetroFramework.MetroColorStyle.Silver;
            this.bt_ajuda.TabIndex = 48;
            this.bt_ajuda.Text = " ?";
            this.bt_ajuda.UseSelectable = true;
            this.bt_ajuda.Click += new System.EventHandler(this.bt_ajuda_Click);
            // 
            // RelatorioProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(787, 488);
            this.Controls.Add(this.bt_ajuda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_fornecedor);
            this.Controls.Add(this.bt_Sair);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RelatorioProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RelatorioProduto";
            this.Load += new System.EventHandler(this.RelatorioProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClassProdutoBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.group_mes.ResumeLayout(false);
            this.group_preco.ResumeLayout(false);
            this.group_preco.PerformLayout();
            this.group_data.ResumeLayout(false);
            this.group_data.PerformLayout();
            this.group_status.ResumeLayout(false);
            this.group_status.PerformLayout();
            this.group_quantidade.ResumeLayout(false);
            this.group_quantidade.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClassRelVendaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox group_data;
        private System.Windows.Forms.MaskedTextBox mask_data;
        private System.Windows.Forms.ComboBox combo_datacad_mes;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button bt_gerar_relatorio;
        private System.Windows.Forms.GroupBox group_status;
        public System.Windows.Forms.RadioButton radio_inativo;
        public System.Windows.Forms.RadioButton radio_ativo;
        private System.Windows.Forms.GroupBox group_quantidade;
        private System.Windows.Forms.ComboBox combo_tipo_relatorio;
        private System.Windows.Forms.TextBox Box_quantidade;
        private System.Windows.Forms.GroupBox group_preco;
        private System.Windows.Forms.TextBox Box_preco;
        private System.Windows.Forms.BindingSource ClassProdutoBindingSource;
        private System.Windows.Forms.Button bt_Sair;
        private System.Windows.Forms.Label label_fornecedor;
        private System.Windows.Forms.GroupBox group_mes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource ClassRelVendaBindingSource;
        private MetroFramework.Controls.MetroButton bt_ajuda;
    }
}