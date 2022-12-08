### ASP.NET

Circuito que o ASP.NET percorre quando se faz uma chamada para uma aplicação, versão ASP.NET MVC5:

Pipeline

![image](https://user-images.githubusercontent.com/108991648/203792621-6c1f9619-4ae0-427b-b677-cd069033afb7.png)

## ASP.NET MVC5 x ASP.NET CORE

MVC5 | Core
:-:|:-:
Mais antigo |  Inovação 
. | Compatível com as tecnologias atuais()
. | Open Source (comunidade colaborando)
Roda apenas em Windows | Roda em multiplataformas
WEB HOST: (ISS) | WEB HOST: ISS, CustomHost e SelfHost (não depende do servidor)

Para novos projetos deve-se dar preferência ao ASP.NET Core, que é a tecnologia mais atual.

> Conceito [OWIN](http://owin.org/spec/spec/owin-1.0.0.html): Open Web Interface for .NET

Especificação de como abrir a comunicação entre a aplicação e o servidor

Onde posso utilizar?

![image](https://user-images.githubusercontent.com/108991648/203804895-c0927785-8f9d-4bb3-a132-5b6c6691fd63.png)

## Padrão MVC

> Model, View, Controller

* Padrão arquitetural
* Separação de responsabilidades

No exemplo: `http://www.site.com.br/clientes/editar/1`, para editarmos este link utilizamos:

* Controller: executa o processo de concexão com o banco de dados para consultar

* Model: popula, vai mesclar dados da Model com o HTML que formará a VIEW.

* View: exibe através de componentes em HTML,

Quem está controlando todo o fluxo é o *Controller*, ele que vai receber a chamada da action, conectar ao banco, realizar a leitura, popular o modelo (junto com o model) e em seguida, junto com a view, exibir os dados na tela.

## HTTP - Verbos básicos

- | Descrição
-|-
GET | Pedindo, fazendo um (request) de uma informação para o servidor. Feito através de uma URL. Ex: clicar em um link.
POST | Enviar informações ao servidor. Ex: formulários (Também é um request)
PUT | Enviar informações ao servidor. Ex: atualizar informações existentes.
DELETE | Solicitar a exclusao de uma informação no servidor através da URL indicada.

## HTTP - Status Code

Code | Descrição
-|-
200 | OK e pode retornar informação
204 | Apenas OK
400 | Bad request
401 | Não autorizado
403 | Acesso negado
404 | Não encontrado
500 | Família 500, erro interno no servidor


________________________________


### Em Visual Code 2022:

Criar projeto com ASP.NET WEB Application (.NET Framework) e não em Core.

Para problemas de visualização do Framework, Vídeo no youtube onde me ajudou a solucionar, fazendo com que ele aparecesse: https://www.youtube.com/watch?v=ANfMct1qFcs&t=192s

- Em Componentes individuais, adicionar:
1) Pacote de direcionamento do .NET Frameworl 4.8
2) Modelos de projeto e item do .NET Framework
3) E, Modificar. Fará o dowload dos itens

E voalá!! 🤩

