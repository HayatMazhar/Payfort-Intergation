using System;
using System.Collections.Generic;
using System.Text;
using Platform.Payment.Models.Request;
using Platform.Payment.PayfortModels;

namespace Platform.Payment.Contracts.Payfort
{
    public interface IPayfortRequestParser
    {
        /// <summary>
        /// Converts to authorize request model.
        /// </summary>
        /// <param name="authorizeRequestModel">The authorize request model.</param>
        /// <param name="payfortConfigurationModel">The payfort configuration model.</param>
        /// <returns></returns>
        PayfortAuthorizationInfoRequest ConvertToAuthorizeRequestModel(AuthorizeRequestModel authorizeRequestModel);

        /// <summary>
        /// Converts to capture request model.
        /// </summary>
        /// <param name="captureRequestModel">The capture request model.</param>
        /// <param name="payfortConfigurationModel">The payfort configuration model.</param>
        /// <returns></returns>
        PayfortCaptureInfoRequestModel ConvertToCaptureRequestModel(CaptureRequestModel captureRequestModel);

        /// <summary>
        /// Converts to void authorize request model.
        /// </summary>
        /// <param name="authorizeRequestModel">The authorize request model.</param>
        /// <param name="payfortConfigurationModel">The payfort configuration model.</param>
        /// <returns></returns>
        PayfortAuthorizationInfoRequest ConvertToVoidAuthorizeRequestModel(VoidAuthorizeRequestModel authorizeRequestModel);

        /// <summary>
        /// Converts to authorize request model.
        /// </summary>
        /// <param name="invoicePayRequestModel">The invoice pay request model.</param>
        /// <param name="payfortConfigurationModel">The payfort configuration model.</param>
        /// <returns></returns>
        PayfortInvoiceRequestModel ConvertToInvoiceRequestModel(InvoicePayRequestModel invoicePayRequestModel);
    }
}
