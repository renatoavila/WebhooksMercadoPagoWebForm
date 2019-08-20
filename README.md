# Webhooks do Mercado Pago usando WebForms
[![Build status](https://ci.appveyor.com/api/projects/status/t50jmbb34x8g84e1/branch/master?svg=true)](https://ci.appveyor.com/project/renatoavila/webhooks-mercado-pago-webforms/branch/master)

Exemplo simples de como uma página para receber um post do Mercado Pago usando WebForms

referência [https://www.mercadopago.com.br/developers/pt/solutions/payments/custom-checkout/webhooks/](https://www.mercadopago.com.br/developers/pt/solutions/payments/custom-checkout/webhooks/)

O post deve ser realizado em: [http://localhost:62902/PaginaQueReceberaPost.aspx/ReceberPostMercadoPago](http://localhost:62902/PaginaQueReceberaPost.aspx/ReceberPostMercadoPago)

Com os seguintes dados no body:

`{ "id": 12345, "live_mode": true, "type": "payment", "date_created": "2015-03-25T10:04:58.396-04:00", "user_id": 44444, "api_version": "v1", "action": "payment.created", "data": { "id": "999999999" } }`

Deixo como sugestão o uso do [PostMan](https://www.getpostman.com/) para os testes
