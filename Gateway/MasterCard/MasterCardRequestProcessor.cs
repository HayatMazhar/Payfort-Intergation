using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using Platform.Payment.Contracts;
using Platform.Payment.Models.Request;
using Platform.Payment.Models.Response;

namespace Platform.Payment.Gateway.MasterCard
{
    public abstract class MasterCardRequestProcessor : IPaymentProcessor
    {
        private ILogger<MasterCardRequestProcessor> _masterCardService;

        /// <summary>
        /// Initializes a new instance of the <see cref="MasterCardRequestProcessor"/> class.
        /// </summary>
        /// <param name="masterCardService">The master card service.</param>
        /// <exception cref="ArgumentNullException">masterCardService</exception>
        protected MasterCardRequestProcessor(ILogger<MasterCardRequestProcessor> masterCardService)
        {
            _masterCardService = masterCardService ?? throw new ArgumentNullException(nameof(masterCardService));
        }

        /// <summary>
        /// Authorizes the specified request.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public Task<AuthorizeResponseModel> Authorize(AuthorizeRequestModel request)
        {
            try
            {
                return Task.FromResult(new AuthorizeResponseModel());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Captures the specified request.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public Task<CaptureResponseModel> Capture(CaptureRequestModel request)
        {
            try
            {
                return Task.FromResult(new CaptureResponseModel());
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// Invoices the pay.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public Task<InvoicePayResponseModel> InvoicePay(InvoicePayRequestModel request)
        {
            try
            {
                return Task.FromResult(new InvoicePayResponseModel());
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// Voids the authorize.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public Task<VoidAuthorizeResponseModel> VoidAuthorize(VoidAuthorizeRequestModel request)
        {
            try
            {
                return Task.FromResult(new VoidAuthorizeResponseModel());
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
