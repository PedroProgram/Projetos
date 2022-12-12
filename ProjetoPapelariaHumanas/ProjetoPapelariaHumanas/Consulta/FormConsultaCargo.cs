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
    public partial class FormConsultarCargo : Form
    {
        public FormConsultarCargo()
        {
            InitializeComponent();
        }

        private void FormConsultarCargo_Load(object sender, EventArgs e)
        {
            combo_pesquisa_cargo.Items.Add("Selecione Uma Opção");
            combo_pesquisa_cargo.Items.Add("Status");
            combo_pesquisa_cargo.Items.Add("Nome");



            //DEIXAR UMA OPÇÃO SELECIONADA
            combo_pesquisa_cargo.SelectedIndex = 0;

            //DEIXAR CHECADO OS RADIOBUTTONS
            radio_inicio.Checked = true;
            radio_ativo.Checked = true;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_cargo.Rows.Count > 0)
            {
                //INSTANCIAR A CLASSE Cargo PARA USAR MÉTODOS E PROPRIEDADES
                ClassCargo cCargo = new ClassCargo();

                //INSTANCIAR O FORMULÁRIO DE CADASTRO / ATUALIZAÇÃO DE Cargo PARA USAR OS CONTROLES DO FORM
                FormCargo fcargo = new FormCargo();

                if (MessageBox.Show("Deseja alterar o cargo selecionado?", "Sistema Papelaria Humanas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes && cCargo.ConsultarCargo(Convert.ToInt32(dataGridView_cargo.SelectedRows != null)))
                {



                    //PEGAR O CÓDIGO DO Cargo SELECIONADO PELO USUÁRIO NA GRID
                    cCargo.ConsultarCargo(Convert.ToInt32(dataGridView_cargo.SelectedRows[0].Cells[0].Value));
                    fcargo.datacad = cCargo.Data_Cadastro; //PASSAR A VARIÁVEL GLOBAL CRIADA NO FORM DE CADASTRO DE CLIENTES
                    fcargo.box_observacao.Text = cCargo.Observacao.ToString();
                    fcargo.box_codigo_cargo.Text = cCargo.Codigo_Cargo.ToString();
                    fcargo.box_nome_cargo.Text = cCargo.Nome_Cargo.ToString();

                    if (cCargo.Status == 1)
                    {

                        fcargo.check_ativo.Checked = true;


                    }

                    else
                    {


                        fcargo.check_ativo.Checked = false;
                    }
                    //MANDAR A INFORMAÇÃO DE UPDATE
                    fcargo.tipo = "Atualização";
                    //ABRIR O FORMULÁRIO DE CADASTRO EM MODO EXCLUSIVO
                    fcargo.ShowDialog();
                    //CHAMAR O MÉTODO DE PESQUISA
                    bt_atualizar_Click(this, new EventArgs());

                }
                else
                {
                    MessageBox.Show("Por Favor Selecionar Um Cargo Existente", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }


        }

        private void combo_consulta_cargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ATIVAR E DESATIVAR OS ELEMENTOS DO FORM CONFROME A ESCOLHA DO USUÁRIO

            //Opção
            if (combo_pesquisa_cargo.SelectedIndex == 0)
            {
                box_nome_cargo.Enabled = false;
                groupBox_status.Enabled = false;
                groupBox_pesquisa.Enabled = false;




            }
            //Status
            if (combo_pesquisa_cargo.SelectedIndex == 1)
            {
                box_nome_cargo.Enabled = false;
                groupBox_status.Enabled = true;
                groupBox_pesquisa.Enabled = false;


            }

            //Nome
            if (combo_pesquisa_cargo.SelectedIndex == 2)
            {
                box_nome_cargo.Enabled = true;
                groupBox_status.Enabled = false;
                groupBox_pesquisa.Enabled = true;


            }


        }

        private void bt_atualizar_Click(object sender, EventArgs e)
        {
            //Instaciar a classe cliente para usar os métodos de consulta

            ClassCargo Ccargo = new ClassCargo();

            //criar uma varíavel para receber a opção escolhida pelo usuário na combo

            string CONSULTA = combo_pesquisa_cargo.SelectedItem.ToString();


            switch (CONSULTA)
            {
                case "Nome":
                    if (box_nome_cargo.Text != "")
                    {
                        if (radio_inicio.Checked == true)
                        {
                            dataGridView_cargo.DataSource = Ccargo.ConsultaCargoNomeInicio(box_nome_cargo.Text);




                        }

                        else
                        {
                            dataGridView_cargo.DataSource = Ccargo.ConsultaCargoNomeContem(box_nome_cargo.Text);

                        }

                    }
                    //Campo nome
                    else
                    {
                        MessageBox.Show("Favor informar um Nome", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;
                //Status
                case "Status":
                    if (radio_ativo.Checked == true)
                    {
                        dataGridView_cargo.DataSource = Ccargo.ConsultarCargoStatus(1);


                    }

                    else
                    {
                        dataGridView_cargo.DataSource = Ccargo.ConsultarCargoStatus(0);


                    }
                    break;

            }
        }

        private void bt_sair_Click(object sender, EventArgs e)
        {
            if (combo_pesquisa_cargo.SelectedIndex > 0)
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

        private void bt_ajuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta é a tela de Consulta de Cargo, um local onde será consultado todos os Cargos", "Sistema Papelaria Humanas", MessageBoxButtons.OK);
        }
    }
}
