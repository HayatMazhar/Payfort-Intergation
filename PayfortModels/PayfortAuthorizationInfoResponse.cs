using System;
using System.Collections.Generic;
using System.Text;

namespace Platform.Payment.PayfortModels
{
    public class PayfortAuthorizationInfoResponse : PayfortAuthorizationInfoRequest
    {
        /// <summary>
        /// Added for paytab refrence ID
        /// </summary>
        public string PaytabReferenceID { get; set; }
    }
}
