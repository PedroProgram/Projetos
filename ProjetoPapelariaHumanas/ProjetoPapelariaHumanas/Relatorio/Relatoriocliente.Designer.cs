
namespace ProjetoPapelariaHumanas
{
    partial class Relatoriocliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Relatoriocliente));
            this.ClassClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox_rel_cli = new System.Windows.Forms.GroupBox();
            this.groupBox_status = new System.Windows.Forms.GroupBox();
            this.radio_inativo = new System.Windows.Forms.RadioButton();
            this.radio_ativo = new System.Windows.Forms.RadioButton();
            this.groupBox_idade = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.box_idade_final = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.box_idade_inicio = new System.Windows.Forms.TextBox();
            this.groupBox_cidade = new System.Windows.Forms.GroupBox();
            this.box_cidade = new System.Windows.Forms.TextBox();
            this.groupBox_sexo = new System.Windows.Forms.GroupBox();
            this.radio_masculino = new System.Windows.Forms.RadioButton();
            this.radio_feminino = new System.Windows.Forms.RadioButton();
            this.groupBox_maiores_de = new System.Windows.Forms.GroupBox();
            this.box_maior = new System.Windows.Forms.TextBox();
            this.button_relatorio = new System.Windows.Forms.Button();
            this.combo_tipo_relatorio = new System.Windows.Forms.ComboBox();
            this.bt_sair = new System.Windows.Forms.Button();
            this.lb_cadastro_cliente = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_ajuda = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.ClassClienteBindingSource)).BeginInit();
            this.groupBox_rel_cli.SuspendLayout();
            this.groupBox_status.SuspendLayout();
            this.groupBox_idade.SuspendLayout();
            this.groupBox_cidade.SuspendLayout();
            this.groupBox_sexo.SuspendLayout();
            this.groupBox_maiores_de.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClassClienteBindingSource
            // 
            this.ClassClienteBindingSource.DataSource = typeof(ProjetoPapelariaHumanas.ClassCliente);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ClassClienteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProjetoPapelariaHumanas.Report.ReportCliente.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 213);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(775, 234);
            this.reportViewer1.TabIndex = 0;
            // 
            // groupBox_rel_cli
            // 
            this.groupBox_rel_cli.Controls.Add(this.groupBox_status);
            this.groupBox_rel_cli.Controls.Add(this.groupBox_idade);
            this.groupBox_rel_cli.Controls.Add(this.groupBox_cidade);
            this.groupBox_rel_cli.Controls.Add(this.groupBox_sexo);
            this.groupBox_rel_cli.Controls.Add(this.groupBox_maiores_de);
            this.groupBox_rel_cli.Controls.Add(this.button_relatorio);
            this.groupBox_rel_cli.Controls.Add(this.combo_tipo_relatorio);
            this.groupBox_rel_cli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox_rel_cli.Location = new System.Drawing.Point(13, 46);
            this.groupBox_rel_cli.Name = "groupBox_rel_cli";
            this.groupBox_rel_cli.Size = new System.Drawing.Size(775, 161);
            this.groupBox_rel_cli.TabIndex = 1;
            this.groupBox_rel_cli.TabStop = false;
            this.groupBox_rel_cli.Text = "Opções de Relatório";
            // 
            // groupBox_status
            // 
            this.groupBox_status.Controls.Add(this.radio_inativo);
            this.groupBox_status.Controls.Add(this.radio_ativo);
            this.groupBox_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox_status.Location = new System.Drawing.Point(423, 28);
            this.groupBox_status.Name = "groupBox_status";
            this.groupBox_status.Size = new System.Drawing.Size(163, 44);
            this.groupBox_status.TabIndex = 16;
            this.groupBox_status.TabStop = false;
            this.groupBox_status.Text = "Status";
            // 
            // radio_inativo
            // 
            this.radio_inativo.AutoSize = true;
            this.radio_inativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_inativo.Location = new System.Drawing.Point(92, 18);
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
            this.radio_ativo.Location = new System.Drawing.Point(19, 17);
            this.radio_ativo.Name = "radio_ativo";
            this.radio_ativo.Size = new System.Drawing.Size(49, 17);
            this.radio_ativo.TabIndex = 0;
            this.radio_ativo.TabStop = true;
            this.radio_ativo.Text = "Ativo";
            this.radio_ativo.UseVisualStyleBackColor = true;
            // 
            // groupBox_idade
            // 
            this.groupBox_idade.Controls.Add(this.label2);
            this.groupBox_idade.Controls.Add(this.box_idade_final);
            this.groupBox_idade.Controls.Add(this.label3);
            this.groupBox_idade.Controls.Add(this.box_idade_inicio);
            this.groupBox_idade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox_idade.Location = new System.Drawing.Point(423, 98);
            this.groupBox_idade.Name = "groupBox_idade";
            this.groupBox_idade.Size = new System.Drawing.Size(213, 53);
            this.groupBox_idade.TabIndex = 12;
            this.groupBox_idade.TabStop = false;
            this.groupBox_idade.Text = "Idade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "De :";
            // 
            // box_idade_final
            // 
            this.box_idade_final.BackColor = System.Drawing.Color.AliceBlue;
            this.box_idade_final.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_idade_final.Location = new System.Drawing.Point(144, 19);
            this.box_idade_final.Name = "box_idade_final";
            this.box_idade_final.Size = new System.Drawing.Size(54, 20);
            this.box_idade_final.TabIndex = 9;
            this.box_idade_final.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.box_idade_final_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Até :";
            // 
            // box_idade_inicio
            // 
            this.box_idade_inicio.BackColor = System.Drawing.Color.AliceBlue;
            this.box_idade_inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_idade_inicio.Location = new System.Drawing.Point(38, 19);
            this.box_idade_inicio.Name = "box_idade_inicio";
            this.box_idade_inicio.Size = new System.Drawing.Size(54, 20);
            this.box_idade_inicio.TabIndex = 8;
            this.box_idade_inicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.box_idade_inicio_KeyPress);
            // 
            // groupBox_cidade
            // 
            this.groupBox_cidade.Controls.Add(this.box_cidade);
            this.groupBox_cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox_cidade.Location = new System.Drawing.Point(263, 98);
            this.groupBox_cidade.Name = "groupBox_cidade";
            this.groupBox_cidade.Size = new System.Drawing.Size(138, 49);
            this.groupBox_cidade.TabIndex = 15;
            this.groupBox_cidade.TabStop = false;
            this.groupBox_cidade.Text = "Cidade";
            // 
            // box_cidade
            // 
            this.box_cidade.BackColor = System.Drawing.Color.AliceBlue;
            this.box_cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_cidade.Location = new System.Drawing.Point(21, 19);
            this.box_cidade.Name = "box_cidade";
            this.box_cidade.Size = new System.Drawing.Size(100, 20);
            this.box_cidade.TabIndex = 0;
            // 
            // groupBox_sexo
            // 
            this.groupBox_sexo.Controls.Add(this.radio_masculino);
            this.groupBox_sexo.Controls.Add(this.radio_feminino);
            this.groupBox_sexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox_sexo.Location = new System.Drawing.Point(16, 98);
            this.groupBox_sexo.Name = "groupBox_sexo";
            this.groupBox_sexo.Size = new System.Drawing.Size(213, 49);
            this.groupBox_sexo.TabIndex = 14;
            this.groupBox_sexo.TabStop = false;
            this.groupBox_sexo.Text = "Sexo";
            // 
            // radio_masculino
            // 
            this.radio_masculino.AutoSize = true;
            this.radio_masculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_masculino.Location = new System.Drawing.Point(112, 20);
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
            this.radio_feminino.Location = new System.Drawing.Point(19, 19);
            this.radio_feminino.Name = "radio_feminino";
            this.radio_feminino.Size = new System.Drawing.Size(67, 17);
            this.radio_feminino.TabIndex = 0;
            this.radio_feminino.TabStop = true;
            this.radio_feminino.Text = "Feminino";
            this.radio_feminino.UseVisualStyleBackColor = true;
            // 
            // groupBox_maiores_de
            // 
            this.groupBox_maiores_de.Controls.Add(this.box_maior);
            this.groupBox_maiores_de.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox_maiores_de.Location = new System.Drawing.Point(275, 23);
            this.groupBox_maiores_de.Name = "groupBox_maiores_de";
            this.groupBox_maiores_de.Size = new System.Drawing.Size(126, 49);
            this.groupBox_maiores_de.TabIndex = 13;
            this.groupBox_maiores_de.TabStop = false;
            this.groupBox_maiores_de.Text = "Maiores De :";
            // 
            // box_maior
            // 
            this.box_maior.BackColor = System.Drawing.Color.AliceBlue;
            this.box_maior.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_maior.Location = new System.Drawing.Point(21, 19);
            this.box_maior.Name = "box_maior";
            this.box_maior.Size = new System.Drawing.Size(80, 20);
            this.box_maior.TabIndex = 0;
            this.box_maior.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.box_maior_KeyPress);
            // 
            // button_relatorio
            // 
            this.button_relatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.button_relatorio.Image = ((System.Drawing.Image)(resources.GetObject("button_relatorio.Image")));
            this.button_relatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_relatorio.Location = new System.Drawing.Point(631, 20);
            this.button_relatorio.Name = "button_relatorio";
            this.button_relatorio.Size = new System.Drawing.Size(141, 53);
            this.button_relatorio.TabIndex = 7;
            this.button_relatorio.Text = "      Gerar Relatório";
            this.button_relatorio.UseVisualStyleBackColor = false;
            this.button_relatorio.Click += new System.EventHandler(this.button_relatorio_Click);
            // 
            // combo_tipo_relatorio
            // 
            this.combo_tipo_relatorio.BackColor = System.Drawing.Color.AliceBlue;
            this.combo_tipo_relatorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_tipo_relatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_tipo_relatorio.FormattingEnabled = true;
            this.combo_tipo_relatorio.Location = new System.Drawing.Point(6, 34);
            this.combo_tipo_relatorio.Name = "combo_tipo_relatorio";
            this.combo_tipo_relatorio.Size = new System.Drawing.Size(258, 21);
            this.combo_tipo_relatorio.TabIndex = 6;
            this.combo_tipo_relatorio.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
            // 
            // bt_sair
            // 
            this.bt_sair.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bt_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.bt_sair.Location = new System.Drawing.Point(773, -4);
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
            this.lb_cadastro_cliente.Location = new System.Drawing.Point(262, 9);
            this.lb_cadastro_cliente.Name = "lb_cadastro_cliente";
            this.lb_cadastro_cliente.Size = new System.Drawing.Size(247, 29);
            this.lb_cadastro_cliente.TabIndex = 30;
            this.lb_cadastro_cliente.Text = "Relatório de Cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 18);
            this.label5.TabIndex = 31;
            this.label5.Text = "Sistema Papelaria Humanas";
            // 
            // bt_ajuda
            // 
            this.bt_ajuda.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_ajuda.Location = new System.Drawing.Point(748, 0);
            this.bt_ajuda.Name = "bt_ajuda";
            this.bt_ajuda.Size = new System.Drawing.Size(19, 19);
            this.bt_ajuda.Style = MetroFramework.MetroColorStyle.Silver;
            this.bt_ajuda.TabIndex = 48;
            this.bt_ajuda.Text = " ?";
            this.bt_ajuda.UseSelectable = true;
            this.bt_ajuda.Click += new System.EventHandler(this.bt_ajuda_Click);
            // 
            // Relatoriocliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.bt_ajuda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_cadastro_cliente);
            this.Controls.Add(this.bt_sair);
            this.Controls.Add(this.groupBox_rel_cli);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Relatoriocliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRelcliente";
            this.Load += new System.EventHandler(this.FormRelcliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClassClienteBindingSource)).EndInit();
            this.groupBox_rel_cli.ResumeLayout(false);
            this.groupBox_status.ResumeLayout(false);
            this.groupBox_status.PerformLayout();
            this.groupBox_idade.ResumeLayout(false);
            this.groupBox_idade.PerformLayout();
            this.groupBox_cidade.ResumeLayout(false);
            this.groupBox_cidade.PerformLayout();
            this.groupBox_sexo.ResumeLayout(false);
            this.groupBox_sexo.PerformLayout();
            this.groupBox_maiores_de.ResumeLayout(false);
            this.groupBox_maiores_de.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ClassClienteBindingSource;
        private System.Windows.Forms.GroupBox groupBox_rel_cli;
        private System.Windows.Forms.ComboBox combo_tipo_relatorio;
        private System.Windows.Forms.Button button_relatorio;
        private System.Windows.Forms.GroupBox groupBox_idade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox box_idade_final;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox box_idade_inicio;
        private System.Windows.Forms.GroupBox groupBox_maiores_de;
        private System.Windows.Forms.TextBox box_maior;
        private System.Windows.Forms.GroupBox groupBox_sexo;
        private System.Windows.Forms.RadioButton radio_masculino;
        private System.Windows.Forms.RadioButton radio_feminino;
        private System.Windows.Forms.GroupBox groupBox_cidade;
        private System.Windows.Forms.TextBox box_cidade;
        private System.Windows.Forms.GroupBox groupBox_status;
        private System.Windows.Forms.RadioButton radio_inativo;
        private System.Windows.Forms.RadioButton radio_ativo;
        private System.Windows.Forms.Button bt_sair;
        private System.Windows.Forms.Label lb_cadastro_cliente;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroButton bt_ajuda;
    }
}