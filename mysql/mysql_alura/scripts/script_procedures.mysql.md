```sql
-- INSERT - INCLUIR DADOS A PARTIR DE UMA PROCEDURE

-- INSERT PRODUTOS (PROCEDURE)

CREATE PROCEDURE `SP_CADASTRO_CLIENTES_INSERT`(
	IN p_ID INT,
    p_CPF varchar(11),
	p_NOME VARCHAR(150),
    p_ENDERECO varchar(250),
	p_BAIRRO varchar(100),
	p_CIDADE varchar(100),
	p_ESTADO varchar(2), 
	p_CEP varchar(8),
	p_IDADE smallint,
	p_SEXO varchar(1), 
	p_LIMITE_CREDITO float,
	p_VOLUME_COMPRA float, 
	p_PRIMEIRA_COMPRA bit(1), 
	p_DATA_NASCIMENTO date)
BEGIN
	INSERT INTO CADASTRO_CLIENTES (
		ID
	,	CPF
	,	NOME
    ,	ENDERECO
    ,	BAIRRO
    ,   CIDADE
    ,   ESTADO
    ,	CEP
    ,	IDADE
    ,	SEXO
    ,	LIMITE_CREDITO
    ,	PRIMEIRA_COMPRA
    ,	DATA_NASCIMENTO)
    
    VALUES (
		p_ID
	,	p_CPF
	,	p_NOME
    ,	p_ENDERECO
    ,	p_BAIRRO
    ,   p_CIDADE
    ,   p_ESTADO
    ,	p_CEP
    ,	p_IDADE
    ,	p_SEXO
    ,	p_LIMITE_CREDITO
    ,	p_PRIMEIRA_COMPRA
    ,	p_DATA_NASCIMENTO);
END

-- CHAMADA DO INSERT
CALL sp_produtos_insert ('1040107', 'Light - 350ml - Melância', 'Lata', '350 ml', 'Melância', 4.56);
CALL sp_produtos_insert ('1037797', 'Clean - 2 Litros - Laranja', 'PET', '2 Litros', 'Laranja', 16.01);
CALL sp_produtos_insert ('1000889', 'Sabor da Montanha - 700 ml - Uva', 'Garrafa', '700 ml', 'Uva', 6.31);
CALL sp_produtos_insert ('1004327', 'Videira do Campo - 1,5 Litros - Melancia', 'PET', '1,5 Litros', 'Melancia', 19.51);
CALL sp_produtos_insert ('544931', 'Frescor do Verão - 350 ml - Limão', 'PET', '350 ml','Limão',3.20);
CALL sp_produtos_insert ('1078680', 'Frescor do Verão - 470 ml - Manga', 'Lata', '470 ml','Manga',5.18);

-- INSERT VENDEDORES (PROCEDURE) DATA = ANO-MÊS-DIA
CALL SP_VENDEDORES_INSERT ('00233', 'João Geraldo da Fonseca', 0.10);
CALL SP_VENDEDORES_INSERT ('00235','Márcio Almeida Silva',0.08, '2014-08-15', 0);
CALL SP_VENDEDORES_INSERT ('00236','Cláudia Morais',0.08, '2013-09-17', 1);
CALL SP_VENDEDORES_INSERT ('00237', 'Roberta Martins', 0.11, '2017-03-18', 1);
CALL SP_VENDEDORES_INSERT ('00238', 'Pericles Alves', 0.11, '2016-08-21', 0);

-- INSERT CADAStro_CLIENTES (PROCEDURE)
CALL SP_CADASTRO_CLIENTES_INSERT ('1', '12345678998','João da Silva', 
'Rua projetada A número 10', 'Vila Roman', 'Caratinga', 'AM', 
'22222222', 30, 'M', 10000.00, 2000, 0, '1992-08-26');

CALL SP_CADASTRO_CLIENTES_INSERT ('2', '19290992743', 'Fernando Cavalcante',
'R. Dois de Fevereiro',	'Água Santa',	'Rio de Janeiro',	'RJ',
'22000000',	18,	'M',	100000,	200000,	1,	'2000-02-12');

CALL SP_CADASTRO_CLIENTES_INSERT ('3',	'2600586709',	'César Teixeira',
'Rua Conde de Bonfim',	'Tijuca',	'Rio de Janeiro',	'RJ',	'22020001',
18,	'M',	120000,	220000,	0,	'2000-03-12');

-- ALTERAR DADOS A PARTIR DA PROCEDURE
-- UPDATE PRODUTOS (PROCEDURE)
CALL SP_PRODUTOS_UPDATE (544931, 'Frescor do Verão - 350 ml - Limão', 'Lata', '350 ml', 'Limão', 2.46);

-- DELETAR DADOS A PARTIR DA PROCEDURE
-- DELETAR PRODUTOS (PROCEDURE)
CALL SP_PRODUTOS_DELETE (1078680);

-- DELETAR VENDEDORES (PROCEDURE)
CALL SP_VENDEDORES_DELETE(00233);

-- VISUALIZAR A PARTIR DE UMA PROCEDURE
CALL SP_CADASTRO_CLIENTES_SELECT_ID_NOME;

-- VISUALIZAR TABELAS
SELECT * FROM PRODUTOS;
SELECT * FROM VENDEDORES;
SELECT * FROM CADASTRO_CLIENTES;


COMMIT;