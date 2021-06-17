USE OlharMeninaBDlimpo;

-- === CONSULTAS SIMPLES ===
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