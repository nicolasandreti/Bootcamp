class Program
{
	static void Main()
	{
		var month = Months.January;
		int day = (int)Months.January;
		Console.WriteLine(day);
		Console.WriteLine(month);
		Console.WriteLine((int)Months.June);
		
		Console.WriteLine((int)Months.August); //14
		Console.WriteLine((int)Months.Septermber); //15
		var month2 = (Months)16; //October
		Console.WriteLine(month2);
	}
}

public enum Months
{
	January = 1,
	February = 3,
	March = 5,
	April = 7,
	May = 9,
	June = 11,
	July = 13,
	August,
	Septermber,
	October,
	November,
	December
}