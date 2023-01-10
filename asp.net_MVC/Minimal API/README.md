# Minimal API's

## Minimal API - Desenvoldor.IO
Criar um novo Projeto no Visual Studio 2022: `API Web do ASP.NET Core`

> Desmarcar: Usar controladores(desmarque para usar APIs mínimas)

### Conhecendo os arquivos


```html
<UserSecretsId>51f48ddb-5a9e-43f5-ad01-ac4abd2b3fcf</UserSecretsId>
    <DockerDefaultTargetOS>Linux</DockerDefaultTargetOS>
```

- [x] Em Properties no arquivo `launchSettigns` comentar a chamada do Docker

- [x] No arquvivo `Program.cs`
    - `var builder = WebApplication.CreateBuilder(args);`
        - Acesso ao container de DI;
        - Serviços que serão configurados no pipeline;
        - Forma de configuração do request        

```css
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Construção da API com os serviços acima adicionados
var app = builder.Build();

// Configuração do fluxo do request
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

//Mapeamento dos endpoints da aplicação, seria uma Action dentro de uma controLLeR (MAS NÃO EXISTE CONTROLLER)
///weatherforecast" = caminho do endPoint
app.MapGet("/weatherforecast", () =>
{
    //criando uma estrutura de dados para gerar um forecast (coleção) para listar os dados no consumo da chamada
    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateTime.Now.AddDays(index),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast");

// fim da aplicação
app.Run();

internal record WeatherForecast(DateTime Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
```

### Modelando a Entidade

```css
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();
```

- [x] Em DemoMinimalAPI criar repositório `Models`, dentro criar classe `Fornecedor.cs`

```css
namespace DemoMinimalAPI.Models
{
    public class Fornecedor
    {
        public Guid Id { get; set; }
        public string? Nome { get; set; }
        public string? Documento { get; set; }
        public bool Ativo { get; set; }
    }
}
```

> string? - ATENÇÂO a pontuação!!

Para versões antigas devemos tirar o `    <ImplicitUsings>enable</ImplicitUsings>` do arquivo principal.

### Configuração do EF

- [x] Em DemoMinimalAPI adicionar os pacotes do EF
```html
<ItemGroup>
		<PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer=" Version="6.0.3" />
		<PackageReference Include="Microsoft.EntityFrameworkCore.Tools" Version="6.0.3" />
		<PrivateAssets>all</PrivateAssets>
		<IncludeAssets>runtime; bukild; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
		</PackageReference>
```

- [x] Ou adicionar via `Console do Gerenciados de Pacotes`
    - Install-Package Microsoft.EntityFrameworkCore.SqlServer
    - Install-Package Microsoft.EntityFrameworkCore.Tools


- [x] Em DemoMinimalAPI criar repositório `Data`, dentro criar classe `MinimalContext.cs`

```css
using DemoMinimalAPI.Models;

namespace DemoMinimalAPI.Data
{
    public class MinimalContextDb : DbContext
    {
        public MinimalContextDb(DbContextOptions<MinimalContextDb> options) : base(options) { }

        public DbSet<Fornecedor> Fornecedores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Fornecedor>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<Fornecedor>()
                .Property(p => p.Nome)
                .IsRequired()
                .HasColumnType("varchar(200)");

            modelBuilder.Entity<Fornecedor>()
                .Property(p => p.Documento)
                .IsRequired()
                .HasColumnType("varchar(14)");

            modelBuilder.Entity<Fornecedor>()
                .ToTable("Fornecedores");

            base.OnModelCreating(modelBuilder);
        }
    }
}
```

### Criar o BD

- [x] Em `appsettings` adicionar `ConnectionString`

```css
"ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=MinimalApp;Trusted_Connection=True;MultipleActiveResultSets=true"
  },

  "AllowedHosts": "*",
  ```

- [x] Em `Program.cs` configurar o contexto para gerar a base

```css
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<MinimalContextDb>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
```

- [x] No Consolde de Pacotes rodar:
    - Primeiro comando `PM> add-migration Initial`
    - Segundo comando `PM> update-database`

### Mapear os métodos para expor os dados da API

- [x] Em `Program.cs` incluir:

