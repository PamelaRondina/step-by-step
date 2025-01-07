# Mermaid

Fluxograma na Vertical



```mermaid
graph TD
    A[Inicio do Programa]
    A-->B[Instrucción 1]
    B-->C[Instrucción 2]
    C-->D[Instrucción 3]
    D-->E[Fin del Programa]
```
____

```mermaid
graph LR
A[Inicio] -->B(Asignar el valor 10 a la variable 'numero')
    B --> C{El numero es mayor que 5?}
    C -->|Sí| D[Mostrar 'El número es mayor que 5']
    D --> E[Fin]
    C -->|No| E    
```

---------


## Título

3 -
title: nome
3 -

## Estilo 

- graph
- flowcharts

## Horizontal ou Vertical

Nome | Descrição
-|-
graph TD | gráfico na Vertical
graph LR | gráfico na Horizontal 

## Linhas

**A --> B**

## ([Inicio])


```mermaid
graph TD
A([Inicio]) 
```

## (Retangular)

```mermaid
graph TD
  A(Retangular)
```

## { Losango }

```mermaid
graph TD
    A{Losango}
    
```
-----------

Site | Link
-|-
Mermaid.js | [Link](https://mermaid.js.org/syntax/flowchart.html)