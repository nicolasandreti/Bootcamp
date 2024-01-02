using System.Collections;
class Program
{
	static void Main()
	{
		Dictionary<int, string> dict = new();
		dict.Add(3, "hey");
		dict.Add(5, "world");
		Console.WriteLine(dict.ContainsValue("WORLD".ToLower()));
		foreach (KeyValuePair<int, string> kvp in dict) //print out Dictionary's keys and values
		{
			Console.WriteLine(kvp.Key);
			Console.WriteLine(kvp.Value);
		}
		
		foreach(int key in dict.Keys) //Print out Dictionary's keys
		{
			Console.WriteLine(key);
		}
		
		foreach(string value in dict.Values) //print out Dictionary's values
		{
			Console.WriteLine(value);
		}
	}
	
}