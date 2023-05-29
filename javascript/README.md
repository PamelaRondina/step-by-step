# O que é JavaScript?

> Linguagem de Programação, auxilia com as interações nas páginas web tornando-as mais dinâmicas.

Em uma página estática, incluir elementos como mapas, formulários, operações numéricas, animações, infográficos interativos e muito mais.

<hr>

## Variáveis
Espaços que se reserva na memória para arquivar valores:

Para nomear uma variável:
  - Deve começar com uma letra ou com underline (_);
    - Para o seu início não são aceitos números ou caracteres especiais;
  - Caracteres subsequentes podem ser letras;
  - JavaScript é case-sensitive, diferencias letras maiúsculas e minúsculas

  **Tipos de Variáveis**

  ```js
var nome = 'Pamela' //menos utilizada
let idade = 31; // pode alterar o valor
const aprovado = true; //não pode alterar diretamente o seu valor
  ```

<hr>
## Estruturas Condicionais Básicas

**if** | **else**

```js
const idade = 31;

if (idade > 18) {
  console.log("Maior que 18");
} else {
  console.log("Menor que 18")
}
```

```js
const nota = 7;

if (nota < 5) {
  console.log("Abaixo da média");
} else if (nota > 5 && nota <= 7) {
  console.log("Na média");
} else {
  console.log("Acima média")
}
```

**switch**
```js
const nota = 7;

switch (nota) {
  case nota < 5:
    console.log("Abaixo da média");
    break;
  case nota > 5 && nota <= 7:
    console.log("Na média");
    break;
   default:
    console.log("Acima média");
}
```

**ternario** 
- if reduzido

```js
const nota = 7;

nota > 5 ? console.log("aprovado") : console.log("reprovado");
```

<hr>

## Laço de Repetição

**for**
Vai se repetir até uma determinada condição:

```javascript
for(início; quantidade de repetição; informações) {

    mostra(7 * multiplicador);
}
```
-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->

```javascript
for( let i = 0; i < 10; i++ ) {
    alert( "O resultado é " + (2 * i) );
}
```
```javascript
for(let i = 1; i <= 10; i++ ) {
    console.log(`${i} x 5 = ${i * 5}`);
}
```

**while**

```javascript
let x = 1;
while (x < 10) {
  console.log(`${x} x 5 = ${x * 5}`);
  x++;
}
```
```javascript
var multi = 1;
while(multi <= 10) {
    mostra(7 * multi);
    multi = multi + 1
}

mostra("FIM");
```

```javascript
var i = 0;
while( i < 10) {
    alert( "O resultado é " + (2 * i) );
    i++;    
}
```
**forEach**

```js
const.valores = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
valores.forEach((value)) => {
  console.log(`${value} x 5 = ${value * 5}`);
}
```

**map**
Resultado em uma array, utilizada para manipular cálculos, fazer validação e retornar o valor par auma nova variável.

```js
const valores2 = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
const result = valores.map((value)) => {
  return value * 5;
}
```
<hr>

## Function

Recebeca parâmetros, faça uma tratativa e retorne para quem chamou a função.

```js
function Soma(num1 + num2) {
  return num1+num2
}
```

## Arrow Function

Foi criada em 2015, sintaxe que lembra uma flecha `() =>`

```js
const soma = (num1 + num2) => num1 + num2
```

<hr>

**Array**

São listas de objetos.

```javascript
var segredos = [1, 3, 4, 7, 9];
```
- `nomeArray.push('itemNovo');` -> Empurrar um novo item para uma array já criada
- `nomeArray[posição4] = 'NovoNome'` -> Adicionar item na Array pela posição
- `nomeArray.pop()` -> Vai eliminar  o ultimo item de uma Array
- `nomeArray.shift()` -> Eliminar  o primeiro item de uma Array
- `nomedaArray.length`-> Retorna a quantidade de elementos que uma Array possui

<hr>
## Funcionalidades do ES6+ 

**filter**
Filtrar determinado valor 

``` js
const alunosFiltrados = alunos.filter((aluno) => aluno.idade >= 18);
console.table(alunosFiltrados);
```

**find** 
Buscar algo específico, retorna o primeiro item solicitado (mesmo que tenham outros iguais)

``` js
const alunoRoberto = alunos.find((aluno) => aluno.nome === Roberto);
console.log(alunoRoberto);
```
**findIndex**
Retorna em qual posição da array o objeto está

```js
const alunoRobertoIndex = alunos.findIndex((aluno) => aluno.nome === Roberto);
console.log(alunoRobertoIndex);
```

**reduce**
Com os itens da array fazer um cálculo

```js
const idades= alunos.reduce((acc, alun) => {
  return acc + aluno.idade;
}, 0);
console.log(idades);
```
**some** e **every**
Utilizados para validação:
- some: retorna true se alguma condição for verdadeira;
- every: retorna true se todas as condições forem verdadeiras.

```js
const acimaDeNove = alunos.some(alunos => alunos.idade < 10);
const menorQueNoventa = alunos.every(alunos => alunos.idade < 90);
console.log(acimaDeNove);
console.log(menorQueNoventa);
```

<hr>

## Método toggle

- Abrir e fechar uma modal com um trailer

