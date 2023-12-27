// <T>
class MyCollection<T>
{
	public T[] myCollection;
	public int count;

	public MyCollection(int size)
	{
		myCollection = new T[size];
		count = -1;
	}
	public bool AddObject(T obj)
	{
		if (count == myCollection.Length - 1)
		{
			return false;
		}
		count++;
		myCollection[count] = obj;
		return true;
	}
	public T GetData(int index)
	{
		if (index > myCollection.Length - 1)
		{
			return default;
		}
		return myCollection[index];
	}

}
class Program{
	static void Main() {
		MyCollection<int> myIntCollection = new(3);
		myIntCollection.AddObject(3); //TypeSafety
		myIntCollection.AddObject(4);
		myIntCollection.AddObject(5);
		
		Console.WriteLine(myIntCollection.GetData(0));
		
		
		MyCollection<string> myStringCollection = new(3);
	}
}