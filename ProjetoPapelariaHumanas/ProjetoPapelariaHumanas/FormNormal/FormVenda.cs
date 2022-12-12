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
    public partial class formVenda43 : Form
    {
        public formVenda43()
        {
            InitializeComponent();
        }

        //CRIAR A LISTA QUE SERÁ USADA NA GRID DE PRODUTOS VENDIDOS
        private List<ClassItensVenda> ListaItensVenda = new List<ClassItensVenda>();

        //VARIAVEL PARA CALCULAR VALOR TOTAL DA VENDA
        private decimal vendaTotal = 0;

        //VARIAVEL PARA CONTAR QUANTAS LINHAS FORAM ADICIONADAS NA GRID DE VENDA
        private int ItensVenda = 0;


        private void formVenda43_Load(object sender, EventArgs e)
        {
            //CARREGAR COMBO ESTADO
            combo_estado.Items.Add("RJ");
            combo_estado.Items.Add("MG");
            combo_estado.Items.Add("GO");
            combo_estado.Items.Add("MT");
            combo_estado.Items.Add("MA");
            combo_estado.Items.Add("AC");
            combo_estado.Items.Add("AL");
            combo_estado.Items.Add("AP");
            combo_estado.Items.Add("AM");
            combo_estado.Items.Add("BA");
            combo_estado.Items.Add("CE");
            combo_estado.Items.Add("DF");
            combo_estado.Items.Add("ES");
            combo_estado.Items.Add("MS");
            combo_estado.Items.Add("PA");
            combo_estado.Items.Add("PB");
            combo_estado.Items.Add("PE");
            combo_estado.Items.Add("PÍ");
            combo_estado.Items.Add("RR");
            combo_estado.Items.Add("RO");
            combo_estado.Items.Add("RN");
            combo_estado.Items.Add("RS");
            combo_estado.Items.Add("SC");
            combo_estado.Items.Add("SE");
            combo_estado.Items.Add("SP");
            combo_estado.Items.Add("TO");
            combo_estado.SelectedIndex = 0;




            //COMBO FORMA DE PAGAMENTO
            cbFormaPagamento.Items.Add("Cartão de Crédito");
            cbFormaPagamento.Items.Add("Cartão de Débito");
            cbFormaPagamento.Items.Add("Dinheiro");
            cbFormaPagamento.Items.Add("Pix");
            cbFormaPagamento.SelectedIndex = -1;

            /// CARREGAR FUNCIONARIO
            /// 
            ///
            //CARRREGAR COMBO FUNCIONARIO
            ClassFuncionario cFuncionario = new ClassFuncionario();
            cbFuncionario.DataSource = cFuncionario.BuscarFuncionario();//executar método criado na classe categoria
            cbFuncionario.DisplayMember = "nome";//exibir na combo (nome)
            cbFuncionario.ValueMember = "codigo_Funcionario"; //guardar no BD (código)
            cbFuncionario.SelectedIndex = -1; //Limpar a combo (não seleciona nada - quando abrir o form

            //INICIAR O FORMULARIO DE VENDA SEM ENTREGA
            check_entrega.Checked = false;
            group_entrega.Enabled = false;


            //INICIAR O FORMULARIO DE VENDA SEM ESSES CAMPOS
            group_produto.Enabled = false;
            group_itens_venda.Enabled = false;
            
        }


        private void btBuscaCliente_Click(object sender, EventArgs e)
        {
            ClassCliente cCliente = new ClassCliente();

            if (string.IsNullOrEmpty(txtPesqCliente.Text))
            {
                MessageBox.Show("Por Favor Preencher o Campo", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            }
            else
            {
                dgvCliente.DataSource = cCliente.ConsultaClienteNomeContemVenda(txtPesqCliente.Text);


            }

        }

        private void btBuscaProduto_Click(object sender, EventArgs e)
        {
            ClassProduto cProduto = new ClassProduto();

            if (string.IsNullOrEmpty(txtPesqProduto.Text)&& dgvProduto.SelectedRows == null)
            {
                MessageBox.Show("Por Favor Preencher o Campo", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);               

            }
            else
            {
                dgvProduto.DataSource = cProduto.ConsultarProdutoNomeContemVenda(txtPesqProduto.Text);               

            }
        }

        private void txtQtde_TextChanged(object sender, EventArgs e)
        {
            if(txtQtde.Text == "")
            {
                MessageBox.Show("Favor Informar Uma Quantidade", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtQtde.Text = "01";
                txtQtde.SelectAll();

            }
            int qtdevendida = Convert.ToInt32(txtQtde.Text);
            int qtdeestoque = Convert.ToInt32(txtQtdeEstoque.Text);

            //VERIFICAR SE A QUANTIDADE VENDIDA É MAIOR QUE A QUANTIADE ESTOQUE 
            if(qtdevendida > qtdeestoque)
            {
                MessageBox.Show("A Quantidade Disponivel É De " + qtdeestoque + " Unidades! ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtQtde.Text = "01";
                txtQtde.SelectAll();

            }
            else
            {
                qtdevendida = Convert.ToInt32(txtQtde.Text);
                decimal valor = Convert.ToDecimal(txtValor.Text);
                txtTotal.Text = (qtdevendida * valor).ToString();

            }

        }

        private void dgvProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProduto.Rows.Count > 0)
            {
                ClassProduto cProduto = new ClassProduto();

                bool resp = cProduto.BuscarProduto(Convert.ToInt32(dgvProduto.SelectedRows[0].Cells[0].Value));

                if (dgvProduto.Rows[0].Cells[0].Value != null)
                {
                    if (resp == true)
                    {
                        txtProduto.Text = cProduto.Nome;
                        txtQtdeEstoque.Text = cProduto.Quantidade.ToString();
                        txtValor.Text = cProduto.Preco_Produto.ToString("n2");
                        txtQtde.Text = "01";
                        txtQtde_TextChanged(this, new EventArgs());
                        txtQtde.Select();
                    }

                    group_produto.Enabled = true;
                    group_itens_venda.Enabled = true;


                }
                else
                {
                    //PARA TER ACESSO AS SEGUINTES GROUPBOX APENAS QUANDO O CAMPO FOR PREENCHIDO
                    group_produto.Enabled = false;
                    group_itens_venda.Enabled = false;
                }

            }

        }


        //METODO QUE SERA USADO PELA GRID DE VENDA COM OS PRODUTOS VENDIDOS
        private void AtualizarGrid()
        {
            //INSTANCIAR CLASSE PRODUTO PARA PEGAR METODO QUE TRAZ O NOME DO PRODUTO 
            ClassProduto cProduto = new ClassProduto();

            //CRIAR UMA TABELA TEMPORARIA
            DataTable dt = new DataTable();

            //INSTANCIAR AS COLUNAS DA GRID 
            dt.Columns.Add(new DataColumn("Código"));
            dt.Columns.Add(new DataColumn("Produto"));
            dt.Columns.Add(new DataColumn("Quantidade"));
            dt.Columns.Add(new DataColumn("Valor"));

            //ADICIONAR AS LINHAS DA GRID
            foreach(ClassItensVenda item in ListaItensVenda)
            {
                dt.Rows.Add(item.codigo_produto, cProduto.BuscarNomeProdVenda(item.codigo_produto), item.quantidade, item.preco_venda);
                dt.AcceptChanges();

            }
            dgvItens.DataSource = dt;

        }


        private void btAddProduto_Click(object sender, EventArgs e)
        {
            //BOTÃO ADICIONAR PRODUTO
            ClassItensVenda cItensVenda = new ClassItensVenda();

            //SOMAR VALOR DO ITEM AO TOTAL DA VENDA
            decimal ValorItem = 0;

            //VERIFICAR SE ALGUM PRODUTO FOI SELECIONADO 
            if(txtTotal.Text =="")
            {
                MessageBox.Show(" Não há produto para ser inserido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
            }
            else
            {
                //SOMAR VALOR DO ITEM SELECIONADO AO TOTAL DA VENDA 
                ValorItem = Convert.ToDecimal(txtTotal.Text);
                vendaTotal = vendaTotal + ValorItem;
                txtValorTotal.Text = vendaTotal.ToString("n2");                
                //CONTAR ITENS DA VENDA (QTDE DE LINHAS DA GRID)
                ItensVenda++;

                //INFORMAÇÕES DOS PRODUTOS VENDIDDS
                cItensVenda.codigo_produto = Convert.ToInt32(dgvProduto.SelectedRows[0].Cells[0].Value);

                cItensVenda.quantidade = Convert.ToInt32(txtQtde.Text);

                cItensVenda.preco_venda = Convert.ToDecimal(txtTotal.Text);

                //ADICIONAR NA LISTA 
                ListaItensVenda.Add(cItensVenda);

                //PEGAR DA LISTA A QUANTIDADE DE ITENS 
                txtQtdeItens.Text = ItensVenda.ToString();
                txtQtdeItens.Text = ListaItensVenda.Count.ToString();

                //CHAMAR MÉTODO QUE CRIA A GRID DE PRODUTOS VENDIDOS
                AtualizarGrid();

                //LIMPAR OS CAMPOS DE PRODUTO APÓS ADICIONAR
                txtProduto.Clear();
                txtQtde.Text = "01";
                txtValor.Clear();
                txtTotal.Clear();
                txtQtdeEstoque.Clear();
                txtValorDesconto.Text = "0";
                txtTotalDesconto.Text = "0";
                txtValorDesconto.Select();

            }

        }


        //METODO LIMPAR - CHAMADO QUANDO VENDA FINALIZADA
        private void Limpar()
        {
            cbFuncionario.SelectedIndex = -1;
            txtPesqCliente.Clear();
            dgvCliente.DataSource = null;
            txtPesqProduto.Clear();
            dgvProduto.DataSource = null;
            box_rua.Clear();
            box_bairro.Clear();
            box_cidade.Clear();
            box_numero.Clear();
            box_complemento.Clear();
            mask_cep.Clear();
            combo_estado.SelectedIndex = -1;


            ListaItensVenda.Clear();
            AtualizarGrid();
            dgvItens.Refresh();

            txtValorTotal.Text = "0";
            txtTotalVenda.Text = "0";
            txtValorDesconto.Text = "0";
            txtTotalDesconto.Text = "0";

            txtQtdeItens.Clear();
            cbFormaPagamento.SelectedIndex = -1;
            vendaTotal = 0;

        }


        private void btRemoveProduto_Click(object sender, EventArgs e)
        {
            //VERIFICAR SE ALGUM PRODUTO FOI SELECIONADO 
            if (dgvItens.RowCount > 0)
            {
               if(MessageBox.Show("Deseja Remover o Produto Selecionado ?", "Sistema Papelaria Humanas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
               {
                    //RECALCULAR TOTAL DA VENDA 
                    //PEGAR O VALOR DO ITEM SLECIONADO PELO USUARIO
                    decimal valor = Convert.ToDecimal(dgvItens.SelectedRows[0].Cells[3].Value);
                    vendaTotal = vendaTotal - valor;
                    txtTotalVenda.Text = vendaTotal.ToString();
                    txtValorTotal.Text = vendaTotal.ToString();

                    //REMOVER O ITEM SELECIONADO DA LISTA E ATUALIZAR GRID
                    ListaItensVenda.RemoveAt(dgvItens.CurrentRow.Index);
                    AtualizarGrid();

                    //RECONTAR A LISTA DE PRODUTOS VENDIDOS
                    txtQtdeItens.Text = ListaItensVenda.Count.ToString();
                   

                }

            }
            else
            {
                MessageBox.Show(" Não há produto Selecionado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }       


        //METODO ATULIZAR ESTOQUE (FAZER CONTA PARA EXCLUIR DO ESTOQUE)
        private void CalcularEstoque(int qtde, int cod)
        {
            ClassProduto cProduto = new ClassProduto();
            cProduto.BuscarProduto(cod);
            int estoque = cProduto.Quantidade;
            cProduto.AtualizarQuantidadeVenda(estoque - qtde, cod);

        }

        private void btFechaVenda_Click(object sender, EventArgs e)
        {
            //VERIFICAR CAMPOS OBRIGATÓRIOS
            if(cbFuncionario.SelectedIndex != -1 && dgvCliente.DataSource != null && dgvItens.DataSource != null && cbFormaPagamento.SelectedIndex != -1)
            {
                ClassVenda cVenda = new ClassVenda();

                //MANDAR INFORMAÇÕES DA TABELA VENDA
                cVenda.valor_total = Convert.ToDecimal(txtTotalVenda.Text);
                cVenda.desconto = Convert.ToDecimal(txtTotalDesconto.Text);
                cVenda.codigo_cliente = Convert.ToInt32(dgvCliente.SelectedRows[0].Cells[0].Value);
                cVenda.codigo_funcionario = Convert.ToInt32(cbFuncionario.SelectedValue);
                cVenda.forma_pagamento = cbFormaPagamento.SelectedItem.ToString();
                cVenda.rua = box_rua.Text;
                cVenda.bairro = box_bairro.Text;
                cVenda.cidade = box_cidade.Text;
                if(box_numero.Text != "")
                {
                    cVenda.numero = Convert.ToInt32(box_numero.Text);
                }
                else
                {
                    cVenda.numero = 0;
                }
                cVenda.complemento = box_complemento.Text;
                if (mask_cep.Text != "")
                {
                    cVenda.cep = mask_cep.Text;
                }
                else
                {
                    cVenda.cep = null;
                }                
                cVenda.estado = combo_estado.SelectedItem.ToString();

                //CHAMAR MÉTODO CADASTRAR VENDA
                bool resp = cVenda.CadastroVenda();
                if(resp == true)
                {
                    foreach (ClassItensVenda item in ListaItensVenda)
                    {
                        item.codigo_venda = cVenda.codigo_venda;
                        resp = item.CadastroItemVenda();

                        //BAIXA ESTOQUE
                        CalcularEstoque(item.quantidade, item.codigo_produto);

                    }
                    if(resp == true)
                    {
                        MessageBox.Show("Venda Realizada Com Sucesso", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Limpar();

                    }

                }
                else
                {
                    MessageBox.Show("Erro ao Realizar Venda", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            else
            {
                MessageBox.Show("Por Favor Preencher Todos os Campos", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }








        }

        private void txtValorDesconto_TextChanged(object sender, EventArgs e)
        {

            if (txtValorDesconto.Text != "")
            {
                decimal Resultado = 0;
                decimal valorDesconto = Convert.ToDecimal(txtValorDesconto.Text);
                decimal valorTotal = Convert.ToDecimal(txtValorTotal.Text);

                Resultado = ((valorTotal * valorDesconto) / 100);
                Resultado = (valorTotal - Resultado);
                txtTotalDesconto.Text = Convert.ToString(Resultado);
                txtTotalVenda.Text = txtTotalDesconto.Text;
            }
            else 
            {
                MessageBox.Show("Por Favor Informar um Valor De Desconto", "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               
            }
            
        }

        private void bt_Sair_Click(object sender, EventArgs e)
        {
            if (txtTotalVenda.Text != "")
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

        private void check_entrega_CheckedChanged(object sender, EventArgs e)
        {
            if (check_entrega.Checked == true)
            {
                group_entrega.Enabled = true;

            }
            else
            {
                group_entrega.Enabled = false;

            }

        }

        private void mask_cep_Leave(object sender, EventArgs e)
        {
            try
            {
                CorreiosApi correios = new CorreiosApi();
                var retorno = correios.consultaCEP(mask_cep.Text);
                box_bairro.Text = retorno.bairro;
                box_rua.Text = retorno.end;
                box_cidade.Text = retorno.cidade;
                combo_estado.SelectedItem = retorno.uf;

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Consultar CEP: " + erro.Message, "Sistema Papelaria Humanas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void box_numero_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtQtde_KeyPress(object sender, KeyPressEventArgs e)
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

        private void bt_ajuda_Click(object sender, EventArgs e)
        {
           
                MessageBox.Show("Esta é a tela de Venda, um local onde será realizada a Venda", "Sistema Papelaria Humanas", MessageBoxButtons.OK);
                       
        }
    }
}
