//Anonymous Delegate (Lambda Expression)
class Program
{
	static void Main()
	{
		//Method parameter int, int return int+int
		var myFunc = (int a, int b) => 
		{ 
			a += 10;
			b *= 2;
			return a + b; 
		};
		//Method parameter int, return int > 0
		var myFunc2 = (int a) => { return a > 0; };
		//Method void parameter string
		var myAction = (string a) => { Console.WriteLine(a); };
		//Method parameterless & void
		var action = () => { Console.WriteLine("Tidak ngapa ngapain"); };
		
		int result = myFunc(3,4);
		Console.WriteLine(result);
	}
}

