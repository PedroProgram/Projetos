using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLojaCosmeticos
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void MenuClientes_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms.OfType<FormCliente>().Count()>0)
            {
                MessageBox.Show("O Formulário de Clientes já está aberto", "Atenção!!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);



            }
            else
            {
                FormCliente F10C = new FormCliente();
                F10C.Show();




            }



        }

        private void MenuProdutos_Click(object sender, EventArgs e)
        {
           if(Application.OpenForms.OfType<FormProduto>().Count()>0)
           {
                MessageBox.Show("O FormulárioCadastro de Produtos já está aberto", "Atenção!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);



           }
           else
           {


                FormProduto F11P = new FormProduto();
                F11P.Show();

           }

        }

        private void bt_sair_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show( "Tem certeza que deseja fechar o sistema?", "Atenção!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                Application.Exit();
            }
        }

        private void Timer_principal_Tick(object sender, EventArgs e)
        {
            lb_data.Text = DateTime.Now.ToShortDateString();
            lb_hora.Text = DateTime.Now.ToShortTimeString();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void MenuConsultas_Click(object sender, EventArgs e)
        {


        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms.OfType<FormConsulta1>().Count() > 0)
            {
                MessageBox.Show("O Formulário de Clientes já está aberto", "Atenção!!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);



            }
            else
            {
                FormConsulta1 F12 = new FormConsulta1();
                F12.Show();




            }
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formRelClientes43>().Count() > 0)
            {
                MessageBox.Show("O Formulário de Clientes já está aberto", "Atenção!!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);



            }
            else
            {
               formRelClientes43 F10C = new formRelClientes43();
                F10C.Show();




            }
        }
    }
}

