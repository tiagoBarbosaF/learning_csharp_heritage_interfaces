using AnyBank_ADM.InternalSystem;

namespace AnyBank_ADM.Employees;

public class Director : EmployeeAuthenticable
{
  public Director(string name, string cpf, string login, string password) : base(name, cpf, "Director",
    5000, login, password)
  {
  }

  public override double GetBonification()
  {
    return Salary * 0.50;
  }

  public override double BiannualPremium()
  {
    return Salary + base.BiannualPremium();
  }

  public override void IncreaseSalary()
  {
    Salary *= 1.15;
  }
}