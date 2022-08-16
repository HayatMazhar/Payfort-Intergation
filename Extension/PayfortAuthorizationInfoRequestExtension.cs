using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Linq;
using Platform.Payment.Enums;
using Platform.Payment.PayfortModels;

namespace Platform.Payment.Extension
{
    public static class PayfortAuthorizationInfoRequestExtension
    {
        /// <summary>
        /// Generate SHA256 Signature
        /// </summary>
        /// <param name="request"></param>
        [Obsolete("Obsolete")]
        public static string GenerateAuthorizationSha256Signature(this PayfortAuthorizationInfoRequest request)
        {
            try
            {
                //Align Parameters names in ascending order and then
                //convert to SHA256
                return ConvertToSha256(GetAuthorizationSignatureAscending(request));
            }
            catch
            {
                return string.Empty;
            }
        }


        /// <summary>
        /// Get Authorization Request Params
        /// </summary>
        /// <param name="request"></param>
        /// <returns>string</returns>
        public static string GetAuthorizationRequestParams(this PayfortAuthorizationInfoRequest request)
        {
            try
            {
                var parameters = GetAuthorizationRequestParamsAsDictionary(request);

                var builder = new StringBuilder();

                builder.Append("{");
                if (parameters != null)
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
        private static Dictionary<string, string> GetAuthorizationRequestParamsAsDictionary(PayfortAuthorizationInfoRequest request)
        {
            var parameters = GetAuthorizationParametersAsDictionary(request);
            parameters.Add("signature", request.Signature);
            return parameters;
        }

        /// <summary>
        /// Generate SHA256 Signature
        /// </summary>
        /// <param name="request"></param>
        [Obsolete("Obsolete")]
        public static string GenerateVoidAuthorizationSha256Signature(this PayfortAuthorizationInfoRequest request)
        {
            try
            {
                //Align Parameters names in ascending order and then
                //convert to SHA256
                return ConvertToSha256(GetVoidAuthorizationSignatureAscending(request));
            }
            catch
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// Get Authorization Request Params
        /// </summary>
        /// <param name="request"></param>
        /// <returns>string</returns>
        public static string GetVoidAuthorizationRequestParams(this PayfortAuthorizationInfoRequest request)
        {
            try
            {
                return
                    $"{{\"command\":\"{PaymentCommandType.VoidAuthorization.ToString()}\",\"access_code\":\"{request.AccessCode}\",\"merchant_identifier\":\"{request.MerchantIdentifier}\",\"language\":\"en\",\"fort_id\":\"{request.FortId}\",\"signature\":\"{request.Signature}\"}}";
            }
            catch
            {
                return string.Empty;
            }
        }

        #region private Methods
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

        /// <summary>
        /// Generate SHA256 string
        /// </summary>
        /// <param name="request"></param>
        /// <returns>string</returns>
        private static string GetAuthorizationSignatureAscending(PayfortAuthorizationInfoRequest request)
        {
            try
            {
                var parameters = GetAuthorizationParametersAsDictionary(request);

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

        private static Dictionary<string, string> GetAuthorizationParametersAsDictionary(PayfortAuthorizationInfoRequest request)
        {
            var parameters = new Dictionary<string, string>
            {
                {"access_code", request.AccessCode},
                {"amount", request.Amount},
                {"command", request.Command},
                {"currency", request.Currency},
                {"customer_email", request.CustomerEmail},
                {"customer_ip", request.CustomerIp},
                {"customer_name", request.CustomerName},
                {"device_fingerprint", request.DeviceFingerPrint},
                {"language", request.Language},
                {"merchant_identifier", request.MerchantIdentifier},
                {"merchant_reference", request.MerchantReference},
                {"remember_me", request.RememberMe},
                {"return_url", request.ReturnUrl},
                {"token_name", request.TokenName}
            };

            if (!string.IsNullOrEmpty(request.check_3ds) && request.check_3ds == "NO")
                parameters.Add("check_3ds", request.check_3ds);

            if (!string.IsNullOrWhiteSpace(request.CardSecurityCode))
                parameters.Add("card_security_code", request.CardSecurityCode);
            return parameters;
        }

        /// <summary>
        /// Generate SHA256 string
        /// </summary>
        /// <param name="request"></param>
        /// <returns>string</returns>
        private static string GetVoidAuthorizationSignatureAscending(PayfortAuthorizationInfoRequest request)
        {
            try
            {
                return string.Format("{0}access_code={1}command={2}fort_id={3}language={4}merchant_identifier={5}{0}",
                    request.RequestPhrase,
                    request.AccessCode,
                    PaymentCommandType.VoidAuthorization.ToString(),
                    request.FortId,
                    "en",
                    request.MerchantIdentifier);
            }
            catch
            {
                return string.Empty;
            }
        }

        #endregion
    }
}
