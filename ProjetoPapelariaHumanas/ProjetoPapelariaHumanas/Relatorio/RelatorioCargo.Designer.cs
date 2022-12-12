
namespace ProjetoPapelariaHumanas
{
    partial class RelatorioCargo
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
            this.ClassCargoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rptv = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bt_Sair = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_ajuda = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.ClassCargoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ClassCargoBindingSource
            // 
            this.ClassCargoBindingSource.DataSource = typeof(ProjetoPapelariaHumanas.ClassCargo);
            // 
            // rptv
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ClassCargoBindingSource;
            this.rptv.LocalReport.DataSources.Add(reportDataSource1);
            this.rptv.LocalReport.ReportEmbeddedResource = "ProjetoPapelariaHumanas.Report.ReportCargo.rdlc";
            this.rptv.Location = new System.Drawing.Point(12, 67);
            this.rptv.Name = "rptv";
            this.rptv.ServerReport.BearerToken = null;
            this.rptv.Size = new System.Drawing.Size(776, 371);
            this.rptv.TabIndex = 0;
            // 
            // bt_Sair
            // 
            this.bt_Sair.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bt_Sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Sair.Location = new System.Drawing.Point(773, -4);
            this.bt_Sair.Name = "bt_Sair";
            this.bt_Sair.Size = new System.Drawing.Size(31, 28);
            this.bt_Sair.TabIndex = 14;
            this.bt_Sair.Text = "X";
            this.bt_Sair.UseVisualStyleBackColor = false;
            this.bt_Sair.Click += new System.EventHandler(this.bt_Sair_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 18);
            this.label5.TabIndex = 17;
            this.label5.Text = "Sistema Papelaria Humanas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(267, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 29);
            this.label2.TabIndex = 18;
            this.label2.Text = "Relatório De Cargo";
            // 
            // bt_ajuda
            // 
            this.bt_ajuda.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_ajuda.Location = new System.Drawing.Point(748, 0);
            this.bt_ajuda.Name = "bt_ajuda";
            this.bt_ajuda.Size = new System.Drawing.Size(19, 19);
            this.bt_ajuda.Style = MetroFramework.MetroColorStyle.Silver;
            this.bt_ajuda.TabIndex = 47;
            this.bt_ajuda.Text = " ?";
            this.bt_ajuda.UseSelectable = true;
            this.bt_ajuda.Click += new System.EventHandler(this.bt_ajuda_Click);
            // 
            // RelatorioCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_ajuda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bt_Sair);
            this.Controls.Add(this.rptv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RelatorioCargo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRelCargo";
            this.Load += new System.EventHandler(this.FormRelCargo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClassCargoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptv;
        private System.Windows.Forms.BindingSource ClassCargoBindingSource;
        private System.Windows.Forms.Button bt_Sair;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroButton bt_ajuda;
    }
}