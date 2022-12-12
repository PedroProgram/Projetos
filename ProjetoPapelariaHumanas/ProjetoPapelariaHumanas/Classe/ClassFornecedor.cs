using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace ProjetoPapelariaHumanas
{
    class ClassFornecedor
    {
        //CONSTRUTOR DA CLASSE 
        //SERVE PARA INICIALIZAR TODAS AS VARIAVEIS E PROPIEDADES
        //PRECISA TER O MESMO NOME DA CLASSE

        public ClassFornecedor()
        {
            codigo_fornecedor = 0;
            nome = null;
            telefone = null;
            cep = null;
            rua = null;
            bairro = null;
            cidade = null;
            cnpj = null;
            data_cadastro_fornecedor = DateTime.Now;
            status = 0;
        }

        //PROPIEDADES
        //SERVE PARA LER E GRAVAR AS INFORMAÇÕES
        //ATALHO PARA CRIAR AS PROPIEDADES - PROP TAB TAB

        public int codigo_fornecedor { get; set; }
        public String nome { get; set; }
        public String telefone { get; set; }
        public String cep { get; set; }
        public String rua { get; set; }
        public String bairro { get; set; }
        public String cidade { get; set; }
        public String cnpj { get; set; }
        public DateTime data_cadastro_fornecedor { get; set; }
        public int status { get; set; }

        //CRIAÇÃO DOS METODOS (FUNCIONALIDADES DO SISTEMA)
        //CADASTRO - CONSULTA - ATUALIZAÇÃO - EXCLUSÃO
        //METODO: TIPO METODO TIPO RETORNO NOME METODO PARAMETROS

        //METODO CADASTRAR FORNECEDOR

        public int cadastrofornecedor()
        {
            string query = "INSERT INTO fornecedor VALUES (0, '" + nome + "','" + telefone + "', '" + cep + "', '" + rua + "', '" + bairro + "', '" + cidade + "', '" + cnpj + "', now(), 1)";

            ClassConexao cConexao = new ClassConexao();
            return cConexao.ExecutaQuery(query);


        }
        //CARREGAR COMBO FORNECEDOR
        public DataTable BuscarFornecedor()
        {
            string query = "SELECT codigo_fornecedor, nome from fornecedor Where status_fornecedor = 1 order by nome";

            ClassConexao conexao = new ClassConexao();
            return conexao.RetornaDataTable(query);

        }
        //método de consulta 
        //consulta de fornecedor por nome - inicio e contem, cnpj, telefone
        //Campos exibidos na consulta: codigo_fornecedor, Nome, CPF,data_cadastro_fornecedor, cep, Telefone

        //Consulta de fornecedor por nome - inicio

        public DataTable ConsultarFornecedorNomeInicio(string nomei)
        {
            string query = "SELECT codigo_fornecedor, nome, telefone, cep, rua, bairro, cidade, cnpj, data_cadastro_fornecedor from fornecedor Where status_fornecedor = 1  AND nome like '" + nomei + "%' order by nome";

            ClassConexao conexao = new ClassConexao();
            return conexao.RetornaDataTable(query);

        }

        //consulta de fornecedor por nome - contém
        public DataTable ConsultarFornecedorNomeContem(string nomec)
        {
            string query = "SELECT codigo_fornecedor, nome, telefone, cep, rua, bairro, cidade, cnpj, data_cadastro_fornecedor from fornecedor Where status_fornecedor = 1  AND nome like '%" + nomec + "%' order by nome";

            ClassConexao cConexao = new ClassConexao();
            return cConexao.RetornaDataTable(query);
        }

        //Consulta de fornecedor por nome - status
        public DataTable ConsultarFornecedorStatus(int Status)
        {
            string query = "SELECT codigo_fornecedor, nome, telefone, cep, rua, bairro, cidade, cnpj, data_cadastro_fornecedor from fornecedor Where status_fornecedor = " + Status + " order by nome";

            ClassConexao cConexao = new ClassConexao();
            return cConexao.RetornaDataTable(query);
        }

        //Consulta de Fornecedor por telefone

        public DataTable ConsultarFornecedorTelefone(string telefone)
        {
            string query = "SELECT codigo_fornecedor, nome, telefone, cep, rua, bairro, cidade, cnpj, data_cadastro_fornecedor from fornecedor Where status_fornecedor = 1  AND telefone = '" + telefone + "' order by nome";

            ClassConexao cConexao = new ClassConexao();
            return cConexao.RetornaDataTable(query);

        }

        public DataTable ConsultarFornecedorCNPJ(string cnpj)
        {

            string query = "SELECT codigo_fornecedor, nome, telefone, cep, rua, bairro, cidade, cnpj, data_cadastro_fornecedor from fornecedor Where status_fornecedor = 1  AND cnpj = '" + cnpj + "' order by nome";

            ClassConexao classConexao = new ClassConexao();
            return classConexao.RetornaDataTable(query);

        }

        //////////////////////////


        //MÉTODO

        public bool BuscarFornecedor(int cod)
        {
            string query = "SELECT * FROM fornecedor Where codigo_fornecedor = " + cod + " ";

            ClassConexao cConexao = new ClassConexao();
            DataTable dt = cConexao.RetornaDataTable(query);


            if (dt.Rows.Count > 0)
            {
                codigo_fornecedor = Convert.ToInt32(dt.Rows[0]["codigo_fornecedor"]);
                nome = dt.Rows[0]["nome"].ToString();
                telefone = dt.Rows[0]["telefone"].ToString();
                cep = dt.Rows[0]["cep"].ToString();
                rua = dt.Rows[0]["rua"].ToString();
                bairro = dt.Rows[0]["bairro"].ToString();
                cidade = dt.Rows[0]["cidade"].ToString();
                cnpj = dt.Rows[0]["cnpj"].ToString();
                data_cadastro_fornecedor = Convert.ToDateTime(dt.Rows[0]["data_cadastro_fornecedor"]);
                status = Convert.ToInt32(dt.Rows[0]["status_fornecedor"]);

                return true;
            }
            else
            {
                return false;
            }

        }

        //METODO ATUALIZAR FORNECEDOR

        public int AtualizarFornecedor()
        {
            string query = " UPDATE fornecedor SET nome = '" + nome + "', telefone = '" + telefone + "', cep = '" + cep + "', rua = '" + rua + "', bairro = '" + bairro + "', cidade = '" + cidade + "', cnpj = '" + cnpj + "', status_fornecedor = " + status + " WHERE codigo_fornecedor = " + codigo_fornecedor + " ";

            ClassConexao cConexao = new ClassConexao();

            int resp = cConexao.ExecutaQuery(query);

            if (resp != 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }

        // METODO EXCLUIR FORNECEDOR

        public bool ExcluirFornecedor()
        {
            string query = "DELETE FROM fornecedor WHERE codigo_fornecedor = " + codigo_fornecedor + " ";

            ClassConexao cConexao = new ClassConexao();

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



        ////////
        ///

        //MÉTODOS DE RELATÓRIOS DE FORNECEDOR




        //METODO DE RELATÓRIO POR TELEFONE
        public DataTable RelatorioFornecedorTelefone(string telefone)
        {
            string query = "SELECT codigo_fornecedor, nome, telefone, cnpj, data_cadastro_fornecedor, status_fornecedor 'status' FROM fornecedor WHERE status_fornecedor = 1 AND telefone = '" + telefone + "' ORDER BY nome";

            ClassConexao cConexao = new ClassConexao();
            return cConexao.RetornaDataTable(query);

        }

        //MÉTODO DE RELATÓRIO POR STATUS
        public DataTable RelatoriofornecedorStatus(int status)
        {
            string query = "SELECT codigo_fornecedor, nome, telefone, cnpj, data_cadastro_fornecedor, status_fornecedor 'status' FROM fornecedor WHERE status_fornecedor = " + status + " order by nome";

            ClassConexao cConexao = new ClassConexao();
            return cConexao.RetornaDataTable(query);

        }

        //MÉTODO DE RELATÓRIO POR CNPJ
        public DataTable RelatorioFornecedorCNPJ(string cnpj)
        {

            string query = "SELECT codigo_fornecedor, nome, telefone, cnpj, data_cadastro_fornecedor, status_fornecedor 'status' FROM fornecedor WHERE status_fornecedor = 1  AND cnpj = '" + cnpj + "' order by nome";

            ClassConexao classConexao = new ClassConexao();
            return classConexao.RetornaDataTable(query);

        }

        //MÉTODO DE RELATÓRIO POR CIDADE
        public DataTable RelatorioFornecedorCidade(string cidade)
        {

            string query = "SELECT codigo_fornecedor, nome, telefone, cnpj, data_cadastro_fornecedor, status_fornecedor 'status' FROM fornecedor WHERE status_fornecedor = 1  AND cidade = '" + cidade + "' order by nome";

            ClassConexao classConexao = new ClassConexao();
            return classConexao.RetornaDataTable(query);

        }

        //CARREGAR COMBO CIDADE
        public DataTable BuscarCidade()
        {
            string query = "SELECT DISTINCT cidade from fornecedor Where status_fornecedor = 1 order by cidade";

            ClassConexao conexao = new ClassConexao();
            return conexao.RetornaDataTable(query);

        }

        //MÉTODO DE RELATÓRIO POR DATA CADASTRO POR MÊS
        public DataTable RelatorioFornecedorCadastroMes(string datacad)
        {

            string query = "SELECT codigo_fornecedor, nome, telefone, cnpj, data_cadastro_fornecedor, status_fornecedor 'status' FROM fornecedor WHERE status_fornecedor = 1  AND MONTH(data_cadastro_fornecedor) = '" + datacad + "' order by nome";

            ClassConexao classConexao = new ClassConexao();
            return classConexao.RetornaDataTable(query);

        }


        //MÉTODO DE RELATÓRIO POR DATA CADASTRO POR DATA
        public DataTable RelatorioFornecedorData(DateTime data)
        {

            string query = "SELECT codigo_fornecedor, nome, telefone, cnpj, data_cadastro_fornecedor, status_fornecedor 'status' FROM fornecedor WHERE status_fornecedor = 1 AND CAST(fornecedor.data_cadastro_fornecedor AS DATE) = '" + data.ToString("yyyy/MM/dd") + "' order by nome";

            ClassConexao classConexao = new ClassConexao();
            return classConexao.RetornaDataTable(query);

        }
        

    }
}
