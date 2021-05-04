namespace TriangleDetector
{
  public class Triangle
  {
    // properties, constructors, methods, etc. go here

    public string CompareSides(int sideOne, int sideTwo, int sideThree)
    {
      if ((sideOne + sideTwo) > sideThree)
      {
        return "This is not a triangle.";
      }
      else
      {
        return "aaaaaaaaaaa";
      }
    }
  }
}

//((sideOne + sideTwo) > sideThree || (sideTwo + sideThree) > sideOne || (sideOne + sideThree) > sideTwo )