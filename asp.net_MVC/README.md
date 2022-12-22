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
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();

            modelBuilder.Entity<Cliente>().ToTble("Clientes");          

            base.OnModelCreating(modelBuilder);
```

Deletamos o BD,  bloqueamos a convensão, alteramos a Model "Cliente", e criamos um novo BD.

```css     
        [MaxLength(100, ErrorMessage = "No máximo 100 caracteres!")]
```

____________________________

### Incluindo dados no BD via formulário 

- [x] Em `ClienteController`, vai salvar os dados no BD. 

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

- [x] Ainda na `Controller`, **braekpoint**

![image](https://user-images.githubusercontent.com/108991648/206860605-d97cf643-02be-40e0-b994-a73461d6be86.png)

- [x] Preencher os dados do formulário e enviar;
- [x] Os dados estarão no View da ModelState;
- [x] Setar `DataMatricula`
- [x] Setar `context.Add`
- [x] Em `Context/Clientes/VisualizaçõesdeResultados`veremos erro de thread para rodar
- [x] Vamos forçar a thread para rodar

![image](https://user-images.githubusercontent.com/108991648/206860979-a2955d32-aed9-4bb5-ac5d-b6f7c0fc54f8.png)
Breakpoint??

- [x] Setar `SaveChange`
- [x] Em SQL, clicar na tabela e abrir `New Data`, abrirá a tabela com os dados do formulário preenchida

Voalá! Dados inseridos na tabela do BD.

![image](https://user-images.githubusercontent.com/108991648/206863280-d850925f-40bf-4230-8515-f9fa85572bd0.png)
_____________________

### Criando um novo Projeto

- [x] Criar um novo projeto no VS
- [x] Blank Solution ou Solução em branco
- [x] Escolher o local e o nome e salvar
- [x] Dentro da Solução, adicionar um novo projeto
- [x] Asp.Net Framework, após o nome, optar por MVC
- [x] Optar por autenticação> contas individuais

> Neste formato foi adicionado mais opções de Models, Controller e Views

NOVO: `Startup.cs` vai trata a autenticação da aplicação



# Editar EdentifyConfig!

- [x] `Web.config` `name` `Catalog`  alterar nome da aplicação e `DataDirectory`, sendo nome do site e nome da aplicação
- [x] `AcountController` trata da criação de um login/usuário
- [x] `ManagerController` gestão do usuário já logado

- [x] `Console de Gerenciador de Pacotes` 
    - habilitar `PM> enable-migrations`
        - `Configuration.cs` alterar `AutomaticMigrationsEnabled = true;` para utilizar as migrations automáticas
    - habilitar o BD `PM> update-database`
<br>

    Foi gerado as tabelas do Edentify:
    - Roles: papéis que posso assumir dentro de um usuário;
    - Claims: permissões do usuário;
    - Logins: logins de redes sociais Edentify;
    - UserRoles: quais Roles estão associadas aos usuários
    - Users: Usuários

    Rodar a aplicação e fazer um registro.

pamela@email.com
Teste@123

Na tabela `dbo.AspNetUsers` terá dados cadastrados

![image](https://user-images.githubusercontent.com/108991648/206872866-5f38b9bf-9c70-459e-8c18-0bf53e0d4ff1.png)

__________________

### Conceito Scaffolding

> Automatizar tarefas simples, CRUD

- [x] Criar uma Model classe `Cliente`
- [x] Incluir as propriedades
<br>

**Criar CRUD em conceito Scaffolding**

- [x] Nos menus do programa `Compilação` e `Compilar Solução` ou `Build/Build Solution`
- [x] Em `Controller` / `Add` / `Controlador`
- [x] Escolher `Entity Framework`

![image](https://user-images.githubusercontent.com/108991648/206865651-84a2abab-d272-4ad4-ad32-8d1eb7ad7ec5.png)

**Compreendendo a Controller criada**

```css
// instância do contexto
        private ApplicationDbContext db = new ApplicationDbContext();

// GET: Clientes (retornar uma lista dos Clientes)
        public async Task<ActionResult> Index()
        {            return View(await db.Clientes.ToListAsync());        }

// GET: Clientes/Details/5 (com base no ID)
        public async Task<ActionResult> Details(int? id)
        {            if (id == null)            {
//caso o ID seja nulo retorna BadRequest
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);            }
            Cliente cliente = await db.Clientes.FindAsync(id);
            if (cliente == null)            {

//caso não seja encontrado retonar NotFound
                return HttpNotFound();            }

//se sim, retorna na View
            return View(cliente);        }

// GET: Clientes/Create (retorna uma View de criação)
        public ActionResult Create()        {
            return View();        }

// POST: Clientes/Create 
        [HttpPost]
        [ValidateAntiForgeryToken]

//receber de volta
        public async Task<ActionResult> Create([Bind(Include = "Id,NomeEmpresa,CNPJ,NomeContatoFinanceiro,Email,Telefone,DataMatricula,Ativo")] Cliente cliente)        {            if (ModelState.IsValid)            { 
//vai adicionar no contexto
            db.Clientes.Add(cliente);
//e salvar
            await db.SaveChangesAsync();
// retorna para Index de Clientes
            return RedirectToAction("Index");            }

//tendo algum problema, retorna para a View
            return View(cliente);        }

// GET: Clientes/Edit/5
// vai puxar um ID específico 
        public async Task<ActionResult> Edit(int? id)        {
//caso não encontre, retorna um BadRequest   
            if (id == null)
            {return new HttpStatusCodeResult(HttpStatusCode.BadRequest);}

//caso não exista, retorna um NotFound
            Cliente cliente = await db.Clientes.FindAsync(id);
            if (cliente == null)            {
                return HttpNotFound();            }
//caso exista, retorna a View para poder editar e submeter na próxima etapa
            return View(cliente);        }

// POST: Clientes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,NomeEmpresa,CNPJ,NomeContatoFinanceiro,Email,Telefone,DataMatricula,Ativo")] Cliente cliente)        {           
            {
//se for válido, será modificado no Entry
                db.Entry(cliente).State = EntityState.Modified;
//será salvo
                await db.SaveChangesAsync();
                return RedirectToAction("Index");            }
            return View(cliente);        }

// GET: Clientes/Delete/5
// pelo ID tenterá encotrar o Cliente
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
//caso não encontre, retorna um BadRequest   
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);            }
            Cliente cliente = await db.Clientes.FindAsync(id);
            if (cliente == null)
            {  
//caso não exista, retorna um NotFound
                return HttpNotFound();            }
//caso exista, retorna a Viewo Delete POST
            return View(cliente);        }

// POST: Clientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
//o Cliente será remivido
            Cliente cliente = await db.Clientes.FindAsync(id);
            db.Clientes.Remove(cliente);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");        }

        protected override void Dispose(bool disposing)
        {            if (disposing)            {
                db.Dispose();            }
            base.Dispose(disposing);        }    }}
```

- [x] Clicar `ApplicationDbContext();` do início
- [x] Inserir `DBset` (verificar se precisa*) o `override`

```css
  public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<WebAppAccountLaw.Models.Cliente> Clientes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();

            modelBuilder.Entity<Cliente>().ToTable("Clientes");          

            base.OnModelCreating(modelBuilder);
```

- - [x] Nos menus do programa `Compilação` e `Compilar Solução` ou `Build/Build Solution`
- [x] Fazer update do BD `update-database -Verbose`

- [x] No BD teremos a tabela `dbo.Clientes` criada
- [x] E nas soluções, no diretório `Views` teremos os arquivos de: Create, Delete, Details, Edit, Index

* Rodar a aplicação e testar os dados do formulário.
_________________________

### Customizar a implementação padrão

- [x] Em `App_Start` `RouteConfig` vamos mapear as rotas

```css
private readonly ApplicationDbContext db = new ApplicationDbContext();

   routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            routes.MapRoute
```

- [x] Na `ControllerCliente`:

- Alterar

```css
     [HttpGet]
        [Route(template:"listar-clientes") ]
       
        public async Task<ActionResult> Index()
        {
            return View(await db.Clientes.ToListAsync());
        }
```

- Alterar
- Deletar o ? e ID Null porque temos o ID int

```css
[HttpGet]
        [Route(template: "cliente/detalhe/{id:int}")]
        
        public async Task<ActionResult> Details(int id)
        {        
            var cliente = await db.Clientes.FindAsync(id);

            if (cliente == null)
            {
                //caso não seja encontrado retonar NotFound
                return HttpNotFound();
            }
            
            return View(cliente);
        }
