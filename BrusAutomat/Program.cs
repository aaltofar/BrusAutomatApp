using System.Text;
using BrusAutomat;
Console.OutputEncoding = Encoding.UTF8;

var vendingMachine = new VendingMachine(new Storage(), new Storefront());

vendingMachine.Inventory.AddNewDrink(new Farris("Farris", 15, 10));
vendingMachine.Inventory.AddNewDrink(new Fanta("Fanta", 20, 5));
vendingMachine.Inventory.AddNewDrink(new CocaCola("Coca-Cola", 17.50, 7));

vendingMachine.Vendor.RefreshChoiceList(vendingMachine.Inventory.DrinkInventory.Count);

vendingMachine.Vendor.InsertCoins(20);

if (vendingMachine.Vendor.ChooseDrink(2))
{
    Console.WriteLine($"Du valgte nummer 2, som tilsvarer {vendingMachine.Inventory.DrinkInventory[2].Name}");
    Console.WriteLine($"Prisen er {vendingMachine.Inventory.DrinkInventory[2].Price}kr");

    var transaction = new Transaction(vendingMachine.Inventory.DrinkInventory[2], vendingMachine.Vendor.CustomerCoinBalance);

    var change = transaction.MakeTransaction();
    vendingMachine.Inventory.ExpendDrink(vendingMachine.Inventory.DrinkInventory[2]);
    Console.WriteLine($"Kjøpet er fullført, her er ditt veksel: {change}kr");
}

