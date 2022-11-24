### ASP.NET

Circuito que o ASP.NET percorre quando se faz uma chamada para uma aplicação, versão ASP.NET MVC5:

Pipeline

![image](https://user-images.githubusercontent.com/108991648/203792621-6c1f9619-4ae0-427b-b677-cd069033afb7.png)

## ASP.NET MVC5 x ASP.NET CORE

MVC5 | Core
:-:|:-:
.|  Inovação 
. | Compatível com as tecnologias atuais()
. | Open Source (comunidade colaborando)
Roda apenas em Windows | Roda em multiplataformas
WEB HOST: (ISS) | WEB HOST: ISS, CustomHost e SelfHost (não depende do servidor)


> Conceito [OWIN](http://owin.org/spec/spec/owin-1.0.0.html): Open Web Interface for .NET

Especificação de como abrir a comunicação entre a aplicação e o servidor

Onde posso utilizar?

![image](https://user-images.githubusercontent.com/108991648/203804895-c0927785-8f9d-4bb3-a132-5b6c6691fd63.png)

## Padrão MVC

> Model, View, Controller

* Padrão arquitetural
* Separação de responsabilidades

No exemplo: http://www.site.com.br/clientes/editar/1, para editarmos este link utilizamos:

* Controller: executa o processo de concexão com o banco de dados para consultar

* Model: popula, vai mesclar dados da Model com o HTML que formará a VIEW.

popular o cliente através da Model

* View: exibe através de componentes em HTML,

Quem está controlando todo o fluxo é o *Controller*, ele que vai receber a chamada da action, conectar ao banco, realizar a leitura, popular o modelo (junto com o model) e em seguida, junto com a view, exibir os dados na tela.

## HTTP - Verbos básicos

- | Descrição
-|-
GET | 
POST |
PUT |
DELETE | 


Métodos e Views que vão listar, criar, editar e excluir (CRUD)
















