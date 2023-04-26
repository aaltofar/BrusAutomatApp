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
        InitMachine();
    }

    public double MakePurchase(Drink drinkToBuy)
    {
        var transaction = new Transaction(drinkToBuy, Vendor.CustomerCoinBalance);
        Inventory.AddCashToStorage(drinkToBuy.Price);
        return transaction.MakeTransaction();
    }

    public void InitMachine()
    {
        AddDrinksToStorage();
        Vendor.RefreshChoiceList(Inventory.DrinkInventory.Count);
    }

    private void AddDrinksToStorage()
    {
        Inventory.AddNewDrink("Fanta", 15.50, 10);
        Inventory.AddNewDrink("Coca-Cola", 17.50, 10);
        Inventory.AddNewDrink("Pepsi", 16.50, 12);
    }

    public void AddCoinsToMachine(double amount)
    {
        Vendor.InsertCoins(amount);
    }

}

