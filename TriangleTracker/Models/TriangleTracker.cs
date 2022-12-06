namespace TriangleTracker
{
  public class Tracker 
  {
    public bool IsTriangle(int side1, int side2, int side3)
    {
      if (side1 + side2 > side3)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}