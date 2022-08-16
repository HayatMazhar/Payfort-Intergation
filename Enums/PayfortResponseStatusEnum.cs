using System.ComponentModel;

namespace Platform.Payment.Enums
{
    /// <summary>
    /// Payfort Response Status Enum
    /// </summary>
    public enum PayfortResponseStatusEnum
    {
        #region Enumerations

        /// <summary>
        /// Invalid Request
        /// </summary>
        [Description("Invalid Request")]
        InvalidRequest = 00,

        /// <summary>
        /// Order Stored
        /// </summary>
        [Description("Order Stored")]
        OrderStored = 01,

        /// <summary>
        /// Authorization Success
        /// </summary>
        [Description("Authorization Success")]
        AuthorizationSuccess = 02,

        /// <summary>
        /// Authorization Failed
        /// </summary>
        [Description("Authorization Failed")]
        AuthorizationFailed = 03,

        /// <summary>
        /// Capture Success
        /// </summary>
        [Description("Capture Success")]
        CaptureSuccess = 04,

        /// <summary>
        /// Capture Failed 
        /// </summary>
        [Description("Capture failed")]
        CaptureFailed = 05,

        /// <summary>
        /// Refund Success
        /// </summary>
        [Description("Refund Success")]
        RefundSuccess = 06,

        /// <summary>
        /// Refund Failed
        /// </summary>
        [Description("Refund Failed")]
        RefundFailed = 07,

        /// <summary>
        /// Authorization Voided Successfully
        /// </summary>
        [Description("Authorization Voided Successfully")]
        AuthorizationVoidedSuccessfully = 08,

        /// <summary>
        /// Authorization Void Failed
        /// </summary>
        [Description("Authorization Void Failed")]
        AuthorizationVoidFailed = 09,

        /// <summary>
        /// Incomplete
        /// </summary>
        [Description("Incomplete")]
        Incomplete = 10,

        /// <summary>
        /// Check Status Failed
        /// </summary>
        [Description("Check status Failed")]
        CheckStatusFailed = 11,

        /// <summary>
        /// Check Status Success
        /// </summary>
        [Description("Check status success")]
        CheckStatusSuccess = 12,

        /// <summary>
        /// Purchase Failure
        /// </summary>
        [Description("Purchase Failure")]
        PurchaseFailure = 13,

        /// <summary>
        /// Purchase Success
        /// </summary>
        [Description("Purchase Success")]
        PurchaseSuccess = 14,

        /// <summary>
        /// Uncertain Transaction
        /// </summary>
        [Description("Uncertain Transaction")]
        UncertainTransaction = 15,

        /// <summary>
        /// Tokenization Failed
        /// </summary>
        [Description("Tokenization failed")]
        TokenizationFailed = 17,

        /// <summary>
        /// Tokenization Success
        /// </summary>
        [Description("Tokenization success")]
        Success = 18,

        /// <summary>
        /// Transaction Pending
        /// </summary>
        [Description("Transaction pending")]
        TransactionPending = 19,

        /// <summary>
        /// On Hold
        /// </summary>
        [Description("On hold")]
        OnHold = 20,

        /// <summary>
        /// SDK Token Creation Failure
        /// </summary>
        [Description("SDK Token creation failure")]
        SdkTokenCreationFailure = 21,

        /// <summary>
        /// SDK Token Creation Success
        /// </summary>
        [Description("SDK Token creation success")]
        SdkTokenCreationSuccess = 22,

        /// <summary>
        /// Failed to Process Digital Wallet Service
        /// </summary>
        [Description("Failed to process Digital Wallet service")]
        FailedToProcessDigitalWalletService = 23,

        /// <summary>
        /// Digital Wallet Order Processed Successfully
        /// </summary>
        [Description("Digital wallet order processed successfully")]
        DigitalWalletOrderProcessedSuccessfully = 24,

        /// <summary>
        /// Check Card Balance Failed
        /// </summary>
        [Description("Check card balance failed")]
        CheckCardBalanceFailed = 27,

        /// <summary>
        /// Check Card Balance Success
        /// </summary>
        [Description("Check card balance success")]
        CheckCardBalanceSuccess = 28,

        /// <summary>
        /// Redemption Failed
        /// </summary>
        [Description("Redemption failed")]
        RedemptionFailed = 29,

        /// <summary>
        /// Redemption Success
        /// </summary>
        [Description("Redemption success")]
        RedemptionSuccess = 30,

