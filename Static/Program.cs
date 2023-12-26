static class Calculator
{
	const int phi = 314;
	
	public static int Add(int a, int b)
	{
		return a+b;
	}
	public static int Circle(int r)
	{
		return phi*r*r;
	}
}

class Human
{
	public string name;
	public static int count = 0;
	public Human(string name)
	{
		count++;
		this.name = name;
	}
	public static int Counter()
	{
		return count;
	}
	public string GetName()
	{
		return name;
	}
}

class Program
{
	static void Main()
	{
		Human human1 = new Human("a");
		Console.WriteLine(human1.GetName());
		Console.WriteLine(Human.Counter());
		Human human2 = new Human("b");
		Console.WriteLine(human2.GetName());
		Console.WriteLine(Human.Counter());
		Human human3 = new Human("c");
		Console.WriteLine(human3.GetName());
		Console.WriteLine(Human.Counter());
		
		Console.WriteLine(Calculator.Add(1,5));
		Console.WriteLine(Calculator.Circle(7));
	}
}