namespace OlharDeMenina.Modelo
{
    internal class Funcionarios
    {
        public int ID { get; set; }
        public string Cargo { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Senha { get; set; }
        public string Telefone { get; set; }
        public string Endereço { get; set; }

        public Funcionarios(string Cargo, string Nome,  string CPF, string Senha, string Telefone, string Endereço)
        {
            this.Cargo = Cargo;
            this.Nome = Nome;
            this.CPF = CPF;
            this.Senha = Senha;
            this.Telefone = Telefone;
            this.Endereço = Endereço;
        }
    }
}