        /// <summary>
        /// Reverse Redemption Transaction Failed
        /// </summary>
        [Description("Reverse Redemption transaction failed")]
        ReverseRedemptionTransactionFailed = 31,

        /// <summary>
        /// Reverse Redemption Transaction Success
        /// </summary>
        [Description("Reverse Redemption transaction success")]
        ReverseRedemptionTransactionSuccess = 32,

        /// <summary>
        /// Transaction In Review
        /// </summary>
        [Description("Transaction In review")]
        TransactionInReview = 40,

        /// <summary>
        /// Currency Conversion Success
        /// </summary>
        [Description("currency conversion success")]
        CurrencyConversionSuccess = 42,

        /// <summary>
        /// Currency Conversion Failed
        /// </summary>
        [Description("currency conversion failed")]
        CurrencyConversionFailed = 43

        #endregion
    }


    public enum PaymentCommandType
    {
        Tokenization,
        Authorization,
        Capture,
        VoidAuthorization,
        Purchase,
        PaymentLink
    }


    public enum PayfortResponseMessageEnum
    {
        /// <summary>
        /// Success
        /// </summary>
        [Description("Success")]
        Success = 000,

        /// <summary>
        /// Missing Parameter
        /// </summary>
        [Description("Missing parameter")]
        MissingParameter = 001,

        /// <summary>
        /// Invalid Parameter Format
        /// </summary>
        [Description("Invalid parameter format")]
        InvalidParameterFormat = 002,

        /// <summary>
        /// Payment Option is not available
        /// </summary>
        [Description("Payment option is not available for this merchant’s account")]
        PaymentOptionNotAvailableForMerchant = 003,

        /// <summary>
        /// Invalid Command
        /// </summary>
        [Description("Invalid command")]
        InvalidCommand = 004,

        /// <summary>
        /// Invalid Aamount
        /// </summary>
        [Description("Invalid amount")]
        InvalidAmount = 005,

        /// <summary>
        /// Technical Problem
        /// </summary>
        [Description("Technical problem")]
        TechnicalProblem = 006,

        /// <summary>
        /// Duplicate Order Number
        /// </summary>
        [Description("Duplicate order number")]
        DuplicateOrderNumber = 007,

        /// <summary>
        /// Signature Mismatch
        /// </summary>
        [Description("Signature mismatch")]
        SignatureMismatch = 008,

        /// <summary>
        /// Invalid Merchant Identifier
        /// </summary>
        [Description("Invalid merchant identifier")]
        InvalidMerchantIdentifier = 009,

        /// <summary>
        /// Invalid Access Code
        /// </summary>
        [Description("Invalid access code")]
        InvalidAccessCode = 010,

        /// <summary>
        /// Order Not Saved
        /// </summary>
        [Description("Order not saved")]
        OrderNotSaved = 011,

        /// <summary>
        /// Card Expired
        /// </summary>
        [Description("Card expired")]
        CardExpired = 012,

        /// <summary>
        /// Invalid Currency
        /// </summary>
        [Description("Invalid currency")]
        InvalidCurrency = 013,

        /// <summary>
        /// Invalid Payment Option
        /// </summary>
        [Description("Inactive payment option")]
        InactivePaymentOption = 014,

        /// <summary>
        /// Invalid Merchant Account
        /// </summary>
        [Description("Inactive merchant account")]
        InactiveMerchantAccount = 015,

        /// <summary>
        /// Invalid Card Number
        /// </summary>
        [Description("Invalid card number")]
        InvalidCardNumber = 016,

        /// <summary>
        /// Operation Not allowd By the Acquirere
        /// </summary>
        [Description("Operation not allowed by the acquirer")]
        OperationNotAllowedAcquirer = 017,

        /// <summary>
        /// Operation not allowed by the processpr
        /// </summary>
        [Description("Operation not allowed by processor")]
        OperationNotAllowedProcessor = 018,

        /// <summary>
        /// Inactive Acquirer
        /// </summary>
        [Description("Inactive acquirer")]
        InactiveAcquirer = 019,

        /// <summary>
        /// Processor is Inactive
        /// </summary>
        [Description("Processor is inactive")]
        ProcessorIsInactive = 020,

        /// <summary>
        /// Payment Option Deactivated by the acquirer
        /// </summary>
        [Description("Payment option deactivated by acquirer")]
        PaymentOptionDeactivatedByAcquirer = 021,

