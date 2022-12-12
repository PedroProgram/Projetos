using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Correios;

namespace ProjetoPapelariaHumanas
{
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }
        //vARIÁVEL TIPO: GUARDAR COMO O FORMULÁRIO DEVE SER ABERTO SE PARA CADASTRO OU ATUALIZAÇÃO/EXCLUSÃO
        //VARI[ÁVEL ESTADO : INFORMAÇÃO É MOSTRADA EM UMA COMBO
        public String tipo, estado;
        
        //VARIÁVEL DATACAD: MOSTRAR INFORMAÇÃO GUARDADA NO BD E NÃO DATA ATUAL COMO PROGRAMADO NO LOAD DO FORM 
        public DateTime datacad;

        private void limpar()
        {
            box_nome.Clear();
            box_email.Clear();
            box_cidade.Clear();
            box_bairro.Clear();
            box_complemento.Clear();
            box_rua.Clear();
            box_numero.Clear();
            mask_celular.Clear();
            mask_cep.Clear();
            mask_cpf.Clear();
            mask_nascimento.Clear();
            mask_residencial.Clear();
            mask_rg.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //VERIFICAR CAMPOS OBRIGATÓRIOS
            //PREENCHER PELO MENOS UM TELEFONE

            if (mask_cpf.Text != "   .   .   -" && mask_rg.Text != "  .   .   -" && mask_residencial.Text != "(  )-    -" && mask_celular.Text != "(  )-     -" && mask_nascimento.Text != "  /  /" && box_rua.Text != "" && box_bairro.Text != "" && box_cidade.Text != "" && box_numero.Text != "" && box_email.Text != "" )
            {
                //PASSAR PARA AS PROPRIEDADES DA CLASSE AS INFORMÇÕES DIGITADAS PELO USUÁRIO NO FORMULÁRIO
                ClassCliente cCliente = new ClassCliente();
                cCliente.nome = box_nome.Text;
                cCliente.cpf = mask_cpf.Text;
                cCliente.rg = mask_rg.Text;
                cCliente.data_nascimento = Convert.ToDateTime(mask_nascimento.Text);
                cCliente.rua = box_rua.Text;
                cCliente.numero = Convert.ToInt32(box_numero.Text);
                cCliente.complemento = box_complemento.Text;
                cCliente.bairro = box_bairro.Text;
                cCliente.email = box_email.Text;
                cCliente.cidade = box_cidade.Text;
                cCliente.telefone = mask_residencial.Text;
                cCliente.celular = mask_celular.Text;
                cCliente.estado = combo_estado.SelectedItem.ToString();






                //RadioButton
                if (radio_feminino.Checked == true)
                {
                    cCliente.sexo = "Feminino";


                }

                else
                {
                    cCliente.sexo = "Masculino";


                }
                //Mascáras que não são obrigatórias
                //CEP

                if (mask_cep.Text != "     -")

                {
                    cCliente.cep = mask_cep.Text;


                }
                else
                {
                    cCliente.cep = "";



                }

                //CHAMAR O MÉTODO CADASTRAR DA CLASSE CLENTE
                int resp = cCliente.cadastro_cliente();

                //EXIBIR MENSAGEM DE CADASTRO REALIZADO
                if (resp == 1)
                {
                    MessageBox.Show("Cliente " + cCliente.nome + "Cadastrado com Sucesso", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    limpar();

                }
                else
                {

                    MessageBox.Show("Erro ao realizar o Cadastro", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }


            }
            else //Validação de campos obrigatórios - CASO O USUÁRIO NÃO PREENCHER OS CAMPOS
            {
                MessageBox.Show(" Por Favor Preencher Todos os Campos Obrigatório", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //COLOCAR COR NOS CAMPOS QUE NÃO FOR PREENCHIDOS               
                mask_cpf.BackColor = Color.LightSteelBlue;
                mask_rg.BackColor = Color.LightSteelBlue;
                mask_nascimento.BackColor = Color.LightSteelBlue;
                box_rua.BackColor = Color.LightSteelBlue;
                box_numero.BackColor = Color.LightSteelBlue;
                box_email.BackColor = Color.LightSteelBlue;           
                box_cidade.BackColor = Color.LightSteelBlue;
                box_bairro.BackColor = Color.LightSteelBlue;
                mask_residencial.BackColor = Color.LightSteelBlue;
                mask_celular.BackColor = Color.LightSteelBlue;
                box_nome.Focus();

            }




        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            combo_estado.Items.Add("RJ");
            combo_estado.Items.Add("MG");
            combo_estado.Items.Add("GO");
            combo_estado.Items.Add("MT");
            combo_estado.Items.Add("MA");
            combo_estado.Items.Add("AC");
            combo_estado.Items.Add("AL");
            combo_estado.Items.Add("AP");
            combo_estado.Items.Add("AM");
            combo_estado.Items.Add("BA");
            combo_estado.Items.Add("CE");
            combo_estado.Items.Add("DF");
            combo_estado.Items.Add("ES");
            combo_estado.Items.Add("MS");
            combo_estado.Items.Add("PA");
            combo_estado.Items.Add("PB");
            combo_estado.Items.Add("PE");
            combo_estado.Items.Add("PÍ");
            combo_estado.Items.Add("RR");
            combo_estado.Items.Add("RO");
            combo_estado.Items.Add("RN");
            combo_estado.Items.Add("RS");
            combo_estado.Items.Add("SC");
            combo_estado.Items.Add("SP");
            combo_estado.Items.Add("SE");
            combo_estado.Items.Add("TO");


            combo_estado.Sorted = true;

            //Data de hoje
            lb_data_cadastro.Text = DateTime.Now.ToString();


            //quando abir o formulário para atualizar/excluir
            if (tipo == "Atualização")
            {
                lb_cadastro_cliente.Text = "Atualização de Cliente";
                bt_cadastrar.Enabled = false;
                check_ativo.Enabled = true;
                combo_estado.SelectedItem = estado;
                lb_data_cadastro.Text = datacad.ToShortDateString();
                lb_data.Text = "Data Cadastro :";


            }
            else
            {
                bt_atualizar.Enabled = false;
                bt_excluir.Enabled = false;
                check_ativo.Checked = true;
                lb_data.Text = "Data De Hoje :";
                lb_data_cadastro.Text = DateTime.Now.ToShortDateString();

            }
        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Excluir o Cliente?", "Sistema papelaria Humanas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ClassCliente ccliente = new ClassCliente();
                ccliente.codigo_cliente = Convert.ToInt32(box_cod_cli.Text);

                bool resp = ccliente.excluircliente();
                if(resp == true)
                {
                    MessageBox.Show("Cliente " + ccliente.nome + "Excluído com Sucesso ", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Este cliente não pode ser excluído, há registros em outras tabelas", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }

        }

        private void bt_sair_Click(object sender, EventArgs e)
        {
            if (mask_cpf.Text != "   .   .   -" && mask_rg.Text != "  .   .   -" && mask_residencial.Text != "(  )-    -" && mask_celular.Text != "(  )-     -" && mask_nascimento.Text != "  /  /" && box_rua.Text != "" && box_bairro.Text != "" && box_cidade.Text != "" && box_numero.Text != "" && box_email.Text != "")
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

        private void box_numero_KeyPress(object sender, KeyPressEventArgs e)
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

        private void mask_cep_Leave(object sender, EventArgs e)
        {
            try
            {
                CorreiosApi correios = new CorreiosApi();
                var retorno = correios.consultaCEP(mask_cep.Text);

                box_bairro.Text = retorno.bairro;
                box_rua.Text = retorno.end;
                box_cidade.Text = retorno.cidade;
                combo_estado.SelectedItem = retorno.uf;
               
            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro ao consultar o CEP :" + erro.Message, "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void bt_ajuda_Click(object sender, EventArgs e)
        {
            if (tipo != "Atualização")
            {
                MessageBox.Show("Esta é a tela de cadastro, um local onde será adicionado todos os clientes", "Sistema Papelaria Humanas", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Esta é a tela de Atualização, um local onde será alterado todos os clientes", "Sistema Papelaria Humanas", MessageBoxButtons.OK);
            }

        }

        private void mask_nascimento_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                MessageBox.Show("Data Inválida", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mask_nascimento.Focus();
                mask_nascimento.Text = "";

            }
        }

        private void btatualizar_Click(object sender, EventArgs e)
        {

            //VERIFICAR CAMPOS OBRIGATÓRIOS
            

            if (mask_cpf.Text != "   .   .   -" && mask_rg.Text != "  .   .   -" && mask_residencial.Text != "(  )-    -" && mask_celular.Text != "(  )-     -" && mask_nascimento.Text != "  /  /" && box_rua.Text != "" && box_bairro.Text != "" && box_cidade.Text != "" && box_numero.Text != "" && box_email.Text != "" )
            {
                //PASSAR PARA AS PROPRIEDADES DA CLASSE AS INFORMÇÕES DIGITADAS PELO USUÁRIO NO FORMULÁRIO
                ClassCliente cCliente = new ClassCliente();
                cCliente.nome = box_nome.Text;
                cCliente.cpf = mask_cpf.Text;
                cCliente.rg = mask_rg.Text;
                cCliente.data_nascimento = Convert.ToDateTime(mask_nascimento.Text);
                cCliente.rua = box_rua.Text;
                cCliente.numero = Convert.ToInt32(box_numero.Text);
                cCliente.complemento = box_complemento.Text;
                cCliente.bairro = box_bairro.Text;
                cCliente.email = box_email.Text;
                cCliente.cidade = box_cidade.Text;
                cCliente.telefone = mask_residencial.Text;
                cCliente.celular = mask_celular.Text;
                cCliente.estado = combo_estado.SelectedItem.ToString();






                //RadioButton
                if (radio_feminino.Checked == true)
                {
                    cCliente.sexo = "Feminino";


                }

                else
                {
                    cCliente.sexo = "Masculino";


                }
                //Mascáras que não são obrigatórias
                //CEP

                if (mask_cep.Text != "     -")

                {
                    cCliente.cep = mask_cep.Text;


                }
                else
                {
                    cCliente.cep = "";



                }
                //status
                if (check_ativo.Checked == true)
                {
                    cCliente.status = 1;
                }

                else
                {
                    cCliente.status = 0;
                }
                cCliente.codigo_cliente = Convert.ToInt32(box_cod_cli.Text);

                //CHAMAR O MÉTODO CADASTRAR DA CLASSE CLENTE
                bool resp = cCliente.AtualizarCliente();

                //EXIBIR MENSAGEM DE CADASTRO REALIZADO
                if (resp)
                {
                    MessageBox.Show("Cliente " + cCliente.nome + " Atualizado com Sucesso ", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    limpar();
                    this.Close();

                }
                else
                {

                    MessageBox.Show("Erro ao realizar a atualização", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }

            }
            else //Validação de campos obrigatórios - CASO O USUÁRIO NÃO PREENCHER OS CAMPOS
            {
                MessageBox.Show("Por Favor Preencher Todos os Campos Obrigatório", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //COLOCAR COR NOS CAMPOS QUE NÃO FOR PREENCHIDOS               
                mask_cpf.BackColor = Color.LightSteelBlue;
                mask_rg.BackColor = Color.LightSteelBlue;
                mask_nascimento.BackColor = Color.LightSteelBlue;
                box_rua.BackColor = Color.LightSteelBlue;
                box_numero.BackColor = Color.LightSteelBlue;
                box_email.BackColor = Color.LightSteelBlue;
                box_cidade.BackColor = Color.LightSteelBlue;
                box_bairro.BackColor = Color.LightSteelBlue;
                mask_residencial.BackColor = Color.LightSteelBlue;
                mask_celular.BackColor = Color.LightSteelBlue;
                box_nome.Focus();

            }

        } 
}   }
