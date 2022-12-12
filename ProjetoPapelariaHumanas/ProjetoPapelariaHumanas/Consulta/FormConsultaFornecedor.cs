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
    public partial class FormConsultaFornecedor : Form
    {
        public FormConsultaFornecedor()
        {
            InitializeComponent();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            //Instaciar a classe cliente para usar os métodos de consulta

            ClassFornecedor cFornecedor = new ClassFornecedor();

            //criar uma varíavel para receber a opção escolhida pelo usuário na combo

            string CONSULTA = combo_pesquisa_fornecedor.SelectedItem.ToString();

            switch (CONSULTA)
            {      
                //TIPO DE PESQUISA(NOME)
                    case "nome":

                if(box_nome.Text != "")
                {
                   if(radio_inicio.Checked == true)
                   {
                            dataGridView_pesquisa_fornecedor.DataSource = cFornecedor.ConsultarFornecedorNomeInicio(box_nome.Text);

                   }
                   else
                   {
                            dataGridView_pesquisa_fornecedor.DataSource = cFornecedor.ConsultarFornecedorNomeContem(box_nome.Text);


                   }


                }
                else
                {
                        MessageBox.Show("Favor informar um nome", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                    break;

                //TIPO DE PESQUISA(telefone)
                    case "telefone":
                if(Mask_Telefone.Text != "(  )-     -")
                {
                        dataGridView_pesquisa_fornecedor.DataSource = cFornecedor.ConsultarFornecedorTelefone(Mask_Telefone.Text);

                }
                else
                {
                        MessageBox.Show("Favor informar um Telefone Valido", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                }
                    break;

                    //TIPO DE PESQUISA(status)
                    case "status":

                if(radio_ativo.Checked == true)
                {
                        dataGridView_pesquisa_fornecedor.DataSource = cFornecedor.ConsultarFornecedorStatus(1);
                }
                else
                {
                        dataGridView_pesquisa_fornecedor.DataSource = cFornecedor.ConsultarFornecedorStatus(0);   
                }
                    break;

                    //TIPO DE PESQUISA(cnpj)
                    case "cnpj":
                if(Mask_Cnpj.Text != "  ,   ,   /    -")
                {
                        dataGridView_pesquisa_fornecedor.DataSource = cFornecedor.ConsultarFornecedorCNPJ(Mask_Cnpj.Text);
                }
                else
                {
                        MessageBox.Show("Favor Informar um CNPJ valido", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                    break;
                 
            }
            
        }

        private void FormConsultaFornecedor_Load(object sender, EventArgs e)
        {
            //CARREGAR COMBO FORNECEDOR
            ClassFornecedor cFornecedor = new ClassFornecedor();
            
            combo_pesquisa_fornecedor.Items.Add("selecione uma opção");
            combo_pesquisa_fornecedor.Items.Add("nome");
            combo_pesquisa_fornecedor.Items.Add("telefone");
            combo_pesquisa_fornecedor.Items.Add("status");
            combo_pesquisa_fornecedor.Items.Add("cnpj");

            //DEIXAR UMA OPÇÃO SELECIONADA
            combo_pesquisa_fornecedor.SelectedItem = "selecione uma opção";

            //DEIXAR CHECADO OS RADIOBUTTONS
            radio_inicio.Checked = true;
            radio_ativo.Checked = true;

        }

        private void dataGridView_pesquisa_fornecedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_pesquisa_fornecedor.Rows.Count > 0)
            {
                //CLICAR NA GRID DE CLIENTES E EDITAR OU EXCLUIR UM CLIENTE
                //USAR O EVENTO CLLCLICK (PODE CLICAR EM QUALQUER LUGAR DA CÉLULA, NÃO SOMENTE NO TEXTO)
                //USAR O EVENTO CLLCONTENT (TEM QUE CLICAR NO CONTEÚDO (TEXTO))

                //INSTANCIAR A CLASSE CLIENTE PARA USAR MÉTODOS E PROPRIEDADES
                ClassFornecedor cFornecedor = new ClassFornecedor();

                //INSTANCIAR O FORMULÁRIO DE CADASTRO / ATUALIZAÇÃO PARA USAR OS CONTROLES DO FORM
                FormFornecedor fFornecedor = new FormFornecedor();

                if (MessageBox.Show("Deseja alterar o Fornecedor selecionado?", "Sistema Papelaria Humanas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes && cFornecedor.BuscarFornecedor(Convert.ToInt32(dataGridView_pesquisa_fornecedor.SelectedRows[0].Cells[0].Value != null)))
                {

                    //PEGAR O CÓDIGO SELECIONADO PELO USUÁRIO NA GRID
                    cFornecedor.BuscarFornecedor(Convert.ToInt32(dataGridView_pesquisa_fornecedor.SelectedRows[0].Cells[0].Value));


                    //PASSAR OS DADOS DO BD PARA OS CONTROLES DO FORM
                    fFornecedor.Box_Cod_Fornecedor.Text = cFornecedor.codigo_fornecedor.ToString();
                    fFornecedor.datacad = cFornecedor.data_cadastro_fornecedor; //PASSAR A VARIÁVEL GLOBAL CRIADA NO FORM DE CADASTRO DE CLIENTES
                    fFornecedor.Box_Nome.Text = cFornecedor.nome.ToString();
                    fFornecedor.Mask_Cnpj.Text = cFornecedor.cnpj.ToString();
                    fFornecedor.Mask_Telefone.Text = cFornecedor.telefone.ToString();
                    fFornecedor.Box_Rua.Text = cFornecedor.rua.ToString();
                    fFornecedor.Box_Bairro.Text = cFornecedor.bairro.ToString();
                    fFornecedor.Box_Cidade.Text = cFornecedor.cidade.ToString();
                    fFornecedor.Mask_Cep.Text = cFornecedor.cep.ToString();


                    if (cFornecedor.status == 1)
                    {

                        fFornecedor.Check_Ativo.Checked = true;


                    }

                    else
                    {


                        fFornecedor.Check_Ativo.Checked = false;
                    }

                    //MANDAR A INFORMAÇÃO DE UPDATE
                    fFornecedor.tipo = "Atualização";
                    //ABRIR O FORMULÁRIO DE CADASTRO EM MODO EXCLUSIVO
                    fFornecedor.ShowDialog();
                    //CHAMAR O MÉTODO DE PESQUISA
                    button1_Click(this, new EventArgs());



                }
                else
                {
                    MessageBox.Show("Por Favor Seleciona Um(a) Fornecedor(a) Existente", "Sistema papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (combo_pesquisa_fornecedor.SelectedIndex > 0)
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

        private void combo_pesquisa_fornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_pesquisa_fornecedor.SelectedIndex == 0)
            {
                box_nome.Enabled = false;
                group_tipo_pesquisa.Enabled = false;
                group_telefone.Enabled = false;
                group_cnpj.Enabled = false;
                group_status.Enabled = false;
               
            }
            if (combo_pesquisa_fornecedor.SelectedIndex == 1)
            {                
                box_nome.Enabled = true;
                radio_inicio.Checked = true;
                group_tipo_pesquisa.Enabled = true;
                group_telefone.Enabled = false;
                group_cnpj.Enabled = false;
                group_status.Enabled = false;
            }
            if (combo_pesquisa_fornecedor.SelectedIndex == 2)
            {
                box_nome.Enabled = false;
                group_tipo_pesquisa.Enabled = false;
                group_telefone.Enabled = true;
                group_cnpj.Enabled = false;
                group_status.Enabled = false;
            }
            if (combo_pesquisa_fornecedor.SelectedIndex == 3)
            {
                box_nome.Enabled = false;
                group_tipo_pesquisa.Enabled = false;
                group_telefone.Enabled = false;
                group_cnpj.Enabled = false;
                group_status.Enabled = true;
            }
            if (combo_pesquisa_fornecedor.SelectedIndex == 4)
            {
                box_nome.Enabled = false;
                group_tipo_pesquisa.Enabled = false;
                group_telefone.Enabled = false;
                group_cnpj.Enabled = true;
                group_status.Enabled = false;
            }
        }

        private void bt_ajuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta é a tela de Consulta de Fornecedor, um local onde será consultado todos os Fornecedores", "Sistema Papelaria Humanas", MessageBoxButtons.OK);
        }
    }
}