```Css
app.UseHttpsRedirection();

//primeiro parâmetro é a rota "fornecedor"
//Fazendo um GET em Fornecedor receberemos uma lista de fornecedores
//segundo parâmetro é um delegate = ação 
app.MapGet("/fornecedor", async (
    MinimalContextDb context) => 
//iniciar a chamada
    await context.Fornecedores.ToListAsync())
    .WithName("GetFornecedores")
    //categoria
    .WithTags("Fornecedor");

//rota = "/fornecedor/{id} | async = assíncrona 
app.MapGet("/fornecedor/{id}", async (

//parâmetros que vai para (=>)
    Guid id,
    MinimalContextDb context) =>
    //Executa a ação de FindAsybc(id)
    await context.Fornecedores.FindAsync(id)
    is Fornecedor fornecedor
    // Se retornar um tipo fornecedor = OK 200
        ? Results.Ok(fornecedor)
        // Caso não, erro 404
        : Results.NotFound())
    //O que essa chamada produz
    //Produces e o tipo de objeto que ele vai produzir = Fornecedor
    .Produces<Fornecedor>(StatusCodes.Status200OK)
    .Produces(StatusCodes.Status404NotFound)
    .WithName("GetFornecedorPorId")
    .WithTags("Fornecedor");
```

### Criação de Endpoint Post (insert)

 [x] Em `Program.cs` incluir:

```Css
    .WithTags("Fornecedor");

   //inserir um fornecedor
app.MapPost("/fornecedor", async (
    MinimalContextDb context,
    Fornecedor fornecedor) =>
{
    context.Fornecedores.Add(fornecedor);
    //Se retornar > 0 afetou o registro
    var result = await context.SaveChangesAsync();
})
    .Produces<Fornecedor>(StatusCodes.Status201Created)
    .Produces(StatusCodes.Status400BadRequest)
    .WithName("PostFornecedor")
    .WithTags("Fornecedor");
```

### Validar Modelos
- [x] No Console de Pacotes rodar: `PM> Install-Package MIniValidation -Version 0.4.2-pre.20220306.48`
 
 - [x] Em `Program.cs` adicionar validação no MapPost:

 ```css
   //caso o MiniValidation não valide com sucesso = errors
    if (!MiniValidator.TryValidate(fornecedor, out var errors))
        //ValidationProblems retorna um 400 (badRequest) 
        return Results.ValidationProblem(errors);

    context.Fornecedores.Add(fornecedor); 
    var result = await context.SaveChangesAsync();

    return result > 0
        //Created retorna 201 e um caminho para este objeto
        //? (pode ser feito deste modo tbm) Results.Created($"/fornecedor/{fornecedor.Id}", fornecedor)
        ? Results.CreatedAtRoute("GetFornecedorPorId", new { id = fornecedor.Id }, fornecedor)
        //BadRequest erro 400
        : Results.BadRequest("Problema ao salvar o registro");

}).ProducesValidationProblem()
    .Produces<Fornecedor>(StatusCodes.Status201Created)
 ```

### Método MapPut

 - [x] Em `Program.cs` abaixo do método MapPost adicionar:

```css
//Faz o mesmo que o POST, porém com o ID da Rota e nos parâmetros
app.MapPut("/fornecedor/{id}", async (
        Guid id,
        MinimalContextDb context,
        Fornecedor fornecedor) =>
{
    var fornecedorBanco = await context.Fornecedores.FindAsync(id);
    if (fornecedorBanco == null) return Results.NotFound();

    if (!MiniValidator.TryValidate(fornecedor, out var errors))
        return Results.ValidationProblem(errors);

    context.Fornecedores.Update(fornecedor);
    var result = await context.SaveChangesAsync();

    return result > 0
        ? Results.NoContent()
        : Results.BadRequest("Problema ao salvar o registro");

}).ProducesValidationProblem()
    .Produces(StatusCodes.Status204NoContent)
    .Produces(StatusCodes.Status400BadRequest)
    .WithName("PutFornecedor")
    .WithTags("Fornecedor");
```

### Método MapDelete

- [x] Em `Program.cs` abaixo do método MapPut adicionar:

```css
app.MapDelete("/fornecedor/{id}", [Authorize] async (
    Guid id,
    MinimalContextDb context) =>
{
    var fornecedor = await context.Fornecedores.FindAsync(id);
    if (fornecedor == null) return Results.NotFound();

    context.Fornecedores.Remove(fornecedor);
    var result = await context.SaveChangesAsync();

    return result > 0
        ? Results.NoContent()
        : Results.BadRequest("Problema ao salvar o registro");

}).Produces(StatusCodes.Status400BadRequest)
.Produces(StatusCodes.Status204NoContent)
.Produces(StatusCodes.Status404NotFound)
.WithName("DeleteFornecedor")
.WithTags("Fornecedor");
```

