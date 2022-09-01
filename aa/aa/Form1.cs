using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_calcular_Click(object sender, EventArgs e)
        {
            if (box_1.Text != "" && box_2.Text != "" && box_3.Text!= "")
            {
                int idade1, idade2, idade3;
                int resultado;

                idade1 = Convert.ToInt32(box_1.Text);
                idade2 = Convert.ToInt32(box_2.Text);
                idade3 = Convert.ToInt32(box_3.Text);
                resultado = (idade1 + idade2 + idade3) / 3;

                txt_resultado.Text = resultado.ToString();



            }
               

                else
                {
                    MessageBox.Show("preencha o campo", "Atençao!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                }




            
            



        
                

                   
             
            



            
        }
    }
}
