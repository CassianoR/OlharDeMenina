USE OhardeMeninaBD;

CREATE TRIGGER tgr_baixa_estoque
ON Venda
FOR INSERT
AS
BEGIN
	DECLARE @CodigoProduto INT,
		@QuantidadeVendida INT
	SELECT  @CodigoProduto = FK_CodigoProduto, @QuantidadeVendida = QuantidadeVendida FROM INSERTED
	UPTADE Estoque
	SET QuantidadeEstoque = QuantidadeEstoque - @QuantidadeVendida
	WHERE FK_CodigoProduto = @CodigoProduto;
END
GO
