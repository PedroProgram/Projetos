
namespace ProjetoPapelariaHumanas
{
    partial class RelatorioFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelatorioFuncionario));
            this.ClassFuncionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.combo_tipo_relatorio = new System.Windows.Forms.ComboBox();
            this.groupBox_sexo = new System.Windows.Forms.GroupBox();
            this.radio_masculino = new System.Windows.Forms.RadioButton();
            this.radio_feminino = new System.Windows.Forms.RadioButton();
            this.group_box_cargo = new System.Windows.Forms.GroupBox();
            this.combo_c = new System.Windows.Forms.ComboBox();
            this.groupBox_status = new System.Windows.Forms.GroupBox();
            this.radio_inativo = new System.Windows.Forms.RadioButton();
            this.radio_ativo = new System.Windows.Forms.RadioButton();
            this.groupBox_cidade = new System.Windows.Forms.GroupBox();
            this.box_cidade = new System.Windows.Forms.TextBox();
            this.groupBox_idade = new System.Windows.Forms.GroupBox();
            this.box_final = new System.Windows.Forms.TextBox();
            this.box_inicio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_sair = new System.Windows.Forms.Button();
            this.lb_cadastro_cliente = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_ajuda = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.ClassFuncionarioBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox_sexo.SuspendLayout();
            this.group_box_cargo.SuspendLayout();
            this.groupBox_status.SuspendLayout();
            this.groupBox_cidade.SuspendLayout();
            this.groupBox_idade.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClassFuncionarioBindingSource
            // 
            this.ClassFuncionarioBindingSource.DataSource = typeof(ProjetoPapelariaHumanas.ClassFuncionario);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ClassFuncionarioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProjetoPapelariaHumanas.Report.ReportFuncionario.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 219);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 236);
            this.reportViewer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.combo_tipo_relatorio);
            this.groupBox1.Controls.Add(this.groupBox_sexo);
            this.groupBox1.Controls.Add(this.group_box_cargo);
            this.groupBox1.Controls.Add(this.groupBox_status);
            this.groupBox1.Controls.Add(this.groupBox_cidade);
            this.groupBox1.Controls.Add(this.groupBox_idade);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 172);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opções de Relatório";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(631, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 62);
            this.button1.TabIndex = 7;
            this.button1.Text = "      Gerar Relatório";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // combo_tipo_relatorio
            // 
            this.combo_tipo_relatorio.BackColor = System.Drawing.Color.AliceBlue;
            this.combo_tipo_relatorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_tipo_relatorio.FormattingEnabled = true;
            this.combo_tipo_relatorio.Location = new System.Drawing.Point(6, 38);
            this.combo_tipo_relatorio.Name = "combo_tipo_relatorio";
            this.combo_tipo_relatorio.Size = new System.Drawing.Size(251, 21);
            this.combo_tipo_relatorio.TabIndex = 6;
            this.combo_tipo_relatorio.SelectedIndexChanged += new System.EventHandler(this.comboBox_tipo_consul_SelectedIndexChanged);
            // 
            // groupBox_sexo
            // 
            this.groupBox_sexo.Controls.Add(this.radio_masculino);
            this.groupBox_sexo.Controls.Add(this.radio_feminino);
            this.groupBox_sexo.Location = new System.Drawing.Point(488, 99);
            this.groupBox_sexo.Name = "groupBox_sexo";
            this.groupBox_sexo.Size = new System.Drawing.Size(160, 45);
            this.groupBox_sexo.TabIndex = 4;
            this.groupBox_sexo.TabStop = false;
            this.groupBox_sexo.Text = "Sexo";
            // 
            // radio_masculino
            // 
            this.radio_masculino.AutoSize = true;
            this.radio_masculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_masculino.Location = new System.Drawing.Point(83, 16);
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
            this.radio_feminino.Location = new System.Drawing.Point(14, 16);
            this.radio_feminino.Name = "radio_feminino";
            this.radio_feminino.Size = new System.Drawing.Size(67, 17);
            this.radio_feminino.TabIndex = 0;
            this.radio_feminino.TabStop = true;
            this.radio_feminino.Text = "Feminino";
            this.radio_feminino.UseVisualStyleBackColor = true;
            // 
            // group_box_cargo
            // 
            this.group_box_cargo.Controls.Add(this.combo_c);
            this.group_box_cargo.Location = new System.Drawing.Point(6, 99);
            this.group_box_cargo.Name = "group_box_cargo";
            this.group_box_cargo.Size = new System.Drawing.Size(177, 45);
            this.group_box_cargo.TabIndex = 3;
            this.group_box_cargo.TabStop = false;
            this.group_box_cargo.Text = "Cargo";
            // 
            // combo_c
            // 
            this.combo_c.BackColor = System.Drawing.Color.AliceBlue;
            this.combo_c.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_c.FormattingEnabled = true;
            this.combo_c.Location = new System.Drawing.Point(20, 18);
            this.combo_c.Name = "combo_c";
            this.combo_c.Size = new System.Drawing.Size(121, 21);
            this.combo_c.TabIndex = 0;
            // 
            // groupBox_status
            // 
            this.groupBox_status.Controls.Add(this.radio_inativo);
            this.groupBox_status.Controls.Add(this.radio_ativo);
            this.groupBox_status.Location = new System.Drawing.Point(488, 19);
            this.groupBox_status.Name = "groupBox_status";
            this.groupBox_status.Size = new System.Drawing.Size(122, 66);
            this.groupBox_status.TabIndex = 2;
            this.groupBox_status.TabStop = false;
            this.groupBox_status.Text = "Status";
            // 
            // radio_inativo
            // 
            this.radio_inativo.AutoSize = true;
            this.radio_inativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_inativo.Location = new System.Drawing.Point(63, 29);
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
            this.radio_ativo.Location = new System.Drawing.Point(7, 31);
            this.radio_ativo.Name = "radio_ativo";
            this.radio_ativo.Size = new System.Drawing.Size(49, 17);
            this.radio_ativo.TabIndex = 0;
            this.radio_ativo.TabStop = true;
            this.radio_ativo.Text = "Ativo";
            this.radio_ativo.UseVisualStyleBackColor = true;
            // 
            // groupBox_cidade
            // 
            this.groupBox_cidade.Controls.Add(this.box_cidade);
            this.groupBox_cidade.Location = new System.Drawing.Point(218, 99);
            this.groupBox_cidade.Name = "groupBox_cidade";
            this.groupBox_cidade.Size = new System.Drawing.Size(166, 45);
            this.groupBox_cidade.TabIndex = 1;
            this.groupBox_cidade.TabStop = false;
            this.groupBox_cidade.Text = "Cidade";
            // 
            // box_cidade
            // 
            this.box_cidade.BackColor = System.Drawing.Color.AliceBlue;
            this.box_cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_cidade.Location = new System.Drawing.Point(22, 19);
            this.box_cidade.Name = "box_cidade";
            this.box_cidade.Size = new System.Drawing.Size(127, 20);
            this.box_cidade.TabIndex = 0;
            // 
            // groupBox_idade
            // 
            this.groupBox_idade.Controls.Add(this.box_final);
            this.groupBox_idade.Controls.Add(this.box_inicio);
            this.groupBox_idade.Controls.Add(this.label2);
            this.groupBox_idade.Controls.Add(this.label1);
            this.groupBox_idade.Location = new System.Drawing.Point(273, 19);
            this.groupBox_idade.Name = "groupBox_idade";
            this.groupBox_idade.Size = new System.Drawing.Size(177, 66);
            this.groupBox_idade.TabIndex = 0;
            this.groupBox_idade.TabStop = false;
            this.groupBox_idade.Text = "Idade";
            // 
            // box_final
            // 
            this.box_final.BackColor = System.Drawing.Color.AliceBlue;
            this.box_final.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_final.Location = new System.Drawing.Point(117, 26);
            this.box_final.Name = "box_final";
            this.box_final.Size = new System.Drawing.Size(36, 20);
            this.box_final.TabIndex = 3;
            this.box_final.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.box_final_KeyPress);
            // 
            // box_inicio
            // 
            this.box_inicio.BackColor = System.Drawing.Color.AliceBlue;
            this.box_inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_inicio.Location = new System.Drawing.Point(40, 26);
            this.box_inicio.Name = "box_inicio";
            this.box_inicio.Size = new System.Drawing.Size(35, 20);
            this.box_inicio.TabIndex = 2;
            this.box_inicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.box_inicio_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Até :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "De :";
            // 
            // bt_sair
            // 
            this.bt_sair.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bt_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.bt_sair.Location = new System.Drawing.Point(776, -4);
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.Size = new System.Drawing.Size(31, 28);
            this.bt_sair.TabIndex = 5;
            this.bt_sair.Text = "X";
            this.bt_sair.UseVisualStyleBackColor = false;
            this.bt_sair.Click += new System.EventHandler(this.bt_sair_Click);
            // 
            // lb_cadastro_cliente
            // 
            this.lb_cadastro_cliente.AutoSize = true;
            this.lb_cadastro_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cadastro_cliente.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lb_cadastro_cliente.Location = new System.Drawing.Point(270, 9);
            this.lb_cadastro_cliente.Name = "lb_cadastro_cliente";
            this.lb_cadastro_cliente.Size = new System.Drawing.Size(302, 29);
            this.lb_cadastro_cliente.TabIndex = 30;
            this.lb_cadastro_cliente.Text = "Relatório de Funcionário";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 18);
            this.label5.TabIndex = 31;
            this.label5.Text = "Sistema Papelaria Humanas";
            // 
            // bt_ajuda
            // 
            this.bt_ajuda.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_ajuda.Location = new System.Drawing.Point(751, 0);
            this.bt_ajuda.Name = "bt_ajuda";
            this.bt_ajuda.Size = new System.Drawing.Size(19, 19);
            this.bt_ajuda.Style = MetroFramework.MetroColorStyle.Silver;
            this.bt_ajuda.TabIndex = 48;
            this.bt_ajuda.Text = " ?";
            this.bt_ajuda.UseSelectable = true;
            this.bt_ajuda.Click += new System.EventHandler(this.bt_ajuda_Click);
            // 
            // RelatorioFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(803, 467);
            this.Controls.Add(this.bt_ajuda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_cadastro_cliente);
            this.Controls.Add(this.bt_sair);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RelatorioFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRelFuncionario";
            this.Load += new System.EventHandler(this.FormRelFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClassFuncionarioBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox_sexo.ResumeLayout(false);
            this.groupBox_sexo.PerformLayout();
            this.group_box_cargo.ResumeLayout(false);
            this.groupBox_status.ResumeLayout(false);
            this.groupBox_status.PerformLayout();
            this.groupBox_cidade.ResumeLayout(false);
            this.groupBox_cidade.PerformLayout();
            this.groupBox_idade.ResumeLayout(false);
            this.groupBox_idade.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox_sexo;
        private System.Windows.Forms.GroupBox group_box_cargo;
        private System.Windows.Forms.GroupBox groupBox_status;
        private System.Windows.Forms.GroupBox groupBox_cidade;
        private System.Windows.Forms.GroupBox groupBox_idade;
        private System.Windows.Forms.TextBox box_final;
        private System.Windows.Forms.TextBox box_inicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_tipo_relatorio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox box_cidade;
        private System.Windows.Forms.ComboBox combo_c;
        private System.Windows.Forms.RadioButton radio_inativo;
        private System.Windows.Forms.RadioButton radio_ativo;
        private System.Windows.Forms.RadioButton radio_masculino;
        private System.Windows.Forms.RadioButton radio_feminino;
        private System.Windows.Forms.BindingSource ClassFuncionarioBindingSource;
        private System.Windows.Forms.Button bt_sair;
        private System.Windows.Forms.Label lb_cadastro_cliente;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroButton bt_ajuda;
    }
}