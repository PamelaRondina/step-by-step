-- INSERT - INCLUIR DADOS A PARTIR DE UMA PROCEDURE
-- INSERT PRODUTOS (PROCEDURE)
CALL sp_produtos_insert ('1040107', 'Light - 350ml - Melância', 'Lata', '350 ml', 'Melância', 4.56);
CALL sp_produtos_insert ('1037797', 'Clean - 2 Litros - Laranja', 'PET', '2 Litros', 'Laranja', 16.01);
CALL sp_produtos_insert ('1000889', 'Sabor da Montanha - 700 ml - Uva', 'Garrafa', '700 ml', 'Uva', 6.31);
CALL sp_produtos_insert ('1004327', 'Videira do Campo - 1,5 Litros - Melancia', 'PET', '1,5 Litros', 'Melancia', 19.51);
CALL sp_produtos_insert ('544931', 'Frescor do Verão - 350 ml - Limão', 'PET', '350 ml','Limão',3.20);
CALL sp_produtos_insert ('1078680', 'Frescor do Verão - 470 ml - Manga', 'Lata', '470 ml','Manga',5.18);

-- INSERT VENDEDORES (PROCEDURE)
CALL SP_VENDEDORES_INSERT ('00233', 'João Geraldo da Fonseca', 0.10);
CALL SP_VENDEDORES_INSERT ('00235','Márcio Almeida Silva',0.08);
CALL SP_VENDEDORES_INSERT ('00236','Cláudia Morais',0.08);

-- ALTERAR DADOS A PARTIR DA PROCEDURE
-- UPDATE PRODUTOS (PROCEDURE)
CALL SP_PRODUTOS_UPDATE (544931, 'Frescor do Verão - 350 ml - Limão', 'Lata', '350 ml', 'Limão', 2.46);

-- DELETAR DADOS A PARTIR DA PROCEDURE
-- DELETAR PRODUTOS (PROCEDURE)
CALL SP_PRODUTOS_DELETE (1078680);

-- DELETAR VENDEDORES (PROCEDURE)
CALL SP_VENDEDORES_DELETE(00233);

-- VISUALIZAR TABELAS
SELECT * FROM PRODUTOS;
SELECT * FROM VENDEDORES;

COMMIT;