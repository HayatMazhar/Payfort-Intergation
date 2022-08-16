using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using Platform.Payment.Contracts;
using Platform.Payment.Models.Configuration;

namespace Platform.Payment.Repository
{
    public class GatewaySettingRepository : IGatewaySettingRepository
    {
        private ILogger<GatewaySettingRepository> _logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="GatewaySettingRepository"/> class.
        /// </summary>
        /// <param name="logger">The logger.</param>
        /// <exception cref="ArgumentNullException">logger</exception>
        public GatewaySettingRepository(ILogger<GatewaySettingRepository> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        /// <summary>
        /// Gets the master card configuration.
        /// </summary>
        /// <returns></returns>
        public MasterCardConfigurationModel GetMasterCardConfiguration()
        {
            try
            {
                return new MasterCardConfigurationModel();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error occurred while fetching mastercard gateway configuration ");
                throw ex;
            }
        }

        /// <summary>
        /// Gets the payfort configuration.
        /// </summary>
        /// <returns></returns>
        public PayfortConfigurationModel GetPayfortConfiguration()
        {
            try
            {
                return new PayfortConfigurationModel()
                {
                    MerchantIdentifier = "IpMFfjOO",
                    MerchantReference = Guid.NewGuid().ToString(),
                    AccessCode = "DfH4MwQPwGtTEQ9SIBm0",
                    RequestPhrase = "asddfrfrw",
                    ReturnUrl = "http://localhost:62136/api/v1/CallBack/PayfortTokenisationCallBack",
                    URL = "https://sbpaymentservices.payfort.com/FortAPI/paymentApi"
                };
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error occurred while fetching payfort gateway configuration ");
                throw ex;
            }
        }
    }
}
