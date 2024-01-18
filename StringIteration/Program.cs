using System.Diagnostics;

class Program
{
	static void Main()
	{
		string a  = String.Empty;
		int iteration = 10000;
		
		Stopwatch stopwatch = new();
		stopwatch.Start();
		for(int i = 0; i<iteration; i++)
		{
			a += "Hello";
			a += "World";
		}
		stopwatch.Stop();
		Console.WriteLine(stopwatch.ElapsedMilliseconds);
	}
}