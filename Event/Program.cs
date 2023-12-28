public delegate void MySubscriber(string message);

class Youtuber
{
	public event MySubscriber mySubscriber;
	public void UploadVideo() {
		Console.WriteLine("Uploading video...");
		Console.WriteLine("Finished....");
		SendNotification("Here is my new video");
	}
	public void SendNotification(string message) {
		mySubscriber.Invoke(message);
	}
}
class Subscriber {
	public void GetNotification(string message) {
		Console.WriteLine("Subscriber get notified : " + message);
	}
}

//Event
class Program 
{
	static void Main() 
	{
		Subscriber sub1 = new Subscriber();
		Subscriber sub2 = new Subscriber();
		Subscriber sub3 = new Subscriber();
		
		Youtuber youtuber = new Youtuber();
		youtuber.mySubscriber += sub1.GetNotification;
		youtuber.mySubscriber += sub1.GetNotification;
		youtuber.mySubscriber += sub1.GetNotification;
		youtuber.mySubscriber += sub1.GetNotification;
		youtuber.mySubscriber -= sub1.GetNotification;
		//youtuber.mySubscriber = sub3.GetNotification;
		//cant use  = for event keyworded delegate
		youtuber.UploadVideo();
	}
}

