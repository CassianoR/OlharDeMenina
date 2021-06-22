use OlhardeMenina_BD;

DELIMITER //
CREATE PROCEDURE novo_funcionario(
	IN Cargo char(20), Nome char(50), CPF char(14), Senha int, Telefone varchar(20), Endereco varchar(50)
)
BEGIN
	INSERT INTO Funcionarios(Cargo,Nome,CPF,Senha,Telefone,Endereco)
    VALUES (Cargo,Nome,CPF,Senha,Telefone,Endereco);
END //


DELIMITER //
CREATE PROCEDURE novo_cliente(
	IN Nome char(50), CPF char(14), Telefone varchar(20), Endereco varchar (50), DataNac date
)
BEGIN
	INSERT INTO Cliente(Nome,CPF,Telefone,Endereco,DataNasc)
    VALUES (Nome,CPF,Telefone,Endereco,DataNasc);
END //

DELIMITER //
CREATE PROCEDURE novo_produto(
	IN NomeProduto char(50), Marca char(100), Categoria char(1), Descricao char(255), Valor decimal(19,4)
)
BEGIN 
	INSERT INTO Produto(NomeProduto,Marca,Categoria,Descricao,Valor)
    VALUES (NomeProduto,Marca,Categoria,Descricao,Valor);
END //


DELIMITER //
CREATE PROCEDURE insercao_estoque(
	IN Numlote int, TotalProdutos int, Frete decimal(15,2), Fornecedor varchar(100), DataCompra date
)
BEGIN
	INSERT INTO Estoque(NumLote,TotalProdutos,Frete,Fornecedor,DataCompra)
    VALUES (NumLote,TotalProdutos,Frete,Fornecedor,DataCompra);
END //

CALL insercao_estoque('4', '5', '10.50', 'Thiago', '2021-06-21');


DELIMITER //
CREATE PROCEDURE insercao_estoquedetalhe(
	IN FK_NumLoteEstoque int, FK_CodigoProduto int, Quantidade int, PrecoCusto decimal(15,2), Validade date
)
BEGIN
	INSERT INTO EstoqueDetalhe(FK_NumLoteEstoque, FK_CodigoProduto, Quantidade, PrecoCusto, Validade)
	VALUES (FK_NumLoteEstoque, FK_CodigoProduto, Quantidade, PrecoCusto, Validade);
END //


DELIMITER //
CREATE PROCEDURE nova_venda(
	IN Codigo int, FK_IDFuncionario int, FK_IDCliente int, Valor decimal (15,2), MetodoPagamento varchar(50), DataHora datetime
)
BEGIN
	INSERT INTO Vendas(Codigo, FK_IDFuncionario, FK_IDCliente,Valor,MetodoPagamento,DataHora)
    VALUES (Codigo,FK_IDFuncionario,FK_IDCliente,Valor,MetodoPagamento,DataHora);
END //

DELIMITER //
CREATE PROCEDURE novo_detalhevenda(
	IN FK_CodigoVendas int, FK_CodigoProduto int, Quantidade int
)
BEGIN
	INSERT INTO VendasDetalhes(FK_CodigoVendas, FK_CodigoProduto, Quantidade)
    VALUES (FK_CodigoVendas, FK_CodigoProduto, Quantidade);
END //

