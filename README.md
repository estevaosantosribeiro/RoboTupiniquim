# Robo Tupiniquim

![](https://i.imgur.com/h7WDhyz.gif)

## Sobre o projeto

A AEB (Agência Espacial Brasileira) entrou em contato com a turma da Academia do Programador para realização de um novo projeto. A agência está planejando uma expedição à Marte, mas antes, a AEB vai enviar uma nave espacial (codinome Tupiniquim I) tripulada com um Robô para fazer análises do planeta vermelho. Os alunos da 11a edição da Academia do Programador, reconhecidos como excelentes programadores, foram contratados para desenvolver o software que irá guiar o Robô nesta empreitada.

## Funcionalidades

- **Definição de tamanho da área**: O usuário pode definir qual será o tamanho da área em que os robôs irão se movimentar.
- **Definição de posição inicial**: O usuário define qual será a posição inicial de cada robô.
- **Movimentação por sequência de comandos**: A movimentação é feita por uma string contendo as instruções que cada robô deverá seguir.
- **Validação de entrada**: O algoritmo verifica se as instruções colocadas para o robô o deixam em uma posição válida ou não, caso contrário é exibida uma mensagem de erro.
- **Possibilidade de mover novamente**: Após realizadas as movimentações o programa pergunta se o usuário deseja mover os robôs novamente.

## Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para a compilação e execução do projeto.

## Como usar

1. Clone o repositório

```
git clone https://github.com/estevaosantosribeiro/RoboTupiniquim.git
```

2. Navegue até a pasta raiz do projeto:

```sh
cd RoboTupiniquim
```

3. Restaure as dependências:

```sh
dotnet restore
```

4. Compile o projeto:

```sh
dotnet build
```

5. Execute o programa:

```sh
dotnet run
```