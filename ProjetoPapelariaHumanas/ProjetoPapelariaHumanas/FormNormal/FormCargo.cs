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
    public partial class FormCargo : Form
    {
        public FormCargo()
        {
            InitializeComponent();

        }
        //vARIÁVEL TIPO: GUARDAR COMO O FORMULÁRIO DEVE SER ABERTO SE PARA CADASTRO OU ATUALIZAÇÃO/EXCLUSÃO
        //VARI[ÁVEL ESTADO : INFORMAÇÃO É MOSTRADA EM UMA COMBO
        public String tipo;
        //VARIÁVEL DATACAD: MOSTRAR INFORMAÇÃO GUARDADA NO BD E NÃO DATA ATUAL COMO PROGRAMADO NO LOAD DO FORM 
        public DateTime datacad;

        private void limpar()
        {
            box_nome_cargo.Clear();


        }









        private void button1_Click(object sender, EventArgs e)
        {
            //VERIFICAR CAMPOS OBRIGATÓRIOS

            if (box_nome_cargo.Text != "")
            {
                //PASSAR PARA AS PROPRIEDADES DA CLASSE AS INFORMÇÕES DIGITADAS PELO USUÁRIO NO FORMULÁRIO

                ClassCargo cCargo = new ClassCargo();
                cCargo.Nome_Cargo = box_nome_cargo.Text;
                cCargo.Observacao = box_observacao.Text;



                //CHAMAR O MÉTODO CADASTRAR DA CLASSE Cargo
                int resp = cCargo.cadastro_cargo();

                //EXIBIR MENSAGEM DE CADASTRO REALIZADO
                if (resp == 1)
                {
                    MessageBox.Show(" Cargo " + cCargo.Nome_Cargo + " Cadastrado com Sucesso ", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    limpar();

                }
                else
                {
                    MessageBox.Show("Erro ao realizar o cadastro", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }




            }
            else //Validação de campos obrigatórios - CASO O USUÁRIO NÃO PREENCHER OS CAMPOS
            {
                //MOSTRAR ESSA MENSAGEM QUANDO O USUÁRIO NÃO PREENCHER OS CAMPOS OBRIGATÓRIOS
                MessageBox.Show("Por Favor Preencher Todos Os Campos Obrigatórios", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //COLOCAR COR NOS CAMPOS QUE NÃO FOR PREENCHIDOS
                box_nome_cargo.BackColor = Color.LightSteelBlue;
                box_nome_cargo.Focus();

            }




        }

        private void FormCargocs_Load(object sender, EventArgs e)
        {
            if (tipo == "Atualização")
            {
                label_cargo.Text = "Atualização de Cargo";
                bt_cadastrar.Enabled = false;
                check_ativo.Enabled = true;
                lb_data_cadastro.Text = datacad.ToShortDateString();
                lb_data.Text = "Data Cadastro :";
            }
            else
            {
                check_ativo.Checked = true;
                bt_atualizar.Enabled = false;
                bt_excluir.Enabled = false;
                lb_data.Text = "Data De Hoje :";
            }
            //Data de hoje
            lb_data_cadastro.Text = DateTime.Now.ToShortDateString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //VERIFICAR CAMPOS OBRIGATÓRIOS
            if (box_nome_cargo.Text != "")
            {
                //PASSAR PARA AS PROPRIEDADES DA CLASSE AS INFORMÇÕES DIGITADAS PELO USUÁRIO NO FORMULÁRIO
                ClassCargo cCargo = new ClassCargo();
                cCargo.Nome_Cargo = box_nome_cargo.Text;
                cCargo.Observacao = box_observacao.Text;

                //status
                if (check_ativo.Checked == true)
                {
                    cCargo.Status = 1;
                }

                else
                {
                    cCargo.Status = 0;
                }
                cCargo.Codigo_Cargo = Convert.ToInt32(box_codigo_cargo.Text);
                //CHAMAR O MÉTODO CADASTRAR DA CLASSE CLENTE
                bool resp = cCargo.atualizarCargo();

                //EXIBIR MENSAGEM DE CADASTRO REALIZADO
                if (resp)
                {
                    MessageBox.Show("Cargo " + cCargo.Nome_Cargo + "Atualizado com Sucesso", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                //MOSTRAR ESSA MENSAGEM QUANDO O USUÁRIO NÃO PREENCHER OS CAMPOS OBRIGATÓRIOS
                MessageBox.Show("Por Favor Preencher Todos Os Campos Obrigatórios", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //COLOCAR COR NOS CAMPOS QUE NÃO FOR PREENCHIDOS
                box_nome_cargo.BackColor = Color.LightSteelBlue;
                box_nome_cargo.Focus();

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Excluir o Cargo?", "Sistema Papelaria Humanas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ClassCargo ccargo = new ClassCargo();
                ccargo.Codigo_Cargo = Convert.ToInt32(box_codigo_cargo.Text);

                bool resp = ccargo.excluircargo();
                if (resp == true)
                {
                    MessageBox.Show("Cargo " + ccargo.Nome_Cargo + "Excluído com Sucesso ", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Este cargo não pode ser excluído, há registros em outras tabelas", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (box_nome_cargo.Text != "")
            {
                if (MessageBox.Show("Tem certeza que deseja fechar o formulário ?", "Sistema Papelaria Humanas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Close();
                }
                
            }
            else
            {
                this.Close();
            }

        }

        private void bt_ajuda_Click(object sender, EventArgs e)
        {
            if (tipo != "Atualização")
            {
                MessageBox.Show("Esta é a tela de cadastro, um local onde será adicionado todos os cargos", "Sistema Papelaria Humanas", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Esta é a tela de Atualização, um local onde será alterado todos os cargos", "Sistema Papelaria Humanas", MessageBoxButtons.OK);
            }

        }




    }
}
