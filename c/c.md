# Linguagem C

O primeiro contato que tive com essa linguagem foi em um bootcamp na escola 42.

**Hello, World!**

No terminal:

`code hello.c`  -   criar um arquivo.c
`make hello`    -   compilador, criar um arquivo executável para que o computador possa ler;
`./hello`       - executa o programa.

 ```c
#include <stdio.h>
#include <unistd.h>

int main(void)
{
    printf("Hello, World!\n");
    write(1, "Hello, World!\n", 14);
}
 ```

**Arquivos de Cabeçalho**

Arquivos que terminam com `.h` referem-se a biblioteca, são inclusos com a linha de comando `#include`, exemplos:

```c
#include <stdio.h>  //printf
#include <unistd.h> //write
```

**Tipos e Códigos de Formato**

Tipo | Descrição | Exemplo | Valor | Impressão
-|- |-|-|-
int | valor inteiro | -10 10 | 4 | %i
long | inteiros com mais bits | 123465464 | 8 | %li
char | único catactere | 'a' 'A' | 1 | %c
*char (string) | uma linha de caracteres | "Continue a nadar..." | X  | %s
float | valor com ponto flutuante | 10.2 | X | %f
double | valor com ponto flutuante com mais dígitos | 10.245664 | X
bool |expressão boleana | V ou F | 

**Operadores**

Operador | Descrição | Exemplo | Valor | Impressão
-|- |-|-|-
`+`| adição | 10 + 10| . | .
`-` | subtração | 10 - 10 | 
`*` | multiplicação | 10 * 10 | 
`/` | divisão | 10 / 10 | 
`=` | recebe - atribuição
`%` | resto | 10 % 2
`||` | qualquer uma das expressões pode ser verdadeira | 1 || 2 
`&&` | ambas as condições deveriam ser verdadeiras | 1 && 2
`==` | igual | 1 == 1
`i++` `+= 1` | acrescentar |
`i--` `-= 1` | decrementar |



____________________________

 Comandos | C
:-|-
= | recebe - atribuição
== | igual
\n | quebra de linha
// | comentário de uma linha
/* texto */ | comentário 