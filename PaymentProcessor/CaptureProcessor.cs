using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using Platform.Payment.Enums;
using Platform.Payment.PayfortModels;

namespace Platform.Payment.PaymentProcessor
{
    public static class CaptureProcessor
    {
        /// <summary>
        /// Generate SHA256 Signature
        /// </summary>
        /// <param name="request"></param>
        public static string GenerateCaptureSHA256Signature(PayfortCaptureInfoRequestModel request)
        {
            try
            {
                //Align Parameters names in ascending order and then
                //convert to SHA256
                return ConvertToSHA256(GetCaptureSignatureAscending(request));
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
        public static string GetCaptureSignatureAscending(PayfortCaptureInfoRequestModel request)
        {
            try
            {
                return string.Format("{0}access_code={1}amount={2}command={3}currency={4}fort_id={5}language={6}merchant_identifier={7}{0}",
                                  request.RequestPhrase,
                                 request.AccessCode,
                                request.Amount,
                               request.Command,
                              request.Currency,
                             request.FortId,
                            "en",
                           request.MerchantIdentifier);
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
        public static string GetCaptureRequestParams(PayfortCaptureInfoRequestModel request)
        {
            try
            {
                return string.Format("{{\"access_code\":\"{0}\",\"amount\":\"{1}\",\"command\":\"{2}\",\"currency\":\"{3}\",\"fort_id\":\"{4}\",\"language\":\"{5}\",\"merchant_identifier\":\"{6}\",\"signature\":\"{7}\"}}",
                                    request.AccessCode,
                                   request.Amount,
                                  request.Command,
                                 request.Currency,
                                request.FortId,
                               "en",
                              request.MerchantIdentifier,
                             request.Signature);
            }
            catch
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// Capture
        /// </summary>
        /// <param name="jsonRequest"></param>
        /// <param name="url"></param>
        /// <returns>string</returns>
        public static PaymentResponse Capture(string jsonRequest, string url, PaymentResponse errInfo)
        {
            //Declarations
            var pfResponse = string.Empty;

            try
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

                var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    streamWriter.Write(jsonRequest);
                    streamWriter.Flush();
                    streamWriter.Close();
                }

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    pfResponse = streamReader.ReadToEnd();
                }
                return GetCaptureResponseInfo(pfResponse, errInfo);
            }
            catch
            {
                return ExceptionHandler.ExceptionHandler.GetPayfortExceptionResponseInfo(errInfo, PaymentCommandType.Capture);
            }
        }

        /// <summary>
        /// Get Capture Response Info
        /// </summary>
        /// <param name="pfResponse"></param>
        /// <param name="errInfo"></param>
        /// <returns>PayfortErrorInfo</returns>
        private static PaymentResponse GetCaptureResponseInfo(string pfResponse, PaymentResponse errInfo)
        {
            var urlResponse = (JObject)JsonConvert.DeserializeObject(pfResponse);

            var responseStatus = urlResponse["status"].Value<int>(); //Payfort Status
            var responseMessage = urlResponse["response_message"].Value<string>(); //Payfort Response Message 
            var responseCode = urlResponse["response_code"].Value<string>(); //Payfort [Status Code + Response code]

            if (responseStatus == (int)PayfortResponseStatusEnum.CaptureSuccess) //Capture Success
            {
                errInfo.FortId = urlResponse["fort_id"].Value<string>();
                errInfo.IsValid = true;
            }
            else
            {
                var responseIntCode = int.Parse(responseCode.Substring(2, 3));

                errInfo.ErrorId = GetErrorId(responseIntCode, PaymentCommandType.Capture);
                errInfo.ErrorTypeId = (int)ErrorType.Payment;
                errInfo.ErrorTypeDescription = GetEnumDescription((CheckOutBookingError)errInfo.ErrorId);
            }

            errInfo.ProfilerResponse = pfResponse;
            return errInfo;
        }

        /// <summary>
        /// Get Error id
        /// </summary>
        /// <param name="responseStatus"></param>
        /// <returns>int</returns>
        private static int GetErrorId(int responseCode, PaymentCommandType CommandType)
        {
            switch (responseCode)
            {
                case (int)PayfortResponseMessageEnum.TechnicalProblem:
                    return (int)CheckOutBookingError.TechnicalProblem;
                case (int)PayfortResponseMessageEnum.AuthenticationFailed:
                    return (int)CheckOutBookingError.AuthenticationFailed;
                case (int)PayfortResponseMessageEnum.InsufficientFunds:
                    return (int)CheckOutBookingError.InsufficientFunds;
                case (int)PayfortResponseMessageEnum.TokenNameDoesNotExist:
                    return (int)CheckOutBookingError.TokenNameDoesNotExist;
                case (int)PayfortResponseMessageEnum.TransactionDeclined:
                    return (int)CheckOutBookingError.TransactionDeclined;
                default:
                    if (CommandType == PaymentCommandType.Authorization)
                        return (int)CheckOutBookingError.AuthorizationFailed;
                    else
                        return (int)CheckOutBookingError.CaptureFailed;
            }
        }

        public static string GetEnumDescription(Enum en)
        {
            var type = en.GetType();

            var memInfo = type.GetMember(en.ToString());

            if (memInfo != null && memInfo.Length > 0)
            {
                var attrs = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);

                if (attrs != null && attrs.Length > 0)
                {
                    return ((DescriptionAttribute)attrs[0]).Description;
                }
            }

            return en.ToString();
        }

        /// <summary>
        /// Converts string to SHA 256 string 
        /// </summary>
        /// <param name="value"></param>
        /// <returns>string</returns>
        private static string ConvertToSHA256(string value)
        {
            var bytes = Encoding.UTF8.GetBytes(value);
            var hashstring = new SHA256Managed();
            var hash = hashstring.ComputeHash(bytes);
            var hashString = string.Empty;
            foreach (var x in hash)
            {
                hashString += String.Format("{0:x2}", x);
            }
            return hashString;
        }

    }
}
