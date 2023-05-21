
[Documentação Java](https://docs.oracle.com/javase/tutorial/java/nutsandbolts/datatypes.html)

# Iniciar um arquivo

- [x] class nomeClass
- [x] `psvm` chamar o `   public static void main`

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

Para uma melhor visualização dos nomes das variáveis `saoFeitasDessaForma`. 
- Não é recomendado iniciar com números ou caracteres especiais.

**Usuário inclui informação**
`import java.util.Scanner;`
`Scanner nomeDaVariavel1 = new Scanner(System.in);`
`int nomeDaVariavel2 = nomeDaVariavel1.nextInt();`

_______________________________________________________________

# Compilar Arquivo Java no Prompt de Comando

- [x] Criar e Salvar Arquivo: nomeArquivo.java

```java
//Meu Primeiro Programa

//nome da classe
class MeuPrimeiroProgramaJava
{
    //módulo principal com a entrada pela linha de comando
    public static void main(String entrada[]) 
    {
        //declaração de variáveis
        int inteiro = 31;
        char caracter = 'F';
        double real  = 1.70;
        String frase = "Pamela Rondina";
        boolean VF=true;

        if (VF == true)
        {
            System.out.println("Eu sou a " + frase + ", tenho " + inteiro + " anos e " + real + "m de altura");
        }

        System.exit(0);

    }
}
```

- [x] No Prompt de Comando: localizar caminho de onde o arquivo está salvo:

- [x] Na pasta rodar:
    - `path "C:\Program Files\Java\jdk-18.0.1.1\bin"`;
    - `dir *.java`;
    - `javac nomeArquivo`;
    - `dir *.class`;
    - `java nomeArquivo`.

```
> path "C:\Program Files\Java\jdk-18.0.1.1\bin"
> dir *.java
> javac Faculdade_aula_java_01.java
> dir *.class
> java Faculdade_aula_java_01.java
```
_________________________________________________________________

Comandos: JAVA | Descrição
:-|:-
; | Ao final de cada linha OBRIGATÒRIO ( ; )
// | Comentário de linha
/* */ | Comentário de texto
&& | e (and)
`||` | ou (or)
`=` | Pertence
`==` | Comparação
? | if/se (operador ternário)
: | else/se não (operador ternário)
 Operador cast: `(float)`| Utilizar em decimal
 case | caso
 break; | parada
 default | Caso não encontre o resultado.
 for | Para laço numérico
System.out.print(); | Saída de Resultado
System.out.println(); | Saída de Resultado + Pular Linha
System.out.println(nomeDaVariavel.toUpperCase()); | Maiúsculas
System.out.println(nomeDaVariavel.toLowerCase()); | Minúsculas
System.out.println(nomeDaVariavel.length()); | Contagem caracteres
` Integer.parseInt(entrada[0]);` | Os dados inclusos em java são em String, este comando passa para **Int**
________________________________________________________________

**IMPORTS**| -
-|-
import java.util.Scanner; | Dado informado pelo usuário

_____________________________________________________________________
**ATALHOS**|-
-|-
fori | `for (int i = 0; j < args.length; j++) {}`