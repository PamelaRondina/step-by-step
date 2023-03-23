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

**Inclusão de emoji**

[Site Emoji](https://www.emojipedia.org/openmoji/) 

- [x] Escolha um emoji e vá até a seção "Codepoints" próximo do fim da página;
- [x] Anote o código, por exemplo, `U+1F970`
- [x] Para incluir em HTML: alterar o `U+` por `&#x`, passando para `&#x1F970`

<hr>

**Inclusão de ícones**

[Site Boxicons](https://boxicons.com/usage)

Em head, incluir `<link href='https://unpkg.com/boxicons@2.1.1/css/boxicons.min.css' rel='stylesheet'>`

 <link href='https://unpkg.com/boxicons@2.1.1/css/boxicons.min.css' rel='stylesheet'>

______________________

**Incluir Links do CSS**

Incluir no espaço head acima do Tittle

```html
<link rel="stylesheet" href="css/reset.css">
```

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

<hr>

## Adicionar favicon

Favicon é o ícone que aparece na guia do navegador

![image](https://user-images.githubusercontent.com/108991648/183938708-be7b8236-d0c0-40cb-aff5-97d1516bc356.png)

Podemos criar ícones nos sites abaixo:

Recomendação|Sites|Tipo
:-|:-|:-
IconArchive|https://iconarchive.com/|Ícones feitos
Favicon|https://www.favicon.cc/| Criar um Icon
Favicon .io | https://favicon.io/|De PNG para Icon - Emojis para Icon

Após escolher o ícone, extensão ICO, salve o arquivo em seu repositório.

Em `head`, acima de `title`, vamos incluir:

- [x] Digitar link, procurar por `link:favicon` e apertar enter
- [x] Em `href=` deletar `favicon.ico` 
- [x] Nas aspas de `href=` clique Ctrl+espaço e selecione o arquivo

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

<hr>

**TAGS** | **NÃO possui fechamento**
:-|:-
&lt;br&gt; | pular linha
&lt;hr&gt;  | linha horizontal
&lt;h1 align="center"&gt; | título 1 + centralizado
&lt;!--"texto"--&gt;  ou `Ctrl + ;`  | comentário
&lt;input/&gt;| cria uma lacuna de preenchimento


<hr>

**TAGS < / >** | **POSSUI fechamento**
:-|:-
&lt;h1&gt;  | título, de 1 até 6
&lt;header&gt;  | cabeçalho
&lt;section&gt; | seções
&lt;p&gt; | parágrafo
&lt;ins&gt;  | texto sublinhado
&lt;strong&gt;  | texto em negrito
&lt;em&gt;  | texto em itálico
&lt;mark&gt;  | marca texto
&lt;pre&gt;&lt;code&gt;  | texto como código - monoespaçado
&lt;big&gt;  | aumenta o tamanho da letra
&lt;small&gt;  | diminui o tamanho da letra
&lt;del&gt;  | risco no centro do texto
&lt;sup&gt;  | texto sobrescrito<sup>11</sup> 
&lt;sub&gt;  | texto subscrito<sub>11</sub>
&lt;q&gt; | citação simples"texto"
&lt;blockquote cite="site"&gt; | citação completa 
&lt;abbr title="text"&gt; | abreviações 
&lt;<bdo dir="rtl">Texto</bdo> | texto invertido
&lt;span&gt;  | tag genérica, não faz quebra de linha
&lt;div&gt;  | tag genérica, executa quebra de linha
&lt;button&gt;| cria uma botão, texto entre as tags não precisa de **" "**
`&#x1F604;` | inserir emoji

<hr>

## Listas

**TAGS < / >** | Descrição
:-|:-
<code>&lt;ol type="opções" start="4"&gt;  | lista ordenada <code>(1  A  a  I  i)</code>
<code>&lt;ul type="opções" start="4"&gt;  | lista NÃO ordenada <code>(bolinhas - disc   circle   square)</code>
&lt;li&gt;  | Elementos (não precisa fechar a TAG)
&lt;dl&gt;  | Definition List
&lt;dt&gt;  | Termo
&lt;dd&gt;  | Definição

<hr>

## Links

**TAGS < / >** | Descrição
:-|:-
&lt;a&gt; | âncora
&lt;a href="link"&gt; | âncora + incluir link
&lt;hreflang="en"&gt; | indica o idioma principal
&lt;...rel="external"&gt; | página externa
&lt;...rel="next"&gt; | próxima página, avanço
&lt;...rel="prev"&gt; | página anterior
&lt;...rel="nofollow"&gt; | não seguir o conteúdo (páginas externas)
&lt;...target="_blank...&gt; | abrir em uma nova aba
&lt;...target="_self...&gt; | na própria aba
&lt;...target="_top...&gt; | desfaz os frames e abre o destino no navegador completo (desuso)
&lt;...target="_parent...&gt; | referência a janela mãe (desuso)
<big>**../**</big> |  retorna 1 diretório
&lt;...download="nomearquivo" type="application/pdf"&gt; | para download de arquivos na minha página

**LINK para saber tipo de download (media types)** [Iana](https://www.iana.org/assignments/media-types/media-types.xhtml)

```html
  <h2>Links Internos - criar outras páginas</h2>    
    <p>Acesse a <a href="pag002.html" rel="next" target="_self">página 002.</a></p>
```
<hr>

## Imagens

**TAGS < / >** | Descrição
:-|:-
&lt;picture&gt; | tag para incluir imagens
<code>&lt;source media="(max-width: 1050px)" srcset="imagens/foto-m.png" type="image/png"&gt;</code> | imagem < que 1050px, abra o arquivo M> **ordem do menor para o maior**
&lt;img src &gt; | incluir imagem

- 1 - picture
- 2 - source
  - media (tamanho máximo)
  - srcset (imagem carregada) 
  - type (media type)
- 3 - img

```html
<picture>
        <source media="(max-width: 750px)" srcset="imagens/foto-p.png" type="image/png">
        <source media="(max-width: 1050px)" srcset="imagens/foto-m.png" type="image/png">
        <img src="imagens/foto-g.png" alt="Imagem G">
    </picture>
```

**Inclusão de imagem**

- De diretório local
```html
<img src="logo-html150.png" alt="imagem HTML5">
```
- [x] **src** local de onde estará o arquivo
- [x] **alt** Nome alternativo para incluir texto alternativo

> Ctrl + espaço (abre a lista de arquivos de uma determinada pasta)

- De uma url 

**Copiar endereço da imagem**

```html
<img src="colar_endereco_da_imagem" alt="Imagem da internet">
```

<hr>

## Color


**BackGround colorido**
```html
<style>
        body {
            background-color: chartreuse;
        }
    </style>
```

**H1 colorido**
```html
<h1 style="color:green;">Teste<h1>
```

Dicas Html Cores de Fundo: [Aqui](https://pt.wikihow.com/Configurar-Cores-de-Fundo-em-HTML#:~:text=Se%20quiser%20usar%20cores%20b%C3%A1sicas,plano%20de%20fundo%20usando%20HTML.)


<hr>

## Áudios

**TAGS < / >** | Descrição
:-|:-
<code>&lt;audio preload="metadata" controls autoplay loop></code> | atributo audio
<code>&lt;source src="local/midia.mp3 type="audio/mpeg"><code> | midia mp3
<code>&lt;source src="local/midia.ogg type="audio/ogg"><code> | midia mp3
<code>&lt;source src="local/midia.wav type="audio/mpeg"><code> | midia wav

- [x] Atributo preload:
  - *metadata*: carrega apenas as informações sobre o arquivo (tamanho, tempo, informações)
  - *none*: não carrega informações, até que o usuário clique no botão
  - *auto*: carrega o áudio por completo assim que a página for carregada, mesmo que o usuário não aperte o play.
  
<hr>

## Vídeos

**TAGS < / >** | Descrição
:-|:-
<code>&lt;video class autoplay loop width="" poster="" controls&gt;&lt;source  src="" type=""></code> | tag para incluir vídeos

- *width*: largura do vídeo
- *poster*: capa

**Conversor para vídeos** [HandBrake](https://handbrake.fr/)

Navegador | Arquivos compatíveis
:-| :-
Microsoft Edge | .mp4 .m4v
Apple Safari | .mp4 .m4v
Google Chrome | .mp4 .m4v .webm .gov
Mozilla Firefox | .webm .ogv
Opera | .webm .ogv

<hr>

**HTML Entities** | **Símbolos**
:-|:-
W3School | [Link](https://www.w3schools.com/charsets/ref_utf_symbols.asp)
`&lt;` | < menor que, less than
`&gt;` | > maior que, greater than
`&reg;` | &reg; marca registrada
`&copy;` | &copy; copyright
`&empty;` | &empty; vazio

<hr>

Sites para Imagens | Acesso
:-|:-
Pexels|https://www.pexels.com/pt-br/procurar/cachorro/
Unplash|https://unsplash.com/
Freepik|https://br.freepik.com/
Rawpixel|https://www.rawpixel.com/
Pixabay|https://pixabay.com/pt/
LibreShot|https://libreshot.com/

<hr>

## Software GIMP

- [x] Software Gimp (programa gratuito para edição de imagens)

 * Utilizar a ferramenta de corte para identificar o tamanho que deseja da imagem 
* Diminuir a largura do arquivo: imagem > Redimensionar 
<br>

## Criar arquivo

- [x] Arquivo + Novo
- [x] Alterar largura x altura 
- [x] Opções avançadas: alterar resolução

Largura | Altura | Resolução x | Resolução y | Específico
- |- | - | - | - | - |
300 | 300 | 80 x | 80 x |Celular
700 | 700 | 80 x | 80 y | Tablet
100 | 1000 | 80 x | 80 y | Computador/Televisão

**Exportar para salvar em PNG**

<hr>

