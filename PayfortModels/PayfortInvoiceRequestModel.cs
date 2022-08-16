using System;
using System.Collections.Generic;
using System.Text;

namespace Platform.Payment.PayfortModels
{
    public class PayfortInvoiceRequestModel
    {
        #region Properties

        /// <summary>
        /// Booking Reference
        /// </summary>
        public string BookingReference { get; set; }
        public string CreditCardType { get; set; }
        public string OrderDescription { get; set; }

        /// <summary>
        /// User Email
        /// </summary>
        public long UserEmail { get; set; }

        /// <summary>
        /// Gets or sets the request expiry date.
        /// </summary>
        /// <value>
        /// The request expiry date.
        /// </value>
        public DateTimeOffset RequestExpiryDate { get; set; }

        /// <summary>
        /// Gets or sets the type of the notification.
        /// </summary>
        /// <value>
        /// The type of the notification.
        /// </value>
        public string NotificationType { get; set; }

        /// <summary>
        /// Payfort Info Id
        /// </summary>
        public long PayfortInfoId { get; set; }

        /// <summary>
        /// Gets or sets the transaction identifier.
        /// </summary>
        /// <value>
        /// The transaction identifier.
        /// </value>
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
        /// Command
        /// </summary>
        public string ServiceCommand { get; set; }

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
        /// Customer Name
        /// </summary>
        public string CustomerPhoneNumber { get; set; }

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

        /// <summary>
        /// Gets or sets the session identifier.
        /// </summary>
        /// <value>
        /// The session identifier.
        /// </value>
        public string SessionId { get; set; }

        /// <summary>
        /// Gets or sets the login device.
        /// </summary>
        /// <value>
        /// The login device.
        /// </value>
        public string LoginDevice { get; set; }

        /// <summary>
        /// Gets or sets the device finger print.
        /// </summary>
        /// <value>
        /// The device finger print.
        /// </value>
        public string DeviceFingerPrint { get; set; }

        /// <summary>
        /// Gets or sets the extra information.
        /// </summary>
        /// <value>
        /// The extra information.
        /// </value>
        public string ExtraInformation { get; set; }

        /// <summary>
        /// Returns true if ... is valid.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is valid; otherwise, <c>false</c>.
        /// </value>
        public bool IsValid { get; set; }

        /// <summary>
        /// Gets or sets the admin user identifier.
        /// </summary>
        /// <value>
        /// The admin user identifier.
        /// </value>
        public long AdminUserId { get; set; }

        /// <summary>
        /// Gets or sets the offline message.
        /// </summary>
        /// <value>
        /// The offline message.
        /// </value>
        public string OfflineMessage { get; set; }

        #endregion
    }
}
