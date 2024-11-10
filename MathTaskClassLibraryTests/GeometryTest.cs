using MathTaskClassLibrary;

namespace MathTaskClassLibraryTests;

public class Test
{
    [Test]
    public void RectangleArea_3and5_15returned()
    {
        int a = 3;
        int b = 5;

        int expected = 15;

        Geometry g = new Geometry();
        int actual = g.RectangleArea(a, b);
        
        
        Assert.AreEqual(expected, actual);
    }
}