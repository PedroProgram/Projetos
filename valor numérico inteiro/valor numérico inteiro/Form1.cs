using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace valor_numérico_inteiro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_Click(object sender, EventArgs e)
        {
            int maior = Convert.ToInt32(tb_1.Text);
            int menor = Convert.ToInt32(tb_2.Text);
            int resultado = 0;
            
            if(maior > menor)
            {
               
                resultado = maior - menor;

            }

            else if (menor > maior)
            {
                resultado = menor - maior;


            }
            lb_resultado.Text = Convert.ToString(resultado);
        }
    }
}
