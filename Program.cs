using System;
using System.Collections.Generic;
using Queen;

namespace Chess
{
  public class Program
  {
    public static void Main()
    {
      
      Console.WriteLine("Enter the queen's X coordinates: ");
      string queenXCoordinate = Console.ReadLine();
      int queenX = int.Parse(queenXCoordinate);
      Console.WriteLine("Enter the queen's Y coordinates: ");
      string queenYCoordinate = Console.ReadLine();
      int queenY = int.Parse(queenYCoordinate);
      Console.WriteLine("Enter your pieces X coordinates: ");
      string userPieceXCoordinate = Console.ReadLine();
      int userPieceX = int.Parse(userPieceXCoordinate);
      Console.WriteLine("Enter your piece's Y coordinates: ");
      string userPieceYCoordinate = Console.ReadLine();
      int userPieceY = int.Parse(userPieceYCoordinate);

      Attack chessPieces = new Attack(queenX, queenY, userPieceX, userPieceY);
      Console.WriteLine(chessPieces.CheckAttack());
    }
  }
}