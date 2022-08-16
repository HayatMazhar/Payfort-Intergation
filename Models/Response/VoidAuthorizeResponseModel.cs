using Platform.Payment.Enums;

namespace Platform.Payment.Models.Response
{
    public class VoidAuthorizeResponseModel
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
    }
}
