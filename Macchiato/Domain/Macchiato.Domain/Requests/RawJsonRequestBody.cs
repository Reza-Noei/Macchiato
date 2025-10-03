namespace Macchiato.Domain.Requests
{
    public sealed class RawJsonRequestBody : RawRequestBody
    {
        public override string ContentType => "application/json";
    }
}
