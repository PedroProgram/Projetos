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
    public partial class FormConsultaCliente : Form
    {
        public FormConsultaCliente()
        {
            InitializeComponent();
        }

        private void combo_consulta_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ATIVAR E DESATIVAR OS ELEMENTOS DO FORM CONFROME A ESCOLHA DO USUÁRIO

            //Opção
            if (combo_pesquisa_cliente.SelectedIndex == 0)
            {
                box_nome.Enabled = false;
                groupBox_pesquisanome.Enabled = false;
                groupBox_sexo.Enabled = false;
                groupBox_status.Enabled = false;
                groupBox_cpf.Enabled = false;
                groupBox_rg.Enabled = false;




            }
            //CPF
            if (combo_pesquisa_cliente.SelectedIndex == 1)
            {
                box_nome.Enabled = false;
                groupBox_pesquisanome.Enabled = false;
                groupBox_sexo.Enabled = false;
                groupBox_status.Enabled = false;
                groupBox_cpf.Enabled = true;
                groupBox_rg.Enabled = false;



            }
            //Nome
            if (combo_pesquisa_cliente.SelectedIndex == 2)
            {
                box_nome.Enabled = true;
                groupBox_pesquisanome.Enabled = true;
                groupBox_sexo.Enabled = false;
                groupBox_status.Enabled = false;
                groupBox_cpf.Enabled = false;
                groupBox_rg.Enabled = false;



            }
            //Sexo
            if (combo_pesquisa_cliente.SelectedIndex == 3)
            {
                box_nome.Enabled = false;
                groupBox_pesquisanome.Enabled = false;
                groupBox_sexo.Enabled = true;
                groupBox_status.Enabled = false;
                groupBox_cpf.Enabled = false;
                groupBox_rg.Enabled = false;

            }
            //Status
            if (combo_pesquisa_cliente.SelectedIndex == 4)
            {
                box_nome.Enabled = false;
                groupBox_pesquisanome.Enabled = false;
                groupBox_sexo.Enabled = false;          
                groupBox_status.Enabled = true;
                groupBox_cpf.Enabled = false;
                groupBox_rg.Enabled = false;


            }
            //RG
            if (combo_pesquisa_cliente.SelectedIndex == 5)
            {
                box_nome.Enabled = false;
                groupBox_pesquisanome.Enabled = false;
                groupBox_sexo.Enabled = false;
                groupBox_status.Enabled = false;
                groupBox_cpf.Enabled = false;
                groupBox_rg.Enabled = true;


            }
        }

        private void FormConsultaCliente_Load(object sender, EventArgs e)
        {
            combo_pesquisa_cliente.Items.Add("Selecione Uma Opção");
            combo_pesquisa_cliente.Items.Add("CPF");
            combo_pesquisa_cliente.Items.Add("Nome");
            combo_pesquisa_cliente.Items.Add("Sexo");
            combo_pesquisa_cliente.Items.Add("Status");
            combo_pesquisa_cliente.Items.Add("RG");

            //DEIXAR SELECIONADO UMA OPÇÃO
            combo_pesquisa_cliente.SelectedIndex = 0;

            //DEIXAR CHECADO OS RADIOBUTTONS
            radio_ativo.Checked = true;
            radio_feminino.Checked = true;
            radio_inicio.Checked = true;

        }

        private void bt_pesquisar_Click(object sender, EventArgs e)
        {
            //Instaciar a classe cliente para usar os métodos de consulta

            ClassCliente Ccliente = new ClassCliente();

            //criar uma varíavel para receber a opção escolhida pelo usuário na combo

            string CONSULTA = combo_pesquisa_cliente.SelectedItem.ToString();


            switch (CONSULTA)
            {
                case "Nome":
                    if (box_nome.Text != "")
                    {
                        if (radio_inicio.Checked == true)
                        {
                            dataGridView_cliente.DataSource = Ccliente.ConsultaClienteNomeInicio(box_nome.Text);




                        }

                        else
                        {
                            dataGridView_cliente.DataSource = Ccliente.ConsultaClienteNomeContem(box_nome.Text);

                        }

                    }
                    //Campo nome
                    else
                    {
                        MessageBox.Show("Favor informar um Nome", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;


                //Campo sexo
                case "Sexo":
                    if (radio_feminino.Checked == true)
                    {

                        dataGridView_cliente.DataSource = Ccliente.ConsultaClienteSexo("F");


                    }
                    else
                    {

                        dataGridView_cliente.DataSource = Ccliente.ConsultaClienteSexo("M");

                    }
                    break;
                //CPF
                case "CPF":
                    if (mask_cpf.Text != "   .   .   -")
                    {

                        dataGridView_cliente.DataSource = Ccliente.ConsultaClienteCPF(mask_cpf.Text);



                    }
                    else
                    {
                        MessageBox.Show("Favor informar um CPF", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                    }
                    break;
                //Status
                case "Status":
                    if (radio_ativo.Checked == true)
                    {
                        dataGridView_cliente.DataSource = Ccliente.ConsultaClienteStatus(1);


                    }

                    else
                    {
                        dataGridView_cliente.DataSource = Ccliente.ConsultaClienteStatus(0);


                    }
                    break;

                //RG
                case "RG":
                    if (mask_rg.Text != "  .   .   -")
                    {
                        dataGridView_cliente.DataSource = Ccliente.ConsultaClienteRg(mask_rg.Text);
                    }
                    else
                    {
                        MessageBox.Show("Favor informar um RG", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;
                   
            }
        }
        

        private void bt_sair_Click(object sender, EventArgs e)
        {
            if (combo_pesquisa_cliente.SelectedIndex > 0)
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

        //CLICAR NA GRID DE CLIENTES E EDITAR OU EXCLUIR UM CLIENTE
        //USAR O EVENTO CLLCLICK (PODE CLICAR EM QUALQUER LUGAR DA CÉLULA, NÃO SOMENTE NO TEXTO)
        //USAR O EVENTO CLLCONTENT (TEM QUE CLICAR NO CONTEÚDO (TEXTO))
        private void dataGridView_cliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_cliente.Rows.Count > 0)
            {
                //INSTANCIAR A CLASSE CLIENTE PARA USAR MÉTODOS E PROPRIEDADES
                ClassCliente cCliente = new ClassCliente();

                //INSTANCIAR O FORMULÁRIO DE CADASTRO / ATUALIZAÇÃO DE CLIENTE PARA USAR OS CONTROLES DO FORM
                FormCliente fcliente = new FormCliente();

                if (MessageBox.Show("Deseja alterar o cliente selecionado?", "Sistema Papelaria Humanas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes && cCliente.ConsultarCliente(Convert.ToInt32(dataGridView_cliente.SelectedRows[0].Cells[0].Value != null)))
                {


                    //PEGAR O CÓDIGO DO CLIENTE SELECIONADO PELO USUÁRIO NA GRID
                    cCliente.ConsultarCliente(Convert.ToInt32(dataGridView_cliente.SelectedRows[0].Cells[0].Value));

                    fcliente.estado = cCliente.estado.ToString(); //(COMBO) PASSAR A VARIÁVEL DECLARADA NO FORMULÁRIO DE CLIENTE
                    fcliente.datacad = cCliente.data_cadastro_cliente; //PASSAR A VARIÁVEL GLOBAL CRIADA NO FORM DE CADASTRO DE CLIENTES
                    fcliente.box_cod_cli.Text = cCliente.codigo_cliente.ToString();
                    fcliente.box_nome.Text = cCliente.nome.ToString();
                    fcliente.mask_rg.Text = cCliente.rg.ToString();
                    fcliente.mask_cpf.Text = cCliente.cpf.ToString();
                    fcliente.mask_nascimento.Text = cCliente.data_nascimento.ToString();
                    fcliente.box_rua.Text = cCliente.rua.ToString();
                    fcliente.box_numero.Text = cCliente.numero.ToString();
                    fcliente.box_complemento.Text = cCliente.complemento.ToString();
                    fcliente.box_bairro.Text = cCliente.bairro.ToString();
                    fcliente.box_cidade.Text = cCliente.cidade.ToString();
                    fcliente.estado = cCliente.estado.ToString(); //(COMBO) PASSAR A VARIÁVEL DECLARADA NO FORMULÁRIO DE CLIENTE
                    fcliente.mask_cep.Text = cCliente.cep.ToString();
                    fcliente.box_email.Text = cCliente.email.ToString();
                    fcliente.mask_residencial.Text = cCliente.telefone.ToString();
                    fcliente.mask_celular.Text = cCliente.celular.ToString();


                    if (cCliente.sexo == "F")
                    {
                        fcliente.radio_feminino.Checked = true;


                    }
                    else
                    {
                        fcliente.radio_masculino.Checked = true;



                    }
                    if (cCliente.status == 1)
                    {

                        fcliente.check_ativo.Checked = true;


                    }

                    else
                    {


                        fcliente.check_ativo.Checked = false;
                    }

                    //MANDAR A INFORMAÇÃO DE UPDATE
                    fcliente.tipo = "Atualização";
                    //ABRIR O FORMULÁRIO DE CADASTRO EM MODO EXCLUSIVO
                    fcliente.ShowDialog();
                    //CHAMAR O MÉTODO DE PESQUISA
                    bt_pesquisar_Click(this, new EventArgs());




                }
                else
                {

                    MessageBox.Show("Por Favor Selecionar Um(a) Cliente Existente", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }

        }

        private void bt_ajuda_Click(object sender, EventArgs e)
        {
                       
                MessageBox.Show("Esta é a tela de Consulta de Cliente, um local onde será consultado todos os Clientes", "Sistema Papelaria Humanas", MessageBoxButtons.OK);
                
        }
    }
}  
   
