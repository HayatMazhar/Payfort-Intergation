using Autofac;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Platform.Payment.Contracts;
using Platform.Payment.Contracts.MasterCard;
using Platform.Payment.Contracts.Payfort;
using Platform.Payment.Enums;
using Platform.Payment.Gateway.MasterCard;
using Platform.Payment.Gateway.Payfort;
using Platform.Payment.Payfort;
using Platform.Payment.Repository;

namespace Platform.Payment
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddPaymentLibrary(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddTransient<IHttpContextAccessor, HttpContextAccessor>();

            services.AddTransient<IMasterCardRequestParser, MasterCardRequestParser > ();
            services.AddTransient<IMasterCardResponseParser, MasterCardResponseParser>();
            services.AddTransient<IPayfortRequestParser, PayfortRequestParser>();
            services.AddTransient<IPayfortResponseParser, PayfortResponseParser>();
            services.AddTransient<IRoutingService, RoutingService>();
            services.AddTransient<IPayfortClient, PayfortClient>();
            services.AddTransient<IGatewaySettingRepository, GatewaySettingRepository>();



            #region Payment Processor


            services.AddTransient<Func<PaymentEngine, IPaymentProcessor>>(serviceProvider => key =>
            {
                switch (key)
                {
                    case PaymentEngine.Payfort:
                        return serviceProvider.GetService<PayfortRequestProcessor>();
                    case PaymentEngine.Mastercard:
                        return serviceProvider.GetService<MasterCardRequestProcessor>();
                   
                    default:
                        throw new KeyNotFoundException(); // or maybe return null, up to you
                }
            });


       
            #endregion

            return services;
        }
    }
}
