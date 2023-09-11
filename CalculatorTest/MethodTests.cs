using System.Runtime.InteropServices.JavaScript;
using Calculator;
using Calculator.Entities;

namespace CalculatorTest;

public class MethodTests
{

    public int AddX(int x)
    {
        return x + Result;
    }
    
    ICalculator calculator;
    
    [SetUp]
    public void Setup()
    {
        calculator = new Method();
        int x = Result;
    }


    public int Result { get; }

    public void Reset()
    {
        throw new NotImplementedException();
    }

    [TestCase(1)]
    public void Add(int x)
    {

        int sum = calculator.Add(7);
        Assert.That(sum, Is.EqualTo(7));
        
    }

    [TestCase(2)]
    public void Subtract(int x)
    {
        int minus = calculator.Subtract(1);
        Assert.That(minus, Is.EqualTo(-1));
    }

    [TestCase(3)]
    public void Multiply(int x)
    {
        //int Result = 3;
        int mult = calculator.Multiply(3);
        Assert.That(0, Is.EqualTo(Result));
        
    }

    public void Divide(int x)
    {
        throw new NotImplementedException();
    }

    public void Modulus(int x)
    {
        throw new NotImplementedException();
    }
}