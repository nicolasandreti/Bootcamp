class Car
{
	public readonly int year;
	public const string brand = "Toyota"; //Const wajib diisi terlebih dahulu valuenya
	
	public Car(int year)
	{
		this.year = year;
	}
	public void GetYear()
	{
		Console.WriteLine(year);
	}
	public void GetBrand()
	{
		Console.WriteLine(brand);
	}
}

class Program
{
	static void Main()
	{
		Car car = new Car(2009);
		car = new Car(2008);
		car.GetYear();
		car.GetBrand();
	}
}