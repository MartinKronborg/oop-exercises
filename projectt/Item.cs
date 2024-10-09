public class Item
{
	string name;
	double price;

	public string GetName()
	{
		return name;
	}
	public double GetPrice()
	{
		return price;
	}

	public Item(string name,double price)
	{
		this.name = name;
		this.price = price;
	}

}