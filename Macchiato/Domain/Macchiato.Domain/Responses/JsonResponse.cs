namespace Macchiato.Domain.Responses
{
    // JSON response
    public class JsonResponse : HttpResponse
    {
        public override string ContentType => "application/json";
    }
}
