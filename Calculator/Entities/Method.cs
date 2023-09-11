namespace Calculator.Entities;

public class Method : ICalculator
{
    public int Result { get; }
    
    public void Reset()
    {
        var Result = 0;

    }

    public int Add(int x)
    {
        
        x += Result;
        if (Result > 2147483646)
        {
            throw new OverflowException("Number is out of range");
        }

        return Result;
    }

    public int Subtract(int x)
    {
        x -= Result;
        if (Result < -2147483647)
        {
            throw new OverflowException("Number is out of range");
        }
        return Result;
    }

    public int Multiply(int x)
    {
        x *= Result;
        if (Result >2147483646)
        {
            throw new OverflowException("Number is out of range");
        }

        return Result;
        
    }

    public void Divide(int x)
    {
        if (Result == 0)
        {
            throw new DivideByZeroException("Can't divide by zero");
            
        }
        x /= Result;
        
    }

    public void Modulus(int x)
    {
        x %= Result;
        
    }
}