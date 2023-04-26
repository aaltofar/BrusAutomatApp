using System.Text;
using BrusAutomat;

Console.OutputEncoding = Encoding.UTF8;

var vendingMachine = new VendingMachine();


int customerChoice = 2;
int customerCoins = 20;

vendingMachine.AddCoinsToMachine(customerCoins);
while (true)
{
    if (vendingMachine.Inventory.IsValidChoice(customerChoice))
    {
        var chosenDrink = vendingMachine.Inventory.DrinkInventory[customerChoice];

        Console.WriteLine($"Du valgte nummer {customerChoice}, som tilsvarer {chosenDrink.Name}(pris {chosenDrink.Price}kr)");

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
