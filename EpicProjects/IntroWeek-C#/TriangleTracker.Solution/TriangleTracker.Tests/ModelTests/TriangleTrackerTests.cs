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
      Assert.AreEqual(result, testCompareSides.CompareSides(1,2,6));
    }
    // Test methods go here
  }
}