# GIT

## O que é GIT?

Software que permite que desenvolvedores trabalhem no mesmo projeto, sendo possível o rastreio das versões realizadas. 

Criado pelo engenheiro de software Linus Torvalds.

## Comandos GIT

| comando                                                                   | Descrição                                                                              |
|:--------------------------------------------------------------------------|:---------------------------------------------------------------------------------------|
| <code>Crtls + S</code>                                                    | SALVAR ARQUIVO                                                                         |
| <code>git --version</code>                                                | Versão do Git CMD                                                                      |
| <code>git clone</code>                                                    | Clonar um Repositório do GitHub                                                        |
| <code>git init</code>                                                     | Criar um repositório                                                                   |
| <code>git add nomeArquivo</code>                                          | add o arquivo para staged                                                              |
| <code>git add .</code>                                                    | add tudo o que foi modificado para o staged                                            |
| <code>git status</code>                                                   | status dos arquivos                                                                    |
| <code>git restore --staged nomeArquivo</code>                             | retorna o arquivo para unstage                                                         |
| <code>git commit -m "mensagem"</code>                                     | -m = incluir mensagem                                                                  |
| <code>git remote add origin linkGitHub</code>                             | trazer repositório do GitHub para local                                                |
| <code>git push origin main</code>                                         | Push local para remoto                                                                 |
| <code>git pull origin main</code>                                         | Pull remoto para local                                                                 |
| `git checkout nomeBranch`                                                 | Altera a branch                                                                        |
| `git config --global user.name`                                           | Altera o nome do usuário do GitHub                                                     |
| `git config --global user.email`                                          | Altera o e-mail do usuário do GitHub                                                   |
| `git branch -m`                                                           | Altera o nome da Branch                                                                |
| `git log`                                                                 | Informações commit: número ID, autor, date, descrição                                  |
| `git log graph`                                                           | Informações commit: ramificações                                                       |
| `git log --graph --pretty=oneline`                                        | Informações commit: ID em 01 linha e descrição                                         |
| `git log --graph --decorate --all --oneline`                              | Informações commit: ID menor em 01 linha                                               |
| `git config --global alias.tree "log --graph --decorate --all --oneline"` | i) alias.tree (apelido chamado tree); Em seguida, chamamos apenas `tree`               |
| `git diff` [^1]                                                           | Analisa alterações do último commit com o arquivo atual, antes de executar o `git add` |
| `git reset --hard 02150216`                                               | retorna para um commit específico                                                      |
| `git reflog`                                                              | Detalhes commit (log completo)                                                         |
| `git tag`                                                                 | Etiquetar commits                                                                      |
| `git branch nome-branch`                                                  | Cria a branch, mas não muda o branch atual. [^2]                                       |
| `git branch`                                                              | Listar Branches                                                                        |
| `git checkout -b nome-branch` ou `git switch -c nome-branch`              | Criar e trocar para a nova branch                                                      |
| `git checkout main`ou `git merge nome-branch`                             | Unir Branches                                                                          |
| `git branch -d nome-branch`                                               | Deletar branch                                                                         |  


____________________

<details>

<summary> <code>git clone</code> | Clonar Repositório </summary>
<br>
Após criar o repositório, copiar o código

