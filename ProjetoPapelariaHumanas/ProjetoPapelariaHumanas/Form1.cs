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
    public partial class FormPrinciaal : Form
    {
        public FormPrinciaal()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormCliente>().Count() > 0)
            {
                MessageBox.Show("O Formulário de Clientes já está aberto", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);



            }
            else
            {
                FormCliente F10C = new FormCliente();
                F10C.Show();




            }
        }

        private void cargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormCargocs>().Count() > 0)
            {
                MessageBox.Show("O Formulário de Cargo já está aberto", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            }
            else
            {
                FormCargocs F11 = new FormCargocs();
                F11.Show();



            }

        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormFuncionario>().Count() > 0)
            {
                MessageBox.Show("O Formulário de Funcionários já está aberto", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);



            }
            else
            {
                FormFuncionario F9F = new FormFuncionario();
                F9F.Show();




            }
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormCliente>().Count() > 0)
            {
                MessageBox.Show("O Formulário de Clientes já está aberto", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);



            }
            else
            {
                FormCliente F10C = new FormCliente();
                F10C.Show();




            }
        }

        private void cadastroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormFuncionario>().Count() > 0)
            {
                MessageBox.Show("O Formulário de Funcionários já está aberto", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);



            }
            else
            {
                FormFuncionario F9F = new FormFuncionario();
                F9F.Show();




            }
        }

        private void cadastroToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormCargocs>().Count() > 0)
            {
                MessageBox.Show("O Formulário de Cargo já está aberto", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            }
            else
            {
                FormCargocs F11 = new FormCargocs();
                F11.Show();



            }
        }

        private void relatórioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormRelFuncionario>().Count() > 0)
            {
                MessageBox.Show("O Formulário de Funcionários já está aberto", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                FormRelFuncionario RelFun = new FormRelFuncionario();
                RelFun.Show();

            }
        }

        private void relatórioToolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormConsultaCliente>().Count() > 0)
            {
                MessageBox.Show("O Formulário de Clientes já está aberto", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);



            }
            else
            {
                FormConsultaCliente consultacliente = new FormConsultaCliente();
                consultacliente.Show();
            }
        }

        private void bt_sair_sistema_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja fechar o Sistema?", "Sistema Papelaria Humanas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                Application.Exit();
            }
        }

        private void consultaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormConsultarCargo>().Count() > 0)
            {
                MessageBox.Show("O Formulário de Cargo já está aberto", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);



            }
            else
            {
                FormConsultarCargo consultarcargo = new FormConsultarCargo();
                consultarcargo.Show();
            }
        }

        private void consultaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormConsularFuncionario>().Count() > 0)
            {
                MessageBox.Show("O Formulário de Funcionários já está aberto", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);



            }
            else
            {
                FormConsularFuncionario consultarfun = new FormConsularFuncionario();
                consultarfun.Show();
            }
        }

        private void relatórioToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormRelCargo>().Count() > 0)
            {
                MessageBox.Show("O Formulário de consulta de cargo já está aberto", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                FormRelCargo Relcargo = new FormRelCargo();
                Relcargo.Show();

            }
        }

        private void relatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormRelcliente>().Count() > 0)
            {
                MessageBox.Show("O Formulário de Clientes já está aberto", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                 FormRelcliente RelCli = new FormRelcliente();
                RelCli.Show();
            }
        }
    }
}
