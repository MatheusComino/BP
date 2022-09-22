INSERT INTO `der_carnho_de_compra_04`.`loja`
(`idLoja`,
`nome`,
`cnpj`)

VALUES
('1',
'americanas',
'456456456');

INSERT INTO `der_carnho_de_compra_04`.`produto`
(`idProduto`,
`nome`,
`Produtocol`)
VALUES
('1',
'arroz',
'???');

INSERT INTO `der_carnho_de_compra_04`.`cliente`
(`idCliente`,
`nome`,
`cpf`)

VALUES
('1',
'carlos',
'123456789456');

INSERT INTO `der_carnho_de_compra_04`.`itens carinho de compra`
(`idItens Carinho de Compra`,
`quantidade`,
`Produto_idProduto`)
VALUES
('1',
'10',
'1');

INSERT INTO `der_carnho_de_compra_04`.`carinho de compra`
(`idCarinho de Compra`,
`idLoja`,
`idItens Carinho de Compra`,
`Cliente_idCliente`)
VALUES
('1',
'1',
1,
'1');

select * from carinho_de_compra;