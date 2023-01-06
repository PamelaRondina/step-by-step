using Alura.MinimalAPI.Model;

var builder = WebApplication.CreateBuilder(args);

//Habilitando o swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

//instanciando o repositório em memória.
var repositorio = new RepositorioDePessoas(true);

app.UseSwagger();// Ativando o Swagger

// Endpoints da solução
app.MapGet("/", () => "Hello World!");

// Listar todas as pessoas.
app.MapGet("/ListaPessoas", () => {
    return repositorio.SelecionarPessoas();
});

//Buscar pessoa pelo CPF.
app.MapGet("/ListaPessoas/{cpf}", (string cpf) => {
    return repositorio.SelecionarPessoa(cpf);
});

//Adicionar pessoa.
app.MapPost("/ListaPessoas/adicionar", (Pessoa pessoa) => {
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
