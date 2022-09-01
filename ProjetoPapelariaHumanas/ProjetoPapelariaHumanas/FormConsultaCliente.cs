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

            //cpf
            if (combo_consulta.SelectedIndex == 0)
            {
                box_nome.Enabled = false;
                groupBox_pesquisanome.Enabled = false;
                groupBox_sexo.Enabled = false;
                groupBox_status.Enabled = false;
                groupBox_cpf.Enabled = true;
                groupBox_rg.Enabled = false;




            }
            //Nome
            if (combo_consulta.SelectedIndex == 1)
            {
                box_nome.Enabled = true;
                groupBox_pesquisanome.Enabled = true;
                groupBox_sexo.Enabled = false;
                groupBox_status.Enabled = false;
                groupBox_cpf.Enabled = false;
                groupBox_rg.Enabled = false;



            }
            //Sexo
            if (combo_consulta.SelectedIndex == 2)
            {
                box_nome.Enabled = false;
                groupBox_pesquisanome.Enabled = false;
                groupBox_sexo.Enabled = true;
                groupBox_status.Enabled = false;
                groupBox_cpf.Enabled = false;
                groupBox_rg.Enabled = false;



            }
            //Status
            if (combo_consulta.SelectedIndex == 3)
            {
                box_nome.Enabled = false;
                groupBox_pesquisanome.Enabled = false;
                groupBox_sexo.Enabled = false;
                groupBox_status.Enabled = true;
                groupBox_cpf.Enabled = false;
                groupBox_rg.Enabled = false;

            }
            //RG
            if (combo_consulta.SelectedIndex == 4)
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
            combo_consulta.Items.Add("CPF");
            combo_consulta.Items.Add("Nome");
            combo_consulta.Items.Add("Sexo");
            combo_consulta.Items.Add("Status");
            combo_consulta.Items.Add("RG");

            //Deixar a opção nome selecionada

            combo_consulta.SelectedItem = "Nome";
        }

        private void bt_pesquisar_Click(object sender, EventArgs e)
        {
            //Instaciar a classe cliente para usar os métodos de consulta

            ClassCliente Ccliente = new ClassCliente();

            //criar uma varíavel para receber a opção escolhida pelo usuário na combo

            string CONSULTA = combo_consulta.SelectedItem.ToString();


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
        //CLICAR NA GRID DE CLIENTES E EDITAR OU EXCLUIR UM CLIENTE
        //USAR O EVENTO CLLCLICK (PODE CLICAR EM QUALQUER LUGAR DA CÉLULA, NÃO SOMENTE NO TEXTO)
        //USAR O EVENTO CLLCONTENT (TEM QUE CLICAR NO CONTEÚDO (TEXTO))
        private void dataGridView_cliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (MessageBox.Show("Deseja alterar o cliente selecionado?", "Sistema Papelaria Humanas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //INSTANCIAR A CLASSE CLIENTE PARA USAR MÉTODOS E PROPRIEDADES
                ClassCliente cCliente = new ClassCliente();

                //INSTANCIAR O FORMULÁRIO DE CADASTRO / ATUALIZAÇÃO DE CLIENTE PARA USAR OS CONTROLES DO FORM
                FormCliente fcliente = new FormCliente();

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





        }

        private void bt_sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja fechar o formulário?", "Sistema papelaria Humanas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}  
   
