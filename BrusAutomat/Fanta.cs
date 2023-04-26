namespace BrusAutomat;

internal class Fanta : IDrink
{
    public string Name { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }

    public Fanta(string name, double price, int count)
    {
        Name = name;
        Price = price;
        Quantity = count;
    }
}


