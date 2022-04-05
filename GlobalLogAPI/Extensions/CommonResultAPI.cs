namespace GlobalLogAPI.Extensions
{
    public class CommonResultAPI
    {
        public class ResultAPI
        {
            public string? Status { get; set; }
            public string? Message { get; set; }
        }
        public class ResultStatus
        {
            public const string Duplicate = "Duplicate Data";
            public const string Error = "Error";
            public const string Success = "Success";
            public const string Failed = "Failed";
        }
    }
}
