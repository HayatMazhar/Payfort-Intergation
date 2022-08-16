using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Platform.Payment.Models.Request;
using Platform.Payment.Models.Response;

namespace Platform.Payment.Contracts
{
    /// <summary>
    /// 
    /// </summary>
    public interface IRoutingService
    {
        /// <summary>
        /// Routes the authorize.
        /// </summary>
        /// <param name="authorizeRequestModel">The authorize request model.</param>
        /// <returns></returns>
        Task<AuthorizeResponseModel> RouteAuthorize(AuthorizeRequestModel authorizeRequestModel);

        /// <summary>
        /// Routes the capture.
        /// </summary>
        /// <param name="captureRequestModel">The capture request model.</param>
        /// <returns></returns>
        Task<CaptureResponseModel> RouteCapture(CaptureRequestModel captureRequestModel);

        /// <summary>
        /// Routes the invoice.
        /// </summary>
        /// <param name="invoicePayRequestModel">The invoice pay request model.</param>
        /// <returns></returns>
        Task<InvoicePayResponseModel> RouteInvoice(InvoicePayRequestModel invoicePayRequestModel);

        /// <summary>
        /// Routes the void authorize.
        /// </summary>
        /// <param name="voidAuthorizeRequestModel">The void authorize request model.</param>
        /// <returns></returns>
        Task<VoidAuthorizeResponseModel> RouteVoidAuthorize(VoidAuthorizeRequestModel voidAuthorizeRequestModel);
    }
}
