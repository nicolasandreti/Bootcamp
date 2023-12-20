class Animal
{
	public int age;
	public string name;
	
	public Animal(int age, string name)
	{
		this.age = age;
		this.name = name;
	}
	public Animal()
	{
		Console.WriteLine("Parent Animal");
	}
}