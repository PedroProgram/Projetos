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

            if (box_nome.Text != "" && mask_cpf.Text != "   .   .   -" && mask_rg.Text != "  .   .   -" && mask_nascimento.Text != "  /  /" && box_rua.Text != "" && box_bairro.Text != "" && box_cidade.Text != "" && box_numero.Text != "" && box_email.Text != "" && (mask_residencial.Text != "(  )-    -" || mask_celular.Text != "(  )-     -"))
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
                    MessageBox.Show("Cliente :" + cCliente.nome + "Cadastrado com Sucesso", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    limpar();

                }
                else
                {

                    MessageBox.Show("Erro ao realizar o Cadastro", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }


            }
            else //Validação de campos obrigatórios - CASO O USUÁRIO NÃO PREENCHER OS CAMPOS
            {
                MessageBox.Show("Preencher Todos os Campos em Negrito", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //COLOCAR COR NOS CAMPOS QUE NÃO FOR PREENCHIDOS
                box_nome.BackColor = Color.Yellow;
                mask_cpf.BackColor = Color.Yellow;
                mask_rg.BackColor = Color.Yellow;
                mask_nascimento.BackColor = Color.Yellow;
                box_rua.BackColor = Color.Yellow;
                box_numero.BackColor = Color.Yellow;
                box_email.BackColor = Color.Yellow;
                box_complemento.BackColor = Color.Yellow;
                box_cidade.BackColor = Color.Yellow;
                box_bairro.BackColor = Color.Yellow;
                mask_residencial.BackColor = Color.LemonChiffon;
                mask_celular.BackColor = Color.LemonChiffon;
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


            //quando abir o formulário para atualizar/excluir
            if (tipo == "Atualização")
            {
                lb_cadastro_cliente.Text = "Atualização de Cliente";
                bt_cadastrar.Enabled = false;
                check_ativo.Enabled = true;
                combo_estado.SelectedItem = estado;
                lb_cadastro.Text = datacad.ToString();



            }
            else
            {
                bt_atualizar.Enabled = false;
                bt_excluir.Enabled = false;



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
            if (MessageBox.Show("Tem certeza que deseja fechar o formulário?", "Sistema Papelaria Humanas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
            {

                this.Close();
            }
        }

        private void btatualizar_Click(object sender, EventArgs e)
        {

            //VERIFICAR CAMPOS OBRIGATÓRIOS
            //PREENCHER PELO MENOS UM TELEFONE

            if (box_nome.Text != "" && mask_cpf.Text != "   .   .   -" && mask_rg.Text != "  .   .   -" && mask_nascimento.Text != "  /  /" && box_rua.Text != "" && box_bairro.Text != "" && box_cidade.Text != "" && box_numero.Text != "" && box_email.Text != "" && (mask_residencial.Text != "(  )-    -" || mask_celular.Text != "(  )-     -"))
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
                    MessageBox.Show("Cliente :" + cCliente.nome + "Atualizado com Sucesso", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    limpar();

                }
                else
                {

                    MessageBox.Show("Erro ao realizar a atualização", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }

            }

           
        } 
}   }
