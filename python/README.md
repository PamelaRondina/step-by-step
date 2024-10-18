# Python

>A identação em python é de suma importância.

Correto, `print` está identado.
```python
if 5 > 3:
    print('5 es mayor a 3')
```

Incorreto, `print` não segue identado, o código terá erro.
```python
if 5 > 3:
print('5 es mayor a 3')
```

**Variáveis**

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

**Concatenação**

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

### Tipos de Dados

Sigla | Tipo | |Exemplo 
-|-|-|-
int   | Inteiro | Números Inteiros | 10
float | Decimal | Numeros Decimais | 20.2
str | String | Texto | Qualquer Texto

```python
print(2 + 2) # 4
print("hola " + "mundo") # hola mundo
print("2" + "2") # 22

inteiro = 10
conDecimal = 20.2 #float
complexo = 1j
```

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
.# | Comentário de linha
' ' ' | Comentário de textos (docstring)
**Operador de Comparação** | 
== | igualdade (2 == 2)
`>` | maior (3 > 2)
`<` | menor (2 < 3)
`>=` | maior ou igual a (3 >= 3) 
`<=` | menor ou igual a (3 <= 3)
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




