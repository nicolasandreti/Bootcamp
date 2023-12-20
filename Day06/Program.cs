class Program
{
	static void Main()
	{
		Calculator calculator = new Calculator();
		calculator.x = 10;
		Console.WriteLine(calculator.x);
		calculator.GetY();
		//calculator.z = 5;
	}
}