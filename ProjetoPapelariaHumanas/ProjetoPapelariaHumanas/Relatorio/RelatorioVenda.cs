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
    public partial class FormRelVenda : Form
    {
        public FormRelVenda()
        {
            InitializeComponent();
        }

        private void FormRelVenda_Load(object sender, EventArgs e)
        {
            comboBox_opcoes.Items.Add("Selecione uma Opção");
            comboBox_opcoes.Items.Add("Data da Venda");
            comboBox_opcoes.Items.Add("Cliente");
            comboBox_opcoes.Items.Add("Funcionário");


            comboBox_opcoes.SelectedIndex = 0;


            //CARRREGAR COMBO FUNCIONARIO
            ClassFuncionario cFuncionario = new ClassFuncionario();
            comboBox_funcionario.DataSource = cFuncionario.BuscarFuncionario();//executar método criado na classe categoria
            comboBox_funcionario.DisplayMember = "nome";//exibir na combo (nome)
            comboBox_funcionario.ValueMember = "codigo_Funcionario"; //guardar no BD (código)
            comboBox_funcionario.SelectedIndex = -1; //Limpar a combo (não seleciona nada - quando abrir o form

            //CARREGAR COMBO CLIENTE
            //CARRREGAR COMBO cliente
            ClassCliente ccli = new ClassCliente();
            combo_cli.DataSource = ccli.BuscarCliente();//executar método criado na classe categoria
            combo_cli.DisplayMember = "nome";//exibir na combo (nome)
            combo_cli.ValueMember = "codigo_cliente"; //guardar no BD (código)
            combo_cli.SelectedIndex = -1; //Limpar a combo (não seleciona nada - quando abrir o form


           
        }

        private void comboBox_opcoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Opção
            if (comboBox_opcoes.SelectedIndex == 0)
            {
                groupBox_cliente.Enabled = false;
                groupBox_fun.Enabled = false;
                groupBox_data.Enabled = false;


            }
            //Data
            if (comboBox_opcoes.SelectedIndex == 1)
            {
                groupBox_cliente.Enabled = false;
                groupBox_fun.Enabled = false;
                groupBox_data.Enabled = true;

            }
            //Cliente
            if (comboBox_opcoes.SelectedIndex == 2)
            {
                groupBox_cliente.Enabled = true;
                groupBox_fun.Enabled = false;
                groupBox_data.Enabled = false;

            }
            //Funcionário
            if (comboBox_opcoes.SelectedIndex == 3)
            {
                groupBox_cliente.Enabled = false;
                groupBox_fun.Enabled = true;
                groupBox_data.Enabled = false;


            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassRelVenda Rvenda = new ClassRelVenda();

            string relatorio = comboBox_opcoes.SelectedItem.ToString();

            switch (relatorio)
            //MÊS
            {
                case "Data da Venda":
                    if (comboBox_opcoes.SelectedIndex != 0)
                    {
                        ClassRelVendaBindingSource.DataSource = Rvenda.RelatorioVenda(Convert.ToDateTime(dateTimePicker_data1.Text), Convert.ToDateTime(dateTimePicker_data2.Text));
                        this.reportview1.RefreshReport();


                     }
                    else
                    {
                        MessageBox.Show("Favor Selecionar uma Data ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                       
                    }
                    break;

                //Cliente
                case "Cliente":
                    if(comboBox_opcoes.SelectedIndex != -1)
                    {
                        ClassRelVendaBindingSource.DataSource = Rvenda.RelatorioVendaCli(Convert.ToInt32(combo_cli.SelectedValue));
                        this.reportview1.RefreshReport();

                    }
                    else
                    {
                        MessageBox.Show("Favor Selecionar um Cliente ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    break;
                //Cliente
                case "Funcionário":
                    if (comboBox_opcoes.SelectedIndex != -1)
                    {
                        ClassRelVendaBindingSource.DataSource = Rvenda.RelatorioVendaFun(Convert.ToInt32(comboBox_funcionario.SelectedValue));
                        this.reportview1.RefreshReport();

                    }
                    else
                    {
                        MessageBox.Show("Favor Selecionar um Funcionário ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    break;
            }
        }

        private void bt_Sair_Click(object sender, EventArgs e)
        {
            if (comboBox_opcoes.SelectedIndex > 0)
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

        private void bt_ajuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta é a tela de Relatório de Venda, um local onde será gerado todos os relatórios De venda", "Sistema Papelaria Humanas", MessageBoxButtons.OK);
        }
    }
}
