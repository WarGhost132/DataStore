namespace ContactModule.Models.Components.Export;

public sealed class ExportArgumentsComponentModel
{
    public List<IFilterOrOperation> Filters { get; set; } = [];
    public ExportTemplateComponentModel Template { get; set; } = new();
    public PaginationAndSorting Settings { get; set; } = new();
}
