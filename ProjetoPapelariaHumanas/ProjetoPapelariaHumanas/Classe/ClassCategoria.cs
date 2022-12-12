using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace ProjetoPapelariaHumanas
{
    class ClassCategoria
    {
        //CONSTRUTOR DA CLASSE 
        //SERVE PARA INICIALIZAR TODAS AS VARIAVEIS E PROPIEDADES
        //PRECISA TER O MESMO NOME DA CLASSE
        public ClassCategoria()
        {
            codigo_categoria = 0;
            nome = null;
            status = 0;
            data_cadastro = DateTime.Now;

        }
        //PROPIEDADES
        //SERVE PARA LER E GRAVAR AS INFORMAÇÕES
        //ATALHO PARA CRIAR AS PROPIEDADES - PROP TAB TAB

        public int codigo_categoria { get; set; }
        public String nome { get; set; }
        public int status { get; set; }
        public DateTime data_cadastro { get; set; }


        //CRIAÇÃO DOS METODOS (FUNCIONALIDADES DO SISTEMA)
        //CADASTRO - CONSULTA - ATUALIZAÇÃO - EXCLUSÃO
        //METODO: TIPO METODO TIPO RETORNO NOME METODO PARAMETROS

        //METODO CADASTRAR CATEGORIA

        public int cadastrarcategoria()
        {
            string query = "INSERT INTO categoria values (0, '" + nome + "', 1, now())";

            ClassConexao cConexao = new ClassConexao();
            return cConexao.ExecutaQuery(query);

        }

        // CLASSE CATEGORIA
        // METODO PARA BUSCAR OS DADOS (CODIGO E NOME DA CATEGORIA)
        // PARA POPULAR A COMBO DE FORNECEDOR DE CATEGORIA DE FORMULARIO DE CADASTRO DE PRODUTO

        public DataTable BuscarCategoria()
        {
            string query = "SELECT codigo_categoria, nome, data_cadastro from categoria Where status = 1 order by nome";

            ClassConexao conexao = new ClassConexao();
            return conexao.RetornaDataTable(query);

        }

        //Metodos de consulta
        //consulta de Categoria por nome - inicio e contem
        //Campos exibidos na consulta: CodigoCategoria, Nome da categoria, Status, Data Cadastro

        //Consulta de categoria por nome - inicio

        public DataTable ConsultaCategoriaNomeInicio(string nomei)
        {
            string query = "select codigo_categoria , nome, data_cadastro FROM categoria WHERE Status = 1 and nome like '" + nomei + "%' ORDER by nome";

            ClassConexao cconexao = new ClassConexao();
            return cconexao.RetornaDataTable(query);


        }
        //Consulta de categoria por nome - contém

        public DataTable ConsultaCategoriaNomeContem(string nomec)
        {
            string query = "select codigo_categoria, nome, data_cadastro FROM categoria WHERE status = 1 and nome like '%" + nomec + "%' ORDER by nome";

            ClassConexao cconexao = new ClassConexao();
            return cconexao.RetornaDataTable(query);


        }
        //Consulta de CATEGORIA por Status
        public DataTable ConsultaCategoriaStatus(int Status)
        {
            string query = "select codigo_categoria, nome, data_cadastro FROM categoria WHERE status = " + Status + " ORDER by nome";

            ClassConexao cconexao = new ClassConexao();
            return cconexao.RetornaDataTable(query);


        }
        public bool ConsultarCategoria(int cod)
        {

            string query = "SELECT * FROM categoria WHERE Codigo_categoria = " + cod + "";
            ClassConexao cconexao = new ClassConexao();
            DataTable dt = cconexao.RetornaDataTable(query);


            if (dt.Rows.Count > 0)
            {
                codigo_categoria = Convert.ToInt32(dt.Rows[0]["codigo_categoria"]);
                data_cadastro = Convert.ToDateTime(dt.Rows[0]["data_cadastro"]);
                nome = dt.Rows[0]["nome"].ToString();
                status = Convert.ToInt32(dt.Rows[0]["status"]);

                return true;
            }
            else
            {

                return false;

            }



        }

        //MÉTODO ATUALIZAR CATEGORIA
        public int Atualizarcategoria()
        {

            string query = "UPDATE categoria SET nome = '" + nome + "', status = " + status + " WHERE codigo_categoria = " + codigo_categoria + " ";

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

        public bool ExcluirCategoria()
        {
            string query = "DELETE FROM categoria WHERE codigo_categoria = " + codigo_categoria + " ";

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

        //////////////
        ///




        //METEDO DE RELATORIO MARCA
        public DataTable RelatorioCategoria()
        {
            string query = "SELECT codigo_categoria, nome, data_cadastro, status FROM categoria WHERE status = 1 ORDER BY nome ";

            ClassConexao cConexao = new ClassConexao();
            return cConexao.RetornaDataTable(query);

        }
    }
}
