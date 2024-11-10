using MathTaskClassLibrary;

public class CalculatorTest
{
    Calculator calc = new Calculator();
    [Test]
    public void addition()
    {
        int a, b;
        int expected = 666;

        a = 333;
        b = 333;

        int actual = calc.addition(a, b);
        
        Assert.AreEqual(expected, actual);
    }   
    
    [Test]
    public void Subtraction()
    {
        int a, b;
        int expected = 0;

        a = 333;
        b = 333;

        int actual = calc.Subtraction(a, b);
        
        Assert.AreEqual(expected, actual);
    }

    [Test] 
    public void multiplication()
    {
        int a, b;
        int expected = 9;

        a = 3;
        b = 3;

        int actual = calc.multiplication(a, b);
            
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void division ()
    {
        int a, b;
        int expected = 3;

        a = 9;
        b = 3;

        int actual = calc.division(a, b);
            
        Assert.AreEqual(expected, actual);
    }
}