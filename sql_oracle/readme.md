# SQl

> Sequel (Linguagem de Consulta Estruturada)
> SQL (Structure Query Language)

* Banco de dados relacionais armazenam os dados de forma mais otimizada, economizando espaço em disco

* Banco de dados relacioal: regra de relacionamento entre entidades podem ser programadas no próprio banco

* Banco de dados sequencial: regra de relacionamento entre entidades devem estar contidas no programa ou na aplicação

* SQL - falta de criatividade e estrutura desvantagens do padrão SQL ANSI

* Novos Bancos de dados NoSQL foram criados, este para facilitador a rotina com as redes sociais

_______

## Comandos de BD - SQL 

![image](https://user-images.githubusercontent.com/108991648/194775988-0e6fb3c7-1200-4b06-bdc8-ccdd186e839c.png)
![image](https://user-images.githubusercontent.com/108991648/194776037-5522c0ba-3e4b-4c58-9ef0-1320da53777b.png)

____

**Localhost**

Quando nos referenciamos a um servidor, a uma máquina chamada localhost, nós estamos nos referenciando à nossa própria máquina.

___

## Entidadades do BD - SQL

- [x] Tablespaces
 - Tabelas
 - Índices
- [x] Views
- [x] Procedures
- [x] Trigger 

![image](https://user-images.githubusercontent.com/108991648/194883439-094cabf9-33fb-46b8-a510-9db74541a0b2.png)
![image](https://user-images.githubusercontent.com/108991648/194883490-41eb2d98-6cb4-4399-bfbf-6d6a1b0a1647.png)
![image](https://user-images.githubusercontent.com/108991648/194883560-ab1f3353-bcdd-4185-8e83-a011d5a951e8.png)
![image](https://user-images.githubusercontent.com/108991648/194883659-f917ba0c-046b-4854-ab71-4aafbb37b75e.png)

```SQL
--CRIAR TABELA

--NOT NULL obrigatório preenchimento
CREATE TABLE MODELO_TESTE (
ID NUMBER NOT NULL,
FK_TIPO_FAVORECIDO NUMBER NOT NULL,
DATA_VENCIMENTO TIMESTAMP(6) NOT NULL,
CPF  VARCHAR2(11) NOT NULL,
Nome VARCHAR2(255) NOT NULL,
Telefone VARCHAR(50) NULL,
Email VARCHAR2(255) NULL,
Data_nascimento DATE,
Endereco1 VARCHAR(150) NULL
);

--EXCLUIR/REMOVER

--excluir tabela
DROP TABLE TABLE1;
DROP TABLE TESTE_CLIENTES_PAM;
DROP TABLE MODELO_TESTE;

--remover campo
ALTER TABLE MODELO_TESTE DROP COLUMN TELEFONE2;
ALTER TABLE MODELO_TESTE DROP COLUMN IDADE;
ALTER TABLE MODELO_TESTE DROP COLUMN CPF;

--excluir registro
DELETE FROM MODELO_TESTE WHERE ID = '3';


--ADICIONAR CAMPO

--Adicionado: celular, bairro, cidade, estado e cep
ALTER TABLE MODELO_TESTE ADD Celular VARCHAR2(50) NULL;
ALTER TABLE MODELO_TESTE ADD Bairro VARCHAR2(100) NULL;
ALTER TABLE MODELO_TESTE ADD Cidade VARCHAR2(100) NULL; 
ALTER TABLE MODELO_TESTE ADD Estado VARCHAR2(2) NULL;
ALTER TABLE MODELO_TESTE ADD CEP VARCHAR2(8) NULL;
ALTER TABLE MODELO_TESTE ADD CPF VARCHAR2(11) NOT NULL;

--adicionar primary key
ALTER TABLE MODELO_TESTE ADD CONSTRAINT PK_MODELO_TESTE PRIMARY KEY (ID);
ALTER TABLE MODELO_TESTE ADD CONSTRAINT PK_MODELO_TESTE PRIMARY KEY (CPF);

--adicionar chave estrangeira
ALTER TABLE PAM_ITENS_NOTAS_FISCAIS
ADD CONSTRAINT FK_PAM_ITENS_NOTAS_FISCAIS1
   FOREIGN KEY (CODIGO_DO_PRODUTO)
   REFERENCES PAM_PRODUTOS (CODIGO_DO_PRODUTO);


--INSERIR

--inserir registros
INSERT INTO MODELO_TESTE (CPF, NOME, TELEFONE, EMAIL, DATA_NASCIMENTO, ENDERECO, BAIRRO, CIDADE, ESTADO, CEP)
VALUES
('39839839801', 'João Nascimento', '(11) 98780-8080', 'joao@gmail.com', 
TO_DATE('19/10/1985','DD/MM/YYYY'), 'Alameda Japi', 'Cerqueira', 'São Paulo','SP','13000101');  

INSERT INTO MODELO_TESTE (CPF, NOME, TELEFONE, EMAIL, DATA_NASCIMENTO, ENDERECO, BAIRRO, CIDADE, ESTADO, CEP)
VALUES
('39439439401', 'Carla Viana', '(11) 98181-8181', 'carla.viana@gmail.com', 
TO_DATE('23/03/1979','DD/MM/YYYY'), 'Rua da Paçoca', 'Doce', 'São Paulo','SP','14000101');  

INSERT INTO MODELO_TESTE (CPF, NOME, TELEFONE, EMAIL, DATA_NASCIMENTO, ENDERECO, BAIRRO, CIDADE, ESTADO, CEP)
VALUES
('3985958201', 'Bruno Caetano', '(45) 98587-8587', 'b.carlos@gmail.com.br', 
TO_DATE('19/02/1992','DD/MM/YYYY'), 'Rua da Tempestade', 'Ventania', 'Minas Gerais','MG','20000909');  

INSERT INTO MODELO_TESTE (CPF, NOME, TELEFONE, EMAIL, DATA_NASCIMENTO, ENDERECO, BAIRRO, CIDADE, ESTADO, CEP)
VALUES
('3958258201', 'Matilda Esperança', '(21) 98585-8587', 'matilda@gmail.com.br', 
TO_DATE('06/06/1996','DD/MM/YYYY'), 'Rua dos Tenentes', 'Brigadeiro', 'Rio de Janeiro','RJ','56000909'); 

INSERT INTO MODELO_TESTE (CPF, NOME, TELEFONE, EMAIL, DATA_NASCIMENTO, ENDERECO, BAIRRO, CIDADE, ESTADO, CEP)
VALUES
('3955958701', 'Carla Carolina', '(11) 95252-5252', 'carla.carol@gmail.com.br', 
TO_DATE('28/11/1989','DD/MM/YYYY'), 'Rua da Calmaria', 'Paz', 'Santa Catarina','SC','45000909'); 

--ALTERAR

--alterar dados da base do campo existente
ALTER TABLE MODELO_TESTE MODIFY NOME VARCHAR(500) NULL;
ALTER TABLE MODELO_TESTE MODIFY CPF VARCHAR(11) NULL;

--alterar registro
UPDATE MODELO_TESTE SET Email = 'joao@Email.com' WHERE NOME = 'João Nascimento';
UPDATE MODELO_TESTE SET NOME = 'João Gomes Nascimento', TELEFONE = '(19) 2535-2535', EMAIL = 'joao.nascimento@gmail.com' WHERE ID = '1';
UPDATE MODELO_TESTE SET ESTADO = 'RJ' WHERE NOME = 'João Nascimento';


--alterar conteúdo de um campo
UPDATE MODELO_TESTE SET ESTADO = 'RJ' WHERE NOME = 'João Nascimento';


--SELECIONAR/VISUALIZAR

--Selecionar


--Visualizar
-- visualizar todos os registros
SELECT * FROM MODELO_TESTE;

--visualizar campos específicos de uma tabela
SELECT NOME, EMAIL, DATA_NASCIMENTO FROM MODELO_TESTE;

--visualizar na ordem que desejo uma tabela
SELECT EMAIL, NOME, CIDADE FROM MODELO_TESTE

--incluir 'apelidos' aos campos
--apelidos com espaços inserir " " 
SELECT NOME AS "CLIENTE PRINCIPAL", TELEFONE AS "MELHOR CONTATO" FROM MODELO_TESTE;

--visualizar registro específico
SELECT * FROM MODELO_TESTE WHERE CPF = '39839839801';
SELECT * FROM MODELO_TESTE WHERE ESTADO = 'SP';

--visualizar registros > < = <> <diferente>
SELECT * FROM MODELO_TESTE WHERE ID = 1;
SELECT * FROM MODELO_TESTE WHERE ID < 3;
SELECT * FROM MODELO_TESTE WHERE ID > 2;
SELECT * FROM MODELO_TESTE WHERE ID >= 2;
SELECT * FROM MODELO_TESTE WHERE ID <> 1;

--entre
SELECT * FROM MODELO_TESTE WHERE DATA_NASCIMENTO BETWEEN '01/01/79' AND '01/01/22';

--NOT não aparece o que estou puxando
SELECT * FROM MODELO_TESTE WHERE NOT (DATA_NASCIMENTO = '19/10/1985' AND NOME = 'João Nascimento'); 

--visualizar datas
SELECT * FROM MODELO_TESTE WHERE DATA_NASCIMENTO = '19/10/85';
SELECT * FROM MODELO_TESTE WHERE DATA_NASCIMENTO = TO_DATE('19/10/1985', 'DD/MM/YYYY');
SELECT * FROM MODELO_TESTE WHERE DATA_NASCIMENTO < TO_DATE('01/01/1998', 'DD/MM/YYYY');
SELECT * FROM MODELO_TESTE WHERE DATA_NASCIMENTO < TO_DATE('10/08/1991', 'MM/DD/YYYY');
SELECT * FROM MODELO_TESTE WHERE TO_CHAR(DATA_NASCIMENTO, 'MM') = 8;

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

--DISTINCT 
--visualizar resultados sem repetição (mesmo em planilhas com resultados duplicados, exemplo cidade)
SELECT DISTINCT ESTADO FROM MODELO_TESTE 
--visualizar todos os ESTADOS com o Endereço de Alamda
SELECT DISTINCT ESTADO FROM MODELO_TESTE WHERE ENDERECO LIKE '%Alameda%';

--ROWNUM 
--(escolho a quantidade de itens que a tabela deve informar)
--incluindo o nome da tabela no meio e fim,
SELECT ROWNUM, MODELO_TESTE.* FROM MODELO_TESTE;
--dando um apelido para a tabela TP
SELECT ROWNUM, TP.* FROM MODELO_TESTE TP;
--apelido + apenas as duas primeiras linhas
SELECT ROWNUM, TP.* FROM MODELO_TESTE TP WHERE ROWNUM <=2;
--apelido + ROWnum no final + quantidade de linhas
SELECT TP.* FROM MODELO_TESTE TP WHERE ROWNUM <=3;

-- ORDER BY / ORDER BY DESC
-- organiza DO MENOR para o MAIOR (Ascendente)
SELECT * FROM MODELO_TESTE ORDER BY DATA_NASCIMENTO;
SELECT * FROM MODELO_TESTE ORDER BY NOME;
-- organiza do MAIOR para o MENOR (Descendente)
SELECT * FROM MODELO_TESTE ORDER BY DATA_NASCIMENTO DESC;
SELECT * FROM MODELO_TESTE ORDER BY NOME DESC;

SELECT * FROM MODELO_TESTE ORDER BY NOME, ESTADO;
SELECT * FROM MODELO_TESTE ORDER BY NOME, ESTADO DESC;

--GROUP BY

--SUN (soma), AVG (média), MAX (máximo), MIN (mínimo)

COMMIT;