```

- Passar Clientes para var
```css
var cliente = await db.Clientes.FindAsync(id
```

- Alterar
```css
 [HttpGet]
        [Route(template: "novo-cliente")]
        public ActionResult Create()
        {
            return View();
        }
```

- Alterar
```css
[HttpPost]
        [Route(template: "novo-cliente")]
        [ValidateAntiForgeryToken]
```

- Alterar
```css
[HttpGet]
        [Route(template: "editar-cliente/{id:int}")]
       
        public async Task<ActionResult> Edit(int id)
        {
        var cliente = await db.Clientes.FindAsync(id);
```

- Alterar

```css
[HttpPost]
        [Route(template:"editar-cliente/{id:int}")]
        [ValidateAntiForgeryToken]
```

- Alterar

```css
[HttpGet]
        [Route(template: "excluir-cliente{id:int")]
        // pelo ID tenterá encotrar o Cliente
        public async Task<ActionResult> Delete(int id)
        {
            var cliente = await db.Clientes.FindAsync(id);
```

- Alterar

```css

        [HttpPost]
        [Route(template: "excluir-cliente/{id:int")]
        [ValidateAntiForgeryToken]
```

- [x]  Em `Views`/ `Shared`/ `_Layout`

- Adicionar
```css
<li>@Html.ActionLink("Página Inicial", "Index", "Home")</li>
<li>@Html.ActionLink("Sobre", "About", "Home")</li>
<li>@Html.ActionLink("Contato", "Contact", "Home")</li>
<li>@Html.ActionLink("Clientes", "Index", "Aluno")</li>
```

________________

### Customizações Visuais

- [X] Em `Views` / `Clientes` / `Index`
- Alterar Título da Página
- Criar um Botão para Incluir Novo Cliente
- Deixar Tabela em formato zebra
- Alterar Links e botão para: editar, alterar e deletar
- Excluir a visualização do DataMatrícula

```css
@{
    ViewBag.Title = "Cadastro de Clientes";
}

<h2>Cadastro de Clientes</h2>

<div>
    <a href="@Url.Action("Create")" class="btn btn-primary">Novo Cliente</a><br><br>


</div>

@* Striped =    formato de tabela zebra
   Hover   =    Saber em qual local estou com o mouse na tabela
    *@

<table class="table table-striped table-hover">
    <tr>
        <th>
            @Html.DisplayNameFor(model => model.NomeEmpresa)
        </th>
        <th>
            @Html.DisplayNameFor(model => model.CNPJ)
        </th>
        <th>
            @Html.DisplayNameFor(model => model.NomeContatoFinanceiro)
        </th>
        <th>
            @Html.DisplayNameFor(model => model.Email)
        </th>
        <th>
            @Html.DisplayNameFor(model => model.Telefone)
        </th>       
        <th>
            @Html.DisplayNameFor(model => model.Ativo)
        </th>
        <th></th>
    </tr>

@foreach (var item in Model) {
    <tr>
        <td>
            @Html.DisplayFor(modelItem => item.NomeEmpresa)
        </td>
        <td>
            @Html.DisplayFor(modelItem => item.CNPJ)
        </td>
        <td>
            @Html.DisplayFor(modelItem => item.NomeContatoFinanceiro)
        </td>
        <td>
            @Html.DisplayFor(modelItem => item.Email)
        </td>
        <td>
            @Html.DisplayFor(modelItem => item.Telefone)
        </td>       
        <td>
            @Html.DisplayFor(modelItem => item.Ativo)
        </td>
        <td>
            <a href="@Url.Action("Edit", controllerName: "Clientes", routeValues: new {id = item.Id})" class="btn btn-warning">Editar</a>
            <a href="@Url.Action("Details", controllerName: "Clientes", routeValues: new { id = item.Id })" class="btn btn-primary">Detalhes</a>
            <a href="@Url.Action("Delete", controllerName: "Clientes", routeValues: new { id = item.Id })" class="btn btn-danger">Deletar</a>
        </td>
    </tr>
 }

</table>
```

- [X] Em `Views` / `Clientes` / `Create`
- Alterar nome da Create
- Deletar DataMatricula 
- Criar Botão Voltar

```css
@model WebAppAccountLaw.Models.Cliente

@{
    ViewBag.Title = "Adicionar novo Cliente";
}

<h2>Adicionar novo Cliente</h2>


@using (Html.BeginForm()) 
{
    @Html.AntiForgeryToken()
    
    <div class="form-horizontal">
        <h4></h4>
```

```css
     <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value="Salvar" class="btn btn-success" />
                @Html.ActionLink("Voltar", actionName:"Index", routeValues: null, htmlAttributes: new {@class = "btn btn-default"})
            </div>
        </div>
    </div>
}


@section Scripts {
    @Scripts.Render("~/bundles/jqueryval")
}
```

- [X] Em `Views` / `Clientes` / `Edit`
- Alterar nome da Create
- Deletar DataMatricula 
- Criar Botão Voltar

```css
@{
    ViewBag.Title = "Editar Cliente";
}

<h2>Editar Cliente</h2>

  <h4>Edição Cliente - @Model.NomeEmpresa</h4>

<div class="col-md-offset-2 col-md-10">
<input type="submit" value="Salvar" class="btn btn-success" />
    @Html.ActionLink("Voltar", actionName: "Index", routeValues: null, htmlAttributes: new { @class = "btn btn-default" })
</div>      
```
- [X] Em `Views` / `Clientes` / `Delete`
- Alterar nome da Create
- Criar Botão Voltar

```css
@{
    ViewBag.Title = "Exclusão de Cliente";
}

<h2>Exclusão de Cliente</h2>

<h3>Tem certeza que deseja deletar?</h3>
<div>
    <h4>Cliente - @Model.NomeEmpresa </h4>

div class="form-group">
    <div class="col-md-offset-2 col-md-10">
        <input type="submit" value="Deletar" class="btn btn-success" />
        @Html.ActionLink("Voltar", actionName: "Index", routeValues: null, htmlAttributes: new { @class = "btn btn-default" })
    </div>
```

 - [X] Em `Views` / `Clientes` / `Details`
- Alterar nome da Create
- Deletar DataMatricula 
- Criar Botão Voltar

```css
ViewBag.Title = "Dados Cadastrais";
}

<h2>Dados Cadastrais</h2>

<div>
    <h4>Cliente - @Model.NomeEmpresa</h4>

<div class="form-group">
    <div class="col-md-offset-2 col-md-10">
        <input type="submit" value="Salvar" class="btn btn-success" />
        @Html.ActionLink("Voltar", actionName: "Index", routeValues: null, htmlAttributes: new { @class = "btn btn-default" })
    </div>
</div>
```

Também Editar:

- [X] Em `Views` / `Account` / `Register`
- [X] Em `Views` / `Account` / `Login`

**DataMatrícula**
- [x] Em `ClientesController`
- Incluir ` cliente.DataMatricula = DateTime.Now;` em `HttpPost/Create` 

```css
[HttpPost]
        [Route(template: "novo-cliente")]
        [ValidateAntiForgeryToken]
        
        public async Task<ActionResult> Create([Bind(Include = "Id,NomeEmpresa,CNPJ,NomeContatoFinanceiro,Email,Telefone,****DataMatricula****,Ativo")] Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                cliente.DataMatricula = DateTime.Now;
```

- [x] Eliminar `DataMatricula` de todos os BIND's
- Incluir ` cliente.DataMatricula = DateTime.Now;` em `HttpPost/edit` 
- Solicitar que ignore a data de matrícula

```css
  db.Entry(cliente).State = EntityState.Modified;
                db.Entry(cliente).Property(Cliente => Cliente.DataMatricula).IsModified = false;
```

**Adicionar campo novo para a Tabela**
- [x] Em `Controller`:
- Criar o novo parâmetro;
- Adicionar o nome do Novo Parâmetro dentro da BIND
- [x] Em `View`, em cada pasta incluir o  noco parâmetro
- [x] Realizar o `update-database -Verbose`

**Alterar Nome das Campos Selecionáveis**

Sobre / Contao / Clientes etc.;

- [x] Em `_Layout` primeiro item é o nome que aparecerá no site = "Account Law"

`<li>@Html.ActionLink("Account Law", "Index", "Home")</li>`

**Alterar Nome da Aplicação no Site**
- [x] Em `View` / `Shared` / `_Layout`

```css
    <title>@ViewBag.Title - Account Law</title>
```

**Alteração da url**

- [x] Em [Rotas](https://github.com/PamelaRondina/step-by-step/tree/main/asp.net_MVC#rotas-por-atributos).

**Alteração dos parágrafos**

- [x] Em `Views` / `Home` / `Index`

> Também conseguimos incluir direcionamentos para sites

```html<div class="jumbotron">
    <h1>Account Law</h1>
    <p class="lead">Solução de gestão financeira para escritórios e departamentos jurídicos.</p>
    <p><a href="https://accountlaw.com.br/" class="btn btn-primary btn-lg">Visitar Site &raquo;</a></p>
</div>

<div class="row">
    <div class="col-md-4">
        <h2>Nossas redes</h2>
        <p>
            Acompanhe nossa trajetória pelo Instagram.
        </p>
        <p><a class="btn btn-default" href="https://www.instagram.com/accountlawoficial/">Instagram &raquo;</a></p>
    </div>
    <div class="col-md-4">
        <h2></h2>
        <p>Acompanhe nossa trajetória pelo Linkedin.</p>
        <p><a class="btn btn-default" href="https://www.linkedin.com/company/accountlaw/">Linkedin &raquo;</a></p>
    </div>
    <div class="col-md-4">
        <h2></h2>
        <p>Acompanhe nossa trajetória pelo Facebook.</p>
        <p><a class="btn btn-default" href="https://www.facebook.com/accountlawoficial">Facebook &raquo;</a></p>
    </div>
    <div class="col-md-4">
        <h2></h2>
        <p>Acompanhe nossa trajetória pelo Youtube.</p>
        <p><a class="btn btn-default" href="https://www.youtube.com/channel/UCs56WDx0cRPTTOp1nnMZulg">Youtube &raquo;</a></p>
    </div>

</div>
```

_____________

### Manutenção de estado

Com uma Controller e uma View, a Controlle entrega dados de modelo para a View, por exemplo, uma Model.

Neste capítulo, vamos entender como essa informação é passada sem uma Model, existem 03 conceitos para isso:

- ViewBag e ViewData
- TempData

**ViewBag e ViewData**

> Uma sacola de informação

- Curto tempo de duração, apenas um request
- Após lida perdem o conteúdo
- Precisa definir uma chave de valor

**ViewBag**
- Atua em tipo dinâmico, resolve objeto em tempo real

- [x] Em `Controller`/ `[HttpGet]/Delete` 



**TempData**
- Tem duração maior
- Após lida perde o conteúdo
- Semelhante a uma sessão do ASP.NEt

Uma Controller fazendo um request para outra Controller e a Controller que recebeu o request chama uma View

Essa TempData será insistente até ser lida:

- [x] Em `Views` / `Clientes` / `Delete`

```csss
@if (!string.IsNullOrEmpty(ViewBag.Mensagem))
{
    <div class="alert alert-danger">
        <button type="button" class="close" data-dismiss="alert">x</button>
        <h3>@ViewBag.Mensagem</h3>
    </div>
}
```


- [x] Em `Controller`/ `[HttpPOst]/Create` 

```css
public async Task<ActionResult> Delete(int id)
        {
            var cliente = await db.Clientes.FindAsync(id);
            if (cliente == null)

            {  //caso não exista, retorna um NotFound
                return HttpNotFound();
            }
            ViewBag.Mensagem = "Atenção, ao continuar: Ação Irreversível!";
```

```css
cliente.DataMatricula = DateTime.Now;
    db.Clientes.Add(cliente);
    await db.SaveChangesAsync();

TempData["Mensagem"] = "Cliente cadastrado com sucesso!";
```

- [x] Em `Views` / `Clientes` / `Index`

> Para C# iniciar com @, código grande com `@{}`
> TempData pode ser uma Objeto ou String

```css
    ViewBag.Title = "Cadastro de Clientes";
}

@if (TempData["Mensagem"] != null)
{
    <div class="alert alert-success">
        <button type="button" class="close" data-dismiss="alert">x</button>
        <h3>@TempData["Mensagem"].ToString()</h3>
    </div>
}
```

______________________

### Controller - Action Filters

- Podem ser utilizados diretamente na Controller

Nome | Descrição
-|-
OutputCache | FAz o cache de um output da Controller
ValidateInput | Desliga a validação dos requests e permite input de dados perigosos
Authorize | Restringe uma Action a apenas usuarios autorizados ou roles
ValidateAntiForgeryToken | Previne ataques de Cross-Site Requests Forgery
HandleError | Captura todos os erros e possibilita a escolha de uma View para exibiçãi de erros personalizados

Em `ClientesController`

- Acesso ao cadastro de Clientes apenas após o Login `[Authorize]`
```css
namespace WebAppAccountLaw.Controllers
{
    [Authorize]
```

- Abrir uma exceção `[AlowAnonymous]`

_____________________________

## ASP.NET Avançado

### Novo projeto

**Adicionando Camadas**

- [x] Escolher `Solução Em Branco`  
- [x] No diretório do computador criar novas pastas
- docs
- sql
- src
- tests
<br>
- [x] No VS adicionar primeira camada: `Add` / `Novo Projeto` sendo `Asp.Net Framework / MVC / Autenticação: Contas individuais` , salvar na pasta `src` como `Nome.AppMvc`
- [x] No VS adicionar segunda camada: `Add` / `Novo Projeto` sendo `Biblioteca de Classes` ou `Class Library`, salvar na pasta `src` como `Nome.Business`
- [x] Deletar `Class1.cs` (não utilizaremos)
- [x] No VS adicionar terceira camada: `Add` / `Novo Projeto`, sendo `Biblioteca de Classes` ou `Class Library`, salvar na pasta `src` como `Nome.Infra`
- [x] Deletar `Class1.cs` (não utilizaremos)

<br>

- [x] Em Business podemos limpar o diretório `References` deixando apenas o arquivo `System`
<br>

**Camada de Negócios**
- [x] Na camada de MVC, em `Referências` adicionar apontamentos: `Projetos` e ticar Business e Infra
- [x] Na camada de Infra, em `Referências` adicionar apontamentos: `Projetos` Business
<br>

**Para mudar a versão do Framework** 
- [x] Clicar no nome do projeto, `Descarregar Projeto` ou `Unload Project` e alterar a versão:

 `<TargetFrameworkVersion>v4.8</TargetFrameworkVersion>`

 - [x] Após editar, fazer `Reload Project`

______________________

### Modelar a camada de Negócios

- [x] Em Business criar pastas/subpastas:
- Em `Core` criar a subpasta `Models` + adicionar classe = `Entity` (será a classe mãe, que não poderá ser estanciada, apenas herdada)
- Em `Models` criar as subpstas:
    - `Fornecedores` + adicionar Classe = `Fornecedor ` e  
    - `Produtos` + adicionar Classe `Produto`
    
    ![image](https://user-images.githubusercontent.com/108991648/207140394-18dc743a-cda0-4092-a426-be4d48569b12.png)


**Classe: Entity**

> Guid: gera numeração não sequencial como o "Int ID"

> Classe mãe! Classe BASE

```css
namespace Pam.Business.Core.Models



{
    
    public abstract class Entity
    {
        // os membros protegidos só podem ser acessíveis de quem herdar   
        protected Entity()
        { 
            //O Id será acessado pela numeração do NewGuid
            Id = Guid.NewGuid();
        }
        
        // Guid: gera numeração não sequencial como o "Int ID"
        // Dá para definir o ID da entidade antes de salvar no BD
        public Guid Id { get; set; }

    }
      
}
```

**Classe - Fornecedor**
```css
namespace Pam.Business.Models.Fornecedores
{
    // Classe Fornecedor que vai herdar de Entity
    public class Fornecedor : Entity
    {
    }
}
```

**Clase - Produto**
```css
namespace Pam.Business.Models.Produtos
{
    // Classe Fornecedor que vai herdar de Entity
    public class Produto : Entity
    {
    }
}
```

**Classe - Endereco**
```css
namespace Pam.Business.Models.Fornecedores
{
    public class Endereco : Entity
    {
    }
}
```

_______________________________

### Incluindo Propriedades

**Fornecedor**
```css
using Pam.Business.Core.Models;
using Pam.Business.Models.Produtos;
using System.Collections.Generic;

namespace Pam.Business.Models.Fornecedores
{
    // Classe Fornecedor que vai herdar de Entity
    public class Fornecedor : Entity
    {
        public string Nome { get; set; }
        public string Documento { get; set; }
        public TipoFornecedor TipoFornecedor { get; set; }
        public Endereco Endereco { get; set; } 
        public bool Ativo { get; set; }
    
        /*EF Relations*/
        public ICollection<Produto> Produtos { get; set; }
    }
}
```

**Classe - Tipo Fornecedor**

```css
namespace Pam.Business.Models.Fornecedores
{
    public enum TipoFornecedor
    {
        PessoaFisica = 1,
        PessoaJuridica
    }
}
```

**Classe - Endereço**

> incluir as propriedades! 

> Todas com `string` pois o próprio usuário que vai informar os dados

```css
using Pam.Business.Core.Models;

namespace Pam.Business.Models.Fornecedores
{
    public class Endereco : Entity
    {
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public Fornecedor Fornecedor { get; set; }
    }
}
```

**Classe - Produto**

```css
using Pam.Business.Core.Models;
using Pam.Business.Models.Fornecedores;

namespace Pam.Business.Models.Produtos
{
    // Classe Fornecedor que vai herdar de Entity
    internal class Produto : Entity
    {
        public Guid FornecedorId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
       
        public Fornecedor Fornecedor { get; set; }
    }
}
```
______________________

### Mapeando as Interfaces 

- [x] Em Core, criar pasta `Data`
- [x] Em Data, criar interface `IRepository`

> Fará as regras de CRUD

```css
using Pam.Business.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Pam.Business.Core.Data
{
    //Entity representa a Entidade
    // 
    public interface IRepository<TEntity> : IDisposable where TEntity : Entity
    {
        //métodos
        Task Adicionar(TEntity entity);
        Task<TEntity> ObterPorId(Guid id);
        Task<List<TEntity>> ObterTodos();
        Task Atualizar(TEntity entity);
        Task Remover(Guid id);

        //retornar uma coleção de entidade com o método Buscar, que recebe uma expressão lambida em cima da entidade que estou trabalhando, que busca no banco o formato que quisermos
        Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> predicate);

        //método para salvar no banco
        //retorna um inteiro (número de linhas afetadas após persistir no BD)
        Task<int> SaveChanges();
    }
}
```

**Implementar o acesso as entidades, atavés das interfaces especializadas.**

- [x] Em Fornecedores, criar interface `IFornecedorRepository`

> Para não repetirmos informações [ : IRepository<Fornecedor> ], tudo o que o Irepository implementa + os métodos (TASK) do atual

```css
using Pam.Business.Core.Data;
using System;
using System.Threading.Tasks;

namespace Pam.Business.Models.Fornecedores
{
    
    public interface IFornecedorRepository : IRepository<Fornecedor>
    {
        Task<Fornecedor> ObterFornecedorEndereco(Guid id);
        Task<Fornecedor> ObterFornecedorProdutosEndereco(Guid id);

    }
}
```

- [x] Em Fornecedores, criar interface `IEnderecoRepository`

> Para não repetirmos informações [ : IRepository<Endereco> ], tudo o que o Irepository implementa + os métodos (TASK) do atual

```css
using Pam.Business.Core.Data;
using System;
using System.Threading.Tasks;

namespace Pam.Business.Models.Fornecedores
{
    public interface IEnderecoRepository : IRepository<Endereco>
    {
        Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId);
    }
}
```

- [x] Em Produtos, criar interface `IProdutoRepository`

> Para não repetirmos informações [ : IRepository<Produto> ], tudo o que o Irepository implementa + os métodos (TASK) do atual

```css
using Pam.Business.Core.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pam.Business.Models.Produtos
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        Task<IEnumerable<Produto>> ObterProdutosPorFornecedor(Guid fornecedorId);
        //lista de produtos e seus fornecedores
        Task<IEnumerable<Produto>> ObterProdutosFornecedores();
        Task<Produto> ObterProdutosFornecedor(Guid id);
    }
}
```
______________________

### Mapeando o BD

**Adicionar Pacote**
- [x] Em Console do Gerenciados de Pacotes:
    - Projeto padrão = Pam.infra
    - `PM> install-package EntityFramework `

**Alterar Nome do BD**
- [x] Em Pam.AppMvc, Web.Config, em ` <add name="DefaultConnection"` alterar o nome para o da aplicação:

Antes: `|DataDirectory|\aspnet-Pam.AppMvc-20221212032038.mdf;Initial Catalog=aspnet-Pam.AppMvc-20221212032038;`

Depois: `|DataDirectory|\Pam.MeusProdutos.mdf;Initial Catalog=Pam.MeusProdutos;`

**Classe - MeuDbContext**

- [x] Na camada de Infra, criar diretório `Data`
- [x] Em Data, criar `Context`
- [x] Em Context, criar classe `MeuDbContext`

```css
using Pam.Business.Models.Fornecedores;
using Pam.Business.Models.Produtos;
using System.Data.Entity;