```js
botaoTrailer.addEventListener("click", () => {
    //1.4: abrir a modal na tela
    //classlist = propriedade
    modal.classList.add("aberto"); 
    video.setAttribute("src", linkDoVideo);   
});

//2.2: identificar quando o usuário clicar no "X"
botaoFecharModal.addEventListener("click", () => {
    //2.3: fechar a modal
    modal.classList.remove("aberto");
    //2.4: remover audio do trailer
    //setAtribute = separar um atributo (no caso o src do video | link do Trailer)
    video.setAttribute("src", "");
});
```

Neste caso, podemos criar uma função:

```js
function alternarModal(){
       //classlist = propriedade
    modal.classList.toggle("aberto"); 
}

// 1.2. - identificar quando o usuário clicar no botão
// quando clicar no botão Trailer vai executar 
botaoTrailer.addEventListener("click", () => {
    //1.4: abrir a modal na tela - chamar a função
    alternarModal();   
    video.setAttribute("src", linkDoVideo);   
});

//2.2: identificar quando o usuário clicar no "X"
botaoFecharModal.addEventListener("click", () => {
    //2.3: fechar a modal
    alternarModal(); 
    //2.4: remover audio do trailer
    //setAtribute = separar um atributo (no caso o src do video | link do Trailer)
    video.setAttribute("src", "");
});
```

_____________

**Se conter menos de 2 caracteres faça isso, se não, faça aqui**

```js

let nome = document.querySelector('#nome')
let labelNome = document.querySelector('#labelNome')

nome.addEventListener('keyup', () => {
  if(nome.value.length <= 2){
    labelNome.setAttribute('style', 'color: red')
    labelNome.innerHTML = 'Nome *Insira no mínino 3 caracteres'
    nome.setAttribute('style', 'border-color: red')
    
  } else {
    labelNome.setAttribute('style', 'color: green')
    labelNome.innerHTML = 'Nome'
    nome.setAttribute('style', 'border-color: green')
  }
})
```

____________

**Senhas iguais - Confirmar senha**

```js
senha.addEventListener('keyup', () => {
  if(senha.value.length <= 5){
    labelSenha.setAttribute('style', 'color: red')
    labelSenha.innerHTML = 'Senha *Insira no mínino 6 caracteres'
    senha.setAttribute('style', 'border-color: red')
    
  } else {
    labelSenha.setAttribute('style', 'color: green')
    labelSenha.innerHTML = 'Senha'
    senha.setAttribute('style', 'border-color: green')
  }
})
```



<hr>

**Comandos: JavaScript** | **Descrição**
:-: |:-
`&&` | AND (e)
`||` | OR (ou)
`=` | Recebe 
`==` | Igual
`===` | Exatamente Igual
`!=`  | Diferente
`!===` | Exatamente Diferente
`>` `<` | Maior e Menor que
`?` | Então
`:` | Se não
`//` | Comentário linha
`/* texto */` | Comentário bloco
`{ }` | Bloco
`< script >` | Iniciar linguagem JavaScript
`var` | variável
`if ( ) { }` | Se 
`else if` | Se não se (para continuar uma análise)
`else` | Se não
`while` | Enquanto / repetição
`for` | Laço de Repetição
`++` | variável + 1
`break` | Quebra um looping (while)
`array` | conjusta da lista
`%` | Resto da Divisão
`+-` | concatenar

_________________

**Funções** | Descrição
- | -
`function teste () { }` | Chamar função
`console.log()` | Imprime algo
`console.table` | Imprime dados em uma tabela
`let nomeVariavel = 10;` | declarar variável (valor pode ser alterado)
`const pi = 3.14;` | declarar variável (valor NÃO pode ser alterado) 
`console.log(resultado).toFixed(2));` | **toFixed** converte o valor para texto e imprime com dois algorítimos após a casa decimal
`const isNumeroPar = (numero % 2) === 0` | (isNomeVariavel) utilizado para declarar variáveis booleanas
`nomeArray.push('itemNovo');`|Para empurrar um novo item para uma array já criada
`nomeArray[posição4] = 'NovoNome'` | Adicionar item na Array pela posição
`nomeArray.pop()` | Vai eliminar  o ultimo item de uma Array
`nomeArray.shift()` | Eliminar  o primeiro item de uma Array
`nomedaArray.length`| Retorna a quantidade de elementos que uma Array possui

alert("texto") | Cria um *pop up* de alerta
prompt("texto") | Pop up para o usuário inserir um resultado, retorna o resultado como string
parseInt("texto")| Converte uma string para número
parseFloat("Texto")| Converte uma string em casas decimais
document.write()| imprime na tela 
document.querySelector| puxa as informações do HTML, necessário incluir nos **(" ")**
input.value | compara com a lacuna criada
input.focus();| O cursor do mouse foca na lacuna criada pelo input/
button.onclick()| compara ao clicar no botão criado
Math.round() | arredondar o resultado
Math.random() | Número aleatório
_____________

Biblioteca | Descrição
- | -
`Math.pow(altura,2)` | Calcular ao quadrado (ou ao cubo3, e assim vai...)
____________________

**Erros**| ----------
- | -
NaN | Não é um número