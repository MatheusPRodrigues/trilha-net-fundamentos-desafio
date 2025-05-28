# DIO - Trilha .NET - Fundamentos
www.dio.me

## Desafio de projeto
Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de fundamentos, da trilha .NET da DIO.

## Contexto
Você foi contratado para construir um sistema para um estacionamento, que será usado para gerenciar os veículos estacionados e realizar suas operações, como por exemplo adicionar um veículo, remover um veículo (e exibir o valor cobrado durante o período) e listar os veículos.

## Proposta
Você precisará construir uma classe chamada "Estacionamento", conforme o diagrama abaixo:
![Diagrama de classe estacionamento](diagrama_classe_estacionamento.png)

A classe contém três variáveis, sendo:

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


## Implementações
Foi realizada todas as alterações solicitadas no desafio de projeto da DIO, sendo completados os métodos da classe Estacionamento para atender da melhor forma as regras de négocio do projeto.

Ademais foram feitas 2 adições e 1 alteração no projeto, sendo elas:
- <b>Método ListarVeiculos foi reaproveitado dentro no corpo do método RemoverVeiculo:</b> Isso foi feito para quando o usuário for remover o veículo do estacionamento, as placas sejam exibidas, assim auxiliando de forma mais efitiva o fluxo do programa se dar dá forma correta.

- <b>Método privado para verificar a placa:</b> implementação do método private VerificarPlaca(string placa):bool, para garantir que as placas cadastradas sigam o formato dado de exemplo na vídeo aula. Ex: ABC-1234.

- <b>Alteração do dotnet utilizado no projeto:</b> como as aulas foram gravadas há algum tempo, o dotnet utilizado no projeto estava desatualizado. Portanto alterei o dotnet do projeto para versão 8.0 que é a que estou utilizando mais