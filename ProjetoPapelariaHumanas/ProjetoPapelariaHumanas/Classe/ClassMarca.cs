using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace ProjetoPapelariaHumanas
{
    class ClassMarca
    {
        public ClassMarca()
        {
            //CONSTRUTOR DA CLASSE
            //SERVE PARA INICIALIZAR TODAS AS VARIAVEIS E PROPIEDADES
            //PRECISA TER O MESMO NOME DA CLASSE

            Codigo_Marca = 0;
            Nome = null;
            Status = 0;
            Data_Cadastro = DateTime.Now;
            Observacao = null;

        }
        //PROPIEDADES 
        //SERVE PARA LER E GRAVAR AS INFORMAÇÕES
        //ATALHO PARA CRIAR AS PROPIEDADES
        public int Codigo_Marca { get; set; }
        public String Nome { get; set; }
        public int Status { get; set; }
        public DateTime Data_Cadastro { get; set; }
        public String Observacao { get; set; }

        // CRIAÇÃO DOS METODOS (FUNCIONALIDADE DO SISTEMA)
        //CADASTRO - CONSULTA - ATUALIZAÇÃO - EXCLUSÃO 
        //METODO : TIPO MÉTODO - TIPO RETORNO - NOME DO MÉTODO - PARÂMETROS
        //MÉTODO CRIAR PRODUTO

        public int cadastroMarca()
        {
            string query = "INSERT INTO marca values (0,'" + Nome + "', 1, now(), '" + Observacao + "' )";

            ClassConexao cConexao = new ClassConexao();
            return cConexao.ExecutaQuery(query);

        }
        // CLASSE MARCA
        // METODO PARA BUSCAR OS DADOS (CODIGO E NOME DA MARCA)
        // PARA POPULAR A COMBO DE FORNECEDOR DE CATEGORIA DE FORMULARIO DE CADASTRO DA MARCA

        public DataTable BuscarMarca()
        {
            string query = "SELECT codigo_marca, nome_marca from marca Where status = 1 order by nome_marca";

            ClassConexao conexao = new ClassConexao();
            return conexao.RetornaDataTable(query);

        }
        //Metodos de consulta
        //consulta de Marca por nome - inicio e contem
        //Campos exibidos na consulta: CodigoCliente, NomeCliente, Status, Data Cadastro

        //Consulta de Marca por nome - inicio

        public DataTable ConsultaMarcaNomeInicio(string nomei)
        {
            string query = "select codigo_marca, nome_marca, data_cadastro FROM marca WHERE Status = 1 and nome_marca like '" + nomei + "%' ORDER by nome_marca";

            ClassConexao cconexao = new ClassConexao();
            return cconexao.RetornaDataTable(query);


        }
        //Consulta de cliente por nome - contém

        public DataTable ConsultaMarcaNomeContem(string nomec)
        {
            string query = "select codigo_marca, nome_marca, data_cadastro FROM marca WHERE Status = 1 and nome_marca like '%" + nomec + "%' ORDER by nome_marca";

            ClassConexao cconexao = new ClassConexao();
            return cconexao.RetornaDataTable(query);


        }
        //Consulta de cliente por nome - Status
        public DataTable ConsultaMarcaStatus(int Status)
        {
            string query = "select codigo_marca, nome_marca, data_cadastro FROM marca WHERE Status = " + Status + " ORDER by nome_marca";

            ClassConexao cconexao = new ClassConexao();
            return cconexao.RetornaDataTable(query);


        }
        public bool ConsultarMarca(int cod)
        {

            string query = "SELECT * FROM marca WHERE  Codigo_marca = " + cod + "";
            ClassConexao cconexao = new ClassConexao();
            DataTable dt = cconexao.RetornaDataTable(query);


            if (dt.Rows.Count > 0)
            {
                Codigo_Marca = Convert.ToInt32(dt.Rows[0]["codigo_marca"]);
                Data_Cadastro = Convert.ToDateTime(dt.Rows[0]["data_cadastro"]);
                Nome = dt.Rows[0]["nome_marca"].ToString();
                Observacao = dt.Rows[0]["observacao"].ToString();
                Status = Convert.ToInt32(dt.Rows[0]["Status"]);

                return true;
            }
            else
            {

                return false;

            }



        }

        //MÉTODO ATUALIZAR MARCA
        public int AtualizarMarca()
        {

            string query = "UPDATE marca SET nome_marca = '" + Nome + "', status = " + Status + ", observacao = '" + Observacao + "' WHERE codigo_marca = " + Codigo_Marca + " ";

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

        public bool ExcluirMaca()
        {
            string query = "DELETE FROM marca WHERE codigo_marca = " + Codigo_Marca + " ";

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



        //METEDO DE RELATORIO MARCA
        public DataTable RelatorioMarca()
        {
            string query = "SELECT codigo_marca 'Codigo_Marca', nome_marca 'Nome', data_cadastro 'Data_Cadastro' , status 'Status' FROM marca WHERE status = 1 ORDER by nome_marca  ";

            ClassConexao cConexao = new ClassConexao();
            return cConexao.RetornaDataTable(query);

        }










    }
}
