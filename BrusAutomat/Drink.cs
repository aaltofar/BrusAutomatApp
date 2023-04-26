namespace BrusAutomat;

public class Drink
{
    public string Name { get; }
    public double Price { get; }
    public int Quantity { get; set; }
    public Drink(string name, double price, int quantity)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
    }

}