namespace Pam.Infra.Data.Context
{
    //Adicionar herança
    public class MeuDbContext : DbContext
    {
        //constructor vai passar para a classe base com o nome abaixo
        public MeuDbContext() : base(nameOrConnectionString: "DefaultConnection")
        { }

        //Mapeamento (nomes sempre no PLURAL)
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
    }
}
```

**Adicionar Pacote**

Em `Console de Gerenciador de Pacotes` para criar o BD e as tabelas:
- [x] Pam.Infra
- [x] PM> enable-migrations

Será gerado um erro:

`Unable to determine the principal end of an association between the types 'Pam.Business.Models.Fornecedores.Fornecedor' and 'Pam.Business.Models.Fornecedores.Endereco'. The principal end of this association must be explicitly configured using either the relationship fluent API or data annotations.`

Para resolvê-lo, **trabalharemos com o FluentAPI**

- [x] Em Pam.Infra, Data, criar pasta `Mappings`
- [x] Em Mapping, criar classe `FornecedorConfig`

```css
using Pam.Business.Models.Fornecedores;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.Infrastructure.Annotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Pam.Infra.Data.Mappings
{
    /*Aqui temos um mapeamento realizado através do EntityTypeConfiguration de Fornecedor*/
    public class FornecedorConfig : EntityTypeConfiguration<Fornecedor>
    {
        public FornecedorConfig()
        {
            /*A chave primária da minha tabela é o ID*/
            HasKey(f => f.Id);

            /*mapear Propriedade = Nome não pode ser nulo | VARCHAR(200)*/
            Property(f => f.Nome)
                .IsRequired()
                .HasMaxLength(200);

            /*mapear Documento = Documento não pode ser nulo | VARCHAR(14) para CPF ou CNPJ | Possui um Índice (para mapeamento mais rápido)*/
            Property(f => f.Documento)
                .IsRequired()
                .HasMaxLength(14)
                .HasColumnAnnotation("IX_Documento", 
                /*Index ser único não é possível cadastrar dois ou mais iguais*/
                value: new IndexAnnotation(new IndexAttribute {IsUnique = true }));

            /*É Obrigatório o Endereço
            Se não fosse obrigatório seria incluso:  HasOptional*/
            HasRequired(f => f.Endereco)
                //O principal é o Fornecedor nesta relação
                .WithRequiredPrincipal(e => e.Fornecedor);

            /*Nome da Tabela*/
            ToTable("Fornecedores");
        }
    }
}
```

- [x] Em Mapping, criar class `EnderecoConfig`

```css
using Pam.Business.Models.Fornecedores;
using System.Data.Entity.ModelConfiguration;


