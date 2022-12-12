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
    public partial class FormProduto : Form
    {
        public FormProduto()
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
            Box_Nome.Clear();
            Box_Quantidade.Clear();
            Box_Preco.Clear();
            Cb_Cod_Categoria.SelectedIndex = -1;
            Cb_Cod_Marca.SelectedIndex = -1;            
            Cb_Cod_Fornecedor.SelectedIndex = -1;

        }

        private void Bt_Cadastrar_Click(object sender, EventArgs e)
        {
            //VERIFICAR CAMPOS OBRIGATORIOS 
            //PREENCHER PELO MENOS UM TELEFONE

            if (Box_Nome.Text != "" && Box_Quantidade.Text != "" && Box_Preco.Text != "" )
            {
                // PASSAR PARA AS PROPIEDADES DA CLASSE AS INFORMAÇÕES DIGITADAS PELO USUARIO NO FORMULÁRIO
                ClassProduto cProduto = new ClassProduto();
                cProduto.Nome = Box_Nome.Text;
                cProduto.Quantidade = Convert.ToInt32(Box_Quantidade.Text);
                cProduto.Preco_Produto = Convert.ToDecimal(Box_Preco.Text);
                cProduto.Codigo_Categoria = Convert.ToInt32 (Cb_Cod_Categoria.SelectedValue);
                cProduto.Codigo_Marca = Convert.ToInt32(Cb_Cod_Marca.SelectedValue); 
                cProduto.Codigo_Fornecedor = Convert.ToInt32(Cb_Cod_Fornecedor.SelectedValue);

                        

                //CHAMAR O METODO CADASTRAR DA CLASSE CLIENTE 
                int resp = cProduto.cadastro_produto();


                //EXIBIR MENSAGEM DE CADASTRO REALIZADO 

                if (resp == 1)
                {

                    MessageBox.Show("Produto "  + Box_Nome.Text + " cadastrada(o) Com Sucesso", " Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    limpar();

                }
                else
                {
                    MessageBox.Show("Erro ao Atualizar", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else //VALIDAÇÃO DE CAMPOS OBRIGATORIOS - CASO O USUARIO NÃO PREECHER OS CAMPOS 
            { //MOSTRAR ESSA MENSAGEM QUANDO O USUARIO NÃO PREENCHER OS CAMPOS OBRIGATÓRIOS

                MessageBox.Show ("Por Favor Preencher Todos Os Campos Obrigatórios", "Sistema Papelaria Humanas",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                Box_Nome.BackColor = Color.LightSteelBlue;
                Box_Quantidade.BackColor = Color.LightSteelBlue;
                Box_Preco.BackColor = Color.LightSteelBlue;
                Box_Nome.Focus();




            }


        }

        private void FormProduto_Load(object sender, EventArgs e)
        {
            //QUANDO ABRIR O FORMULARIO PARA ATUALIZAR/EXCLUIR
            if (tipo == "Atualização")
            {
                label_produto.Text = "Atualização de Produto";
                Bt_Cadastrar.Enabled = false;
                Check_Status.Enabled = true;
                Check_Status.Checked = true;
                Box_Cod_Produto.Enabled = false;
                lb_data.Text = datacad.ToShortDateString();
            }
            else
            {
                Box_Cod_Produto.Enabled = false;
                bt_Atulizar.Enabled = false;
                bt_Excluir.Enabled = false;
                Check_Status.Checked = true;
                Check_Status.Enabled = false;
                lb_data.Text = DateTime.Now.ToShortDateString();
                lb_data_titulo.Text = "Data de Hoje :";
            }


            //CARREGAR COMBO CATEGORIA
            

            ClassCategoria cCategoria = new ClassCategoria();            
            Cb_Cod_Categoria.DataSource = cCategoria.BuscarCategoria(); //EXECUTAR MÉTODO CRIADO NA CLASSE CATEGORIA           
            Cb_Cod_Categoria.DisplayMember = "nome"; //EXIBIR NA COMBO (NOME)
            Cb_Cod_Categoria.ValueMember = "codigo_categoria"; //GUARDAR NO BD (CODIGO)            
            Cb_Cod_Categoria.SelectedIndex = -1; //LIMPAR A COMBO (NÃO SELECIONAR NADA - QUANDO ABRIR O FORM)

            ////

            //CARREGAR COMBO MARCA
            

            ClassMarca cMarca = new ClassMarca();
            Cb_Cod_Marca.DataSource = cMarca.BuscarMarca(); //EXECUTAR MÉTODO CRIADO NA CLASSE MARCA            
            Cb_Cod_Marca.DisplayMember = "nome_marca"; //EXIBIR NA COMBO (NOME DA MARCA)
            Cb_Cod_Marca.ValueMember = "codigo_marca"; // GUARDAR NO BD (CODIGO DA MARCA)            
            Cb_Cod_Marca.SelectedIndex = -1; // LIMPAR A COMBO (NÃO SELECIONAR NADA - QUANDO ABRIR O FORM)

            ////

            //CARREGAR COMBO FORNECEDOR
            

            ClassFornecedor cFornecedor = new ClassFornecedor();
            Cb_Cod_Fornecedor.DataSource = cFornecedor.BuscarFornecedor(); // EXECUTA METODO CRIADO NA CLASSE MARCA           
            Cb_Cod_Fornecedor.DisplayMember = "nome"; //EXIBIR NA COMBO (NOME DO FORNECEDOR)
            Cb_Cod_Fornecedor.ValueMember = "codigo_fornecedor"; // GUARDAR NO BD (CODIGO DO FORNECEDOR)
            Cb_Cod_Fornecedor.SelectedIndex = -1; // LIMPAR A COMBO (NÃO SELECIONAR NADA - QUANDO ABRIR O FORM)
            
        }

        private void bt_Sair_Click(object sender, EventArgs e)
        {
            if (Box_Nome.Text != "" && Box_Quantidade.Text != "" && Box_Preco.Text != "")
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

        private void bt_Atulizar_Click(object sender, EventArgs e)
        {
            //VERIFICAR CAMPOS OBRIGATORIOS 
            //PREENCHER PELO MENOS UM TELEFONE

            if (Box_Nome.Text != "" && Box_Quantidade.Text != "" && Box_Preco.Text != "")
            {
                // PASSAR PARA AS PROPIEDADES DA CLASSE AS INFORMAÇÕES DIGITADAS PELO USUARIO NO FORMULÁRIO
                ClassProduto cProduto = new ClassProduto();
                cProduto.Codigo_Produto = Convert.ToInt32(Box_Cod_Produto.Text);
                cProduto.Nome = Box_Nome.Text;
                cProduto.Quantidade = Convert.ToInt32(Box_Quantidade.Text);
                cProduto.Preco_Produto = Convert.ToDecimal(Box_Preco.Text);
                cProduto.Codigo_Categoria = Convert.ToInt32(Cb_Cod_Categoria.SelectedValue);
                cProduto.Codigo_Marca = Convert.ToInt32(Cb_Cod_Marca.SelectedValue);
                cProduto.Codigo_Fornecedor = Convert.ToInt32(Cb_Cod_Fornecedor.SelectedValue);

                //status
                if (Check_Status.Checked == true)
                {
                    cProduto.status = 1;
                }

                else
                {
                    cProduto.status = 0;
                }
                cProduto.Codigo_Produto = Convert.ToInt32(Box_Cod_Produto.Text);


                //CHAMAR O METODO CADASTRAR DA CLASSE CLIENTE 
                int resp = cProduto.AtualizarPRoduto();


                //EXIBIR MENSAGEM DE CADASTRO REALIZADO 

                if (resp == 1)
                {

                    MessageBox.Show("Produto " + Box_Nome.Text + " Atualizada(o) Com Sucesso", " Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Erro ao Atualizar", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else //VALIDAÇÃO DE CAMPOS OBRIGATORIOS - CASO O USUARIO NÃO PREECHER OS CAMPOS 
            { //MOSTRAR ESSA MENSAGEM QUANDO O USUARIO NÃO PREENCHER OS CAMPOS OBRIGATÓRIOS

                MessageBox.Show("Por Favor Preencher Todos Os Campos Obrigatórios", "Sistema Papelaria Humanas",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                Box_Nome.BackColor = Color.LightSteelBlue;
                Box_Quantidade.BackColor = Color.LightSteelBlue;
                Box_Preco.BackColor = Color.LightSteelBlue;
                Box_Nome.Focus();



            }


        }

        private void bt_Excluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("deseja excluir este Produto ?", "Sistema Papelaria Humanas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ClassProduto cProduto = new ClassProduto();
                cProduto.Codigo_Produto = Convert.ToInt32(Box_Cod_Produto.Text);

                bool resp = cProduto.ExcluirProduto();
                if (resp == true)
                {
                    MessageBox.Show("Produto " + Box_Nome.Text + " Excluida(o) com Sucesso", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Esta Produto não pode ser excluido", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                }



            }

        }

        private void Box_Quantidade_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Box_Preco_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número, backspace(08), enter(13) e espaço(32)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 32 && e.KeyChar != ',')
            {    //see o usuário pressionar uma tecla não numérica no textbox, cancela o evento key press

                e.Handled = true;
                MessageBox.Show("Este Campo Aceita Apenas Números E Vírgulas", "Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {

            }
        }

        private void bt_ajuda_Click(object sender, EventArgs e)
        {
            if (tipo != "Atualização")
            {
                MessageBox.Show("Esta é a tela de cadastro, um local onde será adicionado todos os Produtos", "Sistema Papelaria Humanas", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Esta é a tela de Atualização, um local onde será alterado todos os Produtos", "Sistema Papelaria Humanas", MessageBoxButtons.OK);
            }
        }
    }
}
