# O que é HTML?

> Hypertext Markup Language (Linguagem de Marcação de Texto)

Não é uma linguagem de programação, ela serve para estruturar textos, criar links, vídeos, imagens, etc;

Item | Descrição
:-|:-
Hypertext | Textos que possuem links
Markup | Marcação do texto "tags"
Sintaxe | `<p>conteúdo</p>`
Atributos | href

> i) Html, ii) CSS, e iii) JavaScript 
 i) conteúdo, ii) estilo, e iii) interatividade
 
**Sintaxe de uma tag <>** 

Em html utilizamos tags `<>`

```html
 <p>conteúdo</p>
```

- [x] `<p>` para abrir uma tag de um parágrafo
- [x] `</p>` para fechar a tag 

**Atribuos**

Adicionam informações e configurações à uma tag, neste caso, adicionar um link.

```html
<a href="#">link</a>
```
____________________

Vamos abrir um `novo_arquivo.html` e `! + enter`, o próprio editor incluirá a estrutura básica de um html, dentro do código estão alguns comentários:

- [x] O código é separado por duas áreas: head (cabeça) e body (corpo);
- [x] Vamos indentar para ter uma melhor visualização do código: selecionar de `<head>` até `</body>` e dar um TAB;
- [x] Na parte `head` podemos incluir informações que não aparecerão na página, é a parte de configuração;
- [x] na parte `body` vamos incluir os conteúdos dos sites
- [x] Abaixo de `<body>` incluímos o `<h1>título</h1>` 

```html
<!DOCTYPE html>
<html lang="pt-br"> <!-- idioma que o site, alterar para pt-br (portugês brasileiro) 
<meta http-equiv="X-UA-Compatible" content="IE=edge"> DELETAR-->
<head>
    <meta charset="UTF-8"> <!-- Serve para não ter erro em acentuações e caracteres especiais -->
      <meta name="viewport" content="width=device-width, initial-scale=1.0"> <!-- Viewport serve para melhorar a visualização em aparelhos móveis e no navegador  -->
    <title>Document</title> <!-- Nome do que aparecerá no Browser -->
</head>
<body>
    <h1>Título</h1> <!-- Aqui será o título -->
</body>
</html>
```

<hr>


Comandos: HTML | Descrição
:-|:-
!+enter| Estrutura básica do Html
< > | são tags
&lt;/&gt; | fechar uma tag
href = | atributo
&lt;meta charset = "UTF-8"&gt; | utilizar no navegador para acentuação
lorem | utilizada na seção parágrafo, cria um texto aleatório
Ctrl+S | salvar
Ctrl+R | atualizar Página
Ctrl+O | abrir arquivo no navegador
F12 + Console | para localizar um problema no código
**TAGS** | **NÃO possui fechamento**
&lt;a&gt; | âncora
&lt;br&gt; | pular linha
&lt;b&gt;  | negrito
&lt;hr&gt;  | linha horizontal
&lt;big&gt;  | aumenta o tamanho da letra
&lt;h1 align="center"&gt; | título 1 + centralizado
&lt;!--"texto"--&gt; | comentário
&lt;input/&gt;| cria uma lacuna de preenchimento
**TAGS < / >** | **POSSUI fechamento**
&lt;h1&gt;  | título
&lt;header&gt;  | cabeçalho
&lt;section&gt; | seções
&lt;ul&gt;| lista não ordenada (com pontinhos)
&lt;ol&gt;  | lista ordenada (com números )
&lt;li&gt;  | dentro da Lista são os elementos
&lt;p&gt; | parágrafo
&lt;strong&gt;  | texto em negrito, introduzir valor R$10.00
&lt;span&gt;  | tag genérica, não faz quebra de linha
&lt;div&gt;  | tag genérica, executa quebra de linha
&lt;button&gt;| cria uma botão, texto entre as tags não precisa de **" "**
**HTML Entities** | **Símbolos**
W3School | [Link](https://www.w3schools.com/charsets/ref_utf_symbols.asp)
& lt; | < menor que
& gt; | > maior que
&reg; | &reg; marca registrada
&copy; | &copy; copyright
&empty; | &empty; vazio
