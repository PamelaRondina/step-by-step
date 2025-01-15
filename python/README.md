# Python

## Tipos de Dados

Sigla | Algoritmo | |Exemplo 
-|-|-|-
`int`   | Inteiro | Números Inteiros | 10
`float` | Real | Números Decimais | 20.2
`str` | String | Caracter | Qualquer Texto
`bool` | Lógico | Lógico | True and False

>A identação em python é de suma importância.

Correto: aqui o `print` está identado!

```python
if 5 > 3:
    print('5 es mayor a 3')
```

Incorreto: aqui o `print` não segue identado, o código terá erro.
```python
if 5 > 3:
print('5 es mayor a 3')
```

## Variáveis

Podemos nomear as variáveis em python.

> nomes representativos aos dados que guardaremos, ex: email = pamela@email.com

Modelos de nomes de variáveis:

```python
email = pam@email.com
assim_também = 1 #hífen/guiones não são permitidos"
destaForma = 2
TAMBEM = 3 #variáveis que não pode alterar seu valor"
inserir1 = 4 #nºs no início não são permitidos"
```
Podemos também criar variáveis seguidas:

```python
a, b, c = 'Uno', 'Dos', 'Tres'
    print(a, b, c)
```

## Concatenação

```python
inicio = 'Hola' #não possui espaço
inicio2 = 'Hola ' #possui espaço
final = 'mundo'

print(inicio + final)
Holamundo #Variáveis juntas

print(inicio,final)
Hola mundo #A (,) da 1 de espaço

print(inicio2 + final)
Hola mundo #apenas 1 espaço, veio da variável

print(inicio2,final)
Hola  mundo #possui 2 espaços, a (,) = 1 de espaço
```

## Entrada de Dados

```python
print ("Você pesa {} quilos".format(P))

print (f"Você pesa {P}: quilos")
```

Em python, a função `input` sempre devolve o dado lido do usuário como tipo `str`, para os demais vemos incluir o `input`

```python
XPTO = input("Informe o Valor de XPTO: ") #string

X = int(input("Informe p valor de X: ")) #int
Y = float(input("Informe o valor de Y: ")) #float
``Some status bar options in CMake Tools have now moved to the Project Status View in the CMake Tools sidebar. You can customize your view with the 'cmake.options' property in settings.`





**Listas**

Coleção da dados agrupados em uma lista:

```python
lista = [1, 2, 3]
lista2 = lista.copy() #uma cópia da variável lista

lista.append(4) #adicionar item

#lista.clear() #limpar uma lista

print(lista, lista2)
```
## Funções

> Chamar uma função. Podemos utilizar a palavra chave: `def`:

~~~python
def saludar():
  print("Hola Mundo"); 
~~~
****
**Função: .count and print(len())**

```python
lista = [1, 2, 3]
lista2 = lista.copy()
lista.append(4) 

print(lista, lista2)

#conta quantos elementos específico existem
#elemento destacado dentro dos (3)
print(lista.count(3), lista2.count(3))

#conta quantos elementos possuem a lista
print(len(lista), len(lista2))
```
Terminal
[1, 2, 3, 4] [1, 2, 3]
1 1 (quantidade de números 3 em ambas as listas)
4 3 (quantidade de itens da lista = 4 e lista2 = 3)



_______
Comandos | Python
:-|-
`print("Hola Mundo")` | imprimir texto
.# | comentário de linha
' ' ' ou " " " | comentário de textos (docstring)
`,` | cria espaçamento
**Operadores Aritméticos** |
`+` | adição
`-` | subtração
`*` | multiplicação
`/` |  divisão
`x**y` | potencialização
`x**0.5` | raiz quadrada
`%` | resto da divisão
`//` | quociente da divisão
**Operadores Relacionais e Lógicos** |  
== | igualdade (2 == 2)
`>` | maior (3 > 2)
`<` | menor (2 < 3)
`>=` | maior ou igual a (3 >= 3) 
`<=` | menor ou igual a (3 <= 3)
`!=` | diferente de
`not` | negação (não)
`and` | conjunção (e)
`or` | disjunção (ou)
!= | compara dois valores e nos diz se são diferentes (1 != 2)
**Listas**|
variavel = [1, 2, 3] | São criadas dentro dos [ ]
.copy() | Copia
.append() | Adiciona item
.clear() | Apaga lista
**Funções** |
def | funções
.count(X) | Quantos elementos específicos possuem a lista
print(len(variavel) | Quantos elementos possuem a lista




