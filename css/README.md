### O que é CSS?

> Cascading Style Sheets (Folha de Estilo em Cascata)

Tecnologia que serve para apresentar o visual para o cliente, dando estilos para o Html

<hr>

**Configurações CSS** 

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
pointer-events: none;
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
`<*>` | Início do CSS (Configuração Global)
`</* texto */>` | Comentário
`<.nomeDaClasse>` | Chamar uma classe (necessário o (.))
`<width>` | largura
`<padding>` | espaçamento interno

<hr>

## Cores

Comandos: CSS | Descrição
:-|:-
`<#0000ff>` | Cores
`<rgb(0, 0, 255)>` | Red, Green, Blue
`<rgba(27, 78, 33, 0.205)>` | Red, Green, Blue, Transparência
`<hsl(240, 100%, 50%)>` | Hue, Sturation, Luminosity (matiz, saturação e luminância)
`<background-image: linear-gradient();>` | Imagem em Degradê (direção, cores)

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
- [x] Fontes Externas ([Step by Step](https://github.com/PamelaRondina/html_css/tree/main/html_css_guanabara/modulo_02#fonte-externa))

Comandos: CSS | Descrição
:-|:-
`<font-family:Arial, Helvetica, sans-serif;>` | Família das Fontes

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
font-size: 12pt;>` | Fonte tamanho
text-transform: uppercase;>` | Maiúscula
text-justify: auto;>` | Texto justificado
line-height: 20px;>` | Linha Espaçamento | Altura da linha


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
`<font-weight: *** >` | Peso da Fonte
`<font-weight: bold;>` | Fonte negrito
`<font-style: italic;>` | Fonte Itálica
`<text-decoration: underline;>` | Fonte Sublinhado
`<ShortHand font>` | Melhoria para o Código

```css
/* Shorthand font
- font-style -> font-weight -> font-size -> font-family

font-style: italic;
font-variant: small-caps;
font-weight: bolder;
font-size: 3em;
font-family: 'Work Sans", sans-serif;
*/

font: italic bolder 3em 'Work Sans', sans-serif;
font: bold 2em 'Work Sans';
```

### IV. Alinhamento - Fonte

Comandos: CSS | Descrição
:-|:-
`<text-align:>` | Alinhamento
`<text-align: left;>` | Esquerda
`<text-align: right;>` | Direita
`<text-align: center;>` | Centro
`<text-align: justify;>` | Justificado
`<text-indent: 30px;>` | Parágrafo

## Listas

Comandos: CSS | Descrição
:-|:-
`<list-style: none;>` | Elimina marcações
`<list-style-position: inside;>` | Marcações para dentro
`<columns: 2;>` | Colunas dentro de uma lista


```css
ul {
    
}
```

<hr>

## Links

```css
a {

}
```

Comandos: CSS | Descrição
:-|:-
`<text-decoration: none;>` | Elimina link dos textos, elimina sublinhado

<hr>

## Seletores Personalizados

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

> Não iniciar com numeral ou caracteres especiais os nomes de *id*, *class* e *element* ( _ é aceito)

--->--->--->--->--->--->--->--->--->--->--->--->--->--->--->--->--->--->--->--->--->--->--->--->--->--->--->

Comandos: CSS | Descrição | Utilização
:-|:- | :-
HTML - <code>&lt;h1 id="nome"&gt;</code> | CSS - <code> h1#nome<code> | Único
HTML - class="nome" | CSS = <strong><big>.</big></strong>nome | Múltipos
<code>nome:hover</code> <code>nome:visited</code> <code>nome:active</code> <code>nome:checked</code><code>nome:empty</code> <code>nome:focus</code> | pseudo| class
<code>.nomeClass::after</code> <code>.nomeClass::before</code> | pseudo |element
> | | children

--->--->--->--->--->--->--->--->--->--->--->--->--->--->--->--->--->--->--->--->--->--->--->--->--->--->--->
### Pseudo-Class

Comandos: CSS | Descrição | 
:-|:- |
`<nome:hover>` | ação ocorre quando o mouse passa
`<nome:visited>` | 
`<nome:active>` | 
`<nome:checked>` | 
`<nome:empty>` | 
`<nome:focus>` | quando clica altera para a cor, ex.

```css
div:hover {
            background-color: rgba(255, 255, 0, 0.253);
        }

.item:nth-child(1):hover{
    background-color:#ff0000;
}

.item:first-child:hover,
.item:last-child:hover {
    background-color:#124a12;
}
```

### Pseudo-Element

> Formatação específica de um elemento

Comandos: CSS | Descrição | 
:-|:- |
`nome::before` | depois do elemento
`nome::after` | antes do elemento
`nome::first-letter` | 
`nome::first-line` | 

<hr>

## Display

Comandos: CSS | Descrição | 
:-|:- 
`display: none;` | Não visualizar
`display: block;` | Modo block - visualizar
`display: inline-block; `| blocos na mesma linha 
`display: grid;` | Tabela


**Blocos na mesma linha**

```css
div.quadrado {
            display: inline-block;
            border: 2px solid black;
            border-radius: 10px;
            width: 300px;
            height: 300px;            
        }
```
![image](https://user-images.githubusercontent.com/108991648/228563543-f57d81f4-2743-4b8a-89f5-b07e24b94860.png)

**display: grid;**

```css
 display: grid; 
 grid-template-columns: 1fr 1fr;`
```

![image](https://user-images.githubusercontent.com/108991648/233472010-e3639261-c29c-4b89-b70d-3ed0f246cdbf.png)

<hr>

## Modelos de Caixa 

![image](https://user-images.githubusercontent.com/108991648/225935450-64a4b146-3d92-4509-8315-64b3db864cff.png)

Comandos: CSS | Descrição | 
:-|:- 
`<width: 65px;>` | largura
`<min-width: 300px;>` | largura mínima
`<max-width: 1000px;>` | largura máxima
`<height: 10px;>` | altura
`<border: 10px;>` | borda - dentro do elemento
`<padding: 10px;>` | preenchimento interno
`<margin: 10px;>` | margem externa
`<outline: 1px;>` | entre a margem e border (+ margem)

### Tipos de Caixa

![image](https://user-images.githubusercontent.com/108991648/225364777-2d522a03-55df-4b57-924b-cf772542d2a2.png)

box-level (block-level) | Nova Linha |  inline-level  | Mesma Linha
:-|:- |-| -
`<h1 - h6>` Todo h1 é bold | <code>&lt;blockquote&gt;</code>| <code>&`abbr`   | <code>&lt;a&gt;</code> |
`div`  | `acronym`  |  <code>&lt;span&gt;</code> |
<code>&lt;main&gt;</code>    | <code>&lt;canvas&gt;</code>    | <code>&lt;b&gt;</code>  | <code>&lt;code&gt;</code> |
 <code>&lt;header&gt;</code> | <code>&lt;dd&gt;</code>        | <code>&lt;bdo&gt;</code>  | <code>&lt;small&gt;</code> | 
 <code>&lt;nav&gt;</code>    | <code>&lt;dl&gt;</code>        | <code>&lt;br&gt;</code>  | <code>&lt;strong&gt;</code> |
 <code>&lt;article&gt;</code>| <code>&lt;dt&gt;</code>        | <code>&lt;cite&gt;</code>  | <code>&lt;em&gt;</code> |
 <code>&lt;aside&gt;</code>  | <code>&lt;dieldset&gt;</code>  | <code>&lt;dfn&gt;</code>  | <code>&lt;sup sub&gt;</code> |
 <code>&lt;footer&gt;</code> | <code>&lt;figcaption&gt;</code>| <code>&lt;i&gt;</code>  | <code>&lt;label&gt;</code> |
 <code>&lt;form&gt;</code>   | <code>&lt;figure&gt;</code>    | <code>&lt;img&gt;</code>  | <code>&lt;button&gt;</code> |
 <code>&lt;video&gt;</code>  | <code>&lt;noscript&gt;</code>  | <code>&lt;kbd&gt;</code>  | <code>&lt;select&gt;</code> |
 <code>&lt;p&gt;</code>      | <code>&lt;tfoot&gt;</code>     | <code>&lt;map&gt;</code>  | <code>&lt;input&gt;</code> |
<code>&lt;ol&gt;</code>      | <code>&lt;table&gt;</code>     | <code>&lt;object&gt;</code>  | <code>&lt;output&gt;</code>
<code>&lt;ul&gt;</code>      | .-                              | <code>&lt;q&gt;</code>  |   <code>&lt;samp&gt;</code>
.-                            | .-                              | <code>&lt;script&gt;</code> | <code>&lt;textarea&gt;</code> 
.-                            | .-                              | <code>&lt;tt&gt;</code> | <code>&lt;var&gt;</code> 

### Margin - Preenchimento Externo

Comandos: CSS | Descrição | 
:-|:- 
<code>margin-top: 10px;</code> | ↑
<code>margin-right: 10px;</code> | →
<code>margin-bottom: 10px;</code> | ↓
<code>margin-left: 10px;</code> | ←
<code>margin: auto;</code> | centralizado
ShortHand <code>margin:</code> | Melhoria para o Código

```css
/* Shorthand margin
- margin-top -> margin-right -> margin-bottom -> margin-left
*/

margin: 10px 10px 10px 10px;
margin: 10px auto 10px auto;
```

```css
* {
    margin: 0;
}
```
![image](https://user-images.githubusercontent.com/108991648/213766860-1b052045-e927-431e-b1dc-389e9dfebc89.png)

### Outline

> Entre a margem e border (+ margem)

Comandos: CSS | Descrição | 
:-|:- 
<code>outline-width: 10px<;/code> | tamanho da borda
<code>outline-style: solid;</code> | estilo de borda: sólida
<code>outline-color: blue;</code> | cor da borda
ShortHand <code>outline:</code> | Melhoria para o Código

```css
/* Shorthand outline
- outline-width -> outline-style -> outline-color
*/

outline: 10px solid red;
```



### Border

Comandos: CSS | Descrição | 
- | - 
<code>border-width: 10px</code> | tamanho da borda
<code>border-style: solid;</code> | estilo de borda: sólida
<code>border-color: blue;</code> | cor da borda
ShortHand <code>border:</code> | Melhoria para o Código

```css
/* Shorthand border
- border-width -> border-style -> border-color
*/

border: 10px solid red;
```

### Padding - Preenchimento Interno

Comandos: CSS | Descrição | 
:-|:-
<code>padding-top: 10px;</code> | ↑
<code>padding-right: 10px;</code> | →
<code>padding-bottom: 10px;</code> | ↓
<code>padding-left: 10px;</code> | ←
ShortHand <code>padding:</code> | Melhoria para o Código

```css
/* Shorthand padding
- padding-top -> padding-right -> padding-bottom -> padding-left
*/

padding: 10px 10px 10px 10px;
```
<hr>

## Caixas - |box-size|

Cada box possui 4 edges:
- margin edge;
- border edge;
- padding edge;
- content edge.

### Grouping Tags

Comandos: CSS | Descrição | 
:-|:-:
`<header>`| cabeçalho
`<nav>` | navegação - Links
`<main>` | conteúdo principal
`<section>` | sessão
`<article>` | 
`<aside>` | Conteúdo periférico
`<footer>` | rodapé

![image](https://user-images.githubusercontent.com/108991648/225978264-b0a9e760-e684-46e7-beb8-9e9538e7605f.png)

![image](https://github.com/PamelaRondina/PamelaRondina/assets/108991648/4c6e9157-107c-4ba0-966a-073e3a168250)

-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->

### Sombras 

#### Caixa - Sombra

Comandos: CSS | Descrição | 
:-|:-:
`<box-shadow: ***;` | caixa de sombra
`<box-shadow: 1px 1px 1px 1px black;` | **↮  - ↕  - esbaçamento - espalhamento - cor da sombra**

#### Letra - Sombra

Comandos: CSS | Descrição | 
:-|:-:
`<text-shadow: ***;>` | caixa de sombra
`<text-shadow: 1px 1px 1px 1px black;>` | **↮  - ↕  - esbaçamento - espalhamento - cor da sombra**


### Bordas

Comandos: CSS | Descrição | 
:-|:-:
`<border-radius: ***;>` | bordas
`<border-top-left-radius: ***;>` | borda cima esquerda
`<border-top-right-radius: ***;>` | borda cima direita
`<border-bottom-right-radius: ***;>` | borda baixo direita
`<border-bottom-left-radius: ***;>` | borda baixo esquerda
`<ShortHand <>border-radius:>` | Melhoria para o Código

```css
/* Shorthand padding
- border-top-left-radius --> border-top-right-radius --> border-bottom-right-radius --> border-bottom-left-radius
*/

border-radius: 10px 50px 70px 5px;
```

**Círculo**

```css
   div#bola{
            height: 100px;
            width: 100px;
            background-color: white;
            margin: 10px;;
            border-radius: 50px;
        }
```

Borda por imagem: [Link](https://www.youtube.com/watch?v=n0rjAs_Im4w)

<hr>

## Flexbox

Organizar os elementos na interface, por meio de dois eixos: principal `flex-direction` e transversal 

![image](https://github.com/PamelaRondina/PamelaRondina/assets/108991648/3d4f0317-5d7b-466d-b8b7-b772e96c09d8)
![image](https://github.com/PamelaRondina/PamelaRondina/assets/108991648/8b20a1e3-a53d-42e7-85cd-a4e4e5b646d0)






<hr>

### Imagem

**Centralizar imagem**


```css
img {
    width: 95%;
    margin: auto;
    display: block;
    
}
```

<hr>

## Background

Comandos: CSS | Descrição | 
:-|:-:
<code>background-image: url('link');</code> | imagem anexada de fundo (ocorre repetição da imagem)
<code>background-repeat: ---;</code> | -
<code>background-position: ---;</code> | -
<code>background-size;</code> | tamanho da imagem

**background-image: url('link');**

```css
 body {
            background-image: url('images/wallpaper001.jpg');

            background-image: url('https://avatars.githubusercontent.com/u/8683378?v=4');
        }
```

**background-repeat: ---;**

![image](https://user-images.githubusercontent.com/108991648/228570106-3cd3653f-1479-4242-8e3b-866a4ee3c8a2.png)

**background-position: ---;**

![image](https://user-images.githubusercontent.com/108991648/228622922-73510d93-c9d8-41c9-b79a-911c6bb53753.png)

![image](https://user-images.githubusercontent.com/108991648/228623618-39e441bd-277f-417d-8ffb-19672c1de5d2.png)

**background-image: url('link');**

Propriedade | O que faz...
-: | :- 
<code>[length]px</code> <code>[length]%</code> | Redimensiona a largura da imagem e faz a altura se adaptar automaticamente. Podemos também informar as duas dimensões na sequência ou também usar valores percentuais.
<code>cover</code> | Muda o tamanho da imagem para que ela seja sempre totalmente exibida na tela, sem nenhum corte.
<code>contain</code> | Redimensiona a imagem para que ela cubra o contêiner, mesmo que para isso ocorram alguns eventuais cortes.

<hr>

### Variáveis

Comandos: CSS | Descrição | 
:-|:-:
<code>:root: --nome-variavel;</code> | criar variável

```css
:root {
    --cor0: #c5ebd6;
    --cor1: #83e1ad;
    --cor2: #3ddc84;
    --cor3: #2fa866;
    --cor4: #1a5c37;
    --cor5: #063d1e;
    
    --fonte-padrao: Arial, Verdana, Helvetica, sans-serif;
    --fonte-destaque: 'Bebas Neue', cursive;
    --fonte-android: 'Android', cursive;
}

body {
    background-color: var(--cor0);
    font-family: var(--fonte-padrao);
}
```

### Configuração Global

Comandos: CSS | Descrição | 
:-|:-:
`* { };` | configuração que vale para todos os elementos

```css
* {
    margin: 0;
    padding: 0;;
}
```

<hr>

### Responsividade - Midia Query

> Página acessível para diversas plataformas

Comandos: CSS | Descrição | 
:-|:-:
`@media` | configuração que vale para todos os elementos
 - Incluir no final do arquivo de CSS ou;
 - criar um novo arquivo apenas para a `@media`

```css
@media (max-width: 450px) {
    /* incluir dados para serem alterados conforme a página seja menor */
}
```


<hr>

Ferramentas para CSS | Link
-|-
Css Gradient | [Link](https://cssgradient.io/)
Adobe Color | [Link](https://color.adobe.com/pt/create/color-wheel)
Paletton | [Link](https://paletton.com/#uid=1000u0kllllaFw0g0qFqFg0w0aF) - ex: com site
Responsive Viewer | Extensão Google