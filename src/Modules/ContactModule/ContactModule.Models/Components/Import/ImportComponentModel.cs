namespace ContactModule.Models.Components.Import;

public sealed class ImportComponentModel
{
    public string SourceId { get; set; } = string.Empty;
    public List<ImportPropertyComponentModel> Properties { get; set; } = [];
    public IBrowserFile? File { get; set; }
}
