using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Platform.Payment.PayfortModels
{
    public class PaymentResponse
    {
        /// <summary>
        /// Is Valid
        /// </summary>
        public bool IsValid { get; set; }
        public int PayfortResponseCode { get; set; }
        public string ResponseCode { get; set; }
        public DateTimeOffset RequestExpiryDate { get; set; }
        /// <summary>
        /// Is 3d check Requested
        /// </summary>
        public bool Is3DCheckRequested { get; set; }
        /// <summary>
        /// ThreeD Url
        /// </summary>
        public string ThreeDUrl { get; set; }
        /// <summary>
        /// Error Id
        /// </summary>
        public int ErrorId { get; set; }
        /// <summary>
        /// Error Type Id
        /// </summary>
        public int ErrorTypeId { get; set; }
        /// <summary>
        /// Error Type Description
        /// </summary>
        public string ErrorTypeDescription { get; set; }
        public string PaymentLinkId { get; set; }
        public string PaymentLink { get; set; }
        /// <summary>
        /// User Id
        /// </summary>
        public long UserId { get; set; }
        /// <summary>
        /// Authorization Code
        /// </summary>
        public string AuthorizationCode { get; set; }
        /// <summary>
        /// Fort Id
        /// </summary>
        public string FortId { get; set; }
        /// <summary>
        /// Booking Id
        /// </summary>
        public long BookingId { get; set; }
        public string BookingRefNumber { get; set; }
        public string ProfilerResponse { get; set; }
        public long ErrorNotificationId { get; set; }
        public string Session_Id { get; set; }
        public string ErrorTypeDescriptionRaw { get; set; }
        public PayfortResponse PayfortResponse { get; set; }
    }

    public class PayfortResponse
    {
        [JsonProperty("3ds_url")]
        public string Threeds_url { get; set; }
        [JsonProperty("access_code")]
        public string access_code { get; set; }
        [JsonProperty("amount")]
        public string amount { get; set; }
        [JsonProperty("card_holder_name")]
        public string card_holder_name { get; set; }
        [JsonProperty("card_number")]
        public string card_number { get; set; }
        [JsonProperty("command")]
        public string command { get; set; }
        [JsonProperty("currency")]
        public string currency { get; set; }
        [JsonProperty("customer_email")]
        public string customer_email { get; set; }
        [JsonProperty("customer_ip")]
        public string customer_ip { get; set; }
        [JsonProperty("customer_name")]
        public string customer_name { get; set; }
        [JsonProperty("eci")]
        public string eci { get; set; }
        [JsonProperty("expiry_date")]
        public string expiry_date { get; set; }
        [JsonProperty("fort_id")]
        public string fort_id { get; set; }
        [JsonProperty("language")]
        public string language { get; set; }
        [JsonProperty("merchant_extra")]
        public string merchant_extra { get; set; }
        [JsonProperty("merchant_identifier")]
        public string merchant_identifier { get; set; }
        [JsonProperty("merchant_reference")]
        public string merchant_reference { get; set; }
        [JsonProperty("payment_option")]
        public string payment_option { get; set; }
        [JsonProperty("remember_me")]
        public string remember_me { get; set; }
        [JsonProperty("response_code")]
        public string response_code { get; set; }
        [JsonProperty("response_message")]
        public string response_message { get; set; }
        [JsonProperty("signature")]
        public string signature { get; set; }
        [JsonProperty("status")]
        public string status { get; set; }
        public bool IsSuccessfull { get; set; }
    }
}
