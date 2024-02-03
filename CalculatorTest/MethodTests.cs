using System.Runtime.InteropServices.JavaScript;
using Calculator;
using Calculator.Entities;

namespace CalculatorTest;

public class MethodTests
{
    ICalculator calculator;
    
    [SetUp]
    public void Setup()
    {
        calculator = new Method();
        int x = Result;
    }


    public int Result { get; }
    public int Memory { get; }

    public void Reset()
    {
        throw new NotImplementedException();
    }

    [Test]
    public void AddTest()
    {

        int sum = calculator.Add(2);
        Assert.That(sum, Is.EqualTo(2));
        
    }

    [Test]
    public void SubtractTest()
    {
        int minus = calculator.Subtract(1);
        Assert.That(minus, Is.EqualTo(-1));
    }

    [Test]
    public void MultiplyTest()
    {
        //int Result = 3;
        int mult = calculator.Multiply(3);
        Assert.That(mult, Is.EqualTo(0));
        
    }

    [Test]
    public void Divide()
    {
        int divide = calculator.Divide(3);
        Assert.That(divide, Is.EqualTo(2));    
    }

    [Test]
    public void Modulus()
    {
        int mod = calculator.Modulus(3);
        Assert.That(mod, Is.EqualTo(1)); 
    }

    [Test]
    public void MemoryAdd()
    {
        int memoryAdd = calculator.MemoryAdd(1);
        Assert.That(memoryAdd, Is.EqualTo(1));
        Console.WriteLine(memoryAdd);
    }

    [Test]
    public void MemorySubtract()
    {
        int memorySubtract = calculator.MemorySubtract(1);
        Assert.That(memorySubtract, Is.EqualTo(-1));
        Console.WriteLine(memorySubtract);
    }

    [Test]
    public void MemoryReset()
    {
        int memoryReset = calculator.MemoryAdd(4);
        Console.WriteLine($"MemoryReset is now {memoryReset} ");
        Assert.That(memoryReset, Is.EqualTo(4));

        memoryReset = calculator.ResetMemory();
        Assert.That(memoryReset,Is.EqualTo(1));
        Console.WriteLine($"MemoryReset is now {memoryReset} ");
    }
}
