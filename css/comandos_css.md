O que é CSS?
Cascading Style Sheets (Folha de Estilo em Cascata)

Tecnologia que serve para apresentar o visual para o cliente, dando estilos para o Html

Princípios que nos ajudarão a codar em CSS!
Declaration - Declaração

Quais são as propriedades e valores que serão aplicadas no elemento:

 body - (corpo) seletor
 { - abre chaves
 background - propriedade
 red- valor (alterar os estilos dos elementos)
 } - fecha chaves
body {
    background: red;
}
Comentários

Em CSS para inserir um comentário: /*texto*/

Cascata

Tendo 2 declarações, a última será o de maior relevância.

body {
    background: red;
}

body {
    background: blue;
}
Neste exemplo, o body será de cor blue

Porém, a cascata perde essa prioridade devido à especificidade, cada seletor terá um peso e sua soma trará a relevância de prioridade.

#id {
    /* peso 100*/
}

.class {
    /* peso 10*/
}

element {
    /* peso 1*/
}
image

Não inciar com numeral ou caracteres especiais os nomes de id, class e element ( _ é aceito)