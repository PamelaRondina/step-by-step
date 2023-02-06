# Comandos: Linux

**Comandos LInux** | **Descrição**
:-:|:-
Azul escuro ou d |	Diretórios (pastas)
Cianos	ou l |	Atalho
Branco ou -	|	Arquivo
/ | Diretório 0 (raiz), para seguir: **cd /c**
clear | limpar o terminal
ls | Lista arquivos
ls -a | Lista arquivos + ocultos
ls -l | Lista arquivos + detalhes
cd | Change directory - Mudar de diretório/carpeta
cd - | Retorna um diretório/carpeta
mkdir nomeDoDiretorio | Make directory - Criar um diretório/carpeta
touch nomeDoArquivo| Criar arquivo/archivo
python -i | Iniciar Python
exit() | Encerrar Python
Copiar | `CTRL+Insert`
Colar | `Shift+Insert`
history | acesso o histórico de comandos já executados
uname -a | comando para visualizar especificações do LInus do servidor
cat | concatenação (apenas arquivos)
pwd | diretório atual
sudo su - | troca para usuário root
dnf | yum (gerenciador de pacotes)

Comandos (VIM) | Descrição
-|-
vim ou vi | editar arquivos
:w | salvar
:q | sair
:q! | Saída Forçada
:wq | salva e sai
:x | salva e sai:
d | deleta
u | undo
p | cola na linha debaixo
o | abrir modo de edição na linha debaixo
i | abrir modo de edição na mesma linha
ESC | sair do modo `-- INSERT --`
Colar | `Shift+Insert`
Copiar | `CTRL+Insert`o

excludepkgs=zabbix*

rpm -Uvh https://repo.zabbix.com/zabbix/6.0/rhel/7/x86_64/zabbix-release-6.0-4.el7.noarch.rpm
