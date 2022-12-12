
namespace ProjetoPapelariaHumanas
{
    partial class RelatorioMarca
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
            this.ClassMarcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rptv_marca = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bt_Sair = new System.Windows.Forms.Button();
            this.label_fornecedor = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_ajuda = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.ClassMarcaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ClassMarcaBindingSource
            // 
            this.ClassMarcaBindingSource.DataSource = typeof(ProjetoPapelariaHumanas.ClassMarca);
            // 
            // rptv_marca
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ClassMarcaBindingSource;
            this.rptv_marca.LocalReport.DataSources.Add(reportDataSource1);
            this.rptv_marca.LocalReport.ReportEmbeddedResource = "ProjetoPapelariaHumanas.Report.ReportMarca.rdlc";
            this.rptv_marca.Location = new System.Drawing.Point(12, 72);
            this.rptv_marca.Name = "rptv_marca";
            this.rptv_marca.ServerReport.BearerToken = null;
            this.rptv_marca.Size = new System.Drawing.Size(705, 306);
            this.rptv_marca.TabIndex = 0;
            // 
            // bt_Sair
            // 
            this.bt_Sair.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bt_Sair.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.bt_Sair.Location = new System.Drawing.Point(702, -4);
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
            this.label_fornecedor.Location = new System.Drawing.Point(263, 26);
            this.label_fornecedor.Name = "label_fornecedor";
            this.label_fornecedor.Size = new System.Drawing.Size(198, 29);
            this.label_fornecedor.TabIndex = 5;
            this.label_fornecedor.Text = "Relatório Marca";
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
            this.bt_ajuda.Location = new System.Drawing.Point(677, 0);
            this.bt_ajuda.Name = "bt_ajuda";
            this.bt_ajuda.Size = new System.Drawing.Size(19, 19);
            this.bt_ajuda.Style = MetroFramework.MetroColorStyle.Silver;
            this.bt_ajuda.TabIndex = 48;
            this.bt_ajuda.Text = " ?";
            this.bt_ajuda.UseSelectable = true;
            this.bt_ajuda.Click += new System.EventHandler(this.bt_ajuda_Click);
            // 
            // RelatorioMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(729, 390);
            this.Controls.Add(this.bt_ajuda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_fornecedor);
            this.Controls.Add(this.bt_Sair);
            this.Controls.Add(this.rptv_marca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RelatorioMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRelMarca";
            this.Load += new System.EventHandler(this.FormRelMarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClassMarcaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptv_marca;
        private System.Windows.Forms.BindingSource ClassMarcaBindingSource;
        private System.Windows.Forms.Button bt_Sair;
        private System.Windows.Forms.Label label_fornecedor;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroButton bt_ajuda;
    }
}