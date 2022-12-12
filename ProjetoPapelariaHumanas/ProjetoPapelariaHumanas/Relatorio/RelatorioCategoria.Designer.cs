
namespace ProjetoPapelariaHumanas
{
    partial class RelatorioCategoria
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
            this.ClassCategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewerCategoria = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bt_Sair = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_ajuda = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.ClassCategoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ClassCategoriaBindingSource
            // 
            this.ClassCategoriaBindingSource.DataSource = typeof(ProjetoPapelariaHumanas.ClassCategoria);
            // 
            // reportViewerCategoria
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ClassCategoriaBindingSource;
            this.reportViewerCategoria.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerCategoria.LocalReport.ReportEmbeddedResource = "ProjetoPapelariaHumanas.Report.ReportCategoria.rdlc";
            this.reportViewerCategoria.Location = new System.Drawing.Point(12, 72);
            this.reportViewerCategoria.Name = "reportViewerCategoria";
            this.reportViewerCategoria.ServerReport.BearerToken = null;
            this.reportViewerCategoria.Size = new System.Drawing.Size(705, 306);
            this.reportViewerCategoria.TabIndex = 0;
            // 
            // bt_Sair
            // 
            this.bt_Sair.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bt_Sair.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.bt_Sair.Location = new System.Drawing.Point(703, -4);
            this.bt_Sair.Name = "bt_Sair";
            this.bt_Sair.Size = new System.Drawing.Size(31, 28);
            this.bt_Sair.TabIndex = 3;
            this.bt_Sair.Text = "X";
            this.bt_Sair.UseVisualStyleBackColor = false;
            this.bt_Sair.Click += new System.EventHandler(this.bt_Sair_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(234, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Relatório De Categoria";
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
            // bt_ajuda
            // 
            this.bt_ajuda.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_ajuda.Location = new System.Drawing.Point(678, 0);
            this.bt_ajuda.Name = "bt_ajuda";
            this.bt_ajuda.Size = new System.Drawing.Size(19, 19);
            this.bt_ajuda.Style = MetroFramework.MetroColorStyle.Silver;
            this.bt_ajuda.TabIndex = 48;
            this.bt_ajuda.Text = " ?";
            this.bt_ajuda.UseSelectable = true;
            this.bt_ajuda.Click += new System.EventHandler(this.bt_ajuda_Click);
            // 
            // RelatorioCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(730, 391);
            this.Controls.Add(this.bt_ajuda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_Sair);
            this.Controls.Add(this.reportViewerCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RelatorioCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RelatorioCategoria";
            this.Load += new System.EventHandler(this.RelatorioCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClassCategoriaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerCategoria;
        private System.Windows.Forms.Button bt_Sair;
        private System.Windows.Forms.BindingSource ClassCategoriaBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroButton bt_ajuda;
    }
}