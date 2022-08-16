namespace Platform.Payment.Models.Configuration
{
    public class PayfortConfigurationModel
    {

        public string RequestPhrase { get; set; }
        public string AccessCode { get; set; }
        public string MerchantIdentifier { get; set; }
        public string MerchantReference { get; set; }
        public string ReturnUrl { get; set; }
        public string URL { get; set; }
    }

}
