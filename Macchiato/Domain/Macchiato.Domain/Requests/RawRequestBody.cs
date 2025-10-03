namespace Macchiato.Domain.Requests
{
    public abstract class RawRequestBody : RequestBody
    {
        public string Content { get; set; } = "";
    }
}
