using OlharDeMenina.Modelo;

namespace OlharDeMenina.Controle
{
    internal class ControleFuncionario
    {
        public string AdicionarFuncionarios(Funcionarios funcionario)
        {
            FuncionariosDAO func = new FuncionariosDAO();
            string mensagem = func.Adicionar(funcionario);
            return mensagem;
        }

        // public MySqlDataReader RetornarFuncionarios()
        // {
        //     FuncionariosDAO funf = new FuncionariosDAO();
        //return funf.DadosFuncionarios();
        // }

        //  public MySqlDataReader RetornarFuncionario(int IdFunf)
        // {
        //    FuncionariosDAO funf = new FuncionariosDAO();
        //return funf.DadosFuncionario(IdFunf);
        // }
    }
}