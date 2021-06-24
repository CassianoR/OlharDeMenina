CREATE DATABASE OlharMeninaBD;
USE OlharMeninaBD;

CREATE TABLE Funcionarios (
	ID int unsigned not null auto_increment,
	Cargo char(20) not null,
	Nome char(50) not null,
	CPF char(14) not null,
	Senha int unsigned not null,
	Telefone varchar(20) not null,
	Endereço char(50) not null,
	PRIMARY KEY (ID, CPF)
);

CREATE TABLE Clientes (
	ID int unsigned not null auto_increment,
	Nome char(50) not null,
	CPF char(14) not null,
	Telefone varchar(20) not null,
	Endereço varchar(50) not null, 
    DataNasc date not null,
	PRIMARY KEY (ID)
);

CREATE TABLE Produto (
	Codigo int unsigned not null auto_increment,
    NomeProduto char(50) not null,
    Marca char(100) not null,
    Categoria char(1),
    Quantidade int unsigned not null,
    Descricao varchar(500),
    Preco decimal(15,2) not null,
    PRIMARY KEY (Codigo)
);

-- INSERÇÃO PARA TESTE
INSERT INTO Funcionarios (ID, Cargo, Nome, CPF, Senha, Telefone, Endereço) values ('1', "Administrador", "João", "111.111.111-11",'1234',"99999-9999","Rua Do Palmito");
INSERT INTO Funcionarios (Cargo, Nome, CPF, Senha, Telefone, Endereço) values ("Caixa", "Janaína", "555.555.555-55",'1234',"99999-9999","Rua Do Limão");
INSERT INTO Funcionarios (Cargo, Nome, CPF, Senha, Telefone, Endereço) values ("Cozinheiro", "ll", "455.555.555-55",'1234',"99999-9999","Rua Do Limão");

INSERT INTO Clientes (ID, Nome, CPF, Telefone, Endereco, DataNasc) values (1, "Gorete", '11111-1111', '1234', "Rua Do Palmito", '1999-02-15');
INSERT INTO Clientes (Nome, CPF, Telefone, Endereco, DataNasc) values ("Shayene", '22222-2222', '1234', "Rua Do Laranja", '2003-06-12');
INSERT INTO Clientes (Nome, CPF, Telefone, Endereco, DataNasc) values ("Louise",'99999-9999','1234', "Rua Do sda", '1985-07-25');

INSERT INTO Produto (Codigo, NomeProduto, Marca, Categoria, Descricao, Valor) values ('1',"Batom", "Marca x", 'p', 'aaaa', '15.50');
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

INSERT INTO VendasDetalhes (FK_CodigoVendas, FK_CodigoProduto) values ('1', '1');
INSERT INTO VendasDetalhes (FK_CodigoVendas, FK_CodigoProduto) values ('1', '2');
INSERT INTO VendasDetalhes (FK_CodigoVendas, FK_CodigoProduto) values ('2', '3');

UPDATE VendasDetalhes SET Quantidade = 4 WHERE FK_CodigoProduto = '1';
UPDATE VendasDetalhes SET Quantidade = 4 WHERE FK_CodigoProduto = '2';
UPDATE VendasDetalhes SET Quantidade = 4 WHERE FK_CodigoProduto = '3';
 
-- === CASO PRECISE DROPAR UMA TABELA ==
DROP TABLE Funcionarios;
DROP TABLE Clientes;
DROP TABLE Produto;
DROP TABLE Estoque;
DROP TABLE Vendas;
DROP TABLE VendasDetalhes;
/* -----------------------------------*/
-- === CONSULTAS ===
SELECT * FROM Funcionarios;
SELECT * FROM Clientes;
SELECT * FROM Produto;
SELECT * FROM Estoque;
SELECT * FROM Vendas;
SELECT * FROM VendasDetalhes;
/* -----------------------------------*/
-- === VIEWS ===
SELECT * FROM vw_ExibeVendas;
SELECT * FROM vw_ExibeEstoque;
/* -----------------------------------*/
-- === COMENTÁRIOS ===
-- 15/05 
-- Thiago: Adiocinei o DataNasc date not null na tabela Clientes
-- Thiago: Retirei a PK da tabela Clientes
-- Thiago: Excluí a tabela Estoque e suas consultas
-- Thiago: Adicionei Quantidade e Preco na tabela Produto
-- 01/06
-- Thiago: Alterei o nome de ID para Codigo na tabela Cliente
-- Thiago: Alterei o nome de Endereço para Endereco na tabela Cliente
-- Thiago: Excluí a coluna CPF pois não constava no modelo lógico
-- Thiago: Alterei a coluna Preco para Valor na tabela Produto
-- Thiago: Excluí a coluna Quantidade da tabela Produto pois será criada na tabela estoque
-- Thiago: Criei a tabela Estoque
-- Thiago: Criei a tabela Vendas
-- Thiago: Criei a tabela VendasDetalhes
-- 11/06
-- Thiago: Alterei a coluna Codigo para ID na tabela Cliente - padronizar ID para pessoa e Codigo para objeto
-- Thiago: Alterei na tabela Vendas manualmente corrigindo o nome da coluna FK_CodigoCliente por FK_IDCliente
-- Thiago: Retirei a coluna FK_CodigoProduto e a Coluna Quantidade da tabela Estoque
-- Thiago: Inseri as colunas que dizem respeito as características do lote na tabela Estoque
-- Thiago: Criei a tabela EstoqueDetalhe que contém o detalhamento em relação aos produtos de cada lote
-- Thiago: Inseri a coluna Quantidade na tabela VendasDetalhes com objetivo de colocar a quantidade que foi vendida de cada produto
-- Thiago: Excluí a view ExibeEstoque
-- Thiago: Alterei a view ExibeVendas pois ela referenciava a coluna Codigo do Cliente e o Cliente possui ID
-- Thiago: Alterei a Inserção de dados na tabela Estoque e EstoqueDetalhes
-- Thiago: Adicionei dados na coluna Quantidade da tabela VendaDetalhes 
-- Thiago: Fiz as alterações com objetivo de padronizar a coluna Endereco nas tabelas CLientes e Funcionarios
-- Thiago: Testando fazer alterações no GitHub pela primeira vez


