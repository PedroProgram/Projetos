
namespace ProjetoPapelariaHumanas
{
    partial class FormRelVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRelVenda));
            this.ClassRelVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportview1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox_data = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_data2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker_data1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_fun = new System.Windows.Forms.GroupBox();
            this.comboBox_funcionario = new System.Windows.Forms.ComboBox();
            this.groupBox_cliente = new System.Windows.Forms.GroupBox();
            this.combo_cli = new System.Windows.Forms.ComboBox();
            this.groupBox_opcoes = new System.Windows.Forms.GroupBox();
            this.comboBox_opcoes = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bt_Sair = new System.Windows.Forms.Button();
            this.bt_ajuda = new MetroFramework.Controls.MetroButton();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ClassRelVendaBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox_data.SuspendLayout();
            this.groupBox_fun.SuspendLayout();
            this.groupBox_cliente.SuspendLayout();
            this.groupBox_opcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClassRelVendaBindingSource
            // 
            this.ClassRelVendaBindingSource.DataSource = typeof(ProjetoPapelariaHumanas.ClassRelVenda);
            // 
            // reportview1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ClassRelVendaBindingSource;
            this.reportview1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportview1.LocalReport.ReportEmbeddedResource = "ProjetoPapelariaHumanas.Report.ReportVenda.rdlc";
            this.reportview1.Location = new System.Drawing.Point(24, 193);
            this.reportview1.Name = "reportview1";
            this.reportview1.ServerReport.BearerToken = null;
            this.reportview1.Size = new System.Drawing.Size(768, 239);
            this.reportview1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(282, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Relatório De Venda";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox_data);
            this.groupBox1.Controls.Add(this.groupBox_fun);
            this.groupBox1.Controls.Add(this.groupBox_cliente);
            this.groupBox1.Controls.Add(this.groupBox_opcoes);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.reportview1);
            this.groupBox1.Location = new System.Drawing.Point(11, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(809, 437);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa de Venda";
            // 
            // groupBox_data
            // 
            this.groupBox_data.Controls.Add(this.dateTimePicker_data2);
            this.groupBox_data.Controls.Add(this.label3);
            this.groupBox_data.Controls.Add(this.dateTimePicker_data1);
            this.groupBox_data.Controls.Add(this.label1);
            this.groupBox_data.Location = new System.Drawing.Point(285, 41);
            this.groupBox_data.Name = "groupBox_data";
            this.groupBox_data.Size = new System.Drawing.Size(326, 66);
            this.groupBox_data.TabIndex = 13;
            this.groupBox_data.TabStop = false;
            this.groupBox_data.Text = "Data Venda";
            // 
            // dateTimePicker_data2
            // 
            this.dateTimePicker_data2.Location = new System.Drawing.Point(51, 39);
            this.dateTimePicker_data2.Name = "dateTimePicker_data2";
            this.dateTimePicker_data2.Size = new System.Drawing.Size(214, 20);
            this.dateTimePicker_data2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Até:";
            // 
            // dateTimePicker_data1
            // 
            this.dateTimePicker_data1.Location = new System.Drawing.Point(51, 15);
            this.dateTimePicker_data1.Name = "dateTimePicker_data1";
            this.dateTimePicker_data1.Size = new System.Drawing.Size(214, 20);
            this.dateTimePicker_data1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "De:";
            // 
            // groupBox_fun
            // 
            this.groupBox_fun.Controls.Add(this.comboBox_funcionario);
            this.groupBox_fun.Location = new System.Drawing.Point(30, 125);
            this.groupBox_fun.Name = "groupBox_fun";
            this.groupBox_fun.Size = new System.Drawing.Size(220, 46);
            this.groupBox_fun.TabIndex = 9;
            this.groupBox_fun.TabStop = false;
            this.groupBox_fun.Text = "Funcionário";
            // 
            // comboBox_funcionario
            // 
            this.comboBox_funcionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_funcionario.FormattingEnabled = true;
            this.comboBox_funcionario.Location = new System.Drawing.Point(6, 19);
            this.comboBox_funcionario.Name = "comboBox_funcionario";
            this.comboBox_funcionario.Size = new System.Drawing.Size(208, 21);
            this.comboBox_funcionario.TabIndex = 11;
            // 
            // groupBox_cliente
            // 
            this.groupBox_cliente.Controls.Add(this.combo_cli);
            this.groupBox_cliente.Location = new System.Drawing.Point(285, 125);
            this.groupBox_cliente.Name = "groupBox_cliente";
            this.groupBox_cliente.Size = new System.Drawing.Size(212, 52);
            this.groupBox_cliente.TabIndex = 12;
            this.groupBox_cliente.TabStop = false;
            this.groupBox_cliente.Text = "Cliente";
            // 
            // combo_cli
            // 
            this.combo_cli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_cli.FormattingEnabled = true;
            this.combo_cli.Location = new System.Drawing.Point(6, 19);
            this.combo_cli.Name = "combo_cli";
            this.combo_cli.Size = new System.Drawing.Size(200, 21);
            this.combo_cli.TabIndex = 10;
            // 
            // groupBox_opcoes
            // 
            this.groupBox_opcoes.Controls.Add(this.comboBox_opcoes);
            this.groupBox_opcoes.Location = new System.Drawing.Point(24, 40);
            this.groupBox_opcoes.Name = "groupBox_opcoes";
            this.groupBox_opcoes.Size = new System.Drawing.Size(226, 57);
            this.groupBox_opcoes.TabIndex = 9;
            this.groupBox_opcoes.TabStop = false;
            this.groupBox_opcoes.Text = "Opções de Relatório";
            // 
            // comboBox_opcoes
            // 
            this.comboBox_opcoes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_opcoes.FormattingEnabled = true;
            this.comboBox_opcoes.Location = new System.Drawing.Point(6, 26);
            this.comboBox_opcoes.Name = "comboBox_opcoes";
            this.comboBox_opcoes.Size = new System.Drawing.Size(214, 21);
            this.comboBox_opcoes.TabIndex = 8;
            this.comboBox_opcoes.SelectedIndexChanged += new System.EventHandler(this.comboBox_opcoes_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(671, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 61);
            this.button1.TabIndex = 7;
            this.button1.Text = "        Gerar Relatório";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_Sair
            // 
            this.bt_Sair.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bt_Sair.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.bt_Sair.Location = new System.Drawing.Point(803, -4);
            this.bt_Sair.Name = "bt_Sair";
            this.bt_Sair.Size = new System.Drawing.Size(31, 28);
            this.bt_Sair.TabIndex = 14;
            this.bt_Sair.Text = "X";
            this.bt_Sair.UseVisualStyleBackColor = false;
            this.bt_Sair.Click += new System.EventHandler(this.bt_Sair_Click);
            // 
            // bt_ajuda
            // 
            this.bt_ajuda.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_ajuda.Location = new System.Drawing.Point(778, 0);
            this.bt_ajuda.Name = "bt_ajuda";
            this.bt_ajuda.Size = new System.Drawing.Size(19, 19);
            this.bt_ajuda.Style = MetroFramework.MetroColorStyle.Silver;
            this.bt_ajuda.TabIndex = 232;
            this.bt_ajuda.Text = " ?";
            this.bt_ajuda.UseSelectable = true;
            this.bt_ajuda.Click += new System.EventHandler(this.bt_ajuda_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "Sistema Papelaria Humanas";
            // 
            // FormRelVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(830, 510);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bt_ajuda);
            this.Controls.Add(this.bt_Sair);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRelVenda";
            this.Text = "FormRelVenda";
            this.Load += new System.EventHandler(this.FormRelVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClassRelVendaBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox_data.ResumeLayout(false);
            this.groupBox_data.PerformLayout();
            this.groupBox_fun.ResumeLayout(false);
            this.groupBox_cliente.ResumeLayout(false);
            this.groupBox_opcoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportview1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox_opcoes;
        private System.Windows.Forms.ComboBox comboBox_opcoes;
        private System.Windows.Forms.GroupBox groupBox_fun;
        private System.Windows.Forms.ComboBox comboBox_funcionario;
        private System.Windows.Forms.GroupBox groupBox_cliente;
        private System.Windows.Forms.ComboBox combo_cli;
        private System.Windows.Forms.GroupBox groupBox_data;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_data2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker_data1;
        private System.Windows.Forms.BindingSource ClassRelVendaBindingSource;
        private System.Windows.Forms.Button bt_Sair;
        private MetroFramework.Controls.MetroButton bt_ajuda;
        private System.Windows.Forms.Label label5;
    }
}