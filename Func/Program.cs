using System.Security.Cryptography.X509Certificates;

class Program
{
	static void Main()
	{
		Func<int> showNum1 = ShowNumber;
		Func<int, int> showNum2 = ShowNumber2;
		
		Func<string, int> myFunc = ShowString;
		
		int ShowNumber()
		{
			return 2;
		}
		
		int ShowNumber2(int number)
		{
			return number;
		}
		
		int ShowString(string message)
		{
			return int.Parse(message);
		}
		
		showNum1();
		showNum2(4);
		myFunc("Hello");
	}
}

/*
void Main()
{
	//Func -> delegate for method with return value
	
	//public delegate int Func();
	Func<int> myFunc = ShowNumber;
	//public delegate int Func(string message);
	Func<string, int> myFunc2 = ShowNumber;
	//public delegate bool Func(string a,int b);
	Func<string,int,bool> myFunc3 = ShowNumber;
}
int ShowNumber() {
	return 3;
}
int ShowNumber(string message)
{
	return int.Parse(message);
}
bool ShowNumber(string message, int x)
{
	return true;
}
*/
