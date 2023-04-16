namespace P01_Challenge01.Operation;

public class Divide
{
  public double DivideNumbers(double num1, double num2)
  {
    if (num2 == 0)
    {
      return 0;
    }

    return num1 / num2;
  }
}