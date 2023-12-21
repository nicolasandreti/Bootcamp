//Array -> reference -> mutable
//Array pada readonly yang tidak bisa diubah bentuk keseluruhannya, value pada array masih bisa diubah
class Car
{
	public readonly int[] brand = {1,2,3,4,5};
	public int year;
	public readonly int price;
}

class Program
{
	static void Main()
	{
		Car a = new();
		a.brand[0] = 6; //value pada readonly array boleh diubah
		a.year = 3000;
		//a.price = 1000; -> error karena int price tidak dapat diubah
	}
}