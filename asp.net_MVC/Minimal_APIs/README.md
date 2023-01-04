## Minimal API's

Criar um novo Projeto no Visual Studio 2022: `API Web do ASP.NET Core`

> Desmarcar: Usar controladores(desmarque para usar APIs mínimas)

### Conhecendo os arquivos

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
    Install-Package Microsoft.EntityFrameworkCore.SqlServer
    Install-Package Microsoft.EntityFrameworkCore.Tools


 [x] Em DemoMinimalAPI criar repositório `Data`, dentro criar classe `MinimalContext.cs`

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
    - Primeiro comando `PM> 
    
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

### Autorização de métodos**

 `[AllowAnonyumous]`: Pode ser acesso por qualquer usuário
 `[Authorize]` - precisa estart logado

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



_________________________________


[Desenvolvendo uma Minimal APIs - Canal Desenvolvedor.IO](https://www.youtube.com/watch?v=aXayqUfSNvw)
[Damian Edwards - Mini Validation](https://github.com/DamianEdwards/MiniValidation)
[NetdevPack - Security.Identity](https://github.com/NetDevPack/Security.Identity)