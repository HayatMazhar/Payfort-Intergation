using System;
using System.Collections.Generic;
using System.Text;

namespace Platform.Payment.PayfortModels
{
    public class PayfortCaptureInfoRequestModel
    {
        #region Properties
        /// <summary>
        /// Booking Id
        /// </summary>
        public long BookingId { get; set; }

        /// <summary>
        /// User ID
        /// </summary>
        public long UserId { get; set; }

        /// <summary>
        /// Payfort Info Id 
        /// </summary>
        public long PayfortInfoId { get; set; }

        /// <summary>
        /// Transaction Id - Saudia Specific Not related to Merchant
        /// </summary>
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
        /// Amount
        /// </summary>
        public string Amount { get; set; }

        /// <summary>
        /// Point Amount
        /// </summary>
        public string AmountPaidByPoints { get; set; }

        /// <summary>
        /// Amount
        /// </summary>
        public decimal TotalCartValue { get; set; }

        /// <summary>
        /// Point Amount
        /// </summary>
        public decimal TotalAmountPaidByPoints { get; set; }



        /// <summary>
        /// Points
        /// </summary>
        public double EarnPoints { get; set; }


        /// <summary>
        /// Points
        /// </summary>
        public double BurnPoints { get; set; }

        /// <summary>
        /// Command
        /// </summary>
        public string Command { get; set; }

        /// <summary>
        /// Currency
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// Fort Id
        /// </summary>
        public string FortId { get; set; }

        /// <summary>
        /// Language
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        /// Merchant Identifier
        /// </summary>
        public string MerchantIdentifier { get; set; }

        /// <summary>
        /// Signature
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


        public DateTime ExpiryDate { get; set; }

        public DateTime AvailOn { get; set; }

        public double ROE { get; set; }
        public string TokenName { get; set; }

        public bool IsOfflineBooking { get; set; }

        public string ReturnUrl { get; set; }
        public decimal rateOfExchange { get; set; }
        public int LanguageID { get; set; }
        #endregion
    }
}