        /// <summary>
        /// PAyment Option deactivated by the processor
        /// </summary>
        [Description("Payment option deactivated by processor")]
        PaymentOptionDeactivatedByProcessor = 022,

        /// <summary>
        /// Currency not accepted by the acquirer
        /// </summary>
        [Description("Currency not accepted by acquirer")]
        CurrencyNotAcceptedByAcquirer = 023,

        /// <summary>
        /// Currency not accepted by the processor
        /// </summary>
        [Description("Currency not accepted by processor")]
        CurrencyNotAcceptedByProcessor = 024,

        /// <summary>
        /// Processor Integration settings are missing
        /// </summary>
        [Description("Processor integration settings are missing")]
        ProcessorIntegrationSettingsMissing = 025,

        /// <summary>
        /// Acquirer Integration settings are missing
        /// </summary>
        [Description("Acquirer integration settings are missing")]
        AcquirerIntegrationSettingsMissing = 026,

        /// <summary>
        /// Invalid Extra Parameters
        /// </summary>
        [Description("Invalid extra parameters")]
        InvalidExtraParameters = 027,

        /// <summary>
        /// Missing Operation Settings
        /// </summary>
        [Description("Missing operations settings. Contact PAYFORT operations support")]
        MissingOperationsSettings = 028,

        /// <summary>
        /// Insufficient Funds
        /// </summary>
        [Description("Insufficient funds")]
        InsufficientFunds = 029,

        /// <summary>
        /// Authentication Failed
        /// </summary>
        [Description("Authentication failed")]
        AuthenticationFailed = 030,

        /// <summary>
        /// Invalid Issuer
        /// </summary>
        [Description("Invalid issuer")]
        InvalidIssuer = 031,

        /// <summary>
        /// Invalid Parameter Length
        /// </summary>
        [Description("Invalid parameter length")]
        InvalidParameterLength = 032,

        /// <summary>
        /// Parameter Value not allowed
        /// </summary>
        [Description("Parameter value not allowed")]
        ParameterValueNotAllowed = 033,

        /// <summary>
        /// Operation not allowed
        /// </summary>
        [Description("Operation not allowed")]
        OperationNotAllowed = 034,

        /// <summary>
        /// Order created successfully
        /// </summary>
        [Description("Order created successfully")]
        OrderCreatedSuccessfully = 035,

        /// <summary>
        /// Order not found
        /// </summary>
        [Description("Order not found")]
        OrderNotFound = 036,

        /// <summary>
        /// Tokenization Service Inactive
        /// </summary>
        [Description("Tokenization service inactive")]
        TokenizationServiceInactive = 038,

        /// <summary>
        /// Invalid Transaction Source
        /// </summary>
        [Description("Invalid transaction source as it does not match the Origin URL or the Origin IP")]
        InvalidTransactionSource = 040,

        /// <summary>
        /// Operation amount exceeds the authorization amount
        /// </summary>
        [Description("Operation amount exceeds the authorized amount")]
        OperationAmountExceedsAuthorizedAmount = 042,

        /// <summary>
        /// Inactive Operation
        /// </summary>
        [Description("Inactive Operation")]
        InactiveOperation = 043,

        /// <summary>
        /// Token name does not exist
        /// </summary>
        [Description("Token name does not exist")]
        TokenNameDoesNotExist = 044,

        /// <summary>
        /// Merchant does not have the Token Service
        /// </summary>
        [Description("Merchant does not have the Token service and yet “token_name” was sent")]
        MerchantDoesNotHaveTokenService = 045,

        /// <summary>
        /// Channel is not configured for the selected payment option
        /// </summary>
        [Description("Channel is not configured for the selected payment option.")]
        ChannelNotConfigured = 046,

        /// <summary>
        /// Order already processed
        /// </summary>
        [Description("Order already processed")]
        OrderAlreadyProcessed = 047,

        /// <summary>
        /// Operation amount exceeds captured amount
        /// </summary>
        [Description("Operation amount exceeds the captured amount")]
        OperationAmountExceedsCapturedAmount = 048,

        /// <summary>
        /// Operation not valid for this payment option
        /// </summary>
        [Description("Operation not valid for this payment option")]
        OperationNotValidForPaymentOption = 049,

        /// <summary>
        /// Merchant per transaction limit exceeded
        /// </summary>
        [Description("Merchant per transaction limit exceeded")]
        MerchantPerTransactionLimitExceeded = 050,

