
namespace ProjetoPapelariaHumanas
{
    partial class FormRelFuncionario
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox_idade = new System.Windows.Forms.GroupBox();
            this.groupBox_cidade = new System.Windows.Forms.GroupBox();
            this.groupBox_status = new System.Windows.Forms.GroupBox();
            this.group_box_cargo = new System.Windows.Forms.GroupBox();
            this.groupBox_sexo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.box_inicio = new System.Windows.Forms.TextBox();
            this.box_final = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_tipo_consul = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.box_cidade = new System.Windows.Forms.TextBox();
            this.combo_c = new System.Windows.Forms.ComboBox();
            this.radio_ativo = new System.Windows.Forms.RadioButton();
            this.radio_inativo = new System.Windows.Forms.RadioButton();
            this.radio_feminino = new System.Windows.Forms.RadioButton();
            this.radio_masculino = new System.Windows.Forms.RadioButton();
            this.ClassFuncionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox_idade.SuspendLayout();
            this.groupBox_cidade.SuspendLayout();
            this.groupBox_status.SuspendLayout();
            this.group_box_cargo.SuspendLayout();
            this.groupBox_sexo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClassFuncionarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ClassFuncionarioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProjetoPapelariaHumanas.ReportFuncionario.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 260);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 203);
            this.reportViewer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboBox_tipo_consul);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.groupBox_sexo);
            this.groupBox1.Controls.Add(this.group_box_cargo);
            this.groupBox1.Controls.Add(this.groupBox_status);
            this.groupBox1.Controls.Add(this.groupBox_cidade);
            this.groupBox1.Controls.Add(this.groupBox_idade);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 242);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opções de Relatório";
            // 
            // groupBox_idade
            // 
            this.groupBox_idade.Controls.Add(this.box_final);
            this.groupBox_idade.Controls.Add(this.box_inicio);
            this.groupBox_idade.Controls.Add(this.label2);
            this.groupBox_idade.Controls.Add(this.label1);
            this.groupBox_idade.Location = new System.Drawing.Point(23, 66);
            this.groupBox_idade.Name = "groupBox_idade";
            this.groupBox_idade.Size = new System.Drawing.Size(177, 66);
            this.groupBox_idade.TabIndex = 0;
            this.groupBox_idade.TabStop = false;
            this.groupBox_idade.Text = "Idade";
            // 
            // groupBox_cidade
            // 
            this.groupBox_cidade.Controls.Add(this.box_cidade);
            this.groupBox_cidade.Location = new System.Drawing.Point(223, 174);
            this.groupBox_cidade.Name = "groupBox_cidade";
            this.groupBox_cidade.Size = new System.Drawing.Size(166, 45);
            this.groupBox_cidade.TabIndex = 1;
            this.groupBox_cidade.TabStop = false;
            this.groupBox_cidade.Text = "Cidade";
            // 
            // groupBox_status
            // 
            this.groupBox_status.Controls.Add(this.radio_inativo);
            this.groupBox_status.Controls.Add(this.radio_ativo);
            this.groupBox_status.Location = new System.Drawing.Point(418, 66);
            this.groupBox_status.Name = "groupBox_status";
            this.groupBox_status.Size = new System.Drawing.Size(122, 66);
            this.groupBox_status.TabIndex = 2;
            this.groupBox_status.TabStop = false;
            this.groupBox_status.Text = "Status";
            // 
            // group_box_cargo
            // 
            this.group_box_cargo.Controls.Add(this.combo_c);
            this.group_box_cargo.Location = new System.Drawing.Point(23, 174);
            this.group_box_cargo.Name = "group_box_cargo";
            this.group_box_cargo.Size = new System.Drawing.Size(177, 45);
            this.group_box_cargo.TabIndex = 3;
            this.group_box_cargo.TabStop = false;
            this.group_box_cargo.Text = "Cargo";
            // 
            // groupBox_sexo
            // 
            this.groupBox_sexo.Controls.Add(this.radio_masculino);
            this.groupBox_sexo.Controls.Add(this.radio_feminino);
            this.groupBox_sexo.Location = new System.Drawing.Point(223, 66);
            this.groupBox_sexo.Name = "groupBox_sexo";
            this.groupBox_sexo.Size = new System.Drawing.Size(166, 66);
            this.groupBox_sexo.TabIndex = 4;
            this.groupBox_sexo.TabStop = false;
            this.groupBox_sexo.Text = "Sexo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "De :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Até :";
            // 
            // box_inicio
            // 
            this.box_inicio.Location = new System.Drawing.Point(40, 26);
            this.box_inicio.Name = "box_inicio";
            this.box_inicio.Size = new System.Drawing.Size(35, 20);
            this.box_inicio.TabIndex = 2;
            // 
            // box_final
            // 
            this.box_final.Location = new System.Drawing.Point(117, 26);
            this.box_final.Name = "box_final";
            this.box_final.Size = new System.Drawing.Size(36, 20);
            this.box_final.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(105, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Selecione um Tipo de Consulta:";
            // 
            // comboBox_tipo_consul
            // 
            this.comboBox_tipo_consul.FormattingEnabled = true;
            this.comboBox_tipo_consul.Location = new System.Drawing.Point(360, 20);
            this.comboBox_tipo_consul.Name = "comboBox_tipo_consul";
            this.comboBox_tipo_consul.Size = new System.Drawing.Size(251, 21);
            this.comboBox_tipo_consul.TabIndex = 6;
            this.comboBox_tipo_consul.SelectedIndexChanged += new System.EventHandler(this.comboBox_tipo_consul_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(656, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Relatório";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // box_cidade
            // 
            this.box_cidade.Location = new System.Drawing.Point(22, 19);
            this.box_cidade.Name = "box_cidade";
            this.box_cidade.Size = new System.Drawing.Size(127, 20);
            this.box_cidade.TabIndex = 0;
            this.box_cidade.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // combo_c
            // 
            this.combo_c.FormattingEnabled = true;
            this.combo_c.Location = new System.Drawing.Point(20, 18);
            this.combo_c.Name = "combo_c";
            this.combo_c.Size = new System.Drawing.Size(121, 21);
            this.combo_c.TabIndex = 0;
            // 
            // radio_ativo
            // 
            this.radio_ativo.AutoSize = true;
            this.radio_ativo.Location = new System.Drawing.Point(7, 31);
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
            this.radio_inativo.Location = new System.Drawing.Point(63, 29);
            this.radio_inativo.Name = "radio_inativo";
            this.radio_inativo.Size = new System.Drawing.Size(57, 17);
            this.radio_inativo.TabIndex = 1;
            this.radio_inativo.TabStop = true;
            this.radio_inativo.Text = "Inativo";
            this.radio_inativo.UseVisualStyleBackColor = true;
            // 
            // radio_feminino
            // 
            this.radio_feminino.AutoSize = true;
            this.radio_feminino.Location = new System.Drawing.Point(7, 31);
            this.radio_feminino.Name = "radio_feminino";
            this.radio_feminino.Size = new System.Drawing.Size(67, 17);
            this.radio_feminino.TabIndex = 0;
            this.radio_feminino.TabStop = true;
            this.radio_feminino.Text = "Feminino";
            this.radio_feminino.UseVisualStyleBackColor = true;
            // 
            // radio_masculino
            // 
            this.radio_masculino.AutoSize = true;
            this.radio_masculino.Location = new System.Drawing.Point(76, 31);
            this.radio_masculino.Name = "radio_masculino";
            this.radio_masculino.Size = new System.Drawing.Size(73, 17);
            this.radio_masculino.TabIndex = 1;
            this.radio_masculino.TabStop = true;
            this.radio_masculino.Text = "Masculino";
            this.radio_masculino.UseVisualStyleBackColor = true;
            // 
            // ClassFuncionarioBindingSource
            // 
            this.ClassFuncionarioBindingSource.DataSource = typeof(ProjetoPapelariaHumanas.ClassFuncionario);
            // 
            // FormRelFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 467);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormRelFuncionario";
            this.Text = "FormRelFuncionario";
            this.Load += new System.EventHandler(this.FormRelFuncionario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_idade.ResumeLayout(false);
            this.groupBox_idade.PerformLayout();
            this.groupBox_cidade.ResumeLayout(false);
            this.groupBox_cidade.PerformLayout();
            this.groupBox_status.ResumeLayout(false);
            this.groupBox_status.PerformLayout();
            this.group_box_cargo.ResumeLayout(false);
            this.groupBox_sexo.ResumeLayout(false);
            this.groupBox_sexo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClassFuncionarioBindingSource)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_tipo_consul;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox box_cidade;
        private System.Windows.Forms.ComboBox combo_c;
        private System.Windows.Forms.RadioButton radio_inativo;
        private System.Windows.Forms.RadioButton radio_ativo;
        private System.Windows.Forms.RadioButton radio_masculino;
        private System.Windows.Forms.RadioButton radio_feminino;
        private System.Windows.Forms.BindingSource ClassFuncionarioBindingSource;
    }
}