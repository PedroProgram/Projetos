using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace SistemaLojaCosmeticos
{
    class classCliente
    {
        //CONSTRUTOR DA CLASSE
        //SERVE PARA INICIALIZAR TODAS AS VARIAVEIS E PROPRIEDADES
        //PRECISA TER O MESMO NOME DA CLASSE
        public classCliente()
        {
            CodigoCliente = 0;
            DataCadastro = DateTime.Now;
            NomeCliente = null;
            RG = null;
            CPF = null;
            DataNascimento = DateTime.Now;
            Sexo = null;
            Rua = null;
            Numero = 0;
            Complemento = null;
            Bairro = null;
            Cidade = null;
            Estado = null;
            CEP = null;
            Email = null;
            TelefoneResidencial = null;
            TelefoneCelular = null;
            Status = 0;

        }

        //PROPRIEDADES 
        //SERVE PARA LER E GRAVAR AS INFORMAÇÕES 
        //ATALHO PARA CRIAR AS PROPRIEDADES

        public int CodigoCliente { get; set; }
        public DateTime DataCadastro { get; set; }

        public string NomeCliente { get; set; }

        public string RG { get; set; }

        public string CPF { get; set; }

        public DateTime DataNascimento { get; set; }

        public string Sexo { get; set; }

        public string Rua { get; set; }

        public int Numero { get; set; }

        public string Complemento { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        public string CEP { get; set; }

        public string Email { get; set; }

        public string TelefoneResidencial { get; set; }

        public string TelefoneCelular { get; set; }

        public int Status { get; set; }


        //CRIAÇÃO DOS MÉTODOS (fUNCIONALIDADE DO SISTEMA)
        //CADASTRO - CONSULTA - ATUALIZAÇÃO - EXCLUSÃO
        //MÉTODO : TIPO MÉTODO - TIPO RETORNO - NOME DO MÉTODO - PARÂMETROS
        //MÉTODO CRIAR CLIENTE 

        public int cadastro_cliente()
        {

            string query = "INSERT INTO cliente values(0, now(), '" + NomeCliente + "', '" + RG + "', '" + CPF + "', '" + DataNascimento.ToString("yyyy-MM-dd") + "','"+Sexo+"', '"+Rua+"', "+Numero+", '"+Complemento+"', '"+Bairro+"', '"+Cidade+"', '"+Estado+"', '"+CEP+"', '"+Email+"', '"+TelefoneResidencial+"', '"+TelefoneCelular+"', 1 )";

            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQuery(query);


        }


        //Metodos de consulta
        //consulta de cliente por nome - inicio e contem, cpf, sexo
        //Campos exibidos na consulta: CodigoCliente, NomeCliente, CPF,DataNascimento, sexo, Telefone

        //Consulta de cliente por nome - inicio

        public DataTable ConsultaClienteNomeInicio(string nomei)
        {
            string query = "select CodigoCliente, NomeCliente, CPF, DataNascimento, Sexo, TelefoneCelular FROM cliente WHERE Status = 1 and NomeCliente like '"+ nomei + "%' ORDER by NomeCliente";

            classConexao cconexao = new classConexao();
            return cconexao.RetornaDataTable(query);

             
        }
        //Consulta de cliente por nome - contém

        public DataTable ConsultaClienteNomeContem(string nomec)
        {
            string query = "select CodigoCliente, NomeCliente, CPF, DataNascimento, Sexo, TelefoneCelular FROM cliente WHERE Status = 1 and NomeCliente like '%" + nomec + "%' ORDER by NomeCliente";

            classConexao cconexao = new classConexao();
            return cconexao.RetornaDataTable(query);


        }
        //Consulta de cliente por nome - CPF
        public DataTable ConsultaClienteCPF(string CPF)
        {
            string query = "select CodigoCliente, NomeCliente, CPF, DataNascimento, Sexo, TelefoneCelular FROM cliente WHERE Status = 1 and CPF = '" + CPF + "' ORDER by NomeCliente";

            classConexao cconexao = new classConexao();
            return cconexao.RetornaDataTable(query);


        }
        //Consulta de cliente por nome - Sexo
        public DataTable ConsultaClienteSexo(string Sexo)
        {
            string query = "select CodigoCliente, NomeCliente, CPF, DataNascimento, Sexo, TelefoneCelular FROM cliente WHERE Status = 1 and Sexo = '" + Sexo + "' ORDER by NomeCliente";

            classConexao cconexao = new classConexao();
            return cconexao.RetornaDataTable(query);


        }
        //Consulta de cliente por nome - Status
        public DataTable ConsultaClienteStatus(int Status)
        {
            string query = "select CodigoCliente, NomeCliente, CPF, DataNascimento, Sexo, TelefoneCelular FROM cliente WHERE Status = " + Status + " ORDER by NomeCliente";

            classConexao cconexao = new classConexao();
            return cconexao.RetornaDataTable(query);


        }

        ///////////////////////////////////////////////////////////////////////////


        //MÉTODO 
        public bool ConsultarCliente(int cod)
        {

            string query = "SELECT * FROM Cliente WHERE  CodigoCliente = " + cod + "";
            classConexao cconexao = new classConexao();
            DataTable dt = cconexao.RetornaDataTable(query);


            if (dt.Rows.Count > 0)
            {
                CodigoCliente = Convert.ToInt32(dt.Rows[0]["CodigoCliente"]);
                DataCadastro = Convert.ToDateTime(dt.Rows[0]["DataCadastro"]);
                NomeCliente = dt.Rows[0]["NomeCliente"].ToString();
                RG = dt.Rows[0]["RG"].ToString();
                CPF = dt.Rows[0]["CPF"].ToString();
                DataNascimento = Convert.ToDateTime(dt.Rows[0]["DataNascimento"]);
                Sexo = dt.Rows[0]["Sexo"].ToString();
                Rua = dt.Rows[0]["Rua"].ToString();
                Numero = Convert.ToInt32(dt.Rows[0]["Numero"]);
                Complemento = dt.Rows[0]["Complemento"].ToString();
                Bairro = dt.Rows[0]["Bairro"].ToString();
                Cidade = dt.Rows[0]["Cidade"].ToString();
                Estado = dt.Rows[0]["Estado"].ToString();
                CEP = dt.Rows[0]["CEP"].ToString();
                Email = dt.Rows[0]["Email"].ToString();
                TelefoneResidencial = dt.Rows[0]["telefoneResidencial"].ToString();
                TelefoneCelular = dt.Rows[0]["TelefoneResidencial"].ToString();
                Status = Convert.ToInt32(dt.Rows[0]["Status"]);





                return true;
            }
            else
            {

                return false;

            }
        }
            //MÈTODO ATUALIZAR CLIENTE
            public bool AtualizarCliente()
            {

               string query = "UPDATE Cliente SET NomeCliente = '" + NomeCliente + "', RG = '" + RG + "', CPF = '" + CPF + "', DataNascimento = '" + DataNascimento.ToString("yyyy-MM-dd") + "', Sexo = '" + Sexo + "', Rua = '" + Rua + "', Estado = '" + Estado + "', CEP = '" + CEP + "', Email = '" + Email + "', Status = " + Status + ", TelefoneResidencial = '" + TelefoneResidencial + "', TelefoneCelular = '" + TelefoneCelular + "' WHERE CodigoCliente = " + CodigoCliente +" ";
                 
                classConexao cConexao = new classConexao();

                int resp = cConexao.ExecutaQuery(query);

                if (resp != 0)
                {
                    return true;



                }
                else
                {

                    return false;

                }


            }
        //Métodos relátorio
        public DataTable BuscarCidade()
        {
            string query = "SELECT DISTINCT Cidade FROM cliente WHERE Status = 1 ORDER BY Cidade;";
            classConexao Cconexao = new classConexao();
            return Cconexao.RetornaDataTable(query);


        }

        //Relatório de cliente por idade

        public DataTable RelClienteIdade(int idade1, int idade2)
        {
            string query = "SELECT NomeCliente, CPF, DataNascimento, Cidade, Sexo, TelefoneCelular FROM cliente WHERE Status = 1 and  timestampdiff(YEAR, DataNascimento, now()) BETWEEN "+ idade1 +" and "+ idade2 +" ORDER by NomeCliente;";
            classConexao cconexao = new classConexao();
            return cconexao.RetornaDataTable(query);
        }

        //Relatório de cliente maior de
        public DataTable RelClienteMaiorDe(int idade)
        {
            string query = "SELECT NomeCliente, CPF, DataNascimento, Cidade, Sexo, TelefoneCelular FROM cliente WHERE Status = 1 and  timestampdiff(YEAR, DataNascimento, now()) > " + idade +" ORDER by NomeCliente;";
            classConexao cconexao = new classConexao();
            return cconexao.RetornaDataTable(query);
        }
        //relatório Cliente por cidade
        public DataTable RelClienteCidade(string cidade)
        {
            string query = "SELECT NomeCliente, CPF, DataNascimento, Cidade, Sexo, TelefoneCelular FROM cliente WHERE Status = 1 and Cidades = '"+cidade+"' ORDER by NomeCliente;";
            classConexao cconexao = new classConexao();
            return cconexao.RetornaDataTable(query);
        }














    }
}
