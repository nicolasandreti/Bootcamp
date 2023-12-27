//Publisher
class GameController
{
	public MyDelegate mySubscriber;
	public GameController()
	{
	}
	public void UpdateGameStatus()
	{
		string status = "game Running";
		mySubscriber.Invoke(status);
	}
}

//Subscriber
class SMS
{
	public void SendSMS(string message)
	{
		Console.WriteLine("SMS " + message);
	}
}
class Email
{
	public void SendEmail(string message) { 
		Console.WriteLine("Email " + message);
	}
}
class Database
{
	public void InputDatabase(string message) {
			Console.WriteLine("Database " + message);
	}
}
class API
{
	public void SendApiRequest(string message) { 
		Console.WriteLine("API " + message);
	}
}
class Radio
{
	public void SendRadio(string messaage) {}
}

//The Delegate
public delegate void MyDelegate(string message);

//Program
class Program
{
	static void Main()
	{
		GameController game = new GameController();
		SMS sms = new SMS();
		Email email = new Email();
		Database database = new Database();
		API api = new API();
		Radio radio = new Radio();
		//Register listener to the delegate
		game.mySubscriber = sms.SendSMS;
		game.mySubscriber += email.SendEmail;
		game.mySubscriber += api.SendApiRequest;
		game.mySubscriber += database.InputDatabase;
		game.mySubscriber += radio.SendRadio;
		//Invoke
		game.UpdateGameStatus();
	}
}