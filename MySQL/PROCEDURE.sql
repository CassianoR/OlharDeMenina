use OlhardeMeninaBD;

--Cada tabela está seguida de um exemplo para teste--
--SQL Server utiliza do comando EXEC ou EXECUTAR --

CREATE PROCEDURE sp_novofunc
	@Cargo VARCHAR (50),
	@Nome  VARCHAR (50),
	@CPF   CHAR (14),
	@Endereco VARCHAR (60),
	@Telefone VARCHAR (20),
	@Senha VARCHAR (20)
AS
BEGIN
	INSERT INTO Funcionarios VALUES (@Cargo, @Nome, @CPF, @Endereco, @Telefone, @Senha)
END
GO

EXEC sp_novofunc 'Faxineiro','Carlos','123.456.789.56','Rua Pepino','99769-9999','oi98'

CREATE PROCEDURE sp_novoclien
	@Nome VARCHAR (80),
	@CPF  CHAR (14),
	@Endereco VARCHAR (80),
	@Telefone VARCHAR (20),
	@DataNasc DATE
AS
BEGIN
	INSERT INTO Clientes VALUES(@Nome, @CPF, @Endereco, @Telefone, @DataNasc)
END
GO

EXEC sp_novoclien 'João','333.444.555-59','Rua Alface','99896-9878','1992-07-26'

CREATE PROCEDURE sp_novoproduto
	@Nome  VARCHAR (50),
	@Marca VARCHAR (100),
	@Categoria CHAR (1),
	@Descricao VARCHAR (100),
	@Valor DECIMAL (15,2)
AS
BEGIN
	INSERT INTO Produtos VALUES(@Nome, @Marca, @Categoria, @Descricao, @Valor)
END
GO

EXEC sp_novoproduto 'Batom Vermelho','Risque','2','Muito Cheiroso','50.65'

CREATE PROCEDURE sp_insercaoestoque
	@NumLote INT,
	@TotalProdutosLote INT,
	@Frete DECIMAL (15,2),
	@Fornecedor VARCHAR (80),
	@DataCompra DATE,
	@PrecoLote DECIMAL (15,2),
	@Quantidade INT,
	@Validade DATE,
	@FK_CodigoProduto INT
AS
BEGIN
	INSERT INTO Estoque VALUES (@NumLote,@TotalProdutosLote,@Frete,@Fornecedor,@DataCompra,@PrecoLote,@Quantidade,@Validade,@FK_CodigoProduto)
END
GO

EXEC sp_insercaoestoque '322','60','60.25','Kiko','2021-07-04','90.65','40','2022-03-06','1'

CREATE PROCEDURE sp_novavenda 
	@FK_IDFuncionario INT,
	@FK_IDCliente INT,
	@FK_CodigoProduto INT,
	@Valor DECIMAL (15,2),
	@MetodoPagamento VARCHAR (50),
	@Datahora DATETIME,
	@QuantidadeVendida INT
AS
BEGIN
	INSERT INTO Venda VALUES(@FK_IDFuncionario, @FK_IDCliente, @FK_CodigoProduto, @Valor, @MetodoPagamento, @Datahora, @QuantidadeVendida)
END
GO

EXEC sp_novavenda '1','1','1','30.23','Master Card','2021-06-02 11:59:34','1'


