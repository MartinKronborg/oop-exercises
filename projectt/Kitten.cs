public class Kitten
{
	public double cuteness;

	public static int count = 0;

	public Kitten(double cuteness){
		this.cuteness = cuteness;
		if (cuteness > 9000)
		{
			Console.WriteLine("The cuteness of this Kitten is above 9000!");
		}
		count++;
	}
}