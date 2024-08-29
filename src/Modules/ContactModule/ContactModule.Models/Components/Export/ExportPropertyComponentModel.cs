namespace ContactModule.Models.Components.Export;

public sealed class ExportPropertyComponentModel : PropertyModel
{
    public bool IsRequired { get; set; }
    public bool IsUnique { get; set; }
    public bool IsValid { get; set; }
}
