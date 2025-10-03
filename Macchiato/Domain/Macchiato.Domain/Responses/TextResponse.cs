namespace Macchiato.Domain.Responses
{
    // Plain text response
    public class TextResponse : HttpResponse
    {
        public override string ContentType => "text/plain";
    }
}
