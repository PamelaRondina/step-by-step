# MySQl

> Sequel (Linguagem de Consulta Estruturada)
> SQL (Structure Query Language)

_______

## Comandos de BD - MySQL 


![image](https://user-images.githubusercontent.com/108991648/194775988-0e6fb3c7-1200-4b06-bdc8-ccdd186e839c.png)
![image](https://user-images.githubusercontent.com/108991648/194776037-5522c0ba-3e4b-4c58-9ef0-1320da53777b.png)

___

## Entidadades do BD - MySQL

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


_________

Para agrupar as tabelas - esquema (Schema)

_____

- [X] Escolher qual banco de dados acessar e dar duplo clique

**Criar um DataBase**
`CREATE DATABASE NOME_BD`

**Apagar um Database**
`DROP DATABASE NOME_BD`

**Tipos de Dados**

Tipo | Valor em Bytes 
-|:-:
TINYINT | 1
SMALLINT | 2
MEDIUMINT| 3
INT | 4
BIGNT | 8
FLOAT |  4
DECIMAL ou NUMERIC | Até 65 dígitos
BIT | Até 64 bits
SIGNED ou UNSIGNED | vai possuir ou não sinal no número
ZEROFILL | preenche com zero os espaços
AUTO_INCREMENT | sequencia auto incrementada

>`BIT(1) armazena 1 e 0, BIT(2) armazena 01, 10, 00, 11`

> `INT(4) se armazenamos o valor 5 será gravado 0005`

**Criar Tabela**

`CREATE TABLE NOME_TABELA (Itens)`

Item|Tipo
-|-
CPF|VARCHAR(11),
NOME| VARCHAR(100),
ENDERECO| VARCHAR(150),
BAIRRO| VARCHAR(50),
CIDADE| VARCHAR(50),
ESTADO| VARCHAR(50),
CEP| VARCHAR(8),
IDADE| SMALLINT,
SEXO| VARCHAR(1),
`LIMITE CREDITO`| FLOAT,
`VOLUME COMPRA`| FLOAT,
`PRMEIRA COMPRA`|BIT(1)



