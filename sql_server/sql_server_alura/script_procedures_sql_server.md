-- SCRIPT PROCEDURES

USE ALURA_SQL_SERVER

--CRIAR PROCEDURE INSERT 
-- PARA CRIAR UMA PROCEDURE, MESMO QUE O CPF SEJA NOT NULL O @CPF DEVE SER NULL
CREATE PROCEDURE [SP_PRODUTOS_INSERT]

@CODIGO_DO_PRODUTO VARCHAR(20) = NULL,
@NOME_DO_PRODUTO VARCHAR(150) = NULL,						
@EMBALAGEM VARCHAR(50) = NULL,
@TAMANHO VARCHAR(50) = NULL,
@SABOR VARCHAR(50) = NULL,
@PRECO_DE_LISTA SMALLMONEY = NULL

AS
BEGIN

	INSERT INTO PRODUTOS
	(      CODIGO_DO_PRODUTO,
	       NOME_DO_PRODUTO,
		   EMBALAGEM,
		   TAMANHO,
		   SABOR,
		   PRECO_DE_LISTA)
	VALUES
	(      @CODIGO_DO_PRODUTO,
	       @NOME_DO_PRODUTO,
		   @EMBALAGEM,
		   @TAMANHO,
		   @SABOR,
		   @PRECO_DE_LISTA);

END

-- OUTRO EXEMPLO: CRIAR PROCEDURE INSERT 
CREATE PROCEDURE [SP_VENDEDORES_INSERT]

@MATRICULA VARCHAR(5) = NULL,
@NOME VARCHAR(100) = NULL,
@PERCENTUAL_COMISSAO FLOAT = NULL

AS
BEGIN

	INSERT INTO VENDEDORES
	(	MATRICULA,
		NOME,
		PERCENTUAL_COMISSAO)
	VALUES
	(	@MATRICULA,
		@NOME,
		@PERCENTUAL_COMISSAO);

END

-- CHAMADA PROCEDURE_INSERT
-- 1 - EXEMPLO
USE ALURA_SQL_SERVER;
GO
EXEC [dbo].[SP_VENDEDORES_INSERT] '00236','Cláudia Morais',0.08;
GO

-- 2 - EXEMPLO
EXEC [dbo].[SP_VENDEDORES_INSERT] '00237','Alberto de Sá Verneck',0.11;

EXEC [dbo].[SP_PRODUTOS_INSERT] '1002767', 'Videira do Campo - 700 ml - Cereja/Maça', 
'Garrafa', '700 ml', 'Cereja/Maça', 8.41;

-- CRIAÇÃO PROCEDURE UPDATE

-- 1 EXEMPLO
CREATE PROCEDURE [SP_PRODUTOS_UPDATE]

@CODIGO_DO_PRODUTO VARCHAR(20) = NULL,
@NOME_DO_PRODUTO VARCHAR(150) = NULL,						
@EMBALAGEM VARCHAR(50) = NULL,
@TAMANHO VARCHAR(50) = NULL,
@SABOR VARCHAR(50) = NULL,
@PRECO_DE_LISTA SMALLMONEY = NULL

AS
BEGIN
	UPDATE [dbo].[PRODUTOS] SET
	CODIGO_DO_PRODUTO	= @CODIGO_DO_PRODUTO,
	NOME_DO_PRODUTO		= @NOME_DO_PRODUTO,
	EMBALAGEM			= @EMBALAGEM,
	TAMANHO				= @TAMANHO,
	SABOR				= @SABOR,
	PRECO_DE_LISTA		= @PRECO_DE_LISTA
	WHERE CODIGO_DO_PRODUTO = @CODIGO_DO_PRODUTO;

END

-- 2 EXEMPLO
CREATE PROCEDURE [SP_VENDEDORES_UPDATE]
@MATRICULA VARCHAR(5) = NULL,
@NOME VARCHAR(100) = NULL,
@PERCENTUAL_COMISSAO FLOAT = NULL

AS
BEGIN
	UPDATE [dbo].[VENDEDORES] SET
	MATRICULA			= @MATRICULA,
	NOME				= @NOME,
	PERCENTUAL_COMISSAO	= @PERCENTUAL_COMISSAO
	WHERE MATRICULA		= @MATRICULA

END

-- CHAMADA PROCEDURE_UPDATE

EXEC [dbo].[SP_PRODUTOS_UPDATE] 1078680, 'Frescor do Verão - 470 ml - Manga', 'Garrafa', '470 ml', 'Manga', 5.18

--CRIAR PROCEDURE DELETE
CREATE PROCEDURE SP_CLIENTES_DELETE
 @CPF VARCHAR(11)

AS
BEGIN
	DELETE FROM [dbo].[CLIENTES]
	WHERE CPF = @CPF;

END

CREATE PROCEDURE SP_PRODUTOS_DELETE
@CODIGO_DO_PRODUTO VARCHAR(20)

AS
BEGIN
	DELETE FROM [dbo].[PRODUTOS]
	WHERE CODIGO_DO_PRODUTO = @CODIGO_DO_PRODUTO

END
-- CHAMADA PROCEDURE DELETE
EXEC [dbo].[SP_PRODUTOS_DELETE] 544931

--CRIAR PROCEDURE SELECT
CREATE PROCEDURE SP_PRODUTOS_SELECT
AS
BEGIN
	SELECT * FROM [dbo].[PRODUTOS]
	ORDER BY CODIGO_DO_PRODUTO;
END

-- CHAMADA PROCEDURE SELECT
EXEC [dbo].[SP_PRODUTOS_SELECT]

-- APAGAR PROCEDURE
-- DROP PROCEDURE [dbo].[SP_PRODUTOS_INSERT];[dbo].[SP_VENDEDORES_INSERT]
-- DROP PROCEDURE [dbo].[SP_PRODUTOS_UPDATE]

-- CONTROLE DE FLUXO IF THEN ELSE 
CREATE PROCEDURE SP_NOVO_VELHO_CADASTRO_CLIENTES @CPF VARCHAR(11)

AS
BEGIN
	DECLARE @vResultado VARCHAR(20);
    DECLARE @vDatanascimento DATE;
    SELECT @vDatanascimento = DATA_NASCIMENTO
    FROM [dbo].[CLIENTES] WHERE CPF = @CPF;
    
    IF @vDatanascimento < '20000101'
	BEGIN
		SET @vResultado = 'CLIENTE VELHO';
	END
	ELSE
	BEGIN
		SET @vResultado = 'CLIENTE NOVO';
	END 
	SELECT @vResultado;
END

-- CHAMADA PROCEDURE CONTROLE DE FLUXO IF THEN ELSE 
EXEC [dbo].[SP_NOVO_VELHO_CADASTRO_CLIENTES] 12345678944;

-- VISUALIZAR TABELAS
SELECT * FROM [dbo].[VENDEDORES]
SELECT * FROM [dbo].[PRODUTOS]
SELECT * FROM [dbo].[CLIENTES]