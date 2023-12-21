using System.Net.Sockets;
using System.Runtime.CompilerServices;

class Program
{
	static void Main()
	{
		int x = 4;
		Adder(x);
		Console.WriteLine(x);
	}
	static void Adder(int a)
	{
		a +=3;
	}
}