namespace Investment.Common.Exceptions
{
    public class ErrorResponse
    {
        public string Title { get; set; }
        public int StatusCode { get; set; }
        public string Data { get; set; }
    }
}
