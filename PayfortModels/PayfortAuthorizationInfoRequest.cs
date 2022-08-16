using System;
using System.Collections.Generic;
using System.Text;

namespace Platform.Payment.PayfortModels
{
    public class PayfortAuthorizationInfoRequest
    {

        /// <summary>
        /// Booking Id
        /// </summary>
        public long BookingId { get; set; }

        public bool IsOfflineBooking { get; set; }



        /// <summary>
        /// User Id
        /// </summary>
        public long UserId { get; set; }

        /// <summary>
        /// Type of User Guest/Registered
        /// </summary>
        public int UserType { get; set; }

        /// <summary>
        /// Payfort Info Id
        /// </summary>
        public long PayfortInfoId { get; set; }

        public long TransactionId { get; set; }

        /// <summary>
        /// Request Phrase
        /// </summary>
        public string RequestPhrase { get; set; }

        /// <summary>
        /// Access Code
        /// </summary>
        public string AccessCode { get; set; }

        /// <summary>
        /// Authorization Code
        /// </summary>
        public string AuthorizationCode { get; set; }

        /// <summary>
        /// Fort Id
        /// </summary>
        public string FortId { get; set; }

        /// <summary>
        /// Amount
        /// </summary>
        public string Amount { get; set; }

        /// <summary>
        /// Amount
        /// </summary>
        public decimal TotalCartValue { get; set; }

        /// <summary>
        /// Earn Points
        /// </summary>
        public double EarnPoints { get; set; }

        /// <summary>
        ///  Burn Points
        /// </summary>
        public double BurnPoints { get; set; }

        /// <summary>
        ///  Burn Points
        /// </summary>
        public string AmountPaidByPoints { get; set; }

        /// <summary>
        /// Command
        /// </summary>
        public string Command { get; set; }

        ///  Burn Points
        /// </summary>
        public decimal TotalAmountPaidByPoints { get; set; }
        /// <summary>


        /// <summary>
        /// Card Security Code
        /// </summary>
        public string CardSecurityCode { get; set; }

        /// <summary>
        /// Currency
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// Customer Email
        /// </summary>
        public string CustomerEmail { get; set; }

        /// <summary>
        /// Customer Name
        /// </summary>
        public string CustomerName { get; set; }

        /// <summary>
        /// Customer Ip
        /// </summary>
        public string CustomerIp { get; set; }

        public string CustomerUserAgent { get; set; }

        /// <summary>
        /// Language
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        /// Merchant Identifier
        /// </summary>
        public string MerchantIdentifier { get; set; }

        /// <summary>
        /// Merchant Reference
        /// </summary>
        public string MerchantReference { get; set; }
        public string MerchantExtra { get; set; }

        /// <summary>
        /// Remember Me
        /// </summary>
        public string RememberMe { get; set; }

        /// <summary>
        /// Return Url
        /// </summary>
        public string ReturnUrl { get; set; }

        /// <summary>
        /// TokenName
        /// </summary>
        public string TokenName { get; set; }

        /// <summary>
        /// Singature
        /// </summary>
        public string Signature { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Response Code
        /// </summary>
        public string ResponseCode { get; set; }

        /// <summary>
        /// Response Meesage
        /// </summary>
        public string ResponseMessage { get; set; }

        /// <summary>
        /// Url
        /// </summary>
        public string Url { get; set; }

        public string SessionId { get; set; }

        public string LoginDevice { get; set; }

        public string DeviceFingerPrint { get; set; }

        public DateTime ExpiryDate { get; set; }

        public DateTime AvailOn { get; set; }
        public double ROE { get; set; }

        public int type_of_payment { get; set; }

        public decimal PaidPoints { get; set; }


        public bool IspaidByPoints { get; set; }

        public decimal PaidAmount { get; set; }
        public decimal rateOfExchange { get; set; }

        public long AgentId { get; set; }
        public string check_3ds { get; set; }
    }
}
