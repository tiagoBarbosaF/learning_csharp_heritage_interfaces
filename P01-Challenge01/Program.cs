using P01_Challenge01;
using P01_Challenge01.Operation;

Operations operations = new Operations();

Console.WriteLine($"Sum numbers 10 and 20 - {operations.Sum.SumNumbers(10,20)}" +
                  $"\nSubtract numbers 10 and 20 - {operations.Subtract.SubtractNumbers(10,20)}" +
                  $"\nMultiply numbers 10 and 20 - {operations.Multiply.MultiplyNumbers(10,20):F}" +
                  $"\nDivide numbers 10 and 20 - {operations.Divide.DivideNumbers(10,20):F}");