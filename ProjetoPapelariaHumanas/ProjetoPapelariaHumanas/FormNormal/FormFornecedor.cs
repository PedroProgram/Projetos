using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Correios;

namespace ProjetoPapelariaHumanas
{
    public partial class FormFornecedor : Form
    {
        public FormFornecedor()
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
            Mask_Telefone.Clear();
            Box_Rua.Clear();
            Mask_Cep.Clear();
            Box_Bairro.Clear();
            Box_Cidade.Clear();
            Mask_Cnpj.Clear();

        }






        private void bt_Cadastrar_Click(object sender, EventArgs e)
        {
            if ( Box_Nome.Text != "" && Box_Rua.Text != "" && Box_Bairro.Text != "" && Box_Cidade.Text != "" && Mask_Cnpj.Text != "" )
            {
                //PASSAR PARA PROPIEDADE DA CLASSE AS INFORMAÇÕE DIGITADAS PELO USUARIO NO FORMULARIO

                ClassFornecedor cFornecedor = new ClassFornecedor();
                cFornecedor.nome = Box_Nome.Text;
                cFornecedor.telefone = Mask_Telefone.Text;
                cFornecedor.rua = Box_Rua.Text;
                cFornecedor.cep = Mask_Cep.Text;
                cFornecedor.bairro = Box_Bairro.Text;
                cFornecedor.cidade = Box_Cidade.Text;
                cFornecedor.cnpj = Mask_Cnpj.Text;

                //CHamar o metodo cadastrar da classe Fornecedor
                int resp = cFornecedor.cadastrofornecedor();

                //EXIBIR MENSAGEM DE CADASTRO REALIZADO 
                if(resp == 1)
                {
                    MessageBox.Show( Box_Nome.Text + " Cadastradada(o) com Sucesso", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    limpar();

                }
                else
                {
                    MessageBox.Show("Erro ao realizar o cadastro", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else //Validação de campos obrigatórios - CASO O USUARIO NÃO PREENCHER OS CAMPOS

            { //MOSTRAR ESSA MENSAGEM QUANDO O USUARIO NÃO PREENCHER OS CAMPOS OBRIGATÓRIOS

                MessageBox.Show ("Por favor preencher todos os campos Obrigatórios!", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //COLOCAR COR NOS CAMPOS QUE NÃO FOR PREENCHIDOS
                Box_Nome.BackColor = Color.LightSteelBlue;
                Box_Rua.BackColor = Color.LightSteelBlue;
                Box_Bairro.BackColor = Color.LightSteelBlue;
                Box_Cidade.BackColor = Color.LightSteelBlue;
                Mask_Cnpj.BackColor = Color.LightSteelBlue;
                Box_Nome.Focus();

            }

        }

        private void bt_Sair_Click(object sender, EventArgs e)
        {
            if (Box_Nome.Text != "" && Box_Rua.Text != "" && Box_Bairro.Text != "" && Box_Cidade.Text != "" && Mask_Cnpj.Text != "")
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

        private void bt_Atualizar_Click(object sender, EventArgs e)
        {
             if (Box_Nome.Text != "" && Box_Rua.Text != "" && Box_Bairro.Text != "" && Box_Cidade.Text != "" && Mask_Cnpj.Text != "")
            {
                //PASSAR PARA PROPIEDADE DA CLASSE AS INFORMAÇÕE DIGITADAS PELO USUARIO NO FORMULARIO

                ClassFornecedor cFornecedor = new ClassFornecedor();
                cFornecedor.nome = Box_Nome.Text;
                cFornecedor.telefone = Mask_Telefone.Text;
                cFornecedor.rua = Box_Rua.Text;
                cFornecedor.cep = Mask_Cep.Text;
                cFornecedor.bairro = Box_Bairro.Text;
                cFornecedor.cidade = Box_Cidade.Text;
                cFornecedor.cnpj = Mask_Cnpj.Text;
                
                //status
                if (Check_Ativo.Checked == true)
                {
                    cFornecedor.status = 1;
                }
                else
                {
                    cFornecedor.status = 0;
                }

                cFornecedor.codigo_fornecedor = Convert.ToInt32(Box_Cod_Fornecedor.Text);

                //Chamar o metodo atualizar da classe Fornecedor
                int resp = cFornecedor.AtualizarFornecedor();

                //EXIBIR MENSAGEM DE CADASTRO REALIZADO 
                if (resp == 1 )
                {
                    MessageBox.Show(Box_Nome.Text+ " Atualizada(o) com Sucesso", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();


                }
                else
                {
                    MessageBox.Show("Erro ao Atualizar", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }





             }
             else //Validação de campos obrigatórios - CASO O USUARIO NÃO PREENCHER OS CAMPOS

             { //MOSTRAR ESSA MENSAGEM QUANDO O USUARIO NÃO PREENCHER OS CAMPOS OBRIGATÓRIOS

                MessageBox.Show("Por favor preencher todos os campos Obrigatórios!", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //COLOCAR COR NOS CAMPOS QUE NÃO FOR PREENCHIDOS
                Box_Nome.BackColor = Color.LightSteelBlue;
                Box_Rua.BackColor = Color.LightSteelBlue;
                Box_Bairro.BackColor = Color.LightSteelBlue;
                Box_Cidade.BackColor = Color.LightSteelBlue;
                Mask_Cnpj.BackColor = Color.LightSteelBlue;
                Box_Nome.Focus();

            }




        }

        private void bt_Excluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show ("deseja excluir o Fornecedor ?" , "Sistema Papelaria Humanas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ClassFornecedor cFornecedor = new ClassFornecedor();
                cFornecedor.codigo_fornecedor = Convert.ToInt32(Box_Cod_Fornecedor.Text);

                bool resp = cFornecedor.ExcluirFornecedor();
                if(resp == true)
                {
                    MessageBox.Show("Fornecedor " + Box_Nome.Text + " Excluida(o) com Sucesso", "Sistema Papelari Humanas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Este Fornecedor não pode ser excluido", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                }



            }




        }

        private void FormFornecedor_Load(object sender, EventArgs e)
        {
            //QUANDO ABRIR O FORMULARIO PARA ATUALIZAR/EXCLUIR
            if (tipo == "Atualização")
            {
                label_fornecedor.Text = "Atualização de Fornecedor";
                bt_Cadastrar.Enabled = false;
                Check_Ativo.Enabled = true;
                Box_Cod_Fornecedor.Enabled = false;
                Lb_Data.Text = datacad.ToShortDateString();
            }
            else
            {
                Box_Cod_Fornecedor.Enabled = false;
                bt_Atualizar.Enabled = false;
                bt_Excluir.Enabled = false;
                Check_Ativo.Checked = true;
                Lb_Data.Text = DateTime.Now.ToShortDateString();
                lb_titulo_data.Text = "Data de Hoje :";
            }
        }

        private void Mask_Cep_Leave(object sender, EventArgs e)
        {
            try
            {
                CorreiosApi correios = new CorreiosApi();
                var retorno = correios.consultaCEP(Mask_Cep.Text);
                Box_Bairro.Text = retorno.bairro;
                Box_Rua.Text = retorno.end;
                Box_Cidade.Text = retorno.cidade;
                
            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro ao Consultar CEP: " + erro.Message, "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }






        }

        private void bt_ajuda_Click(object sender, EventArgs e)
        {
            if (tipo != "Atualização")
            {
                MessageBox.Show("Esta é a tela de cadastro, um local onde será adicionado todos os Fornecedores", "Sistema Papelaria Humanas", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Esta é a tela de Atualização, um local onde será alterado todos os Fornecedores", "Sistema Papelaria Humanas", MessageBoxButtons.OK);
            }
        }
    }
}
