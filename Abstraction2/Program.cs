class Human {
	public string Name {get;}
	private Student _student;
	public Human(string name,Student student) 
	{
		Name = name;
		_student = student;
	}
	public void CheckCollege() 
	{
		Console.WriteLine(_student.College());
	}
	public void CheckHighSchool()
	{
		Console.WriteLine(_student.HighSchool());
	}
}
abstract class Student
{
	public abstract string HighSchool();
	public abstract string College();
}
class JakartaStudent : Student
{
	public override string HighSchool()
	{
		 return "SMA 1 Jakarta";
	}
	public override string College()
	{
		return "Binus";
	}
}
class JogjakartaStudent : Student
{
	public override string College()
	{
		return "UGM";
	}
	public override string HighSchool()
	{
		return "DB2";
	}
}

class Program
{
	static void Main()
	{
		Human human = new Human("Budi", new JakartaStudent());
		Console.WriteLine("Name : " + human.Name);
		human.CheckCollege();
		human.CheckHighSchool();
	}
}