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



<hr>

**Comandos: JavaScript** | **Descrição**
:-|:-
// | Comentário
= | Recebe
== | Igual
!= | Diferente
&& | E
{ } | Bloco
< script > | Iniciar linguagem JavaScript
var | variável
**Funções**| ---------
alert("texto") | Cria um *pop up* de alerta
prompt("texto") | Pop up para o usuário inserir um resultado, retorna o resultado como string
parseInt("texto")| Converte uma string para número
parseFloat("Texto")| Converte uma string em casas decimais
if("texto") { "texto" } | Se 
else | Se não
while | Enquanto / repetição
for | Laço de Repetição
++ | variável + 1
break | Quebra um looping (while)
Math.round() | arredondar o resultado
Math.random() | Número aleatório
console.log() | Resultado aparece no console do Browser
**Erros**| ----------
NaN | Não é um número