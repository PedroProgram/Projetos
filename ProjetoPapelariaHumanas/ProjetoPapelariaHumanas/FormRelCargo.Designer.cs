
namespace ProjetoPapelariaHumanas
{
    partial class FormRelCargo
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
            this.rptv = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ClassCargoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ClassCargoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rptv
            // 
            this.rptv.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ClassCargoBindingSource;
            this.rptv.LocalReport.DataSources.Add(reportDataSource1);
            this.rptv.LocalReport.ReportEmbeddedResource = "ProjetoPapelariaHumanas.Report1.rdlc";
            this.rptv.Location = new System.Drawing.Point(0, 0);
            this.rptv.Name = "rptv";
            this.rptv.ServerReport.BearerToken = null;
            this.rptv.Size = new System.Drawing.Size(800, 450);
            this.rptv.TabIndex = 0;
            this.rptv.Load += new System.EventHandler(this.rptv_Load);
            // 
            // ClassCargoBindingSource
            // 
            this.ClassCargoBindingSource.DataSource = typeof(ProjetoPapelariaHumanas.ClassCargo);
            // 
            // FormRelCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rptv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRelCargo";
            this.Text = "FormRelCargo";
            this.Load += new System.EventHandler(this.FormRelCargo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClassCargoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptv;
        private System.Windows.Forms.BindingSource ClassCargoBindingSource;
    }
}