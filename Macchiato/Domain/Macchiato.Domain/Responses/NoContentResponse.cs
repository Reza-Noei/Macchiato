namespace Macchiato.Domain.Responses
{
    // No content response
    public class NoContentResponse : HttpResponse
    {
        public override string ContentType => null;
    }
}
