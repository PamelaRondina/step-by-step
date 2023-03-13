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

> Note que ao final de cada linha finalizamos com ( **;** ).
    
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

## Item a item


## Total da Pagina

**Margin**

Espaçamento da tela com os elementos

```css
* {
    margin: 0;
}
```
![image](https://user-images.githubusercontent.com/108991648/213766860-1b052045-e927-431e-b1dc-389e9dfebc89.png)

**Padding**

INSERIR 

## Body

```css

```

- Font-family = inserir a fonte


## Header

```css
.cabecalho {
    background-color: rgb(109, 132, 194);
    display: flex;
       justify-content: space-between;
}
```
- background-color = cor do fundo
- display: flex = faz com que os elementos fiquem um ao lado do outro

![image](https://user-images.githubusercontent.com/108991648/213780218-f40cc3f2-01a3-4b41-b8f7-6fa557427d86.png)

   - justify-content: space-between = espaço entre os elementos

![image](https://user-images.githubusercontent.com/108991648/213780731-65533c01-bcc4-401f-a3b8-f90494d49aa1.png)

```css
.cabecalho .logo {
    width: 65px;
}
```
- width = alterar o tamanho da imagem

```css
.cabecalho .menu {
    display: flex;
    height: 100%;
    align-items: center;
```
- display-flex = faz com que os elementos fiquem um ao lado do outro
- height = altura / espaçamento
-  align-items: center = alinhar no centro

___________________

**Opacidade**

```css
.card {
  background-color: #ffffff20 (branco);
  background-color: #00000060 (preto);
}
```
_________________
**Transparente**

```css
background-color: transparent;
```
____________________

**Sombra**

```css

box-shadow: 3px 3px 1px 0px
```
(Sombra -> baixo <- cima)

_________

**Eliminar linhas das bordas**
```css
 outline: none;
```

______________

**linha do formulário mudar de cor ao clicar**

```Css
.label-float input:focus{
  border-bottom: 2px solid #4038a0;
}
```

_________________

**linha do formulário ao incluir dados manter**

```css
.label-float input:focus + label,
.label-float input:valid + label{
  font-size: 13px;
  margin-top: 0;
  color: #4038a0;
  border-bottom: 2px solid #4038a0;
  ```
_________________

**Pointer - cursor do mouse**

```css
pointer-event: none;
cursor: pointer;
```

_______________________

**Ficar por cima**

```css
position: absolute;
```

_______________________

**Efeitos do Button**

```css
button:hover{
  background-color: #687A64;
  transition: all .3s ease-out;  
}
```

________________

**Centralizar**

```css
.justify-center{
  display: flex;
  justify-content: center;
}
```

______________


CSS GRADIENTE .IO

___________

## Fonte

Comandos: CSS | Descrição
:-|:-
<code>font-weight: bold;</code> | Fonte negrito
<code>font-size: 12pt;</code> | Fonte tamanho



<hr>

Comandos: CSS | Descrição
:-|:-
<code>*</code> | Início do CSS
<code>/* texto */</code> | Comentário
<code>.nomeDaClasse</code> | Chamar uma classe (necessário o (.))
<code>width</code> | largura
<code>padding</code> | tamanho

<hr>

## Listas

```css
ul {

}
```

Comandos: CSS | Descrição
:-|:-
<code>list-style: none;</code> | Elimina marcações
<hr>

## Links

```css
a {

}
```

Comandos: CSS | Descrição
:-|:-
<code>text-decoration: none;</code> | Elimina link dos textos



<hr>

Ferramentas para CSS | Link
-|-
Css Gradient | [Link](https://cssgradient.io/)
Responsive Viewer | Extensão Google