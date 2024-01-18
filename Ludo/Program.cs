﻿classDiagram

IPiece <|.. PlayerPiece
Board "1" *-- "52" IField
Field *-- IPiece
PlayerPiece *-- PieceStatus
PlayerPiece *-- Colors
PlayerData *-- IPiece

IPlayer <|.. Player
IDice <|.. Dice
IBoard <|.. Board
IField <|.. Field

GameController "1" *-- "2..4" IPlayer
GameController *-- IBoard
GameController *-- IDice
GameController *-- PlayerData
GameController *-- GameStatus

class IPlayer{
    +int Id ~get; private set;~
    +string Name ~get; private set;~
    +GetName() string
}

class Player{
    -int Id ~get; private set;~
    -string Name ~get; private set;~
    +Player(int id, string name)
    +GetName() string
}

class PlayerData{
    +List~IPiece~ pieces
}

class Colors{
    <<enumeration>>
    Red = 0,
    Blue = 13,
    Yellow = 26,
    Green = 39
}

class IDice{
    +int NumOfSides ~get; private set;~
    +Roll() int
}

class Dice{
    +int NumOfSides ~get; private set;~
    +Dice(int numOfSides)
    +Roll() int    
}

class IPiece{
    <<interface>>
    +int Id ~get; private set;~
    +int Position ~get; set;~
    +int StartPosition ~get; private set;~
    +bool CanMove ~get; private set;~
    +Move(int steps)    
}

class PlayerPiece{
    +int Id ~get; private set;~
    +int Position ~get; private set;~
    +int StartPosition ~get; private set;~
    +bool CanMove ~get; private set;~
    +int Counter ~get; set;~
    +int counterMax : readonly
    +Colors color : readonly 
    +PlayerPiece(int id, int startPosition, PieceStatus status, int counterMax = 52, Colors color)
    +Move(IField field, int steps) 
    +IsInPlay() bool
    +SetStatus(PieceStatus status)
    +GetStatus() PieceStatus
    +ResetPiece()
}

class PieceStatus{
    <<enumeration>>
    Home,
    InPlay,
    Safe,
    Finished
}

class IBoard{
    +int NumOfFields~get; private set;~
    +List~IField~ fields
    +MakeFields() bool
}

class Board{
    +int NumOfFields~get; private set;~
    +int maxFields : readonly
    +List~IField~ fields
    +Board(int NumOfFields, int maxFields = 52)
    +MakeFields(int NumOfFields) bool
}

class IField{
    +int Id ~get; private set;~
    +GetFieldId() int;
}

class Field{
    +int Id ~get; private set;~
    +int maxPiece = 4 : readonly
    -List~IPiece~ pieces 
    -bool _occupied
    +Field(int Id, bool occupied = false)
    +GetFieldId() int
    +AddPiece(int pieceID) bool
    +GetPieces() List~IPiece~
    +IsOccupied() bool
    +Occupy()
}

class GameStatus{
    <<enumeration>>
    NotStarted,
    Play,
    Finish
}

class GameController{
    +int maxPlayer : readonly
    -int _numOfPlayers
    -int _playerTurn = 0
    -IDice _dice
    -GameStatus _gameStatus 
    -IBoard _board
    -List~IPlayer~ _turnOrder 
    -Dictionary~IPlayer, PlayerData~ _players
    +GameController(int maxPlayer = 4, IDice dice, GameStatus status) 
    +StartGame() bool
    +GetGameStatus() GameStatus
    +SetGameStatus(GameStatus status) 
    +SetNumOfPlayers(int num) bool
    +AddPlayers(IPlayer player) bool
    +CreateFields(int numFields) IBoard
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