using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebhooksMercadoPagoWebForms.Models
{
    public class ModeloDadosMercadoPago
    {
        public int id { get; set; }
        public bool live_mode { get; set; }
        public string type { get; set; }
        public DateTime date_created { get; set; }
        public int user_id { get; set; }
        public string api_version { get; set; }
        public string action { get; set; }
        public Data data { get; set; }
    }

    public class Data
    {
        public string id { get; set; }
    }

}