        /// <summary>
        /// Acquirer bank is facing technical difficulties
        /// </summary>
        [Description("Acquirer bank is facing technical difficulties, please try again later")]
        AcquirerBankFacingTechnicalDifficulties = 051,

        /// <summary>
        /// Invalid OLP
        /// </summary>
        [Description("Invalid OLP")]
        InvalidOlp = 052,

        /// <summary>
        /// Merchant is not found in OLP Enging DB
        /// </summary>
        [Description("Merchant is not found in OLP Engine DB")]
        MerchantNotFoundOlpEngineDb = 053,

        /// <summary>
        /// SADAD is facing technical diffculties
        /// </summary>
        [Description("SADAD is facing technical difficulties, please try again later")]
        SadadFacingTechnicalDifficulties = 054,

        /// <summary>
        /// OLD ID Alias is not valid
        /// </summary>
        [Description("OLP ID Alias is not valid. Please contact your bank")]
        OlpidAliasNotValid = 055,

        /// <summary>
        /// OLP ID Alias does not exist
        /// </summary>
        [Description("OLP ID Alias does not exist. Please enter a valid OLP ID Alias")]
        OlpidAliasDoesNotExist = 056,

        /// <summary>
        /// /Transaction amount exceed the daily transaction limit
        /// </summary>
        [Description("Transaction amount exceeds the daily transaction limit")]
        TransactionAmountExceedsDailyTransactionLimit = 057,

        /// <summary>
        /// Transaction amount exceeds the allowed limit per transaction
        /// </summary>
        [Description("Transaction amount exceeds the allowed limit per transaction")]
        TransactionAmountExceedsAllowedLimitPerTransaction = 058,

        /// <summary>
        /// Merchant Name and SADAD Merchant ID do not match
        /// </summary>
        [Description("Merchant Name and SADAD Merchant ID do not match")]
        MerchantNameAndSadadMerchantIdDoNotMatch = 059,

        /// <summary>
        /// The entered OLP password is incorrect. Please provide a valid password
        /// </summary>
        [Description("The entered OLP password is incorrect. Please provide a valid password")]
        TheEnteredOlpPasswordIsIncorrect = 060,

        /// <summary>
        /// Failed to create Token
        /// </summary>
        [Description("Failed to create Token")]
        FailedToCreateToken = 061,

        /// <summary>
        /// Token has been created
        /// </summary>
        [Description("Token has been created")]
        TokenHasBeenCreated = 062,

        /// <summary>
        /// Token has been updated
        /// </summary>
        [Description("Token has been updated")]
        TokenHasBeenUpdated = 063,

        /// <summary>
        /// 3-D Secure check requested
        /// </summary>
        [Description("3-D Secure check requested")]
        SecureCheckRequested = 064,

        /// <summary>
        /// Transaction waiting for customer’s action
        /// </summary>
        [Description("Transaction waiting for customer’s action")]
        TransactionWaitingCustomer = 065,

        /// <summary>
        /// Merchant reference already exists
        /// </summary>
        [Description("Merchant reference already exists")]
        MerchantReferenceAlreadyExists = 066,

        /// <summary>
        /// Dynamic descriptor not configured for selected payment
        /// </summary>
        [Description("Dynamic descriptor not configured for selected payment")]
        DynamicDescriptorNotConfiguredForSelectedPayment = 067,

        /// <summary>
        /// SDK service is inactive
        /// </summary>
        [Description("SDK service is inactive")]
        SdkServiceIsInactive = 068,

        /// <summary>
        /// device_id mismatch
        /// </summary>
        [Description("device_id mismatch")]
        DeviceIdMismatch = 070,

        /// <summary>
        /// Failed to initiate connection
        /// </summary>
        [Description("Failed to initiate connection")]
        FailedToInitiateConnection = 071,

        /// <summary>
        /// Transaction has been cancelled by the consumer
        /// </summary>
        [Description("Transaction has been cancelled by the consumer")]
        TransactionCancelledByConsumer = 072,

        /// <summary>
        /// Invalid request format
        /// </summary>
        [Description("Invalid request format")]
        InvalidRequestFormat = 073,

        /// <summary>
        /// Transaction failed
        /// </summary>
        [Description("Transaction failed")]
        TransactionFailed = 074,

        /// <summary>
        /// Transaction failed
        /// </summary>
        [Description("Transaction failed")]
        TransactionFailed1 = 075,

