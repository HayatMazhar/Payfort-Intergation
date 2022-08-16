using System;
using Platform.Payment.Enums;
using Platform.Payment.Extension;
using Platform.Payment.PayfortModels;
using Platform.Payment.PaymentProcessor;

namespace Platform.Payment.Payfort
{
    public class PayfortClient : IPayfortClient
    {
        /// <summary>
        /// Authorize
        /// </summary>
        [Obsolete("Obsolete")]
        public PaymentResponse Authorize(PayfortAuthorizationInfoRequest request)
        {
            //Declarations
            var errInfo = new PaymentResponse();
            //errInfo.UserId = request.UserId;
            //errInfo.BookingId = request.BookingId;

            if (request != null)
            {
                //1. Generate SHA256 Signature
                request.Signature = request.GenerateAuthorizationSha256Signature();

                //2. Generate Json Request Parameter
                var jsonRequest = request.GetAuthorizationRequestParams();

                //3. Send Request
                return AuthorizeProcessor.Authorize(jsonRequest, request.Url, errInfo);
            }
            else
            {
                return ExceptionHandler.ExceptionHandler.GetPayfortExceptionResponseInfo(errInfo, PaymentCommandType.Authorization);
            }
        }

        /// <summary>
        /// Purchase
        /// </summary>
        [Obsolete("Obsolete")]
        public PaymentResponse Purchase(PayfortAuthorizationInfoRequest request)
        {
            //Declarations
            var errInfo = new PaymentResponse();
            //errInfo.UserId = request.UserId;
            //errInfo.BookingId = request.BookingId;

            if (request != null)
            {
                //1. Generate SHA256 Signature
                request.Signature = request.GenerateAuthorizationSha256Signature();

                //2. Generate Json Request Parameter
                var jsonRequest = request.GetAuthorizationRequestParams();

                //3. Send Request
                return PurchaseProcessor.Purchase(jsonRequest, request.Url, errInfo);
            }
            else
            {
                return ExceptionHandler.ExceptionHandler.GetPayfortExceptionResponseInfo(errInfo, PaymentCommandType.Purchase);
            }
        }

        /// <summary>
        /// Authorize
        /// </summary>
        [Obsolete("Obsolete")]
        public PaymentResponse Capture(PayfortCaptureInfoRequestModel request)
        {
            var errInfo = new PaymentResponse
            {
                UserId = request.UserId,
                BookingId = request.BookingId
            };

            {
                //1. Generate SHA256 Signature
                request.Signature = request.GenerateCaptureSha256Signature();

                //2. Generate Json Request Parameter
                var jsonRequest = request.GetCaptureRequestParams(request.Signature);

                //3. Send Request
                return CaptureProcessor.Capture(jsonRequest, request.Url, errInfo);
            }
        }

        /// <summary>
        /// Authorize
        /// </summary>
        [Obsolete("Obsolete")]
        public PaymentResponse VoidAuthorize(PayfortAuthorizationInfoRequest request)
        {
            //Declarations
            var errInfo = new PaymentResponse
            {
                UserId = request.UserId,
                BookingId = request.BookingId
            };

            {
                //1. Generate SHA256 Signature
                request.Signature = request.GenerateVoidAuthorizationSha256Signature();

                //2. Generate Json Request Parameter
                var jsonRequest = request.GetVoidAuthorizationRequestParams();

                //3. Send Request
                return AuthorizeProcessor.VoidAuthorize(jsonRequest, request.Url, errInfo);
            }
        }

        /// <summary>
        /// Generates the invoice.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        [Obsolete("Obsolete")]
        public PaymentResponse GenerateInvoice(PayfortInvoiceRequestModel request)
        {
            //Declarations
            var errInfo = new PaymentResponse
            {
                BookingRefNumber = request.BookingReference
            };
            request.RequestExpiryDate = DateTimeOffset.UtcNow.AddDays(24);
            errInfo.RequestExpiryDate = request.RequestExpiryDate;
            {
                //1. Generate SHA256 Signature
                request.Signature = request.GenerateInvoiceSha256Signature();

                //2. Generate Json Request Parameter
                var jsonRequest = request.GetInvoiceRequestParams();

                //3. Send Request
                return InvoiceProcessor.Invoice(jsonRequest, request.Url, errInfo);
            }
        }

        /// <summary>
        /// Checks the invoice status.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        [Obsolete("Obsolete")]
        public PayFortCheckInvoiceRequestModel CheckInvoiceStatus(PayFortCheckInvoiceRequestModel request)
        {
            //Declarations

            //1. Generate SHA256 Signature
            request.Signature = request.GenerateCheckInvoiceStatusSha256Signature();

            //2. Generate Json Request Parameter
            var jsonRequest = request.GenerateCheckInvoiceStatusRequestParams();

            //3. Send Request
            return InvoiceProcessor.CheckStatus(jsonRequest, request);
        }

    }
}
