namespace BrusAutomat;

public class Storage
{
    private double CashSupply { get; set; }
    public List<Drink> DrinkInventory { get; init; }

    public Storage()
    {
        DrinkInventory = new List<Drink>();
    }

    public void AddCashToStorage(double cashToAdd)
    {
        CashSupply += cashToAdd;
    }

    public void ExpendDrink(Drink drinkToGive)
    {
        for (var i = 0; i < DrinkInventory.Count; i++)
            if (drinkToGive.Name == DrinkInventory[i].Name)
                DrinkInventory[i].Quantity--;

        Console.WriteLine($"Utleverer 1stk {drinkToGive.Name}");
    }

    public void AddNewDrink(string drinkName, double drinkPrice, int drinkQuantity)
    {
        DrinkInventory.Add(new Drink(drinkName, drinkPrice, drinkQuantity));
    }

    public bool IsValidChoice(int choice)
    {
        if (DrinkIsInStock(choice) && ChoiceExists(choice))
            return true;

        return false;
    }

    private bool DrinkIsInStock(int choice)
    {
        return DrinkInventory[choice].Quantity > 0;
    }

    private bool ChoiceExists(int choice)
    {
        return 0 <= choice && choice <= DrinkInventory.Count;
    }

    //public void RestockDrinks(List<Drink> drinksToRestock)
    //{
    //    foreach (var drink in drinksToRestock)
    //        foreach (var d in DrinkInventory)
    //            if (drink.Name == d.Name)
    //                d.Quantity += drink.Quantity;
    //}


    //public void RemoveDrink(Drink drinkToRemove)
    //{
    //    for (var i = 0; i < DrinkInventory.Count; i++)
    //        if (drinkToRemove.Name == DrinkInventory[i].Name)
    //            DrinkInventory.RemoveAt(i);
    //}
}

