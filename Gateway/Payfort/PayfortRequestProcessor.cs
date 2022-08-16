using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Platform.Payment.Contracts;
using Platform.Payment.Contracts.Payfort;
using Platform.Payment.Models.Request;
using Platform.Payment.Models.Response;
using Platform.Payment.Payfort;

namespace Platform.Payment.Gateway.Payfort
{
    public abstract class PayfortRequestProcessor : IPaymentProcessor
    {
        private readonly IPayfortClient _payfortService;
        private readonly IGatewaySettingRepository _gatewaySettingRepository;
        private readonly ILogger<PayfortRequestProcessor> _logger;
        private readonly IPayfortRequestParser _payfortRequestParser;
        private readonly IPayfortResponseParser _payfortResponseParser;

        /// <summary>
        /// Initializes a new instance of the <see cref="PayfortRequestProcessor"/> class.
        /// </summary>
        /// <param name="payfortService">The payfort service.</param>
        /// <param name="logger">The logger.</param>
        /// <param name="payfortRequestParser"></param>
        /// <param name="payfortResponseParser"></param>
        /// <param name="gatewaySettingRepository"></param>
        /// <exception cref="ArgumentNullException">
        /// payfortService
        /// or
        /// _logger
        /// </exception>
        protected PayfortRequestProcessor(IPayfortClient payfortService, ILogger<PayfortRequestProcessor> logger, IGatewaySettingRepository gatewaySettingRepository, IPayfortRequestParser payfortRequestParser, IPayfortResponseParser payfortResponseParser)
        {
            _payfortService = payfortService ?? throw new ArgumentNullException(nameof(payfortService));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _gatewaySettingRepository = gatewaySettingRepository ?? throw new ArgumentNullException(nameof(gatewaySettingRepository));
            _payfortRequestParser = payfortRequestParser ?? throw new ArgumentNullException(nameof(payfortRequestParser));
            _payfortResponseParser = payfortResponseParser ?? throw new ArgumentNullException(nameof(payfortResponseParser));
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
                var payfortRequest = _payfortRequestParser.ConvertToAuthorizeRequestModel(request);

                var stopwatch = new Stopwatch();

                stopwatch.Start();

                var gatewayResponse = _payfortService.Authorize(payfortRequest);

                //Add profiler

                return Task.FromResult(_payfortResponseParser.MapAuthorizationResponse(gatewayResponse));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Exception occured in authorize process in payfort ");
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
                var payfortRequest = _payfortRequestParser.ConvertToCaptureRequestModel(request);

                var stopwatch = new Stopwatch();

                stopwatch.Start();

                var gatewayResponse = _payfortService.Capture(payfortRequest);

                //Add profiler

                return Task.FromResult(_payfortResponseParser.MapCaptureResponse(gatewayResponse));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Exception occured in authorize process in payfort ");
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
                var payfortRequest = _payfortRequestParser.ConvertToInvoiceRequestModel(request);

                var stopwatch = new Stopwatch();

                stopwatch.Start();

                var gatewayResponse = _payfortService.GenerateInvoice(payfortRequest);

                //Add profiler

                return Task.FromResult(_payfortResponseParser.MapInvoicePayResponse(gatewayResponse));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Exception occured in authorize process in payfort ");
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
                var payfortRequest = _payfortRequestParser.ConvertToVoidAuthorizeRequestModel(request);

                var stopwatch = new Stopwatch();

                stopwatch.Start();

                var gatewayResponse = _payfortService.VoidAuthorize(payfortRequest);

                //Add profiler

                return Task.FromResult(_payfortResponseParser.MapVoidAuthorizationResponse(gatewayResponse));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Exception occured in authorize process in payfort ");
                throw ex;
            }
        }
    }
}
