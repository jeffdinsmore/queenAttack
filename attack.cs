namespace Queen
{
  public class Attack
  {
    private int _queenX;
    private int _queenY;
    private int _userPieceX;
    private int _userPieceY;

    public Attack(int queenX, int queenY, int userPieceX, int userPieceY)
    {
      _queenX = queenX;
      _queenY = queenY;
      _userPieceX = userPieceX;
      _userPieceY = userPieceY;
    }

    public bool CheckNumber(int coordinates)
    {
      return (coordinates >= 1 && coordinates <= 8);
    }

    public string CheckAttack() 
    {
      if (_queenX == _userPieceX || _queenY == _userPieceY || (_queenX - _userPieceX) == (_queenY - _userPieceY))
      {
        return ("The queen has taken your piece! You lose!");
      } 
      else
      {   
        return ("You have evaded the queen!");
      }
    }
  }
}
