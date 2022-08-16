using Platform.Payment.Enums;

namespace Platform.Payment.Models.Response
{
    public class CaptureResponseModel
    {
        public PaymentEngine PaymentEngine { get; set; }
        public int EngineType { get; set; }
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public string responseCode { get; set; }
        public int FortId { get; set; }
        public int ErrorId { get; set; }
        public int ErrorTypeId { get; set; }
        public string ErrorTypeDescription { get; set; }
        public string BookingRefNumber { get; set; }
        public long BookingId { get; set; }

    }
}
