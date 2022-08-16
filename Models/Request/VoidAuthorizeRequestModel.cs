using Platform.Payment.Enums;

namespace Platform.Payment.Models.Request
{
    public abstract class VoidAuthorizeRequestModel
    {
        public PaymentEngine Engine { get; set; }
    }
}
