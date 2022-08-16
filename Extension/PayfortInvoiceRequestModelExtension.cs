using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Linq;
using Platform.Payment.Enums;
using Platform.Payment.PayfortModels;

namespace Platform.Payment.Extension
{
    public static class PayfortInvoiceRequestModelExtension
    {
        /// <summary>
        /// Generate SHA256 Signature
        /// </summary>
        /// <param name="request"></param>
        [Obsolete("Obsolete")]
        public static string GenerateInvoiceSha256Signature(this PayfortInvoiceRequestModel request)
        {
            try
            {
                //Align Parameters names in ascending order and then
                //convert to SHA256
                return ConvertToSha256(GetInvoiceSignatureAscending(request));
            }
            catch
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// Generate SHA256 string
        /// </summary>
        /// <param name="request"></param>
        /// <returns>string</returns>
        private static string GetInvoiceSignatureAscending(PayfortInvoiceRequestModel request)
        {
            try
            {
               
                var parameters = GetInvoiceParametersAsDictionary(request);

                var builder = new StringBuilder();

                builder.Append(request.RequestPhrase);
                foreach (var key in parameters.Keys.OrderBy((t => t)))
                {
                    var value = parameters[key];
                    builder.Append($"{key}={value}");
                }
                builder.Append(request.RequestPhrase);

                var signature = builder.ToString();
                return signature;
            }
            catch
            {
                return string.Empty;
            }
        }

        private static Dictionary<string, string> GetInvoiceParametersAsDictionary(PayfortInvoiceRequestModel request)
        {
            var parameters = new Dictionary<string, string>
            {
                {"access_code", request.AccessCode},
                {"amount", Convert.ToInt64(Convert.ToDecimal(request.Amount) * 100) + string.Empty},
                {"currency", request.Currency},
                {"customer_email", request.CustomerEmail},
                {"customer_name", request.CustomerName},
                {"customer_phone", request.CustomerPhoneNumber},
                {"language", request.Language},
                {"merchant_reference", request.MerchantReference},
                {"merchant_identifier", request.MerchantIdentifier},
                {"notification_type", PaymentNotificationsType.None.ToString()},
                //parameters.Add("order_description", request.OrderDescription);
                {"payment_option", string.IsNullOrEmpty(request.CreditCardType) ? "VISA" : request.CreditCardType},
                {"request_expiry_date", request.RequestExpiryDate.ToString("yyyy-MM-ddTHH:mm:ss") + "+00:00"},
                //parameters.Add("return_url", request.ReturnUrl);
                {"service_command", "PAYMENT_LINK"}
            };

            return parameters;
        }

        /// <summary>
        /// Get Authorization Request Params
        /// </summary>
        /// <param name="request"></param>
        /// <returns>string</returns>
        public static string GetInvoiceRequestParams(this PayfortInvoiceRequestModel request)
        {
            try
            {
                var parameters = GetInvoiceParametersAsDictionary(request);
                parameters.Add("signature", request.Signature);

                var builder = new StringBuilder();

                builder.Append("{");
                foreach (var key in parameters.Keys.OrderBy((t => t)))
                {
                    var value = parameters[key];
                    builder.Append($"\"{key}\":\"{value}\",");
                }
                if (builder.ToString().EndsWith(","))
                    builder.Remove(builder.Length - 1, 1);
                builder.Append("}");

                var requestAsString = builder.ToString();
                return requestAsString;
            }
            catch
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// Converts string to SHA 256 string 
        /// </summary>
        /// <param name="value"></param>
        /// <returns>string</returns>
        [Obsolete("Obsolete")]
        private static string ConvertToSha256(string value)
        {
            var bytes = Encoding.UTF8.GetBytes(value);
            var hashstring = new SHA256Managed();
            var hash = hashstring.ComputeHash(bytes);
            return hash.Aggregate(string.Empty, (current, x) => current + $"{x:x2}");
        }

    }
}
