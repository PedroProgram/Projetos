namespace salario
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
            this.bt_calcular = new System.Windows.Forms.Button();
            this.txt_resultado = new System.Windows.Forms.Label();
            this.txt_valor = new System.Windows.Forms.Label();
            this.tb_valor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_calcular
            // 
            this.bt_calcular.Location = new System.Drawing.Point(287, 192);
            this.bt_calcular.Name = "bt_calcular";
            this.bt_calcular.Size = new System.Drawing.Size(112, 49);
            this.bt_calcular.TabIndex = 0;
            this.bt_calcular.Text = "Calcular";
            this.bt_calcular.UseVisualStyleBackColor = true;
            this.bt_calcular.Click += new System.EventHandler(this.bt_calcular_Click);
            // 
            // txt_resultado
            // 
            this.txt_resultado.AutoSize = true;
            this.txt_resultado.Location = new System.Drawing.Point(55, 211);
            this.txt_resultado.Name = "txt_resultado";
            this.txt_resultado.Size = new System.Drawing.Size(50, 13);
            this.txt_resultado.TabIndex = 1;
            this.txt_resultado.Text = "resultado";
            // 
            // txt_valor
            // 
            this.txt_valor.AutoSize = true;
            this.txt_valor.Location = new System.Drawing.Point(58, 149);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(30, 13);
            this.txt_valor.TabIndex = 2;
            this.txt_valor.Text = "valor";
            // 
            // tb_valor
            // 
            this.tb_valor.Location = new System.Drawing.Point(121, 149);
            this.tb_valor.Name = "tb_valor";
            this.tb_valor.Size = new System.Drawing.Size(100, 20);
            this.tb_valor.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 450);
            this.Controls.Add(this.tb_valor);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.txt_resultado);
            this.Controls.Add(this.bt_calcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_calcular;
        private System.Windows.Forms.Label txt_resultado;
        private System.Windows.Forms.Label txt_valor;
        private System.Windows.Forms.TextBox tb_valor;
    }
}

