public interface IPrinter {
	void Fax();
	void Scan();
	void Print();
}
public class Printer1Juta : IPrinter
{
	public void Fax()
	{
		Console.WriteLine(" Printer1Juta Fax lemot");
	}

	public void Print()
	{
		Console.WriteLine(" Printer1Juta Print A4 Medium Resolution");
	}

	public void Scan()
	{
		Console.WriteLine(" Printer1Juta Scan low resolution");
	}
}
public class Printer30Juta : IPrinter
{
	public void Fax()
	{
		Console.WriteLine(" Printer30Juta Fax");
	}

	public void Print()
	{
		Console.WriteLine(" Printer30Juta Print A0 8KHD");
	}

	public void Scan()
	{
		Console.WriteLine(" Printer30Juta Scan");
	}
}

class Program {
	static void Main() {
		Printer(new Printer30Juta());
		Printer(new Printer1Juta());
	}
	static void Printer(IPrinter printer) {
		printer.Print();
	}
}