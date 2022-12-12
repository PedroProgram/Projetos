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
    public partial class FormConsultaCategoria : Form
    {
        public FormConsultaCategoria()
        {
            InitializeComponent();
        }

        ////vARIÁVEL TIPO: GUARDAR COMO O FORMULÁRIO DEVE SER ABERTO SE PARA CADASTRO OU ATUALIZAÇÃO/EXCLUSÃO
        
        public String tipo;

        private void bt_sair_Click(object sender, EventArgs e)
        {
            if (combo_pesquisa_categoria.SelectedIndex > 0)
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

        private void bt_pesquisar_Click(object sender, EventArgs e)
        {
            //Instaciar a classe cliente para usar os métodos de consulta

            ClassCategoria cCategoria = new ClassCategoria();

            //criar uma varíavel para receber a opção escolhida pelo usuário na combo

            string CONSULTA = combo_pesquisa_categoria.SelectedItem.ToString();


            switch (CONSULTA)
            {
                case "Nome":
                    if (box_nome.Text != "")
                    {
                        if (radio_inicio.Checked == true)
                        {
                            dataGridView_pesquisa_categoria.DataSource = cCategoria.ConsultaCategoriaNomeInicio(box_nome.Text);

                        }

                        else
                        {
                            dataGridView_pesquisa_categoria.DataSource = cCategoria.ConsultaCategoriaNomeContem(box_nome.Text);

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
                        dataGridView_pesquisa_categoria.DataSource = cCategoria.ConsultaCategoriaStatus(1);


                    }

                    else
                    {
                        dataGridView_pesquisa_categoria.DataSource = cCategoria.ConsultaCategoriaStatus(0);


                    }
                    break;


            }
        }

        private void FormConsultaCategoria_Load(object sender, EventArgs e)
        {
            combo_pesquisa_categoria.Items.Add("selecione uma opção");
            combo_pesquisa_categoria.Items.Add("Nome");
            combo_pesquisa_categoria.Items.Add("Status");

            //DEIXAR UMA OPÇÃO SELECIONADA
            combo_pesquisa_categoria.SelectedItem = "selecione uma opção";

            //DEIXAR CHECADO OS RADIOSBUTTONS
            radio_inicio.Checked = true;
            radio_ativo.Checked = true;

        }

        private void dataGridView_pesquisa_categoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_pesquisa_categoria.Rows.Count > 0)
            {
                //CLICAR NA GRID DE Categoria E EDITAR OU EXCLUIR UMA CATEGORIA
                //USAR O EVENTO CLLCLICK (PODE CLICAR EM QUALQUER LUGAR DA CÉLULA, NÃO SOMENTE NO TEXTO)
                //USAR O EVENTO CLLCONTENT (TEM QUE CLICAR NO CONTEÚDO (TEXTO))


                //INSTANCIAR A CLASSE CLIENTE PARA USAR MÉTODOS E PROPRIEDADES
                ClassCategoria cCategoria = new ClassCategoria();

                //INSTANCIAR O FORMULÁRIO DE CADASTRO / ATUALIZAÇÃO DE CLIENTE PARA USAR OS CONTROLES DO FORM
                FormCategoria fCategoria = new FormCategoria();

                if (MessageBox.Show("Deseja Alterar a Categoria Selecionada ?", "Sistema Papelaria Humanas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {


                    //PEGAR O CÓDIGO DO CLIENTE SELECIONADO PELO USUÁRIO NA GRID
                    cCategoria.ConsultarCategoria(Convert.ToInt32(dataGridView_pesquisa_categoria.SelectedRows[0].Cells[0].Value));


                    //PASSAR OS DADOS DO BD PARA OS CONTROLES DO FORM DE CLIENTES
                    fCategoria.Box_Cod_Categoria.Text = cCategoria.codigo_categoria.ToString();
                    fCategoria.datacad = cCategoria.data_cadastro; //PASSAR A VARIÁVEL GLOBAL CRIADA NO FORM DE CADASTRO DE CLIENTES
                    fCategoria.Box_Nome.Text = cCategoria.nome.ToString();

                    if (cCategoria.status == 1)
                    {

                        fCategoria.Check_Ativo.Checked = true;


                    }

                    else
                    {


                        fCategoria.Check_Ativo.Checked = false;
                    }

                    //MANDAR A INFORMAÇÃO DE UPDATE
                    fCategoria.tipo = "Atualização";
                    //ABRIR O FORMULÁRIO DE CADASTRO EM MODO EXCLUSIVO
                    fCategoria.ShowDialog();
                    //CHAMAR O MÉTODO DE PESQUISA
                    bt_pesquisar_Click(this, new EventArgs());



                }
                else
                {
                    MessageBox.Show("Por Favor Selecionar Uma Categoria Existente", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }



        }

        private void combo_pesquisa_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_pesquisa_categoria.SelectedIndex == 0)
            {
                group_status.Enabled = false;
                box_nome.Enabled = false;
                group_tipo_pesquisa.Enabled = false;

            }
            if (combo_pesquisa_categoria.SelectedIndex == 1)
            {
                group_status.Enabled = false;
                box_nome.Enabled = true;
                group_tipo_pesquisa.Enabled = true;

            }
            if(combo_pesquisa_categoria.SelectedIndex == 2)
            {

                group_status.Enabled = true;
                box_nome.Enabled = false;
                group_tipo_pesquisa.Enabled = false;
            }

        }

        private void bt_ajuda_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Esta é a tela de Consulta de categoria, um local onde será consultado todas as Categorias", "Sistema Papelaria Humanas", MessageBoxButtons.OK); 
            
           
        }
    }
}
