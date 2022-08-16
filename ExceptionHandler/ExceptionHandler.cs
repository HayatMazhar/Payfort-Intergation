using System;
using System.ComponentModel;
using Platform.Payment.Enums;
using Platform.Payment.PayfortModels;

namespace Platform.Payment.ExceptionHandler
{
    public static class ExceptionHandler
    {
        /// <summary>
        /// Payfort Error Info
        /// </summary>
        /// <param name="errInfo"></param>
        /// <param name="commandType"></param>
        /// <returns>PayfortErrorInfo</returns>
        public static PaymentResponse GetPayfortExceptionResponseInfo(PaymentResponse errInfo, PaymentCommandType commandType)
        {
            switch (commandType)
            {
                case PaymentCommandType.Authorization:
                case PaymentCommandType.VoidAuthorization:
                    errInfo.ErrorId = (int)CheckOutBookingError.AuthorizationException;
                    break;
                case PaymentCommandType.Purchase:
                    errInfo.ErrorId = (int)CheckOutBookingError.PurchaseException;
                    break;
               
                case PaymentCommandType.Tokenization:
                case PaymentCommandType.Capture:
                case PaymentCommandType.PaymentLink:
                default:
                    errInfo.ErrorId = (int)CheckOutBookingError.CaptureException;
                    break;
            }
            errInfo.ErrorTypeId = (int)ErrorType.Payment;
            errInfo.ErrorTypeDescription = GetEnumDescription((CheckOutBookingError)errInfo.ErrorId);

            return errInfo;
        }

        private static string GetEnumDescription(Enum en)
        {
            var type = en.GetType();

            var memInfo = type.GetMember(en.ToString());

            if (memInfo.Length <= 0) return en.ToString();
            var attrs = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);

            return attrs.Length > 0 ? ((DescriptionAttribute)attrs[0]).Description : en.ToString();
        }
    }
}
