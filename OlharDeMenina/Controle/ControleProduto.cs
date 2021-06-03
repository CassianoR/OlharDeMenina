using MySql.Data.MySqlClient;
using OlharDeMenina.Modelo;

namespace OlharDeMenina.Controle
{
    internal class ControleProduto
    {
        public string AdicionarProdutos(Produtos produtos)
        {
            ProdutosDAO cli = new ProdutosDAO();
            string mensagem = cli.Adicionar(produtos);
            return mensagem;
        }

        public MySqlDataReader RetornarProdutos()
        {
            ClientesDAO cli = new ClientesDAO();
            return cli.RetornaClientes();
        }

        public MySqlDataReader RetornarProdutos(int idProd)
        {
            ProdutosDAO cli = new ProdutosDAO();
            return cli.RetornaProdutos();
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