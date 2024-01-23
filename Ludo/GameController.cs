namespace Ludo;

public class GameController
{
	public readonly int maxPlayer;
	private int _numOfPlayers;
	private int _playerTurn = 0;
	private IDice _dice;
	private GameStatus _gameStatus; 
	private IBoard _board;
	private List<IPlayer> _turnOrder;
	private Dictionary<IPlayer, PlayerData> _players;
	public GameController(int maxPlayer, IDice _dice, GameStatus _gameStatus)
	{
		this.maxPlayer = maxPlayer;
		this._dice = _dice;
		this._gameStatus = _gameStatus;
	}
	public bool StartGame()
	{
		if (_gameStatus == GameStatus.NotStarted)
		{
			return true;
		}
		else
		{
			return false;
		}
	}
	public GameStatus GetGameStatus()
	{
		return _gameStatus;
	}
	public bool SetGameStatus(GameStatus status)
	{
		if(_gameStatus == status)
		{
			return false;
		}
		else
		{
			_gameStatus = status;
			return true;
		}
	} 
	public bool SetNumOfPlayers(int num){
		if(num < 2 || num > 4)
		{
			return false;
		}
		else
		{
			_numOfPlayers = num;
			return true;
		}
	}
	public bool AddPlayers(IPlayer player){
		if(_turnOrder.Count() >= _numOfPlayers)
		{
			return false;
		}
		else
		{
			_turnOrder.Add(player);
			return true;
		}
	}
	public IBoard CreateFields(int numFields)
	{
		
	}
	+CreateTurnOrder() List~IPlayer~ 
	+GetPlayer(int index) IPlayer
	+AssignPieces(IPlayer player) List~IPiece~
	+GetPlayerPieces(IPlayer player) List~IPiece~
	+GetPiecesStatus(IPlayer player, PieceSatus status) int 
	+GetPiecePosition(IPlayer player, IPiece piece) IField
	+GetPiecesOnField(IField field) List~IPiece~
	+PutPieceInPlay(IPiece piece) bool
	+MovePiece(IPlayer player, int pieceID, int steps) bool 
	+RollDice() int
	+StartTurn(IPlayer player) bool
	+ChangeCurrentTurn(IPlayer player) bool
	+CheckCurrentTurn() IPlayer
	+EndTurn() bool
	+CheckWinner() IPlayer
	+StopGame() bool
}
