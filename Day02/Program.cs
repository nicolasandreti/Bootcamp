class Program
{
	static void Main()
	{
		Hamster hamster = new Hamster();
		
		hamster.name = "Bobby";
		hamster.gender = "Male";
		hamster.age = 2;
		hamster.colour = "black";
		hamster.weight = 0.3f;
		
		hamster.Run();
		Console.WriteLine("Food to eat: ");
		string food = Console.ReadLine();
		hamster.Eat(food);
		hamster.Sleep();
		
		
		Dog ben = new Dog("Ben", "Male", 3, "Brown", 10.5f);
		Console.WriteLine(ben.name);
		Console.WriteLine(ben.age);
		Console.WriteLine(ben.colour);
		
		Dog cupcake = new Dog("Cupcake", "Female", 1, "White", 3.5f);
		Console.WriteLine(cupcake.name);
		Console.WriteLine(cupcake.age);
		Console.WriteLine(cupcake.colour);
	}
}