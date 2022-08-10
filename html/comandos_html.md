# O que é HTML?

> Hypertext Markup Language (Linguagem de Marcação de Texto)

Não é uma linguagem de programação, ela serve para estruturar textos, criar links, vídeos, imagens, etc;

Item | Descrição
:-|:-
Hypertext | Textos que possuem links
Markup | Marcação do texto "tags"
Sintaxe | `<p>conteúdo</p>`
Atributos | href

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

Vamos abrir um `novo_arquivo.html` e `! + enter`, o próprio editor incluirá a estrutura básica de um html

- [x] Dentro do código estão alguns comentários
- [x] Vamos indentar para ter uma melhor visualização do código: selecionar de `<head>` até `</body>` e dar um TAB
- [x] Na parte `head` podemos incluir informações que não aparecerão na página
- [x] Abaixo de `<body>` incluímos o `<h1>título</h1>` 

```html
<!DOCTYPE html>
<html lang="pt-br"> <!-- alterar para pt-br (portugês brasileiro) 
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

___________


Comandos: Html | Descrição
:-|:-
!+enter| Estrutura básica do Html
< > | São tags
< / > | Fechar uma tag
< a > | Âncora
< br > | Pular linha
< h1 > | Título
< b > | Negrito
< hr > | Risco 
< big > | Aumenta o tamanho da letra
< h1 align="center" > | Título 1 + centralizado
< !--"texto"--> | Comentário
< header > | Cabeçalho
< section > | seções
< ul > | Lista não ordenada (com pontinhos)
< ol > | Lista ordenada (com números )
< li > | Dentro da Lista são os elementos
< p > | Parágrafo
lorem | Transformará em um texto para referência
< strong > | texto em negrito, introduzir valor R$10.00
< span > | tag genérica, não faz quebra de linha
< div > | tag genérica, executa quebra de linha
------ |  -------
href = | Atributo
------ |  -------
Ctrl+S | Salvar
Ctrl+R | Atualizar Página
Ctrl+O | Abrir arquivo no navegador
F12 + Console | Para localizar um problema no código
------ |  -------
< meta charset = "UTF-8"> | Utilizar no navegador para acentuação