### Teste Swagger CRUD
Ao realizar os testes e no PUT ocorrer o `Error: response status is 500` ajustar em `Program.cs` método MapPut:

De:
```css
 var fornecedorBanco = await context.Fornecedores.FindAsync(id);
```

Para:
```css
    var fornecedorBanco = await context.Fornecedores.AsNoTracking<Fornecedor>()
                                                    .FirstOrDefaultAsync(f=>f.Id == id);
```

Ao realizar os testes e no DELETE ocorrer o `Error: response status is 500` ajustar em `Program.cs` método MapDelete:

DEU ERROOOOOOOO

### Implementação do Login e autenticação do usuário

- [x] No Console de Pacotes rodar: `PM> Install-Package NetDevPack.Identity`

- Em `Program.cs` adicionar:

```css
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddIdentityEntityFrameworkContextConfiguration(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
    b => b.MigrationsAssembly("DemoMinimalAPI")));

    builder.Services.AddIdentityConfiguration();
    builder.Services.AddJwtConfiguration(builder.Configuration, "AppSetting");


```

E, acima do "UseHttpredirection" adicionar 

```css
app.UseAuthConfiguration();
``` 

- Em `appsetting.json` adicionar acima de "AllowedHosts"

```js
  "AppSettings": {
    "SecretKey": "MYSECRETSUPERSECRET",
    "Expiration": 2,
    "Issuer": "MinimalPilot",
    "Audience": "https://localhost"
  },
```

- [x] Em `Program.cs` incluir:

```css
builder.Services.AddIdentityConfiguration();
builder.Services.AddJwtConfiguration(builder.Configuration, "AppSettings");
```

- [x] No Consolde de Pacotes rodar para criar as tabelas do BD:
   
    - Primeiro comando `Add-Migration AuthInitial -Context NetDevPackAppDbContext`
    - Segundo comando `Update-database -Context NetDevPackAppDbContext`

### Métodos para registrar e logar usuário

**mapeamento do endpoint para criar o usuário MapPost(registro)**

- Em `Program` acima de MAPGET incluir:

```css
app.MapPost("/registro", async (
    SignInManager<IdentityUser> signInManager,
    UserManager<IdentityUser> userManager,
    IOptions<AppJwtSettings> appJwtSettings,
    RegisterUser registerUser) =>
{
    if (registerUser == null)
        return Results.BadRequest("Usuário não informado");

    if (!MiniValidator.TryValidate(registerUser, out var errors))
        return Results.ValidationProblem(errors);

    var user = new IdentityUser
    {
        UserName = registerUser.Email,
        Email = registerUser.Email,
        EmailConfirmed = true
    };

    var result = await userManager.CreateAsync(user, registerUser.Password);

    if (!result.Succeeded)
        return Results.BadRequest(result.Errors);

    //o usuário deu certo, criação do token
    var jwt = new JwtBuilder()
                .WithUserManager(userManager)
                .WithJwtSettings(appJwtSettings.Value)
                .WithEmail(user.Email)
                .WithJwtClaims()
                .WithUserClaims()
                .WithUserRoles()
                .BuildUserResponse();

    return Results.Ok(jwt);

}).ProducesValidationProblem()
  .Produces(StatusCodes.Status200OK)
  .Produces(StatusCodes.Status400BadRequest)
  .WithName("RegistroUsuario")
  .WithTags("Usuario");
```

**mapeamento do endpoint para criar o usuário MapPost(login)**

- Em `Program` abaixo de MapPost(registro) incluir:

```css
app.MapPost("/login", /*[AllowAnonymous]*/ async (
    SignInManager<IdentityUser> signInManager,
    UserManager<IdentityUser> userManager,
    IOptions<AppJwtSettings> appJwtSettings,
    LoginUser loginUser) =>
{
    if (loginUser == null)
        return Results.BadRequest("Usuário não informado");

    if (!MiniValidator.TryValidate(loginUser, out var errors))
        return Results.ValidationProblem(errors);

    var result = await signInManager.PasswordSignInAsync(loginUser.Email, loginUser.Password, false, true);

    if (result.IsLockedOut)
        return Results.BadRequest("Usuário bloqueado");

    if (!result.Succeeded)
        return Results.BadRequest("Usuário ou senha inválidos");

    var jwt = new JwtBuilder()
                .WithUserManager(userManager)
                .WithJwtSettings(appJwtSettings.Value)
                .WithEmail(loginUser.Email)
                .WithJwtClaims()
                .WithUserClaims()
                .WithUserRoles()
                .BuildUserResponse();

    return Results.Ok(jwt);

}).ProducesValidationProblem()
  .Produces(StatusCodes.Status200OK)
  .Produces(StatusCodes.Status400BadRequest)
  .WithName("LoginUsuario")
  .WithTags("Usuario");
```

