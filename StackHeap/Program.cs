
/* //int biasa -> value type masuknya ke dalam stack
class Program
{
	static void Main()
	{
		int a = 3;
		int b = a;
		b = b+2;
		Console.WriteLine(a);
		Console.WriteLine(b);
	}
}
*/

/* //Class -> Reference type masuknya ke dalam heap (yang dicatat pada heap adalah alamat nya saja)
class Car
{
	public int price;
	public Car(int x)
	{
		price = x;
	}
}

class Program
{
	static void Main()
	{
		Car carA = new Car(3);
		Car carB = carA;
		carB.price = carB.price+2;
		Console.WriteLine(carA.price);
		Console.WriteLine(carB.price);
	}
}
*/

