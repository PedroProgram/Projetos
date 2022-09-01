namespace nota
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
            this.bt_exibir = new System.Windows.Forms.Button();
            this.lb_nota1 = new System.Windows.Forms.Label();
            this.lb_nota2 = new System.Windows.Forms.Label();
            this.lb_nota4 = new System.Windows.Forms.Label();
            this.lb_nota3 = new System.Windows.Forms.Label();
            this.lb_maior = new System.Windows.Forms.Label();
            this.lb_media = new System.Windows.Forms.Label();
            this.lb_menor = new System.Windows.Forms.Label();
            this.tb_nota1 = new System.Windows.Forms.TextBox();
            this.tb_nota2 = new System.Windows.Forms.TextBox();
            this.tb_nota3 = new System.Windows.Forms.TextBox();
            this.tb_nota4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_exibir
            // 
            this.bt_exibir.Location = new System.Drawing.Point(347, 153);
            this.bt_exibir.Name = "bt_exibir";
            this.bt_exibir.Size = new System.Drawing.Size(75, 23);
            this.bt_exibir.TabIndex = 0;
            this.bt_exibir.Text = "Exibir";
            this.bt_exibir.UseVisualStyleBackColor = true;
            this.bt_exibir.Click += new System.EventHandler(this.bt_exibir_Click);
            // 
            // lb_nota1
            // 
            this.lb_nota1.AutoSize = true;
            this.lb_nota1.Location = new System.Drawing.Point(69, 49);
            this.lb_nota1.Name = "lb_nota1";
            this.lb_nota1.Size = new System.Drawing.Size(37, 13);
            this.lb_nota1.TabIndex = 1;
            this.lb_nota1.Text = "nota 1";
            // 
            // lb_nota2
            // 
            this.lb_nota2.AutoSize = true;
            this.lb_nota2.Location = new System.Drawing.Point(69, 88);
            this.lb_nota2.Name = "lb_nota2";
            this.lb_nota2.Size = new System.Drawing.Size(37, 13);
            this.lb_nota2.TabIndex = 2;
            this.lb_nota2.Text = "nota 2";
            // 
            // lb_nota4
            // 
            this.lb_nota4.AutoSize = true;
            this.lb_nota4.Location = new System.Drawing.Point(69, 163);
            this.lb_nota4.Name = "lb_nota4";
            this.lb_nota4.Size = new System.Drawing.Size(39, 13);
            this.lb_nota4.TabIndex = 3;
            this.lb_nota4.Text = "Nota 4";
            // 
            // lb_nota3
            // 
            this.lb_nota3.AutoSize = true;
            this.lb_nota3.Location = new System.Drawing.Point(69, 119);
            this.lb_nota3.Name = "lb_nota3";
            this.lb_nota3.Size = new System.Drawing.Size(37, 13);
            this.lb_nota3.TabIndex = 4;
            this.lb_nota3.Text = "nota 3";
            // 
            // lb_maior
            // 
            this.lb_maior.AutoSize = true;
            this.lb_maior.Location = new System.Drawing.Point(262, 48);
            this.lb_maior.Name = "lb_maior";
            this.lb_maior.Size = new System.Drawing.Size(59, 13);
            this.lb_maior.TabIndex = 5;
            this.lb_maior.Text = "Nota Maior";
            // 
            // lb_media
            // 
            this.lb_media.AutoSize = true;
            this.lb_media.Location = new System.Drawing.Point(262, 109);
            this.lb_media.Name = "lb_media";
            this.lb_media.Size = new System.Drawing.Size(61, 13);
            this.lb_media.TabIndex = 6;
            this.lb_media.Text = "Nota média";
            // 
            // lb_menor
            // 
            this.lb_menor.AutoSize = true;
            this.lb_menor.Location = new System.Drawing.Point(259, 169);
            this.lb_menor.Name = "lb_menor";
            this.lb_menor.Size = new System.Drawing.Size(62, 13);
            this.lb_menor.TabIndex = 7;
            this.lb_menor.Text = "Nota menor";
            // 
            // tb_nota1
            // 
            this.tb_nota1.Location = new System.Drawing.Point(131, 48);
            this.tb_nota1.Name = "tb_nota1";
            this.tb_nota1.Size = new System.Drawing.Size(100, 20);
            this.tb_nota1.TabIndex = 8;
            // 
            // tb_nota2
            // 
            this.tb_nota2.Location = new System.Drawing.Point(131, 88);
            this.tb_nota2.Name = "tb_nota2";
            this.tb_nota2.Size = new System.Drawing.Size(100, 20);
            this.tb_nota2.TabIndex = 9;
            // 
            // tb_nota3
            // 
            this.tb_nota3.Location = new System.Drawing.Point(131, 123);
            this.tb_nota3.Name = "tb_nota3";
            this.tb_nota3.Size = new System.Drawing.Size(100, 20);
            this.tb_nota3.TabIndex = 10;
            // 
            // tb_nota4
            // 
            this.tb_nota4.Location = new System.Drawing.Point(131, 162);
            this.tb_nota4.Name = "tb_nota4";
            this.tb_nota4.Size = new System.Drawing.Size(100, 20);
            this.tb_nota4.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 243);
            this.Controls.Add(this.tb_nota4);
            this.Controls.Add(this.tb_nota3);
            this.Controls.Add(this.tb_nota2);
            this.Controls.Add(this.tb_nota1);
            this.Controls.Add(this.lb_menor);
            this.Controls.Add(this.lb_media);
            this.Controls.Add(this.lb_maior);
            this.Controls.Add(this.lb_nota3);
            this.Controls.Add(this.lb_nota4);
            this.Controls.Add(this.lb_nota2);
            this.Controls.Add(this.lb_nota1);
            this.Controls.Add(this.bt_exibir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_exibir;
        private System.Windows.Forms.Label lb_nota1;
        private System.Windows.Forms.Label lb_nota2;
        private System.Windows.Forms.Label lb_nota4;
        private System.Windows.Forms.Label lb_nota3;
        private System.Windows.Forms.Label lb_maior;
        private System.Windows.Forms.Label lb_media;
        private System.Windows.Forms.Label lb_menor;
        private System.Windows.Forms.TextBox tb_nota1;
        private System.Windows.Forms.TextBox tb_nota2;
        private System.Windows.Forms.TextBox tb_nota3;
        private System.Windows.Forms.TextBox tb_nota4;
    }
}

