using System;
using Platform.Payment.Enums;

namespace Platform.Payment.Models.Request
{
    public abstract class InvoicePayRequestModel
    {
        public PaymentEngine Engine { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerName { get; set; }
        public string CustomerContact { get; set; }
        public string BookingReferenceNumber { get; set; }
        public string OrderDescription { get; set; }
        public string CardType { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string DeviceFingerPrint { get; set; }
    }
}
