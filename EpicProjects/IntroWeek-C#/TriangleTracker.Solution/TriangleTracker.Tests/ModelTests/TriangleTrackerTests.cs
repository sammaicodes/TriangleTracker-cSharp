using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleDetector;

namespace TriangleDetector.Tests
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void CompareSides_IfSidesMakeTriangle_thisISNotAtraingle()
    {
      Triangle testCompareSides = new Triangle();
      string result = "This is not a triangle.";
      Assert.AreEqual(result, testCompareSides.CompareSides(2,2,8));
    }
    [TestMethod]
    public void CompareSides_IfSidesMakeEqualateralTriangle_thisIsAnEqualateraltraingle()
    {
      Triangle testCompareSides = new Triangle();
      string result = "This is an equalateral triangle.";
      Assert.AreEqual(result, testCompareSides.CompareSides(2,2,2));
    }
    [TestMethod]
    public void CompareSides_IfSidesMakeIsoscelsTriangle_thisIsAnIsoscelesTriangle()
    {
      Triangle testCompareSides = new Triangle();
      string result = "This is an Isosceles triangle.";
      Assert.AreEqual(result, testCompareSides.CompareSides(2,2,3));
    }
    [TestMethod]
    public void CompareSides_IfSidesMakeScaleneTriangle_thisIsAScaleneTriangle()
    {
      Triangle testCompareSides = new Triangle();
      string result = "This is a Scalene triangle.";
      Assert.AreEqual(result, testCompareSides.CompareSides(4,2,3));
    }
    // Test methods go here
  }
}