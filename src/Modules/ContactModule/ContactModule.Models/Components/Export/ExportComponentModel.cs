namespace ContactModule.Models.Components.Export;

public sealed class ExportComponentModel
{
    public string CustomerId { get; set; } = string.Empty;
    public ExportParametersComponentModel Parameters { get; set; } = new();
    public ExportArgumentsComponentModel Arguments { get; set; } = new();
}
