namespace OlharDeMenina.Modelo
{
    internal class Clientes
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Endereço { get; set; }
        public string DataNasc { get; set; }

        public Clientes(string Nome, string Telefone, string Endereço, string DataNasc)
        {
            this.Nome = Nome;
            this.Telefone = Telefone;
            this.Endereço = Endereço;
            this.DataNasc = DataNasc;
        }
    }
}