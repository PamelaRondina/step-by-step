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

## Comandos: CSS

Comandos: CSS | Descrição
:-|:-
<code>*</code> | Início do CSS (Configuração Global)
<code>/* texto */</code> | Comentário
<code>.nomeDaClasse</code> | Chamar uma classe (necessário o (.))
<code>width</code> | largura
<code>padding</code> | tamanho

<hr>

## Cores

Comandos: CSS | Descrição
:-|:-
<code>#0000ff</code> | Cores
<code>rgb(0, 0, 255)</code> | Red, Green, Blue
<code>rgba(27, 78, 33, 0.205)</code> | Red, Green, Blue, Transparência
<code>hsl(240, 100%, 50%)</code> | Hue, Sturation, Luminosity
<code>background-image: linear-gradient();</code> | Imagem em Degradê (direção, cores)

**Gradiente**

```css
  body {
            background-image: linear-gradient(to right, #E5C3A1, #FFD8B1, #FDB1A7, #67BAB7);
        }
```
Psicologia das Cores - [RockContent](https://rockcontent.com/br/blog/psicologia-das-cores/)

![image](https://user-images.githubusercontent.com/108991648/224860321-a3c06dc2-eed4-4b22-93b0-7b0953201df7.png)

<hr>

## Fonte

### I. História e Família - Fonte

- [x] História Fontes [Link](https://github.com/PamelaRondina/html_css/tree/main/html_css_guanabara/modulo_02#hist%C3%B3ria-das-fontes)
- [x] Google Fontes ([Step by Step](https://github.com/PamelaRondina/menu_digital#editando-as-fontes))
- [x] Fontes Externas ([Step by Step](https://github.com/PamelaRondina/html_css/tree/main/html_css_guanabara/modulo_02#fonte-externa)

Comandos: CSS | Descrição
:-|:-
<code>font-family:Arial, Helvetica, sans-serif;</code> | Família das Fontes

**Google Fonts**
```css
<style>
        @import url('https://fonts.googleapis.com/css2?family=Satisfy&display=swap');
        
        h1 {
            font-family: 'Satisfy', cursive;
        }
    
</style>
```

**Fontes Externas**
```css
<style>
    @font-face {
    font-family: 'CrieUmNome';
    src: url('fonts/Bachelorette_PERSONAL_USE_ONLY.otf') format('opentype');
    font-weight: normal;
    font-style: normal;
    }

body {
    font-family: 'CrieUmNome', Times, serif;
    font-size: 3em;
    font-weight: normal;
    }
    </style>
```

### II. Tamanho - Fonte

Comandos: CSS | Descrição
:-|:-
<code>font-size: 12pt;</code> | Fonte tamanho




Medida | Absoluta |     Medida | Relativa
-|-|-|-
cm |    centímetro |    em |    ao tamanho do M 
mm |    milímetro |     ex |    ao tamanho do "x            "
in |    polegada |  rem|      a fonte configurada no Body  
px |    pixel | vw|     largura da tamanho da tela
pt |    ponto | vh| altura do tamanho da tela
pc |    paica | % | porcentagem

Recomendação W3C: **em** e **px**

### III. Tipo e Peso - Fonte
Comandos: CSS | Descrição
:-|:-
<code>font-weight: *** </code> | Peso da Fonte
<code>font-weight: bold;</code> | Fonte negrito
<code>font-style: italic;</code> | Fonte Itálica
<code>tex-decoration: underline;</code> | Fonte Sublinhado
<code>ShortHand font</code> | Melhoria para o Código

```css
/* Shorthand font
- font-style -> font-weight -> font-size -> font-family

font-family: 'Work Sans", sans-serif;
font-weiht: bolder;
font-size: 3em;
font-style: italic;
*/

font: italic bolder 3em 'Work Sans', sans-serif;
font: bold 2em 'Work Sans';
```

### IV. Alinhamento - Fonte

Comandos: CSS | Descrição
:-|:-
<code>text-align: </code> | Alinhamento
<code>text-align: left; </code> | Esquerda
<code>text-align: right; </code> | Direita
<code>text-align: center; </code> | Centro
<code>text-align: justify; </code> | Justificado
<code>text-indent: 30px; </code> | Parágrafo

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

## ID e Class

Comandos: CSS | Descrição
:-|:-
HTML - <code>&lt;h1 id="nome"&gt;</code> | CSS - <code> h1#nome<code>
HTML - class="nome" | CSS = <strong><big>.</big></strong>nome

<hr>

Ferramentas para CSS | Link
-|-
Css Gradient | [Link](https://cssgradient.io/)
Adobe Color | [Link](https://color.adobe.com/pt/create/color-wheel)
Paletton | [Link](https://paletton.com/#uid=1000u0kllllaFw0g0qFqFg0w0aF) - ex: com site
Responsive Viewer | Extensão Google