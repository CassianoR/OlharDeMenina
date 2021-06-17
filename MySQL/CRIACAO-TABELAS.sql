USE OlharMeninaBDlimpo;

CREATE TABLE Funcionarios (
	ID int unsigned not null auto_increment,
	Cargo char(20) not null,
	Nome char(50) not null,
	CPF char(14) not null,
	Senha int unsigned not null,
	Telefone varchar(20) not null,
	Endereco varchar(50) not null,
	PRIMARY KEY (ID, CPF)
);

CREATE TABLE Clientes (
	ID int unsigned not null auto_increment,
	Nome char(50) not null,
	CPF char(14) not null,
	Telefone varchar(20) not null,
	Endereco varchar(50) not null, 
    DataNasc date not null,
	PRIMARY KEY (ID)
);

CREATE TABLE Produto (
	Codigo int unsigned not null auto_increment,
    NomeProduto char(50) not null,
    Marca char(100) not null,
    Categoria char(1),
    Descricao varchar(500),
    Valor decimal(15,2) not null,
    PRIMARY KEY (Codigo)
);

CREATE TABLE Estoque (
	NumLote INT UNSIGNED NOT NULL,
    TotalProdutos INT NOT NULL,
	Frete DECIMAL(15,2),
    Fornecedor VARCHAR(100) NOT NULL,
    DataCompra DATE NOT NULL,
    PRIMARY KEY (NumLote)
);

CREATE TABLE EstoqueDetalhe (
    FK_NumLoteEstoque INT UNSIGNED NOT NULL,
    FK_CodigoProduto INT UNSIGNED NOT NULL,
    Quantidade INT NOT NULL,
    PrecoCusto DECIMAL(15,2) NOT NULL,
    Validade DATE NOT NULL,
    PRIMARY KEY (FK_NumLoteEstoque, FK_CodigoProduto),
    CONSTRAINT fk_estoqueDET FOREIGN KEY (FK_CodigoProduto) REFERENCES Produto(Codigo),
    CONSTRAINT fK_estoqueDET2 FOREIGN KEY (FK_NumLoteEstoque) REFERENCES Estoque(NumLote)
);

CREATE TABLE Vendas (
	Codigo int unsigned not null auto_increment,
    FK_IDFuncionario int unsigned not null,
    FK_IDCliente int unsigned not null,
    Valor decimal(15,2) not null,
    MetodoPagamento varchar(50) not null,
    DataHora datetime not null,
    PRIMARY KEY (Codigo, FK_IDFuncionario, FK_IDCliente),
    CONSTRAINT fk_vendas FOREIGN KEY (FK_IDFuncionario) REFERENCES Funcionarios(ID),
    CONSTRAINT fk_vendas1 FOREIGN KEY (FK_IDCliente) REFERENCES Clientes(ID)
);

CREATE TABLE VendasDetalhes (
	FK_CodigoVendas int unsigned not null,
    FK_CodigoProduto int unsigned not null,
    Quantidade INT UNSIGNED NOT NULL,
    CONSTRAINT fk_vDet FOREIGN KEY (FK_CodigoVendas) REFERENCES Vendas(Codigo),
    CONSTRAINT fk_vDet1 FOREIGN KEY (FK_CodigoProduto) REFERENCES Produto(Codigo)
);