namespace Macchiato.Domain.Requests
{
    public sealed class EmptyRequestBody : RequestBody
    {
        public override string ContentType => string.Empty; // No Content-Type
    }
}
