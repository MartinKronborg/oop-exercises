public class FoodItem: Item
{
	double DateTime;

	public double GetDate()
	{
		return DateTime;
	}

	public FoodItem(string name, double price, double DateTime) : base(name,price)
	{
		this.DateTime = DateTime;
	}

	public override string ToString()
	{
		return "FoodItem name= '" + GetName() + "'" 
						+ " price= '" + GetPrice() + "'"
						+ " expiresAt= '" + GetDate() + "' days.";
	}
}
