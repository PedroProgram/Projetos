using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mes2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cb_mes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int mes = Convert.ToInt32(cb_mes.SelectedItem);

            switch (mes)
            {

                case 1:
                    tb_box1.Text = "Janeiro";
                    break;

                case 2:
                    tb_box1.Text = "Fevereiro";
                    break;
                case 3:
                    tb_box1.Text = "Março";
                    break;

                  
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cb_mes.Items.Add(01);
            cb_mes.Items.Add(02);
            cb_mes.Items.Add(03);
            cb_mes.Items.Add(04);

        }
    }
}
