namespace Macchiato.Domain.Requests
{
    public sealed class FormDataRequestBody : RequestBody
    {
        public override string ContentType => "multipart/form-data";

        public List<FormDataField> Fields { get; } = new();
    }
}
