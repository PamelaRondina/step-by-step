# Zabbix

> Serviços importantes não podem falhar!!

- Solução Open Source para monitoramento da insfraestrututa de TI

[Documentação Zabbix](https://www.zabbix.com/br/manuals)

____________

## Baixar Virtualbox

> Software Open Source para instalar sistemas operacionais virtualmente

- [x] [VirtualBox](https://www.virtualbox.org/

** Criar máquina **

______________

## Baixar Ubuntu

[Ubuntu](https://ubuntu.com/download)

Versão do ubuntu para mapear dependências do sistema operacional como drives de disco, de rede e etc


![image](https://user-images.githubusercontent.com/108991648/216650258-d7dd8fd7-5b70-43a2-930a-8b37b650c5f7.png)

Atribuições da máquina virtual (arrancar a memória da máquina local para a máquina virtual)

![image](https://user-images.githubusercontent.com/108991648/216651712-82367498-5e7e-48b6-85de-cf47eb7a3752.png)

> Ao criar uma máquina devemos saber o que rodará para definirmos anterioemente a quantidade de recurso a ser utilizado.

> Para cada software devemos identificar na documentação os requisitos mínimos para que rode em um ambiente de dev, homolog (teste - staging) e prod (final)

## Requisitos do Zabbix

![image](https://user-images.githubusercontent.com/108991648/216656807-81d9e1b8-9432-4988-8efc-cbf0a614405b.png)


______________

## Máquina AWS

- EC2 > Instância > Executar instâncias
- 

______________
## MobaXterm 

### Criar SSH via Session

> SSH é o protocolo de acesso remoto ao sistema Linux

- Session
- Remote Host = Endereço IP do EC2
- Specify username = nome de usuário | 
    - Amazon Linux = ec2-user
- Porta padrão 22 

- Advanced SSH settings - adicionar chave criada no EC2 no `Use private key`
    - arquivo .pem
- Bookmark setting - session name (alterar o nome)

**SSH - acessar máquina**

- ssh (comando)
- -i (parâmetro - especificar o caminho da chave privada de acesso)
- caminho PEM
- user@IP

```mobaxterm
ssh -i /mnt/c/Users/pamela/Downloads/zabbix.pem ec2-user@IP '
```

**Copiar e colar na ModaXterm**

- Copiar `CTRL+Insert`
- Colar `Shift+Insert`

**Erro de acesso em relação ao Windows**

`ls /mnt/c/Users/pamela/Downloads/zabbix.pem`

___________________

## Baixar o Zabbix - Via Pacotes de Distribuição







Item | Descrição
-|-
Gui | Tela gráfica (sem GUI = tela preta)
Headless | Sem tela gráfica, não possui visualização
Benchmark | Métricas de mercado
Ambiente staging | Ambiente de Homologação
métrica | Item + trigger + graph
Item | Memória
Trigger | Gatilho
Graph | Gráfico