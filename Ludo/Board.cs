namespace Ludo;

public interface IBoard
{
	public int NumOfFields {get; set;}
}

public class Board : IBoard
{
	public int NumOfFields {get; set;}
	public readonly int maxFields;
	public List<IField> fields;
	public Board(int NumOfFields, int maxFields = 52)
	{
		this.NumOfFields = NumOfFields;
		this.maxFields = maxFields;
	}
	public bool MakeFields (int NumOfFields)
	{
		for (int i = 0; i < NumOfFields; i++)
		{
			
		}
	}
}