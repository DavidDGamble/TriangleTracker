using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker;

namespace TriangleTracker.Tests
{
  [TestClass]
  public class TrackerTests
  {
    [TestMethod]
    public void IsTriangle_ThreeGivenSidesMakeTriangle_True()
    {
      Tracker testTracker = new Tracker();
      Assert.AreEqual(true, testTracker.IsTriangle(7, 10, 5));
    }

    [TestMethod]

    public void IsTriangle_ThreeGivenSidesNotTriangle_False()
    {
      Tracker testTracker = new Tracker();
      Assert.AreEqual(false, testTracker.IsTriangle(3, 3, 10));
    }

    [TestMethod]

    public void TriangleType_GivenSidesMakeEquilateral_Equilateral()
    {
      Tracker testTracker = new Tracker();
      Assert.AreEqual("equilateral", testTracker.TriangleType(5, 5, 5));
    }
  }
}