namespace Pam.Infra.Data.Mappings
{
    public class EnderecoConfig : EntityTypeConfiguration<Endereco>
    {

        public EnderecoConfig()
        {
            /*A chave primária da minha tabela é o ID*/
            HasKey(p => p.Id);

            Property(c => c.Logradouro)
                .IsRequired()
                .HasMaxLength(200);

            Property(c => c.Numero)
                .IsRequired()
                .HasMaxLength(50);

            /*Possui tamanho fixo*/
            Property(c => c.Cep)
                .IsRequired()
                .HasMaxLength(8)
                .IsFixedLength();

            Property(c => c.Complemento)
                .HasMaxLength(250);

            Property(c => c.Bairro)
               .IsRequired()
               .HasMaxLength(100);

            Property(c => c.Cidade)
               .IsRequired()
               .HasMaxLength(100);

            Property(c => c.Estado)
               .IsRequired()
               .HasMaxLength(100);


            /*Nome da Tabela*/
            ToTable("Enderecos");
        }
    }
}
```

- [x] Em Mapping, criar class `ProdutoConfig`

```css
using Pam.Business.Models.Produtos;
using System.Data.Entity.ModelConfiguration;

namespace Pam.Infra.Data.Mappings
{
    public class ProdutoConfig : EntityTypeConfiguration<Produto>   
    {
        public ProdutoConfig()
        {
            HasKey(p => p.Id);

            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(200);

            Property(p => p.Descricao)
               .IsRequired()
               .HasMaxLength(1000);

            Property(p => p.Imagem)
               .IsRequired()
               .HasMaxLength(100);

            /*Produto tem um relacionamento com o Fornecedor*/
            HasRequired(p => p.Fornecedor)
                .WithMany(f => f.Produtos)
                .HasForeignKey(p => p.FornecedorId);

            /*Nome da Tabela*/
            ToTable("Produtos");
        }
    }
}
```

- [x] Em MeuDbContext configurar mapeamentos

```css
using Pam.Infra.Data.Mappings;
using System.Data.Entity;

...  
public DbSet<Fornecedor> Fornecedores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new FornecedorConfig());
            modelBuilder.Configurations.Add(new EnderecoConfig());
            modelBuilder.Configurations.Add(new ProdutoConfig());
        }
```

> BD que já possua uma tabela .HasColumnNamw("Rua)

Novamente, Em `Console de Gerenciador de Pacotes` para criar o BD e as tabelas:
- [x] Pam.Infra
- [x] PM> enable-migrations

- Em Pam.Infra, Migrations, `Configuration.cs`
    - Alterar `AutomaticMigrationsEnabled = true;` para utilizar as migrations automáticas
    - Deletar: `protected override void` 
    - Seguir modelo abaixo

```css
using Pam.Infra.Data.Context;
using System.Data.Entity.Migrations;

namespace Pam.Infra.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<MeuDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }
                
    }
}
```

**Ajustar scripts das tabelas**

- [x] Em MeuDbContext, adicionar:

```css
using System.Data.Entity.ModelConfiguration.Conventions;

