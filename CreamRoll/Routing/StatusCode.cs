namespace CreamRoll.Routing {
    public enum StatusCode {
        Continue = 100,
        SwitchingProtocols = 101,
        Processing = 102,

        Ok = 200,
        Created = 201,
        Accepted = 202,
        NonAuthoritativeInformation = 203,
        NoContent = 204,
        ResetContent = 205,
        PartialContent = 206,
        MultiStatus = 207,
        AlreadyReported = 208,

        ImUsed = 226,
        MultipleChoices = 300,
        MovedPermanently = 301,
        Found = 302,
        SeeOther = 303,
        NotModified = 304,
        UseProxy = 305,
        TemporaryRedirect = 307,
        PermanentRedirect = 308,

        BadRequest = 400,
        Unauthorized = 401,
        PaymentRequired = 402,
        Forbidden = 403,
        NotFound = 404,
        MethodNotAllowed = 405,
        NotAcceptable = 406,
        ProxyAuthenticationRequired = 407,
        RequestTimeout = 408,
        Conflict = 409,
        Gone = 410,
        LengthRequired = 411,
        PreconditionFailed = 412,
        PayloadTooLarge = 413,
        UriTooLong = 414,
        UnsupportedMediaType = 415,
        RangeNotSatisfiable = 416,
        ExpectationFailed = 417,
        ImATeapot = 418,

        MisdirectedRequest = 421,
        UnprocessableEntity = 422,
        Locked = 423,
        FailedDependency = 424,

        UpgradeRequired = 426,

        PreconditionRequired = 428,
        TooManyRequests = 429,

        RequestHeaderFieldsTooLarge = 431,

        UnavailableForLegalReasons = 451,

        InternalServerError = 500,
        NotImplemented = 501,
        BadGateway = 502,
        ServiceUnavailable = 503,
        GatewayTimeout = 504,
        HttpVersionNotSupported = 505,
        VariantAlsoNegotiates = 506,
        InsufficientStorage = 507,
        LoopDetected = 508,

        NotExtended = 510,
        NetworkAuthenticationRequired = 511,
    }

    public static class StatusHelper {
        public static bool IsInformational(this StatusCode status) {
            return 100 <= (int)status && (int)status < 200;
        }

        public static bool IsSuccess(this StatusCode status) {
            return 200 <= (int)status && (int)status < 300;
        }

        public static bool IsRedirection(this StatusCode status) {
            return 300 <= (int)status && (int)status < 400;
        }

        public static bool IsClientError(this StatusCode status) {
            return 400 <= (int)status && (int)status < 500;
        }

        public static bool IsServerError(this StatusCode status) {
            return 500 <= (int)status && (int)status < 600;
        }
    }
}