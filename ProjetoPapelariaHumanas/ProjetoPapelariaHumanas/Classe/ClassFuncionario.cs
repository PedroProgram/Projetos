using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ProjetoPapelariaHumanas
{
    internal class ClassFuncionario
    {
        //CONSTRUTOR DA CLASSE
        //SERVE PARA INICIALIZAR TODAS AS VARIAVEIS E PROPRIEDADES
        //PRECISA TER O MESMO NOME DA CLASSE

        public ClassFuncionario()
        {
            codigo_funcionario = 0;
            nome_funcionario = null;
            data_nascimento = DateTime.Now;
            cpf = null;
            rg = null;
            telefone = null;
            sexo = null;
            email = null;
            login = null;
            senha = null;
            tipo_acesso = null;
            rua = null;
            bairro = null;
            cidade = null;
            estado = null;
            cep = null;
            complemento = null;
            numero = 0;
            data_cadastro_fun = DateTime.Now;
            status = 0;
            codigo_cargo = 0;





        }
        //PROPRIEDADES 
        //SERVE PARA LER E GRAVAR AS INFORMAÇÕES 
        //ATALHO PARA CRIAR AS PROPRIEDADES

        public int codigo_funcionario { get; set; }

        public string nome_funcionario { get; set; }

        public string cpf { get; set; }

        public string rg { get; set; }

        public string telefone { get; set; }

        public DateTime data_nascimento { get; set; }

        public string sexo { get; set; }

        public string email { get; set; }

        public string login { get; set; }

        public string senha { get; set; }

        public string tipo_acesso { get; set; }

        public DateTime data_cadastro_fun { get; set; }

        public string rua { get; set; }


        public string bairro { get; set; }

        public string cidade { get; set; }

        public string estado { get; set; }

        public string cep { get; set; }


        public string complemento { get; set; }

        public int numero { get; set; }
        public int status { get; set; }

        public int codigo_cargo { get; set; }


        //CRIAÇÃO DOS MÉTODOS (fUNCIONALIDADE DO SISTEMA)
        //CADASTRO - CONSULTA - ATUALIZAÇÃO - EXCLUSÃO
        //MÉTODO : TIPO MÉTODO - TIPO RETORNO - NOME DO MÉTODO - PARÂMETROS
        //MÉTODO CRIAR Funcionario
        public int cadastro_funcionario()
        {

            string funcionario = "INSERT INTO funcionario values (0, '" + nome_funcionario + "', '" + data_nascimento.ToString("yyyy-MM-dd") + "', '" + cpf + "', '" + rg + "', '" + telefone + "','" + sexo + "', '" + email + "', '" + login + "', '" + senha + "', '" + tipo_acesso + "', '" + rua + "', '" + bairro + "', '" + cidade + "', '" + estado + "', '" + cep + "', '" + complemento + "', '" + numero + "', now(), 1, " + codigo_cargo + ")";

            ClassConexao cConexao = new ClassConexao();
            return cConexao.ExecutaQuery(funcionario); 
        }
        //Consulta de funcionário por nome - inicio
        public DataTable ConsultaFuncionarioNomeInicio(string nomei)
        {

            string query = "SELECT funcionario.codigo_funcionario,funcionario.nome, funcionario.cpf, cargo.nome 'cargo', funcionario.sexo, funcionario.status_funcionario FROM funcionario JOIN cargo ON funcionario.codigo_cargo = cargo.codigo_cargo WHERE funcionario.status_funcionario = 1 and funcionario.nome LIKE '" + nomei + "%' ORDER by funcionario.nome";

            ClassConexao cconexao = new ClassConexao();
            return cconexao.RetornaDataTable(query);

        }
        //Consulta de funcionário por nome - contém

        public DataTable ConsultaFuncionarioNomeContem(string nomec)
        {
            string query = "SELECT funcionario.codigo_funcionario,funcionario.nome, funcionario.cpf, cargo.nome 'cargo', funcionario.sexo, funcionario.status_funcionario FROM funcionario JOIN cargo ON funcionario.codigo_cargo = cargo.codigo_cargo WHERE funcionario.status_funcionario = 1 and funcionario.nome LIKE '%" + nomec + "%' ORDER by funcionario.nome";

            ClassConexao cconexao = new ClassConexao();
            return cconexao.RetornaDataTable(query);

        }
        //Consulta de funcionário por - Sexo
        public DataTable ConsultaFuncionarioSexo(string sexo)
        {
            string query = "SELECT funcionario.codigo_funcionario,funcionario.nome, funcionario.cpf, cargo.nome 'cargo', funcionario.sexo, funcionario.status_funcionario FROM funcionario JOIN cargo ON funcionario.codigo_cargo = cargo.codigo_cargo WHERE funcionario.status_funcionario = 1 and funcionario.sexo = '" + sexo + "' ORDER by funcionario.nome";

            ClassConexao cconexao = new ClassConexao();
            return cconexao.RetornaDataTable(query);


        }
        //Consulta de funcionário por - cpf
        public DataTable ConsultaFuncionarioCPF(string cpf)
        {
            string query = "SELECT funcionario.codigo_funcionario,funcionario.nome, funcionario.cpf, cargo.nome 'cargo', funcionario.sexo, funcionario.status_funcionario FROM funcionario JOIN cargo ON funcionario.codigo_cargo = cargo.codigo_cargo WHERE funcionario.status_funcionario = 1 and funcionario.cpf = '" + cpf + "' ORDER by funcionario.nome";

            ClassConexao cconexao = new ClassConexao();
            return cconexao.RetornaDataTable(query);
        }
        //Consulta de funcionário por - Status
        public DataTable ConsultaFuncionarioStatus(int status)
        {
            string query = "SELECT funcionario.codigo_funcionario,funcionario.nome, funcionario.cpf, cargo.nome 'cargo', funcionario.sexo, funcionario.status_funcionario FROM funcionario JOIN cargo ON funcionario.codigo_cargo = cargo.codigo_cargo WHERE funcionario.status_funcionario = " + status + " ORDER by nome";

            ClassConexao cconexao = new ClassConexao();
            return cconexao.RetornaDataTable(query);


        }
        //Consulta de funcionário por Cargo
        public DataTable ConsultaFuncionarioCargo(int cargo)
        {
            string query = "SELECT funcionario.codigo_funcionario,funcionario.nome, funcionario.cpf, cargo.nome 'cargo', funcionario.sexo, funcionario.status_funcionario FROM funcionario JOIN cargo ON funcionario.codigo_cargo = cargo.codigo_cargo WHERE funcionario.status_funcionario = 1 and funcionario.codigo_cargo = '" + cargo + "' ORDER by funcionario.nome";

            ClassConexao cconexao = new ClassConexao();
            return cconexao.RetornaDataTable(query);
        }
        public bool ConsultarFuncionario(int cod)
        {

            string query = "SELECT * FROM funcionario WHERE codigo_funcionario = " + cod + "";
            ClassConexao cconexao = new ClassConexao();
            DataTable dt = cconexao.RetornaDataTable(query);


            if (dt.Rows.Count > 0)
            {
                codigo_funcionario = Convert.ToInt32(dt.Rows[0]["codigo_funcionario"]);
                data_cadastro_fun = Convert.ToDateTime(dt.Rows[0]["data_cadastro_fun"]);
                nome_funcionario = dt.Rows[0]["nome"].ToString();
                rg = dt.Rows[0]["rg"].ToString();
                email = dt.Rows[0]["email"].ToString();
                cpf = dt.Rows[0]["cpf"].ToString();
                data_nascimento = Convert.ToDateTime(dt.Rows[0]["data_nascimento"]);
                sexo = dt.Rows[0]["sexo"].ToString();
                login = dt.Rows[0]["login"].ToString();
                senha = dt.Rows[0]["senha"].ToString();
                rua = dt.Rows[0]["rua"].ToString();
                numero = Convert.ToInt32(dt.Rows[0]["numero"]);
                complemento = dt.Rows[0]["complemento"].ToString();
                bairro = dt.Rows[0]["bairro"].ToString();
                cidade = dt.Rows[0]["cidade"].ToString();
                tipo_acesso = dt.Rows[0]["tipo_acesso"].ToString();
                estado = dt.Rows[0]["estado"].ToString();
                codigo_cargo = Convert.ToInt32(dt.Rows[0]["codigo_cargo"]);
                cep = dt.Rows[0]["cep"].ToString();
                telefone = dt.Rows[0]["telefone"].ToString();
                status = Convert.ToInt32(dt.Rows[0]["status_funcionario"]);





                return true;
            }
            else
            {

                return false;

            }


        }
        public bool AtualizarFuncionario()
        {
            string funcionario = "UPDATE funcionario SET nome = '" + nome_funcionario + "', data_nascimento = '" + data_nascimento.ToString("yyyy-MM-dd") + "', cpf = '" + cpf + "', rg = '" + rg + "', telefone = '" + telefone + "', sexo = '" + sexo + "', email = '" + email + "', login = '" + login + "', senha = '" + senha + "', tipo_acesso = '" + tipo_acesso + "', rua = '" + rua + "', bairro = '" + bairro + "', cidade = '" + cidade + "', estado = '" + estado + "', cep = '" + cep + "', complemento = '" + complemento + "', numero = '" + numero + "', status_funcionario = " + status + ", codigo_cargo = '" + codigo_cargo + "'WHERE codigo_funcionario = " + codigo_funcionario + " ";


            ClassConexao cConexao = new ClassConexao();

            int resp = cConexao.ExecutaQuery(funcionario);

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
            string query = "DELETE FROM funcionario WHERE codigo_funcionario = " + codigo_funcionario + "";
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

        


        //Relatório de cliente por idade


        //Relatório de funcionario 
        public DataTable RelfunCargo(int cargo)
        {
            string query = "SELECT funcionario.nome 'nome_funcionario', funcionario.telefone, funcionario.data_nascimento, funcionario.sexo, cargo.nome 'codigo_cargo' FROM funcionario JOIN cargo ON funcionario.codigo_cargo = cargo.codigo_cargo WHERE funcionario.status_funcionario = 1 and funcionario.codigo_cargo = " + cargo +" ORDER by funcionario.nome";

            ClassConexao cconexao = new ClassConexao();
            return cconexao.RetornaDataTable(query);

        }
        public DataTable RelfunStatus(int status)
        {
            string query = "SELECT funcionario.nome 'nome_funcionario', funcionario.telefone, funcionario.data_nascimento, funcionario.sexo, cargo.nome 'codigo_cargo' FROM funcionario JOIN cargo ON funcionario.codigo_cargo = cargo.codigo_cargo WHERE funcionario.status_funcionario = 1 and funcionario.status_funcionario = " + status + " ORDER by funcionario.nome";

            ClassConexao cconexao = new ClassConexao();
            return cconexao.RetornaDataTable(query);

        }
        public DataTable RelfunCidade(string cidade)
        {
            string query = "SELECT funcionario.nome 'nome_funcionario', funcionario.telefone, funcionario.data_nascimento, funcionario.sexo, cargo.nome 'codigo_cargo' FROM funcionario JOIN cargo ON funcionario.codigo_cargo = cargo.codigo_cargo WHERE funcionario.status_funcionario = 1 and funcionario.cidade like '%" + cidade + "%' ORDER by funcionario.nome";

            ClassConexao cconexao = new ClassConexao();
            return cconexao.RetornaDataTable(query);

        }
        public DataTable RelfunIdades(int idade1, int idade2)
        {
            string query = "SELECT funcionario.nome 'nome_funcionario', funcionario.telefone, funcionario.data_nascimento, funcionario.sexo, cargo.nome 'codigo_cargo' FROM funcionario JOIN cargo ON funcionario.codigo_cargo = cargo.codigo_cargo WHERE funcionario.status_funcionario = 1 and timestampdiff(YEAR, data_nascimento, now()) BETWEEN " + idade1 + " and " + idade2 + " ORDER by funcionario.nome";

            ClassConexao cconexao = new ClassConexao();
            return cconexao.RetornaDataTable(query);

        }
        public DataTable RelfunSexo(string sexo)
        {
            string query = "SELECT funcionario.nome 'nome_funcionario', funcionario.telefone, funcionario.data_nascimento, funcionario.sexo, cargo.nome 'codigo_cargo' FROM funcionario JOIN cargo ON funcionario.codigo_cargo = cargo.codigo_cargo WHERE funcionario.status_funcionario = 1 and funcionario.sexo = '" + sexo + "' ORDER by funcionario.nome";

            ClassConexao cconexao = new ClassConexao();
            return cconexao.RetornaDataTable(query);

        }


        //METODOS PARA VENDA

        public DataTable BuscarFuncionario()
        {
            string query = "SELECT codigo_funcionario, nome from funcionario WHERE status_funcionario = 1 order by nome ";

            ClassConexao cConexao = new ClassConexao();
            return cConexao.RetornaDataTable(query);

        }


    }
}