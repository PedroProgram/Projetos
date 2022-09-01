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
    public partial class FormRelcliente : Form
    {
        public FormRelcliente()
        {
            InitializeComponent();
        }

        private void FormRelcliente_Load(object sender, EventArgs e)
        {   //Pesquisa por idade
            comboBox_tipo_consul.Items.Add("Idade");

            //Pesquisa de Sexo
            comboBox_tipo_consul.Items.Add("Sexo");
            //Pesquisa por cidade
            comboBox_tipo_consul.Items.Add("Cidade");

            //Pesquisa por Status
            comboBox_tipo_consul.Items.Add("Status");
            //Pesquisa por Cargo
            comboBox_tipo_consul.Items.Add("Cargo");


            //Fechar uma opção de groupbox quando selecionar outra
            

            ClassCliente ccliente = new ClassCliente();
            ClassClienteBindingSource.DataSource = ccliente.relatoriocliente();
            this.reportViewer1.RefreshReport();

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassCliente cCliente = new ClassCliente();

            string relatorio = comboBox_tipo_consul.SelectedItem.ToString();

            switch (relatorio)
            {
                case "Aniversariantes Idade":
                    if (box_idade_inicio.Text != "" && box_idade_final.Text != "")
                    {
                        ClassClienteBindingSource.DataSource = cCliente.RelClienteIdade(Convert.ToInt32(box_idade_inicio.Text), Convert.ToInt32(box_idade_final.Text));
                        this.reportViewer1.RefreshReport();


                    }
                    else
                    {
                        MessageBox.Show("Favor preencher as caixas de textos", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    break;

                case "Aniversariantes Maiores de":
                    if (box_maior.Text != "")
                    {
                        ClassClienteBindingSource.DataSource = cCliente.RelClienteMaiorDe(Convert.ToInt32(box_maior.Text));
                        this.reportViewer1.RefreshReport();
                    }

                    else
                    {
                        MessageBox.Show("Favor preencher as caixas de textos", "Ssitema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    break;

                case "Sexo":
                if(radio_feminino.Checked == true)
                {
                        ClassClienteBindingSource.DataSource = cCliente.RelClienteSexo("F");
                        this.reportViewer1.RefreshReport();

                    }
                else
                {
                        ClassClienteBindingSource.DataSource = cCliente.RelClienteSexo("M");
                        this.reportViewer1.RefreshReport();

                    }
                break;


                case "Cidade":
                if(box_cidade.Text !="")
                {
                        ClassClienteBindingSource.DataSource = cCliente.RelClienteCidade(box_cidade.Text);
                        this.reportViewer1.RefreshReport();


                }
                else
                {
                        MessageBox.Show("Favor preencher a caixa de texto", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                    break;

                //Status
                case "Status":
                    if (radio_ativo.Checked == true)
                    {
                        ClassClienteBindingSource.DataSource = cCliente.RelClienteStatus(1);
                        this.reportViewer1.RefreshReport();

                    }

                    else
                    {
                        ClassClienteBindingSource.DataSource = cCliente.RelClienteStatus(0);
                        this.reportViewer1.RefreshReport();

                    }
                    break;


            }
        }
    }
}
