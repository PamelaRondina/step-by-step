```sql
-- CRIAR TABELA

CREATE TABLE MODELO_TESTE (
ID  NUMBER(4) NOT NULL,
Nome VARCHAR2(255) NOT NULL,
Endereco1 VARCHAR(150) NULL,

Telefone VARCHAR(50) NULL,
Telefone2 VARCHAR2(50) NULL,
Email VARCHAR2(255) NULL,
Data_nascimento DATE,
Idade INTEGER,
);

-- ADICIONAR CAMPO EM UMA TABELA
ALTER TABLE MODELO_TESTE ADD Celular VARCHAR2(50) NULL;

-- ALTERAR CAMPO EXISTENTE
ALTER TABLE MODELO_TESTE MODIFY NOME VARCHAR(500) NULL;

-- REMOVER CAMPO EXISTENTE
ALTER TABLE MODELO_TESTE DROP COLUMN TELEFONE2;

-- EXCLUIR TABELA
-- DROP TABLE PRODUTOS;
-- DROP TABLE vendedores;	
-- DROP TABLE CADASTRO_CLIENTES;

-- INSERIR REGISTRO
INSERT INTO MODELO_TESTE (ID, NOME, ENDERECO1, TELEFONE, EMAIL, DATA_NASCIMENTO, CELULAR, BAIRRO, CIDADE, ESTADO, CEP)
VALUES
('0001', 'João Nascimento', 'Alameda Japi', '(11) 2535-2535', 'joao@email.com', 
TO_DATE('19/10/1985','DD/MM/YYYY'), '(11) 98780-8080', 'Cerqueira', 'São Paulo','SP','13000101');  

-- ALTERAR REGISTRO
UPDATE MODELO_TESTE SET Email = 'joao@gmail.com' where id = 0001;
UPDATE MODELO_TESTE SET NOME = 'João Gomes Nascimento', TELEFONE = '(19) 2535-2535', EMAIL = 'joao.nascimento@gmail.com' WHERE ID = '1';

-- EXCLUIR REGISTRO ESPECÍFICO
DELETE FROM MODELO_TESTE WHERE ID = '3'; 

-- INCLUIR PRIMARY KEY
ALTER TABLE VENDEDORES ADD CONSTRAINT PK_VENDEDORES PRIMARY KEY (ID);

-- SELECIONAR QUANTOS CAMPOS DESEJÁVEIS NA ORDEM DE CAMPO ESCOLHIDO (ORDER BY)
SELECT ID, NOME FROM CADASTRO_CLIENTES ORDER BY NOME;

-- DELETAR REGISTROS
DELETE 
DELETE FROM VENDEDORES WHERE ID = 00238;

-- NOME FANTASIA PARA O CAMPO (AS)
SELECT CPF AS CPF_CLIENTE, NOME AS NOME_CLIENTE FROM CADASTRO_CLIENTES;

-- SELECIONAR UM LIMITE ESPECIFICO (LIMIT)
SELECT ID, NOME FROM CADASTRO_CLIENTES LIMIT 1;

-- SELECIONAR REGISTROS 
SELECT * FROM VENDEDORES WHERE NOME = 'Claudia Morais';

-- SELECIONAR REGISTROS > < = <> <diferente>
SELECT * FROM CADASTRO_CLIENTES WHERE ID = 1;
SELECT * FROM CADASTRO_CLIENTES WHERE ID < 3;
SELECT * FROM VENDEDORES WHERE PERCENTUAL_COMISSAO > 0.10;
SELECT * FROM CADASTRO_CLIENTES WHERE ID >= 2;
SELECT * FROM CADASTRO_CLIENTES WHERE ID <> 1;

-- SELECIONAR VALORES ENTRE (BETWEEN)
SELECT * FROM MODELO_TESTE WHERE DATA_NASCIMENTO BETWEEN '01/01/79' AND '01/01/22';

--NOT não aparece o que estou puxando
SELECT * FROM MODELO_TESTE WHERE NOT (DATA_NASCIMENTO = '19/10/1985' AND NOME = 'João Nascimento'); 

-- SELECIONADO DATAS
SELECT * FROM VENDEDORES WHERE DATA_ADMISSAO < '1985-10-19';
SELECT * FROM VENDEDORES WHERE DATA_ADMISSAO > '1985-10-19';
SELECT * FROM VENDEDORES WHERE DATA_ADMISSAO = '1985-10-19';
SELECT * FROM VENDEDORES WHERE DATA_ADMISSAO <> '1985-10-19';
SELECT * FROM CADASTRO_CLIENTES WHERE YEAR (DATA_NASCIMENTO) = 2000;
SELECT * FROM CADASTRO_CLIENTES WHERE MONTH (DATA_NASCIMENTO) = 03;
SELECT * FROM CADASTRO_CLIENTES WHERE DAY (DATA_NASCIMENTO) = 12;
SELECT * FROM VENDEDORES WHERE FERIAS = 1 AND YEAR (DATA_ADMISSAO) < 2016;


--visualizar operações lógicas AND, OR e IN
SELECT * FROM MODELO_TESTE WHERE ID > 1 AND ID < 3;
SELECT * FROM MODELO_TESTE WHERE ID >= 1 AND ID <= 3;
SELECT * FROM MODELO_TESTE WHERE ESTADO = 'RJ' OR ESTADO = 'SP';
SELECT * FROM MODELO_TESTE WHERE ESTADO IN ('RJ', 'MG');


--LIKE
--lozalizar uma parte de um texto - LIKE '%texto', '%texto%', 'texto%'.
--'%texto'  (o resultado será o algo antes do texto - ex: Caetano Bruno)
--'%texto%' (o resultado será dos dois formatos + o texto sozinho)
--'texto%'  (o resultado será texto antes de algo - ex: Bruno Caetano)
SELECT * FROM MODELO_TESTE WHERE NOME LIKE '%Bruno%';
```

