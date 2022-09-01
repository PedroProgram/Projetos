using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace funcionário
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = Convert.ToString(tb_nome.Text);
            double horas_trabalhadas = Convert.ToDouble(tb_horas.Text);
            double valor_hora = Convert.ToDouble(tb_valorhora.Text);
            int filhos = Convert.ToInt32(tb_filhos.Text);
            double salario = 0;

            salario = valor_hora * horas_trabalhadas;
            salario = (filhos * 0.03 * salario) + salario;

            lb_resultado.Text = Convert.ToString(salario);


        }
    }
}
