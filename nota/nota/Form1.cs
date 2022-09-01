using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nota
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_exibir_Click(object sender, EventArgs e)
        {
            decimal nota1 = Convert.ToDecimal(tb_nota1.Text);
            decimal nota2= Convert.ToDecimal(tb_nota2.Text);
            decimal nota3= Convert.ToDecimal(tb_nota3.Text);
            decimal nota4= Convert.ToDecimal(tb_nota4.Text);

            decimal maior;
            decimal media;
            decimal menor;

            maior = nota1;
            media = (nota1 + nota2 + nota3 + nota4) / 3;
            menor = nota1;

            if ( nota2 > maior)
            {
                maior = nota2;



            }
            if(nota3 > maior)
            {
               maior = nota3;


            }
            if(nota4 > maior)
            {
                maior = nota4;


            }
            if (nota2 < maior)
            {
             menor = nota2;

            }
            if (nota3 < maior)
            {
                menor = nota3;

            }
            if (nota4 < maior)
            {
                menor = nota4;
            }

            lb_maior.Text = Convert.ToString(maior); 
            lb_media.Text = Convert.ToString(media);
            lb_menor.Text = Convert.ToString(menor);
        }

    }
}
