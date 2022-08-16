using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using Platform.Payfort.Payment.Extension;
using Platform.Payment.Enums;
using Platform.Payment.PayfortModels;

namespace Platform.Payment.PaymentProcessor
{
    public static class InvoiceProcessor
    {
        /// <summary>
        /// Authorize
        /// </summary>
        /// <param name="jsonRequest"></param>
        /// <param name="url"></param>
        /// <returns>string</returns>
        public static PaymentResponse Invoice(string jsonRequest, string url, PaymentResponse errInfo)
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

                return GetInvoiceResponseInfo(pfResponse, errInfo);
            }
            catch
            {
                return ExceptionHandler.ExceptionHandler.GetPayfortExceptionResponseInfo(errInfo, PaymentCommandType.Authorization);
            }
        }


        /// <summary>
        /// Get Payfort Response Info
        /// </summary>
        /// <param name="pfResponse"></param>
        /// <returns>Payfort Error Info</returns>
        private static PaymentResponse GetInvoiceResponseInfo(string pfResponse, PaymentResponse errInfo)
        {
            var urlResponse = (JObject)JsonConvert.DeserializeObject(pfResponse);

            var responseStatus = urlResponse["status"].Value<int>(); //Payfort Status
            var responseMessage = urlResponse["response_message"].Value<string>(); //Payfort Status
            var responseCode = urlResponse["response_code"].Value<string>(); //Payfort Status

            var paymentLinkId = string.Empty;
            var paymentLink = string.Empty;

            if (responseCode == "48000")
            {
                paymentLinkId = urlResponse["payment_link_id"].Value<string>(); //Payfort Status
                paymentLink = urlResponse["payment_link"].Value<string>(); //Payfort Status
            }



            //Check w.r.t Status
            if (responseStatus == (int)PayFortResponseStatusEnum.GeneratingInvoicePaymentLinkSuccess) //Authorization Success
            {
                errInfo.IsValid = true;
            }
            errInfo.ResponseCode = responseCode;

            errInfo.ProfilerResponse = pfResponse;
            errInfo.PaymentLink = paymentLink;
            errInfo.PaymentLinkId = paymentLinkId;
            return errInfo;
        }

        public static PayFortCheckInvoiceRequestModel CheckStatus(string jsonRequest, PayFortCheckInvoiceRequestModel response)
        {
            //Declarations
            var pfResponse = string.Empty;

            try
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

                var httpWebRequest = (HttpWebRequest)WebRequest.Create(response.Url);
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

                return GetInvoiceStatusResponse(pfResponse, response);
            }
            catch
            {
                response.IsValid = false;
                return response;
            }
        }

        /// <summary>
        /// Get Payfort Response Info
        /// </summary>
        /// <param name="pfResponse"></param>
        /// <returns>Payfort Error Info</returns>
        private static PayFortCheckInvoiceRequestModel GetInvoiceStatusResponse(string pfResponse, PayFortCheckInvoiceRequestModel response)
        {
            //var urlResponse = (JObject)JsonConvert.DeserializeObject(pfResponse);

            var payfortResponse = JsonConvert.DeserializeObject<PayfortCheckStatus>(pfResponse);


            response.IsValid = true;

            response.ResponseCode = payfortResponse.response_code;
            response.AuthorizedAmount = payfortResponse.authorized_amount.ToDecimal() / 100;
            response.CapturedAmount = payfortResponse.captured_amount.ToDecimal() / 100;
            response.RefundedAmount = payfortResponse.refunded_amount.ToDecimal() / 100;
            response.ResponseMessage = payfortResponse.response_message;
            response.TransactionCode = payfortResponse.transaction_code;
            response.TransactionMessage = payfortResponse.transaction_message;
            response.TransactionStatus = payfortResponse.transaction_status;
            response.Status = payfortResponse.status;
            response.FortId = payfortResponse.fort_id;

            //if (responseCodeStatus == PayFortResponseStatusEnum.CheckStatusSuccess
            //    && responseCodeMessage == PayFortResponseMessageEnum.Success
            //    && transactionStatus == PayFortResponseStatusEnum.PurchaseSuccess)
            //{
            //    response.TransactionStatus = transactionStatus;
            //}

            response.ProfilerResponse = pfResponse;

            return response;
        }

    }
}
