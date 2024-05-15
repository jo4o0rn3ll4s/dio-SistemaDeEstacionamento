# Descrição

Neste Projeto de LAB você será desafiado a construir um sistema para um estacionamento, que será usado para gerenciar os veículos estacionados e realizar suas operações, como por exemplo adicionar um veículo, remover um veículo (e exibir o valor cobrado durante o período) e listar os veículos.

Agora é a sua vez de ser o protagonista! Implemente o desafio sugerido pela expert criando um repositório próprio e, com isso, aumentando ainda mais seu portfólio de projetos no GitHub!

#### Pré-requisitos:

- Lógica de Programação e POO;

- Conhecimentos Básico(.NET, Git, GitHub);

- Computador com SO de sua preferência(Windows, Linux, Mac OS);

- Ferramentas de Desenvolvimento (IDE)

# GitHub DIO - Trilha .NET - Fundamentos

Todo código-fonte desenvolvido durante o projeto foi versionado no GitHub, no seguinte endereço:

https://github.com/digitalinnovationone/trilha-net-fundamentos-desafio

www.dio.me

## Desafio de projeto

Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de fundamentos, da trilha .NET da DIO.

## Contexto

Você foi contratado para construir um sistema para um estacionamento, que será usado para gerenciar os veículos estacionados e realizar suas operações, como por exemplo adicionar um veículo, remover um veículo (e exibir o valor cobrado durante o período) e listar os veículos.

## Proposta

Você precisará construir uma classe chamada "Estacionamento", conforme o diagrama abaixo:

<div align="center">
    
![image](https://github.com/jo4o0rn3ll4s/Sketchs_dotnet/assets/65920201/e7fb2efa-530f-4e97-bde0-6a6025335e92)
    
</div>

#### A classe contém três variáveis, sendo:

**precoInicial**: Tipo decimal. É o preço cobrado para deixar seu veículo estacionado.

**precoPorHora**: Tipo decimal. É o preço por hora que o veículo permanecer estacionado.

**veiculos**: É uma lista de string, representando uma coleção de veículos estacionados. Contém apenas a placa do veículo.

A classe contém três métodos, sendo:

**AdicionarVeiculo**: Método responsável por receber uma placa digitada pelo usuário e guardar na variável **veiculos**.

**RemoverVeiculo**: Método responsável por verificar se um determinado veículo está estacionado, e caso positivo, irá pedir a quantidade de horas que ele permaneceu no estacionamento. Após isso, realiza o seguinte cálculo: **precoInicial** * **precoPorHora**, exibindo para o usuário.

**ListarVeiculos**: Lista todos os veículos presentes atualmente no estacionamento. Caso não haja nenhum, exibir a mensagem "Não há veículos estacionados".

Por último, deverá ser feito um menu interativo com as seguintes ações implementadas:

    1. Cadastrar veículo
    2. Remover veículo
    3. Listar veículos
    4. Encerrar

**Bons estudos**
