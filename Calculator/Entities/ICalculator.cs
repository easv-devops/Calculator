namespace Calculator;

public interface ICalculator
{
    int Result { get; } // property keeping the current result of the calculator
    void Reset(); // resets the current result of the calculator
    int Add(int x); // adds x to the current result
    int Subtract(int x); // subtracts x from the current result
    int Multiply(int x); // multiplies the current result with x
    void Divide(int x); // divides the currents result with x (integer division)
    void Modulus(int x);
}