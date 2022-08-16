using System;
using System.Globalization;
using Platform.Payment.Contracts;
using Platform.Payment.Contracts.Payfort;
using Platform.Payment.Enums;
using Platform.Payment.Models.Configuration;
using Platform.Payment.Models.Request;
using Platform.Payment.PayfortModels;

namespace Platform.Payment.Gateway.Payfort
{
    public class PayfortRequestParser : IPayfortRequestParser
    {
        private readonly IGatewaySettingRepository _gatewaySettingRepository;

        private readonly PayfortConfigurationModel _payfortConfigurationModel = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PayfortRequestParser"/> class.
        /// </summary>
        /// <param name="gatewaySettingRepository">The gateway setting repository.</param>
        /// <exception cref="ArgumentNullException">gatewaySettingRepository</exception>
        public PayfortRequestParser(IGatewaySettingRepository gatewaySettingRepository)
        {
            _gatewaySettingRepository = gatewaySettingRepository ?? throw new ArgumentNullException(nameof(gatewaySettingRepository));
            _payfortConfigurationModel = _gatewaySettingRepository.GetPayfortConfiguration();
        }

        /// <summary>
        /// Converts to authorize request model.
        /// </summary>
        /// <param name="authorizeRequestModel">The authorize request model.</param>
        /// <returns></returns>
        public PayfortAuthorizationInfoRequest ConvertToAuthorizeRequestModel(AuthorizeRequestModel authorizeRequestModel)
        {
            try
            {
                return new PayfortAuthorizationInfoRequest()
                {
                    RequestPhrase = _payfortConfigurationModel.RequestPhrase,
                    AccessCode = _payfortConfigurationModel.AccessCode,
                    Amount = authorizeRequestModel.Amount.ToString(CultureInfo.InvariantCulture),
                    Command = PaymentCommandType.Authorization.ToString(),
                    Currency = authorizeRequestModel.Currency,
                    CustomerEmail = authorizeRequestModel.CustomerEmail,
                    CustomerIp = authorizeRequestModel.IPAddress,
                    CustomerName = authorizeRequestModel.CustomerName,
                    Language = authorizeRequestModel.Language,
                    MerchantIdentifier = _payfortConfigurationModel.MerchantIdentifier,
                    MerchantReference = _payfortConfigurationModel.MerchantReference,
                    RememberMe = "YES",
                    ReturnUrl = _payfortConfigurationModel.ReturnUrl,
                    TokenName = authorizeRequestModel.Token,
                    MerchantExtra = authorizeRequestModel.BookingNumber,
                    Url = _payfortConfigurationModel.URL
                };
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// Converts to authorize request model.
        /// </summary>
        /// <param name="invoicePayRequestModel">The invoice pay request model.</param>
        /// <returns></returns>
        public PayfortInvoiceRequestModel ConvertToInvoiceRequestModel(InvoicePayRequestModel invoicePayRequestModel)
        {
            try
            {
                return new PayfortInvoiceRequestModel()
                {
                    RequestPhrase = _payfortConfigurationModel.RequestPhrase,
                    AccessCode = _payfortConfigurationModel.AccessCode,
                    Amount = invoicePayRequestModel.Amount.ToString(CultureInfo.InvariantCulture),
                    Currency = invoicePayRequestModel.Currency,
                    CustomerEmail = invoicePayRequestModel.CustomerEmail,
                    CustomerName = invoicePayRequestModel.CustomerName,
                    CustomerPhoneNumber = invoicePayRequestModel.CustomerContact,
                    MerchantIdentifier = _payfortConfigurationModel.MerchantIdentifier,
                    BookingReference = invoicePayRequestModel.BookingReferenceNumber,
                    OrderDescription = invoicePayRequestModel.OrderDescription,
                    CreditCardType = invoicePayRequestModel.CardType,
                    RequestExpiryDate = invoicePayRequestModel.ExpiryDate,
                    ReturnUrl = _payfortConfigurationModel.ReturnUrl,
                    DeviceFingerPrint = invoicePayRequestModel.DeviceFingerPrint,
                    Url = _payfortConfigurationModel.URL
                };
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// Converts to capture request model.
        /// </summary>
        /// <param name="captureRequestModel">The capture request model.</param>
        /// <returns></returns>
        public PayfortCaptureInfoRequestModel ConvertToCaptureRequestModel(CaptureRequestModel captureRequestModel)
        {
            try
            {
                return new PayfortCaptureInfoRequestModel()
                {
                    RequestPhrase = _payfortConfigurationModel.RequestPhrase,
                    AccessCode = _payfortConfigurationModel.AccessCode,
                    Amount = captureRequestModel.Amount.ToString(CultureInfo.InvariantCulture),
                    Command = PaymentCommandType.Capture.ToString(),
                    Currency = captureRequestModel.Currency,
                    FortId = captureRequestModel.GatewayIdentifier,
                    Language = "en",
                    MerchantIdentifier = _payfortConfigurationModel.MerchantIdentifier,
                    Url = _payfortConfigurationModel.URL
                };
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// Converts to void authorize request model.
        /// </summary>
        /// <param name="authorizeRequestModel">The authorize request model.</param>
        /// <returns></returns>
        public PayfortAuthorizationInfoRequest ConvertToVoidAuthorizeRequestModel(VoidAuthorizeRequestModel authorizeRequestModel)
        {
            try
            {
                return new PayfortAuthorizationInfoRequest()
                {
                    RequestPhrase = _payfortConfigurationModel.RequestPhrase,
                    AccessCode = _payfortConfigurationModel.AccessCode,
                    Command = PaymentCommandType.VoidAuthorization.ToString(),
                    FortId = "",
                    Language = "en",
                    MerchantIdentifier = _payfortConfigurationModel.MerchantIdentifier
                };
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
