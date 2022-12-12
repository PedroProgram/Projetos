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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuCadFornecedor_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormFornecedor>().Count() > 0)
            {
                MessageBox.Show("o formulario cadastro de fornecedor ja está aberto!", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                //COMO TRANSFORMAR ALGO EM OBJETO

                //nome nomeParaObjeto = new formcliente();

                FormFornecedor ffornecedor = new FormFornecedor();
                ffornecedor.Show();
            }










        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormMarca>().Count() > 0)
            {
                MessageBox.Show("o formulario cadastro de marca ja está aberto!", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                //COMO TRANSFORMAR ALGO EM OBJETO

                //nome nomeParaObjeto = new formcliente();

                FormMarca fMarca = new FormMarca();
                fMarca.Show();
            }
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormCategoria>().Count() > 0)
            {
                MessageBox.Show("o formulario cadastro de Categoria ja está aberto!", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                //COMO TRANSFORMAR ALGO EM OBJETO

                //nome nomeParaObjeto = new formcliente();

                FormCategoria fCategoria = new FormCategoria();
                fCategoria.Show();
            }
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormProduto>().Count() > 0)
            {
                MessageBox.Show("o formulario cadastro de Produto ja está aberto!", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                //COMO TRANSFORMAR ALGO EM OBJETO

                //nome nomeParaObjeto = new formcliente();

                FormProduto fProduto = new FormProduto();
                fProduto.Show();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms.OfType<FormFornecedor>().Count() > 0)
            {
                MessageBox.Show("o formulario cadastro de fornecedor ja está aberto!", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                //COMO TRANSFORMAR ALGO EM OBJETO

                //nome nomeParaObjeto = new formcliente();

                FormFornecedor ffornecedor = new FormFornecedor();
                ffornecedor.Show();
            }

        }

        private void cadastrosToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormMarca>().Count() > 0)
            {
                MessageBox.Show("o formulario cadastro de marca ja está aberto!", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                //COMO TRANSFORMAR ALGO EM OBJETO

                //nome nomeParaObjeto = new formcliente();

                FormMarca fMarca = new FormMarca();
                fMarca.Show();
            }
        }

        private void cadastrosToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormCategoria>().Count() > 0)
            {
                MessageBox.Show("o formulario cadastro de Categoria ja está aberto!", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                //COMO TRANSFORMAR ALGO EM OBJETO

                //nome nomeParaObjeto = new formcliente();

                FormCategoria fCategoria = new FormCategoria();
                fCategoria.Show();
            }
        }

        private void cadastrosToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormProduto>().Count() > 0)
            {
                MessageBox.Show("o formulario cadastro de Produto ja está aberto!", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                //COMO TRANSFORMAR ALGO EM OBJETO

                //nome nomeParaObjeto = new formcliente();

                FormProduto fProduto = new FormProduto();
                fProduto.Show();
            }
        }

        private void consultaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormConsultaFornecedor>().Count() > 0)
            {
                MessageBox.Show("o formulario de consulta de fornecedor ja está aberto!", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                //COMO TRANSFORMAR ALGO EM OBJETO

                //nome nomeParaObjeto = new formcliente();

                FormConsultaFornecedor fConsultaFornecedor = new FormConsultaFornecedor();
                fConsultaFornecedor.Show();

            }
        }

        private void consultaToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormConsultaMarca>().Count() > 0)
            {
                MessageBox.Show("o formulario de consulta de marca ja está aberto!", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                //COMO TRANSFORMAR ALGO EM OBJETO

                //nome nomeParaObjeto = new formcliente();

                FormConsultaMarca fConsultaMarca = new FormConsultaMarca();
                fConsultaMarca.Show();
            }
        }

        private void consultaToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormConsultaCategoria>().Count() > 0)
            {
                MessageBox.Show("o formulario de consulta de Categoria ja está aberto!", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                //COMO TRANSFORMAR ALGO EM OBJETO

                //nome nomeParaObjeto = new formcliente();

                FormConsultaCategoria fConsultaCategoria = new FormConsultaCategoria();
                fConsultaCategoria.Show();
            }
        }

        private void consultaToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormConsultaProduto>().Count() > 0)
            {
                MessageBox.Show("O Formulario De Consulta De Produto Ja Está Aberto!", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                //COMO TRANSFORMAR ALGO EM OBJETO

                //nome nomeParaObjeto = new formcliente();

                FormConsultaProduto fConsultaProduto = new FormConsultaProduto();
                fConsultaProduto.Show();
            }
        }

        private void relatórioToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<RelatorioMarca>().Count() > 0)
            {
                MessageBox.Show("O Formulario De Relatório De Marca Ja Está Aberto!", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                //COMO TRANSFORMAR ALGO EM OBJETO

                //nome nomeParaObjeto = new formcliente();

                RelatorioMarca fRelMarca = new RelatorioMarca();
                fRelMarca.Show();
            }
        }

        private void bt_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void relatórioToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<RelatorioCategoria>().Count() > 0)
            {
                MessageBox.Show("O Formulario De Relatório De Categoria Ja Está Aberto!", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                //COMO TRANSFORMAR ALGO EM OBJETO

                //nome nomeParaObjeto = new formcliente();

               RelatorioCategoria fRelCategoria = new RelatorioCategoria();
                fRelCategoria.Show();
            }
        }

        private void relatórioToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<RelatorioFornecedor>().Count() > 0)
            {
                MessageBox.Show("O Formulario De Relatório De Fornecedor Ja Está Aberto!", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                //COMO TRANSFORMAR ALGO EM OBJETO

                //nome nomeParaObjeto = new formcliente();

                RelatorioFornecedor fFornecedor = new RelatorioFornecedor();
                fFornecedor.Show();
            }
        }

        private void relatórioToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<RelatorioProduto>().Count() > 0)
            {
                MessageBox.Show("O Formulario De Relatório De Produto Ja Está Aberto!", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                //COMO TRANSFORMAR ALGO EM OBJETO

                //nome nomeParaObjeto = new formcliente();

                RelatorioProduto fProduto = new RelatorioProduto();
                fProduto.Show();
            }
        }

        private void cadastrosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormCliente>().Count() > 0)
            {
                MessageBox.Show("O Formulario De Cadastro Cliente Ja Está Aberto!", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                //COMO TRANSFORMAR ALGO EM OBJETO

                //nome nomeParaObjeto = new formcliente();

                FormCliente fCliente = new FormCliente();
                fCliente.Show();
            }

        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormConsultaCliente>().Count() > 0)
            {
                MessageBox.Show("O Formulario De Consulta Cliente Ja Está Aberto!", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                //COMO TRANSFORMAR ALGO EM OBJETO

                //nome nomeParaObjeto = new formcliente();

                FormConsultaCliente fConsulta = new FormConsultaCliente();
                fConsulta.Show();
            }
        }

        private void relatorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Relatoriocliente>().Count() > 0)
            {
                MessageBox.Show("O Formulario De Relatório Cliente Ja Está Aberto!", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                //COMO TRANSFORMAR ALGO EM OBJETO

                //nome nomeParaObjeto = new formcliente();

                Relatoriocliente fConsulta = new Relatoriocliente();
                fConsulta.Show();
            }
        }

        private void cadastrosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormFuncionario>().Count() > 0)
            {
                MessageBox.Show("O Formulario De Cadastro De Funcionario Ja Está Aberto!", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                //COMO TRANSFORMAR ALGO EM OBJETO

                //nome nomeParaObjeto = new formcliente();

                FormFuncionario fConsulta = new FormFuncionario();
                fConsulta.Show();
            }
        }

        private void consultaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormConsultaFuncionario>().Count() > 0)
            {
                MessageBox.Show("O Formulario De Consulta De Funcionario Ja Está Aberto!", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                //COMO TRANSFORMAR ALGO EM OBJETO

                //nome nomeParaObjeto = new formcliente();

                FormConsultaFuncionario fConsulta = new FormConsultaFuncionario();
                fConsulta.Show();
            }
        }

        private void relatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<RelatorioFuncionario>().Count() > 0)
            {
                MessageBox.Show("O Formulario De Relatório De Funcionario Ja Está Aberto!", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                //COMO TRANSFORMAR ALGO EM OBJETO

                //nome nomeParaObjeto = new formcliente();

                RelatorioFuncionario fConsulta = new RelatorioFuncionario();
                fConsulta.Show();
            }
        }

        private void cadastrosToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormCargo>().Count() > 0)
            {
                MessageBox.Show("O Formulario De Cadastro De Cargo Ja Está Aberto!", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                //COMO TRANSFORMAR ALGO EM OBJETO

                //nome nomeParaObjeto = new formcliente();

                FormCargo fConsulta = new FormCargo();
                fConsulta.Show();
            }
        }

        private void consultaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormConsultarCargo>().Count() > 0)
            {
                MessageBox.Show("O Formulario De Consulta De Cargo Ja Está Aberto!", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                //COMO TRANSFORMAR ALGO EM OBJETO

                //nome nomeParaObjeto = new formcliente();

                FormConsultarCargo fConsulta = new FormConsultarCargo();
                fConsulta.Show();
            }
        }

        private void relatórioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<RelatorioCargo>().Count() > 0)
            {
                MessageBox.Show("O Formulario De Relatório De Cargo Ja Está Aberto!", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                //COMO TRANSFORMAR ALGO EM OBJETO

                //nome nomeParaObjeto = new formcliente();

                RelatorioCargo fConsulta = new RelatorioCargo();
                fConsulta.Show();
            }
        }

        private void cadastrosToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formVenda43>().Count() > 0)
            {
                MessageBox.Show("O Formulario De Venda Ja Está Aberto!", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                //COMO TRANSFORMAR ALGO EM OBJETO

                //nome nomeParaObjeto = new formcliente();

                formVenda43 fProduto = new formVenda43();
                fProduto.Show();
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lb_data.Text = DateTime.Now.ToLongDateString();
            lb_hora.Text = DateTime.Now.ToLongTimeString();
        }

        private void relatórioToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormRelVenda>().Count() > 0)
            {
                MessageBox.Show("O Formulario De Relatório De Venda Ja Está Aberto!", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                //COMO TRANSFORMAR ALGO EM OBJETO

                //nome nomeParaObjeto = new formcliente();
                FormRelVenda fRelVenda = new FormRelVenda();
                fRelVenda.Show();
            }
        }

        private void bt_ajuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta é a tela Principal, A tela onde o usuario tera acesso a todos as telas do sistema", "Sistema Papelaria Humanas", MessageBoxButtons.OK);
        }
    }
}
