//Exception
//void Main()
//{
	//Null Reference Exception
	//string x = null;
	//x.Length.Dump();

	//IndexOutOfRangeException
	//int[] myInt = {1,2,3};
	//myInt[3].Dump();

	//RuntimeBinderException
	//dynamic a = "hello";
	//a = 3;
	//a = 3.0f;
	//a.AmbilNilaiSekarangJuga().Dump();
	
	//FormatException
	//string a = "3a";
	//int result = int.Parse(a);
//}
class Program
{
	static void Main()
	{
		Console.WriteLine("Start");
		string a = "3a";
		try
		{
			int result = int.Parse(a);	
		}
		catch(Exception e)//Base Exception
		{
			Console.WriteLine(e.Message);	
		}
		Console.WriteLine("Finish");
	}
}


