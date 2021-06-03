namespace OlharDeMenina.Modelo
{
    internal class Produtos
    {
        public int Codigo { get; set; }
        public string NomeProduto { get; set; }
        public string Marca { get; set; }
        public string Categoria { get; set; }
        public string Descricao { get; set; }
        public string Valor { get; set; }

        public Produtos(string NomeProduto, string Marca, string Categoria, string Descricao, string Valor)
        {
            this.NomeProduto = NomeProduto;
            this.Marca = Marca;
            this.Categoria = Categoria;
            this.Descricao = Descricao;
            this.Valor = Valor;
        }
    }
}