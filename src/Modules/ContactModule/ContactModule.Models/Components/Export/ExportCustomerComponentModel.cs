namespace ContactModule.Models.Components.Export;

public sealed class ExportCustomerComponentModel
{
    public List<CustomerItem> Customers { get; set; } = [];

    public class CustomerItem
    {
        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public ExportTemplateComponentModel Template { get; set; } = new();
    }
}
