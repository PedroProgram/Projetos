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
    public partial class FormConsultaMarca : Form
    {
        public FormConsultaMarca()
        {
            InitializeComponent();
        }

        
        private void bt_pesquisar_Click(object sender, EventArgs e)
        {
            //Instaciar a classe cliente para usar os métodos de consulta

            ClassMarca cMarca = new ClassMarca();

            //criar uma varíavel para receber a opção escolhida pelo usuário na combo

            string CONSULTA = combo_pesquisa_marca.SelectedItem.ToString();


            switch (CONSULTA)
            {
                case "Nome":
                    if (box_nome.Text != "")
                    {
                        if (radio_inicio.Checked == true)
                        {
                            dataGridView_pesquisa_marca.DataSource = cMarca.ConsultaMarcaNomeInicio(box_nome.Text);

                        }

                        else
                        {
                            dataGridView_pesquisa_marca.DataSource = cMarca.ConsultaMarcaNomeContem(box_nome.Text);

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
                        dataGridView_pesquisa_marca.DataSource = cMarca.ConsultaMarcaStatus(1);


                    }

                    else
                    {
                        dataGridView_pesquisa_marca.DataSource = cMarca.ConsultaMarcaStatus(0);


                    }
                    break;

            }

        }

        private void FormConsultaMarca_Load(object sender, EventArgs e)
        {
            combo_pesquisa_marca.Items.Add("Selecione uma Opção");
            combo_pesquisa_marca.Items.Add("Nome");
            combo_pesquisa_marca.Items.Add("Status");

            //DEIXAR UMA OPÇÃO SELECIONADA
            combo_pesquisa_marca.SelectedItem = "Selecione uma Opção";

            //DEIXAR CHECADO OS RADIOBUTTONS
            radio_inicio.Checked = true;
            radio_ativo.Checked = true;

        }

        private void bt_sair_Click(object sender, EventArgs e)
        {
            if (combo_pesquisa_marca.SelectedIndex > 0)
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

        private void dataGridView_pesquisa_marca_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_pesquisa_marca.Rows.Count > 0)
            {
                //CLICAR NA GRID DE CLIENTES E EDITAR OU EXCLUIR UM CLIENTE
                //USAR O EVENTO CLLCLICK (PODE CLICAR EM QUALQUER LUGAR DA CÉLULA, NÃO SOMENTE NO TEXTO)
                //USAR O EVENTO CLLCONTENT (TEM QUE CLICAR NO CONTEÚDO (TEXTO))

                //INSTANCIAR A CLASSE CLIENTE PARA USAR MÉTODOS E PROPRIEDADES
                ClassMarca cMarca = new ClassMarca();

                //INSTANCIAR O FORMULÁRIO DE CADASTRO / ATUALIZAÇÃO DE CLIENTE PARA USAR OS CONTROLES DO FORM
                FormMarca fMarca = new FormMarca();

                if (MessageBox.Show("Deseja Alterar a Marca Selecionada ?", "Sistema Papelaria Humanas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes && cMarca.ConsultarMarca(Convert.ToInt32(dataGridView_pesquisa_marca.SelectedRows[0].Cells[0].Value != null)))
                {

                    //PEGAR O CÓDIGO DO CLIENTE SELECIONADO PELO USUÁRIO NA GRID
                    cMarca.ConsultarMarca(Convert.ToInt32(dataGridView_pesquisa_marca.SelectedRows[0].Cells[0].Value));


                    //PASSAR OS DADOS DO BD PARA OS CONTROLES DO FORM DE CLIENTES
                    fMarca.Box_Cod_Marca.Text = cMarca.Codigo_Marca.ToString();
                    fMarca.datacad = cMarca.Data_Cadastro; //PASSAR A VARIÁVEL GLOBAL CRIADA NO FORM DE CADASTRO DE CLIENTES
                    fMarca.Box_Nome.Text = cMarca.Nome.ToString();
                    fMarca.Box_Observacao.Text = cMarca.Observacao.ToString();


                    if (cMarca.Status == 1)
                    {

                        fMarca.Check_Ativo.Checked = true;


                    }

                    else
                    {


                        fMarca.Check_Ativo.Checked = false;
                    }

                    //MANDAR A INFORMAÇÃO DE UPDATE
                    fMarca.tipo = "Atualização";
                    //ABRIR O FORMULÁRIO DE CADASTRO EM MODO EXCLUSIVO
                    fMarca.ShowDialog();
                    //CHAMAR O MÉTODO DE PESQUISA
                    bt_pesquisar_Click(this, new EventArgs());



                }
                else
                {
                    MessageBox.Show("Por Favor selecionar Uma Marca Existente", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }


        }

        private void combo_pesquisa_marca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_pesquisa_marca.SelectedIndex == 0)
            {
                group_status.Enabled = false;
                box_nome.Enabled = false;
                group_tipo_pesquisa.Enabled = false;

            }
            if (combo_pesquisa_marca.SelectedIndex == 1)
            {
                group_status.Enabled = false;
                box_nome.Enabled = true;
                group_tipo_pesquisa.Enabled = true;

            }
            if (combo_pesquisa_marca.SelectedIndex == 2)
            {

                group_status.Enabled = true;
                box_nome.Enabled = false;
                group_tipo_pesquisa.Enabled = false;
            }
        }

        private void bt_ajuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta é a tela de Consulta de Marca, um local onde será consultado todas as Marcas", "Sistema Papelaria Humanas", MessageBoxButtons.OK);
        }
    }
}
