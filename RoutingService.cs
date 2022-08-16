using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Platform.Payment.Contracts;
using Platform.Payment.Enums;
using Platform.Payment.Models.Request;
using Platform.Payment.Models.Response;

namespace Platform.Payment
{
    /// <summary>
    /// this class is used to save the service.
    /// </summary>
    /// <seealso cref="Payment.Domain.Contracts.IRoutingService" />
    public class RoutingService : IRoutingService
    {
        /// <summary>
        /// The payment processor
        /// </summary>
        private Func<PaymentEngine, IPaymentProcessor> _paymentProcessor;
        private ILogger<RoutingService> _logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="RoutingService"/> class.
        /// </summary>
        /// <param name="logger">The logger.</param>
        /// <param name="paymentProcessor">The payment processor.</param>
        /// <exception cref="ArgumentNullException">
        /// logger
        /// or
        /// paymentProcessor
        /// </exception>
        public RoutingService(ILogger<RoutingService> logger, Func<PaymentEngine, IPaymentProcessor> paymentProcessor)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _paymentProcessor = paymentProcessor ?? throw new ArgumentNullException(nameof(paymentProcessor));
        }

        /// <summary>
        /// Routes the authorize.
        /// </summary>
        /// <param name="authorizeRequestModel">The authorize request model.</param>
        /// <returns></returns>
        public async Task<AuthorizeResponseModel> RouteAuthorize(AuthorizeRequestModel authorizeRequestModel)
        {
            try
            {
                return await _paymentProcessor(authorizeRequestModel.Engine).Authorize(authorizeRequestModel);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error - {ex.Message}  occurred while routing Authorization for Engine-{((PaymentEngine)authorizeRequestModel.Engine).ToString()}");
                throw ex;
            }
        }

        /// <summary>
        /// Routes the capture.
        /// </summary>
        /// <param name="captureRequestModel">The capture request model.</param>
        /// <returns></returns>
        public async Task<CaptureResponseModel> RouteCapture(CaptureRequestModel captureRequestModel)
        {
            try
            {
                return await _paymentProcessor(captureRequestModel.Engine).Capture(captureRequestModel);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error - {ex.Message}  occurred while routing Capture for Engine-{((PaymentEngine)captureRequestModel.Engine).ToString()}");
                throw ex;
            }
        }

        /// <summary>
        /// Routes the invoice.
        /// </summary>
        /// <param name="invoicePayRequestModel">The invoice pay request model.</param>
        /// <returns></returns>
        public async Task<InvoicePayResponseModel> RouteInvoice(InvoicePayRequestModel invoicePayRequestModel)
        {
            try
            {
                return await _paymentProcessor(invoicePayRequestModel.Engine).InvoicePay(invoicePayRequestModel);
            }
            catch (Exception ex)
            {

                _logger.LogError($"Error - {ex.Message}  occurred while routing invoice pay for Engine-{((PaymentEngine)invoicePayRequestModel.Engine).ToString()}");
                throw ex;
            }
        }

        /// <summary>
        /// Routes the void authorize.
        /// </summary>
        /// <param name="voidAuthorizeRequestModel">The void authorize request model.</param>
        /// <returns></returns>
        public async Task<VoidAuthorizeResponseModel> RouteVoidAuthorize(VoidAuthorizeRequestModel voidAuthorizeRequestModel)
        {
            try
            {
                return await _paymentProcessor(voidAuthorizeRequestModel.Engine).VoidAuthorize(voidAuthorizeRequestModel);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error - {ex.Message}  occurred while routing invoice pay for Engine-{((PaymentEngine)voidAuthorizeRequestModel.Engine).ToString()}");
                throw ex;
            }
        }
    }
}
