namespace ContactModule.Models.Components.Export;

public sealed class ExportParametersComponentModel
{
    public int? MaximumQuantity { get; set; }
    public bool IsRememberData { get; set; }
    public FileExtension Format { get; set; }
}
