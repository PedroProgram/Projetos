using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLojaCosmeticos
{
    public partial class FormConsulta1 : Form
    {
        public FormConsulta1()
        {
            InitializeComponent();
        }

        private void FormConsulta1_Load(object sender, EventArgs e)
        {
            combo_opcoes.Items.Add("CPF");
            combo_opcoes.Items.Add("Nome");
            combo_opcoes.Items.Add("Sexo");
            combo_opcoes.Items.Add("Status");

            //Deixar a opção nome selecionada

            combo_opcoes.SelectedItem = "Nome";








        }

        private void combo_opcoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ATIVAR E DESATIVAR OS ELEMENTOS DO FORM CONFROME A ESCOLHA DO USUÁRIO

            //cpf
            if (combo_opcoes.SelectedIndex == 0)
            {
                box_nome.Enabled = false;
                groupBoxpesquisa.Enabled = false;
                groupBoxSexo.Enabled = false;
                groupBoxstatus.Enabled = false;
                groupBoxcpf.Enabled = true;




            }
            //Nome
            if (combo_opcoes.SelectedIndex == 1)
            {
                box_nome.Enabled = true;
                groupBoxpesquisa.Enabled = true;
                groupBoxSexo.Enabled = false;
                groupBoxstatus.Enabled = false;
                groupBoxcpf.Enabled = false;




            }
            //Sexo
            if (combo_opcoes.SelectedIndex == 2)
            {
                box_nome.Enabled = false;
                groupBoxpesquisa.Enabled = false;
                groupBoxSexo.Enabled = true;
                groupBoxstatus.Enabled = false;
                groupBoxcpf.Enabled = false;




            }
            //Status
            if (combo_opcoes.SelectedIndex == 3)
            {
                box_nome.Enabled = false;
                groupBoxpesquisa.Enabled = false;
                groupBoxSexo.Enabled = false;
                groupBoxstatus.Enabled = true;
                groupBoxcpf.Enabled = false;




            }
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            //Instaciar a classe cliente para usar os métodos de consulta

            classCliente Ccliente = new classCliente();
            
            //criar uma varíavel para receber a opção escolhida pelo usuário na combo

            string CONSULTA = combo_opcoes.SelectedItem.ToString();


            switch(CONSULTA)
            {
                case "Nome": 
                if(box_nome.Text != "" )
                {
                  if(radio_inicio.Checked == true)
                  {
                            dataGridView_Consulta.DataSource = Ccliente.ConsultaClienteNomeInicio(box_nome.Text);

                  }

                  else
                  {
                            dataGridView_Consulta.DataSource = Ccliente.ConsultaClienteNomeContem(box_nome.Text);

                  }

                  

                }

                //Campo nome
                else
                {
                        MessageBox.Show("Favor informar um Nome", "Sistema Loja Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                }
                    break;


                    //Campo sexo
                case "Sexo":
                if(radioButton_Feminino.Checked == true)
                {

                   dataGridView_Consulta.DataSource = Ccliente.ConsultaClienteSexo(radioButton_Feminino.Text);

                   
                }
                else
                {

                        dataGridView_Consulta.DataSource = Ccliente.ConsultaClienteSexo(radioButton_masculino.Text);

                }
                    break;
                //CPF
                case "CPF":
                if(mask_cep.Text != "   .   .   -")
                {

                        dataGridView_Consulta.DataSource = Ccliente.ConsultaClienteCPF(mask_cep.Text);



                }
                else
                {
                        MessageBox.Show("Favor informar um CPF", "Sistema Loja Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                }
                    break;
                //Status
                case "Status":
                if(radioButton_ativo.Checked==true)
                {
                        dataGridView_Consulta.DataSource = Ccliente.ConsultaClienteStatus(1);


                }

                else
                {
                        dataGridView_Consulta.DataSource = Ccliente.ConsultaClienteStatus(0);  


                }
                    break;     

            }




        }
        //CLICAR NA GRID DE CLIENTES E EDITAR OU EXCLUIR UM CLIENTE
        //USAR O EVENTO CLLCLICK (PODE CLICAR EM QUALQUER LUGAR DA CÉLULA, NÃO SOMENTE NO TEXTO)
        //USAR O EVENTO CLLCONTENT (TEM QUE CLICAR NO CONTEÚDO (TEXTO))
        private void dataGridView_Consulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(MessageBox.Show("Dseja alterar o cliente selecionado?", "Sistema Loja Cosméticos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //INSTANCIAR A CLASSE CLIENTE PARA USAR MÉTODOS E PROPRIEDADES
                classCliente cCliente = new classCliente();

                //INSTANCIAR O FORMULÁRIO DE CADASTRO / ATUALIZAÇÃO DE CLIENTE PARA USAR OS CONTROLES DO FORM
                FormCliente fcliente = new FormCliente();

                //PEGAR O CÓDIGO DO CLIENTE SELECIONADO PELO USUÁRIO NA GRID
                cCliente.ConsultarCliente(Convert.ToInt32(dataGridView_Consulta.SelectedRows[0].Cells[0].Value));


                //PASSAR OS DADOS DO BD PARA OS CONTROLES DO FORM DE CLIENTES
                fcliente.box_codcli.Text = cCliente.CodigoCliente.ToString();
                fcliente.datacad = cCliente.DataCadastro; //PASSAR A VARIÁVEL GLOBAL CRIADA NO FORM DE CADASTRO DE CLIENTES
                fcliente.box_nome.Text = cCliente.NomeCliente.ToString();
                fcliente.mask_rg.Text = cCliente.CPF.ToString();    
                fcliente.mask_cpf.Text = cCliente.RG.ToString();
                fcliente.mask_nascimento.Text = cCliente.DataNascimento.ToString();
                fcliente.box_endereço.Text = cCliente.Rua.ToString();
                fcliente.box_numero.Text = cCliente.Numero.ToString();
                fcliente.box_complemento.Text = cCliente.Complemento.ToString();
                fcliente.box_bairro.Text = cCliente.Bairro.ToString();
                fcliente.box_cidade.Text = cCliente.Cidade.ToString();
                fcliente.estado = cCliente.Estado.ToString(); //(COMBO) PASSAR A VARIÁVEL DECLARADA NO FORMULÁRIO DE CLIENTE
                fcliente.mask_cep.Text = cCliente.CEP.ToString();
                fcliente.box_email.Text = cCliente.Email.ToString();
                fcliente.mask_residencial.Text = cCliente.TelefoneResidencial.ToString();
                fcliente.mask_celular.Text = cCliente.TelefoneCelular.ToString();

                if(cCliente.Sexo == "Feminino")
                {
                    fcliente.radio_feminino.Checked = true;


                }
                else
                {
                    fcliente.radio_masculino.Checked = true;



                }
                 if (cCliente.Status == 1)
                {

                    fcliente.check_status.Checked = true;


                }

                 else
                {


                    fcliente.check_status.Checked = false;
                }

                //MANDAR A INFORMAÇÃO DE UPDATE
                fcliente.tipo = "Atualização";
                //ABRIR O FORMULÁRIO DE CADASTRO EM MODO EXCLUSIVO
                fcliente.ShowDialog();
                //CHAMAR O MÉTODO DE PESQUISA
                btPesquisar_Click(this, new EventArgs());



            }



        }
    }
}
