class Dog
{
	public string name;
	public string gender;
	public int age;
	public string colour;
	public float weight;
	
	public Dog(string name, string gender, int age, string colour, float weight) //Constructor
	{
		this.name = name;
		this.gender = gender;
		this.age = age;
		this.colour = colour;
		this.weight = weight;
	}
	
	public Dog(string name, int age, string colour) //Overloading
	{
		this.name = name;
		this.age = age;
		this.colour = colour;
	}
	
	public Dog(string name = "unknown", string colour = "unknown") //Overloading dan set value default dengan "unknown" sehingga bisa dikosongkan
	{
		this.name = name;
		this.age = 1;
		this.colour = colour;
	}
	
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