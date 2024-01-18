
using System.Text;
using BenchmarkDotNet.Attributes;
[MemoryDiagnoser]
public class StringBenchmarker 
{
	[Params(1, 10,100)]
	public int N;
	[Params(234, 10,100)]
	public int B;
	
	[Benchmark]
	public void StringTest()
	{
		string a = "";
		for(int i = 0; i < N; i++) 
		{
			a += i.ToString();
		}
	}
	[Benchmark]
	public void StringBuilderTest() 
	{
		StringBuilder sb = new();
		for(int i = 0; i < N; i++) 
		{
			sb.Append(i);
		}
	}
	// [Benchmark]
	// public void ListStringTest() 
	// {
	// 	List<char> sb = new();
	// 	for(int i = 0; i < N; i++) 
	// 	{
	// 		sb.Add(i);
	// 	}
	// }
}