namespace Macchiato.Domain.Responses
{
    // Form-encoded or multipart response
    public class FormResponse : HttpResponse
    {
        public override string ContentType { get; }

        public FormResponse(bool isMultipart = false)
        {
            ContentType = isMultipart ? "multipart/form-data" : "application/x-www-form-urlencoded";
        }
    }
}
