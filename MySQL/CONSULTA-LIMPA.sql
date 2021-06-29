CREATE DATABASE OlharMeninaBD;
USE OlharMeninaBD;

/* -----------------------------------*/
-- === CRIAÇÃO DE TABELAS === --
-- === Arrumei uns detalhes, tipo uns In que era minusculo e esta maiusculo, estragando o visual === --
CREATE TABLE Funcionarios (
	ID INT not null IDENTITY (1,1),
	Cargo VARCHAR (50) not null,
	Nome VARCHAR (50) not null,
	CPF CHAR (14) not null UNIQUE,
	Senha INT not null,
	Endereco VARCHAR (80) not null,
	Telefone VARCHAR (20) not null,
	PRIMARY KEY (ID)
)
GO

CREATE TABLE Clientes (
	ID INT not null IDENTITY (1,1),
	Nome VARCHAR (50) not null,
	CPF CHAR (14) not null UNIQUE,
	Endereco VARCHAR (80) not null,
	Telefone VARCHAR (20) not null,
	DataNasc DATE not null,
	PRIMARY KEY (ID)
)
GO

CREATE TABLE Produto (
	Codigo INT not null IDENTITY (1,1),
	NomeProduto VARCHAR(50) not null,
	Marca VARCHAR (100) not null,
	Categoria CHAR (1)not null,
	Descricao VARCHAR (100) not null,
	Valor DECIMAL (15,2) not null,
	PRIMARY KEY (Codigo)
)
GO


CREATE TABLE Estoque (
	ID INT not null IDENTITY (1,1),
	NumLote INT not null,
	TotalProdutosLote INT not null,
	Frete DECIMAL (15,2) not null,
	Fornecedor VARCHAR (80) not null,
	DataCompra DATE not null,
	PrecoLote DECIMAL (15,2) not null,
	QuantidadeEstoque INT not null,
	Validade DATE,
	FK_CodigoProduto INT not null,
	CONSTRAINT FK_Estoque FOREIGN KEY (FK_CodigoProduto) REFERENCES Produto (Codigo),
	PRIMARY KEY (ID)
)
GO

CREATE TABLE Vendas (
	CodigoVendas INT not null IDENTITY (1,1),
	FK_IDFuncionario INT not null,
	FK_IDCliente INT not null,
	FK_CodigoProduto INT not null,
	Valor DECIMAL (15,2) not null,
	MetodoPagamento VARCHAR (50) not null,
	DataHora DATETIME not null,
	QuantidadeVendida INT not null,
	CONSTRAINT FK_Venda  FOREIGN KEY (FK_IDFuncionario) REFERENCES Funcionarios (ID),
	CONSTRAINT FK_Venda2 FOREIGN KEY (fK_IDCliente)	REFERENCES Clientes (ID),
	CONSTRAINT FK_Venda3 FOREIGN KEY (FK_CodigoProduto) REFERENCES Produto (Codigo),
	PRIMARY KEY (CodigoVendas)
)
GO

/* -----------------------------------*/
-- === CONSULTAS ===
SELECT * FROM Funcionarios;
SELECT * FROM Clientes;
SELECT * FROM Produto;
SELECT * FROM Estoque;
SELECT * FROM Vendas;

-- INSERÇÃO PARA TESTE
INSERT INTO Funcionarios (Cargo, Nome, CPF, Senha, Telefone, Endereco) values ('Administrador', 'João', '111.111.111-11','1234','98999-9999','Rua Do Palmito');
INSERT INTO Funcionarios (Cargo, Nome, CPF, Senha, Telefone, Endereco) values ('Caixa', 'Janaína', '555.555.555-55','1234','99999-9999','Rua Do Limão');
INSERT INTO Funcionarios (Cargo, Nome, CPF, Senha, Telefone, Endereco) values ('Cozinheiro', 'll', '455.555.555-55','1234','99999-9999','Rua Do Limão');

INSERT INTO Clientes (Nome, CPF, Telefone, Endereco, DataNasc) values ('Gorete', '11111-1111', '1234', 'Rua Do Palmito', '1999-02-15');
INSERT INTO Clientes (Nome, CPF, Telefone, Endereco, DataNasc) values ('Shayene', '22222-2222', '1234', 'Rua Do Laranja', '2003-06-12');
INSERT INTO Clientes (Nome, CPF, Telefone, Endereco, DataNasc) values ('Louise','99999-9999','1234', 'Rua Do sda', '1985-07-25');

INSERT INTO Produto (NomeProduto, Marca, Categoria, Descricao, Valor) values ('Batom', 'Marca x', 'p', 'aaaa', '15.50');
INSERT INTO Produto (NomeProduto, Marca, Categoria, Descricao, Valor) values ('Base', 'Marca y', 'o', 'bbbb', '16.90');
INSERT INTO Produto (NomeProduto, Marca, Categoria, Descricao, Valor) values ('Delineador', 'Marca z', 'b', 'cccc', '99.90');

INSERT INTO Estoque (FK_CodigoProduto, NumLote, TotalProdutosLote, Frete, Fornecedor, DataCompra, QuantidadeEstoque, PrecoLote, Validade) values (1, '1', '100', '155.50', 'Fornecedor X', '2021-06-12', 11,'123.11', '2022-01-01');
INSERT INTO Estoque (FK_CodigoProduto, NumLote, TotalProdutosLote, Frete, Fornecedor, DataCompra, QuantidadeEstoque, PrecoLote, Validade) values (2, '2', '200', '455.60', 'Fornecedor Y', '2021-04-07', 14,'103.51', '2023-01-01');
INSERT INTO Estoque (FK_CodigoProduto, NumLote, TotalProdutosLote, Frete, Fornecedor, DataCompra, QuantidadeEstoque, PrecoLote, Validade) values (3, '3', '300', '899.60', 'Fornecedor Z', '2021-07-04', 21,'153.11', '2024-01-01');

INSERT INTO Vendas (FK_IDFuncionario, FK_IDCliente,FK_CodigoProduto, Valor, MetodoPagamento, DataHora, QuantidadeVendida) values ('1', '1','1', '555.53', 'Cartão de Crédito', '2021-06-01 12:53:10', 14);
INSERT INTO Vendas (FK_IDFuncionario, FK_IDCliente,FK_CodigoProduto, Valor, MetodoPagamento, DataHora, QuantidadeVendida) values ('2', '3','2', '322.58', 'Cartão de Débito', '2021-06-02 11:30:10', 44);
INSERT INTO Vendas (FK_IDFuncionario, FK_IDCliente,FK_CodigoProduto, Valor, MetodoPagamento, DataHora, QuantidadeVendida) values ('3', '2','3', '80.50', 'Dinheiro', '2021-06-03 04:10:02', 23);
