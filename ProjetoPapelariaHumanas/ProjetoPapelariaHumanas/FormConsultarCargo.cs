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
            combo_consulta_cargo.Items.Add("Status");
            combo_consulta_cargo.Items.Add("Nome");



            //Deixar a opção nome selecionada

            combo_consulta_cargo.SelectedItem = "Nome";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Deseja alterar o cargo selecionado?", "Sistema Papelaria Humanas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                //INSTANCIAR A CLASSE Cargo PARA USAR MÉTODOS E PROPRIEDADES
                ClassCargo cCargo = new ClassCargo();

                //INSTANCIAR O FORMULÁRIO DE CADASTRO / ATUALIZAÇÃO DE Cargo PARA USAR OS CONTROLES DO FORM
                FormCargocs fcargo = new FormCargocs();

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
        }

        private void combo_consulta_cargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ATIVAR E DESATIVAR OS ELEMENTOS DO FORM CONFROME A ESCOLHA DO USUÁRIO

            //staus
            if (combo_consulta_cargo.SelectedIndex == 0)
            {
                box_nome_cargo.Enabled = false;
                groupBox_status.Enabled = true;




            }
            //Nome
            if (combo_consulta_cargo.SelectedIndex == 1)
            {
                box_nome_cargo.Enabled = true;
                groupBox_status.Enabled = false;


            }
        }

        private void bt_atualizar_Click(object sender, EventArgs e)
        {
            //Instaciar a classe cliente para usar os métodos de consulta

            ClassCargo Ccargo = new ClassCargo();

            //criar uma varíavel para receber a opção escolhida pelo usuário na combo

            string CONSULTA = combo_consulta_cargo.SelectedItem.ToString();


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
            if (MessageBox.Show("Tem certeza que deseja fechar o formulário?", "Sistema Papelaria Humanas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
            {

                this.Close();
            }
        }
    }
}
