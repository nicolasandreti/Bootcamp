namespace Ludo;

public interface IPiece
{
	public int Id {get; set;}
	public int Position {get; set;} 
	public int StartPosition {get; set;}
	public bool CanMove {get; set;}
}

public class PlayerPiece : IPiece
{
	public int Id {get; set;}
	public int Position {get; set;} 
	public int StartPosition {get; set;}
	public bool CanMove {get; set;}
	public int Counter {get; set;}
	public readonly int counterMax;
	
}