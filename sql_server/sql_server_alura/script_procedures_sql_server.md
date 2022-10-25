# SQL SERVER

## Definições

* O número de colunas é fixo; 
* As linhas serão ilimitadas, podem ser limitadas desde que seja alterado na criação da tabela;
* Todos os tipos de um campo serão iguais;

> CONSTRAINTS = Restrições (regras de validação de dados)

* NOT NULL - registros vazios não são liberados
* PRIMARY KEY - registros idênticos não se repetem
* FOREIGN KEY (Chave Estrangeira) - relacionamento em tabelas, não se pode incluir dados em uma tabela, se esses mesmos dados não existirem em outra.

> VIEWS = Visões

Resultado passa a ser como se fosse uma tabela, por exemplo, buscar de uma tabela o valor total de vendas de anos diferentes.

> Gatilhos

Quando ocorrer algo, faça isso!
__________

## Criar e deletar - DataBase

`CREATE DATABASE NOME_BD`

```sql
-- NOME DA BASE DE DADOS:
CREATE DATABASE NOME_BD

-- ARQUIVO DE DADOS SERÁ GRAVADO COMO: 
ON (NAME = 'SUCO_VENDAS.DAT'

-- LOCALIZAÇÃO QUE O ARQUIVO SERÁ SALVO:
    FILENAME = 'C:\DIRETORIO_NOME_ARQUIVO.MDF'

-- AO CRIAR O BANCO, AUTOMATICANTE TERÁ E TAMANAHO 10MB
    SIZE = 10MB;

-- E O TAMANHO MÁXIMO SERÁ:
    MAXSIZE = 50MB;

-- O BANCO VAI CRESCER DE 5 EM 5MB
    FILEGROWTH = 5MB)

-- E PODEMOS REPETIR OD DADOS NO ARQUIVO DE LOG:

LOG ON
    (NAME = 'SUCO_VENDAS.'
    FILENAME = 'C:\DIRETORIO_NOME_ARQUIVO.LDF'
    SIZE = 10MB;
    MAXSIZE = 50MB;
    FILEGROWTH = 5MB)
```
`DROP DATABASE NOME_BD`

__________

## Tipos de Dados

### Numéricos Exatos - Inteiros

- 08 bytes - BIGINT
- 04 bytes - INT
- 02 bytes - SMALLINT
- 01 byte   - TINYINT

### Numéricos Exatos - Com casas decimais

- NUMERIC e DECIMAL (Sinônimos)

(1,2) = 1.00
(3.0) = 100

### Numéricos Exatos - Representando Dinheiro

- 08 bytes - MONEY
- 04 bytes - SMALLMONEY

> representamos estes números com a moeda na frente: R$ 10.02.

### Numéricos Exatos - Valor Lógico

- BIT(1)

0 - Falso
1 - Verdadeiro

### Numéricos Aproximados - Valor Decimais

- FLOAT - 
- 04 bytes - REAL

### Data e Hora

- DATE 
AAAA-MM-DD
<br>
- DATETIME
- DATETIME2 (maior intervalo de datas)
AAAA-MM-DD HH:MM:SS:MMM
<br>
- DATETIMEOFFSET (fuso horário)
AAAA-MM-DD HH:MM:SS.MMM +/- HH:MM
<br>
- SMALLDATE 
AAAA-MM-DD HH:MM:SS
<br>
- TIME
HH:MM:SS.MMMMMMM 

### Cadeira de caracteres

CHAR - tamanho fixo - preenche os espaços em branco
VARCHAR - tamanho variável - não preenche os espaços em branco

________

### Criar Tabela

![image](https://user-images.githubusercontent.com/108991648/197614739-f57183b5-0bf3-4671-a5bc-5dcd2320f86d.png)

1º localizar em qual banco de dados está conectado.

Ou, incluir no início da Query `USE NOME_DB`

```sql
CREATE TABLE [PAM_CLIENTES]
([CPF] [VARCHAR] (11),
[NOME] [VARCHAR] (100),
[ENDERECO1] [VARCHAR] (150),
[ENDERECO2] [VARCHAR] (150),
[BAIRRO] [VARCHAR] (50),
[CIDADE] [VARCHAR] (50),
[ESTADO] [VARCHAR] (2),
[CEP] [VARCHAR] (8),
[DATA_NASCIMENTO] [DATE],
[IDADE] [SMALLINT],
[SEXO] [VARCHAR] (1),
[LIMITE_CREDITO] [MONEY],
[VOLUME_COMPRA] [FLOAT],
[PRIMEIRA_COMPRA] [BIT]);
```
____

### Excluir Tabela

```sql
DROP TABLE [NOME_TABELA];
```` 
________























