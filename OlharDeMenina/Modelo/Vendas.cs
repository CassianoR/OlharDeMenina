namespace OlharDeMenina.Modelo
{
    internal class Vendas
    {
        public int Codigo { get; set; }
        public int FK_CodigoFuncionario { get; set; }
        public int FK_CodigoCliente { get; set; }
        public string Valor { get; set; }
        public string MetodoPagamento { get; set; }
        public string DataHora { get; set; }

        public Vendas(int FK_CodigoFuncionario, int FK_CodigoCliente, string Valor, string MetodoPagamento, string DataHora)
        {
            this.FK_CodigoFuncionario = FK_CodigoFuncionario;
            this.FK_CodigoCliente = FK_CodigoCliente;
            this.Valor = Valor;
            this.MetodoPagamento = MetodoPagamento;
            this.DataHora = DataHora;
        }
    }
}