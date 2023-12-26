abstract class Animal
{
	protected int age;
	protected string name;
	public Animal(int age, string name)
	{
		this.age = age;
		this.name = name;
	}
	protected abstract void MakeSound();
	public virtual void Run()
	{
		Console.WriteLine("Animal running!");
	}
	
}

class Dog : Animal
{
	public Dog(int age, string name) : base(age, name)
	{
		
	}
	protected override void MakeSound()
	{
		Console.WriteLine("Bark!");
	}
	public override void Run()
	{
		Console.WriteLine("Dog is running!");
	}
}

class Program
{
	static void Main()
	{
		Animal animal = new Dog(5, "Donut");
		Console.WriteLine("Dog's age is "+animal.age); //Error karena age protected
		Console.WriteLine("Dog's name is "+animal.name); //Error karena name protected
		animal.MakeSound(); //Error karena MakeSound() protected
		animal.Run();
	}
}