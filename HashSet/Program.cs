using System.Collections;
class Program
{
	static void Main()
	{
		HashSet<int> hashOne = new HashSet<int>();
		hashOne.Add(1);
		hashOne.Add(2);
		hashOne.Add(3);
		
		HashSet<int> hashTwo = new HashSet<int>();
		hashTwo.Add(2);
		hashTwo.Add(3);
		hashTwo.Add(4);
		
		hashOne.UnionWith(hashTwo);
		Console.WriteLine(hashOne);
		hashOne.IntersectWith(hashTwo);
		foreach(int i in hashOne)
		{
			Console.WriteLine(i);
		}
		hashOne.ExceptWith(hashTwo);
		foreach(int i in hashOne)
		{
			Console.WriteLine(i);
		}
	}
}