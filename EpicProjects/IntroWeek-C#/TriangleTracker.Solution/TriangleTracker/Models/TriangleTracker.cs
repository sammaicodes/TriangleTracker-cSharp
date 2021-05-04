using System;

namespace TriangleDetector
{
  public class Triangle
  {
    // properties, constructors, methods, etc. go here

    public string CompareSides(int sideOne, int sideTwo, int sideThree)
    {
      if ((sideOne + sideTwo) <= sideThree || (sideTwo + sideThree) <= sideOne || (sideOne + sideThree) <= sideTwo)
      {
        return "This is not a triangle.";
      }
      else if (sideOne == sideTwo && sideOne == sideThree)
      {
        return "This is an equalateral triangle.";
      }else if(sideOne == sideTwo || sideOne == sideThree || sideTwo == sideThree){
        return "This is an Isosceles triangle.";
      }
      else
      {
        return "This is a Scalene triangle.";
      }
    }
  }
}

//((sideOne + sideTwo) > sideThree || (sideTwo + sideThree) > sideOne || (sideOne + sideThree) > sideTwo )