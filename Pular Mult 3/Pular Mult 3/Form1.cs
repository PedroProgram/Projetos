using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pular_Mult_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            for(int mult = 0; mult<=1000; mult++)
            {
              if( mult %3 == 0)
              {

                    
                    
                   




              }

              else
              {
                    MessageBox.Show("Resultado" + mult); 



              }
            }
        }
    }
}
