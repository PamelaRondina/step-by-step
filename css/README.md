### O que é CSS?

> Cascading Style Sheets (Folha de Estilo em Cascata)

Tecnologia que serve para apresentar o visual para o cliente, dando estilos para o Html

<hr>

**Configurações CSS** 

As configurações para CSS são feitas através de seletores:

 - `p` = seletor
 - `font-family: Arial` = declaração
 - `color:` = propriedade. Sempre deve ter o seu valor e separado por ( **:** )
 - `blue` = valor
```css
    p {
        font-family: Arial;
        font-size: 12pt;
        color: blue;    }
```

> Note que: ao final de cada linha finalizamos com ( **;** ).
    
<hr>

**Declaration - Declaração**

Quais são as propriedades e valores que serão aplicadas no elemento:

- [x] `body` - (corpo) seletor
- [x] **{** - abre chaves
- [x] `background` - propriedade
- [x] `red`- valor (alterar os estilos dos elementos)
- [x] **}** - fecha chaves 

```css
body {
    background: red;
}
```

<hr>

**Comentários**

Em CSS para inserir um comentário: `/*texto*/` 

<hr>

**Cascata**

Tendo 2 declarações, a última será o de maior relevância.

```css
body {
    background: red;
}

body {
    background: blue;
}
```
> Neste exemplo, o body será de cor blue

Porém, a cascata perde essa prioridade devido à especificidade, cada seletor terá um peso e sua soma trará a relevância de prioridade.

```css
#id {
    /* peso 100*/
}

.class {
    /* peso 10*/
}

element {
    /* peso 1*/
}
```

![image](https://user-images.githubusercontent.com/108991648/183656135-7636b011-67da-4123-90c9-d3ae5f2f2cfe.png)


> Não inciar com numeral ou caracteres especiais os nomes de *id*, *class* e *element* ( _ é aceito)

<hr>

Comandos: CSS | Descrição
:-|:-
* | Início do CSS
/* comentário */ | Comentário
.nomeDaClasse | Chamar uma classe 

