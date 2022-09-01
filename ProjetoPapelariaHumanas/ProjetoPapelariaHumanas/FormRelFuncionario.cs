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
    public partial class FormRelFuncionario : Form
    {
        public FormRelFuncionario()
        {
            InitializeComponent();
        }

        private void FormRelFuncionario_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            //Pesquisa por idade
            comboBox_tipo_consul.Items.Add( "Idade");

            //Pesquisa maior de:
            comboBox_tipo_consul.Items.Add("Cargo");

            //Pesquisa de Sexo
            comboBox_tipo_consul.Items.Add("Sexo");

            //Pesquisa por cidade
            comboBox_tipo_consul.Items.Add("Cidade");

            comboBox_tipo_consul.Items.Add("Status");




            //CARRREGAR COMBO CARGO
            ClassCargo cCargo = new ClassCargo();
            combo_c.DataSource = cCargo.BuscarCargo();//executar método criado na classe categoria
            combo_c.DisplayMember = "nome";//exibir na combo (nome)
            combo_c.ValueMember = "codigo_cargo"; //guardar no BD (código)
            combo_c.SelectedIndex = -1; //Limpar a combo (não seleciona nada - quando abrir o form




        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            ClassFuncionario cfuncionario = new ClassFuncionario();

            string relatorio = comboBox_tipo_consul.SelectedItem.ToString();

            //Cargo
            switch (relatorio)
            {

                case "Cargo":
                    if (comboBox_tipo_consul.SelectedIndex != -1)
                    {
                        ClassFuncionarioBindingSource.DataSource = cfuncionario.RelfunCargo(Convert.ToInt32(combo_c.SelectedValue));

                        this.reportViewer1.RefreshReport();
                    }
                    else
                    {
                        MessageBox.Show("Favor informar um Cargo", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    break;

                //Status
                case "Status":
                    if (radio_ativo.Checked == true)
                    {
                        ClassFuncionarioBindingSource.DataSource = cfuncionario.RelfunStatus(1);
                        this.reportViewer1.RefreshReport();

                    }
                    else
                    {
                        ClassFuncionarioBindingSource.DataSource = cfuncionario.RelfunStatus(0);
                        this.reportViewer1.RefreshReport();

                    }
                    break;
                //Cidade
                case "Cidade":
                    if (box_cidade.Text != "")
                    {
                        ClassFuncionarioBindingSource.DataSource = cfuncionario.RelfunCidade(box_cidade.Text);
                        this.reportViewer1.RefreshReport();


                    }
                    else
                    {
                        MessageBox.Show("Favor preencher a caixa de texto", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    break;

                //Idade
                case "Idade":
                    if (box_inicio.Text != "" && box_final.Text != "")
                    {
                        ClassFuncionarioBindingSource.DataSource = cfuncionario.RelfunIdades(Convert.ToInt32(box_inicio.Text), Convert.ToInt32(box_final.Text));
                        this.reportViewer1.RefreshReport();


                    }
                    else
                    {
                        MessageBox.Show("Favor preencher as caixas de textos", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    break;

                //Sexo
                case "Sexo":
                    if (radio_feminino.Checked == true)
                    {
                        ClassFuncionarioBindingSource.DataSource = cfuncionario.RelfunSexo("F");
                        this.reportViewer1.RefreshReport();

                    }
                    else
                    {
                        ClassFuncionarioBindingSource.DataSource = cfuncionario.RelfunSexo("M");
                        this.reportViewer1.RefreshReport();

                    }
                    break;

            }       


          
        }

        private void comboBox_tipo_consul_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ATIVAR E DESATIVAR OS ELEMENTOS DO FORM CONFROME A ESCOLHA DO USUÁRIO

            //Idade
            if (comboBox_tipo_consul.SelectedIndex == 0)
            {
                groupBox_cidade.Enabled = false;
                groupBox_idade.Enabled = true;
                groupBox_sexo.Enabled = false;
                groupBox_status.Enabled = false;
                group_box_cargo.Enabled = false;

            }


            //Cargo
           if (comboBox_tipo_consul.SelectedIndex == 1)
           {
                groupBox_cidade.Enabled = false;
                groupBox_idade.Enabled = false;
                groupBox_sexo.Enabled = false;
                groupBox_status.Enabled = false;
                group_box_cargo.Enabled = true;

           }



            //Sexo
            if(comboBox_tipo_consul.SelectedIndex == 2)
            {
                groupBox_cidade.Enabled = false;
                groupBox_idade.Enabled = false;
                groupBox_sexo.Enabled = true;
                groupBox_status.Enabled = false;
                group_box_cargo.Enabled = false;

            }
               



            //Cidade
            if (comboBox_tipo_consul.SelectedIndex == 3)
            {
                groupBox_cidade.Enabled = true;
                groupBox_idade.Enabled = false;
                groupBox_sexo.Enabled = false;
                groupBox_status.Enabled = false;
                group_box_cargo.Enabled = false;

            }

            //Status
            if (comboBox_tipo_consul.SelectedIndex == 4)
            {

                groupBox_cidade.Enabled = false;
                groupBox_idade.Enabled = false;
                groupBox_sexo.Enabled = false;
                groupBox_status.Enabled = true;
                group_box_cargo.Enabled = false;


            }




        }
    }
}
