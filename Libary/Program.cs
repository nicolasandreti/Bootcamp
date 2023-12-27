//Library
//Single Responsibility Principle
//Single class only have single purpose
//Single method only have single purpose
class GameController {
	private GameStatus _gameStatus;
	private IPlayer _player;
	public GameController() {
		_gameStatus = GameStatus.NotInitialized;
	}
	public bool AddPlayer(IPlayer player) {
		if(_player is null) 
		{
			return false;
		}
		if(_gameStatus is not GameStatus.NotInitialized) 
		{
			return false;	
		}
		_player = player;
		_gameStatus = GameStatus.Ready;
		return true;
	}
	public GameStatus CheckGame() 
	{
		return _gameStatus;
	}
	public bool StartGame() 
	{
		if(_gameStatus is not GameStatus.Ready) {
			return false;
		}
		_gameStatus = GameStatus.Playing;
		return true;
	}
}
public enum GameStatus 
{
	NotInitialized,
	Ready,
	Playing,
}
public interface IPlayer
{
	public int ID {get;}
	public string Name {get;}
}


public class Player : IPlayer
{
	public int ID = 1200;
	public string Name = "Nick";

}
class Program
{
	static void Main()
	{
		
	}
}