        /// <summary>
        /// Transaction not found in OLP
        /// </summary>
        [Description("Transaction not found in OLP")]
        TransactionNotFoundOlp = 076,

        /// <summary>
        /// Error transaction code not found
        /// </summary>
        [Description("Error transaction code not found")]
        ErrorTransactionCodeNotFound = 077,

        /// <summary>
        /// Failed to check fraud screening
        /// </summary>
        [Description("Failed to check fraud screening")]
        FailedToCheckFraudScreening = 078,

        /// <summary>
        /// Transaction challenged by fraud
        /// </summary>
        [Description("Transaction challenged by fraud")]
        TransactionChallengedByFraud = 079,

        /// <summary>
        /// Unexpected user behavior
        /// </summary>
        [Description("Unexpected user behavior")]
        UnexpectedUserBehavior = 083,

        /// <summary>
        /// Transaction amount is either bigger than maximum or less than minimum amount accepted for the selected plan
        /// </summary>
        [Description("Transaction amount is either bigger than maximum or less than minimum amount accepted for the selected plan")]
        TransactionAmount = 084,

        /// <summary>
        /// Selected installment plan does not exist
        /// </summary>
        [Description("Selected installment plan does not exist")]
        SelectedInstallmentPlanDoesNotExist = 085,

        /// <summary>
        /// Installment plan is not configured for Merchant account
        /// </summary>
        [Description("Installment plan is not configured for Merchant account")]
        InstallmentPlanNotConfiguredMerchantAccount = 086,

        /// <summary>
        /// Card BIN does not match accepted issuer bank
        /// </summary>
        [Description("Card BIN does not match accepted issuer bank")]
        CardBinDoesNotMatchAcceptedIssuerBank = 087,

        /// <summary>
        /// Token name was not created for this transaction
        /// </summary>
        [Description("Token name was not created for this transaction")]
        TokenNameNotCreated = 088,

        /// <summary>
        /// Failed to retrieve digital wallet details
        /// </summary>
        [Description("Failed to retrieve digital wallet details")]
        FailedToRetrieveDigitalWalletDetails = 089,

        /// <summary>
        /// Failed to perform operation transaction in review
        /// </summary>
        [Description("Failed to perform operation transaction in review")]
        FailedToPerformOperationTransactioninReview = 090,

        /// <summary>
        /// service inactive
        /// </summary>
        [Description("service inactive")]
        ServiceInactive = 093,

        /// <summary>
        /// Failed to execute service
        /// </summary>
        [Description("Failed to execute service")]
        FailedToExecuteService = 099,

        /// <summary>
        /// Operation not allowed. The specified order is not confirmed yet
        /// </summary>
        [Description("Operation not allowed. The specified order is not confirmed yet")]
        OperationNotAllowedOrderNotConfirmed = 662,

        /// <summary>
        /// Transaction declined
        /// </summary>
        [Description("Transaction declined")]
        TransactionDeclined = 666,

        /// <summary>
        /// Transaction closed
        /// </summary>
        [Description("Transaction closed")]
        TransactionClosed = 773,

        /// <summary>
        /// The transaction has been processed, but failed to receive confirmation
        /// </summary>
        [Description("The transaction has been processed, but failed to receive confirmation")]
        TheTransactionProcessedButFailedToReceiveConfirmation = 777,

        /// <summary>
        /// Session timed-out
        /// </summary>
        [Description("Session timed-out")]
        SessionTimedOut = 778,

        /// <summary>
        /// Transformation error
        /// </summary>
        [Description("Transformation error")]
        TransformationError = 779,

        /// <summary>
        /// Transaction number transformation error
        /// </summary>
        [Description("Transaction number transformation error")]
        TransactionNumberTransformationError = 780,

        /// <summary>
        /// Message or response code transformation error
        /// </summary>
        [Description("Message or response code transformation error")]
        MessageOrResponseCodeRransformationError = 781,

        /// <summary>
        /// Installments service inactive
        /// </summary>
        [Description("Installments service inactive")]
        InstallmentsServiceInactive = 783,

        /// <summary>
        /// Transaction blocked by fraud checker"
        /// </summary>
        [Description("Transaction blocked by fraud checker")]
        TransactionBlockedByFraudChecker = 785,

        /// <summary>
        /// Failed to authenticate the user
        /// </summary>
        [Description("Failed to authenticate the user")]
        FailedToAuthenticateTheUser = 787
    }


