public delegate void MySubscriber(string message);
class Youtuber
{
	private event MySubscriber mySubscriber;
	public bool AddSubscriber(MySubscriber sub) 
	{
		if(mySubscriber is null) {
			mySubscriber += sub;
			return true;
		}
		if(mySubscriber.GetInvocationList().Contains(sub)) {
			return false;
		}
		mySubscriber += sub;
		return true;
	}
	public void UploadVideo()
	{
		Console.WriteLine("Uploading video...");
		Console.WriteLine("Finished....");
		SendNotification("Here is my new video");
	}
	public void SendNotification(string message)
	{
		mySubscriber.Invoke(message);
	}
}
class Subscriber
{
	public void GetNotification(string message)
	{
		Console.WriteLine("Subscriber get notified : " + message);
	}
}

//Check if an instance method already registered
class Program 
{
	static void Main()
	{
		Subscriber sub1 = new Subscriber();
		Subscriber sub2 = new Subscriber();
		Subscriber sub3 = new Subscriber();

		Youtuber youtuber = new Youtuber();
		youtuber.AddSubscriber(sub1.GetNotification);
		youtuber.AddSubscriber(sub1.GetNotification);
		youtuber.AddSubscriber(sub3.GetNotification);
		youtuber.UploadVideo();
	}
}

