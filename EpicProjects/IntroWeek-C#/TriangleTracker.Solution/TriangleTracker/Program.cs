using System;
using System.Collections.Generic;


namespace TriangleDetector
{
  public class Program
  {
    public static void Main()
    {
      Triangle myTriangle = new Triangle();
      Console.WriteLine("Welcome to triangle the identifyer");
      Console.WriteLine("Plz enter a number for the fisrt side of your triangle.");
      string stringSideOne = Console.ReadLine();
      Console.WriteLine("Plz enter a number for the second side of your triangle.");
      string stringSideTwo = Console.ReadLine();
      Console.WriteLine("Plz enter a number for the third side of your triangle.");
      string stringSideThree = Console.ReadLine();
      int intSideOne = int.Parse(stringSideOne);
      int intSideTwo = int.Parse(stringSideTwo);
      int intSideThree = int.Parse(stringSideThree);
      string result = myTriangle.CompareSides(intSideOne,intSideTwo, intSideThree);
      Console.WriteLine(result);
    }
  }
}