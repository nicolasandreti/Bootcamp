﻿class Parent
{
	private string _name = "parent";
	protected int age = 2;
	public void ParentMethodA()
	{
		Console.WriteLine("Its parent");
	}
	protected void ParentMethodB()
	{
		Console.WriteLine("Its parent B");
	}
}

class Child : Parent

{
	public void GetAge()
	{
		Console.WriteLine(age);
	}
}

class Program
{
	static void Main()
	{
		Child child = new Child();
		child.GetAge();
	}
}