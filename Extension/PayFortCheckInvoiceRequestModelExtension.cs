using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Platform.Payment.PayfortModels;

namespace Platform.Payment.Extension
{
    public static class PayFortCheckInvoiceRequestModelExtension
    {
        [Obsolete("Obsolete")]
        public static string GenerateCheckInvoiceStatusSha256Signature(this PayFortCheckInvoiceRequestModel request)
        {
            try
            {
                //Align Parameters names in ascending order and then
                //convert to SHA256
                return ConvertToSha256(GenerateCheckInvoiceStatusSignatureAscending(request));
            }
            catch
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// Generate SHA256 string
        /// </summary>
        /// <param name="r"></param>
        /// <returns>string</returns>
        private static string GenerateCheckInvoiceStatusSignatureAscending(PayFortCheckInvoiceRequestModel r)
        {
            try
            {
                var response = $"{r.RequestPhrase}access_code={r.AccessCode}language={r.Language}merchant_identifier={r.MerchantIdentifier}merchant_reference={r.MerchantReference}query_command={r.QueryCommand}{r.RequestPhrase}";

                return response;
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
        public static string GenerateCheckInvoiceStatusRequestParams(this PayFortCheckInvoiceRequestModel request)
        {
            try
            {
                return string.Format("{{\"access_code\":\"{0}\",\"language\":\"{1}\",\"merchant_identifier\":\"{2}\",\"merchant_reference\":\"{3}\",\"query_command\":\"{4}\",\"signature\":\"{5}\"}}",
                                    request.AccessCode,
                              request.Language,
                            request.MerchantIdentifier,
                           request.MerchantReference,
                                request.QueryCommand,
                     request.Signature);

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
