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

## Conceitos Fundamentais 

### JSX

Forma de criar elementos para serem utilizados como templates de aplicações React. Próximo ao HTML.

- Estrutura de HTML dentro de uma função (return) de Javascript
- Função que retorna um elemento, JSX
- teve ter um elemento pai e seus filhos: `<div>` (pai); `<h1>` (filho)

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
~~~

- Para fazer calculos, incluimos o {} dentro da estrutura de JSX, com isso passará a ser um JS.

~~~js
function App() {
  return (
  <div className="App">
    <h1>Olá React</h1>
    <p>1 +1 {1 + 1}</p>
    <Button title="Entrar"/>
    <Button title="Fechar"/>
    <Button title="Abrir"/>
    <Button title="Salvar"/>
  </div>
~~~

- Utilizando uma array:
  - `arr` = array;

~~~js
const App = () => {
  const arr = [1, 2, 3, 4, 5, 6, 7, 8, 9];
  return (
    <div classNaeme="App">
    <h1>Hello DIO!</h1>
    {arr.map((item) => (
      <p>
        {item} * 5 = {item * 5}
      </p>
    ))}
    </div>
    );
  };

  export default App;
~~~


-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->

### Componentes de Classes X Componentes Funcionais

> Componentes de Classe: método mais antigo, não utilizado na versão 17 do React

modelo 1: componente de classe:
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

modelo 1: componente funcional:
~~~js
const handleCklic = () => {
    // TODO
}
~~~

modelo 2: componente de classe:
~~~js
import React, { Component } from "react";

class App extends Component {
  state = {
    usuarios: ["Pamela", "Rondina"],
  };

  render() {
    const { usuarios } = this.state;
    return (
      <dic className="App">
        <h1>Hello DIO!</h1>
        {usuarios.map((item) => (
          <p>{item}</p>
        ))}
        </div>
      );
    }
  }  
~~~

modelo 2: componente funcional:
~~~js
import React, { useState } from "react";

class App = () => {
  
  const [usuarios, setUsuarios] = useStat(["Pamela", "Rondina"]);

  return (
    <dic className="App">
      <h1>Hello DIO!</h1>
      {usuarios.map((item) => (
        <p>{item}</p>
      ))}
      </div>
    );
  }  
~~~

-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->-->
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

`useEffetc` -> Assim que o meu componente for redenrizado em tela, eu quero um tipo de ação:
- primeiro parâmetro recebe uma função
- segundo parâmetro recebe uma array de dependências
~~~js
useEffect((função) => {
}, [array de dependências])
~~~

Neste modelo, a cada mudança, a renderização é feita na página toda. No caso, no `input` a cada informação digitada a página inteira irá renderizar.
~~~js
import React, { useState, useEffect } from "react";

const App = () => {
  const [usuario, setUsuario] = useState("");
  const [count, setCount] = useState(0);
  const [usuarios, setUsuarios] = useState(["Pamela", "Rondina", "Bruno"]);

  const handleAddUser = () => {
    //... todos os dados da array anteior + usuario novo
    setUsuarios([...usuarios, usuario]);
    // usuário não precisará apagar as informações criadas
    setUsuario("");
  };

    useEffect(() => {
    setCount(usuarios.length);
  }, [usuarios]);

  return (
    <div className="App">
      <h1>Hello DIO!</h1>
      <h3>Total: {count}</h3>
      <div>
        <input
        value={usuario}
        onChange={(event) => setUsuario(event.target.value)}
        />
        <button onClick={handleAddUser}>Adicionar</button>  
      </div>
      <hr/>
      {usuarios.map((item) => (
        <p>{item}</p>
      ))}
    </div>
  )
}

export default App;
~~~




<hr>

## Criar um novo Projeto

- [x] No Terminal:

> npx: baixa a versão mais atualizada do NPM

```bash
npx create-react-app nomeProjeto
yes
```

- [x] Projeto do GitHub, rodar:
  - Isso ocorre pois a pasta `node_modules` não sobre para o GitHUb devido ser pesada e não subir por causa do `.gitignore`
~~~bash
npm i 
~~~

- Será criada uma pasta com o nome escolhido.

Pasta | O que tem?
- |-
node_modules | dependências e bibliotecas (não será alterada)
public | arquivos principais do React
src | Onde fica todo o projeto
.gitignore | arquivos que não serão feitos push para o GitHub

- [x] Realizar limpeza: 
  - Em public, eliminar arquivos que não serão utilizados: favicon, logos, manifest, robot;
  - Em public, `index.html`, limpar comentários, `head`;

No `index` o projeto será redenrizado em:
~~~html
<div id="root"></div>
~~~

- [x] Realizar limpeza:
  - Em src, eliminar arquivos que não serão utilizados;
  - Em src, `index.js`, import QUE SÃO NECESSÀRIOS!

~~~js
import React from 'react'; // MANTER
import ReactDOM from 'react-dom/client'; // MANTER
import './index.css'; // folha de estilização 
import App from './App'; // MANTER - OBRIGATÓRIO (onde está rodando a aplicação)
import reportWebVitals from './reportWebVitals'; 
~~~

Para rodar o projeto:
~~~bash
npm run start
~~~

**Entendendo a renderização**
No arquivo `index.html` possui a `<div id="root">`;

No arquivo `index.js`, `document.getElementById('root'));` (Pegue o meu elemento com ID = root ), o `render`, recebe 2 paràmetros, o que será e onde será renderizado.

Podendo ser deletado:
~~~js
 <React.StrictMode> 
  </React.StrictMode> 
~~~

No arquivo, `index.js`, o componente `<App/>`,  será renderizado no `document.getElementById('root'));`

Em `App.js` será construído o componente. Neste local que será feito a visualização do site. Podemos refatorar e iniciar um novo projetom conforme abaixo:

**Arrow Function**
~~~js
const App = () => {
  return(
    <h1>Hello World!</h1>
  )
}

export default App;
~~~

OU,

~~~js
function App() {
  return (
    <h1>Hello World!</h1>
  )
}

export default App;
~~~

OU:

~~~js
export defaul const App = () => {
  return(
    <h1>Hello World!</h1>
  )
}
~~~

<hr>

## Elementos Pais e Filhos/Irmãos
O retorno de qualquer componente não é aceito, dentro de `return` elementos que sejam irmãos, mas aceita um elemento pai e diversos irmãos;

**Formato NÃO ACEITO** (dois elementos irmãos `<div>` e `<button>`)
~~~js
function App() {
  return (
  <div className="App">Olá React</div>;
  <button></button>
  );
}

export default App;
~~~

**FORMATOS ACEITOS**
1º saída: REACT FRAGMENT `<> </>.`
~~~js
function App() {
  return(
    <>
  <h1>Hello World!</h1>
  <p>Eu sou um parágrafo</p>
  </>  
  )
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

## Criar Componente

- Em src, criar diretório `components`;
- Dentro de `components`, criar diretórios com os nomes necessários e em cada um o arquivo `index.js`;
- Em cada `index.js`, podemos criar o componente via `rfc` ou `arrow function`
- O nome do componente deve iniciar com letra maiúscula: `Assim` e `AssimTambém`:

**rfc**
- [x] estrutura de um componente
- [x] Na versão 17 do React, pode-se deletar: `import React from 'react'`

~~~js
import React from 'react'

export default function index() {
  return (
    <div>index</div>
  )
}
~~~

**Arrow Function**

~~~js
const nomeComponente = () => {
  return(
     <div>index</div>
  )
}
~~~

- Em, `App.js`, vamos importar e chamar o componente criado:

~~~js
//IMPORTAR COMPONENTE
import Item from './components/Item'

const App = () => {
  return(
    <>
    <h1>Hello World!</h1>
    <ul>
    /*CHAMAR COMPONENTE*/
      <Item/>
      <Item/>
      <Item/>      
     </ul>
    </>
  )
}

export default App;
~~~

<hr>
## Criando um Container 

- [x] Em `index.html` adicionar na tag body:

Antes:

![image](https://github.com/PamelaRondina/PamelaRondina/assets/108991648/c1f3e6ce-a67e-442a-a9e0-de255e236265)

~~~html
  <body class='container'>
~~~

Depois:
![image](https://github.com/PamelaRondina/PamelaRondina/assets/108991648/b11960ed-a7fa-4d02-ac8d-1cf17d15c562)


<hr>
### Utilizando o Bootstrap

- [x] Buscar links do CSS e do BUNDLE, [Link](https://getbootstrap.com/docs/5.3/getting-started/introduction/)

- [x] Link CSS -> colar acima do `title`
- [x] Link BUNDLE -> colar acima do `</body>`

<hr>

https://www.treinaweb.com.br/blog/qual-a-diferenca-entre-framework-e-biblioteca

React | Descrição
- | -
className | As classes devem conter o Name
</> | Obrigatório fechar as tags </>
NomeComponente | Sempre a primeira letra Maiúsucla
