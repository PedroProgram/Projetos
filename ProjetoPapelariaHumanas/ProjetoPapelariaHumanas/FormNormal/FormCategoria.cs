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
    public partial class FormCategoria : Form
    {
        public FormCategoria()
        {
            InitializeComponent();
        }

        ////vARIÁVEL TIPO: GUARDAR COMO O FORMULÁRIO DEVE SER ABERTO SE PARA CADASTRO OU ATUALIZAÇÃO/EXCLUSÃO
        //VARI[ÁVEL ESTADO : INFORMAÇÃO É MOSTRADA EM UMA COMBO
        public String tipo;
        //VARIÁVEL DATACAD: MOSTRAR INFORMAÇÃO GUARDADA NO BD E NÃO DATA ATUAL COMO PROGRAMADO NO LOAD DO FORM 
        public DateTime datacad;

        private void limpar()
        {
            Box_Nome.Clear();
            
        }
               

        private void Bt_Cadastrar_Click(object sender, EventArgs e)
        {
            if(Box_Nome.Text != "")
            {
                //PASSAR PARA PROPIEDADE DA CLASSE AS INFORMAÇÕE DIGITADAS PELO USUARIO NO FORMULARIO

                ClassCategoria cCategoria = new ClassCategoria();

                cCategoria.nome = Box_Nome.Text;

                //CHamar o metodo cadastrar da classe Fornecedor
                int resp = cCategoria.cadastrarcategoria();

                //EXIBIR MENSAGEM DE CADASTRO REALIZADO 
                if (resp == 1)
                {
                    MessageBox.Show(Box_Nome.Text + " Cadastrada(o) com Sucesso", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    limpar();


                }
                else
                {
                    MessageBox.Show("Erro ao realizar o cadastro", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }


            }
            else //Validação de campos obrigatórios - CASO O USUARIO NÃO PREENCHER OS CAMPOS
            {
                //MOSTRAR ESSA MENSAGEM QUANDO O USUARIO NÃO PREENCHER OS CAMPOS OBRIGATÓRIOS

                MessageBox.Show("Por favor preencher todos os campos Obrigatórios!", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //COLOCAR COR NOS CAMPOS QUE NÃO FOR PREENCHIDOS

                Box_Nome.BackColor = Color.LightSteelBlue;
                Box_Nome.Focus();

            }

        }

        private void bt_Atualizar_Click(object sender, EventArgs e)
        {
           
            if (Box_Nome.Text != "" )
            {

                //PASSAR PARA AS PROPRIEDADES DA CLASSE AS INFORMÇÕES DIGITADAS PELO USUÁRIO NO FORMULÁRIO
                ClassCategoria cCategoria = new ClassCategoria();
                cCategoria.nome = Box_Nome.Text;
                

                //status
                if (Check_Ativo.Checked == true)
                {
                    cCategoria.status = 1;
                }

                else
                {
                    cCategoria.status = 0;
                }
                cCategoria.codigo_categoria = Convert.ToInt32(Box_Cod_Categoria.Text);


                //CHAMAR O MÉTODO CADASTRAR DA CLASSE Marca
                int resp = cCategoria.Atualizarcategoria();

                //EXIBIR MENSAGEM DE Atualização REALIZADO
                if (resp == 1)
                {
                    MessageBox.Show("categoria : " + Box_Nome.Text + " Atualizada(o) com Sucesso", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();

                }
                else
                {

                    MessageBox.Show("Erro ao realizar a atualização da" + Box_Nome.Text + " ", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }


            }
            else //Validação de campos obrigatórios - CASO O USUARIO NÃO PREENCHER OS CAMPOS
            {
                //MOSTRAR ESSA MENSAGEM QUANDO O USUARIO NÃO PREENCHER OS CAMPOS OBRIGATÓRIOS

                MessageBox.Show("Por favor preencher todos os campos Obrigatórios!", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //COLOCAR COR NOS CAMPOS QUE NÃO FOR PREENCHIDOS

                Box_Nome.BackColor = Color.LightSteelBlue;
                Box_Nome.Focus();

            }
        }

        private void bt_Excluir_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("deseja excluir Esta Categoria ?", "Sistema Papelaria Humanas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ClassCategoria cCategoria = new ClassCategoria();
                cCategoria.codigo_categoria = Convert.ToInt32(Box_Cod_Categoria.Text);

                bool resp = cCategoria.ExcluirCategoria();
                if (resp == true)
                {
                    MessageBox.Show("Categoria " + Box_Nome.Text + " Excluida(o) com Sucesso", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Esta Categoria não pode ser excluida", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                }



            }



        }

        private void bt_Sair_Click(object sender, EventArgs e)
        {
            if (Box_Nome.Text != "")
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

        private void FormCategoria_Load(object sender, EventArgs e)
        {
            //QUANDO ABRIR O FORMULARIO PARA ATUALIZAR/EXCLUIR
            if (tipo == "Atualização")
            {
                label_categoria.Text = "Atualização de Categoria";
                Bt_Cadastrar.Enabled = false;
                Check_Ativo.Enabled = true;
                Box_Cod_Categoria.Enabled = false;
                Lb_Data.Text = datacad.ToShortDateString();
                lb_titulo_data.Text = "Data Cadastro :";
            }
            else
            {
                Box_Cod_Categoria.Enabled = false;
                bt_Atualizar.Enabled = false;
                bt_Excluir.Enabled = false;
                Check_Ativo.Checked = true;
                Check_Ativo.Enabled = false;
                Lb_Data.Text = DateTime.Now.ToShortDateString();
                lb_titulo_data.Text = "Data de Hoje :";

            }
        }

        private void bt_ajuda_Click(object sender, EventArgs e)
        {
            if (tipo != "Atualização")
            {
                MessageBox.Show("Esta é a tela de cadastro, um local onde será adicionado todas as Categorias", "Sistema Papelaria Humanas", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Esta é a tela de Atualização, um local onde será alterado todas as Categorias", "Sistema Papelaria Humanas", MessageBoxButtons.OK);
            }
        }
    }
}