..."DefaultConnection")
        { 
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            /*Deabilitar: Nome das tabelas no plural*/
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
            /*Desabilitar: a exclusão em cascata*/
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            /*Se for do tipo string = será VARCHAR(100)*/
            modelBuilder.Properties<string>().Configure(p => p
                .HasColumnType("varchar")
                .HasMaxLength(100));

            modelBuilder.Configurations.Add(new FornecedorConfig());
            modelBuilder.Configurations.Add(new EnderecoConfig());
            modelBuilder.Configurations.Add(new ProdutoConfig());

            base.OnModelCreating(modelBuilder);
        }
    }
}
```

> Podendo ser deletado `.HasMaxLength(100));` dos outros arquivos

- [x] Fazer update do BD `update-database -Verbose`

> As tabelas serão criadas. Visualizar em `SQL Server Object Explorer`

______________

### Padrão Repository

- [x] Em Pam.Infra, Data, criar pasta `Repository`
- [x] Em Repository, criar classe `Repository`
- [x] **IRepository<TEntity>** Implementar interface

```css
using Pam.Business.Core.Data;
using Pam.Business.Core.Models;
using Pam.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Pam.Infra.Data.Repository
{
    /*Abstract Class = não se pode instanciar sozinha, deve ser herdar*/
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity, new()
    {
        /*criar acesso ao contexto*/
        protected readonly MeuDbContext Db;
        protected readonly DbSet<TEntity> DbSet;

        protected Repository()
        {
            /*Contexto em geral*/
            Db = new MeuDbContext();
            /*Acesso rápido a minha Entidade*/
            DbSet = Db.Set<TEntity>();
        }       

        /*método de leitura*/
        public virtual async Task<TEntity> ObterPorId(Guid id)
        {
            /*método "FindAsync" serve para encontrar a entidade através da PK*/
            return await DbSet.FindAsync(id);
        }

        /*método de leitura que trará uma lista*/
        public virtual async Task<List<TEntity>> ObterTodos()
        {
            /*Retorna uma lista de forma assíncrona*/
            return await DbSet.ToListAsync(); 
        }
        /*Método que implementa uma expressão*/
        public async Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> predicate)
        {
            /*Desabilita o Track*/
            return await DbSet.AsNoTracking().Where(predicate).ToListAsync(); 
        }

        /*Inicia a transformação de dados*/
        public virtual async Task Adicionar(TEntity entity)
        {
            DbSet.Add(entity);
            await SaveChanges();
        }

        public virtual async Task Atualizar(TEntity entity)
        {
            Db.Entry(entity).State = EntityState.Modified;
            await SaveChanges();
        }
                       

        public virtual async Task Remover(Guid id)
        {
            Db.Entry(new TEntity { Id = id }).State = EntityState.Deleted;
            await SaveChanges();
        }

        public async Task<int> SaveChanges()
        {
            return await Db.SaveChangesAsync();
        }

        public void Dispose()
        {/*? = Só chama o método se tiver ums instância definida*/
            Db?.Dispose();
        }
    }
}
```

___________________

### Criar Repository: Fornecedor, Endereco e Produto

- [x] Em Pam.Infra, Data, criar pasta `Repository`
- [x] Em Repository, criar classe `FornecedorRepository` 
- [x] Implementar a Interface de `IFornecedorRepository`
- [x] Incluir referência `using System.Data.Entity;`

```css
using Pam.Business.Models.Fornecedores;
using System;
using System.Data.Entity;
using System.Threading.Tasks;

namespace Pam.Infra.Data.Repository
{
    public class FornecedorRepository : Repository<Fornecedor>, IFornecedorRepository
    {
        public async Task<Fornecedor> ObterFornecedorEndereco(Guid id)
        {
            /*retornar o Fornecedor + Endereço populado*/
            return await Db.Fornecedores.AsNoTracking()
                .Include(f => f.Endereco)
                .FirstOrDefaultAsync(f => f.Id == id);
        }

        public async Task<Fornecedor> ObterFornecedorProdutosEndereco(Guid id)
        {
            return await Db.Fornecedores.AsNoTracking()
             .Include(f => f.Endereco)
             .Include(f => f.Produtos)
             .FirstOrDefaultAsync(f => f.Id == id);
        }

        /*Método para não remover um Fornecedor e sim deixá-lo Intaivo
        public override async Task Remover(Guid id)
        {
            var fornecedor = await ObterPorId(id);
            fornecedor.Ativo = false;

            await Atualizar(fornecedor);*/
    }
}
```

- [x] Em Pam.Infra, Data, criar pasta `Repository`
- [x] Em Repository, criar classe `EnderecoRepository` 
- [x] Implementar a Interface de `IEnderecoRepository`

```css
using Pam.Business.Models.Fornecedores;
using System;
using System.Threading.Tasks;

