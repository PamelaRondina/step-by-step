
[Documentação Java](https://docs.oracle.com/javase/tutorial/java/nutsandbolts/datatypes.html)

**Ordem de prioridade em java**

- 1º tipo da variável;
- 2º seu nome;
- 3º atribuir um valor à variável.

```java
String nome = "Pamela";
```

**Run e Terminal**

Incluir no código para iniciarmos o Run:
```java
public static void main (String[] args){}
```

Para visualizarmos o resultado no terminal:
```java
System.out.println(soma);
```

**nomesDeVariaveis**

Para uma melhor visualização dos nomes das variáveis `saoFeitasDessaForma`. E não é recomendado iniciar com números ou caracteres especiais.

**Usuário inclui informação**
`import java.util.Scanner;`
`Scanner nomeDaVariavel1 = new Scanner(System.in);`
`int nomeDaVariavel2 = nomeDaVariavel1.nextInt();`

Comandos: JAVA | Descrição
:-|:-
; | Ao final de cada linha OBRIGATÒRIO ( ; )
System.out.println("texto"); | print
// | Comentário de linha
/* */ | Comentário de texto
&& | e (and)
.```||``` | ou (or)
? | if/se (operador ternário)
: | else/se não (operador ternário)
 Operador cast: `(float)`| Utilizar em decimal
 case | caso
 break; | parada
 default | Caso não encontre o resultado.
 for | Para laço numérico
System.out.println(nomeDaVariavel.toUpperCase()); | Maiúsculas
System.out.println(nomeDaVariavel.toLowerCase()); | Minúsculas
System.out.println(nomeDaVariavel.length()); | Contagem caracteres
**IMPORTS**| -
import java.util.Scanner; | Dado informado pelo usuário
**ATALHOS**|-
fori | `for (int i = 0; j < args.length; j++) {}`