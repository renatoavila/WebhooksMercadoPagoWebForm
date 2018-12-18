<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebhooksMercadoPagoWebForms.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" lang="pt-br">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous" />

    <title>Webhooks do Mercado Pago usando WebForms</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container m-5">
            <h1>Webhooks do Mercado Pago usando WebForms</h1>
            <p>Exemplo simples de como uma página para receber um post do Mercado Pago usando WebForms </p>
            <p>referência <a target="_blank" href="https://www.mercadopago.com.br/developers/pt/solutions/payments/custom-checkout/webhooks/">https://www.mercadopago.com.br/developers/pt/solutions/payments/custom-checkout/webhooks/</a>  </p>
            <p>O post deve ser realizado em: <a target="_blank" href="http://localhost:62902/PaginaQueReceberaPost.aspx">http://localhost:62902/PaginaQueReceberaPost.aspx</a> </p>
            <p>Com os seguintes dados no body:</p>
            <p>
                <code>{ 
                        "id": 12345,
                        "live_mode": true,
                        "type": "payment",
                        "date_created": "2015-03-25T10:04:58.396-04:00",
                        "user_id": 44444,
                        "api_version": "v1",
                        "action": "payment.created",
                        "data": {
                                     "id": "999999999"
                                }
                    }
                </code>
            </p>
            <p>
                Deixo como sugestão o uso do <a href="https://www.getpostman.com/" target="_blank">PostMan</a> para os testes
            </p>
            <p>
                Renato Ávila
            </p>

        </div>
    </form>
</body>
</html>