![image](https://user-images.githubusercontent.com/108991648/204820503-aece8310-78cd-493a-9627-e80647107c33.png)


* MVC

![image](https://user-images.githubusercontent.com/108991648/204821379-bc38ad4b-9f65-46be-b961-41e1a35721bb.png)

O que temos neste projeto?

Item | Descrição
-|-
Solução | 
TesteMVC | Arquivo do projeto
Connected Services | Conectar Serviços Externos
Properties | Propriedades do Projeto
Referências | Referências de dependências
App_Data | Onde será guardado os dados locais
App_Start | Como "startar" as informações
Contetn | Arquivos de FrontEnd: arquivos de CSS e Mapeamento de CSS
Controllers | 
Fonts |
Models | 
Script | 
Views | Páginas de HTML
Favicon | Arquivo de ícone
Global | Setup da configuração da aplicação global
Packages | Arquivos de pacotes da máquina
Web | Arquivo de texto de configuração da Aplicação

### Rodar a Aplicação

![image](https://user-images.githubusercontent.com/108991648/204825446-aaf3ae60-c51e-47df-96e9-71e5a3e9cd68.png)


![image](https://user-images.githubusercontent.com/108991648/204825972-09a3afe0-fb3d-4718-988a-225c3e15a94f.png)

![image](https://user-images.githubusercontent.com/108991648/204826062-df9325ee-fd6e-4f89-9fa7-fa5995da5701.png)

![image](https://user-images.githubusercontent.com/108991648/204826143-ce337855-070b-432e-9727-96e651f599bf.png)



_________________________________

### O básico da WEB

- HTML
- CSS
- JavaScript
- [Bootstrap](http://getbootstrap.com/): Framework de HTML, CSS e JavaScript. Desenvolvimento ágil de projetos responsivos
- [jQuery](http://jquery.com/): Biblioteca JavaScript 
- [Modernizr](http://modernizr.com/): Biblioteca JavaScript que detecta disponibilidade de novas características de HTML e CSS no browser

________________

### MVC Controller

- [x] **HomeController** nome da controller, após criar o nome é necessário incluir `Controler` = HomeController
- [x] **Controller** toda controller herda da classe controller
- [x] **ActionResult** métodos que retornam algo da Controller
- [x] **Diretório Views**
    - Home: Pasta com o nome da Controller
    - Possui 5 principais pastas, que são chamadas no `ActionResults`:
        - Links da aplicação web:About, Contact e Index
        - _ViewStart e Web
           
![image](https://user-images.githubusercontent.com/108991648/205986904-b008817b-70b4-4026-9295-120bd981c900.png)


- [x] Nome da Controller = Home
- [x] Nome da Action no método da controller = About(Sobre)

![image](https://user-images.githubusercontent.com/108991648/205988749-02d414ce-758d-4924-99e9-fd938e2de66b.png)


_____________

### Controller - Action Results

Nome | Comportamento | Tipo Produzido 
-|-|-
ContentResult | Retorna uma String | Content = conteúdo
EmptyResult | Sem resposta | Não produz nada
FileContentResult<br> FilePathResult <br> FileStreamResult| Retorna o conteúdo de um arquivo | File (array de byts)<br> File (caminho)<br> File (stream)
HttpUnauthorizedResult | Retorna um erro HTTP 403 | Acesso negado
JavaScriptResult | Retorna um script a ser executado | JavaScript (evitar utilizar)
JsonResult | Retorna dados em formato JSON | JSON
RedirectResult | Redireciona a uma nova URL | Redirect = redireciona para outra URL
RedirectToRouteResult | Redireciona para outra Action no mesmo ou em outro Controller | RedirectToRoute <br> RedirectToAction
ViewResult <br> PartialViewResult | Retorna uma View ou uma PartialView | View (mais utilizado) <br> PartialView
ActionResult | Permite qualquer tipo de retorno | View<br>PartialView<br>Content etc.;


```css
public class HomeController : Controller 

    public ActionResult Index()
    {
        return View();
    }

    public ContentResult ContentResult()
    {
        return Content("Olá!");
    }

    public FileContentResult fileContentResult()
        {
            var foto = System.IO.File.ReadAllBytes(Server.MapPath("/content/images/nossos_clientes.png"));
            /*caminho de onde o arquivo está salvo*/

            return File(foto, contentType: "image/png", fileDownloadName: "nossos_cliente.png");
         }
            /*nome de download = capa.png*/    
    

    public HttpUnauthorizedResult HttpUnauthorizedResult()
    {
        return new HttpUnauthorizedResult();
        /*retorna um resultado de não autorizado*/
    }

    public JSonResult JsonResult()
    {
        return Json(data:"teste: 'Teste'", JsonRequestBehavior.AllowGet);
    }
    
    public RedirectResult RedirectResult()
    {
       return new RedirectResult(url:"http://ositequeeuquiser.com.br");
    }

    public RedirectToRouteResult RedirectToRouteResult()
    {
        return RedirectToRouteResult(new
        {
            controller = "Home",
            action = "Index"
        });
    }
```
_______________

### Rotas

Estruturas de navegação: no diretório `App_Start`, arquivo `RouteConfig.cs`, este é um método. Ele é chamado dentro do `Global.asax`, existe um método principal **Aplication_Start** que é chamado assim que a aplicação é inicializada.

Este método é algo obrigatório no MV5, podendo ter mais de um, sendo que a rota mais complexa deve ser inclusa primeiro e a padrão (Default) por último.

```css

public static void RegisterRoutes(RouteCollection routes)
{
    routes.IgnoreRoute(url: "{resource}.axd/{*pathInfo}");

    /*Vai ignorar arquivos .axd*/

    routes.MapRoute(
        name: "Institucional",
        url: "institucional/{controller}/{action}",
        defaults: new { controller = "Teste", action = "IndexTeste"}
    );

    /*rota mais complexa acima e padrão abaixo*/

    routes.MapRoute(
        name: "Default",
        url: "{controller}/{action}/{id}",
        defaults: new { controller = "Home", action = "Index", id - UrlParameter.Optional }
    );
}
```

_________________

### Rotas por atributos

Podemos colocar nome nas controllers, mas antes disso, precisamos configurar o `RouteController.cs` dentro de `App_Start` e incluir **routes.MapMvcAttributeRoutes();**:

```css
public static void RegisterRoutes(RouteCollection routes)
{
    routes.IgnoreRoute(url: "{resource}.axd/{*pathInfo}");

/*para altrar o nome das controllers*/
   routes.MapMvcAttributeRoutes();

   routes.MapRoute(
        name: "Default",
        url: "{controller}/{action}/{id}",
        defaults: new { controller = "Home", action = "Index", id - UrlParameter.Optional }
    );
}
```

Vai ler todas as rotas da controller, vai compilar a uma coleção e adicionar a coleção de rotas do MVC

Em seguida, incluir o novo nome na controller em `HomeController`:

```css

[Route(template: "qualquer-nome")]

        public ActionResult About()
        {
            ViewBag.Message = "MVC5";

            return View();
        }
```

Nome | O que faz?
-|-
[Route(template: "qualquer-nome")] | url nome
[RoutePrefix("testes")] | mantem um prefixo para todos os nomes, inserir antes da public



### Incluir mais abas para a página

Em `Controller` criar os métodos:

```css
 public ContentResult ContentResult()
        {
            return Content("Agradecemos por visitar a nossa página");
        }
```
Para incluir imagens, criar uma pasta para incluir um arquivo. Criada em `Content` um diretório `images`. Em seguida criar a controller:

```css
 [Route(template: "nossos-clientes")]
        public FileContentResult fileContentResult()
        {
            var foto = System.IO.File.ReadAllBytes(Server.MapPath("/content/images/nossos_clientes.png"));

            return File(foto, contentType: "image/png", fileDownloadName: "nossos_cliente.png");
         }
```

Em `Views`, `Shared`, `_Layout.cshtml`, incluir o link:

```css
<li>@Html.ActionLink("Agradecimentos", "ContentResult", "Home")</li>
<li>@Html.ActionLink("Nossos Clientes", "FileContentResult", "Home")</li>

```
- [x] **Agradecimentos** e **Nossos Clientes** nome da aba do site
- [x] **ContentResult** e ** nome do método
- [x] **Home** da página inicial

Em seguida, alterar o [nome da rota](https://github.com/PamelaRondina/step-by-step/tree/main/asp.net_MVC#rotas-por-atributos) para o que desejar










