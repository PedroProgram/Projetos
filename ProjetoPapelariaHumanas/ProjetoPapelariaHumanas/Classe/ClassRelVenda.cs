using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ProjetoPapelariaHumanas
{
    class ClassRelVenda
    {
        public ClassRelVenda()
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

            codigo_item_venda = 0;
            preco_venda = 0;
            quantidade = 0;
            codigo_produto = 0;
            codigo_venda = 0;


        }
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

        public int codigo_item_venda { get; set; }

        public decimal preco_venda { get; set; }

        public int quantidade { get; set; }

        public int codigo_produto { get; set; }

      //ClassRelVenda
      public DataTable RelatorioVenda(DateTime dinicio, DateTime dfinal)
        {
            string query = "SELECT venda.codigo_venda, venda.data_venda, venda.valor_total, venda.desconto,venda.forma_pagamento, itens_venda.quantidade, itens_venda.preco_venda, cliente.nome,funcionario.nome,produto.nome FROM cliente JOIN venda ON cliente.codigo_cliente = venda.codigo_cliente JOIN funcionario  ON funcionario.codigo_funcionario = venda.codigo_funcionario JOIN itens_venda ON itens_venda.codigo_venda = venda.codigo_venda JOIN produto ON produto.codigo_produto = itens_venda.codigo_produto WHERE CAST(venda.data_venda AS DATE) BETWEEN '"+ dinicio.ToString("yyyy-MM-dd") + "' AND '"+dfinal.ToString("yyyy-MM-dd")+"' ORDER BY venda.data_venda";

            ClassConexao cconexao = new ClassConexao();
            return cconexao.RetornaDataTable(query);
        }
        public DataTable RelatorioVendaCli(int cliente)
        {
            string query = "SELECT venda.codigo_venda, venda.data_venda, venda.valor_total, venda.desconto,venda.forma_pagamento, itens_venda.quantidade, itens_venda.preco_venda, cliente.nome 'codigo_cliente',funcionario.nome 'codigo_funcionario',produto.nome 'codigo_produto' FROM cliente JOIN venda ON cliente.codigo_cliente = venda.codigo_cliente JOIN funcionario  ON funcionario.codigo_funcionario = venda.codigo_funcionario JOIN itens_venda ON itens_venda.codigo_venda = venda.codigo_venda JOIN produto ON produto.codigo_produto = itens_venda.codigo_produto WHERE venda.codigo_cliente = " + cliente+" ORDER by cliente.nome";

            ClassConexao cconexao = new ClassConexao();
            return cconexao.RetornaDataTable(query);
        }
        public DataTable RelatorioVendaFun(int funcionario)
        {
            string query = "SELECT venda.codigo_venda, venda.data_venda, venda.valor_total, venda.desconto,venda.forma_pagamento, itens_venda.quantidade, itens_venda.preco_venda, cliente.nome 'codigo_cliente',funcionario.nome 'codigo_funcionario',produto.nome 'codigo_produto' FROM cliente JOIN venda ON cliente.codigo_cliente = venda.codigo_cliente JOIN funcionario  ON funcionario.codigo_funcionario = venda.codigo_funcionario JOIN itens_venda ON itens_venda.codigo_venda = venda.codigo_venda JOIN produto ON produto.codigo_produto = itens_venda.codigo_produto WHERE venda.codigo_funcionario = " + funcionario + " ORDER by funcionario.nome";

            ClassConexao cconexao = new ClassConexao();
            return cconexao.RetornaDataTable(query);
        }


    }
}
