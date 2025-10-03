namespace Macchiato.Domain.Responses
{
    // Binary/File response
    public class FileResponse : HttpResponse
    {
        public override string ContentType => "application/octet-stream";

        public string FileName { get; set; } // Optional: store filename
    }
}
