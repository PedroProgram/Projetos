using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace ProjetoPapelariaHumanas
{
    class ClassProduto
    {
        public ClassProduto()
        {
            //CONSTRUTOR DA CLASSE
            //SERVE PARA INICIALIZAR TODAS AS VARIAVEIS E PROPIEDADES
            //PRECISA TER O MESMO NOME DA CLASSE

            Codigo_Produto = 0;
            Nome = null;
            Quantidade = 0;
            Preco_Produto = 0;
            Data_Cadastro = DateTime.Now;
            status = 0;
            Codigo_Categoria = 0;
            Codigo_Marca = 0;
            Codigo_Fornecedor = 0;

        }

        //PROPIEDADES 
        //SERVE PARA LER E GRAVAR AS INFORMAÇÕES
        //ATALHO PARA CRIAR AS PROPIEDADES
        public int Codigo_Produto { get; set; }
        public String Nome { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco_Produto { get; set; }
        public DateTime Data_Cadastro { get; set; } 
        public int status { get; set; }
        public int Codigo_Categoria { get; set; }
        public int Codigo_Marca { get; set; }
        public int Codigo_Fornecedor { get; set; }

        // CRIAÇÃO DOS METODOS (FUNCIONALIDADE DO SISTEMA)
        //CADASTRO - CONSULTA - ATUALIZAÇÃO - EXCLUSÃO 
        //METODO : TIPO MÉTODO - TIPO RETORNO - NOME DO MÉTODO - PARÂMETROS
        //MÉTODO CRIAR PRODUTO

        public int cadastro_produto()
        {
            string query = "INSERT INTO produto values (0 , '" + Nome + "', " + Quantidade + ", " + Preco_Produto.ToString().Replace(",",".") + ", now(), 1, " + Codigo_Categoria + ", " + Codigo_Marca + "," + Codigo_Fornecedor + ")";

            ClassConexao cConexao = new ClassConexao();
            return cConexao.ExecutaQuery(query);


        }

        //CARREGAR COMBO FORNECEDOR
        public DataTable BuscarProduto()
        {
            string query = "SELECT codigo_produto, nome from produto Where status = 1 order by nome";

            ClassConexao conexao = new ClassConexao();
            return conexao.RetornaDataTable(query);

        }

        //método de consulta 
        //consulta de produto por nome - inicio e contem, cnpj, telefone
        //Campos exibidos na consulta: codigo_produto, Nome, CPF,data_cadastro_produto, cep, Telefone

        //Consulta de produto por nome - inicio

        public DataTable ConsultarProdutoNomeInicio(string nomei)
        {
            string query = "SELECT produto.codigo_produto, produto.nome, produto.quantidade, produto.preco_produto, produto.data_cadastro_produto, produto.status, categoria.nome, marca.nome_marca, fornecedor.nome FROM produto JOIN categoria ON produto.codigo_categoria = categoria.codigo_categoria JOIN  marca ON produto.codigo_marca = marca.codigo_marca JOIN fornecedor ON produto.codigo_fornecedor = fornecedor.codigo_fornecedor Where produto.status = 1  AND produto.nome like '" + nomei + "%' order by produto.nome";

            ClassConexao conexao = new ClassConexao();
            return conexao.RetornaDataTable(query);

        }

        //consulta de produto por nome - contém
        public DataTable ConsultarProdutoNomeContem(string nomec)
        {
            string query = "SELECT produto.codigo_produto, produto.nome, produto.quantidade, produto.preco_produto, produto.data_cadastro_produto, produto.status, categoria.nome, marca.nome_marca, fornecedor.nome FROM produto JOIN categoria ON produto.codigo_categoria = categoria.codigo_categoria JOIN  marca ON produto.codigo_marca = marca.codigo_marca JOIN fornecedor ON produto.codigo_fornecedor = fornecedor.codigo_fornecedor Where produto.status = 1  AND produto.nome like '" + nomec + "%' order by produto.nome";

            ClassConexao cConexao = new ClassConexao();
            return cConexao.RetornaDataTable(query);
        }

        //Consulta de fornecedor por nome - status
        public DataTable ConsultarProdutoStatus(int Status)
        {
            string query = "SELECT produto.codigo_produto, produto.nome, produto.quantidade, produto.preco_produto, produto.data_cadastro_produto, produto.status, categoria.nome, marca.nome_marca, fornecedor.nome FROM produto JOIN categoria ON produto.codigo_categoria = categoria.codigo_categoria JOIN  marca ON produto.codigo_marca = marca.codigo_marca JOIN fornecedor ON produto.codigo_fornecedor = fornecedor.codigo_fornecedor Where produto.status = " + Status + " order by produto.nome";

            ClassConexao cConexao = new ClassConexao();
            return cConexao.RetornaDataTable(query);
        }

       
        public DataTable ConsultarProdutoPreco(string preco)
        {

            string query = "SELECT produto.codigo_produto, produto.nome, produto.quantidade, produto.preco_produto, produto.data_cadastro_produto, produto.status, categoria.nome, marca.nome_marca, fornecedor.nome FROM produto JOIN categoria ON produto.codigo_categoria = categoria.codigo_categoria JOIN  marca ON produto.codigo_marca = marca.codigo_marca JOIN fornecedor ON produto.codigo_fornecedor = fornecedor.codigo_fornecedor  Where produto.status = 1 AND produto.preco_produto = '" + preco.Replace(",", ".")  + "' order by produto.nome";

            ClassConexao classConexao = new ClassConexao();
            return classConexao.RetornaDataTable(query);

        }






        //////////////////////////


        //MÉTODO

        public bool BuscarProduto(int cod)
        {
            string query = "SELECT * FROM produto Where codigo_produto = " + cod + " ";

            ClassConexao cConexao = new ClassConexao();
            DataTable dt = cConexao.RetornaDataTable(query);


            if (dt.Rows.Count > 0)
            {
                Codigo_Produto = Convert.ToInt32(dt.Rows[0]["codigo_produto"]);
                Nome = dt.Rows[0]["nome"].ToString();
                Quantidade = Convert.ToInt32(dt.Rows[0]["quantidade"]);
                Preco_Produto = Convert.ToInt32(dt.Rows[0]["preco_produto"]);
                Data_Cadastro = Convert.ToDateTime(dt.Rows[0]["data_cadastro_produto"]);
                status = Convert.ToInt32(dt.Rows[0]["status"]);
                Codigo_Categoria = Convert.ToInt32(dt.Rows[0]["codigo_categoria"]);
                Codigo_Marca = Convert.ToInt32(dt.Rows[0]["codigo_marca"]);
                Codigo_Fornecedor = Convert.ToInt32(dt.Rows[0]["codigo_fornecedor"]);
                

                return true;
            }
            else
            {
                return false;
            }

        }

        //METODO ATUALIZAR PRODUTO

        public int AtualizarPRoduto()
        {
            string query = " UPDATE produto SET nome = '" + Nome + "', quantidade = '" + Quantidade + "', preco_produto = " + Preco_Produto.ToString().Replace(",", ".") + ", codigo_categoria = " + Codigo_Categoria + ", codigo_marca = " + Codigo_Marca + ", codigo_fornecedor = " + Codigo_Fornecedor + ", status = " + status + " WHERE codigo_produto = " + Codigo_Produto + " ";

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

        // METODO EXCLUIR PRODUTO

        public bool ExcluirProduto()
        {
            string query = "DELETE FROM produto WHERE produto.codigo_produto = " + Codigo_Produto + " ";

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

        //Consultar Produto Quantidade
        public DataTable ConsultarProdutoQuantidade(string quantidade)
        {

            string query = "SELECT produto.codigo_produto, produto.nome, produto.quantidade, produto.preco_produto, produto.data_cadastro_produto, produto.status, categoria.nome, marca.nome_marca, fornecedor.nome FROM produto JOIN categoria ON produto.codigo_categoria = categoria.codigo_categoria JOIN  marca ON produto.codigo_marca = marca.codigo_marca JOIN fornecedor ON produto.codigo_fornecedor = fornecedor.codigo_fornecedor  Where produto.status = 1 AND produto.quantidade = '" + quantidade + "' order by produto.nome";

            ClassConexao classConexao = new ClassConexao();
            return classConexao.RetornaDataTable(query);

        }

        public DataTable ConsultarProdutoData(DateTime data)
        {

            string query = "SELECT produto.codigo_produto, produto.nome, produto.quantidade, produto.preco_produto, produto.data_cadastro_produto, produto.status, categoria.nome, marca.nome_marca, fornecedor.nome FROM produto JOIN categoria ON produto.codigo_categoria = categoria.codigo_categoria JOIN  marca ON produto.codigo_marca = marca.codigo_marca JOIN fornecedor ON produto.codigo_fornecedor = fornecedor.codigo_fornecedor  Where produto.status = 1 AND CAST(produto.data_cadastro_produto AS DATE) = '" + data.ToString("yyyy/MM/dd") + "' order by produto.nome";

            ClassConexao classConexao = new ClassConexao();
            return classConexao.RetornaDataTable(query);

        }


        //////
        ///

        ///// METODOS DE RELATORIOS


        //METODO DE RELATÓRIO POR QUANTIDADE
        public DataTable RelatorioProdutoQuantidade(string quantidade)
        {
            string query = "SELECT produto.codigo_produto 'Codigo_Produto', produto.nome 'Nome', produto.quantidade 'Quantidade', produto.preco_produto 'Preco_Produto', categoria.nome 'Codigo_Categoria' , produto.status FROM produto  JOIN categoria ON categoria.codigo_categoria = produto.codigo_categoria WHERE produto.status = 1 AND produto.quantidade = '" + quantidade + "' ORDER BY .produto.nome";

            ClassConexao cConexao = new ClassConexao();
            return cConexao.RetornaDataTable(query);

        }

        //METODO DE RELATÓRIO POR PREÇO
        public DataTable RelatorioProdutoPreco(string preco)
        {
            string query = "SELECT produto.codigo_produto 'Codigo_Produto', produto.nome 'Nome', produto.quantidade 'Quantidade', produto.preco_produto 'Preco_Produto', categoria.nome 'Codigo_Categoria' , produto.status FROM produto  JOIN categoria ON categoria.codigo_categoria = produto.codigo_categoria WHERE produto.status = 1 AND produto.preco_produto = " + preco.ToString().Replace(",", ".") + " ORDER BY produto.nome";

            ClassConexao cConexao = new ClassConexao();
            return cConexao.RetornaDataTable(query);

        }

        //MÉTODO DE RELATÓRIO POR STATUS
        public DataTable RelatorioProdutoStatus(int status)
        {
            string query = "SELECT produto.codigo_produto 'Codigo_Produto', produto.nome 'Nome', produto.quantidade 'Quantidade', produto.preco_produto 'Preco_Produto', categoria.nome 'Codigo_Categoria' , produto.status FROM produto  JOIN categoria ON categoria.codigo_categoria = produto.codigo_categoria WHERE produto.status = " + status + " order by produto.nome";

            ClassConexao cConexao = new ClassConexao();
            return cConexao.RetornaDataTable(query);

        }

        //MÉTODO DE RELATÓRIO POR DATA CADASTRO POR MÊS
        public DataTable RelatorioProdutoCadastroMes(string datacad)
        {

            string query = "SELECT produto.codigo_produto 'Codigo_Produto', produto.nome 'Nome', produto.quantidade 'Quantidade', produto.preco_produto 'Preco_Produto', categoria.nome 'Codigo_Categoria' , produto.status FROM produto  JOIN categoria ON categoria.codigo_categoria = produto.codigo_categoria WHERE produto.status = 1  AND MONTH(data_cadastro_produto) = '" + datacad + "' order by nome";

            ClassConexao classConexao = new ClassConexao();
            return classConexao.RetornaDataTable(query);

        }

        //MÉTODO DE RELATÓRIO POR DATA CADASTRO POR DATA
        public DataTable RelatorioProdutoData(DateTime data)
        {

            string query = "SELECT produto.codigo_produto 'Codigo_Produto', produto.nome 'Nome', produto.quantidade 'Quantidade', produto.preco_produto 'Preco_Produto', categoria.nome 'Codigo_Categoria' , produto.status FROM produto  JOIN categoria ON categoria.codigo_categoria = produto.codigo_categoria WHERE produto.status = 1 AND CAST(produto.data_cadastro_produto AS DATE) = '" + data.ToString("yyyy/MM/dd") + "' order by nome";

            ClassConexao classConexao = new ClassConexao();
            return classConexao.RetornaDataTable(query);

        }
        ///
        /// 
        /// 
        /// 
        /// 
       
        
        
        
        ///METODO PARA VENDA

        public DataTable ConsultarProdutoNomeContemVenda(string nomec)
        {
            string query = "SELECT produto.codigo_produto, produto.nome, produto.quantidade, produto.preco_produto, marca.nome_marca  FROM produto JOIN  marca ON produto.codigo_marca = marca.codigo_marca Where produto.status = 1  AND produto.nome like '%" + nomec + "%' order by produto.nome";

            ClassConexao cConexao = new ClassConexao();
            return cConexao.RetornaDataTable(query);
        }

        //METODO PARA ATUALIZAR QTDE ESTOQUE QUANDO UMA VENDA É FINALIZADA

        public bool AtualizarQuantidadeVenda(int quantidade, int cod)
        {
            string query = "UPDATE produto SET quantidade = " + quantidade + " WHERE codigo_produto = " + cod + " ";

            ClassConexao cConexao = new ClassConexao();

            int resp = cConexao.ExecutaQuery(query);

            if(resp == 1)
            {
                return true;

            }
            else
            {
                return false;

            }

        }

        //METODO PARA LEVAR NOME DO PRODUTO PARA A LISTA DE ITENS 
        //(GRID DE PRODUTOS VENDIDOS)        
        public string BuscarNomeProdVenda(int cod)
        {
            string query = "SELECT nome FROM produto WHERE codigo_produto = " + cod + " ";

            ClassConexao cConexao = new ClassConexao();
            DataTable dt = cConexao.RetornaDataTable(query);

            if (dt.Rows.Count > 0)
            {
                Nome = dt.Rows[0]["nome"].ToString();
            }
            return Nome;

        }

























    }
}
