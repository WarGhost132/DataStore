namespace ContactModule.Models.Components.Shared.Filters;

public sealed class FilterLogicalOperation : IFilterOrOperation
{
    public LogicalOperation? LogicalOperation { get; set; }
}
