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
    public partial class RelatorioProduto : Form
    {
        public RelatorioProduto()
        {
            InitializeComponent();
        }

        private void limpar()
        {
            mask_data.Clear();
            Box_preco.Clear();
            Box_quantidade.Clear();
            combo_datacad_mes.SelectedIndex = -1;


        }

        private void limparReport()
        {
            reportViewer1.Clear();


        }

        private void RelatorioProduto_Load(object sender, EventArgs e)
        {
            {
                //CARREGAR COM DE OPÇÕES DE PESQUISA
                combo_tipo_relatorio.Items.Add("Selecione Uma Opção");
                combo_tipo_relatorio.Items.Add("quantidade");
                combo_tipo_relatorio.Items.Add("status");
                combo_tipo_relatorio.Items.Add("preço");
                combo_tipo_relatorio.Items.Add("data cadastro por mês");
                combo_tipo_relatorio.Items.Add("data");
                combo_tipo_relatorio.SelectedIndex = 0;
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

                //DEIXAR UMA OPÇÃO DE RADIOBUTTON SELECIONADO
                radio_ativo.Checked = true;

            }
        }

        private void bt_gerar_relatorio_Click(object sender, EventArgs e)
        {
            this.limparReport();


            ClassProduto cProduto = new ClassProduto();

            string relatorio = combo_tipo_relatorio.SelectedItem.ToString();

            switch (relatorio)
            {

                //MÊS
                case "data cadastro por mês":
                    if (combo_datacad_mes.SelectedIndex != 0)
                    {
                        ClassProdutoBindingSource.DataSource = cProduto.RelatorioProdutoCadastroMes(combo_datacad_mes.SelectedIndex.ToString());

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
                        ClassProdutoBindingSource.DataSource = cProduto.RelatorioProdutoData(Convert.ToDateTime(mask_data.Text));

                        this.reportViewer1.RefreshReport();
                        this.limpar();
                    }
                    else
                    {
                        MessageBox.Show("Favor Informar Uma Data Cadastrada", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;

                //status
                case "status":

                    if (radio_ativo.Checked == true)
                    {
                        ClassProdutoBindingSource.DataSource = cProduto.RelatorioProdutoStatus(1);

                        this.reportViewer1.RefreshReport();
                        this.limpar();
                    }
                    else
                    {
                        ClassProdutoBindingSource.DataSource = cProduto.RelatorioProdutoStatus(0);
                        this.reportViewer1.RefreshReport();
                        this.limpar();
                    }
                    break;

                //PRECO
                case "preço":

                    if (Box_preco.Text != "")
                    {
                        ClassProdutoBindingSource.DataSource = cProduto.RelatorioProdutoPreco(Convert.ToString(Box_preco.Text));

                        this.reportViewer1.RefreshReport();
                        this.limpar();
                    }
                    else
                    {
                        MessageBox.Show("Favor Informar Um Valor Valido", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;

                //QUANTIDADE
                case "quantidade":

                    if (Box_quantidade.Text != "")
                    {
                        ClassProdutoBindingSource.DataSource = cProduto.RelatorioProdutoQuantidade(Convert.ToString(Box_quantidade.Text));

                        this.reportViewer1.RefreshReport();
                        this.limpar();
                    }
                    else
                    {
                        MessageBox.Show("Favor Informar Uma Quantidade Valido", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;
            }
                
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
                group_quantidade.Enabled = false;
                group_status.Enabled = false;
                group_preco.Enabled = false;
                group_mes.Enabled = false;
                group_data.Enabled = false;

            }

            if (combo_tipo_relatorio.SelectedIndex == 1)
            {
                group_quantidade.Enabled = true;
                group_status.Enabled = false;
                group_preco.Enabled = false;
                group_mes.Enabled = false;
                group_data.Enabled = false;

            }

            if (combo_tipo_relatorio.SelectedIndex == 2)
            {
                group_quantidade.Enabled = false;
                group_status.Enabled = true;
                group_preco.Enabled = false;
                group_mes.Enabled = false;
                group_data.Enabled = false;

            }

            if (combo_tipo_relatorio.SelectedIndex == 3)
            {
                group_quantidade.Enabled = false;
                group_status.Enabled = false;
                group_preco.Enabled = true;
                group_mes.Enabled = false;
                group_data.Enabled = false;

            }

            if (combo_tipo_relatorio.SelectedIndex == 4)
            {
                group_quantidade.Enabled = false;
                group_status.Enabled = false;
                group_preco.Enabled = false;
                group_mes.Enabled = true;
                group_data.Enabled = false;

            }

            if (combo_tipo_relatorio.SelectedIndex == 5)
            {
                group_quantidade.Enabled = false;
                group_status.Enabled = false;
                group_preco.Enabled = false;
                group_mes.Enabled = false;
                group_data.Enabled = true;

            }






        }

        private void Box_preco_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número, backspace(08), enter(13) e espaço(32)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 32 && e.KeyChar != ',')
            {    //see o usuário pressionar uma tecla não numérica no textbox, cancela o evento key press

                e.Handled = true;
                MessageBox.Show("Este Campo Aceita Apenas Números E Vírgulas", "Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {

            }
        }

        private void Box_quantidade_KeyPress(object sender, KeyPressEventArgs e)
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
            MessageBox.Show("Esta é a tela de Relatório de Produto, um local onde será gerado todos os Relatórios", "Sistema Papelaria Humanas", MessageBoxButtons.OK);
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
