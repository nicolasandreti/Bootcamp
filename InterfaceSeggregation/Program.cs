//INTERFACE SEGGREGATION PRINCIPLE
public interface IPrint
{
	void Print();
}
public interface IFax {
	void Fax();
}
public interface IScan {
	void Scan();
}
public interface IPrinterMahal : IPrint, IFax, IScan {}

public class Printer150Ribu : IPrint
{
	public void Print()
	{
		Console.WriteLine("Print150Ribu Grayscale B5");
	}
}
public class Printer1Juta : IPrinterMahal
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
public class Printer30Juta : IPrinterMahal
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
		Printer(new Printer1Juta());
		Printer(new Printer150Ribu());
		PrinterBisaScan(new Printer30Juta());
	}
	static void Printer(IPrint printer) {
		printer.Print();
	}
	
	static void PrinterBisaScan(IPrinterMahal scan)
	{
		scan.Print();
		scan.Scan();
	}
}