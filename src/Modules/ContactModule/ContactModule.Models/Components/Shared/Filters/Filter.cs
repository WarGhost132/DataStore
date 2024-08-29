namespace ContactModule.Models.Components.Shared.Filters;

public sealed class Filter : IFilterOrOperation
{
    public string PropertyName {  get; set; } = string.Empty;
    public Operation Operation { get; set; } = Operation.Contains;
    public string Value { get; set; } = string.Empty;
}
