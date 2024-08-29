namespace ContactModule.Models.Components.Export;

public sealed class ExportTemplateComponentModel
{
    public class TemplateItem
    {
        public string Id { get; set; } = string.Empty;
        public List<ExportPropertyComponentModel> Properties { get; set; } = [];
        public bool IsDefault { get; set; }
    }
}
