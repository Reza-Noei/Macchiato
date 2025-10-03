namespace Macchiato.Domain.Responses
{
    // Base abstract class for all response types
    public abstract class HttpResponse
    {
        public abstract string ContentType { get; }
    }
}
