
namespace ProjetoPapelariaHumanas
{
    partial class FormRelcliente
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox_rel_cli = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.box_cidade = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radio_masculino = new System.Windows.Forms.RadioButton();
            this.radio_feminino = new System.Windows.Forms.RadioButton();
            this.groupBox_maiores_de = new System.Windows.Forms.GroupBox();
            this.box_maior = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.box_idade_final = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.box_idade_inicio = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox_tipo_consul = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radio_ativo = new System.Windows.Forms.RadioButton();
            this.radio_inativo = new System.Windows.Forms.RadioButton();
            this.ClassClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox_rel_cli.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox_maiores_de.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClassClienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ClassClienteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProjetoPapelariaHumanas.ReportCli.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 237);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 210);
            this.reportViewer1.TabIndex = 0;
            // 
            // groupBox_rel_cli
            // 
            this.groupBox_rel_cli.Controls.Add(this.groupBox4);
            this.groupBox_rel_cli.Controls.Add(this.groupBox3);
            this.groupBox_rel_cli.Controls.Add(this.groupBox2);
            this.groupBox_rel_cli.Controls.Add(this.groupBox_maiores_de);
            this.groupBox_rel_cli.Controls.Add(this.groupBox1);
            this.groupBox_rel_cli.Controls.Add(this.button1);
            this.groupBox_rel_cli.Controls.Add(this.comboBox_tipo_consul);
            this.groupBox_rel_cli.Controls.Add(this.label1);
            this.groupBox_rel_cli.Location = new System.Drawing.Point(13, 12);
            this.groupBox_rel_cli.Name = "groupBox_rel_cli";
            this.groupBox_rel_cli.Size = new System.Drawing.Size(775, 209);
            this.groupBox_rel_cli.TabIndex = 1;
            this.groupBox_rel_cli.TabStop = false;
            this.groupBox_rel_cli.Text = "Opções de Relatório";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radio_inativo);
            this.groupBox4.Controls.Add(this.radio_ativo);
            this.groupBox4.Location = new System.Drawing.Point(424, 57);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(172, 44);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Status";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.box_cidade);
            this.groupBox3.Location = new System.Drawing.Point(243, 118);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(138, 49);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cidade";
            // 
            // box_cidade
            // 
            this.box_cidade.Location = new System.Drawing.Point(21, 19);
            this.box_cidade.Name = "box_cidade";
            this.box_cidade.Size = new System.Drawing.Size(100, 20);
            this.box_cidade.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radio_masculino);
            this.groupBox2.Controls.Add(this.radio_feminino);
            this.groupBox2.Location = new System.Drawing.Point(11, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 49);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sexo";
            // 
            // radio_masculino
            // 
            this.radio_masculino.AutoSize = true;
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
            this.groupBox_maiores_de.Location = new System.Drawing.Point(243, 52);
            this.groupBox_maiores_de.Name = "groupBox_maiores_de";
            this.groupBox_maiores_de.Size = new System.Drawing.Size(138, 49);
            this.groupBox_maiores_de.TabIndex = 13;
            this.groupBox_maiores_de.TabStop = false;
            this.groupBox_maiores_de.Text = "Maiores De :";
            // 
            // box_maior
            // 
            this.box_maior.Location = new System.Drawing.Point(21, 19);
            this.box_maior.Name = "box_maior";
            this.box_maior.Size = new System.Drawing.Size(80, 20);
            this.box_maior.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.box_idade_final);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.box_idade_inicio);
            this.groupBox1.Location = new System.Drawing.Point(11, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 53);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Idade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "De :";
            // 
            // box_idade_final
            // 
            this.box_idade_final.Location = new System.Drawing.Point(144, 19);
            this.box_idade_final.Name = "box_idade_final";
            this.box_idade_final.Size = new System.Drawing.Size(54, 20);
            this.box_idade_final.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Até :";
            // 
            // box_idade_inicio
            // 
            this.box_idade_inicio.Location = new System.Drawing.Point(38, 19);
            this.box_idade_inicio.Name = "box_idade_inicio";
            this.box_idade_inicio.Size = new System.Drawing.Size(54, 20);
            this.box_idade_inicio.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(646, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Relatório";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_tipo_consul
            // 
            this.comboBox_tipo_consul.FormattingEnabled = true;
            this.comboBox_tipo_consul.Location = new System.Drawing.Point(338, 13);
            this.comboBox_tipo_consul.Name = "comboBox_tipo_consul";
            this.comboBox_tipo_consul.Size = new System.Drawing.Size(258, 21);
            this.comboBox_tipo_consul.TabIndex = 6;
            this.comboBox_tipo_consul.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(84, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Selecione um Tipo de Consulta:";
            // 
            // radio_ativo
            // 
            this.radio_ativo.AutoSize = true;
            this.radio_ativo.Location = new System.Drawing.Point(21, 20);
            this.radio_ativo.Name = "radio_ativo";
            this.radio_ativo.Size = new System.Drawing.Size(49, 17);
            this.radio_ativo.TabIndex = 0;
            this.radio_ativo.TabStop = true;
            this.radio_ativo.Text = "Ativo";
            this.radio_ativo.UseVisualStyleBackColor = true;
            // 
            // radio_inativo
            // 
            this.radio_inativo.AutoSize = true;
            this.radio_inativo.Location = new System.Drawing.Point(93, 20);
            this.radio_inativo.Name = "radio_inativo";
            this.radio_inativo.Size = new System.Drawing.Size(57, 17);
            this.radio_inativo.TabIndex = 1;
            this.radio_inativo.TabStop = true;
            this.radio_inativo.Text = "Inativo";
            this.radio_inativo.UseVisualStyleBackColor = true;
            // 
            // ClassClienteBindingSource
            // 
            this.ClassClienteBindingSource.DataSource = typeof(ProjetoPapelariaHumanas.ClassCliente);
            // 
            // FormRelcliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox_rel_cli);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormRelcliente";
            this.Text = "FormRelcliente";
            this.Load += new System.EventHandler(this.FormRelcliente_Load);
            this.groupBox_rel_cli.ResumeLayout(false);
            this.groupBox_rel_cli.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox_maiores_de.ResumeLayout(false);
            this.groupBox_maiores_de.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClassClienteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ClassClienteBindingSource;
        private System.Windows.Forms.GroupBox groupBox_rel_cli;
        private System.Windows.Forms.ComboBox comboBox_tipo_consul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox box_idade_final;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox box_idade_inicio;
        private System.Windows.Forms.GroupBox groupBox_maiores_de;
        private System.Windows.Forms.TextBox box_maior;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radio_masculino;
        private System.Windows.Forms.RadioButton radio_feminino;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox box_cidade;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radio_inativo;
        private System.Windows.Forms.RadioButton radio_ativo;
    }
}