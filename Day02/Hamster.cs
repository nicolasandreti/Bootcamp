class Hamster
{
	public string name;
	public string gender;
	public int age;
	public string colour;
	public float weight;
	
	public void Run()
	{
		Console.WriteLine("RUN!");
	}
	
	public void Eat(string food)
	{
		Console.WriteLine($"{name} is eating {food}");
	}
	
	public void Sleep()
	{
		Console.WriteLine(name+" is sleeping");
	}
}