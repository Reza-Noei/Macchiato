namespace Macchiato.Domain.Requests
{
    public sealed class BinaryRequestBody : RequestBody
    {
        public override string ContentType { get; }

        public byte[] Data { get; set; }

        public BinaryRequestBody(byte[] data, string contentType = "application/octet-stream")
        {
            Data = data;
            ContentType = contentType;
        }
    }
}
