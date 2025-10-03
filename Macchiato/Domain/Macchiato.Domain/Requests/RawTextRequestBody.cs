namespace Macchiato.Domain.Requests
{
    public sealed class RawTextRequestBody : RawRequestBody
    {
        public override string ContentType => "text/plain";
    }
}
