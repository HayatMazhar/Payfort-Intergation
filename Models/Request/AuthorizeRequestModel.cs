using Platform.Payment.Enums;

namespace Platform.Payment.Models.Request
{
    public class AuthorizeRequestModel
    {
        /// <summary>
        /// Gets or sets the engine.
        /// </summary>
        /// <value>
        /// The engine.
        /// </value>
        public PaymentEngine Engine { get; set; }

        /// <summary>
        /// Gets or sets the booking number.
        /// </summary>
        /// <value>
        /// The booking number.
        /// </value>
        public string BookingNumber { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is offline booking.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is offline booking; otherwise, <c>false</c>.
        /// </value>
        public bool IsOfflineBooking { get; set; }

        /// <summary>
        /// Gets or sets the user identifier.
        /// </summary>
        /// <value>
        /// The user identifier.
        /// </value>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the type of the user.
        /// </summary>
        /// <value>
        /// The type of the user.
        /// </value>
        public int UserType { get; set; }

        /// <summary>
        /// Gets or sets the amount.
        /// </summary>
        /// <value>
        /// The amount.
        /// </value>
        public decimal Amount { get; set; }

        /// <summary>
        /// Gets or sets the total cart price.
        /// </summary>
        /// <value>
        /// The total cart price.
        /// </value>
        public decimal TotalCartPrice { get; set; }

        /// <summary>
        /// Gets or sets the earn points.
        /// </summary>
        /// <value>
        /// The earn points.
        /// </value>
        public decimal EarnPoints { get; set; }

        /// <summary>
        /// Gets or sets the burn points.
        /// </summary>
        /// <value>
        /// The burn points.
        /// </value>
        public decimal BurnPoints { get; set; }

        /// <summary>
        /// Gets or sets the amount paidby points.
        /// </summary>
        /// <value>
        /// The amount paidby points.
        /// </value>
        public decimal AmountPaidbyPoints { get; set; }

        /// <summary>
        /// Gets or sets the currency.
        /// </summary>
        /// <value>
        /// The currency.
        /// </value>
        public string Currency { get; set; }

        /// <summary>
        /// Gets or sets the customer email.
        /// </summary>
        /// <value>
        /// The customer email.
        /// </value>
        public string CustomerEmail { get; set; }

        /// <summary>
        /// Gets or sets the name of the customer.
        /// </summary>
        /// <value>
        /// The name of the customer.
        /// </value>
        public string CustomerName { get; set; }

        /// <summary>
        /// Gets or sets the ip address.
        /// </summary>
        /// <value>
        /// The ip address.
        /// </value>
        public string IPAddress { get; set; }

        /// <summary>
        /// Gets or sets the language.
        /// </summary>
        /// <value>
        /// The language.
        /// </value>
        public string Language { get; set; }

        /// <summary>
        /// Gets or sets the token.
        /// </summary>
        /// <value>
        /// The token.
        /// </value>
        public string Token { get; set; }

        /// <summary>
        /// Gets or sets the login device.
        /// </summary>
        /// <value>
        /// The login device.
        /// </value>
        public string LoginDevice { get; set; }
    }
}
