class Youtuber
{
	public string Name { get; }
	public event EventHandler<MyEventArgs> mySubscriber;
	public Youtuber(string name)
	{
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
		mySubscriber?.Invoke(this, new MyEventArgs(){data = " hopes you enjoy the new video."});
	}
	public override string ToString()
	{
		return Name;
	}
}
class Subscriber
{
	public void GetNotification(object sender, MyEventArgs e)
	{
		Console.WriteLine("Subscriber get notified : " + sender + e.data);
	}
}
class MyEventArgs : EventArgs {
	public string data;
	public int data2;
}

//EventHandler
// ? -> null checking
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
	}
}

