using AnyBank_ADM.InternalSystem;

namespace AnyBank_ADM.Employees;

public class AccountManager : EmployeeAuthenticable
{
  public AccountManager(string name, string cpf, string login, string password) : base(name, cpf, "Account Manager",
    4000, login, password)
  {
  }

  public override double GetBonification()
  {
    return Salary * 0.25;
  }

  public override double BiannualPremium()
  {
    return Salary + base.BiannualPremium();
  }

  public override void IncreaseSalary()
  {
    Salary *= 1.05;
  }
}