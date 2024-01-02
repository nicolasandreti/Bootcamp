
class Program
{
	static void Main()
	{
		Queue<int> queue = new();
		queue.Enqueue(1);
		queue.Enqueue(2);
		queue.Enqueue(3);
		
		int result = queue.Peek();
		Console.WriteLine(result);
		int result2 = queue.Dequeue();
		Console.WriteLine(result2);
	}
}