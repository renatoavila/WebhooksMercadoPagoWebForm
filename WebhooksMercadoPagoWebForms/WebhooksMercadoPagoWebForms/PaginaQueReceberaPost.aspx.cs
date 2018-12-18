using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebhooksMercadoPagoWebForms.Models;
 
namespace WebhooksMercadoPagoWebForms
{
    public partial class PaginaQueReceberaPost : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
         
        [System.Web.Services.WebMethod]
        [System.Web.Script.Services.ScriptMethod(ResponseFormat = System.Web.Script.Services.ResponseFormat.Json)]
        public static string ReceberPostMercadoPago()
        {
            var jsonString = String.Empty;

            HttpContext.Current.Request.InputStream.Position = 0;
            using (var inputStream = new System.IO.StreamReader(HttpContext.Current.Request.InputStream))
            {
                jsonString = inputStream.ReadToEnd();
            }

            // Deserializar o objeto que veio no body (estou usando "Newtonsoft", mas pode ser qualquer outra biblioteca)
            ModeloDadosMercadoPago model = Newtonsoft.Json.JsonConvert.DeserializeObject<ModeloDadosMercadoPago>(jsonString);

            bool isValido = true; //TUDO OK???? SIM

            if(isValido) // Se deu tudo ok retorna sucesso pro mercado pago
            {
                HttpContext.Current.Response.Status = "200 OK"; 
                HttpContext.Current.Response.StatusCode = 200;
            }
            else //
            {
                // Outros possíveis StatusCode em: https://developer.mozilla.org/pt-BR/docs/Web/HTTP/Status
                HttpContext.Current.Response.Status = "500 Internal Server Error";
                HttpContext.Current.Response.StatusCode = 500;
            }

            HttpContext.Current.ApplicationInstance.CompleteRequest();

            return String.Empty;
        }
    }
}