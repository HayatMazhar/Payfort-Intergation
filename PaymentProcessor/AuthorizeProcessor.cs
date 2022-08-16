using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Text;
using Platform.Payment.Enums;
using Platform.Payment.PayfortModels;
using Platform.Payfort.Payment.Extension;

namespace Platform.Payment.PaymentProcessor
{
    public static class AuthorizeProcessor
    {

        /// <summary>
        /// Authorize
        /// </summary>
        /// <param name="jsonRequest"></param>
        /// <param name="url"></param>
        /// <returns>string</returns>
        public static PaymentResponse Authorize(string jsonRequest, string url, PaymentResponse errInfo)
        {
            //Declarations

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
                string pfResponse;
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    pfResponse = streamReader.ReadToEnd();
                    //pfResponse = File.ReadAllText(@"E:\Repository\MockResponses\PayfortResponse.json");
                }

                return GetAuthorizationResponseInfo(pfResponse, errInfo);
            }
            catch (Exception ex)
            {
                return GetPayfortExceptionResponseInfo(errInfo, PaymentCommandType.Authorization);
            }
        }

        /// <summary>
        /// Get Payfort Response Info
        /// </summary>
        /// <param name="pfResponse"></param>
        /// <returns>Payfort Error Info</returns>
        private static PaymentResponse GetAuthorizationResponseInfo(string pfResponse, PaymentResponse errInfo)
        {
            var urlResponse = JsonConvert.DeserializeObject<PayfortResponse>(pfResponse);
            errInfo.PayfortResponse = urlResponse;
            var responseStatus = urlResponse.status; //Payfort Status
            var responseMessage = urlResponse.response_message; //Payfort Response Message 
            var responseCode = urlResponse.response_code; //Payfort [Status Code + Response code]

            //Check w.r.t Status
            if (responseStatus.ToInt() == (int)PayfortResponseStatusEnum.AuthorizationSuccess) //Authorization Success
            {
                errInfo.IsValid = true;
                // errInfo.AuthorizationCode = urlResponse["authorization_code"].Value<string>();
                errInfo.FortId = urlResponse.fort_id;
            }
            else if (responseStatus.ToInt() == (int)PayfortResponseStatusEnum.OnHold && responseMessage.ToLower().Contains("3-d")) //3d Check Requested
            {
                errInfo.Is3DCheckRequested = true;
                errInfo.FortId = urlResponse.fort_id;
                errInfo.ThreeDUrl = urlResponse.Threeds_url;
            }
            else
            {
                var responseIntCode = Convert.ToInt32(responseCode.Substring(2, 3));

                errInfo.ErrorId = GetErrorId(responseIntCode, PaymentCommandType.Authorization);
                errInfo.ErrorTypeId = (int)ErrorType.Payment;
                errInfo.ErrorTypeDescription = GetEnumDescription((CheckOutBookingError)errInfo.ErrorId);
            }
            errInfo.ProfilerResponse = pfResponse;
            return errInfo;
        }

        /// <summary>
        /// Get Error id
        /// </summary>
        /// <returns>int</returns>
        private static int GetErrorId(int responseCode, PaymentCommandType commandType)
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
                    if (commandType == PaymentCommandType.Authorization)
                        return (int)CheckOutBookingError.AuthorizationFailed;
                    else
                        return (int)CheckOutBookingError.CaptureFailed;
            }
        }

        /// <summary>
        /// Gets the enum description.
        /// </summary>
        /// <param name="en">The en.</param>
        /// <returns></returns>
        private static string GetEnumDescription(Enum en)
        {
            var type = en.GetType();

            var memInfo = type.GetMember(en.ToString());

            switch (memInfo.Length > 0)
            {
                case true:
                {
                    var attrs = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);

                    if (attrs.Length > 0)
                    {
                        return ((DescriptionAttribute)attrs[0]).Description;
                    }

                    break;
                }
            }

            return en.ToString();
        }

        /// <summary>
        /// Payfort Error Info
        /// </summary>
        /// <param name="errInfo"></param>
        /// <returns>PayfortErrorInfo</returns>
        private static PaymentResponse GetPayfortExceptionResponseInfo(PaymentResponse errInfo, PaymentCommandType CommandType)
        {
            switch (CommandType)
            {
                case PaymentCommandType.Authorization:
                case PaymentCommandType.VoidAuthorization:
                    errInfo.ErrorId = (int)CheckOutBookingError.AuthorizationException;
                    break;
                default:
                    errInfo.ErrorId = (int)CheckOutBookingError.CaptureException;
                    break;
            }
            errInfo.ErrorTypeId = (int)ErrorType.Payment;
            errInfo.ErrorTypeDescription = GetEnumDescription((CheckOutBookingError)errInfo.ErrorId);

            return errInfo;
        }


        /// <summary>
        /// Authorize
        /// </summary>
        /// <param name="jsonRequest"></param>
        /// <param name="url"></param>
        /// <returns>string</returns>
        public static PaymentResponse VoidAuthorize(string jsonRequest, string url, PaymentResponse errInfo)
        {
            //Declarations

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
                string pfResponse;
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    pfResponse = streamReader.ReadToEnd();
                }

                return GetVoidAuthorizationResponseInfo(pfResponse, errInfo);
            }
            catch (Exception ex)
            {
                return GetPayfortExceptionResponseInfo(errInfo, PaymentCommandType.VoidAuthorization);
            }
        }

        /// <summary>
        /// Get Payfort Response Info
        /// </summary>
        /// <param name="pfResponse"></param>
        /// <returns>Payfort Error Info</returns>
        private static PaymentResponse GetVoidAuthorizationResponseInfo(string pfResponse, PaymentResponse errInfo)
        {
            var urlResponse = (JObject)JsonConvert.DeserializeObject(pfResponse);

            var responseStatus = urlResponse["status"].Value<int>(); //Payfort Status

            //Check w.r.t Status
            if (responseStatus == (int)PayfortResponseStatusEnum.AuthorizationVoidedSuccessfully) //Authorization Success
            {
                errInfo.IsValid = true;
            }
            errInfo.ProfilerResponse = pfResponse;
            return errInfo;
        }

    }
}
