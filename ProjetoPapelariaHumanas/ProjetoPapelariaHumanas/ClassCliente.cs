using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ProjetoPapelariaHumanas
{
    class ClassCliente
    {

        //CONSTRUTOR DA CLASSE
        //SERVE PARA INICIALIZAR TODAS AS VARIAVEIS E PROPRIEDADES
        //PRECISA TER O MESMO NOME DA CLASSE

        public ClassCliente()
        {
            codigo_cliente = 0;
            nome = null;
            cpf = null;
            rg = null;
            telefone = null;
            celular = null;
            data_nascimento = DateTime.Now;
            sexo = null;
            email = null;
            data_cadastro_cliente = DateTime.Now;
            rua = null;
            bairro = null;
            cidade = null;
            estado = null;
            cep = null;
            complemento = null;
            numero = 0;
            status = 0;



        }
        //PROPRIEDADES 
        //SERVE PARA LER E GRAVAR AS INFORMAÇÕES 
        //ATALHO PARA CRIAR AS PROPRIEDADES

        public int codigo_cliente { get; set; }

        public string nome { get; set; }

        public string cpf { get; set; }

        public string rg { get; set; }

        public string telefone { get; set; }

        public string celular { get; set; }

        public DateTime data_nascimento { get; set; }

        public string sexo { get; set; }

        public string email { get; set; }

        public DateTime data_cadastro_cliente { get; set; }

        public string rua { get; set; }


        public string bairro { get; set; }

        public string cidade { get; set; }

        public string estado { get; set; }

        public string cep { get; set; }


        public string complemento { get; set; }

        public int numero { get; set; }
        public int status { get; set; }


        //CRIAÇÃO DOS MÉTODOS (fUNCIONALIDADE DO SISTEMA)
        //CADASTRO - CONSULTA - ATUALIZAÇÃO - EXCLUSÃO
        //MÉTODO : TIPO MÉTODO - TIPO RETORNO - NOME DO MÉTODO - PARÂMETROS
        //MÉTODO CRIAR CLIENTE 


        public int cadastro_cliente()
        {
            string cliente = "INSERT INTO cliente values (0,'" + nome + "','" + cpf + "', '" + rg + "', '" + telefone + "','" + celular + "', '" + data_nascimento.ToString("yyyy-MM-dd") + "', '" + sexo + "', '" + email + "', now(), '" + rua + "', '" + bairro + "', '" + cidade + "', '" + estado + "', '" + cep + "', '" + complemento + "', '" + numero + "',1)";

            ClassConexao cConexao = new ClassConexao();
            return cConexao.ExecutaQuery(cliente);




        }
        //Metodos de consulta
        //consulta de cliente por nome - inicio e contem, cpf, sexo
        //Campos exibidos na consulta: CodigoCliente, NomeCliente, CPF,DataNascimento, sexo, Telefone

        //Consulta de cliente por nome - inicio

        public DataTable ConsultaClienteNomeInicio(string nomeinicio)
        {

            string query = "select codigo_cliente, nome, cpf, rg, sexo, status_cliente FROM cliente WHERE status_cliente =  1 and nome like '" + nomeinicio + "%' ORDER by nome";

            ClassConexao cconexao = new ClassConexao();
            return cconexao.RetornaDataTable(query);

        }
        //Consulta de cliente por nome - contém

        public DataTable ConsultaClienteNomeContem(string nomecontem)
        {
            string query = "select codigo_cliente, nome, cpf, rg, sexo, status_cliente FROM cliente WHERE status_cliente = 1 and nome like '%" + nomecontem + "%' ORDER by nome";

            ClassConexao cconexao = new ClassConexao();
            return cconexao.RetornaDataTable(query);
        }
        //Consulta de cliente por - CPF
        public DataTable ConsultaClienteCPF(string cpf)
        {
            string query = "select codigo_cliente, nome, cpf, rg , sexo, status_cliente FROM cliente WHERE status_cliente = 1 and cpf = '" + cpf + "' ORDER by nome";

            ClassConexao cconexao = new ClassConexao();
            return cconexao.RetornaDataTable(query);
        }
        //Consulta de cliente por - Sexo
        public DataTable ConsultaClienteSexo(string sexo)
        {
            string query = "select codigo_cliente, nome, cpf, rg, sexo, status_cliente FROM cliente WHERE status_cliente = 1 and sexo = '" + sexo + "' ORDER by nome";

            ClassConexao cconexao = new ClassConexao();
            return cconexao.RetornaDataTable(query);


        }
        //Consulta de cliente por - Status
        public DataTable ConsultaClienteStatus(int status)
        {
            string query = "select codigo_cliente, nome, cpf, rg, sexo, status_cliente FROM cliente WHERE status_cliente = " + status + " ORDER by nome";

            ClassConexao cconexao = new ClassConexao();
            return cconexao.RetornaDataTable(query);


        }

        //Consulta de cliente por - celular

        public DataTable ConsultaClienteRg(string rg)
        {
            string query = "select codigo_cliente, nome, cpf, sexo, status_cliente FROM cliente WHERE status_cliente = 1 and rg = '" + rg + "' ORDER by nome";

            ClassConexao cconexao = new ClassConexao();
            return cconexao.RetornaDataTable(query);


        } ///////////////////////////////////////////////////

        public bool ConsultarCliente(int cod)
        {

            string query = "SELECT * FROM Cliente WHERE  codigo_cliente = " + cod + "";
            ClassConexao cconexao = new ClassConexao();
            DataTable dt = cconexao.RetornaDataTable(query);


            if (dt.Rows.Count > 0)
            {
                codigo_cliente = Convert.ToInt32(dt.Rows[0]["codigo_cliente"]);
                data_cadastro_cliente = Convert.ToDateTime(dt.Rows[0]["data_cadastro_cliente"]);
                nome = dt.Rows[0]["nome"].ToString();
                rg = dt.Rows[0]["rg"].ToString();
                cpf = dt.Rows[0]["cpf"].ToString();
                data_nascimento = Convert.ToDateTime(dt.Rows[0]["data_nascimento"]);
                sexo = dt.Rows[0]["sexo"].ToString();
                rua = dt.Rows[0]["rua"].ToString();
                numero = Convert.ToInt32(dt.Rows[0]["numero"]);
                complemento = dt.Rows[0]["complemento"].ToString();
                bairro = dt.Rows[0]["bairro"].ToString();
                cidade = dt.Rows[0]["cidade"].ToString();
                estado = dt.Rows[0]["estado"].ToString();
                cep = dt.Rows[0]["cep"].ToString();
                email = dt.Rows[0]["email"].ToString();
                telefone = dt.Rows[0]["telefone"].ToString();
                celular = dt.Rows[0]["celular"].ToString();
                status = Convert.ToInt32(dt.Rows[0]["status_cliente"]);
                return true;
            }
            else
            {
                return false;
            }
            //MÈTODO ATUALIZAR CLIENTE
        }
        public bool AtualizarCliente()
        {

            string query = "UPDATE Cliente SET nome = '" + nome + "', rg = '" + rg + "', cpf = '" + cpf + "', data_nascimento = '" + data_nascimento.ToString("yyyy-MM-dd") + "', sexo = '" + sexo + "', rua = '" + rua + "', estado = '" + estado + "', cep = '" + cep + "', email = '" + email + "', status_cliente = " + status + ", telefone = '" + telefone + "', celular = '" + celular + "' WHERE codigo_cliente = " + codigo_cliente + " ";

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

        public bool excluircliente()
        {
            string query = "DELETE FROM Cliente WHERE codigo_cliente = " + codigo_cliente + "";
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
        //Método Cliente
        //Relatório de Cliente
        public DataTable relatoriocliente()
        {
            string query = "SELECT nome , celular , data_nascimento, sexo, cidade from cliente WHERE status_cliente  = 1 order by nome";
            ClassConexao Cconexao = new ClassConexao();
            return Cconexao.RetornaDataTable(query);
        }
        //Relatório de cliente por idade

        public DataTable RelClienteIdade(int idade1, int idade2)
        {
            string query = "SELECT nome, celular , data_nascimento, sexo, cidade, celular FROM cliente WHERE status_cliente = 1 and  timestampdiff(YEAR, data_nascimento, now()) BETWEEN " + idade1 + " and " + idade2 + " ORDER by nome;";
            ClassConexao cconexao = new ClassConexao();
            return cconexao.RetornaDataTable(query);
        }
        //Relatório de cliente maior de
        public DataTable RelClienteMaiorDe(int idade)
        {
            string query = "SELECT nome, celular, data_nascimento, sexo, cidade, celular FROM cliente WHERE status_cliente = 1 and  timestampdiff(YEAR, data_nascimento, now()) > " + idade + " ORDER by nome;";
            ClassConexao cconexao = new ClassConexao();
            return cconexao.RetornaDataTable(query);
        }


        //Relatório de cliente por sexo
        public DataTable RelClienteSexo(string sexo)
        {
            string query = "SELECT nome, celular, data_nascimento, sexo, cidade, celular FROM cliente WHERE status_cliente = 1 and sexo = '" + sexo + "' ORDER by nome;";
            ClassConexao cconexao = new ClassConexao();
            return cconexao.RetornaDataTable(query);

        }
        //relatório Cliente por cidade
        public DataTable RelClienteCidade(string cidade)
        {
            string query = "SELECT nome, celular, data_nascimento, sexo, cidade, celular FROM cliente WHERE status_cliente = 1 and cidade like '%" + cidade + "%' ORDER by nome;";
            ClassConexao cconexao = new ClassConexao();
            return cconexao.RetornaDataTable(query);
        }

        public DataTable RelClienteStatus(int status)
        {
            string query = "select nome, celular, data_nascimento, sexo, cidade FROM cliente WHERE status_cliente = " + status + " ORDER by nome";

            ClassConexao cconexao = new ClassConexao();
            return cconexao.RetornaDataTable(query);


        }





    }

}