![image](https://user-images.githubusercontent.com/108991648/230122644-2f3fffdb-5177-47f8-b219-ca7dc4275bcf.png)

No Terminal incluir: "<code>git clone</code> + Link copiado"

</details>

<details>
<summary> <code>git ignore</code> | Ignorar Arquivos </summary>

> Arquivo para adicionarmos informações que nao queremos utilizar no dia a dia

- [X] Criar pasta `.gitignore`;
- [X] Dentro do arquivo: `**/.nomeArquivo`

</details>

<details>
  <summary><code>git diff</code> | Analisar alterações do último Commit com o arquivo atual
   </summary>

[^1]: `git diff` 

```bash
$ git diff
diff --git a/python/README.md b/python/README.md
index b2391f6..c1164d6 100644
--- a/python/README.md
+++ b/python/README.md
@@ -88,7 +88,15 @@ lista.append(4) #adicionar item

 print(lista, lista2)

+## Funções
```

> **`diff --git a/python/README.md b/python/README.md`**

  - A diferença está sendo exibida entre duas versões do arquivo `README.md` no diretório `python`;
  - O prefixo `a/` refere-se à versão antiga, e `b/` refere-se à versão nova do arquivo.
  

> **`index b2391f6..c1164d6`**:
  - Hashes do commit para as versões antigas e novas do arquivo. Esses hashes (`b2391f6` e `c1164d6`) são identificadores únicos das versões do arquivo.
  - Isso indica que a versão do arquivo mudou entre esses dois commits.
  
<!--> **`100644`**: 
  - É o modo de permissão Unix do arquivo. O `100644` significa que o arquivo é um arquivo regular (não executável) e tem permissões padrão de leitura e escrita para o proprietário, e somente leitura para outros.
 > <-->

> **`--- a/python/README.md`**
> **`+++ b/python/README.md`**

  - Indicam as versões do arquivo antes e depois da mudança, com `a/` representando a versão anterior e `b/` a versão nova. (ultimo coomit e o save atual)


> **`@@ -88,7 +88,15 @@`**

  - Esse é o **hunk header**, linhas que ocorre a mudança;
  - **`-88,7`**: versão anterior, começando na linha 88 e mostrando 7 linhas.
  - **`+88,15`**: nova versão, começando também na linha 88, mas agora mostrando 15 linhas.
  - Isso indica que ^^8 linhas foram adicionadas à nova versão em torno da linha 88.


**Aos detalhes**
Na versão anterior tínhamos o seguinte bloco de código na linha 88:
```python
lista.append(4) #adicionar item

print(lista, lista2)
```

E agora o conteúdo a partir dessa linha foi expandido para incluir mais linhas de código (totalizando 15 linhas em vez de 7), a nova versão tem mais informações.

```
+## Funções
```

- **`+## Funções`**:
  - Este é o conteúdo que foi **adicionado** ao arquivo. O símbolo `+` indica que a linha `## Funções` foi adicionada no novo arquivo `README.md`.

> Resumo:
1. O arquivo `README.md` no diretório `python` foi modificado.
2. Ele mudou entre os commits `b2391f6` (antigo) e `c1164d6` (novo).
3. Na linha 88, o conteúdo foi expandido, de 7 linhas na versão antiga para 15 linhas na nova.
4. Uma seção com o título `## Funções` foi adicionada.

</details>

<details>
<summary><code>git reset -hard</code> | Retorna para commit específico</summary>

![alt text](image.png)

</details>

<details>
<summary><code>git reflog</code> | Detalhes Commit (Log Completo) </summary>

```bash
08f5adb (HEAD -> main, origin/main, origin/HEAD) HEAD@{0}: commit: add explicação 'git diff'
8e2974f HEAD@{1}: commit: add extensão: learn markdown
a03b07f HEAD@{2}: commit: add 'chamar função def'
3ac66ca HEAD@{3}: commit: adicionado: cabeçalho, expandir e recolher texto
b29b561 HEAD@{4}: commit: add operador de comparação
09c34f6 HEAD@{5}: commit: link markdown (diagrama)
e4a5e3f HEAD@{6}: commit: adicionado comando leitura readme
2416bbd HEAD@{7}: commit: novos comandos python
c42b61a HEAD@{8}: commit: novos comandos git
d56b0ad HEAD@{9}: commit: atualização 13.out
c97d892 HEAD@{10}: commit: atualização out.13
3d76ae7 HEAD@{11}: clone: from https://github.com/PamelaRondina/step-by-step.git
```
</details>

<details>
<summary><code>git tag</code> | Incluir etiquetas</summary>

- Nome para tags
- [x] minúsculas
- [x] guiones baixos 'aula_01' 
</details>


</details>

<details>
  <summary><code>git branch</code> | Alterar a Ramificação
   </summary>
<br>

[^2]: `git branch`

Uma linha de desenvolvimento separada que permite trabalhar em novas funcionalidades, correções de bugs, ou experimentações sem alterar diretamente a linha principal do código (geralmente a branch main ou master). Com branches, desenvolvemos novas partes do projeto isoladamente e depois integramos ao código principal quando estiverem prontas.


| Comando                                                            | Descrição                                   |
|--------------------------------------------------------------------|---------------------------------------------|
| `git branch nome-da-branch`                                        | Cria a branch, mas não muda o branch atual. |
| `git branch`                                                       | Listar Branches                             |
| `git checkout -b nome-da-branch` ou `git switch -c nome-da-branch` | Criar e trocar para a nova branch           |
| `git checkout main`ou `git merge nome-da-branch`                   | Unir Branches                               |
| `git branch -d nome-da-branch`                                     | Deletar branch                              |


**Benefícios de Trabalhar com Branches**
- Isolamento: Cada branch é isolada, então mudanças em uma branch não afetam as outras;
- Colaboração: Vários desenvolvedores podem trabalhar em diferentes branches sem interferir uns nos outros;
- Organização: Branches permitem organizar e gerenciar o desenvolvimento de novas funcionalidades, 
</details>

</details>

<details>
  <summary><code>git switch</code> X <code>git checkout</code> | Sobre Branches
   </summary>
<br>

**git checkout** é um comando mais antigo e possuem diversas funcionalidades.
- [x] Trocar de branch `git checkout nome-da-branch`
- [x] Restaurar arquivos ou commits específicos no repositório `git checkout nome-do-arquivo` ou `git checkout hash-do-commit`
- [x] Criar e trocar para uma nova branch com o flag -b `git checkout -b nova-branch`

**git switch** veio para simplificar a mudança de branches, tendo como função principal *trocar de branch*, permite apenas:
- [X] Mudar de branch `git switch nome-da-branch`
- [X] Criar e trocar para uma nova branch com o flag -c `git switch -c nova-branch`
- [X] Com sua utilização há menos risco de alterar arquivos ou commits por engano.

**Quando usar cada um?**
- `git switch` para mudar de branch ou criar uma nova branch e já trocar para ela;
- `git checkout` se precisar restaurar arquivos ou commits específicos, pois git switch não cobre essas funcionalidades.

| Comando                                                            | Descrição                                   |
|--------------------------------------------------------------------|---------------------------------------------|
| `git branch nome-da-branch`                                        | Cria a branch, mas não muda o branch atual. |
| `git branch`                                                       | Listar Branches                             |
| `git checkout -b nome-da-branch` ou `git switch -c nome-da-branch` | Criar e trocar para a nova branch           |
| `git checkout main`ou `git merge nome-da-branch`                   | Unir Branches                               |
| `git branch -d nome-da-branch`                                     | Deletar branch                              |


**Benefícios de Trabalhar com Branches**
- Isolamento: Cada branch é isolada, então mudanças em uma branch não afetam as outras;
- Colaboração: Vários desenvolvedores podem trabalhar em diferentes branches sem interferir uns nos outros;
- Organização: Branches permitem organizar e gerenciar o desenvolvimento de novas funcionalidades, 
</details>

_________________


## Comandos: Git Bash e GIT CMD

| **Comandos Linux**       | **Descrição**                                   | **Comandos Windows**                         |
|:------------------------:|:------------------------------------------------|:---------------------------------------------|
| `cd /`                   | Diretório 0 (raiz), para seguir: **cd /c**      | =                                            |
| `cd C:/`                 | Disco Local C:/                                 | =                                            |
| `clear` ou `CRTL + L`    | Limpar o terminal                               | `cls`                                        |
| `ls`                     | Listar arquivos e diretórios                    | `dir`                                        |
| `ls -a`                  | Listar arquivos + ocultos                       | `dir`                                        |
| `cd`                     | **change directory** Mudar de diretório/carpeta | =                                            |
| `cd -` - `cd ..`         | Retorna um diretório/carpeta                    | =                                            |
| `TAB`                    | Autocomplete                                    | =                                            |
| `mkdir nomeDoDiretorio`  | **make directory** Criar um diretório/carpeta   | =                                            |
| `echo hello > hello.txt` | Verificar e criar arquivo                       | =                                            |
| `touch nomeArquivo`      | Criar arquivo                                   | `type nul  > nomeArquivo.txt`                |
| `rm -rf nomeDiretorio`   | Eliminar Diretório e seus arquivos              | `rmdir /s/q nomeDiretorio`                   |
| `rm -rf nomeArquivo`     | Eliminar Arquivo dentro do Diretório            | `del nomeArquivo`                            |
| `rmdir nomeDiretorio`    | Eliminar apenas Diretórios vazios               | `RD nomeDiretorio` ou `rmdir nomeDiretorio/` |
| `rm -rf *` [^3]               | Eliminar TODOS os arquivos dentro do Diretório  | `del * /s/q`                            |
| `mv nomeAtual nomeNovo`  | Renomear arquivos                               | `rename nomeAtual nomeNovo`                  |
| `mv nomeArquivo ../`     | Mover arquivos                                  | `move nomeArquivo ../`                       |
| `pwd`                    | mostra diretório atual                          | ???????                                      |
| <code>cat</code>         | Mostrar o conteúdo o arquivo                    | ??????????                                   |
| `Code .`                 | abrir VSCode                                    | *****                                        |
| `Ctrl + Insert`          | Copiar do Terminal                              | **********                                   |
| `Shift + Insert`         | Colar do Terminal                               | **********                                   |


**Git Bash: cores diretórios e arquivos**

| **Cores**   | **Descrição**       |
|:-----------:|:--------------------|
| Azul escuro | Diretórios (pastas) |
| Cianos      | Atalho              |
| Branco      | Arquivo             |



**Git Bash `rm -rf *`**

[^3]: `rm -rf`  


> - rm: comando de deletar
> - r: *recursivo* deletar todos os arquivos do diretório específico
> - f: *force* não questionar a exclusão do diretório
> - *: todos os arquivos dentro do diretório
<br>



<details>
  <summary>Analisar Textos</summary>
<br>

<img src="https://user-images.githubusercontent.com/108991648/230180095-ceefd075-3b30-4451-8a96-5b4bc37abcce.png" width="500" height="400" />

<br>

<img src="https://user-images.githubusercontent.com/108991648/229250256-ab7bb919-c632-4c86-a03e-59f10a78e599.png" width="400" height="300"/>

<br><br>


**Chave SSH**
**SHA1** - gera a incriptação com 40 caracteres

**blob** - guarda o Sha e NÃO guarda o nome do arquivo

**tree \0** - arvores que armazenam blobs e guarda o nome do arquivo

**commit** o que da sentido para a alteração

<img src="https://user-images.githubusercontent.com/108991648/229250411-cef8dc87-9c7d-44d8-81cf-0e87790708a3.png" width="400" height="300"/>

![image](https://user-images.githubusercontent.com/108991648/229252048-9612a3c2-2234-4c86-b975-d90526057837.png)
<br>
touch nomeDoArquivo| Criar arquivo/archivo
python -i | Iniciar Python
exit() | Encerrar Python

</details>



