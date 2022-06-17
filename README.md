# Softplan Challenge
Teste técnico da Softplan.

Esse teste técnico consistiu em **duas APIs**, chamadas aqui de __API 1__ e __API 2__.

A **API 1**, possui apenas um endpoint, chamado de <em>taxasJuros</em>, que retorna sempre um único valor (0.01), apenas para consumo da outra API.

![image](https://user-images.githubusercontent.com/32681498/174210745-bb3b091e-99a6-418e-a16e-dbeb1b697b45.png)

![image](https://user-images.githubusercontent.com/32681498/174211157-99ae52b9-a88e-4847-bbe8-d63c040187d0.png)


Já a **API 2** possui dois endpoints. O primeiro, chamado de <em>calculaJuros</em>, consome o endpoint da primeira API, e aplica um cálculo de juros compostos em cima do valor retornado e de mais dois parâmetros passados por query string, <em>valorinicial</em> e <em>meses</em>.

![image](https://user-images.githubusercontent.com/32681498/174212138-e116d1ec-d799-4df3-9e6d-ceed32b7208a.png)

![image](https://user-images.githubusercontent.com/32681498/174212382-932ee96f-63e1-42e5-aacf-4a0105982e72.png)


O segundo endpoint chamado de <em>showMeTheCode</em>, retorna o endereço do repositório no GitHub.

![image](https://user-images.githubusercontent.com/32681498/174212479-287c60eb-6e85-42f5-af7f-a0510a41abe2.png)


Além das APIs, o projeto também fez uso de alguns recursos presentes na documentação, que foi o **upload no GitHub, utlização do Swagger, Teste Unitário e Teste de integração**.
O Swagger pode ser vistos nos prints acima, já o teste unitário está na validação do cálculo matemático dos juros compostos, como pode ser visto logo abaixo:

![image](https://user-images.githubusercontent.com/32681498/174212850-aadec446-4cf6-4977-979b-37decc914a33.png)


E por último, o Teste de integração foi uma página web consumindo as duas APIs.

![image](https://user-images.githubusercontent.com/32681498/174219122-745cbab8-e9aa-4b6c-bdfd-355308a36066.png)

Para realizar os testes, é preciso rodar as duas APIs localmente, nas portas locais 8001 e 8002.