namespace Pam.Infra.Data.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public async Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId)
        {
            return await ObterPorId(fornecedorId);
        }
    }
}
```

- [x] Em Pam.Infra, Data, criar pasta `Repository`
- [x] Em Repository, criar classe `ProdutoRepository` 
- [x] Implementar a Interface de `IProdutoRepository`
- [x] Incluir referência `using System.Data.Entity;`

```css
using Pam.Business.Models.Produtos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Pam.Infra.Data.Repository
{
    public class ProdutosRepository : Repository<Produto>, IProdutoRepository

    {
        public async Task<Produto> ObterProdutosFornecedor(Guid id)
        {
            return await Db.Produtos.AsNoTracking()
                .Include(f => f.Fornecedor)
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IEnumerable<Produto>> ObterProdutosFornecedores()
        {
            return await Db.Produtos.AsNoTracking()
                .Include(f => f.Fornecedor)
                .OrderBy(p => p.Nome).ToListAsync();
        }

        public async Task<IEnumerable<Produto>> ObterProdutosPorFornecedor(Guid fornecedorId)
        {
            return await Buscar(p => p.FornecedorId == fornecedorId);
        }
    }
}
```

________________________

### Trabalhando com Fluent Validation

- [x] Em Pam.Business, Fornecedores, criar pasta `Validations`
- [x] Em Validations criar classe `FornecedorValidation` 
<br><br>

Em `Console de Gerenciador de Pacotes` **Instalar o [Fluent Validation](https://github.com/FluentValidation/FluentValidation)**
- [x] Pam.Business
- [x] PM> Install-Package FluentValidation

- [x] Em Pam.Business, Core, criar pasta `Validations` e subpasta `Documentos`
- [x] Em Documentos criar classe `validacaoDocs` 

```css
using System.Collections.Generic;
using System.Linq;


namespace Pam.Business.Core.Validations.Documentos
{
            public class CpfValidacao
        {
            public const int TamanhoCpf = 11;

            public static bool Validar(string cpf)
            {
                var cpfNumeros = Utils.ApenasNumeros(cpf);

                if (!TamanhoValido(cpfNumeros)) return false;
                return !TemDigitosRepetidos(cpfNumeros) && TemDigitosValidos(cpfNumeros);
            }

            private static bool TamanhoValido(string valor)
            {
                return valor.Length == TamanhoCpf;
            }

            private static bool TemDigitosRepetidos(string valor)
            {
                string[] invalidNumbers =
                {
                "00000000000",
                "11111111111",
                "22222222222",
                "33333333333",
                "44444444444",
                "55555555555",
                "66666666666",
                "77777777777",
                "88888888888",
                "99999999999"
            };
                return invalidNumbers.Contains(valor);
            }

            private static bool TemDigitosValidos(string valor)
            {
                var number = valor.Substring(0, TamanhoCpf - 2);
                var digitoVerificador = new DigitoVerificador(number)
                    .ComMultiplicadoresDeAte(2, 11)
                    .Substituindo("0", 10, 11);
                var firstDigit = digitoVerificador.CalculaDigito();
                digitoVerificador.AddDigito(firstDigit);
                var secondDigit = digitoVerificador.CalculaDigito();

                return string.Concat(firstDigit, secondDigit) == valor.Substring(TamanhoCpf - 2, 2);
            }
        }

        public class CnpjValidacao
        {
            public const int TamanhoCnpj = 14;

            public static bool Validar(string cpnj)
            {
                var cnpjNumeros = Utils.ApenasNumeros(cpnj);

                if (!TemTamanhoValido(cnpjNumeros)) return false;
                return !TemDigitosRepetidos(cnpjNumeros) && TemDigitosValidos(cnpjNumeros);
            }

            private static bool TemTamanhoValido(string valor)
            {
                return valor.Length == TamanhoCnpj;
            }

            private static bool TemDigitosRepetidos(string valor)
            {
                string[] invalidNumbers =
                {
                "00000000000000",
                "11111111111111",
                "22222222222222",
                "33333333333333",
                "44444444444444",
                "55555555555555",
                "66666666666666",
                "77777777777777",
                "88888888888888",
                "99999999999999"
            };
                return invalidNumbers.Contains(valor);
            }

            private static bool TemDigitosValidos(string valor)
            {
                var number = valor.Substring(0, TamanhoCnpj - 2);

                var digitoVerificador = new DigitoVerificador(number)
                    .ComMultiplicadoresDeAte(2, 9)
                    .Substituindo("0", 10, 11);
                var firstDigit = digitoVerificador.CalculaDigito();
                digitoVerificador.AddDigito(firstDigit);
                var secondDigit = digitoVerificador.CalculaDigito();

                return string.Concat(firstDigit, secondDigit) == valor.Substring(TamanhoCnpj - 2, 2);
            }
        }

        public class DigitoVerificador
        {
            private string _numero;
            private const int Modulo = 11;
            private readonly List<int> _multiplicadores = new List<int> { 2, 3, 4, 5, 6, 7, 8, 9 };
            private readonly IDictionary<int, string> _substituicoes = new Dictionary<int, string>();
            private bool _complementarDoModulo = true;

            public DigitoVerificador(string numero)
            {
                _numero = numero;
            }

            public DigitoVerificador ComMultiplicadoresDeAte(int primeiroMultiplicador, int ultimoMultiplicador)
            {
                _multiplicadores.Clear();
                for (var i = primeiroMultiplicador; i <= ultimoMultiplicador; i++)
                    _multiplicadores.Add(i);

                return this;
            }

            public DigitoVerificador Substituindo(string substituto, params int[] digitos)
            {
                foreach (var i in digitos)
                {
                    _substituicoes[i] = substituto;
                }
                return this;
            }

            public void AddDigito(string digito)
            {
                _numero = string.Concat(_numero, digito);
            }

            public string CalculaDigito()
            {
                return !(_numero.Length > 0) ? "" : GetDigitSum();
            }

            private string GetDigitSum()
            {
                var soma = 0;
                for (int i = _numero.Length - 1, m = 0; i >= 0; i--)
                {
                    var produto = (int)char.GetNumericValue(_numero[i]) * _multiplicadores[m];
                    soma += produto;

                    if (++m >= _multiplicadores.Count) m = 0;
                }

                var mod = (soma % Modulo);
                var resultado = _complementarDoModulo ? Modulo - mod : mod;

                return _substituicoes.ContainsKey(resultado) ? _substituicoes[resultado] : resultado.ToString();
            }
        }

        public class Utils
        {
            public static string ApenasNumeros(string valor)
            {
                var onlyNumber = "";
                foreach (var s in valor)
                {
                    if (char.IsDigit(s))
                    {
                        onlyNumber += s;
                    }
                }
                return onlyNumber.Trim();
            }
        }
    }
```

- [x] Retornar em `FornecedorValidation` para incluir as regras:

```css
using FluentValidation;
using Pam.Business.Core.Validations.Documentos;

namespace Pam.Business.Models.Fornecedores.Validations
{
    public class FornecedorValidation : AbstractValidator<Fornecedor>
    {
        public FornecedorValidation() 
        {
            RuleFor(f => f.Nome)
                /*Não pode ser vazio | Com mensagem*/
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido.")
                /*Tamanho do Nome 2 = mínimo e 100 = máximo*/
                .Length(2,200).WithMessage("O campo {propertyName} precisa ter entre {MinLength} e {MaxLength} caracteres.");

            /*Validar CPF ou CNPJ*/
            When(f => f.TipoFornecedor == TipoFornecedor.PessoaFisica, () =>
            {
                RuleFor(f => f.Documento.Length).Equal(CpfValidacao.TamanhoCpf)
                .WithMessage("O campo Documento precisa ter {ComparisonValue} caracteres e foi fornecido {PropertyValue}.");
                RuleFor(f => CpfValidacao.Validar(f.Documento)).Equal(true)
                .WithMessage("O documento forneceido é inválido.");
            });

            When(f => f.TipoFornecedor == TipoFornecedor.PessoaJuridica, () =>
            {
                RuleFor(f => f.Documento.Length).Equal(CnpjValidacao.TamanhoCnpj)
                .WithMessage("O campo Documento precisa ter {ComparisonValue} caracteres e foi fornecido {PropertyValue}.");
                RuleFor(f => CnpjValidacao.Validar(f.Documento)).Equal(true)
                .WithMessage("O documento forneceido é inválido.");

            });
        }
    }
}
```

- [x] Em Pam.Business, Models, Fornecedores, Validations criar classe `EnderecoValidation` 

```css
using FluentValidation;

namespace Pam.Business.Models.Fornecedores.Validations
{
    public class EnderecoValidation : AbstractValidator<Endereco>
    {
        public EnderecoValidation() 
        {
            /*As regras não podem ser vazias e possuem um tamanho específico*/
            RuleFor(c => c.Logradouro)
                    .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                    .Length(2, 200).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(c => c.Bairro)
                    .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                    .Length(2, 100).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(c => c.Cep)
                    .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                    .Length(8).WithMessage("O campo {PropertyName} precisa ter {MaxLength} caracteres");

            RuleFor(c => c.Cidade)
                    .NotEmpty().WithMessage("A campo {PropertyName} precisa ser fornecida")
                    .Length(2, 100).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(c => c.Estado)
                    .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                    .Length(2, 50).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(c => c.Numero)
                    .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                    .Length(1, 50).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

        }
        
    }
}
```

- [x] Em Pam.Business, Produtos, criar pasta `Validations`
- [x] Em Validations, criar classe `ProdutoValidation`

```css
using FluentValidation;

namespace Pam.Business.Models.Produtos.Validations
{
    public class ProdutoValidation : AbstractValidator<Produto>
    {
        public ProdutoValidation()
        {
            /*As regras não podem ser vazias e possuem um tamanho específico*/
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(2, 200).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(c => c.Descricao)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(2, 1000).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            /*O campo valor precisa ser > que 0*/
            RuleFor(c => c.Valor)
                .GreaterThan(0).WithMessage("O campo {PropertyName} precisa ser maior que {ComparisonValue}");
        }
    }
}
```

> Podendo ser validada também desta forma:
![image](https://user-images.githubusercontent.com/108991648/208689074-eca93e4b-89c3-4328-b205-3ebb11271515.png)

_____________________

### Serviços de Negócio

- [x] Em Pam.Business, Core, Models, Fornecedores criar pasta `Services`
- [x] Em Services, criar interface `IFornecedorService`

```css
using System;
using System.Threading.Tasks;

namespace Pam.Business.Models.Fornecedores
{
    public interface IFornecedorService : IDisposable
    {
        Task Adicionar(Fornecedor fornecedor);
        Task Atualizar(Fornecedor fornecedor);
        Task Remover(Guid id);
        Task AtualizarEndereco(Endereco endereco);

    }
}
```

- [x] Em Services, criar classe `FornecedorService`
- [x] **IFornecedoreService** implementar interface

```css
using System;
using System.Linq;
using System.Threading.Tasks;
using Pam.Business.Core.Notificacoes;
using Pam.Business.Core.Service;
using Pam.Business.Models.Fornecedores.Validations;


namespace Pam.Business.Models.Fornecedores.Services
{
    public class FornecedorService : BaseService, IFornecedorService
    {
        private readonly IFornecedorRepository _fornecedorRepository;
        private readonly IEnderecoRepository _enderecoRepository;

        public FornecedorService(IFornecedorRepository fornecedorRepository, 
                                 IEnderecoRepository enderecoRepository,
                                 INotificador notificador) : base(notificador)
        {
            _fornecedorRepository = fornecedorRepository;
            _enderecoRepository = enderecoRepository;
            
        }
        public async Task Adicionar(Fornecedor fornecedor)
        {
            /*Fornecedor e Endereço estão validos? Se não, retorna!*/
            if (!ExecutarValidacao(new FornecedorValidation(), fornecedor)
                || !ExecutarValidacao(new EnderecoValidation(), fornecedor.Endereco)) return;

            /*Fornecedor Existe com esse documento? Se sim, retorna*/
            if (await FornecedorExistente(fornecedor)) return;

            /*estando ok, Adiciona*/
            await _fornecedorRepository.Adicionar(fornecedor);

        }

        public async Task Atualizar(Fornecedor fornecedor)
        {
            /*Fornecedor está válido? Se não, retorna!*/
            if (!ExecutarValidacao(new FornecedorValidation(), fornecedor)) return;

            /*Fornecedor Existe com esse documento? Se sim, retorna*/
            if (await FornecedorExistente(fornecedor)) return;

            /*estando ok, Atualiza*/
            await _fornecedorRepository.Atualizar(fornecedor);
        }

        public async Task Remover(Guid id)
        {
            var fornecedor = await _fornecedorRepository.ObterFornecedorProdutosEndereco(id);
            /*regra, não pode deletar fornecedor com produtos
             Se o fornecedor possui produtos, retorna*/
            if (fornecedor.Produtos.Any())
            {
                Notificar("O fornecedor possui produtos cadastrados!");
                return;
            }
            /*Se o endereço do fornecedor.Endereço for diferente de NULL será removido o Endereço*/
            if (fornecedor.Endereco != null)
            {
                await _enderecoRepository.Remover(fornecedor.Endereco.Id);
            }
            /*Depois de remover o endereço, remover o fornecedor*/

            await _fornecedorRepository.Remover(id);
        }
        public async Task AtualizarEndereco(Endereco endereco)
        {
            /*Endereço está válido? Se não, retorna!*/
            if (!ExecutarValidacao(new EnderecoValidation(), endereco)) return;

            await _enderecoRepository.Atualizar(endereco);
        }

        private async Task<bool> FornecedorExistente(Fornecedor fornecedor)
        {
            var fornecedorAtual = await _fornecedorRepository.Buscar(f => f.Documento == fornecedor.Documento && f.Id != fornecedor.Id);

            if (!fornecedorAtual.Any()) return false;

            Notificar("Já existe um fornecedor com este documento informado.");
                  
            return true;
        }

            public void Dispose()
            {
                _fornecedorRepository?.Dispose();
                _enderecoRepository?.Dispose();
            }

        }
    } 
```

- [x] Em Pam.Business, Core, criar pasta `Services`
- [x] Em Services, criar classe `BaseService`



```css
using FluentValidation;
using Pam.Business.Core.Models;


namespace Pam.Business.Core.Service
{
   public abstract class BaseService
    {
        /*método que executa qualquer validação de qualquer entidade*/   
        protected bool ExecutarValidacao<TV, TE>(TV validacao, TE entidade) where TV: AbstractValidator<TE> where TE : Entity
        {
            var validator = validacao.Validate(entidade);

            return validator.IsValid;
        }
    }
}
```


- [x] Em Pam.AppMvc, Controller, criar controlador vazio `FornecedoresController`

```css
using Pam.Business.Models.Fornecedores;
using Pam.Business.Models.Fornecedores.Services;
using Pam.Infra.Data.Repository;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Pam.AppMvc.Controllers
{
    public class FornecedoresController : Controller
    {
        
    }
} 
```

**Rodar a aplicação**

Incluie Breakpoint em `FornecedorController` em 
`await _fornecedorService.Adicionar(fornecedor);`

Ao rodar a aplicação deu erro no Global.asax.

- [x] Em Pam.AppMvc, arquivo `Global.aasx` foi necessário editar para:

```css
using System.Web;

namespace Pam.AppMvc
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
```

A aplicação funcionou!!

______________________

### Criar Services: Produtos

- [x] Em Pam.Business, Models, Produtos `Services`
- [x] Em Services, criar interface `IProdutosService`

```css
using System;
using System.Threading.Tasks;

namespace Pam.Business.Models.Produtos.Services
{
    public interface IProdutosService : IDisposable
    {
        /*Realizar modificações no estado da minha entidade*/
        Task Adicionar(Produto produto);
        Task Atualizar(Produto produto);
        Task Remover(Guid id);
    }
}
```
- [x] Em Services, criar classe `ProdutoService`
- [x] Implementar a interface de `IProdutosService`

```css
using Pam.Business.Core.Service;
using Pam.Business.Models.Produtos.Validations;
using System;
using System.Threading.Tasks;

namespace Pam.Business.Models.Produtos.Services
{
    public class ProdutoService : BaseService, IProdutosService
    {

        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task Adicionar(Produto produto)
        {/*Para Adicionar um produto, executa a validação*/
            if (!ExecutarValidacao(new ProdutoValidation(), produto)) return;

            await _produtoRepository.Adicionar(produto);
        }

        public async Task Atualizar(Produto produto)
        {
            if (!ExecutarValidacao(new ProdutoValidation(), produto)) return;

            await _produtoRepository.Atualizar(produto);
        }
               
        public async Task Remover(Guid id)
        {
            await _produtoRepository.Remover(id);
        }
        /*verificar se no repositório possui instância*/
        public void Dispose()
        {
            _produtoRepository?.Dispose();
        }
    }

}
```
____________________
### Mecanismo de Notificação de erros

- [x] Em Pam.Business, Core criar pasta `Notificacoes`
- [x] Em Notificacoes, criar classe `Notificacao`

```css
namespace Pam.Business.Core.Notificacoes
{
    public class Notificacao
    {

        public Notificacao(string mensagem) 
        {
            mensagem = mensagem;
        }

        public string Mensagem { get; }
        
    }
}
```

- [x] Em Notificacoes, criar interface `INotificador`

```css
using System.Collections.Generic;


namespace Pam.Business.Core.Notificacoes
{
    public interface INotificador
    {
        /*método de teste para saber se tem notificação*/
        bool TemNotificacao();
        /*retorna uma lista das notificações*/
        List<Notificacao> ObterNotificacoes();
        /*Handle = manipular quando uma notificação é lançada*/
        void Handle(Notificacao notificacao);
    }
}
```

- [x] Em Notificacoes, criar classe `Notificador`
- [x] Implementar a interface de `INotificador`

```css
using System.Collections.Generic;
using System.Linq;


namespace Pam.Business.Core.Notificacoes
{
    public class Notificador : INotificador
    {

        private List<Notificacao> _notificacoes;

        public Notificador()
        {
            /*As notificações = uma nova instância*/
            _notificacoes = new List<Notificacao>();
        }
        public void Handle(Notificacao notificacao)
        {
            _notificacoes.Add(notificacao);
        }

        public List<Notificacao> ObterNotificacoes()
        {
            return _notificacoes;
        }

        public bool TemNotificacao()
        {
            return _notificacoes.Any();
          
        }
    }
}
```
________________

### Implementar a notificação de erro

- [x] Em Pam.Business, Core, Services, arquivo `BaseService` adicionar:

```css
using FluentValidation;
using FluentValidation.Results;
using Pam.Business.Core.Models;
using Pam.Business.Core.Notificacoes;

namespace Pam.Business.Core.Service
{
   public abstract class BaseService
    {
        private readonly INotificador _notificador;

        protected BaseService(INotificador notificador)
        {
            _notificador = notificador;
        }

        protected void Notificar(ValidationResult validationResult)
        {
            foreach (var error in validationResult.Errors)
            {
                /*o que fazer com cada erro que encontrar?*/
                Notificar(error.ErrorMessage);
            }
        }

        protected void Notificar(string mensagem)
        {
            _notificador.Handle(new Notificacao(mensagem));
        }

        /*método que executa qualquer validação de qualquer entidade*/   
        protected bool ExecutarValidacao<TV, TE>(TV validacao, TE entidade) where TV: AbstractValidator<TE> where TE : Entity
        {
            var validator = validacao.Validate(entidade);

            if (validator.IsValid) return true;

            Notificar(validator);

            return false;
        }
    }
}
```

- [x] Em Pam.Business, Models, Fornecedores  Services, no arquivo `FornecedorService`
- [x] Modificar

```css
...
   public FornecedorService(
    IFornecedorRepository fornecedorRepository, 
    IEnderecoRepository enderecoRepository,
    INotificador notificador) : base(notificador)
        {
            _fornecedorRepository = fornecedorRepository;
            _enderecoRepository = enderecoRepository;
            
        }
...

  public async Task Remover(Guid id)
        {
            var fornecedor = await _fornecedorRepository.ObterFornecedorProdutosEndereco(id);
            
            if (fornecedor.Produtos.Any())
            {
                Notificar("O fornecedor possui produtos cadastrados!")
                return;
            }

  private async Task<bool> FornecedorExistente(Fornecedor fornecedor)
        {
            var fornecedorAtual = await _fornecedorRepository.Buscar(f => f.Documento == fornecedor.Documento && f.Id != fornecedor.Id);

            if (!fornecedorAtual.Any()) return false;

            Notificar("Já existe um fornecedor com este documento informado.")
            
            return true;
        }
```

- [x] Em Pam.Business, Models, Produtos,  Services, no arquivo `ProdutoService`
- [x] Modificar

```css
...
 public ProdutoService(IProdutoRepository produtoRepository, INotificador notificador) : base(notificador) 
        {
            _produtoRepository = produtoRepository;
        }
```

____________________

### Camada de Apresentação - MVC

- [x] Em Pam.AppMvc, ViewModels criar classe 
 `ProdutoViewModel`, `FornecedorViewModel` e `EnderecoViewModel`

 **`ProdutoViewModel`**
 
 ```css
 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace Pam.AppMvc.ViewModels
{
    /*Aqui temos uma representação da entidade Produto, representa as mesmas catacterísticas*/
    public class ProdutoViewModel
    { 
    public ProdutoViewModel()
    {
        Id = Guid.NewGuid();
    }

    /*Campo Id é a Chave*/
    [Key]
    public Guid Id { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigatório")]
    [DisplayName("Fornecedor")]
    public Guid FornecedorId { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigatório")]
    [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
    public string Nome { get; set; }

    [DisplayName("Descrição")]
    [Required(ErrorMessage = "O campo {0} é obrigatório")]
    [StringLength(1000, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
    public string Descricao { get; set; }

    /*Nome da imagem no BD*/
    [DisplayName("Imagem do Produto")]
    public HttpPostedFileBase ImagemUpload { get; set; }
    
    public string Imagem { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigatório")]
    public decimal Valor { get; set; }

    [ScaffoldColumn(false)]
    public DateTime DataCadastro { get; set; }

    [DisplayName("Ativo?")]
    public bool Ativo { get; set; }

    /*Fornecedor que representa o produto*/
    public FornecedorViewModel Fornecedor { get; set; }

    /*Lista de Fornecedores que auxilia a escrever o DropDownList*/
    public IEnumerable<FornecedorViewModel> Fornecedores { get; set; }
    
    }

}
```
 
 **`FornecedorViewModel`**
 
 ```css
 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Pam.AppMvc.ViewModels
{
    public class FornecedorViewModel
    { 
        public FornecedorViewModel()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(14, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 11)]
        public string Documento { get; set; }

        [DisplayName("Tipo")]
        public int TipoFornecedor { get; set; }

        public EnderecoViewModel Endereco { get; set; }

        [DisplayName("Ativo?")]
        public bool Ativo { get; set; }

        public IEnumerable<ProdutoViewModel> Produtos { get; set; }
    }
}
```
 
 
 **`EnderecoViewModel`**

```css
using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Pam.AppMvc.ViewModels
{
    public class EnderecoViewModel
    {
        public EnderecoViewModel()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(50, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 1)]
        public string Numero { get; set; }

        public string Complemento { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(8, ErrorMessage = "O campo {0} precisa ter {1} caracteres", MinimumLength = 8)]
        public string Cep { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(50, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Estado { get; set; }

        [HiddenInput]
        public Guid FornecedorId { get; set; }
    }
}
```
____________________________________

### Recurso Scaffolding

Para que este método funcione precisamos comentar alguns campos, arquivo `ProdutoViewModel`

```css

    ///*Nome da imagem no BD*/
    //[DisplayName("Imagem do Produto")]
    //public HttpPostedFileBase ImagemUpload { get; set; }

    ///*Fornecedor que representa o produto*/
    //public FornecedorViewModel Fornecedor { get; set; }

    ///*Lista de Fornecedores que auxilia a escrever o DropDownList*/
    //public IEnumerable<FornecedorViewModel> Fornecedores { get; set; }
```

- [x] Compilar aplicação AppMvc
- [x] Em Pam.AppMvc, Controller, adicionar novo item com scalffold / New Scaffolded Item.
- [x] Controlador MVC 5 com modos de exibição usando o Entity Framework
- [x] Se der erro, faça Recompilação AppMvc

![image](https://user-images.githubusercontent.com/108991648/208911177-8395a897-0c1c-4063-a333-e30896ea039c.png)

> Criei uma nova Classe de contexto de dados, pois estava dando erro.

- [x] Foi gerado:
    - Uma controller `ProdutosController`
    - Em Views, criou a pasta `Produtos`, com aquivos: Create, Delete, Details, Edit, Index 

Precisamos editar alguns itens do ProdutoController:

```css
public class ProdutosController : Controller
    {
        /*para realizar a leitura*/
        private readonly IProdutoRepository _produtoRepository;
        /*para modificar o BD*/
        private readonly IProdutoService _produtoService;

        public ProdutosController()
        {
            _produtoRepository = new ProdutoRepository();
            _produtoService = new ProdutoService(_produtoRepository,new Notificador());
        }

        public async Task<ActionResult> Index()
        {
            return View(await _produtoRepository.ObterTodos());
        }

        // GET: Produtos/Details/5
        public async Task<ActionResult> Details(Guid id)
        {            
            var produto = await _produtoRepository.ObterPorId(id);
     
            if (produtoViewModel == null)
            {
                return HttpNotFound();
            }
            return View(produtoViewModel);
        }

        ...

        public async Task<ActionResult> Create(ProdutoViewModel produtoViewModel)
        {
            if (ModelState.IsValid)
            {
                _produtoService.Adicionar(produtoViewModel);
               
                return RedirectToAction("Index");
            }

            return View(produtoViewModel);
        }
```
________________________________

### Recurso Auto Mapper

> Mapeamento automático. Criar um arquivo de configuração de Entidade para DTO e vice versa

[AutoMapper](https://github.com/AutoMapper/AutoMapper) funciona mapeando um tipo e um nome

Em `Console de Gerenciador de Pacotes` instalar:
- [x] Pam.AppMvc
- [x] PM> Install-Package AutoMapper -Version 10.1.1 (a ultima versão não funcionou)

Vamos configurar o pacote!

- [x] Em Pam.AppMvc, App_Start criar classe `AutoMapperConfig`

```css
using AutoMapper;
using Pam.AppMvc.ViewModels;
using Pam.Business.Models.Fornecedores;
using Pam.Business.Models.Produtos;
using System;
using System.Linq;
using System.Reflection;

namespace Pam.AppMvc.App_Start
{
    /* Classe para ativar o AutoMapper*/
    public class AutoMapperConfig
    {
        /*Config para encontrar qualquer classe que herde de Profile edo AutoMapper*/ 
        public static MapperConfiguration GetMapperConfiguration()
        {
            /*Coleção que herdam de Profile
             var profile onde através do objeto Assembly, na inicialização do projeto pega todos os Assemblys executados | 
             GetTyoe = vai obter os tipos deles
            Onde os tipos são do tipo Profile | E se está atribuido*/
            var profiles = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(x => typeof(Profile).IsAssignableFrom(x));

            return new MapperConfiguration(cfg =>
            {
                foreach (var profile in profiles)
                {
                    cfg.AddProfile(Activator.CreateInstance(profile) as Profile);
                }
            });

        }
    }
        /*classe de que herda do Profile do AutoMapper*/
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        {
            /*mapear das entidades para viewModel e ReverseMap(vice e versa)*/
            CreateMap<Fornecedor, FornecedorViewModel>().ReverseMap();
            CreateMap<Endereco, EnderecoViewModel>().ReverseMap();
            CreateMap<Produto, ProdutoViewModel>().ReverseMap();
        }
    }    
}
```

- [x] Em ProdutosController adicionar o AutoMapper através de uma interface

```css
using AutoMapper;

   private readonly IMapper _mapper;
```

- [x] Comentar:

```css
  /*_produtoRepository = new ProdutoRepository();
            _produtoService = new ProdutoService(_produtoRepository,new Notificador());*/
```            

- [x] Realizar:
    - mapeamentos
    - acima do Dispose, criar método ObterProduto

**Index**
```css
public async Task<ActionResult> Index()
            /*retornar uma lista de produtos ViewModel
             produtosVM = ProdutosViewModel*/
        {            
            return View(_mapper.Map<IEnumerable<ProdutoViewModel>>(await _produtoRepository.ObterTodos()));
        }
```
**Details**
```css
 public async Task<ActionResult> Details(Guid id)
        {            
            var produtoViewModel = await ObterProduto(id);
     
            if (produtoViewModel == null)
            {
                return HttpNotFound();
            }
            return View(produtoViewModel);
        }
```

**Create POST**
```css
 if (ModelState.IsValid)
            {
               await _produtoService.Adicionar(_mapper.Map<Produto>(produtoViewModel));
```

**Edit GET**
```css
 public async Task<ActionResult> Edit(Guid id)
        {

            var produtoViewModel = await ObterProduto(id);

            if (produtoViewModel == null)
            {
                return HttpNotFound(); 
            }

            return View(produtoViewModel);

        }
```

**Edit POST**

```css
   public async Task<ActionResult> Edit(ProdutoViewModel produtoViewModel)
        {
            if (ModelState.IsValid)
            {
                await _produtoService.Atualizar(_mapper.Map<Produto>(produtoViewModel));

                return RedirectToAction("Index");
            }
            return View(produtoViewModel);
        }

```

**Delete GET**
```css
 public async Task<ActionResult> Delete(Guid id)
        {
            var produtoViewModel = await ObterProduto(id);

            if (produtoViewModel == null)

            {                
                return HttpNotFound();
            }

            return View(produtoViewModel);
        }
```

**Delete POST**
```css
   public async Task<ActionResult> DeleteConfirmed(Guid id)
        {

            var produtoViewModel = await ObterProduto(id);

            if (produtoViewModel == null)

            {
                return HttpNotFound();
            }

            await _produtoService.Remover(id);

            return RedirectToAction("Index");
        }

```

**Adicionar Método ObterProduto**
```css
   private async Task<ProdutoViewModel> ObterProduto(Guid id)
        {
            var produto = _mapper.Map<ProdutoViewModel>(await _produtoRepository.ObterProdutosPorFornecedor(id));
            return produto;
        }
```

**Dispose**
```css
  if (disposing)
            {
                _produtoRepository.Dispose();
                _produtoService.Dispose();
            }
            base.Dispose(disposing);
```

___________________

### Criar atributos de Navegação/Rotas

- [X] Em ProdutosController, adicionar as Rotas de Navegação

Local | Rota
-|-
Index | [Route("lista-de-produtos")]
Details | [Route("dados_do_produto/{id:guid}")]
Create GET | [Route("novo-produto")] 
Create POST | [Route("novo-produto")] 
Edit GET | [Route("editar-produto/{id:guid}")]
Edit POST | [Route("editar-produto/{id:guid}")]
Delete GET | [Route("excluir-produto/{id:guid}")]
Delete POST | [Route("excluir-produto/{id:guid}")]

- [x] Adicionar `[HttpGet]` nos GET's
- [x] Adicionar `[ValidateAntiForgeryToken]` nos POST's

___________________

### Configurar o SimpleInjector














_______________

Item | Ação
-|-
Breakpoint | ?
? | Caso a instância não exista, não chama o método
Task | ?
Disposable | ?
! | ? (retornar negativo?)
`||` | ou
= | Recebe
== | igual
!= | Diferente
[Required] | Campo obrigatório
[DisplayName] | Nome que o usuário visualiza
public abstract | São protegidos (protected)
virtual | Em outros arquivos são chamados pelo overrride
PM> update-database -Script`: | Vai apresentar o Script das criações das tabelas







