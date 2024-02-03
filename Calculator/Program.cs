// See https://aka.ms/new-console-template for more information

using Calculator;
using Calculator.Entities;

namespace MyNamespace
{
  public class Program
  {
    public static void Main(String[] args)
    {
      Method method = new Method();
      method.GetMemory();
      Console.WriteLine("Adding 2 to memory...");
      method.MemoryAdd(2);
      method.GetMemory();
        
      Console.WriteLine("Adding 1 to memory");
      method.MemoryAdd(1);
      method.GetMemory();
      
      Console.WriteLine("Substracting 25 from memory");
      method.MemorySubtract(25);
      method.GetMemory();

      Console.WriteLine("Reseting memory");
      method.ResetMemory();
      method.GetMemory();
    }
  }
}
