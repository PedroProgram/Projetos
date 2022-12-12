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
    public partial class RelatorioCategoria : Form
    {
        public RelatorioCategoria()
        {
            InitializeComponent();
        }

        private void RelatorioCategoria_Load(object sender, EventArgs e)
        {
            ClassCategoria cCategoria = new ClassCategoria();
            ClassCategoriaBindingSource.DataSource = cCategoria.RelatorioCategoria();

            this.reportViewerCategoria.RefreshReport();
        }

        private void bt_Sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem Certeza Que Deseja Sair ?", "Sistema Papelaria Humanas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void bt_ajuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta é a tela de Relatório de Categoria, um local onde será gerado todos os Relatórios", "Sistema Papelaria Humanas", MessageBoxButtons.OK);
        }
    }
}