**Solução de Erro!!!**

> System.InvalidOperationException: 'Unable to find the required services. Please add all the required services by calling 'IServiceCollection.AddAuthorization' in the application startup code.'


Adicionar `builder.Services.AddRazorPages();` no início do Program.cs

### Autorização de métodos

 `[AllowAnonyumous]`: Pode ser acessado por qualquer usuário
 `[Authorize]` - Usuário precisa estar logado

- [x] Incluir `[AllowAnonyumous]` depois da chave:
    - ("/registro", ;
    - ("/login", ; 
    - MapGet("/fornecedor, ;

- [x] Incluir `[Authorize]` depois da chave:
    - MapPost("/fornecedor" ;
    - MapPut("/fornecedor/{id}", ;
    - MapDelete("/fornecedor/{id}"

- Em `Program.cs` abaixo de "AddJwtConfiguration" adicionar:

```cs
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("ExcluirFornecedor",
        policy => policy.RequireClaim("ExcluirFornecedir"));
});
```

- Em MapDelete adicionar em Produces: metódo policy é chamada neste momento:

```cs
.RequireAuthorization("ExcluirFornecedor")
.WithName("DeleteFornecedor")
```

- Em SQL Server Objects abrir a tabela do `AspNetUseClaims`, clicar em ViewData:


**Site de Leitura de Token**

Na aplicação em login, copiar o token:

![image](https://user-images.githubusercontent.com/108991648/210563390-f3edee6f-014d-491d-b6b9-7a14ba366c37.png)

No site [JTT IO](https://jwt.io/) colar o token:

![image](https://user-images.githubusercontent.com/108991648/210564858-17102e36-e172-4d41-bd05-26e50167b472.png)

```cs
{
  "email": "teste@teste.com",
  "password": "Teste@123"
}

{
  "accessToken": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiI5OWE3ZTFjMS02MTczLTQ5YTctOTY4Ny01MjI0NWQxYWQwNDkiLCJlbWFpbCI6InRlc3RlQHRlc3RlLmNvbSIsImp0aSI6ImEzZmFiMjczLTFhNDItNGE0MS1hOGQzLWQ5MDdhYjc3ODc3OCIsIm5iZiI6MTY3Mjg0NjQ3NCwiaWF0IjoxNjcyODQ2NDc0LCJFeGNsdWlyRm9ybmVjZWRvciI6IkV4Y2x1aXJGb3JuZWNlZG9yIiwiZXhwIjoxNjcyODUzNjc0LCJpc3MiOiJNaW5pbWFsUGlsb3QiLCJhdWQiOiJodHRwczovL2xvY2FsaG9zdCJ9.talSgBOYvav88Hn40bDKf6wB9_Pwmt-wrm8ZAF9NNMQ",
  "expiresIn": 7200,
  "userToken": {
    "id": "99a7e1c1-6173-49a7-9687-52245d1ad049",
    "email": "teste@teste.com",
    "claims": [
      {
        "value": "ExcluirFornecedor",
        "type": "ExcluirFornecedor"
      }
    ]
  },
  "refreshToken": null
}
```

### Suporte a JWT no Swagger

- [x] Em `Program.cs` em `builder.Services.AddSwaggerGen();` adicionar (incluir todo o método abaixo do policy)

```cs
  policy => policy.RequireClaim("ExcluirFornecedor"));
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c => 

{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Minimal API Sample",
        Description = "Developed by Eduardo Pires - Owner @ desenvolvedor.io",
        Contact = new OpenApiContact { Name = "Eduardo Pires", Email = "contato@eduardopires.net.br" },
        License = new OpenApiLicense { Name = "MIT", Url = new Uri("https://opensource.org/licenses/MIT") }
    });

    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = "Insira o token JWT desta maneira: Bearer {seu token}",
        Name = "Authorization",
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[] {}
        }
    });
});

var app = builder.Build();
```

**Gerou o botou de Authorize!**

- [x] Temos um usuário com a Claim, criaremos outro sem a Claim:

```cs
{
  "email": "pamela@eteste1.com",
  "password": "P@m123",
  "confirmPassword": "P@m123"
}


 "accessToken": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxZmY1MmJmNC0yZjU3LTRlY2YtYTkxMy05MWVhYzNlMmNiZGIiLCJlbWFpbCI6InBhbWVsYUBldGVzdGUxLmNvbSIsImp0aSI6IjZiZjk3N2ZkLTQxNjEtNGY2YS04MDE4LTVmODBiYmIwM2Q5YyIsIm5iZiI6MTY3MjgzODM2OSwiaWF0IjoxNjcyODM4MzY5LCJleHAiOjE2NzI4NDU1NjksImlzcyI6Ik1pbmltYWxQaWxvdCIsImF1ZCI6Imh0dHBzOi8vbG9jYWxob3N0In0.p4o-CDZyHPsLXPXRY-b1Fy531tcx3mlQyURZkQVcXuw",
  "expiresIn": 7200,
  "userToken": {
    "id": "1ff52bf4-2f57-4ecf-a913-91eac3e2cbdb",
    "email": "pamela@eteste1.com",
    "claims": []
  },
```

- [x] Utilizar o token do 2º usuário, clicando no botão de Authorize.
    - Adicionar "Bearer + espaço + token
    - Fazer um POST em fornecedor

```cs
{
  "id": "3fa85f64-5717-4562-b3fc-2c963f66afa4",
  "nome": "Pamela Rondina",
  "documento": "12345678911",
  "ativo": true
}
```

### Organizar o projeto

- [x]~Em `Program.cs` ajustar:
    - Adicionar `region Configure Services` abaixo de `var builder = WebApplication.CreateBuilder(args);`
    - Finalizar região após `var app = builder.Build();` com `endregion`
    <br>
    - Abaixo de `endregion` criar `#region Configure Pipeline`, e após `app.Run();` incluir `#endregion`
<br>
    - criar método para mapear as Actions, no final de tudo e incluir todos os app: 
        - app.MapPost("/registro",
        - app.MapPost("/login",
        - app.MapGet("/fornecedor",
        - app.MapGet("/fornecedor/{id}",
        - app.MapPost("/fornecedor", 
        - app.MapPut("/fornecedor/{id}",
        - app.MapDelete("/fornecedor/{id}",
        - e transformar tudo em uma região: `region Actions`
        
    ```cs
void MapActions(WebApplication app)
{
    ```





_______________________________________

**Code** | **Descrição**
-|-
200 |	OK e pode retornar informação
204	| Apenas OK
400	|Bad request
401	|Não autorizado
403	|Acesso negado
404	|Não encontrado
500	|Família 500, erro interno no servidor


_________________________________


[Desenvolvendo uma Minimal APIs - Canal Desenvolvedor.IO](https://www.youtube.com/watch?v=aXayqUfSNvw)
[Eduardo Pires - Minimal-API](https://github.com/EduardoPires/Minimal-API)
[Damian Edwards - Mini Validation](https://github.com/DamianEdwards/MiniValidation)
[NetdevPack - Security.Identity](https://github.com/NetDevPack/Security.Identity)
[Leitura de Token](https://jwt.io/)


EXCLUIDO:
  <PackageReference Include="Microsoft.VisualStudio.Azure.Containers.Tools.Targets" Version="1.17.0" />

__________________________________

## Minial API - Alura

Criar um novo Projeto no Visual Studio 2022: `ASP.NET Core Vazio`

> .NET 6.0
> Desmarcar: Habilitar o Docker

Adicionar diretório `Model`, classes `Pessoa` e `RepositorioDePessoas`

Em Pessoa:
```cs
namespace Alura.MinimalAPI.Model
{
    public class Pessoa
    {
        public Pessoa()
        {
            Identificador = Guid.NewGuid();
        }
        public Guid Identificador { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string CPF { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }
}
```
Em RepositorioDePessoas:
```cs
namespace Alura.MinimalAPI.Model
{
    public class RepositorioDePessoas
    {
        public RepositorioDePessoas(bool dados)
        {
            if (dados)
            {
                CriarDadosEmMemoria();
            }
            else
            {
                ListaPessoas = new List<Pessoa>();
            }
        }

        private void CriarDadosEmMemoria()
        {

            this.ListaPessoas = new List<Pessoa>()
            {
                new Pessoa()
                {
                    Nome = "André Silva",
                    CPF = "123456789-12",
                    Email ="andresilva@email.com"
                },
                new Pessoa()
                {
                    Nome = "Pedro Malazartes",
                    CPF = "182993692-12",
                    Email ="pedromala@email.com"
                },
                new Pessoa()
                {
                    Nome = "Maria Joaquina",
                    CPF = "987351984-12",
                    Email ="mariajoaquina@email.com"
                }
            };
        }

        public List<Pessoa> ListaPessoas { get; set; }

        public Pessoa AdicionarPessoas(Pessoa p)
        {
            ListaPessoas.Add(p);
            return p;
        }

        public bool RemoverPessoas(string cpf)
        {
            var pessoaTemp = (from pessoa in this.ListaPessoas
                              where pessoa.CPF == cpf
                              select pessoa).SingleOrDefault();
            if (pessoaTemp == null)
            {
                return false;
            }
            var removido = ListaPessoas.Remove(pessoaTemp);
            return removido;
        }

        public List<Pessoa> SelecionarPessoas()
        {
            return this.ListaPessoas;
        }

        public Pessoa SelecionarPessoa(string cpf)
        {
            var pessoaTemp = (from pessoa in ListaPessoas
                              where pessoa.CPF == cpf
                              select pessoa).SingleOrDefault();
            if (pessoaTemp == null)
            {
                return new Pessoa();
            }
            return pessoaTemp;
        }

        public bool AtualizarPessoas(Pessoa p)
        {
            var pessoaTemp = (from pessoa in this.ListaPessoas
                              where pessoa.CPF == p.CPF
                              select pessoa).SingleOrDefault();
            if (pessoaTemp == null)
            {
                return false;
            }

            pessoaTemp.Identificador = p.Identificador;
            pessoaTemp.Nome = p.Nome;

            return true;
        }

    }
}
```

### Global usings

> importações das bibliotecas básicas que usarmos, já estão habilitadas no arquivo principal (nome do projeto)

```html
<Project Sdk="Microsoft.NET.Sdk.Web">

  <PropertyGroup>
    <TargetFramework>net6.0</TargetFramework>
    <Nullable>enable</Nullable>
    <ImplicitUsings>enable</ImplicitUsings>
  </PropertyGroup>

</Project>

```

Com isso, o projeto acompanha as bibliotecas:

```cs
System.Net.Http.Json
Microsoft.AspNetCore.Builder
Microsoft.AspNetCore.Hosting
Microsoft.AspNetCore.Http
Microsoft.AspNetCore.Routing
Microsoft.Extensions.Configuration
Microsoft.Extensions.DependencyInjection
Microsoft.Extensions.Hosting
Microsoft.Extensions.Logging

System.Collections.Generic
System.IO
System.Linq
System.Net.Http
System.Threading
System.Threading.Task
```

### Classe Program.cs

**Configuração do Swagger**

- [x] Em “Ferramentas”> “Gerenciador de pacotes do Nuget” > “Gerenciador de pacotes do NuGet para essa solução…” Adicionar pacote `Swashbuckle.AspNetCore`, escolher o projeto e instalar.

- [x] Em `Program.cs` adicionar:
```cs
using Alura.MinimalAPI.Model;

var builder = WebApplication.CreateBuilder(args);

//Habilitando o SWAGGER
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

//instanciando o repositório em memória
var repositorio = new RepositorioDePessoas(true);

app.UseSwagger();//Ativando o Swagger

//Endpoints de solução
app.MapGet("/", () => "Hello World!");

// Listar todas as pessoas
app.MapGet("/ListaPessoas/{cpf}", (string cpf) =>
{
    return repositorio.SelecionarPessoa(cpf);
});

//Adicionar pessoa
app.MapPost("/ListaPessoa/adicionar", (Pessoa pessoa) =>
{
    return repositorio.AdicionarPessoas(pessoa);
});

//Atualizar pessoa.
app.MapPut("/ListaPessoas/atualizar", (Pessoa pessoa) => {
    return repositorio.AtualizarPessoas(pessoa);
});

//Remover pessoa.
app.MapDelete("/ListaPessoas/remover", (string cpf) => {
    return repositorio.RemoverPessoas(cpf);
});

app.UseSwaggerUI();// Ativando a interface Swagger

app.Run();
```

**Referências**

[Alura - Minial API](https://github.com/alura-cursos/Alura.MinimalAPI)
________________________________

## Minimal API Pizzaria - Microsoft

### Configurar o projeto

Criar um novo Projeto pelo terminal CMD, localizar o local onde deseja salvar:

> dir: lista os diretórios
> cd + nome: entra no diretório

`dotnet new web -o PizzaStore -f net6.0`

Entrar na pasta:
`cs PizzaStore`

Adicionar Pacote:
`dotnet add package Swashbuckle.AspNetCore --version 6.2.3`

Criar um arquivo e abrir o VSCode:
`code Pizza.cs`

```cs
namespace PizzaStore.Models 
{
    public class Pizza
    {
          public int Id { get; set; }
          public string? Name { get; set; }
          public string? Description { get; set; }
    }
}
```
> A classe Pizza anterior é um objeto simples que representa uma pizza. Esse código é seu modelo de dados

- [x] Em `Program.cs` adicionar:

```cs
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
     c.SwaggerDoc("v1", new OpenApiInfo {
         Title = "PizzaStore API",
         Description = "Making the Pizzas you love",
         Version = "v1" });
});

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(c =>
{
   c.SwaggerEndpoint("/swagger/v1/swagger.json", "PizzaStore API V1");
});

app.MapGet("/", () => "Hello World!");

app.Run();
```

### Adicionar o EF Core ao projeto

No VSCode abra um terminal `Ctrl + '` para adicionar pacote `dotnet add package Microsoft.EntityFrameworkCore.InMemory --version 6.0`

- [x] Adicione `using Microsoft.EntityFrameworkCore;` à parte superior dos arquivos Program.cs e Pizza.cs.

- [x] Crir uma classe `PizzaDb.cs`

- [x] Em `Pizza.cs` (acima do } final). adicione:

```cs
class PizzaDb : DbContext
{
    public PizzaDb(DbContextOptions options) : base(options) { }
    public DbSet<Pizza> Pizzas { get; set; } = null!;
}
```

>DbContext representa uma conexão ou sessão usada para consultar e salvar as instâncias das entidades em um banco de dados.

- [x] Adicione using PizzaStore.Models; à parte superior do arquivo Program.cs.

- [x] Em `Program.cs`:
    - Antes da chamada para AddSwaggerGen, adicione:

```cs
builder.Services.AddDbContext<PizzaDb>(options => options.UseInMemoryDatabase("items"));
```

### Retornar uma lista de itens

    - Antes de app.Run, adicione:
```cs
app.MapGet("/pizzas", async (PizzaDb db) => await db.Pizzas.ToListAsync());
```

>Para ler de uma lista de itens na lista de pizzas

### Exeutar o Aplicativo

- No terminal: `dotnet run` 
- Na saída aparecerá `http://localhot:7049` (podendo der qualquer númeração)
- Clique no link e adicione: `https://localhost:7049/swagger/`

>Se quiser substituir o comportamento de seleção de porta aleatória, você poderá definir as portas a serem usadas em launchSettings.json.

> Para parar de rodar a aplicação no terminal `Ctrl+C`

### Criar itens

> adicionar novos itens à lista de pizzas.

- [x] Em `Program.cs` adicione abaixo de app.MapGet(/"pizzas):

```cs
app.MapPost("/pizza", async (PizzaDb db, Pizza pizza) =>
{
    await db.Pizzas.AddAsync(pizza);
    await db.SaveChangesAsync();
    return Results.Created($"/pizza/{pizza.Id}", pizza);
});
```

### Testar a API

- No terminal: `dotnet run` 
- Na saída aparecerá `http://localhot:7049` (podendo der qualquer númeração)
- Clique no link e adicione: `https://localhost:7049/swagger/`
- Para adicionar dados: Post/pizza > Try it out > Adicione os dados > Execute
- Para ler os dados: Get/pizza > Tru it out > Execute > Responde body (teve ter informações inclusas)
- No terminal, parar a aplicação `Ctrl+C`

### Obter um único item

> Para GET (OBTER) um item por id

```css
app.MapGet("/pizza/{id}", async (PizzaDb db, int id) => await db.Pizzas.FindAsync(id));
```

### Atualizar um item

> Atualizar um item existente

- [x] Em `Program.cs` adicionar abaixo da rota GET/pizza{id}

```cs
app.MapPut("/pizza/{id}", async (PizzaDb db, Pizza updatepizza, int id) =>
{
      var pizza = await db.Pizzas.FindAsync(id);
      if (pizza is null) return Results.NotFound();
      pizza.Name = updatepizza.Name;
      pizza.Description = updatepizza.Description;
      await db.SaveChangesAsync();
      return Results.NoContent();
});
```

### Excluir um item

> Para excluir um item existente

```cs
app.MapDelete("/pizza/{id}", async (PizzaDb db, int id) =>
{
   var pizza = await db.Pizzas.FindAsync(id);
   if (pizza is null)
   {
      return Results.NotFound();
   }
   db.Pizzas.Remove(pizza);
   await db.SaveChangesAsync();
   return Results.Ok();
});
```
### Configurar o banco de dados SQLite

Há suporte para outros bancos de dados [Suporte BD EF Core](https://learn.microsoft.com/pt-br/ef/core/providers/?tabs=dotnet-core-cli)

1) No terminal, instalar pacote: `dotnet add package Microsoft.EntityFrameworkCore.Sqlite --version 6.0`

2) No terminal, instalar pacote: `dotnet tool install --global dotnet-ef`

> Ferramentas EF Core: ferramentas para EF Core realizar tarefas de desenvolvimento de tempo de design. Por exemplo, eles criam migrações, aplicam migrações e geram código para um modelo com base em um banco de dados existente.

3) No terminal instalar pacote: `dotnet add package Microsoft.EntityFrameworkCore.Design --version 6.0`

> Microsoft.EntityFrameworkCore.Design: contém toda a lógica de tempo de design para o EF Core criar seu banco de dados.

### Habilitar a criação do banco de dados

- Em `Program.cs`, em `var builder = WebApplication.CreateBuilder(args);`adicione:

> Esse código verifica o provedor de configuração em busca de uma cadeia de conexão chamada Pizzas. Se ele não encontrar uma, usará Data Source=Pizzas.db como a cadeia de conexão. O SQLite mapeará isso para um arquivo.

**Substituição de banco de dados de memória para persistente**

De: 
> dados salvos em memória
```cs
builder.Services.AddDbContext<PizzaDb>(options => options.UseInMemoryDatabase("items"));
```

Para:
> dados salvos no BD
```cs
builder.Services.AddSqlite<PizzaDb>(connectionString);
```

**Início da criação - BD**

- 1ª etapa: criar a migração

Salve todas as alterações e no terminal inclua: `dotnet ef migrations add InitialCreate`

> Será criado um diretório `Migrations` com dois arquivos

- 2º etapa: concluir a migração

No terminal inclua: `dotnet ef database update`

### Questionário:

1. Qual das afirmações a seguir é verdadeira sobre o EF (Entity Framework) Core?

Ele é uma tecnologia de acesso a dados leve, extensível e de plataforma cruzada para aplicativos .NET.

2. Qual das afirmações a seguir descreve como uma classe de entidade é usada no EF Core?

Cada classe representa um objeto de negócios em seu aplicativo e geralmente é mapeado para uma única tabela de banco de dados.

3. Qual etapa é usada para criar o banco de dados SQLite?

Executar o comando dotnet ef database update depois de criar uma ou mais migrações.
________________________

## Minimal API - Patrick God

Criar um novo Projeto no Visual Studio 2022: `API Web do ASP.NET Core`

> Desmarcar: Usar controladores(desmarque para usar APIs mínimas)

### Modelando a Entidade - MODEL

```cs
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//Para teste:
app.MapGet("/", () => "Desenvolvedora Full Stack em andamento...");

app.Run();
```

- [x] Criar diretório `Models`e criar classe para inserirmos os dados:

```css
namespace MinimalAPIPG.Models
{
    public class SuperHero
    {

        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Sobrenome { get; set; }
        public string? Nome_Heroi { get; set; }
    }
}
```

### Configurando o EF

- [x] Adicionar Pacotes
    - Install-Package Microsoft.EntityFrameworkCore
    - Install-Package Microsoft.EntityFrameworkCore.Design
    - Install-Package Microsoft.EntityFrameworkCore.SqlServer
    - dotnet tool uninstall --global dotnet-ef
    - dotnet tool install --global dotnet-ef

    - [x] Em `appsettings.json` incluir:
    ```cs
    {
    "ConnectionStrings": {
      "DefaultConnection": "server=(localdb)\\mssqllocaldb; database=MinimalAPIPG; trusted_connection=true"
    
  },
  ```

  - [x] Criar diretório `Data`, dentro criar classe `DataContext.cs`






__________________________

Referências
[Minimal API - Microsoft](https://learn.microsoft.com/pt-br/training/modules/build-web-api-minimal-database/6-knowledge-check)
[Documentação EF Core - Banco de Dados Suportados](https://learn.microsoft.com/pt-br/training/modules/build-web-api-minimal-database/4-add-sqlite-database-provider)

[Patrick God - Minimal API](https://www.youtube.com/watch?v=NhWMx5atpms)
[Patrivk God - GitHUb - Minimal API](https://github.com/patrickgod/MinimalAPITutorial)