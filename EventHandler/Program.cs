class Publisher {
	public string Name {get;}
	public Publisher(string name) {
		Name = name;
	}
	public event EventHandler mySubscriber;
	public void SendNotification() {
		mySubscriber?.Invoke(this, EventArgs.Empty);
	}
	public override string ToString()
	{
		return Name;
	}
}
class Youtuber
{
	public string Name {get;}
	public event EventHandler mySubscriber;
	public Youtuber(string name) {
		Name = name;
	}
	public void UploadVideo()
	{
		Console.WriteLine("Uploading video...");
		Console.WriteLine("Finished....");
		SendNotification("Here is my new video");
	}
	public void SendNotification(string message)
	{
		mySubscriber?.Invoke(this,EventArgs.Empty); //? -> null checking similar to (if ... is not null)
	}
	public override string ToString()
	{
		return Name;
	}
}
class Subscriber
{
	public void GetNotification(object sender, EventArgs e)
	{
		Console.WriteLine("Subscriber get notified : " + sender);
	}
}

//EventHandler
class Program 
{
	static void Main()
	{
		Subscriber sub1 = new Subscriber();
		Subscriber sub2 = new Subscriber();
		Subscriber sub3 = new Subscriber();
		
		Youtuber youtuber = new Youtuber("Yusuf");
		youtuber.mySubscriber += sub3.GetNotification;
		//cant use  = for event keyworded delegate
		youtuber.UploadVideo();

		Youtuber youtuber2 = new Youtuber("Yanto");
		youtuber2.mySubscriber += sub3.GetNotification;
		//cant use  = for event keyworded delegate
		youtuber2.UploadVideo();

		Publisher publisher = new("Jarot");
		publisher.mySubscriber += sub3.GetNotification;
		publisher.SendNotification();
		
		Publisher publisher2 = new("Budi");
		publisher2.mySubscriber += sub3.GetNotification;
		publisher2.SendNotification();
	}
}
