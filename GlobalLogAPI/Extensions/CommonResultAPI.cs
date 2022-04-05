namespace GlobalLogAPI.Extensions
{
    public class CommonResultAPI
    {
        public class ResultAPI
        {
            public int StatusCode { get; set; }
            public string? Message { get; set; }
        }
        public class ResultStatus
        {
            public const string Duplicate = "Duplicate Data";
            public const string Error = "Error";
            public const string Success = "Success";
            public const string Failed = "Failed";
        }
        public class ResultMessage
        {
            public const string SaveSuccess = "Data Save Success";
            public const string DelSuccess = "Data Delete Success";
        }
    }
}
