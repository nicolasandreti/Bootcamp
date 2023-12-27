public delegate void MyDelegate(string message);
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
class SMS
{
	public void SendSMS(string message) { 
		Console.WriteLine("SMS " + message);
	}
}
class Program
{
	static void Main()
	{
		GameController game = new GameController();
		SMS sms = new SMS();
		
		game.mySubscriber = sms.SendSMS;
		game.UpdateGameStatus();
	}
}