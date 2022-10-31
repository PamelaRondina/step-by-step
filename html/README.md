# O que é HTML?

> Hypertext Markup Language (Linguagem de Marcação de Texto)

Não é uma linguagem de programação, ela serve para estruturar textos, criar links, vídeos, imagens, etc;

Item | Descrição
:-|:-
Hypertext | Textos que possuem links
Markup | Marcação do texto "tags"
Sintaxe | `<p>conteúdo</p>`
Atributos | href

> i) Html, ii) CSS, e iii) JavaScript <br>
 i) conteúdo, ii) estilo/design, e iii) interatividade
 __________

**Sintaxe de uma tag <>** 

Em html utilizamos tags `<>`

```html
 <p>conteúdo</p>
```

- [x] `<p>` para abrir uma tag de um parágrafo
- [x] `</p>` para fechar a tag 

>Para sabermos se uma tag está obsoleta podemos consultar o site, [item Obsolete Features](https://html.spec.whatwg.org/multipage/)
_______

**Atributos**

Adicionam informações e configurações à uma tag, neste caso, adicionar um link.

- `<a` abertura de tah
- `href` parâmetro
- `site ou arquivo` valor
- `link` conteúdo
- `</a>` fechamento de tag

```html
<a href="www.site.com.br">link</a> <!--Link externo-->

<a href="arquivo.html">link</a> <!--Link interno-->
```
____________________

**Estrutura básica de Html [!+Enter]**

Vamos abrir um `novo_arquivo.html` e `! + enter`, o próprio editor incluirá a estrutura básica de um html, dentro do código estão alguns comentários:

- [x] O código é separado por duas áreas: head (cabeça) e body (corpo);
- [x] Vamos identar para ter uma melhor visualização do código: selecionar de `<head>` até `</body>` e dar um TAB;
- [x] Na parte `head` podemos incluir informações que não aparecerão na página, é a parte de configuração;
- [x] na parte `body` vamos incluir os conteúdos dos sites, todos os elementos que serão visíveis.
- [x] Abaixo de `<body>` incluímos o `<h1>título</h1>` 

```html
<!DOCTYPE html>
<html lang="pt-br"> <!-- idioma que o site, alterar para pt-br (português brasileiro) 
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

**Inclusão de imagem**

- De diretório local
```html
<img src="logo-html150.png" alt="imagem HTML5">
```

- De uma url ***********

<hr>

**Inclusão de emoji**

[Site Emoji](https://www.emojipedia.org/openmoji/) 

- [x] Escolha um emoji e vá até a seção "Codepoints" próximo do fim da página;
- [x] Note o código, por exemplo, `U+1F970`
- [x] Para incluir em HTML para alterar o `U+` por `&#x`, passando para `&#x1F970`

<hr>

**Inclusão de ícones**

[Site Boxicons](https://boxicons.com/usage)

Em head, incluir `<link href='https://unpkg.com/boxicons@2.1.1/css/boxicons.min.css' rel='stylesheet'>`

<hr>

## Passo a passo

- [x] ! + Enter
- [x] Identar de `<head>` até `</body>` 
- [x] Deletar `<meta http-equiv="X-UA-Compatible" content="IE=edge">`
- [x] Alterar o título
- [x] Em head, adicionar arquivo CSS `<link rel="stylesheet" href="style.css">` - 
- [x] Em body, adicionar arquivo JavaScript `<script src="script.js"></script>`

> CTRL + Espaço (abrem os arquivos)

- [x] Em head, incluir link de ícones
`    <!--para a visualização dos ícones-->
        <link href='https://unpkg.com/boxicons@2.1.1/css/boxicons.min.css' rel='stylesheet'> `

- [x] 

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

<br>

**TAGS** | **NÃO possui fechamento**
:-|:-
&lt;a&gt; | âncora
&lt;br&gt; | pular linha
&lt;b&gt;  | negrito
&lt;hr&gt;  | linha horizontal
&lt;big&gt;  | aumenta o tamanho da letra
&lt;h1 align="center"&gt; | título 1 + centralizado
&lt;!--"texto"--&gt; | comentário
&lt;input/&gt;| cria uma lacuna de preenchimento

<br>

**TAGS < / >** | **POSSUI fechamento**
:-|:-
&lt;h1&gt;  | título, de 1 até 6
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
`&#x1F604;` | inserir emoji

<br>

**HTML Entities** | **Símbolos**
:-|:-
W3School | [Link](https://www.w3schools.com/charsets/ref_utf_symbols.asp)
`&lt;` | < menor que, less than
`&gt;` | > maior que, greater than
`&reg;` | &reg; marca registrada
`&copy;` | &copy; copyright
`&empty;` | &empty; vazio



