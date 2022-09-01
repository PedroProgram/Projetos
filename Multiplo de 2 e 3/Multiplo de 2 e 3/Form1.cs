using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiplo_de_2_e_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(textBox1.Text);


            if(numero == 2 || numero == 4 || numero == 6 || numero == 8 || numero == 10)
            {
                lb_resultado.Text = "Esse número é divisível por 2";


            }
            else if (numero == 3 || numero == 6 || numero == 9 || numero == 12 || numero == 15)
            {
                lb_resultado.Text = "Esse número é divisível por 3";


            }
        }
    }
}