    public enum CheckOutBookingError
    {
        [Description("Car-IQ-1")]
        InsuranceQuoteFail = 1,
        [Description("Car-IQ-2")]
        InsuraceQuotePriceMatch = 2,
        [Description("Car-IQ-3")]
        InsuraceQuotePriceFail = 3,
        [Description("Car-IQ-4")]
        DataBaseError = 4,
        [Description("Car-IQ-5")]
        GenericInsuranceQuoteError = 5,
        [Description("Car-IQ-6")]
        InsuranceQuoteApiFail = 6,


        [Description("AIR-PC-7")]
        AirPriceChanged = 7,

        [Description("AIR-PC-8")]
        AirNotAvailable = 8,

        [Description("AIR-PC-8-Package")]
        AirNotAvailablePacakge = 88,

        [Description("AIR-PC-9")]
        ErrorPriceCheck = 9,
        [Description("AIR-PC-10")]
        SuccessFlight = 10,

        [Description("Hotel-PC-11")]
        SuccessHotel = 11,

        [Description("Hotel-PC-12")]
        HotelNotAvailable = 12,
        [Description("Hotel-PC-13")]
        ErrorHotel = 13,
        [Description("Hotel-PC-14")]
        HotelPriceChange = 14,

        [Description("Payment-PC-11")]
        PaymentFailed = 15,


        [Description("Car-BR-7")]
        VehicleBookingRequestFail = 16,
        [Description("Car-BR-8")]
        VechcleBookingApiFail = 17,
        [Description("Car-BR-9")]
        VechicleBookingApiSuccess = 18,
        [Description("Car-BR-10")]
        VechicleBookingSaveToDbFail = 19,
        [Description("Car-IQ-11")]
        VechicleInsuranceQuoteSaveToDbFail = 20,
        [Description("Car-CB-12")]
        CancelQuoteRequestFail = 21,
        [Description("Car-CB-13")]
        CancelBookingApiFail = 22,
        [Description("Car-CB-14")]
        CancelBookingSuccess = 23,
        [Description("CheckOut-S1-1")]
        Step1CompleteSucess = 24,
        [Description("CheckOut-S1-2")]
        Step1UpdateError = 25,
        [Description("AIR-PC-19")]
        AirPriceSegmentException = 26,
        [Description("Air-PC-20")]
        TravelFusionException = 27,
        [Description("Air-PC-21")]
        AirGeneralExceptionTp = 28,
        [Description("Air-PC-22")]
        AirException = 28,
        [Description("Air-PC-22-Pacakge")]
        AirExceptionPacakge = 280,
        [Description("Air-PC-23")]
        OneWayException = 29,
        [Description("Checkout-AE-1")]
        AmountMisMatch = 30,
        [Description("Checkout-HB-3")]
        HotelBookingFailedGeneric = 33,
        [Description("Checkout-HB-4")]
        HotelBookingExceptionFailed = 34,
        [Description("Checkout-AU-99")]
        AuthorizationSuccess = 35,
        [Description("Checkout-AU-100")]
        AirRescheduled = 45,
        [Description("Checkout-AU-100-Package")]
        AirRescheduledPacakge = 450,

        [Description("AIR-PC-88")]
        AirBookingDuplicate = 46,
        [Description("Hotel-PC-88")]
        ItineraryAlresdyBooked = 47,
        [Description("Unrecov-Hotel-PC-15")]
        UnRecoverableHotelNotAvailable = 48,
        [Description("Checkout-HB-5")]
        UnRecovHotelBookingExceptionFailed = 49,
        [Description("Checkout-HB-6")]
        RecovHotelBookingExceptionFailed = 50,
        [Description("Recov-Hotel-PC-16")]
        RecoverableHotelNotAvailable = 51,
        [Description("Checkout-HB-7")]
        AgentAttentionHotelBookingExceptionFailed = 52,
        [Description("Checkout-HB-8")]
        AnonymusHotelBookingFailedGeneric = 53,
        [Description("Checkout-HB-9")]
        PendingBookingHotelBookingFailedGeneric = 54,

        [Description("Checkout-GAD-01")]
        UsersPointsDeductionFailed = 55,



        [Description("OLP-ID-Alias-not-exist")]
        OlpidAliasDoesNotExist = 56,

        [Description("OLP-password-incorrect")]
        TheEnteredOlpPasswordIsIncorrect = 60,

        [Description("Invalid-OLP")]
        InvalidOlp = 61,

