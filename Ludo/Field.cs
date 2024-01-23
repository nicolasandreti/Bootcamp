namespace Ludo;

public interface IField
{
	public int Id {get; set;}
}

public class Field : IField
{
	public int Id {get; set;}
	public readonly int maxPiece = 4;
	private List<IPiece> _pieces;
	private bool _occupied;
	public Field(int Id, bool occupied)
	{
		this.Id = Id;
		this._occupied = occupied;
	}
	public int GetFieldId()
	{
		return Id;
	}
	public bool AddPiece(IPiece Piece)
	{
		if(_pieces.Count() < maxPiece)
		{
			_pieces.Add(Piece);
			return true;
		}
		else
		{
			return false;
		}
	}
	
	public List<IPiece> GetPieces()
	{
		return _pieces;
	}
	public bool IsOccupied()
	{
		if (_occupied = false && _pieces.Count() < 1)
		{
			return false;
		}
		else
		{
			return true;
		}
	}
	public void Occupy()
	{
		_occupied = true;
		
	}
}