using System.Collections; //needed to use IEnumerator<T>
class Program
{
	static void Main()
	{
		int[] myInt = { 1, 2, 3 };
		IEnumerator enumerator = myInt.GetEnumerator();
		enumerator.MoveNext().Dump();
		enumerator.Current.Dump();
		enumerator.MoveNext().Dump();
		enumerator.Current.Dump();
		enumerator.MoveNext().Dump();
		enumerator.Current.Dump();
		enumerator.MoveNext().Dump();
		enumerator.Reset();
		enumerator.MoveNext().Dump();
		enumerator.Current.Dump(); //-1
	}
}

public static class StringExtensionToolThatHelpEachOther {
	public static void Dump(this object x) {
		Console.WriteLine(x);
	}
}