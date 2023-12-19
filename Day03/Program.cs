using Day03;

class Program 
{
	static void Main() 
	{
		Calculator calculator = new();
		int resultOfSum = calculator.Add(3, 4);
		int resultOfMul = calculator.Mul(5, 6);
		Console.WriteLine(resultOfSum);
		Console.WriteLine(resultOfMul);

		int result = calculator.Add("hello",3, 4, 5, 6 , 7, 8, 9, 10, 11);
		Console.WriteLine(result);
	}
}