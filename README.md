# Robo Tupiniquim

![](https://i.imgur.com/h7WDhyz.gif)

## Sobre o projeto

A AEB (Ag�ncia Espacial Brasileira) entrou em contato com a turma da Academia do Programador para realiza��o de um novo projeto. A ag�ncia est� planejando uma expedi��o � Marte, mas antes, a AEB vai enviar uma nave espacial (codinome Tupiniquim I) tripulada com um Rob� para fazer an�lises do planeta vermelho. Os alunos da 11a edi��o da Academia do Programador, reconhecidos como excelentes programadores, foram contratados para desenvolver o software que ir� guiar o Rob� nesta empreitada.

## Funcionalidades

- **Defini��o de tamanho da �rea**: O usu�rio pode definir qual ser� o tamanho da �rea em que os rob�s ir�o se movimentar.
- **Defini��o de posi��o inicial**: O usu�rio define qual ser� a posi��o inicial de cada rob�.
- **Movimenta��o por sequ�ncia de comandos**: A movimenta��o � feita por uma string contendo as instru��es que cada rob� dever� seguir.
- **Valida��o de entrada**: O algoritmo verifica se as instru��es colocadas para o rob� o deixam em uma posi��o v�lida ou n�o, caso contr�rio � exibida uma mensagem de erro.
- **Possibilidade de mover novamente**: Ap�s realizadas as movimenta��es o programa pergunta se o usu�rio deseja mover os rob�s novamente.

## Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para a compila��o e execu��o do projeto.

## Como usar

1. Clone o reposit�rio

```
git clone https://github.com/estevaosantosribeiro/RoboTupiniquim.git
```

2. Navegue at� a pasta raiz do projeto:

```sh
cd RoboTupiniquim
```

3. Restaure as depend�ncias:

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