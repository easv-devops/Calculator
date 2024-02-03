namespace Calculator.Entities;

public class Method : ICalculator
{
    public int Memory { get; set; }
    public int Result { get; set; }
    
    
    public void Reset()
    {
        Result = 0;
    }

    public int Add(int x)
    {
        Result += x;
        if (Result > 2147483646 || Result < -2147483647)
        {
            throw new OverflowException("Number is out of range");
        }
        Console.WriteLine($"Result is: {Result}");
        return Result;
    }

    public int Subtract(int x)
    {
        Result -= x;
        if (Result > 2147483646 || Result < -2147483647)
        {
            throw new OverflowException("Number is out of range");
        }
        Console.WriteLine($"Result is: {Result}");

        return Result;
    }

    public int Multiply(int x)
    {
        Result *= x;
        if (Result > 2147483646 || Result < -2147483647)
        {
            throw new OverflowException("Number is out of range");
        }
        Console.WriteLine($"Result is: {Result}");

        return Result;
        
    }

    public int Divide(int x)
    {
        Result = 6;
        if (x == 0)
        {
            throw new DivideByZeroException("Can't divide by zero");
        }
        Console.WriteLine($"Result is: {Result}");

        Result /= x;
        return Result;
    }

    public int Modulus(int x)
    {
        Result = 4;
        Result %= x;
        Console.WriteLine($"Result is: {Result}");

        return Result;
    }

    public int ResetMemory()
    {
        Memory = 0;
        return Memory;
    }

    public int MemoryAdd(int x)
    {
        Result = x + Memory;
        if (Result > 2147483646 || Result < -2147483647)
        {
            throw new OverflowException("Number is out of range");
        }
        Memory = Result;
        return Memory;
    }

    public int MemorySubtract(int x)
    {
        Result = Memory - x;
        if (Result > 2147483646 || Result < -2147483647)
        {
            throw new OverflowException("Number is out of range");
        }
        Memory = Result;
        return Memory;
    }
    
    public int GetMemory()
    {
        Console.WriteLine($"Memory is: {Memory}");
        return Memory;
    }

}