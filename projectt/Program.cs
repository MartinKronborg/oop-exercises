Item et = new Item("Tomat",25);

FoodItem to = new FoodItem("hvidløgsflutes",5,79);

NonFoodItem tre = new NonFoodItem("atombombe",7500000,["uran", "plutonium", "steel", "din mor"]);

//Console.WriteLine(et.GetName());
//Console.WriteLine(et.GetPrice());

//Console.WriteLine(to.ToString());

//Console.WriteLine(tre.ToString());


FoodItem[] Items = new FoodItem[10];
for (int i = 0; i < Items.Length; i++)
{
	Items[i] = new FoodItem($"Item {i}",12.3 * i, DateTime.Now.Day);
}

foreach (FoodItem Item in Items)
{
	Console.WriteLine(Item.ToString());
}