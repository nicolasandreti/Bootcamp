using System.Numerics;
//Generic Constraint
//Generic : All class can set the type
//Constaint : Limit to a class with condition
class Calculator<T> where T:IAdditionOperators<T,T,T>
{
	public T Addition(T a, T b) 
	{
		return a + b;
	}
}
class Program {
	static void Main() {
		Calculator<decimal> calculator = new();
		var result = calculator.Addition(3,4);
		result.GetType().Dump();
		result.Dump();
	}
}