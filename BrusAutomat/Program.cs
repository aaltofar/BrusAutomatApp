using System.Text;
using BrusAutomat;

Console.OutputEncoding = Encoding.UTF8;


var vendingMachine = new VendingMachine();

vendingMachine.Inventory.AddNewDrink("Fanta", 15.50, 10);
vendingMachine.Inventory.AddNewDrink("Coca-Cola", 17.50, 10);
vendingMachine.Inventory.AddNewDrink("Pepsi", 16.50, 12);

vendingMachine.Vendor.RefreshChoiceList(vendingMachine.Inventory.DrinkInventory.Count);

vendingMachine.Vendor.InsertCoins(20);
int choice = 1;

while (true)
{
    if (vendingMachine.Inventory.IsValidChoice(choice))
    {
        var chosenDrink = vendingMachine.Inventory.DrinkInventory[choice];

        Console.WriteLine($"Du valgte nummer {choice}, som tilsvarer {chosenDrink.Name}(pris {chosenDrink.Price}kr)");

        if (vendingMachine.Vendor.HasEnoughMoney(chosenDrink.Price))
        {
            var change = vendingMachine.MakePurchase(chosenDrink);

            vendingMachine.Inventory.ExpendDrink(chosenDrink);
            Console.WriteLine($"Kjøpet er fullført, her er ditt veksel: {change}kr");
        }
        else
            Console.WriteLine("Kjøpet avbrytes, ikke nok mynt i innkast");

    }
    else
        Console.WriteLine("Ugyldig valg, prøv igjen");

    Console.ReadLine();
}
