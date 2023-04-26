namespace BrusAutomat;
internal class VendingMachine
{
    public Storage Inventory { get; set; }
    public Storefront Vendor { get; set; }

    public VendingMachine(Storage inventory, Storefront vendor)
    {
        Inventory = inventory;
        Vendor = vendor;
    }
}

