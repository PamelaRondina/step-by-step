## React.js

[Documentação](https://pt-br.legacy.reactjs.org/)

O que é React?
É uma biblioteca JavaScript para a criação de interfaces de usuário. Criada pelo Facebook, 2011.

**Framework x Biblioteca**

> Biblioteca recurso para facilitar, compartilhar soluções por meio de funções ou métodos.

Exemplos:
- Moment.js -> manipulação de datas;
- Chart.js -> lida com gráficos;
- Voca -> 
- Mo.js
- React -> facilita criação de interface
- Vue ->

> Framework é uma ferramenta que ajuda a desenvolver o projeto, não em detalhes de configuração

Exemplos:
- Next.js -> utilizado para criação de sites simples.
- Angular -> é do Google
- Vuex -> 
- Ionic ->
- Express ->
- LoopBack -> 

<hr>

## Criar um novo Projeto

- [x] No Terminal:

> npx: baixa a versão mais atualizada do NPM

```bash
npx create-react-app nomeProjeto
yes
```

- Será criada uma pasta com o nome escolhido.

Pasta | O que tem?
- |-
node_modules | dependências e bibliotecas (não será alterada)
public | arquivos principais do React
src | Onde fica todo o projeto

Em public, `index.html`, limpar comentários +:
~~~html

<link rel="icon" href="%PUBLIC_URL%/favicon.ico" />
  <meta name="theme-color" content="#000000" />

      <meta
      name="description"
      content="Web site created using create-react-app"
    />

     <link rel="apple-touch-icon" href="%PUBLIC_URL%/logo192.png" />

    <link rel="manifest" href="%PUBLIC_URL%/manifest.json" />
~~~

Em src, `index.js`, limpar comentários +: 
~~~js
import reportWebVitals from './reportWebVitals';
import './index.css';

reportWebVitals();
~~~

Para rodar:
~~~bash
npm run start
~~~

<hr>

## Componentes de Classes 

> Método mais antigo, não utilizado na versão 17 do React

~~~js
import React, { Component } from "react";

export default class AppClass extends Component {
    constructor(props) {
        super(props);
        this.state = { counter: 0};
        this.handleClick = this.handleClick.bind(this);
    }

    handleClick() {
        //TODO
    }
}

render() {
    retunr <div>AppClass</div>
}
~~~

Funcionar:

~~~js
const handleCklic = () => {
    // TODO
}
~~~

<hr>

## Criar Componente

- Em src, criar pasta `componentes`, dentro arquivo `index.js`
- `rfc` -> estrutura de um componente
- Na versão 17 do React pode-se deletar: `import React from 'react'`

~~~js
//Podendo ser feito assim:
import React from 'react'

export default function index() {
  return (
    <div>index</div>
  )
}

//Ou assim:

export default function Button(props) {
const { title } = props;

    return       <button>{title}</button>;
}
~~~

**{} recebe propriedades = props

- Em, App.js, vamos importar o componente Button criado:

~~~js
import Button from './components/Button';
~~~

No return, não podemos retornar dois objetos, ou seja, duas <tgas> lado a lado, o jsx retorna apenas 1 componente, para isso temos duas saídas:

~~~js
//Desta forma não é aceita!!
function App() {
  return (
  <div className="App">Olá React</div>;
  <button></button>
  );
}

export default App;
~~~
1º saída: tag fantasma `<> </>.`

~~~js
import Button from './components/Button';

function App() {
  return (<>
  <div className="App">Olá React</div>
  <button></button>
  </>
  );
}

export default App;
~~~

2ª saída: 

> No React é obrigatório fechar as tags </>

~~~js
import Button from './components/Button';

function App() {
  return (
  <div className="App">
    <h1>Olá React</h1>
    <Button title="Entrar"/>
    <Button title="Fechar"/>
    <Button title="Abrir"/>
    <Button title="Salvar"/>
  </div>

  );
}

export default App;
~~~

<hr>

## Ciclo de Vida de um Componente

![image](https://github.com/PamelaRondina/PamelaRondina/assets/108991648/c0fe519c-a49c-4ac8-91cd-4119957ea3a6)

Componentes Lifecycle | Drescição
-|-
constructor | início da construção 
1) getDerivedStateFromProps |
2) componentDidMount |
3) shouldComponentUpdate |
4) render |
5) getSnapshotBeforeUpdate |
6) componentDidUpdate |
7) componentWillUnmount |

***VERIFICAR MELHOR ESTE PONTO!!**

<hr>

https://www.treinaweb.com.br/blog/qual-a-diferenca-entre-framework-e-biblioteca