using Platform.Payment.Enums;

namespace Platform.Payment.Models.Request
{
    public class CaptureRequestModel
    {
        public PaymentEngine Engine { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public string GatewayIdentifier { get; set; }


    }
}
