using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPapelariaHumanas
{
    public partial class FormRelCargo : Form
    {
        public FormRelCargo()
        {
            InitializeComponent();
        }

        private void FormRelCargo_Load(object sender, EventArgs e)
        {
            ClassCargo ccargo = new ClassCargo();
            ClassCargoBindingSource.DataSource = ccargo.relatoriocargo();
            this.rptv.RefreshReport();
            
        }

        private void rptv_Load(object sender, EventArgs e)
        {

        }
    }
}