        //[Description("OLP-ID-Alias-not-exist.")]
        //OLPIDAliasDoesNotExist = 56,
        [Description("Transaction-cancelled")]
        TransactionCancelledByConsumer = 72,

        [Description("Transaction-cancelled")]
        UnexpectedUserBehavior = 73,


        [Description("Checkout-PAY-01")]
        PaymentOptionNotAvailableForMerchant = 101,
        [Description("Checkout-PAY-02")]
        TechnicalProblem = 102,
        [Description("Checkout-PAY-03")]
        InsufficientFunds = 103,
        [Description("Checkout-PAY-04")]
        AuthenticationFailed = 104,
        [Description("Checkout-PAY-06")]
        TransactionDeclined = 106,
        [Description("Checkout-PAY-07")]
        AuthorizationFailed = 107,
        [Description("Checkout-PAY-08")]
        AuthorizationException = 108,
        [Description("Checkout-PAY-09")]
        CaptureFailed = 109,
        [Description("Checkout-PAY-10")]
        CaptureException = 110,
        

        [Description("Checkout-BK-1")]
        CardValidationFailed = 111,
        [Description("Checkout-BK-3")]
        CardNumberInvalid = 112,
        [Description("Checkout-BK-4")]
        CardExpired = 113,
        [Description("Checkout-PAY-11")]
        TokenNameDoesNotExist = 114,
        [Description("Unrecov-PACK-Hotel-PC-15")]
        UnRecoverablePackHotelNotAvailable = 115,
        [Description("Checkout-PACK-HB-5")]
        UnRecovPackHotelBookingExceptionFailed = 116,
        [Description("Checkout-PACK-HB-6")]
        RecovPackHotelBookingExceptionFailed = 117,
        [Description("Hotel-PACK-PC-12")]
        HotelPackNotAvailable = 118,
        [Description("Hotel-PACK-PC-14")]
        HotelPackPriceChange = 119,
        [Description("Hotel-PACK-PC-88")]
        ItineraryPackAlresdyBooked = 120,
        [Description("Checkout-PACK-HB-7")]
        AgentPackAttentionHotelBookingExceptionFailed = 121,
        [Description("Checkout-PACK-HB-8")]
        AnonymusPackHotelBookingFailedGeneric = 122,
        [Description("Checkout-PACK-HB-9")]
        PendingPackBookingHotelBookingFailedGeneric = 123,
        [Description("Checkout-PACK-HB-3")]
        HotelPackBookingFailedGeneric = 124,
        [Description("Car-PACK-BR-7")]
        VehiclePackBookingRequestFail = 125,
        [Description("Car-PACK-BR-8")]
        VechclePackBookingApiFail = 126,
        [Description("Car-PACK-IQ-4")]
        DataBasePackError = 128,
        [Description("PayTab-Pay-Fail-901")]
        PayTabCreatePageFaild = 127,


        [Description("Sadad-Authorization-Failed")]
        SadadGeneral = 129,


        /*Ejazah Checkout*/
        [Description("General-TravellerUpdate-Fail")]
        TravellerUpdateException = 425,


        [Description("General-Coupon-Bin-Exception")]
        CouponBinFailure = 426,

        [Description("Checkout-PAY-12")]
        PurchaseException = 427,
        [Description("Checkout-PAY-13")]
        PurchaseFailed = 428,
    }


    public enum ErrorType
    {
        Car = 3,
        Hotel = 2,
        Flight = 1,
        Payment = 4,
        General = 5,
        PointDeduction = 6
    }

    public enum PaymentNotificationsType
    {
        Sms,
        Email,
        None
    }

    /// <summary>
    /// Pay Fort Response Status Enum
    /// </summary>
    public enum PayFortResponseStatusEnum
    {
        /// <summary>
        /// Invalid Request
        /// </summary>
        [Description("Invalid Request")]
        InvalidRequest = 00,

        /// <summary>
        /// Order Stored
        /// </summary>
        [Description("Order Stored")]
        OrderStored = 01,

        /// <summary>
        /// Authorization Success
        /// </summary>
        [Description("Authorization Success")]
        AuthorizationSuccess = 02,

        /// <summary>
        /// Authorization Failed
        /// </summary>
        [Description("Authorization Failed")]
        AuthorizationFailed = 03,

        /// <summary>
        /// Capture Success
        /// </summary>
        [Description("Capture Success")]
        CaptureSuccess = 04,

