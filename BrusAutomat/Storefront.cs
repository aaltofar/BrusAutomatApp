namespace BrusAutomat;

public class Storefront
{
    private int AvailableChoices { get; set; }
    public double CustomerCoinBalance { get; set; }

    public bool ChooseDrink(int choice)
    {
        if (choice > 0 && choice < AvailableChoices)
            return true;

        return false;
    }

    public bool HasEnoughMoney(double price)
    {
        if (CustomerCoinBalance > price)
            return true;

        return false;
    }

    public void InsertCoins(double coins)
    {
        CustomerCoinBalance += coins;
        Console.WriteLine($"Du la inn {coins}kr");
    }

    public void RefreshChoiceList(int choices)
    {
        AvailableChoices = choices;
    }
}

