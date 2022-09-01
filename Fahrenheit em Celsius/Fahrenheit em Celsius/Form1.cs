using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fahrenheit_em_Celsius
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal fah = Convert.ToDecimal(textBox1.Text);
            decimal celsius;

            celsius = (fah - 32) * (5 )/9;
            lb_resultado.Text = celsius.ToString();


        }
    }
}
