namespace Ludo;

public interface IPlayer
{
	public int Id {get;}
	public string Name {get;}
}

public class Player : IPlayer
{
	public int Id {get;}
	public string Name {get;}
	public Player(int Id, string Name)
	{
		this.Id = Id;
		this.Name = Name;
	}
	public string GetName()
	{
		return Name;
	}
}
