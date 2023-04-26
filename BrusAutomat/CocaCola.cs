namespace BrusAutomat;
internal class CocaCola : IDrink
{
    public string Name { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }

    public CocaCola(string name, double price, int count)
    {
        Name = name;
        Price = price;
        Quantity = count;
    }
}

