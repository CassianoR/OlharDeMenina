CREATE DATABASE OlharMeninaBD;
USE OlharMeninaBD;

/* -----------------------------------*/
-- === CRIAÇÃO DE TABELAS === --
-- === Arrumei uns detalhes, tipo uns In que era minusculo e esta maiusculo, estragando o visual === --
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
    	NumLote int unsigned not null,
    	TotalProdutos int not null,
    	Frete decimal(15,2),
    	Fornecedor varchar(100) not null,
    	DataCompra date not null,
    	PRIMARY KEY (NumLote)
);

CREATE TABLE EstoqueDetalhe (
    	FK_NumLoteEstoque int unsigned not null,
    	FK_CodigoProduto int unsigned not null,
    	Quantidade int not null,
    	PrecoCusto decimal(15,2) not null,
    	Validade date not null,
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
    	Quantidade int unsigned not null,
    	CONSTRAINT fk_vDet FOREIGN KEY (FK_CodigoVendas) REFERENCES Vendas(Codigo),
    	CONSTRAINT fk_vDet1 FOREIGN KEY (FK_CodigoProduto) REFERENCES Produto(Codigo)
);

/* -----------------------------------*/
-- === CONSULTAS ===
SELECT * FROM Funcionarios;
SELECT * FROM Clientes;
SELECT * FROM Produto;
SELECT * FROM Estoque;
SELECT * FROM Vendas;
SELECT * FROM VendasDetalhes;

/* -----------------------------------*/
-- === CRIAÇÃO DE VIEWS ===
CREATE VIEW vw_ExibeVendas
AS SELECT tbl_funcionarios.Nome AS Funcionário, tbl_clientes.Nome AS Clientes, tbl_vendas.Valor, tbl_vendas.MetodoPagamento, tbl_vendas.DataHora 
FROM Vendas tbl_vendas, Funcionarios tbl_funcionarios, Clientes tbl_clientes
WHERE tbl_vendas.FK_IDFuncionario = tbl_funcionarios.ID AND tbl_clientes.ID = tbl_vendas.FK_IDCliente;


-- INSERÇÃO PARA TESTE
INSERT INTO Funcionarios (ID, Cargo, Nome, CPF, Senha, Telefone, Endereco) values ('1', "Administrador", "João", "111.111.111-11",'1234',"99999-9999","Rua Do Palmito");
INSERT INTO Funcionarios (Cargo, Nome, CPF, Senha, Telefone, Endereco) values ("Caixa", "Janaína", "445.555.555-55",'1234',"99999-9999","Rua Do Limão");
INSERT INTO Funcionarios (Cargo, Nome, CPF, Senha, Telefone, Endereco) values ("Cozinheiro", "ll", "455.555.555-55",'1234',"99999-9999","Rua Do Limão");

INSERT INTO Clientes (ID, Nome, CPF, Telefone, Endereco, DataNasc) values (1, "Gorete", '11111-1111', '1234', "Rua Do Palmito", '1999-02-15');
INSERT INTO Clientes (Nome, CPF, Telefone, Endereco, DataNasc) values ("Shayene", '22222-2222', '1234', "Rua Do Laranja", '2003-06-12');
INSERT INTO Clientes (Nome, CPF, Telefone, Endereco, DataNasc) values ("Louise",'99999-9999','1234', "Rua Do sda", '1985-07-25');

INSERT INTO Produto (Codigo, NomeProduto, Marca, Categoria, Descricao, Valor) values ('1',"Batom", "Marca w", 'p', 'aaaa', '15.50');
INSERT INTO Produto (NomeProduto, Marca, Categoria, Descricao, Valor) values ("Base", "Marca y", 'o', 'bbbb', '16.90');
INSERT INTO Produto (NomeProduto, Marca, Categoria, Descricao, Valor) values ("Delineador", "Marca z", 'b', 'cccc', '99.90');

INSERT INTO Estoque (NumLote, TotalProdutos, Frete, Fornecedor, DataCompra) values ('1', '100', '155.50', 'Fornecedor X', '2021-06-12');
INSERT INTO Estoque (NumLote, TotalProdutos, Frete, Fornecedor, DataCompra) values ('2', '200', '455.60', 'Fornecedor Y', '2021-04-07');
INSERT INTO Estoque (NumLote, TotalProdutos, Frete, Fornecedor, DataCompra) values ('3', '300', '899.60', 'Fornecedor Z', '2021-07-04');

INSERT INTO EstoqueDetalhe (FK_NumLoteEstoque, FK_CodigoProduto, Quantidade, PrecoCusto, Validade) values ('1', '2', '36', '36.50', '2021-06-26');
INSERT INTO EstoqueDetalhe (FK_NumLoteEstoque, FK_CodigoProduto, Quantidade, PrecoCusto, Validade) values ('2', '3', '45', '45.80', '2021-07-26');
INSERT INTO EstoqueDetalhe (FK_NumLoteEstoque, FK_CodigoProduto, Quantidade, PrecoCusto, Validade) values ('3', '1', '78', '89.45', '2021-06-01');

INSERT INTO Vendas (Codigo, FK_IDFuncionario, FK_IDCliente, Valor, MetodoPagamento, DataHora) values ('1', '1', '1', '555.53', 'Cartão de Crédito', '2021-06-01 12:53:10');
INSERT INTO Vendas (FK_IDFuncionario, FK_IDCliente, Valor, MetodoPagamento, DataHora) values ('2', '3', '322.58', 'Cartão de Débito', '2021-06-02 11:30:10');
INSERT INTO Vendas (FK_IDFuncionario, FK_IDCliente, Valor, MetodoPagamento, DataHora) values ('3', '2', '80.50', 'Dinheiro', '2021-06-03 04:10:02');

INSERT INTO VendasDetalhes (FK_CodigoVendas, FK_CodigoProduto, Quantidade) values ('1', '1', '12');
INSERT INTO VendasDetalhes (FK_CodigoVendas, FK_CodigoProduto, Quantidade) values ('1', '2', '9');
INSERT INTO VendasDetalhes (FK_CodigoVendas, FK_CodigoProduto, Quantidade) values ('2', '3', '5');
