using System;
using System.Collections.Generic;
using System.Text;
using Platform.Payment.Models.Configuration;

namespace Platform.Payment.Contracts
{
    public interface IGatewaySettingRepository
    {
        /// <summary>
        /// Gets the payfort configuration.
        /// </summary>
        /// <returns></returns>
        PayfortConfigurationModel GetPayfortConfiguration();

        /// <summary>
        /// Gets the master card configuration.
        /// </summary>
        /// <returns></returns>
        MasterCardConfigurationModel GetMasterCardConfiguration();
    }
}
