using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_notas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal nota1= Convert.ToDecimal(textBox1.Text);    
            decimal nota2= Convert.ToDecimal(textBox2.Text);
            decimal nota3 = Convert.ToDecimal(textBox3.Text);
            decimal nota4 = Convert.ToDecimal(textBox4.Text);
          
            
            decimal nota_final = Convert.ToDecimal(textBox6);


            nota_final = nota1 + nota2 + nota3 + nota4 / 4;
            
            if (nota_final >= 7)
            {
                lb_resultado.Text = "Aprovado";



            }
            else if (nota_final <7 || nota_final <5)
            {
                
                lb_resultado.Text = "Recuperação";


            }







        }
    }
}
