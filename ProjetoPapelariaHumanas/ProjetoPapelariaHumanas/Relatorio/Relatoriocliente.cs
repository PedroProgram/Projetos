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
    public partial class Relatoriocliente : Form
    {
        public Relatoriocliente()
        {
            InitializeComponent();
        }

        private void FormRelcliente_Load(object sender, EventArgs e)

        {
            combo_tipo_relatorio.Items.Add("Selecione Uma Opção");
            //Pesquisa por idade
            combo_tipo_relatorio.Items.Add("Idade");
            //Pesquisa de Sexo
            combo_tipo_relatorio.Items.Add("Sexo");
            //Pesquisa por cidade
            combo_tipo_relatorio.Items.Add("Cidade");
            //Pesquisa por Status
            combo_tipo_relatorio.Items.Add("Status");
            //Pesquisa por Maior de
            combo_tipo_relatorio.Items.Add("Maiores de");

            combo_tipo_relatorio.SelectedIndex = 0;

            //ATIVAR UMA OPÇÃO DE RADIOBUTTON
            radio_ativo.Checked = true;
            radio_feminino.Checked = true;

            
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Opção
            if (combo_tipo_relatorio.SelectedIndex == 0)
            {
                groupBox_cidade.Enabled = false;
                groupBox_idade.Enabled = false;
                groupBox_sexo.Enabled = false;
                groupBox_status.Enabled = false;
                groupBox_maiores_de.Enabled = false;

            }
            //Idade
            if (combo_tipo_relatorio.SelectedIndex == 1)
            {
                groupBox_cidade.Enabled = false;
                groupBox_idade.Enabled = true;
                groupBox_sexo.Enabled = false;
                groupBox_status.Enabled = false;
                groupBox_maiores_de.Enabled = false;

            }
            //Sexo
            if (combo_tipo_relatorio.SelectedIndex == 2)
            {
                groupBox_cidade.Enabled = false;
                groupBox_idade.Enabled = false;
                groupBox_sexo.Enabled = true;
                groupBox_status.Enabled = false;
                groupBox_maiores_de.Enabled = false;

            }

            //Cidade
            if (combo_tipo_relatorio.SelectedIndex == 3)
            {
                groupBox_cidade.Enabled = true;
                groupBox_idade.Enabled = false;
                groupBox_sexo.Enabled = false;
                groupBox_status.Enabled = false;
                groupBox_maiores_de.Enabled = false;

            }

            //Status 
            if (combo_tipo_relatorio.SelectedIndex == 4)
            {
                groupBox_cidade.Enabled = false;
                groupBox_idade.Enabled = false;
                groupBox_sexo.Enabled = false;
                groupBox_status.Enabled = true;
                groupBox_maiores_de.Enabled = false;

            }
            //Maiores de
            if (combo_tipo_relatorio.SelectedIndex == 5)
            {
                groupBox_cidade.Enabled = false;
                groupBox_idade.Enabled = false;
                groupBox_sexo.Enabled = false;
                groupBox_status.Enabled = false;
                groupBox_maiores_de.Enabled = true;


            }

            

           
        }

        private void button_relatorio_Click(object sender, EventArgs e)
        {
            ClassCliente cCliente = new ClassCliente();

            string relatorio = combo_tipo_relatorio.SelectedItem.ToString();

            switch (relatorio)
            {
                case "Idade":
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

                case "Maiores de":
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
                    if (radio_feminino.Checked == true)
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
                    if (box_cidade.Text != "")
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

        private void bt_sair_Click(object sender, EventArgs e)
        {
            if (combo_tipo_relatorio.SelectedIndex > 0)
            {
                if (MessageBox.Show("Tem Certeza Que Deseja Sair ?", "Sistema Papelaria Humanas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Close();
                }

            }
            else
            {
                this.Close();
            }
        }

        private void box_maior_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número, backspace(08), enter(13) e espaço(32)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 32)
            {    //see o usuário pressionar uma tecla não numérica no textbox, cancela o evento key press

                e.Handled = true;
                MessageBox.Show("Este Campo Aceita Apenas Números", "Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {

            }
        }

        private void box_idade_inicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número, backspace(08), enter(13) e espaço(32)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 32)
            {    //see o usuário pressionar uma tecla não numérica no textbox, cancela o evento key press

                e.Handled = true;
                MessageBox.Show("Este Campo Aceita Apenas Números", "Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {

            }
        }

        private void box_idade_final_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número, backspace(08), enter(13) e espaço(32)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 32)
            {    //see o usuário pressionar uma tecla não numérica no textbox, cancela o evento key press

                e.Handled = true;
                MessageBox.Show("Este Campo Aceita Apenas Números", "Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {

            }
        }

        private void bt_ajuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta é a tela de Relatório de Cliente, um local onde será gerado todos os Relatórios", "Sistema Papelaria Humanas", MessageBoxButtons.OK);
        }
    } 
}

