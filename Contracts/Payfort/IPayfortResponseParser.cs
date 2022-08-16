using System;
using System.Collections.Generic;
using System.Text;
using Platform.Payment.Models.Response;
using Platform.Payment.PayfortModels;

namespace Platform.Payment.Contracts.Payfort
{
    public interface IPayfortResponseParser
    {
        /// <summary>
        /// Maps the authorization response.
        /// </summary>
        /// <param name="paymentResponse">The payment response.</param>
        /// <returns></returns>
        AuthorizeResponseModel MapAuthorizationResponse(PaymentResponse paymentResponse);

        /// <summary>
        /// Maps the capture response.
        /// </summary>
        /// <param name="paymentResponse">The payment response.</param>
        /// <returns></returns>
        CaptureResponseModel MapCaptureResponse(PaymentResponse paymentResponse);

        /// <summary>
        /// Maps the void authorization response.
        /// </summary>
        /// <param name="paymentResponse">The payment response.</param>
        /// <returns></returns>
        VoidAuthorizeResponseModel MapVoidAuthorizationResponse(PaymentResponse paymentResponse);

        /// <summary>
        /// Maps the invoice pay response.
        /// </summary>
        /// <param name="paymentResponse">The payment response.</param>
        /// <returns></returns>
        InvoicePayResponseModel MapInvoicePayResponse(PaymentResponse paymentResponse);
    }
}
