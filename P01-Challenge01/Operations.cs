using P01_Challenge01.Operation;

namespace P01_Challenge01;

public class Operations
{
  public Sum Sum { get; private set; }
  public Subtract Subtract { get; private set; }
  public Multiply Multiply { get; private set; }
  public Divide Divide { get; private set; }

  public Operations()
  {
    Sum = new Sum();
    Subtract = new Subtract();
    Multiply = new Multiply();
    Divide = new Divide();
  }
}