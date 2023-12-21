using System.Diagnostics;
using System.Text;

/* //String biasa(immutable)
class Program
{
	static void Main()
	{
		int iteration = 100000;
		string a = String.Empty; //sama sajaa dgn string a = ""
		Stopwatch sw = new Stopwatch();
		sw.Start();
		for(int i = 0; i < iteration; i++)
		{
			a += "a";
			a += "b";
			a += "c";
		}
		sw.Stop();
		Console.WriteLine(sw.ElapsedMilliseconds);
	}
}
*/

//String builder => string dengan jenis mutable
class Program
{
	static void Main()
	{
		int iteration = 100000;
		StringBuilder sb = new StringBuilder();
		Stopwatch sw = new Stopwatch();
		sw.Start();
		for(int i = 0; i < iteration; i++)
		{
			sb.Append("a");
			sb.Append("b");
			sb.Append("c");
		}
		sw.Stop();
		Console.WriteLine(sw.ElapsedMilliseconds);
	}
}