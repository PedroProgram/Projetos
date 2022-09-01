using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace potência_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lb_box_SelectedIndexChanged(object sender, EventArgs e)
        {
    
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cal = 3;
            for (int b = 1; b <= 15; b++)
            {
                lb_box.Items.Add(Math.Pow(cal, b));


            }

        }
    }
}
