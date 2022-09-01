using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ProjetoPapelariaHumanas
{
    class ClassCargo
    {
        //CONSTRUTOR DA CLASSE
        //SERVE PARA INICIALIZAR TODAS AS VARIAVEIS E PROPRIEDADES
        //PRECISA TER O MESMO NOME DA CLASSE

        public ClassCargo ()
        {
            Codigo_Cargo = 0;
            Nome_Cargo = null;
            Data_Cadastro = DateTime.Now;
            Status = 0;
            Observacao = null;






        }
        //PROPRIEDADES 
        //SERVE PARA LER E GRAVAR AS INFORMAÇÕES 
        //ATALHO PARA CRIAR AS PROPRIEDADES
        public int Codigo_Cargo { get; set; }

        public string Nome_Cargo { get; set; }

        public DateTime Data_Cadastro { get; set;}

        public int Status { get; set; }

        public string Observacao { get; set; }

        //CRIAÇÃO DOS MÉTODOS (fUNCIONALIDADE DO SISTEMA)
        //CADASTRO - CONSULTA - ATUALIZAÇÃO - EXCLUSÃO
        //MÉTODO : TIPO MÉTODO - TIPO RETORNO - NOME DO MÉTODO - PARÂMETROS
        //MÉTODO CRIAR Cargo

        public int cadastro_cargo()
        {
            string cadastro_cargo = "INSERT INTO cargo values (0, '" + Nome_Cargo + "',now(), 1, '" + Observacao + "' )";

            ClassConexao Cconexao = new ClassConexao();
            return Cconexao.ExecutaQuery(cadastro_cargo);

        }
        //CLASSE CARGO
        //METODO PARA BUSCAR OS DADOS cargo
        //PARA POPULAR A COMBO DE CARGO DE CATEGORIA DO FORMULÁRIO DE CADASTRO DE FUNCIONÁRIOS
        public DataTable BuscarCargo ()
        {
            string query = "SELECT codigo_cargo, nome from cargo where status = 1 order by nome ";

            ClassConexao cConexao = new ClassConexao();
            return cConexao.RetornaDataTable(query);

        } 
        //Status
        public DataTable ConsultarCargoStatus(int status)
        {
            string query = "SELECT codigo_cargo, nome, status from cargo where status = " + status + " order by nome";
            ClassConexao cconexao = new ClassConexao();
            return cconexao.RetornaDataTable(query);

        }
        public DataTable ConsultaCargoNomeInicio(string nomei)
        {

            string query = "select codigo_cargo, nome, status FROM cargo WHERE status =  1 and nome like '" + nomei + "%' ORDER by nome";

            ClassConexao cconexao = new ClassConexao();
            return cconexao.RetornaDataTable(query);

        }
        //Consulta de cargo por nome - contém

        public DataTable ConsultaCargoNomeContem(string nomec)
        {
            string query = "select codigo_cargo, nome, status FROM cargo WHERE status = 1 and nome like '%" + nomec + "%' ORDER by nome";

            ClassConexao cconexao = new ClassConexao();
            return cconexao.RetornaDataTable(query);
        }
        ///////////////////////////////

        public bool ConsultarCargo(int cod)
        {

            string query = "SELECT * FROM cargo WHERE  codigo_cargo = " + cod + "";
            ClassConexao cconexao = new ClassConexao();
            DataTable dt = cconexao.RetornaDataTable(query);

            if (dt.Rows.Count > 0)
            {
                Codigo_Cargo = Convert.ToInt32(dt.Rows[0]["codigo_cargo"]);
                Nome_Cargo = dt.Rows[0]["nome"].ToString();
                Data_Cadastro = Convert.ToDateTime(dt.Rows[0]["data_cadastro"]);
                Status = Convert.ToInt32(dt.Rows[0]["status"]);
                Observacao = dt.Rows[0]["observacao"].ToString();

                return true;


            }
            else
            {

                return false;

            }

        }
        //MÈTODO ATUALIZAR CLIENTE
        public bool atualizarCargo()
        {
            string query = "UPDATE cargo SET nome = '" + Nome_Cargo + "', status = " + Status + ", observacao = '" + Observacao + "'WHERE codigo_cargo = " + Codigo_Cargo + "";

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
        public bool excluircargo()
        {
            string query = "DELETE FROM cargo WHERE codigo_cargo = " + Codigo_Cargo + "";
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

        //Método Cargo
        //Relatório de cargo
        public DataTable relatoriocargo()
        {
            string query = "SELECT nome 'Nome_Cargo', data_cadastro 'Data_Cadastro', status 'Status' from cargo WHERE status = 1 order by nome";
            ClassConexao Cconexao = new ClassConexao();
            return Cconexao.RetornaDataTable(query);


        }
    }

}
