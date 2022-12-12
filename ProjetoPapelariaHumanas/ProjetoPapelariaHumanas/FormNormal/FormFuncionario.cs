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
    public partial class FormFuncionario : Form
    {
        public FormFuncionario()
        {
            InitializeComponent();
        }
        //vARIÁVEL TIPO: GUARDAR COMO O FORMULÁRIO DEVE SER ABERTO SE PARA CADASTRO OU ATUALIZAÇÃO/EXCLUSÃO
        //VARI[ÁVEL ESTADO : INFORMAÇÃO É MOSTRADA EM UMA COMBO
        public String tipo, estado, tipo_acesso;
        public int cargo;
        //VARIÁVEL DATACAD: MOSTRAR INFORMAÇÃO GUARDADA NO BD E NÃO DATA ATUAL COMO PROGRAMADO NO LOAD DO FORM 
        public DateTime datacad;

        private void limpar()
        {
            box_nome_funcionario.Clear();
            box_email.Clear();
            box_cidade.Clear();
            box_bairro.Clear();
            box_complemento.Clear();
            box_rua.Clear();
            box_numero.Clear();
            mask_celular.Clear();
            mask_cep.Clear();
            mask_CPF.Clear();
            mask_RG.Clear();
            mask_celular.Clear();
            mask_nascimento_fun.Clear();
            combo_acesso.SelectedIndex = -1;
            combo_cargo.SelectedIndex = -1;
            box_login.Clear();
            box_senha.Clear();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //VERIFICAR CAMPOS OBRIGATÓRIOS
            if ( box_nome_funcionario.Text != "" && mask_nascimento_fun.Text != "  /  /" && mask_CPF.Text != "   .   .   -" && mask_RG.Text != "  .   .   -" && mask_celular.Text != "(  )-     -" && box_email.Text != "" && box_login.Text != "" && box_senha.Text != "" && box_rua.Text != "" && box_bairro.Text != "" && box_cidade.Text != "" && box_numero.Text !="" )
            {
                ClassFuncionario cfuncionario = new ClassFuncionario();
                cfuncionario.nome_funcionario = box_nome_funcionario.Text;
                cfuncionario.cpf = mask_CPF.Text;
                cfuncionario.rg = mask_RG.Text;
                cfuncionario.bairro = box_bairro.Text;
                cfuncionario.rua = box_rua.Text;
                cfuncionario.numero = Convert.ToInt32(box_numero.Text);
                cfuncionario.cidade = box_cidade.Text;
                cfuncionario.email = box_email.Text;
                cfuncionario.telefone = mask_celular.Text;
                cfuncionario.complemento = box_complemento.Text;
                cfuncionario.senha = box_senha.Text;
                cfuncionario.login = box_login.Text;
                cfuncionario.cep = mask_cep.Text;
                cfuncionario.cidade = box_cidade.Text;
                cfuncionario.estado = combo_estado.SelectedItem.ToString();
                cfuncionario.codigo_cargo = Convert.ToInt32(combo_cargo.SelectedValue);
                cfuncionario.tipo_acesso = Convert.ToString(combo_acesso.Text);
                cfuncionario.data_nascimento = Convert.ToDateTime(mask_nascimento_fun.Text);

                //RadioButton
                if (radio_feminino.Checked == true)
                {
                    cfuncionario.sexo = "Feminino";


                }

                else
                {
                    cfuncionario.sexo = "Masculino";


                }
                //Mascáras que não são obrigatórias
                //CEP

                if (mask_cep.Text != "     -")

                {
                    cfuncionario.cep = mask_cep.Text;


                }
                else
                {
                    cfuncionario.cep = "";



                }

                //CHAMAR O MÉTODO CADASTRAR DA CLASSE funcionário
                int resp = cfuncionario.cadastro_funcionario();
                //exibir mensagem de cadastro realizado
                if (resp == 1)
                {
                    MessageBox.Show(" Funcionário  " + cfuncionario.nome_funcionario + " Cadastrado com Sucesso ", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    limpar();


                }

                else
                {

                    MessageBox.Show("Erro ao realizar o cadastro", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else //Validação de campos obrigatórios - CASO O USUÁRIO NÃO PREENCHER OS CAMPOS
            {

                MessageBox.Show("Por Favor Preencher Todos os Campos Obrigatórios", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //COLOCAR COR NOS CAMPOS QUE NÃO FOR PREENCHIDOS
                box_nome_funcionario.BackColor = Color.LightSteelBlue;
                mask_nascimento_fun.BackColor = Color.LightSteelBlue;
                mask_CPF.BackColor = Color.LightSteelBlue;
                mask_RG.BackColor = Color.LightSteelBlue;
                mask_celular.BackColor = Color.LightSteelBlue;
                box_email.BackColor = Color.LightSteelBlue;               
                box_login.BackColor = Color.LightSteelBlue;
                box_senha.BackColor = Color.LightSteelBlue;
                box_rua.BackColor = Color.LightSteelBlue;
                box_bairro.BackColor = Color.LightSteelBlue;
                box_cidade.BackColor = Color.LightSteelBlue;
                box_numero.BackColor = Color.LightSteelBlue;               
                box_nome_funcionario.Focus();                   

            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Excluir o Funcionário?", "Sistema papelaria Humanas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ClassFuncionario cfuncionario = new ClassFuncionario();
                cfuncionario.codigo_funcionario = Convert.ToInt32(box_codigo_fun.Text);

                bool resp = cfuncionario.excluircliente();
                if (resp == true)
                {
                    MessageBox.Show("Funcionário " + cfuncionario.nome_funcionario + "Excluído com Sucesso ", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Este funcionário não pode ser excluído, há registros em outras tabelas", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void bt_sair_Click(object sender, EventArgs e)
        {
            if (box_nome_funcionario.Text != "" && mask_nascimento_fun.Text != "  /  /" && mask_CPF.Text != "   .   .   -" && mask_RG.Text != "  .   .   -" && mask_celular.Text != "(  )-     -" && box_email.Text != "" && box_login.Text != "" && box_senha.Text != "" && box_rua.Text != "" && box_bairro.Text != "" && box_cidade.Text != "" && box_numero.Text != "")
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
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Consultar CEP: " + erro.Message, "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_ajuda_Click(object sender, EventArgs e)
        {
            if (tipo != "Atualização")
            {
                MessageBox.Show("Esta é a tela de cadastro, um local onde será adicionado todos os Funcionarios", "Sistema Papelaria Humanas", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Esta é a tela de Atualização, um local onde será alterado todos os Funcionarios", "Sistema Papelaria Humanas", MessageBoxButtons.OK);
            }
        }

        private void mask_nascimento_fun_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                MessageBox.Show("Data Inválida", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mask_nascimento_fun.Focus();
                mask_nascimento_fun.Text = "";

            }
        }

        private void FormFuncionario_Load(object sender, EventArgs e)
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
            combo_estado.Items.Add("SE");
            combo_estado.Items.Add("SP");
            combo_estado.Items.Add("TO");


           

            combo_acesso.Items.Add("Administrador");
            combo_acesso.Items.Add("Usuário");

            //Data de hoje
            lb_data_cadastro.Text = DateTime.Now.ToString();

            //CARRREGAR COMBO CARGO
            ClassCargo cCargo = new ClassCargo();
            combo_cargo.DataSource = cCargo.BuscarCargo();//executar método criado na classe categoria
            combo_cargo.DisplayMember = "nome";//exibir na combo (nome)
            combo_cargo.ValueMember = "codigo_cargo"; //guardar no BD (código)
            combo_cargo.SelectedIndex = -1; //Limpar a combo (não seleciona nada - quando abrir o form

            //quando abir o formulário para atualizar/excluir
            if (tipo == "Atualização")
            {
                label_funcionario.Text = "Atualização de Funcionário";
                bt_cadastrar.Enabled = false;
                check_ativo.Enabled = true;
                combo_estado.SelectedItem = estado;
                lb_data_cadastro.Text = datacad.ToShortDateString();
                combo_cargo.SelectedValue = cargo;
                combo_acesso.SelectedItem = tipo_acesso;
                lb_data.Text = "Data Cadastro";
            }
            else
            {
                bt_atualizar.Enabled = false;
                bt_excluir.Enabled = false;
                lb_data.Text = "Data De Hoje";
                lb_data_cadastro.Text = DateTime.Now.ToShortDateString();
                check_ativo.Checked = true;
            }

        }

        private void bt_atualizar_Click(object sender, EventArgs e)
        {
            //VERIFICAR CAMPOS OBRIGATÓRIOS
            //PREENCHER PELO MENOS UM TELEFONE

            if (box_nome_funcionario.Text != "" && mask_nascimento_fun.Text != "  /  /" && mask_CPF.Text != "   .   .   -" && mask_RG.Text != "  .   .   -" && mask_celular.Text != "(  )-     -" && box_email.Text != "" && box_login.Text != "" && box_senha.Text != "" && box_rua.Text != "" && box_bairro.Text != "" && box_cidade.Text != "" && box_numero.Text != "" )
            {
                //PASSAR PARA AS PROPRIEDADES DA CLASSE AS INFORMÇÕES DIGITADAS PELO USUÁRIO NO FORMULÁRIO
                ClassFuncionario cfuncionario = new ClassFuncionario();
                cfuncionario.nome_funcionario = box_nome_funcionario.Text;
                cfuncionario.cpf = mask_CPF.Text;
                cfuncionario.rg = mask_RG.Text;
                cfuncionario.data_nascimento = Convert.ToDateTime(mask_nascimento_fun.Text);
                cfuncionario.rua = box_rua.Text;
                cfuncionario.numero = Convert.ToInt32(box_numero.Text);
                cfuncionario.complemento = box_complemento.Text;
                cfuncionario.bairro = box_bairro.Text;
                cfuncionario.email = box_email.Text;
                cfuncionario.cidade = box_cidade.Text;
                cfuncionario.telefone = mask_celular.Text;
                cfuncionario.estado = combo_estado.SelectedItem.ToString();
                cfuncionario.codigo_cargo = Convert.ToInt32(combo_cargo.SelectedValue);


                //RadioButton
                if (radio_feminino.Checked == true)
                {
                    cfuncionario.sexo = "Feminino";


                }

                else
                {
                    cfuncionario.sexo = "Masculino";


                }
                //Mascáras que não são obrigatórias
                //CEP

                if (mask_cep.Text != "     -")

                {
                    cfuncionario.cep = mask_cep.Text;


                }
                else
                {
                    cfuncionario.cep = "";



                }
                //status
                if (check_ativo.Checked == true)
                {
                    cfuncionario.status = 1;
                }

                else
                {
                    cfuncionario.status = 0;
                }
                cfuncionario.codigo_funcionario = Convert.ToInt32(box_codigo_fun.Text);

                //CHAMAR O MÉTODO CADASTRAR DA CLASSE CLENTE
                bool resp = cfuncionario.AtualizarFuncionario();

                //EXIBIR MENSAGEM DE CADASTRO REALIZADO
                if (resp)
                {
                    MessageBox.Show("Funcionário  " + cfuncionario.nome_funcionario + " Atualizado com Sucesso ", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

                MessageBox.Show("Por Favor Preencher Todos os Campos Obrigatórios", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //COLOCAR COR NOS CAMPOS QUE NÃO FOR PREENCHIDOS
                box_nome_funcionario.BackColor = Color.LightSteelBlue;
                mask_nascimento_fun.BackColor = Color.LightSteelBlue;
                mask_CPF.BackColor = Color.LightSteelBlue;
                mask_RG.BackColor = Color.LightSteelBlue;
                mask_celular.BackColor = Color.LightSteelBlue;
                box_email.BackColor = Color.LightSteelBlue;
                box_login.BackColor = Color.LightSteelBlue;
                box_senha.BackColor = Color.LightSteelBlue;
                box_rua.BackColor = Color.LightSteelBlue;
                box_bairro.BackColor = Color.LightSteelBlue;
                box_cidade.BackColor = Color.LightSteelBlue;
                box_numero.BackColor = Color.LightSteelBlue;
                box_nome_funcionario.Focus();

            }


        }
    }
}
