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

Em seguida, alterar o [nome da rota](https://github.com/PamelaRondina/step-by-step/tree/main/asp.net_MVC#rotas-por-atributos).

_______________

### Passagem de parâmetros na controller

Em `App_Start` e `RouteConfig`, a configuração da rota está para chamar o ID

*Rotas SEM atributos:*

Chamar o parâmetro:
- [x] `parametros/index?teste/1`
- [x] `parametros/index?id=1&id2=5` **& concatena**

```css
public class ParametrosController : Controller
{
    public ActionResult Index(int id, int id2)
    {
        return View();
    }
}

```
*Rotas COM atributos:*

> [Tipos de atributos](https://devblogs.microsoft.com/dotnet/attribute-routing-in-asp-net-mvc-5/#:~:text=MVC%205%20supports%20a%20new,routing%2C%20is%20still%20fully%20supported.) site Microsoft.

> {id:int} indica um parâmetro

> Para fazer um teste criar itens nos diretórios: Controllers, View e fazer um Index para o teste, por exemplo, Parametros!!

```css
[RoutePrefix("parametros")]

    public class ParametrosController : Controller
    {
        [Route(template:"{id2:int}/{texto:maxlength(50)}")]
        public ActionResult IndexParametros(int id2, string texto)
        {
            return View();
        }
```

Chamar o parâmetro:
- [x] `parametros/1/legal`

___________

### Trabalhando com Modelos / Models

> Representada por uma tela que é a View

- [x] A pasta Model por padrão vem vazia

Para iniciar, vamos adicionar uma nova classe neste diretório e incluir suas prioridades.

```css
    public class Clientes
    {
        public int Id { get; set; }
    
        public string Nome { get; set; }

        public string CNPJ { get; set; }

        public string ContatoFinanceiro { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }

        public DateTime DataMatricula { get; set; }

        public bool Ativo { get; set; }
       

    }
```

___________________

### Data Annotations

> São Aplicadas na Model, auxilia na validação

```css
 public class Clientes
    {
        public int Id { get; set; }

        /*[Required(ErrorMessage = existem outros formatos de erros")]*/
        /*DisplayName = Nome do que aparece na View*/
        /*EmailAdress = estrutura de e-mail*/

        [DisplayName("Nome da Empresa")]
        [Required(ErrorMessage = "Por favor, informe o {0}.")]
        public string NomeEmpresa { get; set; }

        [Required(ErrorMessage = "Por favor, informe o {0}.")]
        public string CNPJ { get; set; }

        [DisplayName("Contato do Financeiro")]
        [Required(ErrorMessage = "Por favor, informe o {0}.")]
        public string NomeContatoFinanceiro { get; set; }

        [DisplayName("E-mail")]
        [Required(ErrorMessage = "Por favor, informe o {0}.")]
        [EmailAddress(ErrorMessage = "E-mail em formato inválido" )]
        public string Email { get; set; }


        [Required(ErrorMessage = "Por favor, informe o {0}.")]
        public string Telefone { get; set; }


        public DateTime DataMatricula { get; set; }

        public bool Ativo { get; set; }
```

Outros modelos

```css
[Required(ErrosMessage = "O campo {}0 é obrigatório")]
public string Senha { get; set; }

[Compare(otherProperty: "Senha", ErrorMessage = "As senhas informadas não conferem")]
[Required(ErrorMessage = "O campo {0} é obrigatório")]
public string SenhaConfirmacao { get; set; }
```

___________________

### Validação das Models

A validação é realizada na Controller

> Moto Bidding, transformação de um dado de formulário em modelo

A validação na Controller é feita através do ModelState, e ele valida a Model no momento que é passada no parâmetro.

- [x] Criar uma novaController;
- [x] Verificar se entrou `using TesteMVC5.Models;`


```css
   public class ClienteController : Controller
    {
          /*Simular a entrada de um cliente*/

        [Route(template:"cliente")]
        public ActionResult Novo(Cliente cliente)
         /*Este formato não é utilizado no dia a dia*/

        {
            cliente = new Cliente
            {
                Id = 1,
                NomeEmpresa = "Advocacia Jurídica",
                CNPJ = "00000582000189",
                NomeContatoFinanceiro = "Kelly Cristina",
                Email = "kelly.cristina@jurídica.adv.br",
                Telefone = "11958250000",
                DataMatricula = DateTime.Now,
                Ativo = true
            };

            /*passar um dado para outra Action*/
            return RedirectToAction("Index", cliente);
        }

        public ActionResult Index(Cliente cliente)
        {
            if (!ModelState.IsValid) return View(cliente);

            return View(cliente);
        }
    }
```

- [x] Inserir breakpoint (sem ele dá erro!);
- [x] Rodar a aplicação
- [x] Ativar os parâmetros (em amarelo) para que os dados sejam encaminhados para as outras etapas

![image](https://user-images.githubusercontent.com/108991648/206721452-02465470-d2c2-4cd9-a20f-c864d21728b2.png)

**Explorar o ModelState**

- Clicar na **ModelState** em `QuickWatch`;

Quando existente, nesta janela veremos os erros dos parâmetros. Neste modelo não consta!

![image](https://user-images.githubusercontent.com/108991648/206722797-3f03ddc3-58cd-481a-9872-905c779d1505.png)

____________________________

### Views e Razor

O MVC da Microsoft possui o Razor e está ligado a Views

- [x] Em `Views` / `Shared` / `_Layout.cshtml` algumas estrutura do Razor's:

```html
    <title>@ViewBag.Title - Meu Aplicativo ASP.NET</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
```

Detalhes Razor:

- [x] Para ser Razor necessita utilizar o ` @ `
- [x] Dentro das ` {  } ` é o seu contexto, sendo código C#

_____________

### Trabalhando com HTmlHelpers 

Criar uma nova pasta no diretório da Views, com o nome da Controller e criar um arquivo `Nome.cshtml`

- [x] adicionar a model: `@model NomeDoProjeto.Models.NomeModel`

> Apenas 1 model por View

[**Editor Extensions**](https://learn.microsoft.com/pt-br/dotnet/api/system.web.mvc.html.editorextensions.editorfor?view=aspnet-mvc-5.2) ou [**Editor List**](https://docs.devexpress.com/AspNetMvc/12003/components/data-editors-extensions/editor-list)

- [x] `@using (Html.BeginForm())` = Criar um formulário
- [x] `EditorFor` = Lacuna
- [x] `CheckBoxFor` = Caixinha para ticar
- [x] `text-danger` = Texto estará em vermelho
- [x] `ValidationMessageFor` = Valida se o campo está preenchido ou não

**Controller**
```css
 public class ClienteController : Controller
    {
        [HttpGet]
        [Route(template: "novo-cliente")]

        public ActionResult NovoCliente()
        {
            return View();
        }

        [HttpPost]
        [Route(template: "novo-cliente")]
        public ActionResult NovoCliente(Cliente cliente)
        {
            if (!ModelState.IsValid) return View(cliente);

            return View(cliente);

        }
    }

}
```

**Model**

```css
@model TesteMVC5.Models.Cliente

<h2>Novo Cliente</h2>

@*Criando um formulário*@
@using (Html.BeginForm())
{
    <div class="form-horizontal">
        <h4>Informe os dados do Cliente:</h4>
        <hr />

        @* Para mostrar os erros de validação = false *@
        @Html.ValidationSummary(excludePropertyErrors:true, message:"", htmlAttributes: new {  @class = "text-danger"})

        <div class="form-group">
            @* Label para uma Model específia *@
            @Html.LabelFor(model => model.NomeEmpresa, htmlAttributes: new { @class = "control-label col-md-2" })
            <div class="col-md-10">
                @* EditoFor = caixa de texto *@
                @Html.EditorFor(model => model.NomeEmpresa, additionalViewData: new { htmlAttributes = new { @class = "form-control" } })
                @Html.ValidationMessageFor(model => model.NomeEmpresa, validationMessage: "", htmlAttributes: new { @class = "text-danger" })
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(model => model.CNPJ, htmlAttributes: new { @class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(model => model.CNPJ, additionalViewData: new { htmlAttributes = new { @class = "form-control" } })
                @Html.ValidationMessageFor(model => model.CNPJ, validationMessage: "", htmlAttributes: new { @class = "text-danger" } )
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(model => model.NomeContatoFinanceiro, htmlAttributes: new { @class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(model => model.NomeContatoFinanceiro, additionalViewData: new { htmlAttributes = new { @class = "form-control" } })
                @Html.ValidationMessageFor(model => model.NomeContatoFinanceiro , validationMessage: "", htmlAttributes: new { @class = "text-danger" } )
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(model => model.Email, htmlAttributes: new { @class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(model => model.Email, additionalViewData: new { htmlAttributes = new { @class = "form-control" } })
                @Html.ValidationMessageFor(model => model.Email, validationMessage: "", htmlAttributes: new { @class = "text-danger" })
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(model => model.Telefone, htmlAttributes: new { @class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(model => model.Telefone, additionalViewData: new { htmlAttributes = new { @class = "form-control" } })
                @Html.ValidationMessageFor(model => model.Telefone, validationMessage: "", htmlAttributes: new { @class = "text-danger" })
            </div>
        </div>
  

        <div class="form-group">
            @Html.LabelFor(model => model.Ativo, htmlAttributes: new { @class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.CheckBoxFor(model => model.Ativo, htmlAttributes: new { @class = "form-control" })
            </div>
        </div>


        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value="Enviar" class="btn btn-default" />
            </div>
        </div>
    </div>
}
```

**Resultado**
![image](https://user-images.githubusercontent.com/108991648/206790460-f9596fdb-b9dc-4acf-9125-322e05e5b9cd.png)

_________________________________

### Jquery

Outro método para auxiliar na validação: FrontEnd - JavaScript. Neste formato as informações não serão na Controller, evitando desgastes para o Banco de Dados.

Sendo adicionada a validação através da @section:

- Tudo será redenrizado em `_Layout` na seção de Script
- Ordem da validação, diretório `Script`:
    - jquery;
    - jquery.validate;
    - jquery.unobtrusive.

```css
@* validação por JavaScript *@
@section Scripts
{
    @Scripts.Render("~/bundles/jqueryval")
}
```

__________________________________________

### Rotas Partial View

No formulário, para retornar para a página inicial.

Criar uma nova View, porém, neste caso será uma PartialView: 
> Ao criar uma View como PartialView utilizar o **_** na 
frente.

Criar _PartialView:
```css
@model TesteMVC5.Models.Cliente

<div class="form-group">
    <div class="col-md-offset-2 col-md-10">
        <input type="submit" value="Enviar" class="btn btn-defalut" />
        <a href="@Url.Action("Index", "Home")" class="btn btn-info">Voltar</a>
    </div>
</div>
```

No arquivo da Model, Eliminar campo:
```css   <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value="Enviar" class="btn btn-default" />
            </div>
        </div>
```

E, Incluir:

```css
   @Html.Partial("_BotaoRetorno")  
```

Para que a PartialView fique disponível para todos as outrs Views devemos arrastá-la para o diretório `Shared`

__________________________________

### Conceito de CSRF

> Falsificação de Solicitação entre Sites

Para isto precisamos incluir:

**Na View**

```css
@using (Html.BeginForm())
{
    @Html.AntiForgeryToken()
```

**na Controller**

```css
  [HttpPost]
        [ValidateAntiForgeryToken]
        [Route(template: "novo-cliente")]
```

_________________________

### Gerenciamento de Scripts

**Bundling**
Processo de transformar diversos arquivos do mesmo tipo em um.

**Minification**
Reduzir o tamanho dos arquivos através da remoção dos espaços em branco, comentários, quebras de linhas e substituições de variáveis.

_____________

### Implementando Bundling e Minification

Em `_Layout` temos:

- [x] Bundling do Css: @Styles.Render("~/Content/css")
- [x] Bundling do JavaScipt: @Scripts.Render("~/bundles/modernizr")

> Dica! Em `_Layout` deixar todo o JavaScrip no final da aplicação

As configurações desta seção estão em `App_Start` `BundleConfig.cs`

* criar teste.js
* criar bundle

```css
            bundles.Add(new ScriptBundle("~/bundles/testes").Include(
                        "~/Scripts/teste1.js", 
                        "~/Scripts/teste2.js" ));
```
* Layout embaixo, incluir o bundle

   @Scripts.Render("~/bundles/testes")

* E, abaixo do public:

```css
 public static void RegisterBundles(BundleCollection bundles)
        {
            BundleTable.EnableOptimizations = true;
```

*No `Index` da `Home`, incluir no final:

```css

@section scripts
{
    <script>
        teste1("Teste 1");
        teste2("Teste 2");
    </script>
}    
```

Para rodar em produção, podemos desabilitar o Bundle, em `Web.config`, alterar para `false` (último arquivo)

```css
  <compilation debug="true" targetFramework="4.6.1" />
```

_________________

### Trabalhando com o Entity Framework

Criar um Banco de Dados a partir de um Framework 6

**Migrations**

Automatizam os processos de atualização de BD

**Comandos**
* PM > Enable-Migrations

* PM > Update-Database
    * -Force    Forçar uma atualização da qual dados podem ser perdidos
    * -Verbose  Mostrar mais informações 
    * -Script   gerar um Script de migração do banco, não executa.

* PM > Add-Migration
    * Comando que vai adicuinar uma migração, fazer um versionamento do projeto. 
* PM > Get-Migrations
    * Pegar as migrações existentes e faz uma listagem de quais foram aplicadas

    _________________

    ### Configurando o EF na aplicação

Utilizar - SQL Server

Configurar o Entity Framework, no Nome do Projeto, com o botão direito mouse, procurar `Gerenciar pacotes de NUGET`, e buscar a versão `EntityFrameowrk`

> Caso não apareça, ir em pesquisar `Console do Gerenciador de Pacotes` ou `Package Manager Console`

- [x] Na linha de comandos, digitar: `PM> Install-Package EntityFramework`

> Para visualizar a versão do EF: `packages.config` e verificar `EntityFramework`

- [x] Adicionar nova pasta `Data` e uma classe `AppDbContext.cs`, que será o contexto do EF.
- [x] `AppDbContext` adicionar `sing System.Data.Entity;`
- [x] Instalar [SQL Servar Data Tools](https://learn.microsoft.com/pt-br/sql/ssdt/download-sql-server-data-tools-ssdt?view=sql-server-ver15)

```css
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using TesteMVC5.Models;

namespace TesteMVC5.Data
{
    public class AppDbContext : DbContext
    {
        //objetivo do DbContext será mapear as classes para que as tabelas se tornem BD
        public AppDbContext() : base("DefaultConnection")
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}
```

Em `Web.config` vamos incluir:

```css
/*Abre a seção*/
<connectionStrings>

/*DefaultConnection (mesmo nome que está no construtor do contexto)*/
		<add name="DefaultConnection" 

/*connection = vai se conectar no banco de dados*/
        connectionString="Data Source=(localdb)
        
/*Instância do nome do BD da máquina*/
        \MSSQLLocalDB;AttachDbFilename=|
/*DataDirectory = mapeando a pasta App_Data*/
        DataDirectory|
        
/*Nome do arquivo do BD*/
        \AppTesteMvc5.mdf;
        
/*Nome da tabela do BD*/         
        Initial Catalog=AppTesteMvc5;
        
/*O usuário da própria máquina*/        
        Integrated Security=True" 
        
/*Trabalhar com SQL Server*/
        providerName="System.Data.SqlClient" />

/*Fecha a seção*/
</connectionStrings>
```
Em Exibir `SQL Server Object Explorer`, podemos liberar o acesso ao BD pelo VS

Abrir `Console do Gerenciador de Pacotes`:
- [x] Rodar, `PM> enable-migrations`
- [x] Será criado o diretório `Migratiosn` com o arquivo `Configuration.cs`, faremos alterações nele:

```css
using TesteMVC5.Data;

namespace TesteMVC5.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<AppDbContext>
    {
        public Configuration()
        {
            // será alterado para true para conseguirmos aplicar as migrations
            AutomaticMigrationsEnabled = true;
        }

        //Seed = serve para incluir informações no BD no momento da criação
        protected override void Seed(AppDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
```

Em `Console de Gerenciador de Pacotes` para criar o BD e as tabelas:
- [x] PM> update-database -verbose

> Fechar o Banco de Dados do VS, abrir novamente e dar refresh (vai ajudar com que as tabelas apareçam!!)

**Criar Script par ao BD**
Neste ponto, quem cria o BD é o usuários

- [x] PM> update-database -verbose -Script

**Remover Convensão Plural do EF**

Neste formato o programa não incluirá o "S" nas tabelas,
Para isso, incluiremis o `modelBuilder.Entity<Cliente>`

Em `Data` `AppDbContext`

```css
        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
```

Deletamos o BD,  bloqueamos a convensão, alteramos a Model "Cliente", e criamos um novo BD.

```css     
        [MaxLength(100, ErrorMessage = "No máximo 100 caracteres!")]
```

____________________________

### *****************

Em `ClienteController`, vai salvar os dados no BD. 

```css
namespace TesteMVC5.Controllers
{
    public class ClienteController : Controller
    {
        private readonly AppDbContext context = new AppDbContext();

        [HttpGet]
        [Route(template: "novo-cliente")]

        public ActionResult NovoCliente()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route(template: "novo-cliente")]
        public ActionResult NovoCliente(Cliente cliente)
        {
            if (!ModelState.IsValid) return View(cliente);

             cliente.DataMatricula = DateTime.Now;

            context.Clientes.Add(cliente);
            context.SaveChanges();

            return View(cliente);

        }
    }

}
```

Ainda na `Controller`, por o braekpoint e iniciar a aplicação.

![image](https://user-images.githubusercontent.com/108991648/206860605-d97cf643-02be-40e0-b994-a73461d6be86.png)



Preencher os dados do formulário e enviar.


Breakpoint??
























