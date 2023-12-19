namespace Day03;

public class Calculator
{
	public int Add(params int[] numbers) //Untuk berapapun parameter yang ada dijadikan list
	{
		int result = 0;
		foreach(int number in numbers ) 
		{
			result = result + number;
		}
		return result;
	}
	public int Add(string a, params int[] numbers) //Params harus ada di belakang
	{
		int result = 0;
		foreach(int number in numbers ) 
		{
			result = result + number;
		}
		return result;
	}

	public int Mul(int a, int b) 
	{
		return a * b;
	}
}
