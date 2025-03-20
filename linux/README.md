# Comandos: Linux


**Sistema Operacional** 

Software, ou conjunto de software, tem como função administrar e gerenciar os recursos do sistema: componentes de hardware, sistemas de arquivos, programas de terceiros.

Sua principal função é estabelecer uma interface entre o hardware e o usuário.

Mais utilizados:
- Microsoft windows;
- Mac OS;
- Linux.

**Kernel**
Ponte entre o usuário e o hardware. Compõe a parte central do SO



Comandos Básicos | Linux | English
:-:|:-|:-
**Cores** | 
Azul escuro ou d |	Diretórios (pastas)
Cianos	ou l |	Atalho
Branco ou -	|	Arquivo
**-->**
`~` | Diretório 0 (raiz), para seguir: **cd /c**
`cd` | Mudar de diretório/carpeta | Change **into** an existing directory
`cd ..` | Retorna um diretório/carpeta | Change **backward** into an existing directory
`mkdir nomeDoDiretorio` | Make directory - Criar um diretório/carpeta
`touch nomeDoArquivo`| Criar arquivo/archivo
pwd | caminho do diretório atual | Print the current working directory
`CTRL+Insert` | copiar
`Shift+Insert` | colar
**ls** | 
`ls` | Lista arquivos | List the contents of the directory
`ls -a` | Lista arquivos + ocultos
`ls -l` | Lista arquivos + detalhes
`ls -1` | lista arquivos um abaixo do outro
**.**
cat | concatenar arquivos e imprimir o conteúdo de um arquivo | print the contents of a file
rm | remover arquivos
mv | mover ou renomear
`clear` `CTL + L` | limpar o terminal | Clear command line
echo | print informações no terminal | print information 

## Descompactar arquivos [link](https://kinsta.com/pt/base-de-conhecimento/extrair-descompactar-arquivos-tar-gz-linux-windows/)

**Versão Unzip**
`unzip --version`

**Instalar Unzip**
`sudo apt install unzip`

Comando | Linux
-|-
`unzip arquivo.zip` | Descompactar arquivos zip
`unzip arquivo.zip -d pasta_destino` | Descompactar em diretório específico


Outros Comandos | Linux
-|-
python -i | Iniciar Python
exit() | Encerrar Python
erase | apagar
history | acesso o histórico de comandos já executados
uname -a | comando para visualizar especificações do Linux do servidor
sudo su - | troca para usuário root
dnf para yum | (gerenciador de pacotes)
yum search maria | lista os pacotes
mysql -uroot -p | Estabelece conexão com o MariaDB Server, -u (usuário) root (master) -p(password)
systemctl status mariadb | administra aplicativos -status (se up ou down) 
rpm -qa | Trazer todos os pacotes instalados 
rpm -ql | Lista o que um determinado pacote instalou
rpm -qarpm | grep zabbix

excludepkgs=zabbix*

rpm -Uvh https://repo.zabbix.com/zabbix/6.0/rhel/7/x86_64/zabbix-release-6.0-4.el7.noarch.rpm
