class Program
{
	static void SendMessage(string message)
	{
		Console.WriteLine(message);
	}
	static void Main()
	{
		Action<string> showMessage = SendMessage;
		showMessage("Hello");
	}
}	


/*void Main()
{
	//Action => delegate for method with no return value (void)
	Action myAction = Print;
	myAction.Invoke();
	Action<string> myActionString = Print;
	myActionString.Invoke("message");
}
void Print(){
	"Print".Dump();
}
void Print(string message)
{
	message.Dump();
}
class Publisher {
	Action<int, int> subscriber;
}
*/
