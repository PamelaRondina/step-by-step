# GIT

## Comandos: Git Bash e GIT CMD

**Comandos Linux**|**Descrição** | **Comandos Windows**
:-:|:- | :-
<code>clear</code> ou <code>CRTL + L</code> | Limpar o terminal | <code>cls</code>
<code>ls</code> | Lista arquivos e diretórios | <code>dir</code>
<code>ls -a</code> | Lista arquivos + ocultos | <code>dir</code>
<code>cd</code> | **change directory** Mudar de diretório/carpeta | =
<code>cd -</code> <code>cd ..</code>  | Retorna um diretório/carpeta | =
<code>cd /</code> | Diretório 0 (raiz), para seguir: **cd /c** | =
<code>TAB</code> | Autocomplete | =
<code>mkdir nomeDoDiretorio</code> | **make directory** Criar um diretório/carpeta | =
<code>echo hello > hello.txt</code> | Verificar e criar arquivo | =
touch | Criar arquivo | type nul  > nomeArquivo.txt
<code>rm -rf nomeDiretorio</code> | Elimina Diretório e seus arquivos | <code>rmdir /s/q nomeDiretorio</code>
<code>rm -rf nomeArquivo</code> | Elimina Arquivo dentro do Diretório | <code>del nomeArquivo</code>
<code>rmdir nomeDiretorio/</code> | Elimina apenas Diretórios vazios | <code>RD nomeDiretorio/</code> ou <code>rmdir nomeDiretorio/</code>
<code>rm -rf *</code> | Elimina TODOS os arquivos dentro do Diretório | <code>del * /s/q</code>
<code>mv nomeAtual nomeNovo</code> | Renomear arquivos | rename nomeAtual nome Novo
<code>mv nomeArquivo ../</code> | Mover arquivos | move nomeArquivo ../
pwd | mostra diretório atual | ???????
<code>cat</code> | Mostrar o conteúdo o arquivo | ??????????

**Cores** | **Descrição**
:-:|:-
Azul escuro |	Diretórios (pastas)
Cianos	|	Atalho
Branco	|	Arquivo

<br> 

_both_

<code>echo hello > hello.txt</code> 
Vai verificar se o arquivo 'hello' existe, se não, criar um arquivo txt.

<br>

_Bash_ 

<code>rm -rf * nomeDoDiretorio</code>
- rm: comando de deletar
- r: *recursivo* deletar todos os arquivos do diretório específico
- f: *force* não questionar a exclusão do diretório
- *: todos os arquivos dentro do diretório
<br>

<hr>

<img src="https://user-images.githubusercontent.com/108991648/229250256-ab7bb919-c632-4c86-a03e-59f10a78e599.png" width="400" height="300"/>



**SHA1** - gera a incriptação com 40 caracteres

**blob** - guarda o Sha e NÃO guarda o nome do arquivo

**tree \0** - arvores que armazenam blobs e guarda o nome do arquivo

**commit** o que da sentido para a alteração

<img src="https://user-images.githubusercontent.com/108991648/229250411-cef8dc87-9c7d-44d8-81cf-0e87790708a3.png" width="400" height="300"/>

![image](https://user-images.githubusercontent.com/108991648/229252048-9612a3c2-2234-4c86-b975-d90526057837.png)

**Chave SSH**



__________________


## Comandos GIT

comando | Descrição
:- | :-
<code>git --version</code> | Versão do Git CMD 
<code>git clone</code> | Clonar um Repositório do GitHub
<code>git init</code>| Criar um repositório 
<code>git add nomeArquivo</code> | add o arquivo para staged
<code>git add *</code> | add tudo o que foi modificado para o staged
<code>git status</code> | status dos arquivos
<code>git restore --staged nomeArquivo</code> | retorna o arquivo para unstage
<code>git commit -m "mensagem"</code> | -m = incluir mensagem 
<code>git remote add origin linkGitHub</code> | trazer repositório do GitHub para local
<code>git push origin main</code> | Push local para remoto
<code>git pull origin main</code> | Pull remoto para local
__________


## Clonar Repositório

Após criar o repositório, copiar o código
![image](https://user-images.githubusercontent.com/108991648/230122644-2f3fffdb-5177-47f8-b219-ca7dc4275bcf.png)

No Terminal incluir: "<code>git clone</code> + Link copiado"

<br>

![image](https://user-images.githubusercontent.com/108991648/230180095-ceefd075-3b30-4451-8a96-5b4bc37abcce.png)




________________
<br><br><br><br><br><br><br><br><br><br>
**AJUSTARRRR**
touch nomeDoArquivo| Criar arquivo/archivo
python -i | Iniciar Python
exit() | Encerrar Python
