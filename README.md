# Conversor de Moedas em WinForm integrado com API para gerar a cotação em tempo real

Essa é uma solução para buscar o conhecimento em consumir uma API pública da HG Brasil, nela usamos apenas a conversão de Dólar para Real, em tempo real, o intuíto foi para o aprendizado de como consumir uma API pública.

# Visão Geral

Projeto realizado mentoria no qual participo, é o quarto desafio, o desafio foi realizar o consumo de uma API pública, usando o WinForms como interface com o usuário, verificar quais conceitos, pacotes, e o raciocínio lógico para realizar essa conversam de moedas em tempo real.

## O Desafio

Conceitos e funções que não havia trabalho, Json Deserialize, e precisei instalar o pacote Newtown.Json para pode prosseguir com o projeto.

* Lidar com URL, como se fosse um endpoint quando criamos uma API
* Definir as propriedades como Json
* Utilizar o método GetAsync para buscar as informações da URL
* Foi construído duas classes, uma para criar as propriedades do valor de compra, venda, e variação do dólar, a outra classe para instanciar a primeira classe, como herança e criar a propriedade da primeira classe, e realizei um construtor chamando o método para que cada vez que aquela classe for solicitada, ela chame a primeira classe instanciada.

# Screenshots

### Formato do WinForms
![image](https://user-images.githubusercontent.com/113942505/221687019-d4d07234-85c5-4b8d-8f4a-93021c249dbe.png)

### Primeira Classe - Moeda Corrente
![image](https://user-images.githubusercontent.com/113942505/221687278-aee5802c-416d-402f-b975-870c4da60672.png)

### Segunda Classe - Mercado Financeiro
![image](https://user-images.githubusercontent.com/113942505/221687383-7178e0a7-4e5a-4c80-b236-e2c307faf1f7.png)

### Código do Btn Form
![image](https://user-images.githubusercontent.com/113942505/221687805-0dd7ad11-e82b-4feb-94d9-388ddcb14dd8.png)

### Resultado do projeto com a conversão do dólar em tempo real
![image](https://user-images.githubusercontent.com/113942505/221688165-42599c6e-6f35-4a07-b674-e7113610f886.png)

# O que eu aprendi?

* Como utilizar o Deserializer Json
* Como converter uma URL para string
* Aplicação do Using [HTTPClient]
* Utilização do "IsSuccesStatusCode" para realizar uma condição e gerar as informações no form
* Cada processo aprendo um pouco mais sobre Debug's
* Realizar as JsonProperty
* Como formatar as Labels no formato moeda corrente e porcentagem e jogar as informações nelas
* Mais uma aplicação utilizando o Try/Catch

# Autor

* LinkedIn - [Conrado Vincoletto](www.linkedin.com/in/conradovincoletto)





