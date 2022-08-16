using System;
using Platform.Payment.Enums;

namespace Platform.Payment.Models.Response
{
    public class InvoicePayResponseModel
    {
        public PaymentEngine PaymentEngine { get; set; }

        public bool IsValid { get; set; }
        public string ResponseMessage { get; set; }
        public string ResponseCode { get; set; }
        public string PaymentLink { get; set; }
        public string PaymentLinkId { get; set; }
        public PayFortResponseStatusEnum Status { get; set; }
        public PayFortResponseStatusEnum TransactionStatus { get; set; }
        public string TransactionCode { get; set; }
        public string TransactionMessage { get; set; }
        public decimal RefundedAmount { get; set; }
        public decimal CapturedAmount { get; set; }
        public decimal AuthorizedAmount { get; set; }
        public long AdminUserId { get; set; }
        public long FortId { get; set; }
        public string ProfilerResponse { get; set; }
        public PayfortCheckStatus CheckStatusResponse { get; set; }
    }

    public class PayfortCheckStatus
    {
        public string transaction_code { get; set; }
        public PayFortResponseStatusEnum transaction_status { get; set; }
        public string response_code { get; set; }
        public string signature { get; set; }
        public string merchant_identifier { get; set; }
        public string access_code { get; set; }
        public string transaction_message { get; set; }
        public string language { get; set; }
        public string fort_id { get; set; }
        public string refunded_amount { get; set; }
        public string response_message { get; set; }
        public string merchant_reference { get; set; }
        public string query_command { get; set; }
        public string captured_amount { get; set; }
        public string authorized_amount { get; set; }
        public PayFortResponseStatusEnum status { get; set; }
    }

    public class PayfortFeedBackModel
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
