using System;
using System.Collections.Generic;
using System.Text;
using Platform.Payment.Enums;

namespace Platform.Payment.PayfortModels
{
    public class PayFortCheckInvoiceRequestModel
    {
        #region Properties
        public string RequestPhrase { get; set; }
        /// <summary>
        /// Access Code
        /// </summary>
        public string AccessCode { get; set; }

        /// <summary>
        /// Query Command - CHECK_STATUS
        /// </summary>
        public string QueryCommand { get; set; } = "CHECK_STATUS";

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

        /// <summary>
        /// Singature
        /// </summary>
        public string Signature { get; set; }

        /// <summary>
        /// Fort Id
        /// </summary>
        public string FortId { get; set; }

        public string Url { get; set; }


        #region Response Properties
        public bool IsValid { get; set; }
        /// <summary>
        /// Response Meesage
        /// </summary>
        public string ResponseMessage { get; set; }
        /// <summary>
        /// Response Code
        /// </summary>
        public string ResponseCode { get; set; }
        /// <summary>
        /// Status
        /// </summary>
        public PayFortResponseStatusEnum Status { get; set; }

        public PayFortResponseStatusEnum TransactionStatus { get; set; }
        public string TransactionCode { get; set; }
        public string TransactionMessage { get; set; }
        public decimal RefundedAmount { get; set; }
        public decimal CapturedAmount { get; set; }
        public decimal AuthorizedAmount { get; set; }

        public long AdminUserId { get; set; }
        public string ProfilerResponse { get; set; }
        #endregion

        #endregion
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
}
