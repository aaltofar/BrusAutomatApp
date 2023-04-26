namespace BrusAutomat;
public class Transaction
{
    public IDrink DrinkToBuy { get; set; }
    public double IncomingAmount { get; set; }
    public double OutgoingAmount { get; set; }
    public double Change { get; set; }
    public bool IsSuccessful { get; set; }

    public Transaction(IDrink drinkToBuy, double incomingAmount)
    {
        DrinkToBuy = drinkToBuy;
        IncomingAmount = incomingAmount;
        Change = IncomingAmount - DrinkToBuy.Price;
    }

    public double MakeTransaction()
    {
        if (IncomingAmount < DrinkToBuy.Price)
        {
            Console.WriteLine("For lite penger, transaksjonen avbrytes");
            return IncomingAmount;
        }

        Console.WriteLine("Kjøp bekreftet, utleverer vare");
        return Change;
    }
}

