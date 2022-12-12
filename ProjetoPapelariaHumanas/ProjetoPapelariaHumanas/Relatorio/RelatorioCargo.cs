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
    public partial class RelatorioCargo : Form
    {
        public RelatorioCargo()
        {
            InitializeComponent();
        }

        private void FormRelCargo_Load(object sender, EventArgs e)
        {
            ClassCargo ccargo = new ClassCargo();
            ClassCargoBindingSource.DataSource = ccargo.relatoriocargo();
            this.rptv.RefreshReport();
            
        }

        private void bt_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_ajuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta é a tela de Relatório de Cargo, um local onde será gerado todos os Relatórios", "Sistema Papelaria Humanas", MessageBoxButtons.OK);
        }
    }
}
