#define BCD
#define CDD

class Program
{
	static void Main()
	{
		
		#if ABC
		Console.WriteLine("Hello, ABC!");
		
		#elif BCD
		Console.WriteLine("Hello, BCD!");
		
		#else
		Console.WriteLine("Hello, CDE!");
		
		#endif
	}
}
