using AnyBank_ADM.Employees;

namespace AnyBank_ADM.Utils;

public class ManageBonification
{
  public double TotalBonification { get; private set; }

  public void Record(Employee employee)
  {
    TotalBonification += employee.GetBonification() + employee.BiannualPremium();
  }
}