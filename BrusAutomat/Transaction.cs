namespace BrusAutomat;

public class Transaction
{
    private Drink DrinkToBuy { get; }
    private double IncomingAmount { get; }
    private double Change { get; }

    public Transaction(Drink drinkToBuy, double incomingAmount)
    {
        DrinkToBuy = drinkToBuy;
        IncomingAmount = incomingAmount;
        Change = IncomingAmount - DrinkToBuy.Price;
    }

    public double MakeTransaction()
    {
        Console.WriteLine("Kjøp bekreftet, utleverer vare");
        return Change;
    }
}

