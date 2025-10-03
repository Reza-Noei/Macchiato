namespace Macchiato.Domain.Responses
{
    public class CustomResponse : HttpResponse
    {
        public override string ContentType { get; }

        public CustomResponse(string contentType)
        {
            ContentType = contentType;
        }
    }
}
