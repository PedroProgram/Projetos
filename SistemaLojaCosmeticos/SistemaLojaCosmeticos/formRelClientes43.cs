using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLojaCosmeticos
{
    public partial class formRelClientes43 : Form
    {
        public formRelClientes43()
        {
            InitializeComponent();
        }

        private void formRelClientes43_Load(object sender, EventArgs e)
        {
            //CARREGAR COMBO TIPO DE RELATÓRIO
            cbTipoRel.Items.Add("Aniversariantes por Dia e Mês");
            cbTipoRel.Items.Add("Aniversariantes do Mês");
            cbTipoRel.Items.Add("Aniversariantes Data Completa");
            cbTipoRel.Items.Add("Aniversariantes Idade");
            cbTipoRel.Items.Add("Aniversariantes Maiores de");
            cbTipoRel.Items.Add("Cidade");
            cbTipoRel.Items.Add("Sexo");
            cbTipoRel.Items.Add("Status");
            cbTipoRel.SelectedIndex = 4;

            //CARREGAR COMBO MÊS
            cbMes.Items.Add("Escolha um Mês");
            cbMes.Items.Add("Janeiro");
            cbMes.Items.Add("Fevereiro");
            cbMes.Items.Add("Março");
            cbMes.Items.Add("Abril");
            cbMes.Items.Add("Maio");
            cbMes.Items.Add("Junho");
            cbMes.Items.Add("Julho");
            cbMes.Items.Add("Agosto");
            cbMes.Items.Add("Setembro");
            cbMes.Items.Add("Outubro");
            cbMes.Items.Add("Novembro");
            cbMes.Items.Add("Dezembro");
            cbMes.SelectedIndex = 0;

            //CARREGAR COMBO DIA
            cbDia.Items.Add("Escolha um Dia");
            cbDia.Items.Add("01");
            cbDia.Items.Add("02");
            cbDia.Items.Add("03");
            cbDia.Items.Add("04");
            cbDia.Items.Add("05");
            cbDia.Items.Add("06");
            cbDia.Items.Add("07");
            cbDia.Items.Add("08");
            cbDia.Items.Add("09");
            cbDia.Items.Add("10");
            cbDia.Items.Add("11");
            cbDia.Items.Add("12");
            cbDia.Items.Add("13");
            cbDia.Items.Add("14");
            cbDia.Items.Add("15");
            cbDia.Items.Add("16");
            cbDia.Items.Add("17");
            cbDia.Items.Add("18");
            cbDia.Items.Add("19");
            cbDia.Items.Add("20");
            cbDia.Items.Add("21");
            cbDia.Items.Add("22");
            cbDia.Items.Add("23");
            cbDia.Items.Add("24");
            cbDia.Items.Add("25");
            cbDia.Items.Add("26");
            cbDia.Items.Add("27");
            cbDia.Items.Add("28");
            cbDia.Items.Add("29");
            cbDia.Items.Add("30");
            cbDia.Items.Add("31");
            cbDia.SelectedIndex = 0;

            //CARREGAR COMBO SEXO
            cbSexo.Items.Add("Escolha um Sexo");
            cbSexo.Items.Add("Feminino");
            cbSexo.Items.Add("Masculino");
            cbSexo.SelectedIndex = 0;

            //CARREGAR COMBO DE CIDADE DO BANCO DE DADOS - TABELA CLIENTE
            classCliente cCliente = new classCliente();
            cbCidade.DataSource = cCliente.BuscarCidade(); // EXECUTAR MÉTODO DE CONSULTA CRIADO NA CLASSE CLIENTE
            cbCidade.DisplayMember = "Cidade"; // EXIBIR NA COMBO (CIDADE)
            cbCidade.ValueMember = "Cidade"; // GUARDAR NO BD (CIDADE)
            cbCidade.SelectedIndex = -1;
            this.reportViewer_cliente.RefreshReport();
        }

        private void cbTipoRel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoRel.SelectedIndex == 0) //Aniversariantes por dia e mês
            {
                gbAniversariantes.Enabled = true;
                cbDia.Enabled = true;
                cbMes.Enabled = true;
                dtpInicial.Enabled = false;
                dtpFinal.Enabled = false;
                gbIdade.Enabled = false;
                gbIdadeMaior.Enabled = false;
                gbStatus.Enabled = false;
                cbCidade.Enabled = false;
                cbSexo.Enabled = false;   
            }

            if (cbTipoRel.SelectedIndex == 1) //Aniversariantes do mês
            {
                gbAniversariantes.Enabled = true;
                cbDia.Enabled = false;
                cbMes.Enabled = true;
                dtpInicial.Enabled = false;
                dtpFinal.Enabled = false;
                gbIdade.Enabled = false;
                gbIdadeMaior.Enabled = false;
                gbStatus.Enabled = false;
                cbCidade.Enabled = false;
                cbSexo.Enabled = false;
            }

            if (cbTipoRel.SelectedIndex == 2) //Aniversariantes Data Completa
            {
                gbAniversariantes.Enabled = true;
                cbDia.Enabled = false;
                cbMes.Enabled = false;
                dtpInicial.Enabled = true;
                dtpFinal.Enabled = true;
                gbIdade.Enabled = false;
                gbIdadeMaior.Enabled = false;
                gbStatus.Enabled = false;
                cbCidade.Enabled = false;
                cbSexo.Enabled = false;
            }

            if (cbTipoRel.SelectedIndex == 3) //Aniversariantes Idade
            {
                gbAniversariantes.Enabled = false;
                gbIdade.Enabled = true;
                gbIdadeMaior.Enabled = false;
                gbStatus.Enabled = false;
                cbCidade.Enabled = false;
                cbSexo.Enabled = false;
            }

            if (cbTipoRel.SelectedIndex == 4) //Aniversariantes Maiores de 
            {
                gbAniversariantes.Enabled = false;
                gbIdade.Enabled = false;
                gbIdadeMaior.Enabled = true;
                gbStatus.Enabled = false;
                cbCidade.Enabled = false;
                cbSexo.Enabled = false;
            }

            if (cbTipoRel.SelectedIndex == 5) //Cidade
            {
                gbAniversariantes.Enabled = false;
                gbIdade.Enabled = false;
                gbIdadeMaior.Enabled = false;
                gbStatus.Enabled = false;
                cbCidade.Enabled = true;
                cbSexo.Enabled = false;
            }

            if (cbTipoRel.SelectedIndex == 6) //Sexo
            {
                gbAniversariantes.Enabled = false;
                gbIdade.Enabled = false;
                gbIdadeMaior.Enabled = false;
                gbStatus.Enabled = false;
                cbCidade.Enabled = false;
                cbSexo.Enabled = true;
            }

            if (cbTipoRel.SelectedIndex == 7) //Status
            {
                gbAniversariantes.Enabled = false;
                gbIdade.Enabled = false;
                gbIdadeMaior.Enabled = false;
                gbStatus.Enabled = true;
                cbCidade.Enabled = false;
                cbSexo.Enabled = false;
            }
        }

        private void btGerarRelatorio_Click(object sender, EventArgs e)
        {
            classCliente cCliente = new classCliente();

            string relatorio = cbTipoRel.SelectedItem.ToString();

             switch(relatorio)
            {
                case "Aniversariantes Idade":
                    if (txtIdadeInicial.Text != "" && txtIdadeFinal.Text != "")
                    {
                        classClienteBindingSource.DataSource = cCliente.RelClienteIdade(Convert.ToInt32(txtIdadeInicial.Text),Convert.ToInt32(txtIdadeFinal.Text)) ;
                        this.reportViewer_cliente.RefreshReport();


                    }
                    else
                    {
                        MessageBox.Show("Favor preencher as caixas de textos", "Ssitema Loja Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    break;

                case "Aniversariantes Maiores de":
                if(txtIdadeMaior.Text !="")
                {
                        classClienteBindingSource.DataSource = cCliente.RelClienteMaiorDe(Convert.ToInt32(txtIdadeMaior.Text));
                        this.reportViewer_cliente.RefreshReport();
                }

                else
                {
                        MessageBox.Show("Favor preencher as caixas de textos", "Ssitema Loja Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                    break;

                case "Cidade":
                    if(cbCidade.SelectedIndex != -1)
                    {
                        classClienteBindingSource.DataSource = cCliente.RelClienteCidade(cbCidade.SelectedValue.ToString());
                        this.reportViewer_cliente.RefreshReport();


                    }
                    else
                    {
                        MessageBox.Show("Favor escolher uma cidade", "Ssitema Loja Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                    }
                    break;



            }


        }
    }
}
