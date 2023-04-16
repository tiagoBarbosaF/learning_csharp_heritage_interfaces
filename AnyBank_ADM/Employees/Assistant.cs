namespace AnyBank_ADM.Employees;

public class Assistant : Employee
{
  public Assistant(string name, string cpf) : base(name, cpf, "Assistant", 2000)
  {
  }

  public override double GetBonification()
  {
    return Salary * 0.20;
  }

  public override double BiannualPremium()
  {
    return Salary + base.BiannualPremium();
  }

  public override void IncreaseSalary()
  {
    Salary *= 1.10;
  }
}