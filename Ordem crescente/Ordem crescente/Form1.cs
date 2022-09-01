using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ordem_crescente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valor = Convert.ToInt32(textBox1.Text);

            if (valor == 4 || valor == 20)
            {
                lb_resultado.Text = "è divisível por 2";


            }
            else if (valor == 9 || valor == 27)
            {

                lb_resultado.Text = "è divisível por 3";



            }





        }
    }
}
