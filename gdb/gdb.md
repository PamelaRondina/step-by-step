# GDB

GNU Debugger, utilizado no terminal para analisar os códigos para a Linguagem C.

## Instalar

No terminal: 
`sudo apt install gdb`

- `sudo`    Super User Do, permite executar comandos com privilégios:
- `apt install`     Advanced Package Tool, gerenciador de pacotes baseadas no Debian (como Linux e Ubuntu)
    - instalar: *apt install nome_pacote*,
    - atualiar: *apt update nome_pacote*,
    - remover: *apt remove nome_pacote*.
- `gdb` GNU Debugger

## Comandos

Comandos | DGB
-|- 
`gcc -g nome_programa.c` | -g: cria um arquivo que compila que executa no GDB
`gdb arquivo_compilado` | inicia o programa GDB
`lay src` `layout src`| Abre a tela para visualizar o codigo dentro do programa
`run` | inicia o programa 
**breakpoint** | 
`break main` `b main` | Setar um ponto de parada na main (ou qualquer outra linha)
`info b` | lista todos os breaks setados no programa
`clear main` | deleta breakpoint na variavel setada
`disable 2` | desabilitar breakpoint, o número do break e nao da linha
`enable 2` | habilitar breakpoint, o número do break e não da linha
**visualizar variaveis** |
watch nome_variável | mostra o valor da variavél a cada turno
**.** | 
`set variavel = 10` | Incluir um novo valor a variavel 
`step` `s` | acessa a função
`start` | Incluir um breakpoint temporário na main
`next` `n` | próximo passo
`print` `p`| imprimir + Nome_variavel
**list** | 
`list` `l main` | mostra 10 linhas
`show listsize` | mostra a quantidade de linhas que o sistema possui, por padrao sao 10 linhas
`set listsize 5` | para alterar a quantidade de linhas que serao exibidas
**.**
`quit` | sair do programa GDB
