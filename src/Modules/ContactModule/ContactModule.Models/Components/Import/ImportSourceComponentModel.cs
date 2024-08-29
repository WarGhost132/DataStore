namespace ContactModule.Models.Components.Import;

public sealed class ImportSourceComponentModel
{
    public List<ImportSourceItem> Sources { get; set; } = [];
    public class ImportSourceItem
    {
        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public SourceType Type { get; set; } = SourceType.ManualLoading;
        public List<ImportPropertyComponentModel> Properties { get; set; }
    }
}
