USE OlharMeninaBDlimpo;

INSERT INTO Funcionarios (ID, Cargo, Nome, CPF, Senha, Telefone, Endereco) values ('1', "Administrador", "João", "111.111.111-11",'1234',"99999-9999","Rua Do Palmito");
INSERT INTO Funcionarios (Cargo, Nome, CPF, Senha, Telefone, Endereco) values ("Caixa", "Janaína", "555.555.555-55",'1234',"99999-9999","Rua Do Limão");
INSERT INTO Funcionarios (Cargo, Nome, CPF, Senha, Telefone, Endereco) values ("Cozinheiro", "ll", "455.555.555-55",'1234',"99999-9999","Rua Do Limão");

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

INSERT INTO VendasDetalhes (FK_CodigoVendas, FK_CodigoProduto, Quantidade) values ('1', '1', '12');
INSERT INTO VendasDetalhes (FK_CodigoVendas, FK_CodigoProduto, Quantidade) values ('1', '2', '9');
INSERT INTO VendasDetalhes (FK_CodigoVendas, FK_CodigoProduto, Quantidade) values ('2', '3', '5');
