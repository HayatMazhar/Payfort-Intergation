namespace Platform.Payment.Models.Response
{
    public class AuthorizeResponseModel
    {
        public int EngineType { get; set; }
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public bool Is3DSecure { get; set; }
        public string URL3DSecure { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public string FortId { get; set; }
        public long BookingId { get; set; }
        public string BookingRefNumber { get; set; }
    }
}
