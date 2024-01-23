namespace Ludo;

public interface IDice
{
	public int NumOfSides {get; set;}
}

public class Dice : IDice
{
	public int NumOfSides {get; set;}
	public Dice(int NumOfSides)
	{
		this.NumOfSides = NumOfSides;
	}
	public int Roll()
	{
		Random random = new();
		return random.Next(1,7); //randomize 1 to 6
	}
}