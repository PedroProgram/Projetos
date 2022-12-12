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
    public partial class RelatorioFuncionario : Form
    {
        public RelatorioFuncionario()
        {
            InitializeComponent();
        }

        private void FormRelFuncionario_Load(object sender, EventArgs e)
        {

            
            combo_tipo_relatorio.Items.Add("Selecione Uma Opção");

            //Pesquisa por idade
            combo_tipo_relatorio.Items.Add( "Idade");

            //Pesquisa maior de:
            combo_tipo_relatorio.Items.Add("Cargo");

            //Pesquisa de Sexo
            combo_tipo_relatorio.Items.Add("Sexo");

            //Pesquisa por cidade
            combo_tipo_relatorio.Items.Add("Cidade");

            combo_tipo_relatorio.Items.Add("Status");

            combo_tipo_relatorio.SelectedIndex = 0;



            //CARRREGAR COMBO CARGO
            ClassCargo cCargo = new ClassCargo();
            combo_c.DataSource = cCargo.BuscarCargo();//executar método criado na classe categoria
            combo_c.DisplayMember = "nome";//exibir na combo (nome)
            combo_c.ValueMember = "codigo_cargo"; //guardar no BD (código)
            combo_c.SelectedIndex = -1; //Limpar a combo (não seleciona nada - quando abrir o form

            //DEIXAR UMA OPÇÃO DE RADIOBUTTON SELECIONADA
            radio_ativo.Checked = true;
            radio_feminino.Checked = true;


        }

        private void button1_Click(object sender, EventArgs e)
        {

            ClassFuncionario cfuncionario = new ClassFuncionario();

            string relatorio = combo_tipo_relatorio.SelectedItem.ToString();

            //Cargo
            switch (relatorio)
            {

                case "Cargo":
                    if (combo_tipo_relatorio.SelectedIndex != -1)
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

            //Opção
            if (combo_tipo_relatorio.SelectedIndex == 0)
            {
                groupBox_cidade.Enabled = false;
                groupBox_idade.Enabled = false;
                groupBox_sexo.Enabled = false;
                groupBox_status.Enabled = false;
                group_box_cargo.Enabled = false;

            }


            //Idade
           if (combo_tipo_relatorio.SelectedIndex == 1)
           {
                groupBox_cidade.Enabled = false;
                groupBox_idade.Enabled = true;
                groupBox_sexo.Enabled = false;
                groupBox_status.Enabled = false;
                group_box_cargo.Enabled = false;

           }



            //Cargo
            if(combo_tipo_relatorio.SelectedIndex == 2)
            {
                groupBox_cidade.Enabled = false;
                groupBox_idade.Enabled = false;
                groupBox_sexo.Enabled = false;
                groupBox_status.Enabled = false;
                group_box_cargo.Enabled = true;

            }
               



            //Sexo
            if (combo_tipo_relatorio.SelectedIndex == 3)
            {
                groupBox_cidade.Enabled = false;
                groupBox_idade.Enabled = false;
                groupBox_sexo.Enabled = true;
                groupBox_status.Enabled = false;
                group_box_cargo.Enabled = false;

            }

            //Cidade
            if (combo_tipo_relatorio.SelectedIndex == 4)
            {

                groupBox_cidade.Enabled = true;
                groupBox_idade.Enabled = false;
                groupBox_sexo.Enabled = false;
                groupBox_status.Enabled = false;
                group_box_cargo.Enabled = false;


            }
            //Status
            if (combo_tipo_relatorio.SelectedIndex == 5)
            {
                groupBox_cidade.Enabled = false;
                groupBox_idade.Enabled = false;
                groupBox_sexo.Enabled = false;
                groupBox_status.Enabled = true;
                group_box_cargo.Enabled = false;

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

        private void box_inicio_KeyPress(object sender, KeyPressEventArgs e)
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

        private void box_final_KeyPress(object sender, KeyPressEventArgs e)
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
            MessageBox.Show("Esta é a tela de Relatório de Funcionario, um local onde será gerado todos os Relatórios", "Sistema Papelaria Humanas", MessageBoxButtons.OK);
        }
    }
}
