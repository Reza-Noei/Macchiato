namespace Macchiato.Domain.Requests
{
    public class FormDataField
    {
        public string Name { get; set; } = "";
        
        public string? Value { get; set; }  // For text fields
        
        public byte[]? FileContent { get; set; } // For file uploads
        
        public string? FileName { get; set; }
    }
}
