using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPapelariaHumanas
{
    class ClassVenda
    {
        //CONSTRUTOR DA CLASSE
        //SERVE PARA INICIALIZAR TODAS AS VARIAVEIS E PROPRIEDADES
        //PRECISA TER O MESMO NOME DA CLASSE
        public ClassVenda()
        {
            codigo_venda = 0;
            rua = null;
            bairro = null;
            cidade = null;
            estado = null;
            cep = null;
            complemento = null;
            numero = 0;            
            valor_total = 0;
            desconto = 0;
            forma_pagamento = null;
            data_venda = DateTime.Now;            
            codigo_funcionario = 0;
            codigo_cliente = 0;
        }

            //PROPRIEDADES 
            //SERVE PARA LER E GRAVAR AS INFORMAÇÕES 
            //ATALHO PARA CRIAR AS PROPRIEDADES
        public int codigo_venda { get; set; }

        public string rua { get; set; }

        public string bairro { get; set; }

        public string cidade { get; set; }

        public string estado { get; set; }

        public string cep { get; set; }

        public string complemento { get; set; }

        public int numero { get; set; }
                          
        public decimal valor_total { get; set; }

        public decimal desconto { get; set; }

        public string forma_pagamento { get; set; }

        public DateTime data_venda { get; set; }       

        public int codigo_funcionario { get; set; }

        public int codigo_cliente { get; set; }

        public bool CadastroVenda()
        {
            string query = "INSERT INTO venda VALUES (0, '" + rua + "', '" + bairro + "', '" + cidade + "', '" + estado + "', '" + cep + "', '" + complemento + "', " + numero + ", " + valor_total.ToString().Replace(",", ".") + ", " + desconto.ToString().Replace(",", ".") + ", '" + forma_pagamento + "', now(), " + codigo_funcionario + ", " + codigo_cliente + " );  SELECT LAST_INSERT_ID() ";

            ClassConexao cConexao = new ClassConexao();

            codigo_venda = 0;
            codigo_venda = cConexao.ExecutaQueryID(query);

            if(codigo_venda != 0)
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
