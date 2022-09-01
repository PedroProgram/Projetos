using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)

        {
            int mes = Convert.ToInt32(cb_mes.Text);
            
            if (mes ==1)
            {
                box_1.Text = "Janeiro";
                box_1.ForeColor = Color.Red;


            }
            else if (mes ==2)
            {
                box_1.Text = "fevereiro";
                box_1.ForeColor = Color.Black;


            }

           
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cb_mes.Items.Add(01);
            cb_mes.Items.Add(02);
            cb_mes.Items.Add(03);
            cb_mes.Items.Add(04);
            cb_mes.Items.Add(05);
        }
    }
}
