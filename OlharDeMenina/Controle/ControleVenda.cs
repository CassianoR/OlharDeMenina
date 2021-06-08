using MySql.Data.MySqlClient;
using OlharDeMenina.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlharDeMenina.Controle
{
    class ControleVenda
    {
        public string AdicionarVendas(Vendas vendas)
        {
            VendasDAO ven = new VendasDAO();
            string mensagem = ven.Adicionar(vendas);
            return mensagem;
        }

        public MySqlDataReader RetornarVendas()
        {
            VendasDAO ven = new VendasDAO();
            return ven.RetornaVendas();
        }

        public MySqlDataReader RetornarProdutos(int idProd)
        {
            ProdutosDAO cli = new ProdutosDAO();
            return cli.RetornaProdutos(idProd);
        }

        public string DeletarProdutos(int idProd)
        {
            ProdutosDAO cli = new ProdutosDAO();
            return cli.DeletarProdutos(idProd);
        }

        public string EditarProdutos(Produtos produtos, int idProd)
        {
            ProdutosDAO cli = new ProdutosDAO();
            string mensagem = cli.EditarProdutos(produtos, idProd);

            return mensagem;
        }
    }
}
