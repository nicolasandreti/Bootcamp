//Extension Method
//Extend or add method to locked library/class
class Program{
	static void Main()
	{
		String myString = "asd";
		true.Dump();
		
		int result = 1.Tambah(1,3);
		result.Dump();
	}
}
// 1. Static class public
// 2. Static method public
// 3. this
public static class StringExtensionToolThatHelpEachOther {
	public static void Dump(this object x) {
		Console.WriteLine(x);
	}
	public static int Tambah(this int x, int y, int z)
	{
		return x + y + z;
	}
}

