using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace salario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_calcular_Click(object sender, EventArgs e)
        {
            decimal valor = Convert.ToDecimal(tb_valor.Text);
            decimal aumento = 0;
            decimal resultado = 0;

            //Atribuir valor dos salários
            if (resultado >= 5000 *10 /100)
            {
                aumento = resultado + valor;   
             
             

                


             
            }
            else if (resultado < 5000 && resultado >= 2000 *20 /100)
            {
               


            }


            txt_resultado.Text = valor.ToString();
         

        }
    }
}
