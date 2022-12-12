using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ProjetoPapelariaHumanas
{
    class ClassItensVenda
    {
        //CONSTRUTOR DA CLASSE
        //SERVE PARA INICIALIZAR TODAS AS VARIAVEIS E PROPRIEDADES
        //PRECISA TER O MESMO NOME DA CLASSE
        public ClassItensVenda()
        {
            codigo_item_venda = 0;
            preco_venda = 0;
            quantidade = 0;
            codigo_produto = 0;
            codigo_venda = 0;

        }

        //PROPRIEDADES 
        //SERVE PARA LER E GRAVAR AS INFORMAÇÕES 
        //ATALHO PARA CRIAR AS PROPRIEDADES

        public int codigo_item_venda { get; set; }

        public decimal preco_venda { get; set; }

        public int quantidade { get; set; }

        public int codigo_produto { get; set; }

        public int codigo_venda { get; set; }


        //CRIAÇÃO DOS MÉTODOS (fUNCIONALIDADE DO SISTEMA)
        //CADASTRO - CONSULTA - ATUALIZAÇÃO - EXCLUSÃO
        //MÉTODO : TIPO MÉTODO - TIPO RETORNO - NOME DO MÉTODO - PARÂMETROS
        
        public bool CadastroItemVenda()
        {
            string query = " INSERT INTO itens_venda VALUES (0, " + preco_venda.ToString().Replace(",", ".") + ", " + quantidade + ", " + codigo_produto + ", " + codigo_venda + " ) ";

            ClassConexao cConexao = new ClassConexao();

            int resp = cConexao.ExecutaQuery(query);

            if(resp != 0)
            {
                return true;

            }
            else
            {
                return false;

            }

        }

















    }
}
