namespace Macchiato.Domain.Requests
{
    public sealed class UrlEncodedRequestBody : RequestBody
    {
        public override string ContentType => "application/x-www-form-urlencoded";

        public Dictionary<string, string> Parameters { get; } = new();
    }
}
