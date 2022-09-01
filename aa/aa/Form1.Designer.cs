namespace aa
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_idade1 = new System.Windows.Forms.Label();
            this.txt_idade2 = new System.Windows.Forms.Label();
            this.txt_idade3 = new System.Windows.Forms.Label();
            this.box_1 = new System.Windows.Forms.TextBox();
            this.box_2 = new System.Windows.Forms.TextBox();
            this.box_3 = new System.Windows.Forms.TextBox();
            this.bt_calcular = new System.Windows.Forms.Button();
            this.txt_resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_idade1
            // 
            this.txt_idade1.AutoSize = true;
            this.txt_idade1.Location = new System.Drawing.Point(107, 99);
            this.txt_idade1.Name = "txt_idade1";
            this.txt_idade1.Size = new System.Drawing.Size(45, 13);
            this.txt_idade1.TabIndex = 0;
            this.txt_idade1.Text = "idade 1:";
            // 
            // txt_idade2
            // 
            this.txt_idade2.AutoSize = true;
            this.txt_idade2.Location = new System.Drawing.Point(110, 156);
            this.txt_idade2.Name = "txt_idade2";
            this.txt_idade2.Size = new System.Drawing.Size(42, 13);
            this.txt_idade2.TabIndex = 1;
            this.txt_idade2.Text = "idade2:";
            // 
            // txt_idade3
            // 
            this.txt_idade3.AutoSize = true;
            this.txt_idade3.Location = new System.Drawing.Point(113, 210);
            this.txt_idade3.Name = "txt_idade3";
            this.txt_idade3.Size = new System.Drawing.Size(42, 13);
            this.txt_idade3.TabIndex = 2;
            this.txt_idade3.Text = "idade3:";
            // 
            // box_1
            // 
            this.box_1.BackColor = System.Drawing.Color.AliceBlue;
            this.box_1.Location = new System.Drawing.Point(211, 99);
            this.box_1.Name = "box_1";
            this.box_1.Size = new System.Drawing.Size(100, 20);
            this.box_1.TabIndex = 3;
            // 
            // box_2
            // 
            this.box_2.Location = new System.Drawing.Point(211, 149);
            this.box_2.Name = "box_2";
            this.box_2.Size = new System.Drawing.Size(100, 20);
            this.box_2.TabIndex = 4;
            // 
            // box_3
            // 
            this.box_3.Location = new System.Drawing.Point(211, 203);
            this.box_3.Name = "box_3";
            this.box_3.Size = new System.Drawing.Size(100, 20);
            this.box_3.TabIndex = 5;
            // 
            // bt_calcular
            // 
            this.bt_calcular.Location = new System.Drawing.Point(548, 235);
            this.bt_calcular.Name = "bt_calcular";
            this.bt_calcular.Size = new System.Drawing.Size(75, 23);
            this.bt_calcular.TabIndex = 6;
            this.bt_calcular.Text = "calcular";
            this.bt_calcular.UseVisualStyleBackColor = true;
            this.bt_calcular.Click += new System.EventHandler(this.bt_calcular_Click);
            // 
            // txt_resultado
            // 
            this.txt_resultado.AutoSize = true;
            this.txt_resultado.Location = new System.Drawing.Point(545, 88);
            this.txt_resultado.Name = "txt_resultado";
            this.txt_resultado.Size = new System.Drawing.Size(55, 13);
            this.txt_resultado.TabIndex = 7;
            this.txt_resultado.Text = "Resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_resultado);
            this.Controls.Add(this.bt_calcular);
            this.Controls.Add(this.box_3);
            this.Controls.Add(this.box_2);
            this.Controls.Add(this.box_1);
            this.Controls.Add(this.txt_idade3);
            this.Controls.Add(this.txt_idade2);
            this.Controls.Add(this.txt_idade1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_idade1;
        private System.Windows.Forms.Label txt_idade2;
        private System.Windows.Forms.Label txt_idade3;
        private System.Windows.Forms.TextBox box_1;
        private System.Windows.Forms.TextBox box_2;
        private System.Windows.Forms.TextBox box_3;
        private System.Windows.Forms.Button bt_calcular;
        private System.Windows.Forms.Label txt_resultado;
    }
}