        /// <summary>
        /// Capture Failed 
        /// </summary>
        [Description("Capture failed")]
        CaptureFailed = 05,

        /// <summary>
        /// Refund Success
        /// </summary>
        [Description("Refund Success")]
        RefundSuccess = 06,

        /// <summary>
        /// Refund Failed
        /// </summary>
        [Description("Refund Failed")]
        RefundFailed = 07,

        /// <summary>
        /// Authorization Voided Successfully
        /// </summary>
        [Description("Authorization Voided Successfully")]
        AuthorizationVoidedSuccessfully = 08,

        /// <summary>
        /// Authorization Void Failed
        /// </summary>
        [Description("Authorization Void Failed")]
        AuthorizationVoidFailed = 09,

        /// <summary>
        /// Incomplete
        /// </summary>
        [Description("Incomplete")]
        Incomplete = 10,

        /// <summary>
        /// Check Status Failed
        /// </summary>
        [Description("Check status Failed")]
        CheckStatusFailed = 11,

        /// <summary>
        /// Check Status Success
        /// </summary>
        [Description("Check status success")]
        CheckStatusSuccess = 12,

        /// <summary>
        /// Purchase Failure
        /// </summary>
        [Description("Purchase Failure")]
        PurchaseFailure = 13,

        /// <summary>
        /// Purchase Success
        /// </summary>
        [Description("Purchase Success")]
        PurchaseSuccess = 14,

        /// <summary>
        /// Uncertain Transaction
        /// </summary>
        [Description("Uncertain Transaction")]
        UncertainTransaction = 15,

        /// <summary>
        /// Tokenization Failed
        /// </summary>
        [Description("Tokenization failed")]
        TokenizationFailed = 17,

        /// <summary>
        /// Tokenization Success
        /// </summary>
        [Description("Tokenization success")]
        Success = 18,

        /// <summary>
        /// Transaction Pending
        /// </summary>
        [Description("Transaction pending")]
        TransactionPending = 19,

        /// <summary>
        /// On Hold
        /// </summary>
        [Description("On hold")]
        OnHold = 20,

        /// <summary>
        /// SDK Token Creation Failure
        /// </summary>
        [Description("SDK Token creation failure")]
        SdkTokenCreationFailure = 21,

        /// <summary>
        /// SDK Token Creation Success
        /// </summary>
        [Description("SDK Token creation success")]
        SdkTokenCreationSuccess = 22,

        /// <summary>
        /// Failed to Process Digital Wallet Service
        /// </summary>
        [Description("Failed to process Digital Wallet service")]
        FailedToProcessDigitalWalletService = 23,

        /// <summary>
        /// Digital Wallet Order Processed Successfully
        /// </summary>
        [Description("Digital wallet order processed successfully")]
        DigitalWalletOrderProcessedSuccessfully = 24,

        /// <summary>
        /// Check Card Balance Failed
        /// </summary>
        [Description("Check card balance failed")]
        CheckCardBalanceFailed = 27,

        /// <summary>
        /// Check Card Balance Success
        /// </summary>
        [Description("Check card balance success")]
        CheckCardBalanceSuccess = 28,

        /// <summary>
        /// Redemption Failed
        /// </summary>
        [Description("Redemption failed")]
        RedemptionFailed = 29,

        /// <summary>
        /// Redemption Success
        /// </summary>
        [Description("Redemption success")]
        RedemptionSuccess = 30,

        /// <summary>
        /// Reverse Redemption Transaction Failed
        /// </summary>
        [Description("Reverse Redemption transaction failed")]
        ReverseRedemptionTransactionFailed = 31,

        /// <summary>
        /// Reverse Redemption Transaction Success
        /// </summary>
        [Description("Reverse Redemption transaction success")]
        ReverseRedemptionTransactionSuccess = 32,

        /// <summary>
        /// Transaction In Review
        /// </summary>
        [Description("Transaction In review")]
        TransactionInReview = 40,

        /// <summary>
        /// Currency Conversion Success
        /// </summary>
        [Description("currency conversion success")]
        CurrencyConversionSuccess = 42,

        /// <summary>
        /// Currency Conversion Failed
        /// </summary>
        [Description("currency conversion failed")]
        CurrencyConversionFailed = 43,

        [Description("Generating invoice payment link success")]
        GeneratingInvoicePaymentLinkSuccess = 48,

        [Description("Generating invoice payment link failed")]
        GeneratingInvoicePaymentLinkFailed = 49,
    }


}