ALTER TABLE Clientes CHANGE ID Codigo int unsigned not null auto_increment;
ALTER TABLE Clientes CHANGE Endereço Endereco varchar(50);
ALTER TABLE Clientes DROP COLUMN CPF;

ALTER TABLE Produto CHANGE Preco Valor decimal(15,2);
ALTER TABLE Produto DROP COLUMN Quantidade;

CREATE TABLE Estoque (
	FK_CodigoProduto int unsigned not null,
    Quantidade int not null,
	PRIMARY KEY (FK_CodigoProduto),
	CONSTRAINT fk_estoque FOREIGN KEY (FK_CodigoProduto) REFERENCES Produto(Codigo)
);

CREATE TABLE Vendas (
	Codigo int unsigned not null auto_increment,
    FK_IDFuncionario int unsigned not null,
    FK_CodigoCliente int unsigned not null,
    Valor decimal(15,2) not null,
    MetodoPagamento varchar(50) not null,
    DataHora datetime not null,
    PRIMARY KEY (Codigo, FK_IDFuncionario, FK_CodigoCliente),
    CONSTRAINT fk_vendas FOREIGN KEY (FK_IDFuncionario) REFERENCES Funcionarios(ID),
    CONSTRAINT fk_vendas1 FOREIGN KEY (FK_CodigoCliente) REFERENCES Clientes(Codigo)
);

CREATE TABLE VendasDetalhes (
	FK_CodigoVendas int unsigned not null,
    FK_CodigoProduto int unsigned not null,
    CONSTRAINT fk_vDet FOREIGN KEY (FK_CodigoVendas) REFERENCES Vendas(Codigo),
    CONSTRAINT fk_vDet1 FOREIGN KEY (FK_CodigoProduto) REFERENCES Produto(Codigo)
);

ALTER TABLE Clientes ADD COLUMN CPF char(14) not null;

CREATE VIEW vw_ExibeVendas
AS SELECT tbl_funcionarios.Nome AS Funcionário, tbl_clientes.Nome AS Clientes, tbl_vendas.Valor, tbl_vendas.MetodoPagamento, tbl_vendas.DataHora 
FROM Vendas tbl_vendas, Funcionarios tbl_funcionarios, Clientes tbl_clientes
WHERE tbl_vendas.FK_IDFuncionario = tbl_funcionarios.ID AND tbl_clientes.Codigo = tbl_vendas.FK_CodigoCliente;

CREATE VIEW vw_ExibeEstoque 
AS SELECT tbl_produto.NomeProduto AS 'Nome do Produto', tbl_produto.Marca AS 'Marca do Produto', tbl_produto.Categoria AS 'Categoria do Produto', tbl_produto.Descricao AS 'Descrição do Produto', tbl_estoque.Quantidade AS 'Quantidade do Produto',tbl_produto.Valor AS 'Valor do Produto'
FROM Estoque tbl_estoque, Produto tbl_produto
WHERE tbl_estoque.FK_CodigoProduto = tbl_produto.Codigo;

ALTER TABLE Clientes CHANGE Codigo ID int unsigned not null auto_increment;
ALTER TABLE Vendas CHANGE FK_CodigoCliente FK_IDCliente int unsigned not null;

ALTER TABLE VendasDetalhes DROP FOREIGN KEY fk_vDet1;
DROP TABLE Estoque;

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


ALTER TABLE VendasDetalhes ADD COLUMN Quantidade INT UNSIGNED NOT NULL;
DROP VIEW vw_ExibeEstoque;

ALTER VIEW vw_ExibeVendas
AS SELECT tbl_funcionarios.Nome AS Funcionário, tbl_clientes.Nome AS Clientes, tbl_vendas.Valor, tbl_vendas.MetodoPagamento, tbl_vendas.DataHora 
FROM Vendas tbl_vendas, Funcionarios tbl_funcionarios, Clientes tbl_clientes
WHERE tbl_vendas.FK_IDFuncionario = tbl_funcionarios.ID AND tbl_clientes.ID = tbl_vendas.FK_IDCliente;


ALTER TABLE Funcionarios CHANGE Endereço Endereco VARCHAR(50);
ALTER TABLE Clientes CHANGE Endereco Endereco VARCHAR(50);



