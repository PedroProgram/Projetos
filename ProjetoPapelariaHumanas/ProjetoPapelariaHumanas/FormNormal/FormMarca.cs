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
    public partial class FormMarca : Form
    {
        public FormMarca()
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
            Box_Observacao.Clear();

        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (Box_Nome.Text != "" )
            {
                //PASSAR PARA PROPIEDADE DA CLASSE AS INFORMAÇÕE DIGITADAS PELO USUARIO NO FORMULARIO

                ClassMarca cMarca = new ClassMarca();

                cMarca.Nome = Box_Nome.Text;
                cMarca.Observacao = Box_Observacao.Text;

                //CHamar o metodo cadastrar da classe Fornecedor
                int resp = cMarca.cadastroMarca();

                //EXIBIR MENSAGEM DE CADASTRO REALIZADO 

                if(resp == 1)
                {
                    MessageBox.Show(Box_Nome.Text +  " Cadastrada(o) com Sucesso", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void bt_Atulizar_Click(object sender, EventArgs e)
        {
            if (Box_Nome.Text != "")
            {

                //PASSAR PARA AS PROPRIEDADES DA CLASSE AS INFORMÇÕES DIGITADAS PELO USUÁRIO NO FORMULÁRIO
                ClassMarca cMarca = new ClassMarca();
                cMarca.Nome = Box_Nome.Text;
                cMarca.Observacao = Box_Observacao.Text;
                               

                //status
                if (Check_Ativo.Checked == true)
                {
                    cMarca.Status = 1;
                }

                else
                {
                    cMarca.Status = 0;
                }
                cMarca.Codigo_Marca = Convert.ToInt32(Box_Cod_Marca.Text);


                //CHAMAR O MÉTODO CADASTRAR DA CLASSE Marca
                int resp = cMarca.AtualizarMarca();

                //EXIBIR MENSAGEM DE CADASTRO REALIZADO
                if (resp == 1)
                {
                    MessageBox.Show(Box_Nome.Text + " Atualizada(o) com Sucesso", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();


                }
                else
                {

                    MessageBox.Show("Erro ao realizar a atualização da(o) " + Box_Nome.Text +" ", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Error);


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

        private void bt_Excluir_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("deseja excluir Esta Marca ?", "Sistema Papelaria Humanas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ClassMarca cMarca = new ClassMarca();
                cMarca.Codigo_Marca = Convert.ToInt32(Box_Cod_Marca.Text);

                bool resp = cMarca.ExcluirMaca();
                if (resp == true)
                {
                    MessageBox.Show("Marca " + Box_Nome.Text + " Excluida(o) com Sucesso", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Esta Marca não pode ser excluida(o)", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                }



            }




        }

        private void FormMarca_Load(object sender, EventArgs e)
        {
            //QUANDO ABRIR O FORMULARIO PARA ATUALIZAR/EXCLUIR
            if (tipo == "Atualização")
            {
                label_marca.Text = "Atualização de Marca";
                Bt_Cadastrar.Enabled = false;
                Check_Ativo.Enabled = true;
                Box_Cod_Marca.Enabled = false;
                Lb_Data.Text = datacad.ToShortDateString();
            }
            else
            {
                bt_Atulizar.Enabled = false;
                bt_Excluir.Enabled = false;
                Check_Ativo.Checked = true;
                Check_Ativo.Enabled = false;
                Lb_Data.Text = DateTime.Now.ToShortDateString();
                lb_titulo_data.Text = "Data de Hoje :";
                Box_Cod_Marca.Enabled = false;
            }
        }

        private void bt_ajuda_Click(object sender, EventArgs e)
        {
            if (tipo != "Atualização")
            {
                MessageBox.Show("Esta é a tela de cadastro, um local onde será adicionado todas as Marcas", "Sistema Papelaria Humanas", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Esta é a tela de Atualização, um local onde será alterado todas as Marcas", "Sistema Papelaria Humanas", MessageBoxButtons.OK);
            }
        }
    }
}
