namespace BrusAutomat;
public class Storage
{
    private double CashSupply { get; set; }
    public List<IDrink> DrinkInventory { get; set; }

    public Storage()
    {
        DrinkInventory = new List<IDrink>();
    }

    public void RestockDrinks(List<IDrink> drinksToRestock)
    {
        foreach (var drink in drinksToRestock)
            foreach (var d in DrinkInventory)
                if (drink.Name == d.Name)
                    d.Quantity += drink.Quantity;
    }

    public void ExpendDrink(IDrink drinkToGive)
    {
        for (int i = 0; i < DrinkInventory.Count; i++)
            if (drinkToGive.Name == DrinkInventory[i].Name)
                DrinkInventory[i].Quantity--;

        Console.WriteLine($"Utleverer 1stk {drinkToGive.Name}");
    }

    public void AddNewDrink(IDrink drinkToAdd)
    {
        foreach (var d in DrinkInventory)
            if (drinkToAdd.Name == d.Name)
                return;

        DrinkInventory.Add(drinkToAdd);
    }

    public void RemoveDrink(IDrink drinkToRemove)
    {
        for (int i = 0; i < DrinkInventory.Count; i++)
            if (drinkToRemove.Name == DrinkInventory[i].Name)
                DrinkInventory.RemoveAt(i);
    }

    public void AddCash(double cashToAdd)
    {
        CashSupply += cashToAdd;
    }
}

