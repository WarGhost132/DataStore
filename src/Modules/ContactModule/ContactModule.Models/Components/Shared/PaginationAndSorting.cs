namespace ContactModule.Models.Components.Shared;

public sealed class PaginationAndSorting
{
    public int? SkipRecordsNumber { get; set; }
    public int? TakeRecordsNumber { get; set; }
    public SortOrderOption? SortBy { get; set; }
    public string? FieldForSorting { get; set; }
    public List<string> SourceNames { get; set; } = [];
}
