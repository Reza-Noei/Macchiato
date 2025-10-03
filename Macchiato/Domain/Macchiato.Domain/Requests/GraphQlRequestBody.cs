namespace Macchiato.Domain.Requests
{
    public sealed class GraphQlRequestBody : RequestBody
    {
        public override string ContentType => "application/json";

        public string Query { get; set; } = "";
        public Dictionary<string, object>? Variables { get; set; }
    }
}
