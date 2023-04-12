# O que é JavaScript?

> ************


FOR:

```javascript
for( var i = 0; i < 10; i++ ) {
    alert( "O resultado é " + (2 * i) );
}
```

```javascript
for(início; quantidade de repetição; informações) {

    mostra(7 * multiplicador);
}
```

```javascript
for(var valor = 1; valor <= 10; valor++) {

    mostra(7 * multiplicador);
}
```

```javascript
for(var multiplicador = 1; multiplicador <= 10; multiplicador++) {

    mostra(7 * multiplicador);

}

mostra("FIM");
```

WHILE:

```javascript
var multiplicador = 1;

while(multiplicador <= 10) {

    mostra(7 * multiplicador);
    multiplicador = multiplicador + 1
}

mostra("FIM");
```

```javascript
var i = 0;
while( i < 10) {
    alert( "O resultado é " + (2 * i) );
    i++;    
}
Uma linguagem de programação.
```

**Array**

São listas

```javascript
var segredos = [´1, 3, 4, 7, 9];
```
<hr>

**Método toggle**

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
// | Comentário linha
/* texto */ | Comentário bloco
= | Recebe 
=== | Igual
!= | Diferente
&& | E
{ } | Bloco
< script > | Iniciar linguagem JavaScript
var | variável
if ( ) { } | Se 
else if | Se não se (para continuar uma análise)
else | Se não
while | Enquanto / repetição
for | Laço de Repetição
++ | variável + 1
break | Quebra um looping (while)
array | conjusta da lista
% | Resto da Divisão

_________________

**Funções** | Descrição
- | -
`function teste () { }` | Chamar função
`console.log()` | Imprime algo
`let nomeVariavel = 10;` | declarar variável (valor pode ser alterado)
`const pi = 3.14;` | declarar variável (valor NÃO pode ser alterado) 
`console.log(resultado).toFixed(2));` | **toFixed** converte o valor para texto e imprime com dois algorítimos após a casa decimal
`const isNumeroPar = (numero % 2) === 0` | (isNomeVariavel) utilizado para declarar variáveis booleanas 

alert("texto") | Cria um *pop up* de alerta
prompt("texto") | Pop up para o usuário inserir um resultado, retorna o resultado como string
parseInt("texto")| Converte uma string para número
parseFloat("Texto")| Converte uma string em casas decimais
**nomedaarray**.length|retorna a quantidade de elementos que uma array possui
**nomedaarray**.push(**itemnono**)|Para empurrar um novo item para uma array já criada
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