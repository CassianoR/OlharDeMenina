using OlharDeMenina.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlharDeMenina.Controle
{
    class ControleFuncionario
    {
       public string AdicionarFuncionarios(Funcionarios funcionario)
        {
            FuncionariosDAO func = new FuncionariosDAO();
            string mensagem = func.Adicionar(funcionario);
            return mensagem;
        }

        public SqlDataReader RetornarFuncionarios()
        {
            FuncionariosDAO funf = new FuncionariosDAO();
            return funf.DadosFuncionarios();
        }
        public SqlDataReader RetornarFuncionario(int IdFunf)
        {
            FuncionariosDAO funf = new FuncionariosDAO();
            return funf.DadosFuncionario(IdFunf);
        }
    }
}
