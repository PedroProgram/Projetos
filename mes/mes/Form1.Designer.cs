namespace mes
{
    partial class Form1
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
            this.cb_mes = new System.Windows.Forms.ComboBox();
            this.txt_mes = new System.Windows.Forms.Label();
            this.box_1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cb_mes
            // 
            this.cb_mes.FormattingEnabled = true;
            this.cb_mes.Location = new System.Drawing.Point(165, 56);
            this.cb_mes.Name = "cb_mes";
            this.cb_mes.Size = new System.Drawing.Size(121, 21);
            this.cb_mes.TabIndex = 0;
            this.cb_mes.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txt_mes
            // 
            this.txt_mes.AutoSize = true;
            this.txt_mes.Location = new System.Drawing.Point(137, 142);
            this.txt_mes.Name = "txt_mes";
            this.txt_mes.Size = new System.Drawing.Size(30, 13);
            this.txt_mes.TabIndex = 1;
            this.txt_mes.Text = "Mês:";
            // 
            // box_1
            // 
            this.box_1.Location = new System.Drawing.Point(186, 139);
            this.box_1.Name = "box_1";
            this.box_1.Size = new System.Drawing.Size(100, 20);
            this.box_1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.box_1);
            this.Controls.Add(this.txt_mes);
            this.Controls.Add(this.cb_mes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_mes;
        private System.Windows.Forms.Label txt_mes;
        private System.Windows.Forms.TextBox box_1;
    }
}

