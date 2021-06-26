USE OhardeMeninaBD;

CREATE TRIGGER tgr_baixa_estoque
ON Venda
FOR INSERT
AS
BEGIN
	DECLARE @CodigoProduto int,
			@QuantidadeVendida int
	select  @CodigoProduto = FK_CodigoProduto, @QuantidadeVendida = QuantidadeVendida from inserted
	update Estoque
	set QuantidadeEstoque = QuantidadeEstoque - @QuantidadeVendida
	where FK_CodigoProduto = @CodigoProduto;
end
go