```SQL
--DISTINCT 
-- Visualizar resultados sem repetição (quais são as embalagens com líquido sabor laranja?)
SELECT DISTINCT EMBALAGEM FROM TABELA_PRODUTOS WHERE SABOR = 'Laranja';
```
ID|EMBALAGEM
-|-
1|Pet
2|Garrafa
3|Lata

```SQL
--ROWNUM 
-- Escolho a quantidade de itens que a tabela deve informar
SELECT * FROM CLIENTE WHERE ROWNUM <=4
-- O RESULTADO SERÃO AS 4 PRIMEIRAS LINHAS DA TABELA

-- OUTRAS FORMAS DE UTILIZAR O ROWNUM
-- 1) 
SELECT ROWNUM, TP.* FROM TABELA_DE_PRODUTOS TP;

--2)
SELECT ROWNUM, TP.* FROM TABELA_DE_PRODUTOS TP WHERE ROWNUM <=5;

--3)
SELECT TP.* FROM TABELA_DE_PRODUTOS TP WHERE ROWNUM <=5

-- LISTAR AS 10 PRIMEIRAS VENDAS DO DIA 01/10/17
SELECT * FROM NOTAS_FISCAIS WHERE DATA_VENDA = TO_DATE('2017-01-01','YYYY-MM-DD') AND ROWNUM <= 10;
```

```SQL
-- ORDER BY ASC
-- organiza DO MENOR para o MAIOR (Ascendente)
SELECT * FROM MODELO_TESTE ORDER BY NOME;
SELECT * FROM MODELO_TESTE ORDER BY  NOME ASC;
```
ID | NOME | COR
-|-|-
1 | Bruno | Vermelho
2 | Pamela | Azul
3 | Rosinha | Rosa

```SQL
-- ORDER BY DESC
-- organiza do MAIOR para o MENOR (Descendente)
SELECT * FROM MODELO_TESTE ORDER BY NOME DESC;
SELECT * FROM MODELO_TESTE ORDER BY NOME, ESTADO;
SELECT * FROM MODELO_TESTE ORDER BY NOME, ESTADO DESC;
```

ID | NOME | COR
-|-|-
1 | Rosinha | Rosa
2 | Pamela | Azul
3 | Bruno | Vermelho


```sql
--GROUP BY
-- SE POSSUIR 'ORDER BY' A 'GROUP BY' DEVE VIR ANTES
-- SUM (soma), AVG (média), MAX (máximo), MIN (mínimo), COUNT(CONTA)
SELECT * FROM TABELA_TESTE
```
TABELA PRINCIPAL
ID | SEXO | NOME | IDADE
-|-|-|-
1 | F | Cátia| 40
2 | M | João| 42
3 | F | Jaqueline | 18
4 | M | Ícaro \ 20

```sql
SELECT CIDADE, SUM(IDADE) FROM cadastro_clientes GROUP BY CIDADE ORDER BY CIDADE;

SELECT SEXO, SUM(IDADE) FROM TABELA_TESTE GROUP BY SEXO ORDER BY SEXO
```
ID | SEXO | IDADE
-|-|-
1 | F | 40
2 | M | 42

```sqL
-- QUAIS SÃO OS PRODUTOS MAIS CAROS?
SELECT EMBALAGEM, MAX(PRECO_LISTA) FROM produtos GROUP BY EMBALAGEM;

SELECT EMBALAGEM, MAX(PRECO_DE_LISTA) FROM TABELA_DE_PRODUTOS GROUP BY EMBALAGEM;
```
ID | EMBALAGEM | MAX(PRECO_DE_LISTA)
-|-|-
1 | Garrafa | 15,12
2 | Pet | 40,50
3 | Lata | 5,50

```SQL
-- HAVING
-- VEM DEPOIS DO GROUP BY, É UTILIZADO COMO UM FILTRO

SELECT EMBALAGEM MAX(PRECO_DE_LISTA) AS MAIOR_PRECO FROM TABELA_DE_PRODUTOS
WHERE PRECO_DE_LISTA >= 10
GROUP BY EMBALAGEM
HAVING MAX(PRECO_DE_LISTA) >=20;
```
```SQL
--CASE WHEN








```SQL
--visualizar todos os ESTADOS com o Endereço de ALAMEDA
SELECT DISTINCT ESTADO FROM MODELO_TESTE WHERE ENDERECO LIKE '%Alameda%';






-- VISUALIZAR TABELAS
SELECT * FROM PRODUTOS;
SELECT * FROM VENDEDORES;
SELECT * FROM CADASTRO_CLIENTES;

-- FINALIZAR SEMPRE COM COMMIT NO SQL DEVELOPER
COMMIT;