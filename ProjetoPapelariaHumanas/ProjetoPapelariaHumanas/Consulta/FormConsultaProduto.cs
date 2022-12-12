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
    public partial class FormConsultaProduto : Form
    {
        public FormConsultaProduto()
        {
            InitializeComponent();
        }

        private void bt_pesquisar_Click(object sender, EventArgs e)
        {
            //Instaciar a classe cliente para usar os métodos de consulta

            ClassProduto cProduto = new ClassProduto();

            //criar uma varíavel para receber a opção escolhida pelo usuário na combo

            string CONSULTA = combo_pesquisa_produto.SelectedItem.ToString();

            switch (CONSULTA)
            {
                //TIPO DE PESQUISA(NOME)
                case "nome":

                    if (box_nome.Text != "")
                    {
                        if (radio_inicio.Checked == true)
                        {
                            dataGridView_pesquisa_produto.DataSource = cProduto.ConsultarProdutoNomeInicio(box_nome.Text);

                        }
                        else
                        {
                            dataGridView_pesquisa_produto.DataSource = cProduto.ConsultarProdutoNomeContem(box_nome.Text);

                        }

                    }
                    else
                    {
                        MessageBox.Show("Favor informar um nome", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    break;

                //TIPO DE PESQUISA(quantidade)
                case "quantidade":
                    if (box_quantidade.Text != "")
                    {
                        dataGridView_pesquisa_produto.DataSource = cProduto.ConsultarProdutoQuantidade(box_quantidade.Text);

                    }
                    else
                    {
                        MessageBox.Show("Favor Informar Uma Quantidade Valida", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                    }
                    break;

                //TIPO DE PESQUISA(status)
                case "status":

                    if (radio_ativo.Checked == true)
                    {
                        dataGridView_pesquisa_produto.DataSource = cProduto.ConsultarProdutoStatus(1);
                    }
                    else
                    {
                        dataGridView_pesquisa_produto.DataSource = cProduto.ConsultarProdutoStatus(0);
                    }
                    break;

                //TIPO DE PESQUISA(preço)
                case "preço":
                    if (box_preco.Text != "")
                    {
                        dataGridView_pesquisa_produto.DataSource = cProduto.ConsultarProdutoPreco(box_preco.Text);
                    }
                    else
                    {
                        MessageBox.Show("Favor Informar Um Preço Valido", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;

                //TIPO DE PESQUISA(Data)
                case "data":
                    if (masked_data.Text != "  /  /")
                    {
                        dataGridView_pesquisa_produto.DataSource = cProduto.ConsultarProdutoData(Convert.ToDateTime(masked_data.Text));
                    }
                    else
                    {
                        MessageBox.Show("Favor Informar Uma Data Valida", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;

            }

        }

        private void FormConsultaProduto_Load(object sender, EventArgs e)
        {
            //CARREGAR COMBO FORNECEDOR
            ClassProduto cFornecedor = new ClassProduto();

            combo_pesquisa_produto.Items.Add("Selecione uma Opção");
            combo_pesquisa_produto.Items.Add("nome");
            combo_pesquisa_produto.Items.Add("status");
            combo_pesquisa_produto.Items.Add("quantidade");
            combo_pesquisa_produto.Items.Add("data");
            combo_pesquisa_produto.Items.Add("preço");

            //DEIXAR UMA OPÇÃO SELECIONADA
            combo_pesquisa_produto.SelectedItem = "Selecione uma Opção";

            //DEIXAR CHECADO OS RADIOBUTTONS
            radio_inicio.Checked = true;
            radio_ativo.Checked = true;

        }

        private void dataGridView_pesquisa_produto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_pesquisa_produto.Rows.Count > 0)
            {
                //CLICAR NA GRID DE CLIENTES E EDITAR OU EXCLUIR UM CLIENTE
                //USAR O EVENTO CLLCLICK (PODE CLICAR EM QUALQUER LUGAR DA CÉLULA, NÃO SOMENTE NO TEXTO)
                //USAR O EVENTO CLLCONTENT (TEM QUE CLICAR NO CONTEÚDO (TEXTO))

                //INSTANCIAR A CLASSE CLIENTE PARA USAR MÉTODOS E PROPRIEDADES
                ClassProduto cProduto = new ClassProduto();

                //INSTANCIAR O FORMULÁRIO DE CADASTRO / ATUALIZAÇÃO DE CLIENTE PARA USAR OS CONTROLES DO FORM
                FormProduto fProduto = new FormProduto();

                if (MessageBox.Show("Deseja Alterar O Produto Selecionado ?", "Sistema Papelaria Humanas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes && cProduto.BuscarProduto(Convert.ToInt32(dataGridView_pesquisa_produto.SelectedRows[0].Cells[0].Value != null)))
                {


                    //PEGAR O CÓDIGO DO CLIENTE SELECIONADO PELO USUÁRIO NA GRID
                    cProduto.BuscarProduto(Convert.ToInt32(dataGridView_pesquisa_produto.SelectedRows[0].Cells[0].Value));


                    //PASSAR OS DADOS DO BD PARA OS CONTROLES DO FORM DE CLIENTES
                    fProduto.Box_Cod_Produto.Text = cProduto.Codigo_Produto.ToString();
                    fProduto.datacad = cProduto.Data_Cadastro; //PASSAR A VARIÁVEL GLOBAL CRIADA NO FORM DE CADASTRO DE CLIENTES
                    fProduto.Box_Nome.Text = cProduto.Nome.ToString();
                    fProduto.Box_Quantidade.Text = cProduto.Quantidade.ToString();
                    fProduto.Box_Preco.Text = cProduto.Preco_Produto.ToString();
                    fProduto.Cb_Cod_Categoria.Text = Convert.ToString(cProduto.Codigo_Categoria);
                    fProduto.Cb_Cod_Marca.Text = Convert.ToString(cProduto.Codigo_Marca);
                    fProduto.Cb_Cod_Fornecedor.Text = Convert.ToString(cProduto.Codigo_Fornecedor);


                    // Status
                    if (cProduto.status == 1)
                    {

                        fProduto.Check_Status.Checked = true;


                    }

                    else
                    {


                        fProduto.Check_Status.Checked = false;
                    }

                    //MANDAR A INFORMAÇÃO DE UPDATE
                    fProduto.tipo = "Atualização";
                    //ABRIR O FORMULÁRIO DE CADASTRO EM MODO EXCLUSIVO
                    fProduto.ShowDialog();
                    //CHAMAR O MÉTODO DE PESQUISA
                    bt_pesquisar_Click(this, new EventArgs());



                }
                else
                {
                    MessageBox.Show("Por Favor Selecionar Um Produto Existente", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }


        }

        private void bt_sair_Click(object sender, EventArgs e)
        {
            if (combo_pesquisa_produto.SelectedIndex > 0)
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

        private void combo_pesquisa_produto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_pesquisa_produto.SelectedIndex == 0)
            {
                box_nome.Enabled = false;
                group_tipo_pesquisa.Enabled = false;
                group_status.Enabled = false;
                group_quatidade.Enabled = false;
                group_preco.Enabled = false;
                group_data.Enabled = false;

            }
            if (combo_pesquisa_produto.SelectedIndex == 1)
            {
                box_nome.Enabled = true;
                group_tipo_pesquisa.Enabled = true;
                group_status.Enabled = false;
                group_quatidade.Enabled = false;
                group_preco.Enabled = false;
                group_data.Enabled = false;
            }
            if (combo_pesquisa_produto.SelectedIndex == 2)
            {
                box_nome.Enabled = false;
                group_tipo_pesquisa.Enabled = false;
                group_status.Enabled = true;
                group_quatidade.Enabled = false;
                group_preco.Enabled = false;
                group_data.Enabled = false;
            }
            if (combo_pesquisa_produto.SelectedIndex == 3)
            {
                box_nome.Enabled = false;
                group_tipo_pesquisa.Enabled = false;
                group_status.Enabled = false;
                group_quatidade.Enabled = true;
                group_preco.Enabled = false;
                group_data.Enabled = false;
            }
            if (combo_pesquisa_produto.SelectedIndex == 4)
            {
                box_nome.Enabled = false;
                group_tipo_pesquisa.Enabled = false;
                group_status.Enabled = false;
                group_quatidade.Enabled = false;
                group_preco.Enabled = false;
                group_data.Enabled = true;
            }
            if (combo_pesquisa_produto.SelectedIndex == 5)
            {
                box_nome.Enabled = false;
                group_tipo_pesquisa.Enabled = false;
                group_status.Enabled = false;
                group_quatidade.Enabled = false;
                group_preco.Enabled = true;
                group_data.Enabled = false;
            }
        }

        private void box_preco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 32 && e.KeyChar != ',')
            {    //see o usuário pressionar uma tecla não numérica no textbox, cancela o evento key press

                e.Handled = true;
                MessageBox.Show("Este Campo Aceita Apenas Números E Vírgulas", "Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {

            }
        }

        private void box_quantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
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
            MessageBox.Show("Esta é a tela de Consulta de Produto, um local onde será consultado todos os Produtos", "Sistema Papelaria Humanas", MessageBoxButtons.OK);
        }

        private void masked_data_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                MessageBox.Show("Data Inválida", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                masked_data.Focus();
                masked_data.Text = "";

            }
        }
    }
}
