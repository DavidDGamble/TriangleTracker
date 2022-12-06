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
  }
}