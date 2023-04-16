namespace AnyBank_ADM.Employees;

public class Designer : Employee
{
  public Designer(string name, string cpf) : base(name, cpf, "Designer", 3000)
  {
  }

  public override double GetBonification()
  {
    return Salary * 0.17;
  }

  public override double BiannualPremium()
  {
    return Salary + base.BiannualPremium();
  }

  public override void IncreaseSalary()
  {
    Salary *= 1.11;
  }
}