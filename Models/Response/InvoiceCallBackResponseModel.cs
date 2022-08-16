using System;

namespace Platform.Payment.Models.Response
{
    public class InvoiceCallBackResponseModel
    {
        public string notification_type { get; set; }
        public string amount { get; set; }
        public string response_code { get; set; }
        public DateTime request_expiry_date { get; set; }
        public string payment_link_id { get; set; }
        public string signature { get; set; }
        public string merchant_identifier { get; set; }
        public string payment_option { get; set; }
        public string order_description { get; set; }
        public string access_code { get; set; }
        public string customer_phone { get; set; }
        public string language { get; set; }
        public string payment_link { get; set; }
        public string service_command { get; set; }
        public string response_message { get; set; }
        public string merchant_reference { get; set; }
        public string customer_email { get; set; }
        public string currency { get; set; }
        public string customer_name { get; set; }
        public string status { get; set; }
    }
}
