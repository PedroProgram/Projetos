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
    public partial class FormConsultaFuncionario : Form
    {
        public FormConsultaFuncionario()
        {
            InitializeComponent();
        }

        private void FormConsularFuncionario_Load(object sender, EventArgs e)
        {
            combo_pesquisa_funcionario.Items.Add("Selecione Uma Opção");
            combo_pesquisa_funcionario.Items.Add("CPF");
            combo_pesquisa_funcionario.Items.Add("Nome");
            combo_pesquisa_funcionario.Items.Add("Sexo");
            combo_pesquisa_funcionario.Items.Add("Status");
            combo_pesquisa_funcionario.Items.Add("Cargo");

            //DEIXAR UMA OPÇÃO SELECIONADA
            combo_pesquisa_funcionario.SelectedIndex = 0;

            //DEIXAR CHECADO OS RADIOBUTTONS
            radio_inicio.Checked = true;
            radio_ativo.Checked = true;
            radio_feminino.Checked = true;

            //CARRREGAR COMBO CARGO
            ClassCargo cCargo = new ClassCargo();
            combo_c.DataSource = cCargo.BuscarCargo();//executar método criado na classe categoria
            combo_c.DisplayMember = "nome";//exibir na combo (nome)
            combo_c.ValueMember = "codigo_cargo"; //guardar no BD (código)
            combo_c.SelectedIndex = -1; //Limpar a combo (não seleciona nada - quando abrir o form
        }


        private void combo_pesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ATIVAR E DESATIVAR OS ELEMENTOS DO FORM CONFROME A ESCOLHA DO USUÁRIO

            //Opção
            if (combo_pesquisa_funcionario.SelectedIndex == 0)
            {
                box_nome_fun.Enabled = false;
                groupBoox_tipopesquisa.Enabled = false;
                groupBox_sexo.Enabled = false;
                groupBox_status.Enabled = false;
                groupBox_cpf.Enabled = false;
                groupBox_cargo.Enabled = false;




            }
            //CPF
            if (combo_pesquisa_funcionario.SelectedIndex == 1)
            {
                box_nome_fun.Enabled = false;
                groupBoox_tipopesquisa.Enabled = false;
                groupBox_sexo.Enabled = false;
                groupBox_status.Enabled = false;
                groupBox_cpf.Enabled = true;
                groupBox_cargo.Enabled = false;



            }
            //Nome
            if (combo_pesquisa_funcionario.SelectedIndex == 2)
            {
                box_nome_fun.Enabled = true;
                groupBoox_tipopesquisa.Enabled = true;
                groupBox_sexo.Enabled = false;
                groupBox_status.Enabled = false;
                groupBox_cpf.Enabled = false;
                groupBox_cargo.Enabled = false;



            }
            //Sexo
            if (combo_pesquisa_funcionario.SelectedIndex == 3)
            {
                box_nome_fun.Enabled = false;
                groupBoox_tipopesquisa.Enabled = false;
                groupBox_cargo.Enabled = false;
                groupBox_cpf.Enabled = false;
                groupBox_status.Enabled = false;
                groupBox_sexo.Enabled = true;
                groupBox_cargo.Enabled = false;


            }
            //Status
            if (combo_pesquisa_funcionario.SelectedIndex == 4)
            {
                box_nome_fun.Enabled = false;
                groupBoox_tipopesquisa.Enabled = false;
                groupBox_cpf.Enabled = false;
                groupBox_sexo.Enabled = false;
                groupBox_status.Enabled = true;
                groupBox_cargo.Enabled = false;


            }
            //Cargo
            if (combo_pesquisa_funcionario.SelectedIndex == 5)
            {
                box_nome_fun.Enabled = false;
                groupBoox_tipopesquisa.Enabled = false;
                groupBox_sexo.Enabled = false;
                groupBox_status.Enabled = false;
                groupBox_cpf.Enabled = false;
                groupBox_cargo.Enabled = true;




            }

        }

        private void bt_pesquisar_Click(object sender, EventArgs e)
        {
            //Instaciar a classe cliente para usar os métodos de consulta

            ClassFuncionario Cfuncionario = new ClassFuncionario();

            //criar uma varíavel para receber a opção escolhida pelo usuário na combo

            string CONSULTA = combo_pesquisa_funcionario.SelectedItem.ToString();


            switch (CONSULTA)
            {
                case "Nome":
                    if (box_nome_fun.Text != "")
                    {
                        if (radio_inicio.Checked == true)
                        {
                            dataGridView_funcionario.DataSource = Cfuncionario.ConsultaFuncionarioNomeInicio(box_nome_fun.Text);

                        }

                        else
                        {
                            dataGridView_funcionario.DataSource = Cfuncionario.ConsultaFuncionarioNomeContem(box_nome_fun.Text);

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

                        dataGridView_funcionario.DataSource = Cfuncionario.ConsultaFuncionarioSexo("F");

                    }
                    else
                    {

                        dataGridView_funcionario.DataSource = Cfuncionario.ConsultaFuncionarioSexo("M");

                    }
                    break;
                //CPF
                case "CPF":
                    if (mask_cpf.Text != "   .   .   -")
                    {

                        dataGridView_funcionario.DataSource = Cfuncionario.ConsultaFuncionarioCPF(mask_cpf.Text);



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
                        dataGridView_funcionario.DataSource = Cfuncionario.ConsultaFuncionarioStatus(1);


                    }

                    else
                    {
                        dataGridView_funcionario.DataSource = Cfuncionario.ConsultaFuncionarioStatus(0);


                    }
                    break;
                //Cargo
                case "Cargo":
                    if (combo_c.SelectedIndex != -1)
                    {
                        dataGridView_funcionario.DataSource = Cfuncionario.ConsultaFuncionarioCargo(Convert.ToInt32(combo_c.SelectedValue));

                    }
                    else
                    {
                        MessageBox.Show("Favor informar um Cargo", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    break;
            }
        }

        private void dataGridView_funcionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_funcionario.Rows.Count > 0)
            {
                //INSTANCIAR A CLASSE funcionário PARA USAR MÉTODOS E PROPRIEDADES
                ClassFuncionario cfuncionario = new ClassFuncionario();

                //INSTANCIAR O FORMULÁRIO DE CADASTRO / ATUALIZAÇÃO DE funcionário PARA USAR OS CONTROLES DO FORM
                FormFuncionario ffuncionario = new FormFuncionario();

                if (MessageBox.Show("Deseja alterar o Funcionário selecionado?", "Sistema Papelaria Humanas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes && cfuncionario.ConsultarFuncionario(Convert.ToInt32(dataGridView_funcionario.SelectedRows[0].Cells[0].Value != null)))
                {

                    //PEGAR O CÓDIGO DO funcionário SELECIONADO PELO USUÁRIO NA GRID
                    cfuncionario.ConsultarFuncionario(Convert.ToInt32(dataGridView_funcionario.SelectedRows[0].Cells[0].Value));
                    ffuncionario.estado = cfuncionario.estado.ToString(); //(COMBO) PASSAR A VARIÁVEL DECLARADA NO FORMULÁRIO DE funcionário
                    ffuncionario.datacad = cfuncionario.data_cadastro_fun; //PASSAR A VARIÁVEL GLOBAL CRIADA NO FORM DE CADASTRO DE funcionários
                    ffuncionario.tipo_acesso = cfuncionario.tipo_acesso.ToString();
                    ffuncionario.cargo = cfuncionario.codigo_cargo;
                    ffuncionario.box_codigo_fun.Text = cfuncionario.codigo_funcionario.ToString();
                    ffuncionario.box_nome_funcionario.Text = cfuncionario.nome_funcionario.ToString();
                    ffuncionario.mask_RG.Text = cfuncionario.rg.ToString();
                    ffuncionario.mask_CPF.Text = cfuncionario.cpf.ToString();
                    ffuncionario.mask_nascimento_fun.Text = cfuncionario.data_nascimento.ToString();
                    ffuncionario.box_rua.Text = cfuncionario.rua.ToString();
                    ffuncionario.box_numero.Text = cfuncionario.numero.ToString();
                    ffuncionario.box_login.Text = cfuncionario.login.ToString();
                    ffuncionario.box_senha.Text = cfuncionario.senha.ToString();
                    ffuncionario.box_complemento.Text = cfuncionario.complemento.ToString();
                    ffuncionario.box_bairro.Text = cfuncionario.bairro.ToString();
                    ffuncionario.box_cidade.Text = cfuncionario.cidade.ToString();
                    ffuncionario.estado = cfuncionario.estado.ToString(); //(COMBO) PASSAR A VARIÁVEL DECLARADA NO FORMULÁRIO DE funcionário
                    ffuncionario.mask_cep.Text = cfuncionario.cep.ToString();
                    ffuncionario.box_email.Text = cfuncionario.email.ToString();
                    ffuncionario.mask_celular.Text = cfuncionario.telefone.ToString();

                    if (cfuncionario.sexo == "F")
                    {
                        ffuncionario.radio_feminino.Checked = true;
                    }
                    else
                    {
                        ffuncionario.radio_masculino.Checked = true;
                    }
                    if (cfuncionario.status == 1)
                    {

                        ffuncionario.check_ativo.Checked = true;
                    }

                    else
                    {
                        ffuncionario.check_ativo.Checked = false;
                    }
                    //MANDAR A INFORMAÇÃO DE UPDATE
                    ffuncionario.tipo = "Atualização";
                    //ABRIR O FORMULÁRIO DE CADASTRO EM MODO EXCLUSIVO
                    ffuncionario.ShowDialog();
                    //CHAMAR O MÉTODO DE PESQUISA
                    bt_pesquisar_Click(this, new EventArgs());


                }
                else
                {
                    MessageBox.Show("Por Favor Selecionar Um(a) Funcionario(a) Existente", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }

        }

        private void bt_sair_Click(object sender, EventArgs e)
        {
            if (combo_pesquisa_funcionario.SelectedIndex > 0)
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bt_ajuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta é a tela de Consulta de Funcionários, um local onde será consultado todos os Funcionários", "Sistema Papelaria Humanas", MessageBoxButtons.OK);
        }
    }
}
