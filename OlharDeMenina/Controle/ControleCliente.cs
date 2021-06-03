using MySql.Data.MySqlClient;
using OlharDeMenina.Modelo;

namespace OlharDeMenina.Controle
{
    internal class ControleCliente
    {
        public string AdicionarClientes(Clientes clientes)
        {
            ClientesDAO cli = new ClientesDAO();
            string mensagem = cli.Adicionar(clientes);
            return mensagem;
        }

        public MySqlDataReader RetornarClientes()
        {
            ClientesDAO cli = new ClientesDAO();
            return cli.RetornaClientes();
        }

        public MySqlDataReader RetornarClientes(int idClien)
        {
            ClientesDAO cli = new ClientesDAO();
            return cli.RetornaClientes();
        }

        public string DeletarClientes(int idClien)
        {
            ClientesDAO cli = new ClientesDAO();
            return cli.DeletarClientes(idClien);
        }

        public string EditarClientes(Clientes clientes, int idClien)
        {
            ClientesDAO cli = new ClientesDAO();
            string mensagem = cli.EditarClientes(clientes, idClien);

            return mensagem;
        }
    }
}