using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Platform.Payment.Models.Request;
using Platform.Payment.Models.Response;

namespace Platform.Payment.Contracts
{
    /// <summary>
    /// this interface is created as a generic implementationagainst the payment process for all the payment gateways.
    /// </summary>
    public interface IPaymentProcessor
    {
        /// <summary>
        /// Authorizes the specified request.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        Task<AuthorizeResponseModel> Authorize(AuthorizeRequestModel request);

        /// <summary>
        /// Captures the specified request.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        Task<CaptureResponseModel> Capture(CaptureRequestModel request);

        /// <summary>
        /// Voids the authorize.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        Task<VoidAuthorizeResponseModel> VoidAuthorize(VoidAuthorizeRequestModel request);

        /// <summary>
        /// Invoices the pay.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        Task<InvoicePayResponseModel> InvoicePay(InvoicePayRequestModel request);
    }
}
