using System.Numerics;
//Operator Overloading
public class Car : IAdditionOperators<Car, Car, Car>
{
	public int price;
	public int year;
	public string name;
	public Car(int price, int year, string name)  
	{
		this.price = price;
		this.year = year;
		this.name = name;
	}
	//Operator Overloading
	public static Car operator +(Car left, Car right) 
	{
		Car resultCar = new Car(left.price+right.price, 0, "");
		return resultCar;
	}
}
class Program{
	static void Main() {
		Car car = new Car(3000,10,"a");
		Car carb = new Car(5500,11,"b");
		Car carc = new Car(1000,11,"c");
		Car carprice = car + carb + carc;
		carprice.price.Dump();
	}
}