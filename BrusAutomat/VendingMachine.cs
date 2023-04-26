using System.Drawing;

namespace BrusAutomat;

internal class VendingMachine
{
    public Storage Inventory { get; set; }
    public Storefront Vendor { get; set; }

    public VendingMachine()
    {
        Inventory = new Storage();
        Vendor = new Storefront();
    }

    public double MakePurchase(Drink drinkToBuy)
    {
        var transaction = new Transaction(drinkToBuy, Vendor.CustomerCoinBalance);
        Inventory.AddCashToStorage(drinkToBuy.Price);
        return transaction.MakeTransaction();
    }

}

