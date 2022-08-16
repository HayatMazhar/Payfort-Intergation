using Platform.Payment.PayfortModels;

namespace Platform.Payment.Payfort
{
    public interface IPayfortClient
    {
        /// <summary>
        /// Authorizes the specified request.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        PaymentResponse Authorize(PayfortAuthorizationInfoRequest request);

        /// <summary>
        /// Purchase request
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        PaymentResponse Purchase(PayfortAuthorizationInfoRequest request);

        /// <summary>
        /// Captures the specified request.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        PaymentResponse Capture(PayfortCaptureInfoRequestModel request);

        /// <summary>
        /// Voids the authorize.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        PaymentResponse VoidAuthorize(PayfortAuthorizationInfoRequest request);

        /// <summary>
        /// Generates the invoice.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        PaymentResponse GenerateInvoice(PayfortInvoiceRequestModel request);

        /// <summary>
        /// Checks the invoice status.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        PayFortCheckInvoiceRequestModel CheckInvoiceStatus(PayFortCheckInvoiceRequestModel request);
    }
}
