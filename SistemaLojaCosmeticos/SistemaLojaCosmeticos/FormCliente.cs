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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }



        private void limpar()
        {
            box_nome.Clear();
            box_email.Clear();
            box_cidade.Clear();
            box_bairro.Clear();
            box_complemento.Clear();
            box_endereço.Clear();
            box_numero.Clear();
            mask_celular.Clear();
            mask_cep.Clear();
            mask_cpf.Clear();
            mask_nascimento.Clear();
            mask_residencial.Clear();
            mask_rg.Clear();





        }

        private void bt_cadastrar_Click(object sender, EventArgs e)
        {
            //VERIFICAR CAMPOS OBRIGATÓRIOS
            //PREENCHER PELO MENOS UM TELEFONE

            if (box_nome.Text != "" && mask_cpf.Text != "   .   .   -" && mask_nascimento.Text != "  /  /" && box_endereço.Text != "" && box_numero.Text != "" && box_email.Text != "" && (mask_residencial.Text != "(  )-    -" || mask_celular.Text != "(  )-     -"))
            {

                //PASSAR PARA AS PROPRIEDADES DA CLASSE AS INFORMÇÕES DIGITADAS PELO USUÁRIO NO FORMULÁRIO
                classCliente cCliente = new classCliente();
                cCliente.NomeCliente = box_nome.Text;
                cCliente.CPF = mask_cpf.Text;
                cCliente.DataNascimento = Convert.ToDateTime(mask_nascimento.Text);
                cCliente.Rua = box_endereço.Text;
                cCliente.Numero = Convert.ToInt32(box_numero.Text);
                cCliente.Complemento = box_complemento.Text;
                cCliente.Bairro = box_bairro.Text;
                cCliente.Cidade = box_cidade.Text;
                cCliente.Estado = combo_estado.SelectedItem.ToString();
                cCliente.Email = box_email.Text;

                //Radio Button 
                if (radio_feminino.Checked == true)
                {
                    cCliente.Sexo = "Feminino";



                }

                else
                {
                    cCliente.Sexo = "Masculino";




                }

                //Mascáras que não são obrigatórias
                //RG
                if (mask_rg.Text != "  .   .   -")
                {
                    cCliente.RG = mask_rg.Text;


                }
                else
                {
                    cCliente.RG = "";

                }

                if (mask_cep.Text != "     -")
                {
                    cCliente.CEP = mask_cep.Text;


                }
                else
                {
                    cCliente.CEP = "";



                }

                if (mask_celular.Text != "(  )-    -")
                {
                    cCliente.TelefoneCelular = mask_celular.Text;



                }

                else
                {
                    cCliente.TelefoneCelular = "";


                }

                if (mask_residencial.Text != "(  )-     -")
                {
                    cCliente.TelefoneResidencial = mask_residencial.Text;




                }
                else
                {
                    cCliente.TelefoneResidencial = "";


                }

                //CHAMAR O MÉTODO CADASTRAR DA CLASSE CLENTE
                int resp = cCliente.cadastro_cliente();

                //EXIBIR MENSAGEM DE CADASTRO REALIZADO
                if (resp == 1)
                {
                    MessageBox.Show("Cliente :" + cCliente.NomeCliente + "Cadastrado com Sucesso", "Sistema Loja Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    limpar();

                }
                else
                {

                    MessageBox.Show("Erro ao realizar o cadastro", "Sistema Loja Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }


            }

            else //Validação de campos obrigatórios - CASO O USUÁRIO NÃO PREENCHER OS CAMPOS

            {   //MOSTRAR ESSA MENSAGEM QUANDO O USUÁRIO NÃO PREENCHER OS CAMPOS OBRIGATÓRIOS
                MessageBox.Show("Por favor preencher todos os campos  com * (Obrigatórios!!)", "Sistema Loja Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //COLOCAR COR NOS CAMPOS QUE NÃO FOR PREENCHIDOS
                box_nome.BackColor = Color.Yellow;
                mask_cpf.BackColor = Color.Yellow;
                mask_nascimento.BackColor = Color.Yellow;
                box_endereço.BackColor = Color.Yellow;
                box_numero.BackColor = Color.Yellow;
                box_email.BackColor = Color.Yellow;
                mask_residencial.BackColor = Color.LemonChiffon;
                mask_celular.BackColor = Color.LemonChiffon;
                box_nome.Focus();




            }





        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            combo_estado.Items.Add("SP");
            combo_estado.Items.Add("RJ");
            combo_estado.Items.Add("ES");
            combo_estado.Items.Add("CE");
            combo_estado.Items.Add("");
            combo_estado.Sorted = true;


            //quando abir o formulário para atualizar/excluir
            if (tipo == "Atualização")
            {
                lb_cadastro_cliente.Text = "Atualização de Cliente";
                bt_cadastrar.Enabled = false;
                check_status.Enabled = true;
                combo_estado.SelectedItem = estado;
                label_data_cadastro.Text = datacad.ToString();



            }
            else
            {
                bt_atualizar.Enabled = false;
                bt_excluir.Enabled = false;



            }

        }

        private void box_numero_KeyPress(object sender, KeyPressEventArgs e)
        {   //Se a tecla digitada não for número, backspace(08), enter(13) e espaço(32)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 32)
                //see o usuário pressionar uma tecla não numérica no textbox, cancela o evento key press
                e.Handled = true;
            MessageBox.Show("Este campo aceita apenas números!!!", "Sistema Loja Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bt_atualizar_Click(object sender, EventArgs e)
        {
            if (box_nome.Text != "" && mask_cpf.Text != "   .   .   -" && mask_nascimento.Text != "  /  /" && box_endereço.Text != "" && box_numero.Text != "" && box_email.Text != "" && (mask_residencial.Text != "(  )-    -" || mask_celular.Text != "(  )-     -"))
            {

                //PASSAR PARA AS PROPRIEDADES DA CLASSE AS INFORMÇÕES DIGITADAS PELO USUÁRIO NO FORMULÁRIO
                classCliente cCliente = new classCliente();
                cCliente.NomeCliente = box_nome.Text;
                cCliente.CPF = mask_cpf.Text;
                cCliente.DataNascimento = Convert.ToDateTime(mask_nascimento.Text);
                cCliente.Rua = box_endereço.Text;
                cCliente.Numero = Convert.ToInt32(box_numero.Text);
                cCliente.Complemento = box_complemento.Text;
                cCliente.Bairro = box_bairro.Text;
                cCliente.Cidade = box_cidade.Text;
                cCliente.Estado = combo_estado.SelectedItem.ToString();
                cCliente.Email = box_email.Text;

                //Radio Button 
                if (radio_feminino.Checked == true)
                {
                    cCliente.Sexo = "Feminino";
                }

                else
                {
                    cCliente.Sexo = "Masculino";
                }

                //Mascáras que não são obrigatórias
                //RG
                if (mask_rg.Text != "  .   .   -")
                {
                    cCliente.RG = mask_rg.Text;
                }
                else
                {
                    cCliente.RG = "";
                }

                if (mask_cep.Text != "     -")
                {
                    cCliente.CEP = mask_cep.Text;
                }
                else
                {
                    cCliente.CEP = "";

                }

                if (mask_celular.Text != "(  )-    -")
                {
                    cCliente.TelefoneCelular = mask_celular.Text;
                }

                else
                {
                    cCliente.TelefoneCelular = "";
                }

                if (mask_residencial.Text != "(  )-     -")
                {
                    cCliente.TelefoneResidencial = mask_residencial.Text;
                }
                else
                {
                    cCliente.TelefoneResidencial = "";
                }

                //status
                if (check_status.Checked == true)
                {
                    cCliente.Status = 1;
                }

                else
                {
                    cCliente.Status = 0;
                }
                cCliente.CodigoCliente = Convert.ToInt32(box_codcli.Text);


                //CHAMAR O MÉTODO CADASTRAR DA CLASSE CLENTE
                bool resp = cCliente.AtualizarCliente();

                //EXIBIR MENSAGEM DE CADASTRO REALIZADO
                if (resp)
                {
                    MessageBox.Show("Cliente :" + cCliente.NomeCliente + "Atualizado com Sucesso", "Sistema Loja Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    limpar();

                }
                else
                {

                    MessageBox.Show("Erro ao realizar a atualização", "Sistema Loja Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }


            }

            else //Validação de campos obrigatórios - CASO O USUÁRIO NÃO PREENCHER OS CAMPOS

            {   //MOSTRAR ESSA MENSAGEM QUANDO O USUÁRIO NÃO PREENCHER OS CAMPOS OBRIGATÓRIOS
                MessageBox.Show("Por favor preencher todos os campos  com * (Obrigatórios!!)", "Sistema Loja Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //COLOCAR COR NOS CAMPOS QUE NÃO FOR PREENCHIDOS
                box_nome.BackColor = Color.Yellow;
                mask_cpf.BackColor = Color.Yellow;
                mask_nascimento.BackColor = Color.Yellow;
                box_endereço.BackColor = Color.Yellow;
                box_numero.BackColor = Color.Yellow;
                box_email.BackColor = Color.Yellow;
                mask_residencial.BackColor = Color.LemonChiffon;
                mask_celular.BackColor = Color.LemonChiffon;
                box_nome.Focus();




            }



        }

        private void mask_nascimento_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {

            if (!e.IsValidInput)
            {
                MessageBox.Show("Data Inválida", "Sistema Loja Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mask_nascimento.Focus();


            }

        }



    }
    }
