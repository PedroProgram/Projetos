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
    public partial class RelatorioFornecedor : Form
    {
        public RelatorioFornecedor()
        {
            InitializeComponent();
        }

        private void limpar()
        {
            mask_data.Clear();
            Mask_Cnpj.Clear();
            Mask_Telefone.Clear();
            combo_cidade.SelectedIndex = -1;
            combo_datacad_mes.SelectedIndex = -1;


        }

        private void limparReport()
        {
            reportViewer1.Clear();


        }
        private void bt_pesquisar_Click(object sender, EventArgs e)
        {
            this.limparReport();


            ClassFornecedor cFornecedor = new ClassFornecedor();

            string relatorio = combo_tipo_relatorio.SelectedItem.ToString();

            switch (relatorio)
            {

                //MÊS
                case "data cadastro por mês":
                    if (combo_datacad_mes.SelectedIndex != 0)
                    {
                        ClassFornecedorBindingSource.DataSource = cFornecedor.RelatorioFornecedorCadastroMes(combo_datacad_mes.SelectedIndex.ToString());

                        this.reportViewer1.RefreshReport();
                        this.limpar();

                    }  
                    else
                    {
                        MessageBox.Show("Favor Selecionar um Mês ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;

                //DATA
                case "data":
                    if (mask_data.Text != "  /  /")
                    {
                        ClassFornecedorBindingSource.DataSource = cFornecedor.RelatorioFornecedorData(Convert.ToDateTime(mask_data.Text));

                        this.reportViewer1.RefreshReport();
                        this.limpar();
                    }
                    else
                    {
                        MessageBox.Show("Favor Informar Uma Data Cadastrada", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;

                //telefone
                case "telefone":
                    if (Mask_Telefone.Text != "(  )-     -")
                    {
                        ClassFornecedorBindingSource.DataSource = cFornecedor.RelatorioFornecedorTelefone(Mask_Telefone.Text);


                        this.reportViewer1.RefreshReport();
                        this.limpar();

                    }
                    else
                    {
                        MessageBox.Show("Favor informar um Telefone Cadastrado", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                    }
                    break;

                //status
                case "status":

                    if (radio_ativo.Checked == true)
                    {
                        ClassFornecedorBindingSource.DataSource = cFornecedor.RelatoriofornecedorStatus(1);

                        this.reportViewer1.RefreshReport();
                        this.limpar();
                    }
                    else
                    {
                        ClassFornecedorBindingSource.DataSource = cFornecedor.RelatoriofornecedorStatus(0);
                    }
                    break;

                //cnpj

                case "cnpj":
                    if (Mask_Cnpj.Text != "  ,   ,   /    -")
                    {
                        ClassFornecedorBindingSource.DataSource = cFornecedor.RelatorioFornecedorCNPJ(Mask_Cnpj.Text);

                        this.reportViewer1.RefreshReport();
                        this.limpar();
                    }
                    else
                    {
                        MessageBox.Show("Favor Informar um CNPJ Cadastrado", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;

                //cidade

                case "cidade":
                    if (combo_cidade.SelectedIndex != -1)
                    {
                        ClassFornecedorBindingSource.DataSource = cFornecedor.RelatorioFornecedorCidade(combo_cidade.SelectedValue.ToString());

                        this.reportViewer1.RefreshReport();
                        this.limpar();

                    }
                    else
                    {
                        MessageBox.Show("Favor Selecionar Uma Cidade Cadastrada ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;
            }
                    

        }

        private void RelatorioFornecedor_Load_1(object sender, EventArgs e)
        {
            //CARREGAR COM DE OPÇÕES DE PESQUISA
            combo_tipo_relatorio.Items.Add("Selecione Uma Opção");
            combo_tipo_relatorio.Items.Add("data cadastro por mês");
            combo_tipo_relatorio.Items.Add("data");
            combo_tipo_relatorio.Items.Add("telefone");
            combo_tipo_relatorio.Items.Add("status");
            combo_tipo_relatorio.Items.Add("cnpj");
            combo_tipo_relatorio.Items.Add("cidade");

            combo_tipo_relatorio.SelectedIndex = 0 ;
            //CARREGAR COMBO CIDADE


            ClassFornecedor cFornecedor = new ClassFornecedor();
            combo_cidade.DataSource = cFornecedor.BuscarCidade(); // EXECUTA METODO CRIADO NA CLASSE MARCA           
            combo_cidade.DisplayMember = "cidade"; //EXIBIR NA COMBO (NOME DO FORNECEDOR)
            combo_cidade.ValueMember = "cidade"; // GUARDAR NO BD (CODIGO DO FORNECEDOR)
            combo_cidade.SelectedIndex = -1; // LIMPAR A COMBO (NÃO SELECIONAR NADA - QUANDO ABRIR O FORM)


            //CARREGAR COMBO MÊS

            combo_datacad_mes.Items.Add("Selecione Um Mês");
            combo_datacad_mes.Items.Add("JANEIRO");
            combo_datacad_mes.Items.Add("FEVERREIRO");
            combo_datacad_mes.Items.Add("MARÇO");
            combo_datacad_mes.Items.Add("ABRIL");
            combo_datacad_mes.Items.Add("MAIO");
            combo_datacad_mes.Items.Add("JUNHO");
            combo_datacad_mes.Items.Add("JULHO");
            combo_datacad_mes.Items.Add("AGOSTO");
            combo_datacad_mes.Items.Add("SETEMBRO");
            combo_datacad_mes.Items.Add("OUTUBRO");
            combo_datacad_mes.Items.Add("NOVEMBRO");
            combo_datacad_mes.Items.Add("DEZEMBRO");

            combo_datacad_mes.SelectedItem = "Selecione Um Mês";


            //DEIXAR UMA OPÇÃO DE RADIOBUTTON SELECIONADA
            radio_ativo.Checked = true;

        }

        private void bt_Sair_Click(object sender, EventArgs e)
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

        private void combo_opcoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_tipo_relatorio.SelectedIndex == 0)
            {
                group_telefone.Enabled = false;
               group_status.Enabled = false;
                group_cnpj.Enabled = false;
                group_cidade.Enabled = false;
                group_mes.Enabled = false;
                group_data.Enabled = false;

            }

            if (combo_tipo_relatorio.SelectedIndex == 1)
            {
                group_telefone.Enabled = false;
                group_status.Enabled = false;
                group_cnpj.Enabled = false;
                group_cidade.Enabled = false;
                group_mes.Enabled = true;
                group_data.Enabled = false;

            }

            if (combo_tipo_relatorio.SelectedIndex == 2)
            {
                group_telefone.Enabled = false;
                group_status.Enabled = false;
                group_cnpj.Enabled = false;
                group_cidade.Enabled = false;
                group_mes.Enabled = false;
                group_data.Enabled = true;

            }

            if (combo_tipo_relatorio.SelectedIndex == 3)
            {
                group_telefone.Enabled = true;
                group_status.Enabled = false;
                group_cnpj.Enabled = false;
                group_cidade.Enabled = false;
                group_mes.Enabled = false;
                group_data.Enabled = false;

            }


            if (combo_tipo_relatorio.SelectedIndex == 4)
            {
                group_telefone.Enabled = false;
                group_status.Enabled = true;
                group_cnpj.Enabled = false;
                group_cidade.Enabled = false;
                group_mes.Enabled = false;
                group_data.Enabled = false;

            }

            if (combo_tipo_relatorio.SelectedIndex == 5)
            {
                group_telefone.Enabled = false;
                group_status.Enabled = false;
                group_cnpj.Enabled = true;
                group_cidade.Enabled = false;
                group_mes.Enabled = false;
                group_data.Enabled = false;

            }

            if (combo_tipo_relatorio.SelectedIndex == 6)
            {
                group_telefone.Enabled = false;
                group_status.Enabled = false;
                group_cnpj.Enabled = false;
                group_cidade.Enabled = true;
                group_mes.Enabled = false;
                group_data.Enabled = false;

            }

        }

        private void bt_ajuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta é a tela de Relatório de Fornecedor, um local onde será gerado todos os Relatórios", "Sistema Papelaria Humanas", MessageBoxButtons.OK);
        }

        private void masked_data_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                MessageBox.Show("Data Inválida", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mask_data.Focus();
                mask_data.Text = "";

            }
        }
    } 


}
